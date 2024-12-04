namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.UsageContext;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ChangeDataUserTask

	/// <exclude/>
	public partial class ChangeDataUserTask
	{

		#region Methods: Private

		private static void ThrowExceptionIfEmptyFilters(EntitySchemaQueryFilterCollection filters) {
			var message = new LocalizableString("Terrasoft.Core",
				"ProcessSchemaChangeDataUserTask.Exception.ChangeDataWithEmptyFilter");
			ProcessUserTaskUtilities.ThrowExceptionIfEmptyFilters(filters, message);
		}

		private static EntitySchemaQuery GetEntitySchemaQuery(EntitySchemaManager entitySchemaManager,
				EntitySchema entitySchema, bool useUserPermissions) {
			return new EntitySchemaQuery(entitySchemaManager, entitySchema.Name) {
				UseAdminRights = useUserPermissions,
				IgnoreDisplayValues = GlobalAppSettings.FeatureIgnoreDisplayValuesInDataUserTasks
			};
		}

		private void UpdateEntities(EntitySchema entitySchema, bool useUserPermissions) {
			EntitySchemaQuery esq = GetEntitySchemaQuery(UserConnection.EntitySchemaManager, entitySchema,
				useUserPermissions);
			esq.AddAllSchemaColumns();
			if (IsMatchConditions) {
				ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
				EntitySchemaQueryFilterCollection filters = esq.Filters;
				ThrowExceptionIfEmptyFilters(filters);
			}
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			UpdateEntityCollection(entityCollection, entitySchema, useUserPermissions);
		}

		private void UpdateEntity(EntitySchema entitySchema, Entity entity, bool useUserPermissions) {
			string GetDebugInfo(Entity source) {
				var info = new System.Text.StringBuilder();
				try {
					info.Append(source.SchemaName);
					info.Append($" ({source.Schema.PrimaryColumn.Name}: [{source.PrimaryColumnValue}])");
				} catch (Exception) { }
				return info.ToString();
			}
			try {
				foreach (KeyValuePair<string, object> columnValue in RecordColumnValues.Values) {
					EntitySchemaColumn column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
					object value = columnValue.Value;
					if (ProcessUserTaskUtilities.GetIsEmptyLookupOrDateTimeValue(value, column.DataValueType)) {
						value = null;
					}
					entity.UseAdminRights = useUserPermissions;
					entity.SetColumnValue(column, value);
				}
				entity.Save(false);
			} catch (Exception e) when(GetShouldCatchUpdatingException(e)) {
				string debugInfo = GetDebugInfo(entity);
				Log.Error($"An error occurred during process element {this} when updating an entity {debugInfo}", e);
			}
		}

		private bool GetShouldCatchUpdatingException(Exception exception) {
			return !(exception is RecursionDepthLimitExceededException);
		}

		private void UpdateEntitiesByChunks(EntitySchema entitySchema, bool useUserPermissions) {
			EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchemaQuery esq = GetEntitySchemaQuery(entitySchemaManager, entitySchema, useUserPermissions);
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			if (IsMatchConditions) {
				ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, 
					DataSourceFilters);
				EntitySchemaQueryFilterCollection filters = esq.Filters;
				ThrowExceptionIfEmptyFilters(filters);
			}
			IList<object> entityIds = GetEntityIds(esq);
			UpdateEntities(entitySchemaManager, entitySchema, entityIds, useUserPermissions);
		}

		private IList<object> GetEntityIds(EntitySchemaQuery esq) {
			var entityIds = new List<object>();
			esq.ChunkSize = 10_000;
			foreach (EntityCollection collection in esq.GetEntityCollectionIterator(UserConnection)) {
				foreach (Entity entity in collection) {
					entityIds.Add(entity.PrimaryColumnValue);
				}
			}
			return entityIds;
		}

		private void UpdateEntities(EntitySchemaManager entitySchemaManager, EntitySchema entitySchema,
				IList<object> entityIds, bool useUserPermissions) {
			using (UsageContext context = CreateUsageContext()) {
				EntitySchemaQuery esq = GetEntitySchemaQuery(entitySchemaManager, entitySchema, useUserPermissions);
				esq.SetUsageContext(context, CrudOperationType.Update);
				esq.AddAllSchemaColumns();
				string primaryColumnName = entitySchema.PrimaryColumn.Name;
				EntitySchemaQueryFilterCollection filters = esq.Filters;
				IEnumerable<IEnumerable<object>> chunks = entityIds.SplitOnChunks(100);
				foreach (IEnumerable<object> chunk in chunks) {
					IEntitySchemaQueryFilterItem filter =
						esq.CreateFilterWithParameters(FilterComparisonType.Equal, primaryColumnName, chunk);
					filters.Add(filter);
					EntityCollection entities = esq.GetEntityCollection(UserConnection);
					UpdateEntityCollection(entities, entitySchema, useUserPermissions);
					esq.ResetSelectQuery();
					filters.Clear();
				}
			}
		}

		private void UpdateEntityCollection(EntityCollection entityCollection, EntitySchema entitySchema,
				bool useUserPermissions) {
			foreach (Entity entity in entityCollection) {
				UpdateEntity(entitySchema, entity, useUserPermissions);
			}
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc />
		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntitySchemaUId.IsEmpty()) {
				return false;
			}
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			if (RecordColumnValues.Values.Count == 0) {
				return true;
			}
			if (GlobalAppSettings.FeatureUseEntityCollectionChunksInProcessUserTask) {
				UpdateEntitiesByChunks(entitySchema, context.UseUserPermissions);
			} else {
				UpdateEntities(entitySchema, context.UseUserPermissions);
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void UpdateFiltersRightExprMetaDataByParameterValue(Process process,
				DataSourceFilterCollection filters) {
			foreach (IDataSourceFilterItem filter in filters) {
				if (filter is DataSourceFilterCollection dataSourceFilterCollection) {
					UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourceFilterCollection);
					continue;
				}
				var dataSourceFilter = (DataSourceFilter)filter;
				DataSourceFilterExpression rightExpression = dataSourceFilter.RightExpression;
				if (rightExpression?.Type != DataSourceFilterExpressionType.Custom) {
					continue;
				}
				rightExpression.Type = DataSourceFilterExpressionType.Parameter;
				if (rightExpression.Parameters.Count == 2) {
					DataSourceFilterExpressionParametersCollection parameters = rightExpression.Parameters;
					object metaPath = parameters[1].Value;
					parameters[1].Value = process.GetParameterValueByMetaPath((string)metaPath);
					parameters.RemoveAt(0);
				}
				if (dataSourceFilter.SubFilters?.Count > 0) {
					UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourceFilter.SubFilters);
				}
			}
		}

		[Obsolete("8.1.5 | Method is not in use and will be removed in upcoming releases.")]
		public virtual void UpdateEntityCollection(EntityCollection entityCollection, EntitySchema entitySchema) {
			UpdateEntityCollection(entityCollection, entitySchema, false);
		}

		#endregion

	}

	#endregion

}
