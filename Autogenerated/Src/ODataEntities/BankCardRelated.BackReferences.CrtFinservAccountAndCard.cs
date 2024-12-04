namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: BankCardRelated

	/// <exclude/>
	public class BankCardRelated : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public BankCardRelated(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BankCardRelated";
		}

		public BankCardRelated(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "BankCardRelated";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

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
		public Guid BankCardId {
			get {
				return GetTypedColumnValue<Guid>("BankCardId");
			}
			set {
				SetColumnValue("BankCardId", value);
				_bankCard = null;
			}
		}

		/// <exclude/>
		public string BankCardNumber {
			get {
				return GetTypedColumnValue<string>("BankCardNumber");
			}
			set {
				SetColumnValue("BankCardNumber", value);
				if (_bankCard != null) {
					_bankCard.Number = value;
				}
			}
		}

		private BankCard _bankCard;
		/// <summary>
		/// Card.
		/// </summary>
		public BankCard BankCard {
			get {
				return _bankCard ??
					(_bankCard = new BankCard(LookupColumnEntities.GetEntity("BankCard")));
			}
		}

		/// <exclude/>
		public Guid RelatedBankCardId {
			get {
				return GetTypedColumnValue<Guid>("RelatedBankCardId");
			}
			set {
				SetColumnValue("RelatedBankCardId", value);
				_relatedBankCard = null;
			}
		}

		/// <exclude/>
		public string RelatedBankCardNumber {
			get {
				return GetTypedColumnValue<string>("RelatedBankCardNumber");
			}
			set {
				SetColumnValue("RelatedBankCardNumber", value);
				if (_relatedBankCard != null) {
					_relatedBankCard.Number = value;
				}
			}
		}

		private BankCard _relatedBankCard;
		/// <summary>
		/// Linked card.
		/// </summary>
		public BankCard RelatedBankCard {
			get {
				return _relatedBankCard ??
					(_relatedBankCard = new BankCard(LookupColumnEntities.GetEntity("RelatedBankCard")));
			}
		}

		#endregion

	}

	#endregion

}

