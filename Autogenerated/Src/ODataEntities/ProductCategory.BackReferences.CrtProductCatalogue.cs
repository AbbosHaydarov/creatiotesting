namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductCategory

	/// <exclude/>
	public class ProductCategory : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public ProductCategory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductCategory";
		}

		public ProductCategory(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "ProductCategory";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AttributeInSiteEvent> AttributeInSiteEventCollectionByProductCategoryValue {
			get;
			set;
		}

		public IEnumerable<ChangeCriteria> ChangeCriteriaCollectionByProductCategory {
			get;
			set;
		}

		public IEnumerable<DefSpecification> DefSpecificationCollectionByProductCategory {
			get;
			set;
		}

		public IEnumerable<DocListInCondition> DocListInConditionCollectionByProductCategory {
			get;
			set;
		}

		public IEnumerable<DocListInFinApp> DocListInFinAppCollectionByProductCategory {
			get;
			set;
		}

		public IEnumerable<DocumentList> DocumentListCollectionByProductCategory {
			get;
			set;
		}

		public IEnumerable<DocumentListInProduct> DocumentListInProductCollectionByProductCategory {
			get;
			set;
		}

		public IEnumerable<FinApplication> FinApplicationCollectionByProductCategory {
			get;
			set;
		}

		public IEnumerable<Product> ProductCollectionByCategory {
			get;
			set;
		}

		public IEnumerable<ProductKind> ProductKindCollectionByProductCategory {
			get;
			set;
		}

		public IEnumerable<ProductType> ProductTypeCollectionByCategory {
			get;
			set;
		}

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Active processes.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
			}
		}

		/// <exclude/>
		public Guid KindId {
			get {
				return GetTypedColumnValue<Guid>("KindId");
			}
			set {
				SetColumnValue("KindId", value);
				_kind = null;
			}
		}

		/// <exclude/>
		public string KindName {
			get {
				return GetTypedColumnValue<string>("KindName");
			}
			set {
				SetColumnValue("KindName", value);
				if (_kind != null) {
					_kind.Name = value;
				}
			}
		}

		private ProductCategoryKind _kind;
		/// <summary>
		/// Class.
		/// </summary>
		public ProductCategoryKind Kind {
			get {
				return _kind ??
					(_kind = new ProductCategoryKind(LookupColumnEntities.GetEntity("Kind")));
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

	}

	#endregion

}

