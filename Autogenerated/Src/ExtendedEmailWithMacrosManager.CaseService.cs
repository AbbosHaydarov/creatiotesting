namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: ExtendedEmailWithMacrosManager
    
	public class ExtendedEmailWithMacrosManager : ExtendedEmailWithMacrosManagerBase
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="ExtendedEmailWithMacrosManager"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public ExtendedEmailWithMacrosManager(UserConnection userConnection)
			: base(userConnection) {
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Creates an activity and fills it with default values.
		/// </summary>
		/// <returns>Activity entity.</returns>
		protected override Entity CreateActivityEntity() {
			return CreateActivity();
		}

		protected virtual Activity CreateActivity() {
			return base.CreateActivityEntity() as Activity;
		}

		/// <summary>
		/// Fills an <paramref name="activity" /> with given <paramref name="data" />.
		/// </summary>
		/// <param name="activity">Activity entity.</param>
		/// <param name="data">Case data.</param>
		protected override void FillEntityWithCaseData(Entity activity, CaseData data) {
			FillActivityWithCaseData(activity as Activity, data);
		}

		protected virtual void FillActivityWithCaseData(Activity activity, CaseData data) {
			base.FillEntityWithCaseData(activity, data);
		}

		#endregion

	}

	#endregion

}
