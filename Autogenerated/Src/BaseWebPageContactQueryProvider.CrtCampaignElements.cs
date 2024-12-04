namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: BaseWebPageContactQueryProvider

	/// <summary>
	/// Provides base Query models to the specified schemas.
	/// </summary>
	public abstract class BaseWebPageContactQueryProvider
	{

		#region Fields: Private

		/// <summary>
		/// Instance of the <see cref="UserConnection"/>.
		/// </summary>
		protected UserConnection UserConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Constructor for the <see cref="BaseWebPageContactQueryProvider"/>.
		/// </summary>
		/// <param name="userConnection"></param>
		public BaseWebPageContactQueryProvider(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private void RemoveExtraColumns(ref Select contactSelect) {
			var columns = contactSelect.Columns
				.Where(x => x.Alias == "ContactId" || x.Alias == "LinkedEntityId")
				.ToList();
			contactSelect.Columns.Clear();
			contactSelect.Columns.AddRange(columns);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Inner implementation to create contact select model.
		/// </summary>
		/// <param name="schema">Entity schema.</param>
		/// <param name="contactColumn">Name of the contact column.</param>
		/// <param name="filters">Advanced filters for current implementation.</param>
		/// <returns></returns>
		protected virtual ContactSelectModel InternalGetSelectModel(EntitySchema schema, string contactColumn,
				IEnumerable<IEntitySchemaQueryFilterItem> filters) {
			var contactSelect = GetContactSelect(schema.Name, contactColumn, filters);
			return new ContactSelectModel {
				ContactSelect = contactSelect,
				ContactIdColumnName = "ContactId",
				AudienceSchemaUId = schema.UId
			};
		}

		/// <summary>
		/// Returns <see cref="Select"/> query for the current audience.
		/// </summary>
		/// <param name="schemaName">Name of current entity schema.</param>
		/// <param name="contactColumn">Name of the contact column.</param>
		/// <param name="filters">Extended filters for current implementation.</param>
		/// <returns></returns>
		protected virtual Select GetContactSelect(string schemaName, string contactColumn,
				IEnumerable<IEntitySchemaQueryFilterItem> filters) {
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(schemaName);
			var esq = new EntitySchemaQuery(entitySchema) {
				IsDistinct = true
			};
			esq.AddColumn("Id").SetForcedQueryColumnValueAlias("LinkedEntityId");
			esq.AddColumn(contactColumn).SetForcedQueryColumnValueAlias("ContactId");
			var isNotNullContactFilter = esq.CreateIsNotNullFilter(contactColumn);
			esq.Filters.AddRange(new[] {
				isNotNullContactFilter
			}.Concat(filters));
			var contactSelect = esq.GetSelectQuery(UserConnection);
			RemoveExtraColumns(ref contactSelect);
			return contactSelect;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Prepares <see cref="ContactSelectModel"/> with select query and columns list for the specified conditions.
		/// </summary>
		/// <param name="webFormId">The unique identifier of landing.</param>
		/// <returns>An instance of <see cref="ContactSelectModel"/>.</returns>
		/// <exception cref="ArgumentException">In case of schema absence.</exception>
		public abstract ContactSelectModel GetSelectModel(Guid entityId);

		#endregion

	}

	#endregion

}
