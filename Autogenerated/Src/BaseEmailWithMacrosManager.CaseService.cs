namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Core;
	using Core.Entities;
	using Core.Factories;
	using Mail.Sender;
	using System.Text;

	#region Class: BaseEmailWithMacrosManager

	[Obsolete("Current type is used only for the backward compatibility. Use CrtBaseEmailWithMacrosManager instead")]
	public abstract class BaseEmailWithMacrosManager<TMacrosProcessor>: CrtBaseEmailWithMacrosManager<TMacrosProcessor>
		where TMacrosProcessor : Utils.MacrosHelperV2, new()
	{

		#region Constructors: Protected

		protected BaseEmailWithMacrosManager() {
		}

		protected BaseEmailWithMacrosManager(UserConnection userConnection): base(userConnection) {
		} 

		#endregion

		#region Methods: Protected

		protected override sealed Entity CreateActivityEntity() {
			return CreateActivity();
		}

		protected virtual Activity CreateActivity() {
			return base.CreateActivityEntity() as Activity;
		}

		#endregion

	}

	#endregion

}
