namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using global::Common.Logging;

	#region Class: ActualizeFacebookDataExecutor

	public class ActualizeFacebookDataExecutor : IInstallScriptExecutor
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("WebToObject");

		#endregion

		#region Methods: Public

		public void Execute(UserConnection userConnection) {
			try {
				var executor = new ActualizeFacebookWebFormsExecutor();
				executor.Execute(userConnection);
			} catch (Exception ex) {
				_log.Error("Error on running ActualizeFacebookWebFormsExecutor", ex);
			}
		}

		#endregion

	}

	#endregion

}
