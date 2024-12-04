namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: BaseWebAnalyticsDataQueryExecutor

	/// <summary>
	/// Base class to specify creatio web analytics data for the contact specified.
	/// </summary>
	public abstract class BaseWebAnalyticsDataQueryExecutor
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: public

		/// <summary>
		/// Constructor for the <see cref="BaseWebAnalyticsDataQueryExecutor"/>.
		/// </summary>
		/// <param name="userConnection">Instance of the <see cref="UserConnection"/>.</param>
		public BaseWebAnalyticsDataQueryExecutor(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Instance of the <see cref="UserConnection"/>.
		/// </summary>
		protected UserConnection UserConnection => _userConnection;

		/// <summary>
		/// Entity schema name to get data.
		/// </summary>
		protected abstract string EntitySchemaName { get; }

		#endregion

		#region Methods: Private

		private EntitySchemaQueryFilter FindContactIdFilter(EntitySchemaQueryFilterCollection filters) {
			var contactFilter = filters.OfType<EntitySchemaQueryFilter>().FirstOrDefault(filter => {
				EntitySchemaQueryExpression leftExpression = filter.LeftExpression;
				if (leftExpression == null) {
					return false;
				}
				return (leftExpression.ExpressionType == EntitySchemaQueryExpressionType.SchemaColumn
						&& leftExpression.SchemaColumn.ParentMetaSchema?.Name == "Contact"
						&& leftExpression.SchemaColumn.Name == "Id")
					|| (leftExpression.ExpressionType == EntitySchemaQueryExpressionType.SchemaColumn
						&& leftExpression.SchemaColumn.ReferenceSchema?.Name == "Contact"
						&& leftExpression.SchemaColumn.Name == "Contact");
			});
			if (contactFilter != null) {
				return contactFilter;
			}
			foreach (var filterCollection in filters.OfType<EntitySchemaQueryFilterCollection>()) {
				var innerFilter = FindContactIdFilter(filterCollection);
				if (innerFilter != null) {
					return innerFilter;
				}
			}
			return null;
		}

		private EntitySchemaQueryFilterCollection GetSearchFilters(EntitySchemaQueryFilterCollection sourceFilters,
				EntitySchemaQuery esq) {
			var contactFilter = FindContactIdFilter(sourceFilters);
			return GetBaseSearchFilters(sourceFilters, contactFilter, esq);
		}

		private EntitySchemaQueryFilterCollection GetBaseSearchFilters(EntitySchemaQueryFilterCollection sourceFilters,
				EntitySchemaQueryFilter contactFilter, EntitySchemaQuery esq) {
			var filters = new EntitySchemaQueryFilterCollection(esq);
			foreach (var filter in sourceFilters) {
				if (filter == contactFilter) {
					continue;
				}
				var filterCollection = filter as EntitySchemaQueryFilterCollection;
				if (filterCollection != null) {
					filters.Add(GetBaseSearchFilters(filterCollection, contactFilter, esq));
					continue;
				}
				filters.Add(filter);
			}
			return filters;
		}

		private Guid FindContactIdFromFilters(EntitySchemaQueryFilterCollection filters) {
			var contactFilter = FindContactIdFilter(filters);
			Guid.TryParse(contactFilter?.RightExpressions.FirstOrDefault()?.ParameterValue?.ToString(), out var contactId);
			return contactId;
		}

		private EntitySchemaQuery CreateEsqForData(EntitySchemaQuery sourceEsq) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName(EntitySchemaName);
			var esq = new EntitySchemaQuery(schema);
			esq.AddAllSchemaColumns();
			sourceEsq.Columns.ForEach((column) => {
				if (!esq.Columns.ExistsByPath(column.Path) && column.ValueExpression.SubQuery == null) {
					esq.AddColumn(column);
				}
				switch (column.OrderDirection) {
					case OrderDirection.Ascending:
						esq.Columns.FindByName(column.Name)?.OrderByAsc();
						break;
					case OrderDirection.Descending:
						esq.Columns.FindByName(column.Name)?.OrderByDesc();
						break;
					case OrderDirection.None:
					default:
						break;
				}
			});
			return esq;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Returns filter for the contact specified.
		/// </summary>
		/// <param name="esq">Entity schema query instance.</param>
		/// <param name="contactId">Specified contact identifier.</param>
		/// <returns></returns>
		protected abstract EntitySchemaQueryFilterCollection CreateContactFilters(EntitySchemaQuery esq, Guid contactId);

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns collection of specified entity records.
		/// </summary>
		/// <param name="esq">Source entity schema query.</param>
		/// <returns><see cref="EntityCollection"/>.</returns>
		public virtual EntityCollection GetEntityCollection(EntitySchemaQuery esq) {
			var dataEsq = CreateEsqForData(esq);
			var sourceFilters = esq.Filters;
			var baseFilters = GetSearchFilters(sourceFilters, dataEsq);
			dataEsq.Filters.Add(baseFilters);
			var contactId = FindContactIdFromFilters(sourceFilters);
			if (contactId.IsNotEmpty()) {
				var contactFilters = CreateContactFilters(dataEsq, contactId);
				dataEsq.Filters.Add(contactFilters);
			}
			return dataEsq.GetEntityCollection(UserConnection, new EntitySchemaQueryOptions {
				RowsOffset = esq.SkipRowCount,
				PageableRowCount = esq.RowCount,
				PageableDirection = PageableSelectDirection.Current,
				PageableConditionValues = new Dictionary<string, object>()
			});
		}

		#endregion

	}

	#endregion

}
