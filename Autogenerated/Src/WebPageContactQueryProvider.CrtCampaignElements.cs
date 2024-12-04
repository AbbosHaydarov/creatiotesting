namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: WebPageContactQueryProvider

	/// <summary>
	/// Provides Query models to the specified schemas.
	/// </summary>
	public class WebPageContactQueryProvider : BaseWebPageContactQueryProvider
	{

		#region Constructors: Public

		/// <summary>
		/// Constructor for the <see cref="WebPageContactQueryProvider"/>
		/// </summary>
		/// <param name="userConnection">User connection instance.</param>
		public WebPageContactQueryProvider(UserConnection userConnection) : base(userConnection) { }

		#endregion

		#region Properties: Public

		/// <summary>
		/// Column name for web page URL field to filter.
		/// </summary>
		public string PageUrlColumnName {
			get;
			set;
		}

		/// <summary>
		/// Column value for web page URL field to filter.
		/// </summary>
		public string PageUrlColumnValue {
			get;
			set;
		}

		#endregion

		#region Methods: Private

		private void CheckParameters(string contactColumn) {
			if (string.IsNullOrEmpty(contactColumn)) {
				throw new Exception("ContactId column name is not specified");
			}
			if (string.IsNullOrEmpty(PageUrlColumnName)) {
				throw new Exception("PageUrl column name is not specified");
			}
			if (string.IsNullOrEmpty(PageUrlColumnValue)) {
				throw new Exception("Page URL parameter is empty");
			}
		}

		private IEnumerable<IEntitySchemaQueryFilterItem> GetWebPageUrlFilters(EntitySchema schema) {
			var esq = new EntitySchemaQuery(schema);
			return new List<IEntitySchemaQueryFilterItem> {
				esq.CreateFilterWithParameters(FilterComparisonType.Contain, PageUrlColumnName,
					PageUrlColumnValue)
			};
		}

		private (Guid entitySchemaUId, string contactColumn) GetTargetEntityData(Guid entityId) {
			var targetSchemaUIdSelect = new Select(UserConnection)
				.Column("EntityObjectId")
				.Column("ContactColumn")
				.From("CampaignSignalEntity")
				.Where("Id").IsEqual(Column.Parameter(entityId)) as Select;
			targetSchemaUIdSelect.SpecifyNoLockHints();
			var targetSchemaUId = targetSchemaUIdSelect.ExecuteSingleRecord(reader =>
				(
					reader.GetColumnValue<Guid>("EntityObjectId"),
					reader.GetColumnValue<string>("ContactColumn")
				), out (Guid, string) schemaInfo);
			return (schemaInfo.Item1, schemaInfo.Item2);
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="BaseWebPageContactQueryProvider.GetSelectModel(Guid)"/>
		public override ContactSelectModel GetSelectModel(Guid entityId) {
			var entityData = GetTargetEntityData(entityId);
			CheckParameters(entityData.contactColumn);
			var schema = UserConnection.EntitySchemaManager.FindInstanceByUId(entityData.entitySchemaUId);
			if (schema == null) {
				throw new Exception($"Schema for UId = {entityData.entitySchemaUId} was not found");
			}
			var pageUrlFilters = GetWebPageUrlFilters(schema);
			return InternalGetSelectModel(schema, entityData.contactColumn, pageUrlFilters);
		}

		#endregion

	}

	#endregion

}
