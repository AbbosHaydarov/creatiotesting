namespace Terrasoft.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;
    using Terrasoft.Common;
    using Terrasoft.Core.DB;
    using global::Common.Logging;

    #region Class: FolderTreeEntityListener

    /// <summary>
    /// Listener for 'BaseFolder' and 'FolderTree' entity events.
    /// </summary>
    /// <seealso cref="FolderTreeEntityListener" />
    [EntityEventListener(SchemaName = "BaseEntity")]
    [EntityEventListener(SchemaName = "FolderTree")]
    public class FolderTreeEntityListener: BaseEntityEventListener
    {
        
        #region Fields: Private

        private static readonly ILog _log = LogManager.GetLogger("FolderTree");

        #endregion

        #region Methods: Private

        private HierarchicalSelectOptions GetFolderTreeHierarchicalOptions(Guid rootFolderId) {
            var options = new HierarchicalSelectOptions {
                PrimaryColumnName = "Id",
                ParentColumnName = "ParentId",
                SelectType = HierarchicalSelectType.Children
            };
            var startingIdParameter = new QueryParameter("Id", rootFolderId);
            QueryCondition startingCondition = options.StartingPrimaryColumnCondition;
            startingCondition.LeftExpression = new QueryColumnExpression("Id");
            startingCondition.ConditionType = QueryConditionType.Equal;
            startingCondition.RightExpressions.Add(startingIdParameter);
            return options;
        }

        private IEnumerable<Guid> FindRelatedFolders(Entity entity) {
            Select select = new Select(entity.UserConnection)
                .Column("FT", "Id").As("Id")
                .Column("FT", "ParentId").As("ParentId")
                .From(entity.SchemaName).As("FT");
            select.HierarchicalOptions = GetFolderTreeHierarchicalOptions(entity.PrimaryColumnValue);
            return select.ExecuteEnumerable(r => r.GetColumnValue<Guid>("Id")).ToArray();
        }

        private void ClearConfigs(Entity entity) {
            try {
                var folderGuids = FindRelatedFolders(entity);
                new Delete(entity.UserConnection).From("FolderRelatedElConfig").Where("FolderId")
                    .In(Column.Parameters(folderGuids)).Execute();
            } catch (Exception ex) {
                _log.Error($"Delete related setting error: {ex.Message}", ex);
            }
        }

        #endregion

        #region Methods: Public

        /// <summary>
        /// Handles entity Deleting event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityBeforeEventArgs" /> instance containing the
        /// event data.</param>
        public override void OnDeleting(object sender, EntityBeforeEventArgs e) {
            base.OnDeleting(sender, e);
            var entity = (Entity)sender;
            var isNeedClearRelatedConfigs = entity.Schema.Name == "FolderTree" ||
                (entity.Schema.ParentSchema != null && entity.Schema.ParentSchema.Name == "BaseFolder");
            if (!isNeedClearRelatedConfigs) {
                return;
            }
            ClearConfigs(entity);
        }

        #endregion

    }

    #endregion

}

