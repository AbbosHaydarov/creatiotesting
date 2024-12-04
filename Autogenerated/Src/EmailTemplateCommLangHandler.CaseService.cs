namespace Terrasoft.Configuration 
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: EmailTemplateCommLangHandler

	/// <summary>
	/// An abstract e-mail template communication language receiver.
	/// </summary>
	public abstract class EmailTemplateCommLangHandler : EmailTemplateCommLangHandlerBase
	{

		/// <summary>
		/// Case entity.
		/// </summary>
		protected Case CaseEntity {
			get => Entity as Case;
			set => Entity = value;
		}

		/// <summary>
		/// Initialize new instance of <see cref="EmailTemplateCommLangHandler" />.
		/// </summary>
		/// <param name="caseId">Case record identifier.</param>
		/// <param name="userConnection">User connection.</param>
		protected EmailTemplateCommLangHandler(Guid caseId, UserConnection userConnection)
			: base(caseId, userConnection) { }

		/// <summary>
		/// Initialize new instance of <see cref="EmailTemplateCommLangHandler" />.
		/// </summary>
		/// <param name="entity">Entity.</param>
		/// <param name="userConnection">User connection.</param>
		protected EmailTemplateCommLangHandler(Entity entity, UserConnection userConnection)
			: base(entity, userConnection) { }
	}

	#endregion

}
