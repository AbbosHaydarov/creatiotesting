namespace Terrasoft.Configuration
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Web;
    using Terrasoft.Core.DB;
    using Terrasoft.Web.Common;
    using global::Common.Logging;

    #region Class: FolderRelatedElConfigService

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class FolderRelatedElConfigService : BaseService {

        #region Fields: Private

        private static readonly ILog _log = LogManager.GetLogger("FolderTree");

        #endregion
        
        #region Methods: Public

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        [return: MessageParameter(Name = "result")]
        public int Copy(Guid sourceFolderId, Guid targetFolderId) {
            try {
                var select = new Select(UserConnection).Column(new QueryParameter("FolderId", targetFolderId))
                    .Column("ElementName").Column("ClientSchemaName").Column("ElementConfig")
                    .From("FolderRelatedElConfig").Where("FolderId").IsEqual(Column.Parameter(sourceFolderId));
                var insertSelect = new InsertSelect(UserConnection).Into("FolderRelatedElConfig").Set("FolderId")
                    .Set("ElementName").Set("ClientSchemaName").Set("ElementConfig").FromSelect(select);
                return insertSelect.Execute();
            } catch (Exception ex) {
                _log.ErrorFormat("Copy folder settings failed with error: {0}", ex, ex.Message);
                throw;
            }
        }

        #endregion
    }

    #endregion

}

