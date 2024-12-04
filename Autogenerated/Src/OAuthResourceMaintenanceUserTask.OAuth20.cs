namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Common.Logging;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.OAuth20;
	using Terrasoft.Core.Factories;
	using Terrasoft.OAuthIntegration.HealthCheck;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;

	#region Class: OAuthResourceMaintenanceUserTask

	/// <exclude/>
	public partial class OAuthResourceMaintenanceUserTask
	{

		#region Fields: Private
		
		private readonly ILog _log = LogManager.GetLogger("OAuth20");
		#endregion

		#region Methods: Private

		private void RegisterOAuthResource() {
			var healthCheckService = ClassFactory.Get<IOAuthHealthCheckService>();
			var status = healthCheckService.GetHealthStatus();
			LogOAuthHealthCheckStatus(status);
			if (NeedRegisterOAuthResource(status)) {
				OAuthConfigService service = new OAuthConfigService();
				var result = service.AddDefaultResource();
				ValidateResult(result);
			}
		}

		private void LogOAuthHealthCheckStatus(OAuthHealthCheckStatus status) {
			if (status.HasProblem) {
				_log.Info($"OAuth HealthCheck status is: {status.Message}");
			} else {
				_log.Debug($"OAuth HealthCheck status is: {status.Message}");
			}
		}

		private void ValidateResult(AddResourceResponse result) {
			if (!result.Success) {
				var errorMessage = new StringBuilder();
				errorMessage.AppendLine(result.ResponseStatus.ErrorCode);
				errorMessage.AppendLine(result.ResponseStatus.Message);
				errorMessage.AppendLine(result.ResponseStatus.StackTrace);
				_log.Error(errorMessage.ToString());
			}
		}

		private bool NeedRegisterOAuthResource(OAuthHealthCheckStatus status) {
			if (status.HasProblem && status.IsSystemSettingsFilledIn
				&& status.IsIdentityServiceAvailable && status.IsAccessTokenRetrievableForSystemActions 
				&& !status.IsDefaultResourceRegistered) {
				return true;
			}
			return false;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			try {
				RegisterOAuthResource();
			} catch (Exception ex) {
				_log.Error(ex);
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public override ProcessElementNotification GetNotificationData() {
			return base.GetNotificationData();
		}

		#endregion

	}

	#endregion

}