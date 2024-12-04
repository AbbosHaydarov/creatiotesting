 namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: SysModuleInWorkplaceByUITypeQueryExecutor


	[DefaultBinding(typeof(IEntityQueryExecutor), Name = "SysModuleInWorkplaceByUITypeQueryExecutor")]
	public class SysModuleInWorkplaceByUITypeQueryExecutor : BaseWorkplaceSchemaByUITypeQueryExecutor
	{

		#region Constructors: Public

		public SysModuleInWorkplaceByUITypeQueryExecutor(UserConnection userConnection,
			IFreedomUIClientUnitSchemaProvider clientUnitSchemaProvider)
			: base(userConnection, clientUnitSchemaProvider) { }

		#endregion

		#region Properties: Protected

		protected override string TargetEntitySchemaName => "SysModuleInWorkplaceByUIType";
		protected override string ParentEntitySchemaName => "SysModuleInWorkplace";
		protected override string SectionSchemaUIdColumnPath => "SysModule.SectionSchemaUId";

		#endregion

	}

	#endregion

}

