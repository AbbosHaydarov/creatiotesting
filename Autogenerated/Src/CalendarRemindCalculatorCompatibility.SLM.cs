 namespace Terrasoft.Configuration
 {
	using System;
	using Terrasoft.Core;

	public class CalendarRemindCalculator: CalendarRemindCalculatorV2
	{
		#region Constructors: Protected

		protected CalendarRemindCalculator(UserConnection userConnection) : base(userConnection) {}

		#endregion

		#region Properties: Private

		private UserConnection UserConnection { 
			get;
			set;
		}

		#endregion

		#region Properties: Protected

		protected Case Case { 
			private get => CaseEntity as Case;
			set => CaseEntity = value;
		}

		#endregion

		#region Methods: Protected
		
		protected static Case getCaseEntity(UserConnection userConnection, Guid caseId, string[] columnsName) {
			return GetCaseEntity(userConnection, caseId, columnsName) as Case;
		}
		
		#endregion
		
		#region Methods: Public

		public static new CalendarRemindCalculator CreateInstance(UserConnection userConnection, Guid caseId) {
			var caseEntity = getCaseEntity(userConnection, caseId, new[] { "ServiceItemId", "PriorityId" });
			if(caseEntity == null || caseEntity.PriorityId == Guid.Empty) {
				return null;
			}
			return new CalendarRemindCalculator(userConnection) { Case = caseEntity };
		}

		#endregion
	}
     
 }
