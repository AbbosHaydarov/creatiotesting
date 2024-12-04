namespace Terrasoft.Configuration
{
    using System;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;
    using global::Common.Logging;
    using Newtonsoft.Json;
    using Terrasoft.Messaging.Common;

    #region Class: FolderRelatedElConfigEntityListener

    /// <summary>
    /// Listener for 'BaseFolder' and 'FolderRelatedElConfig' entity events.
    /// </summary>
    /// <seealso cref="FolderRelatedElConfigEntityListener" />
    [EntityEventListener(SchemaName = "FolderRelatedElConfig")]
    public class FolderRelatedElConfigEntityListener : BaseEntityEventListener
    {

        #region Fields: Private

        private static readonly ILog _log = LogManager.GetLogger("FolderTree");

        #endregion

        #region Methods: Private

        private void SendNotification(Entity entity) {
            try {
                if (!MsgChannelManager.IsRunning) {
                    return;
                }
                var clientSchemaName = entity.GetTypedColumnValue<string>("ClientSchemaName");
                var schemaInstance = entity.UserConnection.ClientUnitSchemaManager.FindItemByName(clientSchemaName);
                var body = new {
                    FolderId = entity.GetTypedColumnValue<Guid>("FolderId"),
                    UserId = entity.UserConnection.CurrentUser.Id,
                    Name = clientSchemaName,
                    schemaInstance.UId,
                    ManagerName = "ClientUnitSchemaManager"
                };
                var simpleMessage = new SimpleMessage {
                    Body = JsonConvert.SerializeObject(body),
                    Header = {
                        Sender = "FolderTreeRelatedElementConfigsNotifier"
                    }
                };
                MsgChannelManager.Instance.PostToAll(simpleMessage);
            } catch (Exception ex) {
                _log.Error($"Send change notification error: {ex.Message}", ex);
            }
        }

        #endregion

        #region Methods: Public

        /// <summary>
        /// Handles entity Deleted event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs" /> instance containing the
        /// event data.</param>
        public override void OnDeleted(object sender, EntityAfterEventArgs e) {
            base.OnDeleted(sender, e);
            SendNotification((Entity)sender);
        }

        /// <summary>
        /// Handles entity Updated event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs" /> instance containing the
        /// event data.</param>
        public override void OnUpdated(object sender, EntityAfterEventArgs e) {
            base.OnUpdated(sender, e);
            SendNotification((Entity)sender);
        }

        /// <summary>Handles entity Inserted event.</summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs" /> instance containing the event data.</param>
        public override void OnInserted(object sender, EntityAfterEventArgs e) {
            base.OnInserted(sender, e);
            SendNotification((Entity)sender);
        }

        #endregion

    }

    #endregion

}

