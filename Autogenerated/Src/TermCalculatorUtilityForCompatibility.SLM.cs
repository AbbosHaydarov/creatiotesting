namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;

	public class TermCalculator: TermCalculatorV2
	{

		public TermCalculator(UserConnection userConnection, Guid serviceItemId, Guid priorityId)
			: base(userConnection, serviceItemId, priorityId) { }
		
		protected ServiceItem ServiceItem => ServiceItemEntity as ServiceItem;

		protected CasePriority Priority => PriorityEntity as CasePriority; 

		protected Calendar Calendar => CalendarEntity as Calendar;

	}
}
