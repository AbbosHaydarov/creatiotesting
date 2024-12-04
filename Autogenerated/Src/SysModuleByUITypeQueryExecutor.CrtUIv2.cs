namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: SysModuleByUITypeQueryExecutor

	[DefaultBinding(typeof(IEntityQueryExecutor), Name = "SysModuleByUITypeQueryExecutor")]
	public class SysModuleByUITypeQueryExecutor : BaseWorkplaceSchemaByUITypeQueryExecutor
	{

		#region Constructors: Public

		public SysModuleByUITypeQueryExecutor(UserConnection userConnection,
			IFreedomUIClientUnitSchemaProvider clientUnitSchemaProvider)
			: base(userConnection, clientUnitSchemaProvider) { }

		#endregion

		#region Properties: Protected

		protected override string TargetEntitySchemaName => "SysModuleByUIType";
		protected override string ParentEntitySchemaName => "SysModule";
		protected override string SectionSchemaUIdColumnPath => "SectionSchemaUId";

		#endregion

	}

	#endregion

}

