namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AppValQuestionResult

	/// <exclude/>
	public class AppValQuestionResult : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public AppValQuestionResult(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AppValQuestionResult";
		}

		public AppValQuestionResult(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "AppValQuestionResult";
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
		public Guid AppValidationItemId {
			get {
				return GetTypedColumnValue<Guid>("AppValidationItemId");
			}
			set {
				SetColumnValue("AppValidationItemId", value);
				_appValidationItem = null;
			}
		}

		/// <exclude/>
		public string AppValidationItemName {
			get {
				return GetTypedColumnValue<string>("AppValidationItemName");
			}
			set {
				SetColumnValue("AppValidationItemName", value);
				if (_appValidationItem != null) {
					_appValidationItem.Name = value;
				}
			}
		}

		private AppValidationItem _appValidationItem;
		/// <summary>
		/// Validation action.
		/// </summary>
		public AppValidationItem AppValidationItem {
			get {
				return _appValidationItem ??
					(_appValidationItem = new AppValidationItem(LookupColumnEntities.GetEntity("AppValidationItem")));
			}
		}

		/// <summary>
		/// Required.
		/// </summary>
		public bool IsRequired {
			get {
				return GetTypedColumnValue<bool>("IsRequired");
			}
			set {
				SetColumnValue("IsRequired", value);
			}
		}

		/// <summary>
		/// Question.
		/// </summary>
		public string Question {
			get {
				return GetTypedColumnValue<string>("Question");
			}
			set {
				SetColumnValue("Question", value);
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

		/// <exclude/>
		public Guid AppValidationAnswerId {
			get {
				return GetTypedColumnValue<Guid>("AppValidationAnswerId");
			}
			set {
				SetColumnValue("AppValidationAnswerId", value);
				_appValidationAnswer = null;
			}
		}

		/// <exclude/>
		public string AppValidationAnswerName {
			get {
				return GetTypedColumnValue<string>("AppValidationAnswerName");
			}
			set {
				SetColumnValue("AppValidationAnswerName", value);
				if (_appValidationAnswer != null) {
					_appValidationAnswer.Name = value;
				}
			}
		}

		private AppValidationAnswer _appValidationAnswer;
		/// <summary>
		/// Answer.
		/// </summary>
		public AppValidationAnswer AppValidationAnswer {
			get {
				return _appValidationAnswer ??
					(_appValidationAnswer = new AppValidationAnswer(LookupColumnEntities.GetEntity("AppValidationAnswer")));
			}
		}

		/// <exclude/>
		public Guid AppValidationId {
			get {
				return GetTypedColumnValue<Guid>("AppValidationId");
			}
			set {
				SetColumnValue("AppValidationId", value);
				_appValidation = null;
			}
		}

		/// <exclude/>
		public string AppValidationName {
			get {
				return GetTypedColumnValue<string>("AppValidationName");
			}
			set {
				SetColumnValue("AppValidationName", value);
				if (_appValidation != null) {
					_appValidation.Name = value;
				}
			}
		}

		private AppValidation _appValidation;
		/// <summary>
		/// Verification.
		/// </summary>
		public AppValidation AppValidation {
			get {
				return _appValidation ??
					(_appValidation = new AppValidation(LookupColumnEntities.GetEntity("AppValidation")));
			}
		}

		#endregion

	}

	#endregion

}

