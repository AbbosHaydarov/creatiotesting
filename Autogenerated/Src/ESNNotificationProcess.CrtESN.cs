namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Messaging.Common;

	#region Class: ESNNotificationProcessSchema

	/// <exclude/>
	public class ESNNotificationProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ESNNotificationProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ESNNotificationProcessSchema(ESNNotificationProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ESNNotificationProcess";
			UId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3");
			CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3");
			Version = 0;
			PackageUId = new Guid("0d13113a-287e-c0ff-f4f6-cf9ec5dddf35");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateNotificationIdParameterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"NotificationIdParameter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNotificationIdParameterParameter());
		}

		protected virtual void InitializeOnPostCommentedStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d70075ca-9e0b-44df-a779-e59e0e2f85b4"),
				ContainerUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f478e43-a126-41ef-bd27-886141b52843"),
				ContainerUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"b0e78c23-7095-4d59-b8eb-c10243bcd67b",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadCommentedPostUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba9ba9d2-475d-40f2-8404-7ac59bcee891"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,93,111,211,48,20,253,43,85,158,231,41,31,142,147,244,13,141,130,246,0,155,216,196,11,221,195,141,125,211,89,56,31,178,221,65,169,250,223,185,78,182,210,161,162,21,94,64,34,79,241,209,241,241,185,159,219,72,26,112,238,61,180,24,205,163,91,180,22,92,223,248,243,55,218,120,180,111,109,191,30,162,179,200,161,213,96,244,55,84,19,190,80,218,191,6,15,116,101,187,252,161,176,140,230,203,227,26,203,232,108,25,105,143,173,35,14,93,201,243,44,43,243,66,177,60,229,156,113,0,201,106,85,8,38,84,37,68,34,27,89,39,197,196,252,149,248,69,223,14,96,113,122,99,148,111,198,223,219,205,16,168,9,1,114,164,104,215,119,143,96,22,76,184,69,7,181,65,69,103,111,215,72,144,183,186,165,104,240,86,183,120,13,150,222,10,58,125,128,136,212,128,113,129,101,176,241,139,175,131,69,231,116,223,189,100,206,172,219,238,144,77,2,184,63,62,218,137,71,143,129,121,13,254,126,148,184,36,91,187,209,229,171,213,202,226,10,188,126,56,52,241,25,55,35,239,180,252,209,5,69,85,250,8,102,141,7,111,62,143,228,2,6,63,5,52,61,79,4,171,87,247,39,199,186,207,216,75,225,166,4,14,79,228,19,53,143,198,144,10,2,31,2,48,169,60,253,46,163,79,151,238,234,75,135,246,70,222,99,11,83,214,238,206,9,253,9,88,24,108,177,243,243,109,35,120,2,146,75,150,215,101,70,121,76,129,213,73,89,50,192,42,46,235,56,207,242,184,217,209,133,189,161,249,54,77,36,111,170,138,179,26,138,146,113,46,144,209,41,101,74,148,77,26,39,89,85,138,44,92,89,116,94,251,205,212,9,243,173,194,148,199,162,20,44,171,155,148,241,34,175,88,45,26,201,74,44,243,170,142,235,52,151,114,119,55,133,171,221,96,96,243,113,31,213,7,4,53,163,102,14,150,103,33,25,52,89,214,249,89,152,167,89,223,204,40,205,107,227,117,183,34,146,49,40,67,57,67,10,3,189,165,18,192,10,71,225,80,93,146,83,49,54,60,230,192,10,81,43,198,171,36,101,101,33,98,114,166,36,231,149,128,44,78,168,11,195,23,154,165,95,105,9,230,106,64,75,205,56,54,67,124,124,140,158,205,95,40,145,237,123,63,37,126,95,226,155,94,210,34,121,119,96,234,169,163,69,42,203,76,20,25,83,113,158,51,158,20,192,64,240,156,73,169,168,44,77,158,168,148,58,122,71,203,40,100,224,166,95,91,249,56,252,110,218,66,127,180,93,254,194,206,248,157,53,112,116,16,79,25,172,255,108,100,46,213,191,214,217,187,104,247,29,100,60,254,6,91,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9a60810c-41d3-474d-908b-832435849593"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("56642892-05c7-42ae-8a57-ac21482d70bb"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0c54e3ed-b510-44aa-95e8-d5869d6647b7"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3ea11d01-ccd4-45c3-9644-14df37bc5ce0"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd3d7954-cc74-4986-a523-d221d7761c23"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("92450397-12f0-4f17-a75d-d38567c6327b"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,77,45,46,78,76,79,181,50,180,50,212,241,76,177,50,176,50,208,9,72,44,74,205,43,1,49,1,78,75,80,76,29,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("5a1f2b83-ed26-4c92-8480-206a321e9963"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e4064fd-64ed-4abc-8260-c6a14fb6a6c5"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd53a939-0d8c-44b8-9ef1-fc1e8c5694e4"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d146f3f2-4cb7-4239-92bf-c9081aa150f5"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4508d2c7-78c9-422c-977e-5f7441f0ef76"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0cc7df16-22da-417e-b78a-80ea545febad"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15a46e90-2180-4324-bb5b-dcb14fbe07ee"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("720d957d-e275-469f-8956-e925ee0c382a"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d7c50aae-200a-41d3-8177-d3acea16b585"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9702aa85-1629-4ea9-8aa4-2753d1f1692e"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6a3574e7-1c32-41ba-9a16-e9ed315eef65"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f2c99b37-6016-4f45-af48-6e6f1c684e46"),
				ContainerUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddCommentNotificationUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("d2f54b5a-bf50-4842-a4f0-4d72ad23d06c"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"104d30b1-458a-49b9-8464-aef17d78b411",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7f07f8e3-92dd-4b85-b1a9-b8d1a524e5d5"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9abee62b-56b1-4c28-93ae-c885bfff3a39"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("a806be87-94ba-47b4-9129-331e6d19c0a5"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8bbeac4-174d-4926-9467-5e78622c517a"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,219,110,219,70,16,253,21,129,201,163,71,216,251,69,175,137,11,24,112,82,35,78,243,98,251,97,47,179,137,80,138,52,72,170,133,43,232,223,59,164,37,223,218,42,46,218,20,8,234,125,160,200,209,156,217,217,225,57,156,217,84,175,135,155,107,172,22,213,71,236,186,208,183,101,152,191,105,59,156,159,117,109,194,190,159,159,182,41,212,203,223,66,172,241,44,116,97,133,3,118,159,66,189,198,254,116,217,15,71,179,199,176,234,168,122,253,203,244,111,181,184,216,84,39,3,174,126,58,201,20,61,88,244,154,75,6,204,185,12,42,38,13,161,40,15,33,34,227,129,25,175,188,36,112,106,235,245,170,121,135,67,56,11,195,151,106,177,169,166,104,20,32,146,135,230,201,67,12,132,85,34,48,240,201,114,48,38,73,43,140,16,186,216,106,123,84,245,233,11,174,194,180,233,61,152,51,149,37,139,28,148,118,1,148,143,30,156,50,10,2,22,110,179,117,81,113,62,130,119,254,247,192,139,87,23,39,253,143,191,54,216,157,79,113,23,37,212,61,94,205,201,250,196,112,92,227,10,155,97,177,241,88,156,183,9,65,201,82,64,89,145,193,103,171,65,248,224,116,18,18,185,199,45,1,238,170,185,216,232,192,139,136,78,2,102,97,64,37,47,40,61,199,64,48,19,164,224,232,189,145,35,228,184,25,150,195,205,155,169,70,139,13,198,98,98,244,18,92,8,132,10,140,131,103,44,67,50,24,140,13,165,160,224,219,171,87,87,227,193,242,178,191,174,195,205,167,63,158,239,3,134,60,75,237,106,76,30,243,236,186,237,135,89,14,67,152,255,176,236,232,118,73,111,112,214,150,89,135,253,186,30,150,205,103,242,173,107,76,195,178,109,232,141,55,67,72,195,237,22,215,143,216,241,112,147,205,229,45,201,46,171,197,229,95,209,108,247,123,91,212,199,68,123,202,177,203,234,232,178,58,111,215,93,26,35,74,122,120,251,224,116,211,38,147,203,147,199,61,169,200,210,172,235,122,103,121,75,71,221,59,238,205,109,94,150,37,230,147,230,124,207,165,41,10,219,45,248,147,203,126,221,230,246,79,96,239,66,19,62,99,247,158,10,112,159,251,93,150,31,169,140,251,192,81,120,205,44,47,96,49,120,80,104,136,53,153,7,240,220,199,34,173,20,165,136,9,253,1,11,118,216,36,124,156,24,55,17,165,209,28,28,49,5,20,215,36,138,156,25,4,199,100,86,198,201,156,229,14,223,79,213,30,213,188,203,107,44,213,182,218,110,143,30,106,60,57,210,181,84,68,72,83,210,40,81,5,222,160,3,137,54,75,145,93,112,57,28,212,120,182,198,42,148,4,99,36,78,37,132,133,152,92,4,235,181,118,164,143,49,199,127,95,227,147,130,15,137,228,206,225,133,226,255,49,197,61,139,70,199,226,128,149,145,81,92,17,89,173,245,32,148,96,116,19,138,103,246,16,197,159,157,216,115,41,30,76,81,150,27,4,158,144,72,198,233,11,239,152,37,154,162,98,14,117,22,152,216,65,138,59,165,146,38,217,129,45,217,82,128,100,193,241,156,65,19,241,93,180,44,41,93,190,69,27,59,109,219,159,215,215,115,205,82,138,206,57,8,74,81,23,205,24,193,235,60,6,20,201,147,106,179,119,106,46,24,154,140,82,3,105,142,26,139,213,133,206,151,61,72,195,141,115,134,171,100,204,215,218,202,110,191,227,243,247,179,166,29,232,123,154,194,216,50,102,99,31,152,223,183,27,178,220,80,225,167,182,243,210,70,190,203,54,242,28,74,253,45,141,249,172,172,202,49,131,205,154,186,0,205,68,148,139,164,172,180,162,92,185,41,62,186,131,26,67,206,115,136,138,20,194,104,224,84,140,43,226,175,228,96,153,101,44,201,194,121,113,255,175,81,49,32,67,165,83,128,68,67,52,168,130,22,130,244,25,100,136,86,88,135,220,112,251,109,71,197,147,252,34,239,187,245,61,201,59,50,180,142,184,72,234,25,169,147,105,74,140,142,52,158,56,19,74,198,148,141,141,95,147,247,213,246,119,44,76,134,219,103,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f640e209-6e76-4601-93eb-8e3eda7f8505"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8d85b8c-3c7a-44ee-8684-d0653011114c"),
				ContainerUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b16c2a23-8fa1-410c-8bf0-9ded1dcbf5b3"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,203,110,219,48,16,252,149,64,231,48,16,37,74,34,125,43,82,183,200,161,73,208,4,185,196,57,144,212,202,38,42,153,2,73,39,77,13,255,123,151,146,227,58,133,139,184,189,180,245,197,210,96,118,118,246,165,117,162,91,233,253,165,236,32,153,36,183,224,156,244,182,9,103,31,76,27,192,125,116,118,213,39,167,137,7,103,100,107,190,65,61,226,211,218,132,247,50,72,12,89,207,126,40,204,146,201,236,176,198,44,57,157,37,38,64,231,145,131,33,69,153,86,138,211,130,112,149,103,132,113,69,9,23,76,17,224,2,64,65,201,56,99,35,243,87,226,231,182,235,165,131,49,199,32,223,12,143,183,207,125,164,82,4,244,64,49,222,46,183,96,30,77,248,233,82,170,22,106,124,15,110,5,8,5,103,58,172,6,110,77,7,215,210,97,174,168,99,35,132,164,70,182,62,178,90,104,194,244,107,239,192,123,99,151,111,153,107,87,221,114,159,141,2,176,123,221,218,73,7,143,145,121,45,195,98,144,184,64,91,155,193,229,187,249,220,193,92,6,243,184,111,226,11,60,15,188,227,250,135,1,53,78,233,78,182,43,216,203,249,186,146,115,217,135,177,160,49,61,18,156,153,47,142,174,117,215,177,183,202,205,16,236,95,200,71,106,30,172,33,43,17,124,140,192,168,242,242,56,75,238,47,252,213,211,18,220,141,94,64,39,199,174,61,156,33,250,19,48,109,161,131,101,152,172,83,222,48,90,11,65,4,207,57,97,148,75,162,138,74,16,89,209,170,202,170,172,72,75,181,193,128,157,161,201,186,174,210,180,42,180,36,2,82,69,24,171,27,100,99,8,20,8,64,214,240,66,177,205,195,104,220,248,190,149,207,119,59,127,151,240,116,130,91,25,115,159,244,214,7,168,207,62,131,182,174,222,54,62,254,33,45,207,25,175,181,206,8,173,21,186,226,50,35,130,213,26,167,203,53,173,120,33,10,174,113,79,226,47,142,211,206,141,150,237,85,15,14,215,101,24,87,122,120,209,95,93,72,108,162,179,54,140,173,217,13,225,198,106,60,245,79,56,57,57,71,100,111,231,148,166,84,48,93,17,41,104,67,152,46,21,225,153,96,68,167,170,204,115,145,149,148,102,232,10,63,23,113,96,55,118,229,244,246,60,253,248,157,248,163,251,255,11,87,253,59,135,122,240,84,142,89,253,255,118,169,47,234,127,109,71,55,201,230,59,175,169,228,159,199,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("310495bd-78ef-46e8-bd4f-08a98a050897"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb3ef4f3-9764-4095-a7f4-5e41a35ac0ac"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("54c3435c-6332-48a2-a3e3-e3146231388c"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("48f7c6e0-02c8-4675-80b8-8367b0ef9190"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d5e71c2a-4e7a-4bbc-8424-96fac9c00de2"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("062d7511-3234-4dc6-98d1-9a2bd134a872"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,77,45,46,78,76,79,181,50,180,50,212,9,72,44,74,205,43,177,50,176,50,208,113,46,74,77,44,73,77,113,170,4,243,60,83,64,20,0,81,116,18,230,43,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("21c4f994-ba78-446e-9942-d68f20139863"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("66e87786-c605-4fec-b02e-830988bb2e7d"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a122acd7-cc81-49fd-8c39-9aab1b9c747c"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("677eaf70-16e1-4664-bae1-944189695e0b"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8162883-d725-4f4b-b85f-218697d31396"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc9471e4-6058-424b-acd0-8b0ae601c0c6"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e98494ea-7338-4c9a-b507-c8b3dc9be58f"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("e0adb813-1f6d-4072-b83f-eafcb5ba680c"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("49fd90d6-76c8-48f2-8b16-ea83004edbda"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b833533c-49e1-4ebc-ac9f-1a911d02ccc4"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c3db1aa-d065-4619-9e55-0615dfb22975"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fa088023-44c1-4370-afa4-5c6b45d07773"),
				ContainerUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeOnLikeAddedStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4cf7a08-cf11-4efc-aad9-78919c7c9593"),
				ContainerUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f836b77b-679f-4dfa-a647-9a7e89c1ec39"),
				ContainerUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("39c452ee-d582-4fc4-89da-188114ddf6aa"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,93,111,26,49,16,252,43,232,158,99,116,220,151,57,222,170,148,84,145,170,38,42,40,47,33,15,139,189,6,43,119,248,100,155,180,20,241,223,187,190,3,74,42,170,208,74,85,213,123,242,141,198,179,179,235,217,109,36,42,112,238,19,212,24,141,162,41,90,11,206,40,223,191,209,149,71,251,193,154,117,19,93,69,14,173,134,74,127,67,217,225,99,169,253,123,240,64,87,182,179,31,10,179,104,52,59,175,49,139,174,102,145,246,88,59,226,132,43,10,184,44,184,100,113,86,164,44,43,96,192,128,199,49,155,11,153,100,114,14,192,249,112,207,252,133,248,181,169,27,176,216,213,104,229,85,123,156,110,154,64,29,16,32,90,138,118,102,181,7,211,96,194,141,87,48,175,80,210,191,183,107,36,200,91,93,83,55,56,213,53,222,131,165,90,65,199,4,136,72,10,42,23,88,21,42,63,254,218,88,116,78,155,213,91,230,170,117,189,58,101,147,0,30,127,247,118,226,214,99,96,222,131,95,182,18,183,100,107,215,186,124,183,88,88,92,128,215,47,167,38,158,113,211,242,46,155,31,93,144,244,74,15,80,173,241,164,230,235,78,174,161,241,93,67,93,121,34,88,189,88,94,220,235,113,98,111,181,155,16,216,28,200,23,106,158,237,33,41,8,124,9,64,167,114,56,206,162,199,91,119,247,101,133,118,34,150,88,67,55,181,167,62,161,63,1,227,10,107,92,249,209,118,48,231,92,230,89,202,18,57,84,52,199,33,50,16,89,206,210,130,99,206,115,158,169,68,237,232,194,209,208,104,139,153,80,28,226,33,19,106,48,96,25,42,193,0,100,201,248,176,28,148,130,139,50,47,211,221,83,103,92,187,166,130,205,195,209,223,13,162,236,53,198,249,94,165,159,177,7,82,162,236,127,70,97,172,108,95,62,124,225,129,204,66,11,168,238,26,180,20,128,246,1,226,243,209,125,149,249,48,22,107,140,239,154,61,142,117,98,4,45,239,71,42,216,154,58,68,40,33,191,49,79,56,101,38,205,89,166,202,152,65,34,145,165,66,149,89,156,228,133,224,5,89,162,237,15,243,159,152,181,21,251,109,115,221,218,255,209,58,255,131,37,253,157,189,59,155,252,75,146,252,127,102,116,23,190,191,26,184,93,180,251,14,194,141,26,249,99,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab5d3b2f-e2fb-4c08-99ff-2f80f260179f"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eb26905a-bd71-46d4-8d6a-d6ed38d0edde"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c33a347d-db7a-4e6a-919d-dcec7662e460"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9e247ae1-2b40-42ab-805b-c5d6096d9ba4"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a73401c-113f-4c6f-861a-7262b910e6cb"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a2463ef1-b5d5-415d-b646-059986b3a408"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,11,45,78,45,178,50,180,50,212,113,46,74,77,44,73,77,241,207,179,50,176,50,208,9,206,79,206,76,204,241,77,45,46,78,76,79,5,139,120,166,128,40,0,3,32,50,156,47,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				UId = new Guid("d73fb076-b90d-4745-a4b2-fac13c95af7d"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("16d9166d-3ef0-42f4-8408-44ae67b0bbf8"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7375ce45-bc51-437e-87e1-eedd8eff6e54"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe779b3d-abd3-45e1-aeab-f8081843611c"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41b06c6a-fc83-481d-8934-d1b75bfe8a0f"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("074acb9f-4b51-4a71-96b0-a688dc1e4df0"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f30a6c29-f244-4a31-9102-fcea5bed4454"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				UId = new Guid("5556b314-99f0-40b0-8172-959a76296469"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("990df6b1-021b-4232-9284-f92fa22ee682"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("272ed838-6e7e-4ec3-b267-81140797856d"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("daa71dc2-1fb1-4636-bb5a-75c107201ba4"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("489232d2-1dc4-492b-a5a8-1ef8e65ac76c"),
				ContainerUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddLikedNotificationUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("da240fb2-c774-4c74-99fd-2e1fdfae3964"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"104d30b1-458a-49b9-8464-aef17d78b411",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17ac42d2-21e6-4d36-ba16-b249f630b24b"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e8734de8-8d7a-4251-a4ab-c545f58d718b"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("644e1f0f-142c-4e1f-8cad-d8d970d36e91"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("56e0b34b-5e15-42e9-b5c8-2bb82ace64b4"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,75,79,220,72,16,199,191,138,229,228,72,143,250,253,152,43,97,37,36,200,34,72,114,1,14,213,221,213,97,20,99,35,219,179,43,118,52,223,125,203,3,195,107,55,132,236,75,27,9,31,102,236,118,85,117,245,191,235,231,234,85,253,118,188,190,194,122,94,127,192,190,135,161,43,227,108,183,235,113,118,212,119,9,135,97,118,208,37,104,22,191,65,108,240,8,122,184,196,17,251,79,208,44,113,56,88,12,227,78,245,216,173,222,169,223,254,178,121,91,207,79,87,245,254,136,151,31,247,51,69,183,0,214,123,107,152,179,42,48,141,202,177,32,120,102,169,216,144,125,78,80,146,36,231,212,53,203,203,246,16,71,56,130,241,162,158,175,234,77,52,10,144,157,117,228,166,89,224,86,51,45,165,99,49,249,200,92,48,198,71,175,180,48,161,94,239,212,67,186,192,75,216,76,122,239,44,184,206,138,71,193,180,241,192,116,136,129,121,77,97,0,139,112,217,249,168,133,152,156,111,237,239,29,11,52,3,78,111,242,98,184,106,224,250,211,87,13,174,30,137,243,208,100,117,118,163,241,89,61,63,251,154,202,183,255,39,155,228,31,235,252,84,226,179,122,231,172,62,233,150,125,154,34,42,122,120,247,32,183,205,36,27,147,39,143,91,77,105,164,93,54,205,237,200,59,24,97,107,184,29,238,242,162,44,48,239,183,39,91,41,55,81,248,237,197,254,228,103,123,221,228,246,119,220,14,161,133,207,216,191,39,1,238,115,191,203,242,3,201,184,13,28,120,180,38,22,207,120,41,137,105,161,5,243,206,5,38,181,228,116,3,37,112,183,241,62,198,130,61,182,9,255,98,98,199,56,108,212,158,138,249,54,175,73,170,117,189,94,239,60,44,113,140,178,20,41,57,211,64,197,169,5,55,204,91,174,24,150,98,177,184,130,30,213,179,37,238,181,78,6,149,101,174,228,41,64,114,204,139,156,153,161,194,247,209,241,164,77,249,231,75,252,244,205,65,215,125,89,94,205,12,79,41,122,239,25,104,109,152,206,24,89,48,121,10,40,83,176,37,229,224,245,76,199,146,165,151,134,37,7,196,177,80,138,197,16,144,241,108,163,202,49,130,54,226,205,249,115,196,220,205,183,119,242,190,106,187,145,138,45,193,184,232,218,106,130,100,214,44,190,96,174,174,73,241,234,170,27,198,155,88,175,112,253,199,112,69,25,12,119,162,48,135,211,54,163,149,204,103,1,244,205,14,177,40,167,166,74,127,14,174,151,212,210,119,193,21,57,112,233,104,105,24,52,209,238,101,98,81,8,100,89,41,205,3,58,13,81,63,11,23,10,145,201,134,208,224,138,16,229,66,179,136,74,48,199,41,106,82,69,136,226,255,13,184,78,247,135,159,127,109,177,191,209,103,190,233,23,231,51,26,125,50,176,215,224,37,182,227,124,21,74,137,6,146,102,41,27,106,116,211,114,67,148,153,161,145,96,16,180,211,57,172,201,225,174,75,204,87,217,169,18,185,179,132,34,181,84,178,48,164,123,148,172,64,18,42,5,3,197,229,201,101,175,29,23,227,245,238,70,163,249,202,39,107,53,39,69,20,245,100,66,217,69,230,67,178,12,93,54,212,174,233,62,171,245,249,183,96,62,70,200,213,120,129,213,4,110,149,169,152,102,63,45,250,97,172,22,180,119,85,87,170,30,135,101,51,46,218,207,21,109,78,131,105,66,125,118,72,205,142,74,241,149,238,31,146,238,200,209,249,36,21,193,19,38,186,77,96,209,19,226,73,112,169,85,76,217,186,248,93,116,251,76,52,5,42,242,144,29,65,6,190,80,192,233,176,8,128,18,56,183,65,134,103,233,142,65,7,35,18,229,1,137,50,34,31,22,18,133,178,54,41,39,173,148,166,184,255,5,221,73,41,145,75,204,140,39,82,93,71,147,153,47,129,150,11,214,42,146,181,200,156,159,208,237,149,52,222,137,64,31,4,71,233,25,218,178,40,17,153,162,53,7,80,96,185,80,127,164,27,99,177,49,6,197,60,157,188,73,82,46,232,228,60,29,184,45,130,165,211,81,65,41,94,72,247,77,75,158,186,241,139,249,222,237,218,17,210,107,247,254,49,249,22,150,90,163,53,116,160,166,42,161,206,64,124,251,156,57,3,207,21,145,234,85,206,234,91,124,159,175,127,7,154,213,88,85,91,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8010ef15-aad8-4dba-850c-692c850d65b9"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0bd3a304-f122-4a32-b22a-9a226bd873df"),
				ContainerUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadLikedPostUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bb823b89-4655-4e40-9e5c-0e10daf24deb"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,219,48,16,252,21,65,231,48,144,37,234,229,91,145,186,69,14,109,130,38,200,165,206,97,69,46,101,34,212,3,20,157,214,53,252,239,93,74,137,235,20,46,226,246,210,2,213,137,26,12,135,179,207,109,40,12,12,195,71,104,48,156,135,183,104,45,12,157,114,231,239,180,113,104,223,219,110,221,135,103,225,128,86,131,209,223,80,78,248,66,106,247,22,28,208,149,237,242,135,194,50,156,47,143,107,44,195,179,101,168,29,54,3,113,232,10,202,60,65,16,41,43,50,16,140,71,73,206,160,74,115,150,32,207,18,84,113,58,139,227,137,249,43,241,139,174,233,193,226,244,198,40,175,198,227,237,166,247,212,25,1,98,164,232,161,107,159,192,196,155,24,22,45,84,6,37,253,59,187,70,130,156,213,13,69,131,183,186,193,107,176,244,150,215,233,60,68,36,5,102,240,44,131,202,45,190,246,22,135,65,119,237,107,230,204,186,105,15,217,36,128,251,223,39,59,209,232,209,51,175,193,173,70,137,75,178,181,27,93,190,169,107,139,53,56,253,120,104,226,1,55,35,239,180,252,209,5,73,85,186,3,179,198,131,55,95,70,114,1,189,155,2,154,158,39,130,213,245,234,228,88,247,25,123,45,220,152,192,254,153,124,162,230,209,24,226,140,192,71,15,76,42,207,199,101,248,249,114,184,250,210,162,189,17,43,108,96,202,218,253,57,161,63,1,11,131,13,182,110,190,45,149,170,82,16,156,9,153,114,198,75,46,88,89,197,146,97,26,67,138,192,115,46,203,29,93,216,27,154,111,41,243,170,138,242,140,85,101,36,25,49,82,6,188,138,153,2,49,75,68,153,130,202,165,191,178,104,157,118,155,169,19,230,219,66,100,25,143,56,176,36,207,18,198,103,121,197,138,82,100,12,115,153,102,0,116,150,201,238,126,10,87,15,189,129,205,221,62,170,79,8,50,112,43,12,140,126,192,192,103,131,70,203,14,46,240,3,21,116,42,160,60,175,141,211,109,29,80,59,25,20,190,158,231,31,40,249,80,227,40,233,235,74,66,105,84,0,230,165,98,185,154,21,140,39,81,206,74,76,129,101,60,230,60,198,72,197,126,44,118,254,243,109,210,213,90,128,185,234,209,82,27,142,109,16,29,31,160,23,147,231,139,99,187,206,77,41,223,23,247,166,19,180,66,14,77,61,247,178,76,36,231,60,154,49,46,139,152,241,84,150,12,146,42,101,37,175,242,172,204,101,37,84,65,174,104,13,249,208,111,186,181,21,79,99,63,76,251,231,143,246,202,95,216,22,191,179,0,142,142,224,41,35,245,159,13,203,165,252,215,58,123,23,238,190,3,244,220,118,151,85,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df4038dc-6372-4684-8eec-b443a51b08be"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b90f1d0e-459b-4ff2-84b9-84bdd7ae294d"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55f43d53-adf7-49ba-b7fc-3fdfc2fb2ef5"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be6e2286-7b11-4750-807e-4ce55e79daca"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e88fd04-f4da-40e3-b8c4-35afe197eb57"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e49b308-b01a-4375-803d-4e3f3770a686"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,77,45,46,78,76,79,181,50,180,50,212,241,76,177,50,176,50,208,9,72,44,74,205,43,1,49,1,78,75,80,76,29,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("83258719-cd7a-45a9-b2ee-39499a3a6013"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c164263e-1a79-4940-9a57-e2dccc8fa7a0"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("eec87964-39ad-40af-a379-61083fb27433"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2061afa-5a06-4890-9015-495796290789"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("56e6c97a-488f-4add-9847-e81524046833"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e5240fe-f6fb-4a6b-9ab0-214fcca33c93"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ef6b4042-e216-4b4f-a5ee-db4fe2678424"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("8c09f3bd-485d-4bc4-8868-7ed8fdc1494b"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3001471f-45f4-4b10-bb93-e968de3645f2"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e2be980a-5e5d-46f0-b248-73fd2d5c1967"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7eced334-87e9-445d-b4fc-c349d0303875"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e2a3f16-2ed0-4300-85ef-3daad88e98d6"),
				ContainerUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("985f26f9-02d6-49a5-afcc-1da4c66649df"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,77,115,211,48,16,253,43,29,159,171,142,109,201,118,156,27,83,2,211,3,180,67,75,47,164,135,149,180,74,53,216,177,71,82,10,37,147,255,206,202,78,66,203,132,105,224,2,248,98,251,205,211,219,183,95,90,39,170,1,239,223,67,139,201,52,185,65,231,192,119,38,156,189,177,77,64,247,214,117,171,62,57,77,60,58,11,141,253,134,122,196,103,218,134,215,16,128,142,172,231,63,20,230,201,116,126,88,99,158,156,206,19,27,176,245,196,161,35,82,114,201,203,26,152,202,114,195,4,47,74,86,215,233,132,113,33,56,55,92,9,94,195,200,252,149,248,121,215,246,224,112,140,49,200,155,225,243,230,177,143,212,140,0,53,80,172,239,150,91,144,71,19,126,182,4,217,160,166,255,224,86,72,80,112,182,165,108,240,198,182,120,5,142,98,69,157,46,66,68,50,208,248,200,106,208,132,217,215,222,161,247,182,91,190,100,174,89,181,203,167,108,18,192,253,239,214,78,58,120,140,204,43,8,247,131,196,5,217,218,12,46,95,45,22,14,23,16,236,195,83,19,159,241,113,224,29,87,63,58,160,169,75,183,208,172,240,73,204,231,153,156,67,31,198,132,198,240,68,112,118,113,127,116,174,251,138,189,148,110,78,96,191,35,31,169,121,48,135,188,36,240,33,2,163,202,238,115,158,124,186,240,151,95,150,232,174,213,61,182,48,86,237,238,140,208,159,128,89,131,45,46,195,116,61,41,106,35,141,17,44,211,90,49,145,101,130,129,212,57,43,32,173,243,138,163,49,121,181,161,3,123,67,211,181,74,203,10,120,109,88,134,19,42,189,40,12,131,156,215,12,69,10,169,50,40,50,81,110,238,70,227,214,247,13,60,222,238,253,125,164,69,58,137,145,169,42,39,160,53,234,179,15,168,58,167,183,133,143,47,162,41,52,19,37,132,98,192,75,205,132,225,37,155,20,121,206,68,133,144,73,172,121,33,21,205,73,124,98,59,187,133,85,208,92,246,232,104,92,134,118,165,135,7,253,217,134,196,34,186,174,11,99,105,246,77,184,238,20,173,250,187,209,227,96,106,55,115,19,94,113,33,77,201,74,94,1,19,40,11,38,43,157,177,60,213,144,97,46,51,169,42,114,69,215,69,108,216,117,183,114,106,187,158,126,188,39,254,104,255,255,194,86,255,206,162,30,92,149,99,70,255,191,29,234,11,253,175,205,232,38,217,124,7,148,77,44,171,199,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("14407ed4-7b93-4bb0-8947-61bee5163314"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4825dd82-7b93-46dc-930d-b83505b1dfac"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8dbf8aa1-5f3b-4120-a9f7-2ce998b5271d"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97994f7a-bac7-48f6-b00e-124a48fb410b"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4410d85f-c656-4d35-8868-6b0cf395c87f"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd03c654-a7de-4ffc-89fa-6c63a3c8eb4e"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,176,50,212,9,206,79,206,76,204,241,77,45,46,78,76,79,5,138,24,232,120,166,128,40,0,102,106,230,161,38,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe"),
				UId = new Guid("d92065a7-8e79-43e7-9061-f16b60b4846f"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("152ec142-0c82-4d70-a402-a52fef871f70"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b2c24b55-7356-45da-b7fa-06d890b61f98"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1533582a-753c-4ea4-a4b7-fbee9273241e"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4d80d870-a1ef-4838-819a-2b0dfb2ceee5"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("379f0ed1-624c-4682-bc40-71ebf792b7c5"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("264b43ca-f583-4d03-9225-6c4c86add08b"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe"),
				UId = new Guid("5965ef63-7801-4c91-9a41-a15ad70a5605"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("838e5c55-a218-4d7e-8db5-2a2360539a1e"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9af0e793-7b1b-40b6-b726-89e6b53d8b6b"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5bd1a28f-6eb3-4163-9ad0-e598003c1907"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e9dd48c5-c7fe-46e1-b496-5b5dae63c6ee"),
				ContainerUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeOnMentionAddedStartSignalParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c067a39f-1e8f-445f-a239-e40a0cfe4146"),
				ContainerUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("50d03153-866c-49a1-b09f-f3572ef11b73"),
				ContainerUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"99ab74f3-cdbf-4054-83d8-96c433f423fe",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("242ce24d-3ddd-45ff-9b66-b7ca7b504cbc"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,77,111,219,48,12,253,43,129,207,85,33,91,178,108,231,54,116,217,208,195,214,98,45,122,105,122,144,101,202,21,230,47,72,74,183,44,200,127,31,101,167,89,58,100,104,182,203,6,204,39,153,120,124,122,124,36,181,137,84,35,157,251,40,91,136,230,209,45,88,43,93,175,253,249,59,211,120,176,239,109,191,26,162,179,200,129,53,178,49,223,160,154,226,139,202,248,183,210,75,76,217,44,127,48,44,163,249,242,56,199,50,58,91,70,198,67,235,16,131,41,52,206,170,56,203,74,82,229,188,36,156,166,140,20,185,16,132,197,105,197,132,46,69,66,139,9,249,43,242,139,190,29,164,133,233,142,145,94,143,199,219,245,16,160,49,6,212,8,49,174,239,118,65,22,68,184,69,39,203,6,42,252,247,118,5,24,242,214,180,88,13,220,154,22,174,165,197,187,2,79,31,66,8,210,178,113,1,213,128,246,139,175,131,5,231,76,223,189,38,174,89,181,221,33,26,9,96,255,187,147,67,71,141,1,121,45,253,227,72,113,137,178,182,163,202,55,117,109,161,150,222,60,29,138,248,12,235,17,119,154,127,152,80,97,151,238,100,179,130,131,59,95,86,114,33,7,63,21,52,93,143,0,107,234,199,147,107,221,59,246,90,185,9,6,135,103,240,137,156,71,107,72,4,6,159,66,96,98,121,62,46,163,251,75,119,245,165,3,123,163,30,161,149,147,107,15,231,24,253,41,176,104,160,133,206,207,55,130,209,36,214,52,33,32,84,65,184,80,9,201,99,90,18,41,53,231,37,205,179,92,149,91,76,216,11,154,111,170,34,161,34,149,25,201,33,195,20,6,25,41,168,136,137,142,69,41,104,201,115,46,116,72,89,116,222,248,245,52,9,243,141,140,25,23,84,101,68,176,20,27,198,165,38,5,83,64,226,76,39,101,201,43,150,241,106,251,48,149,107,220,208,200,245,221,190,170,79,32,171,89,208,139,94,206,130,25,184,89,214,249,89,216,167,89,175,103,104,243,170,241,166,171,103,56,77,13,168,128,59,255,128,222,203,26,70,198,208,86,228,97,160,243,148,165,156,164,92,113,194,139,68,16,201,69,70,50,29,211,34,137,25,139,147,20,199,47,124,97,74,250,218,40,217,92,13,96,113,10,199,41,160,199,247,231,197,226,133,222,216,190,247,147,227,251,222,222,244,10,95,144,67,81,251,81,46,211,20,13,68,45,37,186,207,115,65,137,204,209,79,149,230,186,72,120,46,21,80,84,133,175,80,40,253,166,95,89,181,219,122,55,61,63,127,244,172,252,133,199,226,119,246,255,232,6,158,178,81,255,217,174,92,86,255,218,100,111,163,237,119,103,52,45,139,84,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0cd58999-5230-4ef3-a513-99389ff530c0"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("99ae8ad0-6499-4567-8c65-86a56bbea68f"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4c952f0e-dffd-4986-846d-384a7af8a09a"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8117a6f-4913-432b-b814-eeab6e96632d"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0dca8765-93e1-4123-8811-6ec3651653bf"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69d9d40d-db8f-43e9-88ae-a3abf24a965a"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,77,45,46,78,76,79,181,50,180,50,212,9,72,44,74,205,43,177,50,176,50,208,241,76,1,81,0,255,202,163,187,29,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("8cc5ccbc-2b9c-463a-9bab-aa349cb77cd2"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c4950dc-eb9d-4ad4-ab50-8fbb9420594b"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("290fc9b4-9025-4e3f-98b9-1747c5e4346a"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("575e6cd5-8a18-469a-9cd6-55e129df411f"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4ae0aeb5-961a-4027-9a0c-5ac3d4a5ac77"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("68d9c290-aed7-4455-8d6c-9b0597a13528"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cb390c3d-53e0-4db5-8ba9-d854ceef7d5e"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				UId = new Guid("e177f00d-bbb5-4a71-96a5-6b3bd5c30c02"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7d9a88fc-ab6e-4c1a-b52c-764cccb74f1a"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ea463a5-4871-446f-af0b-1667f7dedda3"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("48bd0458-36a0-4710-9baf-d55b64ad2ab2"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ad88c443-aa08-4a50-8ab0-0e7f5effc244"),
				ContainerUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddMentionNotificationUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("e037ba80-32fe-4970-89b0-011247b9cfca"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"104d30b1-458a-49b9-8464-aef17d78b411",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa175d01-463f-4eaa-b6dd-6e062b0a9fbe"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("31adc4d6-d5e5-44b1-a41c-9f6561db382d"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("75b974c3-f286-497f-b22e-63339fcad82c"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4772da4a-5d0b-4678-8701-ff35ab251456"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,219,110,219,70,16,134,95,133,96,114,169,21,246,124,208,173,227,2,6,236,212,176,147,220,88,190,216,195,108,76,148,34,13,146,106,225,10,122,247,14,105,201,39,52,74,211,54,5,130,154,23,148,184,220,153,29,254,252,63,206,110,202,183,195,221,45,148,139,242,3,116,157,239,219,60,204,143,218,14,230,231,93,27,161,239,231,167,109,244,117,245,187,15,53,156,251,206,175,96,128,238,147,175,215,208,159,86,253,48,43,158,135,149,179,242,237,175,211,221,114,113,181,41,79,6,88,125,60,73,152,29,20,181,86,240,68,76,162,64,100,8,134,88,19,57,201,146,230,32,60,147,145,42,12,142,109,189,94,53,103,48,248,115,63,220,148,139,77,57,101,195,4,201,104,35,65,72,226,168,150,68,114,110,72,136,54,16,227,148,178,193,10,201,148,43,183,179,178,143,55,176,242,211,162,143,193,140,202,36,104,96,68,42,235,137,116,193,17,43,49,141,135,204,76,50,54,72,198,198,224,221,252,199,192,236,235,30,198,59,169,234,111,107,127,247,233,139,19,110,159,137,243,116,202,102,121,175,241,178,92,44,191,164,242,238,247,114,42,254,185,206,47,37,94,150,179,101,121,217,174,187,56,102,20,120,241,238,73,109,211,34,211,148,23,151,123,77,113,164,89,215,245,110,228,157,31,252,126,226,126,184,77,85,174,32,157,52,151,123,41,167,44,116,119,144,63,57,237,143,251,218,254,73,216,153,111,252,103,232,222,163,0,143,181,63,84,249,1,101,220,39,118,52,104,21,178,37,52,231,72,36,147,12,29,101,28,225,146,83,252,227,179,163,102,138,190,128,12,29,52,17,254,102,97,23,208,79,106,143,102,222,213,53,74,181,45,183,219,217,83,139,27,151,132,201,193,18,47,53,90,28,130,38,62,82,75,152,182,38,139,156,193,2,59,104,113,43,101,84,32,52,49,57,25,124,162,136,140,176,148,136,66,227,219,96,104,148,42,255,251,22,191,122,115,218,182,191,172,111,231,138,198,24,172,29,235,151,138,200,4,129,56,149,198,132,60,58,157,99,114,86,206,173,242,129,202,64,73,214,28,49,116,65,18,11,248,204,24,171,50,174,65,109,210,111,174,15,17,243,176,222,241,229,251,162,105,7,52,91,244,67,213,54,197,8,201,124,5,205,120,1,169,184,107,215,69,133,163,55,80,172,144,13,180,197,125,226,87,210,254,99,210,2,119,138,26,150,137,1,239,208,216,154,19,155,152,39,142,185,144,133,17,60,103,126,136,180,191,98,172,111,34,141,139,172,77,118,142,36,160,1,211,132,128,5,33,250,49,211,196,92,202,202,57,121,144,52,96,44,249,32,145,19,42,40,158,152,36,1,4,35,134,26,74,163,200,140,101,251,61,72,187,58,233,127,254,173,129,238,94,159,197,212,60,174,231,56,250,98,224,184,134,145,131,197,70,11,202,89,166,156,128,142,40,189,198,142,105,25,62,179,247,89,34,133,214,216,24,182,24,240,208,50,22,155,228,56,213,202,227,183,3,80,18,41,192,140,45,147,145,204,116,208,52,72,172,53,143,33,199,200,217,112,119,52,105,180,216,120,38,164,166,248,197,209,66,161,164,210,103,226,68,4,194,76,230,33,224,3,27,153,182,215,95,35,251,2,124,42,118,4,23,9,189,52,255,169,234,250,161,168,240,213,21,109,46,58,232,215,245,80,53,159,11,124,55,53,196,113,222,252,236,21,238,31,24,238,64,1,77,200,5,178,227,70,184,149,35,1,59,2,137,140,114,41,66,76,218,132,111,130,59,101,225,209,115,140,32,102,216,215,51,119,196,5,235,176,225,48,70,153,176,92,50,126,16,238,224,164,83,12,113,9,62,98,69,220,83,226,162,97,68,235,40,12,215,156,171,108,254,95,112,211,132,195,217,140,239,200,140,123,103,133,81,222,43,130,219,140,160,156,22,129,122,249,157,224,62,106,155,193,199,225,181,115,63,28,63,18,220,232,42,220,143,42,220,89,103,224,184,35,69,184,109,74,148,120,75,5,122,202,138,148,196,215,224,190,222,254,1,226,240,5,62,100,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d9562bc-844a-4dc6-86f8-0bfb638f3379"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("80d16d3f-9a20-469c-960b-54cfe5e9b6df"),
				ContainerUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab84c217-21ad-45fe-a710-9a563a7cf619"),
				ContainerUId = new Guid("2e85559f-f12a-47bc-ab83-2d0181bfba46"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaESNNotificationsLaneSet = CreateESNNotificationsLaneSetLaneSet();
			LaneSets.Add(schemaESNNotificationsLaneSet);
			ProcessSchemaLane schemaPostCommentLane = CreatePostCommentLaneLane();
			schemaESNNotificationsLaneSet.Lanes.Add(schemaPostCommentLane);
			ProcessSchemaTerminateEvent terminateprocess = CreateTerminateProcessTerminateEvent();
			FlowElements.Add(terminateprocess);
			ProcessSchemaStartSignalEvent onpostcommentedstartsignal = CreateOnPostCommentedStartSignalStartSignalEvent();
			FlowElements.Add(onpostcommentedstartsignal);
			ProcessSchemaUserTask readcommentedpostusertask = CreateReadCommentedPostUserTaskUserTask();
			FlowElements.Add(readcommentedpostusertask);
			ProcessSchemaUserTask addcommentnotificationusertask = CreateAddCommentNotificationUserTaskUserTask();
			FlowElements.Add(addcommentnotificationusertask);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaStartSignalEvent onlikeaddedstartsignal = CreateOnLikeAddedStartSignalStartSignalEvent();
			FlowElements.Add(onlikeaddedstartsignal);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask addlikednotificationusertask = CreateAddLikedNotificationUserTaskUserTask();
			FlowElements.Add(addlikednotificationusertask);
			ProcessSchemaUserTask readlikedpostusertask = CreateReadLikedPostUserTaskUserTask();
			FlowElements.Add(readlikedpostusertask);
			ProcessSchemaScriptTask sendnotificationscripttask = CreateSendNotificationScriptTaskScriptTask();
			FlowElements.Add(sendnotificationscripttask);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaInclusiveGateway inclusivegateway1 = CreateInclusiveGateway1InclusiveGateway();
			FlowElements.Add(inclusivegateway1);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaStartSignalEvent onmentionaddedstartsignal = CreateOnMentionAddedStartSignalStartSignalEvent();
			FlowElements.Add(onmentionaddedstartsignal);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaUserTask addmentionnotificationusertask = CreateAddMentionNotificationUserTaskUserTask();
			FlowElements.Add(addmentionnotificationusertask);
			ProcessSchemaFormulaTask formulatask3 = CreateFormulaTask3FormulaTask();
			FlowElements.Add(formulatask3);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaFormulaTask formulatask4 = CreateFormulaTask4FormulaTask();
			FlowElements.Add(formulatask4);
			FlowElements.Add(CreateCommentAddedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateLikeAddedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateMentionAddedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateCommentAddedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "CommentAddedSequenceFlow",
				UId = new Guid("0156db7a-f82d-4ed9-a5ef-8530400fce08"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(168, 316),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("b43be58a-f5cb-4c05-9b13-4b8c5b8464c3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(350, 314),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateLikeAddedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "LikeAddedSequenceFlow",
				UId = new Guid("32aa6322-db45-4d67-9c50-41a911ad85c5"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(192, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("bfdef988-ecab-417f-91d7-9a0b65d48de3"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(476, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("125e3237-d312-47eb-a932-945ac6d5edda"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(782, 216),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6a307e4-94ad-4577-b6c1-23185045e859"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("7850594b-b39d-4a6f-abe8-17e96c27fc2b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(825, 242),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(1024, 226),
				SequenceFlowStartPointPosition = new Point(940, 226),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("32d0ae3e-a939-4d47-95b8-8a0fefbe6a8c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b31e7b6c-362c-41a5-9e34-85da4aeff8e1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c62d023f-d7a2-438c-8edc-ec8862fe1137"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(298, 184),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("ad6782a6-6114-4142-b433-ce08d7b4364a"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(294, 388),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow13",
				UId = new Guid("3644824f-fc0f-4f3a-9911-ec3d6c880567"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(803, 301),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("32d0ae3e-a939-4d47-95b8-8a0fefbe6a8c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("d965760d-4fd1-46a1-b3fb-ba8ccfd6f025"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(737, 262),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6a307e4-94ad-4577-b6c1-23185045e859"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("35a7daa0-7cf9-4d50-b40b-d99484b2a4fa"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(656, 234),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("109b1c48-4f13-4d85-b81a-a9a72ece3004"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("7fb09131-0ba8-4de8-9bfb-5a01072bee92"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(788, 194),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("109b1c48-4f13-4d85-b81a-a9a72ece3004"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateMentionAddedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "MentionAddedSequenceFlow",
				UId = new Guid("57280d6b-6f93-4766-bcb4-4b19793e96b2"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(216, 363),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("bb7c2e57-a962-4bca-b5d6-73ab487208a6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(368, 363),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("5f1ffd43-e907-4974-9701-526673cc6cdc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(527, 365),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("633c7a4b-8103-4372-9ed1-991ca224e83d"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(674, 364),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c23bd082-a1cf-453c-b6ea-7067d9f9c0dc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("a0334895-3f8d-43e7-846a-72782b717b40"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(781, 254),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c23bd082-a1cf-453c-b6ea-7067d9f9c0dc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e21c3341-b60d-4cf8-9369-00f996cb958c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("90ef497e-6e18-440d-b80e-d28f2f133509"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(659, 535),
				SequenceFlowStartPointPosition = new Point(142, 535),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2e85559f-f12a-47bc-ab83-2d0181bfba46"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dc6f485e-b8a2-4027-84e9-46cb310090d1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("67a3da84-74e1-4051-9a38-2559e2217ade"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("90ef497e-6e18-440d-b80e-d28f2f133509"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				SequenceFlowEndPointPosition = new Point(813, 253),
				SequenceFlowStartPointPosition = new Point(728, 535),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc6f485e-b8a2-4027-84e9-46cb310090d1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(813, 535));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateESNNotificationsLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaESNNotificationsLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bbb40bf8-7fa3-4cea-89cf-ea95f81755d8"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ESNNotificationsLaneSet",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaESNNotificationsLaneSet;
		}

		protected virtual ProcessSchemaLane CreatePostCommentLaneLane() {
			ProcessSchemaLane schemaPostCommentLane = new ProcessSchemaLane(this) {
				UId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bbb40bf8-7fa3-4cea-89cf-ea95f81755d8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"PostCommentLane",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaPostCommentLane;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("b31e7b6c-362c-41a5-9e34-85da4aeff8e1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"TerminateProcess",
				Position = new Point(1024, 212),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateOnPostCommentedStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"OnPostCommentedStartSignal",
				NewEntityChangedColumns = false,
				Position = new Point(113, 51),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeOnPostCommentedStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadCommentedPostUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadCommentedPostUserTask",
				Position = new Point(358, 37),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadCommentedPostUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddCommentNotificationUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"AddCommentNotificationUserTask",
				Position = new Point(512, 37),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddCommentNotificationUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadDataUserTask1",
				Position = new Point(204, 37),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateOnLikeAddedStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"OnLikeAddedStartSignal",
				NewEntityChangedColumns = false,
				Position = new Point(113, 212),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeOnLikeAddedStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadDataUserTask2",
				Position = new Point(204, 198),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddLikedNotificationUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"AddLikedNotificationUserTask",
				Position = new Point(512, 198),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddLikedNotificationUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLikedPostUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadLikedPostUserTask",
				Position = new Point(358, 198),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadLikedPostUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSendNotificationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("32d0ae3e-a939-4d47-95b8-8a0fefbe6a8c"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"SendNotificationScriptTask",
				Position = new Point(871, 198),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,89,91,111,219,54,20,126,78,128,254,7,205,79,50,96,8,233,101,47,93,157,33,113,147,204,219,146,102,113,156,1,107,138,130,181,232,132,131,46,174,68,37,211,12,255,247,157,67,82,18,73,209,138,156,0,3,138,186,230,185,95,248,157,67,247,129,100,94,145,211,108,146,38,9,93,112,150,38,222,216,155,27,7,63,189,218,127,0,46,154,127,7,82,66,31,189,147,132,51,94,206,22,247,52,38,127,20,52,43,125,83,67,160,51,156,147,132,220,209,108,228,13,78,102,23,23,41,103,75,182,32,200,53,24,174,95,237,239,129,169,163,48,102,201,21,187,187,231,57,24,88,146,40,167,175,246,55,96,21,44,6,151,25,139,73,86,10,51,147,52,42,226,36,152,230,71,209,35,41,243,25,141,192,30,136,240,172,160,202,201,69,70,9,167,225,167,68,242,2,17,149,28,133,161,252,238,15,38,21,195,96,168,68,242,116,193,72,116,78,243,28,252,156,134,219,4,103,58,91,48,13,221,242,215,244,31,222,79,131,250,116,171,145,9,236,235,76,197,221,165,75,22,99,190,155,202,90,200,173,249,146,100,52,225,125,85,74,238,173,153,147,228,221,2,87,42,187,227,215,21,239,152,5,67,127,59,25,188,92,117,52,204,53,80,3,139,251,72,220,143,78,9,201,98,72,93,144,152,118,202,32,131,233,213,34,77,158,242,12,88,106,25,117,109,142,59,50,175,46,206,113,169,199,84,203,117,185,216,72,26,126,214,178,151,247,41,79,251,24,22,140,181,124,250,152,208,108,187,216,39,36,215,204,137,6,60,167,44,226,52,83,18,82,187,60,250,147,241,123,40,57,56,9,95,114,95,30,78,210,120,69,50,150,167,137,72,219,201,247,130,68,0,102,144,132,145,167,195,217,52,172,69,209,40,234,150,10,114,244,202,111,59,224,114,13,1,16,37,207,168,106,88,136,6,65,14,72,22,198,162,52,91,122,134,222,60,152,164,69,2,136,56,246,14,134,30,162,107,70,121,145,37,18,83,65,96,211,182,136,144,174,171,248,124,240,197,134,82,139,5,157,195,84,168,76,223,144,168,160,31,62,2,235,53,139,233,161,111,33,176,168,121,229,108,77,11,126,99,73,136,126,86,114,248,61,248,61,93,144,72,58,174,27,175,120,130,217,138,46,216,178,68,222,70,213,200,212,49,79,114,193,197,104,56,148,17,231,60,99,201,93,19,206,76,126,111,244,194,39,17,81,136,2,207,104,6,8,192,254,165,186,9,100,251,43,77,232,52,89,166,193,156,47,92,181,155,134,118,162,212,236,210,242,228,30,57,125,18,124,86,176,240,208,119,206,170,58,197,206,105,212,71,185,76,145,165,190,25,101,219,13,84,200,251,204,8,76,180,127,202,76,13,192,47,178,102,141,128,237,70,171,233,246,76,107,230,112,124,202,204,11,19,233,26,158,253,76,190,52,169,29,211,213,112,64,206,202,254,70,244,217,218,82,36,103,228,46,157,109,15,223,182,111,98,98,246,247,79,12,209,175,82,170,53,172,119,245,172,153,158,134,95,218,84,238,239,88,107,148,187,85,238,234,166,99,210,187,21,171,105,190,67,38,235,1,255,85,201,218,35,126,7,93,98,234,107,26,96,152,206,202,92,188,48,230,9,227,47,123,192,232,154,158,126,189,160,121,102,172,39,186,188,182,170,216,148,171,52,229,210,52,70,106,12,17,204,184,63,84,251,133,33,164,239,26,22,13,252,124,246,154,3,57,225,100,193,97,215,81,181,24,214,153,197,20,49,170,54,22,195,151,254,219,75,165,164,231,226,146,155,165,172,164,155,157,69,103,16,125,163,31,116,244,77,85,39,99,91,49,95,193,40,61,205,79,33,141,69,6,163,132,124,139,104,232,15,244,13,240,230,205,96,40,189,71,105,219,149,177,245,204,14,38,69,134,208,137,86,28,155,130,84,100,230,97,15,78,32,19,123,214,67,26,7,245,105,154,197,176,211,242,230,159,99,111,18,145,60,63,133,234,165,89,137,222,127,216,42,119,232,163,45,188,25,224,31,220,248,2,101,142,178,187,34,6,7,253,129,233,56,244,130,85,76,76,216,30,38,82,86,196,152,41,206,153,8,79,248,147,120,197,75,127,136,118,127,238,28,246,200,241,190,199,252,178,124,120,145,241,39,173,74,115,106,179,212,131,86,176,106,38,8,149,185,32,69,156,159,194,214,58,133,164,147,100,65,143,75,8,68,94,138,38,176,161,104,74,180,103,60,55,96,19,53,215,79,60,144,240,214,226,19,173,52,141,171,101,211,198,234,17,146,79,218,81,180,34,19,140,87,20,186,58,196,141,184,81,5,59,50,146,182,109,180,134,9,65,173,138,36,206,207,178,180,88,41,155,173,95,137,4,135,133,225,230,221,18,28,199,105,88,226,79,65,117,79,99,199,227,161,143,25,249,200,68,33,224,138,169,129,6,120,246,237,111,168,206,161,204,205,222,90,251,97,104,164,61,125,54,35,147,44,231,95,195,162,6,105,205,166,94,239,35,125,77,169,137,213,79,62,35,199,150,46,153,54,67,241,113,205,120,68,91,209,136,211,190,225,32,208,41,87,235,173,100,35,77,32,138,96,59,217,15,152,25,77,66,55,112,76,47,90,108,187,66,198,220,1,25,109,227,240,250,130,183,29,106,253,252,197,91,219,237,189,17,47,58,143,2,22,138,56,205,151,221,113,89,191,236,36,33,192,212,17,112,102,189,190,29,60,32,168,222,14,222,223,14,214,7,155,91,112,232,118,16,178,124,21,145,242,166,161,188,86,148,149,132,99,113,99,52,242,27,32,111,54,178,35,181,53,203,106,134,81,235,126,137,96,149,179,14,72,233,114,155,133,166,207,213,189,49,253,181,16,163,237,173,19,8,71,93,248,214,65,108,144,105,91,92,216,209,191,194,42,1,49,93,208,71,14,13,146,46,121,128,39,226,47,232,131,7,154,241,224,58,149,161,183,223,157,13,105,184,213,200,150,180,97,184,206,212,105,29,240,218,221,1,144,178,118,142,223,118,229,248,93,213,48,34,61,168,226,199,141,51,231,173,132,182,14,170,156,89,199,91,234,97,85,194,89,45,153,32,61,127,136,4,255,231,37,145,143,56,29,12,229,191,229,179,105,88,129,208,140,197,171,136,42,223,213,12,51,206,124,193,106,28,5,10,240,123,22,191,70,116,51,134,250,166,54,213,55,18,137,199,111,197,49,186,141,223,222,213,245,221,242,227,159,54,61,100,170,53,60,168,14,28,125,44,19,163,149,204,140,182,181,204,78,195,54,211,47,148,84,24,42,112,188,53,75,81,228,60,191,155,220,19,0,226,72,109,33,94,172,62,199,94,139,22,84,155,9,74,78,27,178,183,80,159,227,74,90,238,49,156,198,114,135,49,93,21,1,177,165,95,73,253,0,53,46,34,245,83,223,158,58,13,46,211,156,87,5,55,2,19,226,48,188,224,143,218,135,197,255,248,252,7,43,248,66,45,187,26,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("c6a307e4-94ad-4577-b6c1-23185045e859"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"FormulaTask1",
				Position = new Point(659, 37),
				ResultParameterMetaPath = @"f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,173,14,131,48,20,6,208,135,65,223,229,246,23,168,159,152,218,146,73,82,113,91,190,102,130,34,10,201,4,225,221,135,158,61,201,153,186,233,177,61,191,43,218,59,127,80,37,20,89,54,196,219,165,127,112,95,80,177,238,225,96,73,26,37,9,101,167,13,89,54,160,52,107,71,106,224,34,179,22,157,189,58,175,240,146,38,21,59,90,56,138,183,12,205,35,121,244,158,172,103,69,163,65,162,1,6,179,244,101,112,236,206,216,197,31,234,102,75,234,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway1InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"InclusiveGateway1",
				Position = new Point(785, 198),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("109b1c48-4f13-4d85-b81a-a9a72ece3004"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"FormulaTask2",
				Position = new Point(659, 198),
				ResultParameterMetaPath = @"f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,177,10,195,32,16,128,225,135,201,124,69,79,79,212,189,67,167,22,58,6,135,83,47,116,136,25,76,160,67,200,187,215,185,219,207,7,255,60,205,143,253,249,221,164,191,203,71,26,199,133,215,93,210,109,232,31,220,87,105,178,29,241,20,131,193,6,116,32,170,32,216,234,12,120,36,11,89,107,85,13,57,44,44,215,24,94,220,185,201,33,61,158,94,105,37,139,38,96,174,126,44,153,193,147,42,224,2,150,17,213,81,14,87,154,210,15,163,88,133,182,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadDataUserTask3",
				Position = new Point(204, 352),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateOnMentionAddedStartSignalStartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"OnMentionAddedStartSignal",
				NewEntityChangedColumns = false,
				Position = new Point(113, 366),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeOnMentionAddedStartSignalParameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"ReadDataUserTask4",
				Position = new Point(358, 352),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddMentionNotificationUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"AddMentionNotificationUserTask",
				Position = new Point(512, 352),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddMentionNotificationUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask3FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("c23bd082-a1cf-453c-b6ea-7067d9f9c0dc"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("48ad66af-f62a-4e7d-a95a-4445bfd263b3"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"FormulaTask3",
				Position = new Point(659, 352),
				ResultParameterMetaPath = @"f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,59,14,131,48,12,0,208,195,48,187,34,159,218,33,123,7,166,86,234,136,50,56,137,173,14,192,16,144,58,32,238,94,230,174,79,122,83,55,141,219,243,187,74,123,151,143,44,28,149,231,77,210,237,210,63,120,204,178,200,186,199,195,80,230,64,189,135,234,4,193,27,69,96,205,12,72,72,100,43,7,131,246,188,194,139,27,47,178,75,139,135,173,195,29,109,46,16,188,103,240,181,32,4,212,0,125,214,140,46,168,115,52,156,169,75,63,109,26,49,214,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("2e85559f-f12a-47bc-ab83-2d0181bfba46"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("90ef497e-6e18-440d-b80e-d28f2f133509"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				EntitySchemaUId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(111, 519),
				SerializeToDB = false,
				Size = new Size(31, 31),
				UseBackgroundMode = true,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask4FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("dc6f485e-b8a2-4027-84e9-46cb310090d1"),
				BackgroundModePriority = BackgroundModePriority.Inherited,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a387dbb-63f2-4c09-9a38-d1ce176371c6"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("90ef497e-6e18-440d-b80e-d28f2f133509"),
				CreatedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"),
				Name = @"FormulaTask4",
				Position = new Point(659, 507),
				ResultParameterMetaPath = @"f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,203,187,14,131,48,12,64,209,143,97,118,133,67,222,123,135,78,173,212,17,101,112,130,173,14,132,33,32,117,64,252,123,51,119,61,87,119,30,230,199,254,252,110,220,222,229,195,149,162,208,186,115,186,117,253,131,251,202,149,183,35,158,138,189,49,38,8,8,42,2,237,114,1,202,126,2,181,140,232,49,75,38,109,175,62,188,168,81,229,131,91,60,123,215,69,161,3,133,180,128,54,194,64,14,71,8,100,236,68,174,136,197,112,165,33,253,0,44,207,211,152,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed792714-f7cc-4d65-861b-bf1701dd5157"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("09668c8e-1e00-4d2a-a040-35cd7a7045d1"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("15acea73-0568-4254-95cc-9ac7e24aed39")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("257f42e9-08c7-402e-8ccc-800826314b17"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("982aa7db-afb3-478f-ad21-ce96e46fb25b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("22aaf901-be11-4228-b8c4-b254129c86d7"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("fe67a13d-f941-4162-b1b9-3bbef244841b")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ESNNotificationProcess(userConnection);
		}

		public override object Clone() {
			return new ESNNotificationProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3"));
		}

		#endregion

	}

	#endregion

	#region Class: ESNNotificationProcess

	/// <exclude/>
	public class ESNNotificationProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessPostCommentLane

		/// <exclude/>
		public class ProcessPostCommentLane : ProcessLane
		{

			public ProcessPostCommentLane(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadCommentedPostUserTaskFlowElement

		/// <exclude/>
		public class ReadCommentedPostUserTaskFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCommentedPostUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCommentedPostUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("9ef897ce-43ff-472d-9d75-29a85c23e19e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,93,111,211,48,20,253,43,85,158,231,41,31,142,147,244,13,141,130,246,0,155,216,196,11,221,195,141,125,211,89,56,31,178,221,65,169,250,223,185,78,182,210,161,162,21,94,64,34,79,241,209,241,241,185,159,219,72,26,112,238,61,180,24,205,163,91,180,22,92,223,248,243,55,218,120,180,111,109,191,30,162,179,200,161,213,96,244,55,84,19,190,80,218,191,6,15,116,101,187,252,161,176,140,230,203,227,26,203,232,108,25,105,143,173,35,14,93,201,243,44,43,243,66,177,60,229,156,113,0,201,106,85,8,38,84,37,68,34,27,89,39,197,196,252,149,248,69,223,14,96,113,122,99,148,111,198,223,219,205,16,168,9,1,114,164,104,215,119,143,96,22,76,184,69,7,181,65,69,103,111,215,72,144,183,186,165,104,240,86,183,120,13,150,222,10,58,125,128,136,212,128,113,129,101,176,241,139,175,131,69,231,116,223,189,100,206,172,219,238,144,77,2,184,63,62,218,137,71,143,129,121,13,254,126,148,184,36,91,187,209,229,171,213,202,226,10,188,126,56,52,241,25,55,35,239,180,252,209,5,69,85,250,8,102,141,7,111,62,143,228,2,6,63,5,52,61,79,4,171,87,247,39,199,186,207,216,75,225,166,4,14,79,228,19,53,143,198,144,10,2,31,2,48,169,60,253,46,163,79,151,238,234,75,135,246,70,222,99,11,83,214,238,206,9,253,9,88,24,108,177,243,243,109,35,120,2,146,75,150,215,101,70,121,76,129,213,73,89,50,192,42,46,235,56,207,242,184,217,209,133,189,161,249,54,77,36,111,170,138,179,26,138,146,113,46,144,209,41,101,74,148,77,26,39,89,85,138,44,92,89,116,94,251,205,212,9,243,173,194,148,199,162,20,44,171,155,148,241,34,175,88,45,26,201,74,44,243,170,142,235,52,151,114,119,55,133,171,221,96,96,243,113,31,213,7,4,53,163,102,14,150,103,33,25,52,89,214,249,89,152,167,89,223,204,40,205,107,227,117,183,34,146,49,40,67,57,67,10,3,189,165,18,192,10,71,225,80,93,146,83,49,54,60,230,192,10,81,43,198,171,36,101,101,33,98,114,166,36,231,149,128,44,78,168,11,195,23,154,165,95,105,9,230,106,64,75,205,56,54,67,124,124,140,158,205,95,40,145,237,123,63,37,126,95,226,155,94,210,34,121,119,96,234,169,163,69,42,203,76,20,25,83,113,158,51,158,20,192,64,240,156,73,169,168,44,77,158,168,148,58,122,71,203,40,100,224,166,95,91,249,56,252,110,218,66,127,180,93,254,194,206,248,157,53,112,116,16,79,25,172,255,108,100,46,213,191,214,217,187,104,247,29,100,60,254,6,91,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,77,45,46,78,76,79,181,50,180,50,212,241,76,177,50,176,50,208,9,72,44,74,205,43,1,49,1,78,75,80,76,29,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddCommentNotificationUserTaskFlowElement

		/// <exclude/>
		public class AddCommentNotificationUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddCommentNotificationUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddCommentNotificationUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("0ab2efba-c523-403e-bd25-180fad2a2c61");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Owner = () => (Guid)(((process.ReadCommentedPostUserTask.ResultEntity.IsColumnValueLoaded(process.ReadCommentedPostUserTask.ResultEntity.Schema.Columns.GetByName("CreatedBy").ColumnValueName) ? process.ReadCommentedPostUserTask.ResultEntity.GetTypedColumnValue<Guid>("CreatedById") : Guid.Empty)));
				_recordDefValues_IsRead = () => (bool)(false);
				_recordDefValues_Type = () => (Guid)(new Guid("20e6de35-8b86-475f-bed9-361688614c66"));
				_recordDefValues_SocialMessage = () => (Guid)(((process.ReadCommentedPostUserTask.ResultEntity.IsColumnValueLoaded(process.ReadCommentedPostUserTask.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCommentedPostUserTask.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsRead", () => _recordDefValues_IsRead.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SocialMessage", () => _recordDefValues_SocialMessage.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Owner;
			internal Func<bool> _recordDefValues_IsRead;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_SocialMessage;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,86,219,110,219,70,16,253,21,129,201,163,71,216,251,69,175,137,11,24,112,82,35,78,243,98,251,97,47,179,137,80,138,52,72,170,133,43,232,223,59,164,37,223,218,42,46,218,20,8,234,125,160,200,209,156,217,217,225,57,156,217,84,175,135,155,107,172,22,213,71,236,186,208,183,101,152,191,105,59,156,159,117,109,194,190,159,159,182,41,212,203,223,66,172,241,44,116,97,133,3,118,159,66,189,198,254,116,217,15,71,179,199,176,234,168,122,253,203,244,111,181,184,216,84,39,3,174,126,58,201,20,61,88,244,154,75,6,204,185,12,42,38,13,161,40,15,33,34,227,129,25,175,188,36,112,106,235,245,170,121,135,67,56,11,195,151,106,177,169,166,104,20,32,146,135,230,201,67,12,132,85,34,48,240,201,114,48,38,73,43,140,16,186,216,106,123,84,245,233,11,174,194,180,233,61,152,51,149,37,139,28,148,118,1,148,143,30,156,50,10,2,22,110,179,117,81,113,62,130,119,254,247,192,139,87,23,39,253,143,191,54,216,157,79,113,23,37,212,61,94,205,201,250,196,112,92,227,10,155,97,177,241,88,156,183,9,65,201,82,64,89,145,193,103,171,65,248,224,116,18,18,185,199,45,1,238,170,185,216,232,192,139,136,78,2,102,97,64,37,47,40,61,199,64,48,19,164,224,232,189,145,35,228,184,25,150,195,205,155,169,70,139,13,198,98,98,244,18,92,8,132,10,140,131,103,44,67,50,24,140,13,165,160,224,219,171,87,87,227,193,242,178,191,174,195,205,167,63,158,239,3,134,60,75,237,106,76,30,243,236,186,237,135,89,14,67,152,255,176,236,232,118,73,111,112,214,150,89,135,253,186,30,150,205,103,242,173,107,76,195,178,109,232,141,55,67,72,195,237,22,215,143,216,241,112,147,205,229,45,201,46,171,197,229,95,209,108,247,123,91,212,199,68,123,202,177,203,234,232,178,58,111,215,93,26,35,74,122,120,251,224,116,211,38,147,203,147,199,61,169,200,210,172,235,122,103,121,75,71,221,59,238,205,109,94,150,37,230,147,230,124,207,165,41,10,219,45,248,147,203,126,221,230,246,79,96,239,66,19,62,99,247,158,10,112,159,251,93,150,31,169,140,251,192,81,120,205,44,47,96,49,120,80,104,136,53,153,7,240,220,199,34,173,20,165,136,9,253,1,11,118,216,36,124,156,24,55,17,165,209,28,28,49,5,20,215,36,138,156,25,4,199,100,86,198,201,156,229,14,223,79,213,30,213,188,203,107,44,213,182,218,110,143,30,106,60,57,210,181,84,68,72,83,210,40,81,5,222,160,3,137,54,75,145,93,112,57,28,212,120,182,198,42,148,4,99,36,78,37,132,133,152,92,4,235,181,118,164,143,49,199,127,95,227,147,130,15,137,228,206,225,133,226,255,49,197,61,139,70,199,226,128,149,145,81,92,17,89,173,245,32,148,96,116,19,138,103,246,16,197,159,157,216,115,41,30,76,81,150,27,4,158,144,72,198,233,11,239,152,37,154,162,98,14,117,22,152,216,65,138,59,165,146,38,217,129,45,217,82,128,100,193,241,156,65,19,241,93,180,44,41,93,190,69,27,59,109,219,159,215,215,115,205,82,138,206,57,8,74,81,23,205,24,193,235,60,6,20,201,147,106,179,119,106,46,24,154,140,82,3,105,142,26,139,213,133,206,151,61,72,195,141,115,134,171,100,204,215,218,202,110,191,227,243,247,179,166,29,232,123,154,194,216,50,102,99,31,152,223,183,27,178,220,80,225,167,182,243,210,70,190,203,54,242,28,74,253,45,141,249,172,172,202,49,131,205,154,186,0,205,68,148,139,164,172,180,162,92,185,41,62,186,131,26,67,206,115,136,138,20,194,104,224,84,140,43,226,175,228,96,153,101,44,201,194,121,113,255,175,81,49,32,67,165,83,128,68,67,52,168,130,22,130,244,25,100,136,86,88,135,220,112,251,109,71,197,147,252,34,239,187,245,61,201,59,50,180,142,184,72,234,25,169,147,105,74,140,142,52,158,56,19,74,198,148,141,141,95,147,247,213,246,119,44,76,134,219,103,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "5ca46f1711e94116b7e56dc129a6bce3",
							"BaseElements.AddCommentNotificationUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("0d13113a-287e-c0ff-f4f6-cf9ec5dddf35");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("f641ac4c-5b83-4a2a-b188-ae908b05350f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,203,110,219,48,16,252,149,64,231,48,16,37,74,34,125,43,82,183,200,161,73,208,4,185,196,57,144,212,202,38,42,153,2,73,39,77,13,255,123,151,146,227,58,133,139,184,189,180,245,197,210,96,118,118,246,165,117,162,91,233,253,165,236,32,153,36,183,224,156,244,182,9,103,31,76,27,192,125,116,118,213,39,167,137,7,103,100,107,190,65,61,226,211,218,132,247,50,72,12,89,207,126,40,204,146,201,236,176,198,44,57,157,37,38,64,231,145,131,33,69,153,86,138,211,130,112,149,103,132,113,69,9,23,76,17,224,2,64,65,201,56,99,35,243,87,226,231,182,235,165,131,49,199,32,223,12,143,183,207,125,164,82,4,244,64,49,222,46,183,96,30,77,248,233,82,170,22,106,124,15,110,5,8,5,103,58,172,6,110,77,7,215,210,97,174,168,99,35,132,164,70,182,62,178,90,104,194,244,107,239,192,123,99,151,111,153,107,87,221,114,159,141,2,176,123,221,218,73,7,143,145,121,45,195,98,144,184,64,91,155,193,229,187,249,220,193,92,6,243,184,111,226,11,60,15,188,227,250,135,1,53,78,233,78,182,43,216,203,249,186,146,115,217,135,177,160,49,61,18,156,153,47,142,174,117,215,177,183,202,205,16,236,95,200,71,106,30,172,33,43,17,124,140,192,168,242,242,56,75,238,47,252,213,211,18,220,141,94,64,39,199,174,61,156,33,250,19,48,109,161,131,101,152,172,83,222,48,90,11,65,4,207,57,97,148,75,162,138,74,16,89,209,170,202,170,172,72,75,181,193,128,157,161,201,186,174,210,180,42,180,36,2,82,69,24,171,27,100,99,8,20,8,64,214,240,66,177,205,195,104,220,248,190,149,207,119,59,127,151,240,116,130,91,25,115,159,244,214,7,168,207,62,131,182,174,222,54,62,254,33,45,207,25,175,181,206,8,173,21,186,226,50,35,130,213,26,167,203,53,173,120,33,10,174,113,79,226,47,142,211,206,141,150,237,85,15,14,215,101,24,87,122,120,209,95,93,72,108,162,179,54,140,173,217,13,225,198,106,60,245,79,56,57,57,71,100,111,231,148,166,84,48,93,17,41,104,67,152,46,21,225,153,96,68,167,170,204,115,145,149,148,102,232,10,63,23,113,96,55,118,229,244,246,60,253,248,157,248,163,251,255,11,87,253,59,135,122,240,84,142,89,253,255,118,169,47,234,127,109,71,55,201,230,59,175,169,228,159,199,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,77,45,46,78,76,79,181,50,180,50,212,9,72,44,74,205,43,177,50,176,50,208,113,46,74,77,44,73,77,113,170,4,243,60,83,64,20,0,81,116,18,230,43,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("9ffb5ac4-cd54-494c-9b2d-e52a5ea474d9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,83,93,111,26,49,16,252,43,232,158,99,116,220,151,57,222,170,148,84,145,170,38,42,40,47,33,15,139,189,6,43,119,248,100,155,180,20,241,223,187,190,3,74,42,170,208,74,85,213,123,242,141,198,179,179,235,217,109,36,42,112,238,19,212,24,141,162,41,90,11,206,40,223,191,209,149,71,251,193,154,117,19,93,69,14,173,134,74,127,67,217,225,99,169,253,123,240,64,87,182,179,31,10,179,104,52,59,175,49,139,174,102,145,246,88,59,226,132,43,10,184,44,184,100,113,86,164,44,43,96,192,128,199,49,155,11,153,100,114,14,192,249,112,207,252,133,248,181,169,27,176,216,213,104,229,85,123,156,110,154,64,29,16,32,90,138,118,102,181,7,211,96,194,141,87,48,175,80,210,191,183,107,36,200,91,93,83,55,56,213,53,222,131,165,90,65,199,4,136,72,10,42,23,88,21,42,63,254,218,88,116,78,155,213,91,230,170,117,189,58,101,147,0,30,127,247,118,226,214,99,96,222,131,95,182,18,183,100,107,215,186,124,183,88,88,92,128,215,47,167,38,158,113,211,242,46,155,31,93,144,244,74,15,80,173,241,164,230,235,78,174,161,241,93,67,93,121,34,88,189,88,94,220,235,113,98,111,181,155,16,216,28,200,23,106,158,237,33,41,8,124,9,64,167,114,56,206,162,199,91,119,247,101,133,118,34,150,88,67,55,181,167,62,161,63,1,227,10,107,92,249,209,118,48,231,92,230,89,202,18,57,84,52,199,33,50,16,89,206,210,130,99,206,115,158,169,68,237,232,194,209,208,104,139,153,80,28,226,33,19,106,48,96,25,42,193,0,100,201,248,176,28,148,130,139,50,47,211,221,83,103,92,187,166,130,205,195,209,223,13,162,236,53,198,249,94,165,159,177,7,82,162,236,127,70,97,172,108,95,62,124,225,129,204,66,11,168,238,26,180,20,128,246,1,226,243,209,125,149,249,48,22,107,140,239,154,61,142,117,98,4,45,239,71,42,216,154,58,68,40,33,191,49,79,56,101,38,205,89,166,202,152,65,34,145,165,66,149,89,156,228,133,224,5,89,162,237,15,243,159,152,181,21,251,109,115,221,218,255,209,58,255,131,37,253,157,189,59,155,252,75,146,252,127,102,116,23,190,191,26,184,93,180,251,14,194,141,26,249,99,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,11,45,78,45,178,50,180,50,212,113,46,74,77,44,73,77,241,207,179,50,176,50,208,9,206,79,206,76,204,241,77,45,46,78,76,79,5,139,120,166,128,40,0,3,32,50,156,47,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("93f0b6d7-cabb-47f4-b3eb-20b5b7bf78bb"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddLikedNotificationUserTaskFlowElement

		/// <exclude/>
		public class AddLikedNotificationUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddLikedNotificationUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddLikedNotificationUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("e3294926-e0c2-4d63-8254-b110d3562cae");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_IsRead = () => (bool)(false);
				_recordDefValues_Type = () => (Guid)(new Guid("4bfd2825-c7a9-4133-b99e-0d6b3dbba451"));
				_recordDefValues_SocialMessage = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("SocialMessage").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("SocialMessageId") : Guid.Empty)));
				_recordDefValues_Owner = () => (Guid)(((process.ReadLikedPostUserTask.ResultEntity.IsColumnValueLoaded(process.ReadLikedPostUserTask.ResultEntity.Schema.Columns.GetByName("CreatedBy").ColumnValueName) ? process.ReadLikedPostUserTask.ResultEntity.GetTypedColumnValue<Guid>("CreatedById") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_IsRead", () => _recordDefValues_IsRead.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SocialMessage", () => _recordDefValues_SocialMessage.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<bool> _recordDefValues_IsRead;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_SocialMessage;
			internal Func<Guid> _recordDefValues_Owner;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,75,79,220,72,16,199,191,138,229,228,72,143,250,253,152,43,97,37,36,200,34,72,114,1,14,213,221,213,97,20,99,35,219,179,43,118,52,223,125,203,3,195,107,55,132,236,75,27,9,31,102,236,118,85,117,245,191,235,231,234,85,253,118,188,190,194,122,94,127,192,190,135,161,43,227,108,183,235,113,118,212,119,9,135,97,118,208,37,104,22,191,65,108,240,8,122,184,196,17,251,79,208,44,113,56,88,12,227,78,245,216,173,222,169,223,254,178,121,91,207,79,87,245,254,136,151,31,247,51,69,183,0,214,123,107,152,179,42,48,141,202,177,32,120,102,169,216,144,125,78,80,146,36,231,212,53,203,203,246,16,71,56,130,241,162,158,175,234,77,52,10,144,157,117,228,166,89,224,86,51,45,165,99,49,249,200,92,48,198,71,175,180,48,161,94,239,212,67,186,192,75,216,76,122,239,44,184,206,138,71,193,180,241,192,116,136,129,121,77,97,0,139,112,217,249,168,133,152,156,111,237,239,29,11,52,3,78,111,242,98,184,106,224,250,211,87,13,174,30,137,243,208,100,117,118,163,241,89,61,63,251,154,202,183,255,39,155,228,31,235,252,84,226,179,122,231,172,62,233,150,125,154,34,42,122,120,247,32,183,205,36,27,147,39,143,91,77,105,164,93,54,205,237,200,59,24,97,107,184,29,238,242,162,44,48,239,183,39,91,41,55,81,248,237,197,254,228,103,123,221,228,246,119,220,14,161,133,207,216,191,39,1,238,115,191,203,242,3,201,184,13,28,120,180,38,22,207,120,41,137,105,161,5,243,206,5,38,181,228,116,3,37,112,183,241,62,198,130,61,182,9,255,98,98,199,56,108,212,158,138,249,54,175,73,170,117,189,94,239,60,44,113,140,178,20,41,57,211,64,197,169,5,55,204,91,174,24,150,98,177,184,130,30,213,179,37,238,181,78,6,149,101,174,228,41,64,114,204,139,156,153,161,194,247,209,241,164,77,249,231,75,252,244,205,65,215,125,89,94,205,12,79,41,122,239,25,104,109,152,206,24,89,48,121,10,40,83,176,37,229,224,245,76,199,146,165,151,134,37,7,196,177,80,138,197,16,144,241,108,163,202,49,130,54,226,205,249,115,196,220,205,183,119,242,190,106,187,145,138,45,193,184,232,218,106,130,100,214,44,190,96,174,174,73,241,234,170,27,198,155,88,175,112,253,199,112,69,25,12,119,162,48,135,211,54,163,149,204,103,1,244,205,14,177,40,167,166,74,127,14,174,151,212,210,119,193,21,57,112,233,104,105,24,52,209,238,101,98,81,8,100,89,41,205,3,58,13,81,63,11,23,10,145,201,134,208,224,138,16,229,66,179,136,74,48,199,41,106,82,69,136,226,255,13,184,78,247,135,159,127,109,177,191,209,103,190,233,23,231,51,26,125,50,176,215,224,37,182,227,124,21,74,137,6,146,102,41,27,106,116,211,114,67,148,153,161,145,96,16,180,211,57,172,201,225,174,75,204,87,217,169,18,185,179,132,34,181,84,178,48,164,123,148,172,64,18,42,5,3,197,229,201,101,175,29,23,227,245,238,70,163,249,202,39,107,53,39,69,20,245,100,66,217,69,230,67,178,12,93,54,212,174,233,62,171,245,249,183,96,62,70,200,213,120,129,213,4,110,149,169,152,102,63,45,250,97,172,22,180,119,85,87,170,30,135,101,51,46,218,207,21,109,78,131,105,66,125,118,72,205,142,74,241,149,238,31,146,238,200,209,249,36,21,193,19,38,186,77,96,209,19,226,73,112,169,85,76,217,186,248,93,116,251,76,52,5,42,242,144,29,65,6,190,80,192,233,176,8,128,18,56,183,65,134,103,233,142,65,7,35,18,229,1,137,50,34,31,22,18,133,178,54,41,39,173,148,166,184,255,5,221,73,41,145,75,204,140,39,82,93,71,147,153,47,129,150,11,214,42,146,181,200,156,159,208,237,149,52,222,137,64,31,4,71,233,25,218,178,40,17,153,162,53,7,80,96,185,80,127,164,27,99,177,49,6,197,60,157,188,73,82,46,232,228,60,29,184,45,130,165,211,81,65,41,94,72,247,77,75,158,186,241,139,249,222,237,218,17,210,107,247,254,49,249,22,150,90,163,53,116,160,166,42,161,206,64,124,251,156,57,3,207,21,145,234,85,206,234,91,124,159,175,127,7,154,213,88,85,91,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "5ca46f1711e94116b7e56dc129a6bce3",
							"BaseElements.AddLikedNotificationUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("0d13113a-287e-c0ff-f4f6-cf9ec5dddf35");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadLikedPostUserTaskFlowElement

		/// <exclude/>
		public class ReadLikedPostUserTaskFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLikedPostUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLikedPostUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("c331dfbd-0c62-4b5d-8f9f-ba6630e7f2dd");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,219,48,16,252,21,65,231,48,144,37,234,229,91,145,186,69,14,109,130,38,200,165,206,97,69,46,101,34,212,3,20,157,214,53,252,239,93,74,137,235,20,46,226,246,210,2,213,137,26,12,135,179,207,109,40,12,12,195,71,104,48,156,135,183,104,45,12,157,114,231,239,180,113,104,223,219,110,221,135,103,225,128,86,131,209,223,80,78,248,66,106,247,22,28,208,149,237,242,135,194,50,156,47,143,107,44,195,179,101,168,29,54,3,113,232,10,202,60,65,16,41,43,50,16,140,71,73,206,160,74,115,150,32,207,18,84,113,58,139,227,137,249,43,241,139,174,233,193,226,244,198,40,175,198,227,237,166,247,212,25,1,98,164,232,161,107,159,192,196,155,24,22,45,84,6,37,253,59,187,70,130,156,213,13,69,131,183,186,193,107,176,244,150,215,233,60,68,36,5,102,240,44,131,202,45,190,246,22,135,65,119,237,107,230,204,186,105,15,217,36,128,251,223,39,59,209,232,209,51,175,193,173,70,137,75,178,181,27,93,190,169,107,139,53,56,253,120,104,226,1,55,35,239,180,252,209,5,73,85,186,3,179,198,131,55,95,70,114,1,189,155,2,154,158,39,130,213,245,234,228,88,247,25,123,45,220,152,192,254,153,124,162,230,209,24,226,140,192,71,15,76,42,207,199,101,248,249,114,184,250,210,162,189,17,43,108,96,202,218,253,57,161,63,1,11,131,13,182,110,190,45,149,170,82,16,156,9,153,114,198,75,46,88,89,197,146,97,26,67,138,192,115,46,203,29,93,216,27,154,111,41,243,170,138,242,140,85,101,36,25,49,82,6,188,138,153,2,49,75,68,153,130,202,165,191,178,104,157,118,155,169,19,230,219,66,100,25,143,56,176,36,207,18,198,103,121,197,138,82,100,12,115,153,102,0,116,150,201,238,126,10,87,15,189,129,205,221,62,170,79,8,50,112,43,12,140,126,192,192,103,131,70,203,14,46,240,3,21,116,42,160,60,175,141,211,109,29,80,59,25,20,190,158,231,31,40,249,80,227,40,233,235,74,66,105,84,0,230,165,98,185,154,21,140,39,81,206,74,76,129,101,60,230,60,198,72,197,126,44,118,254,243,109,210,213,90,128,185,234,209,82,27,142,109,16,29,31,160,23,147,231,139,99,187,206,77,41,223,23,247,166,19,180,66,14,77,61,247,178,76,36,231,60,154,49,46,139,152,241,84,150,12,146,42,101,37,175,242,172,204,101,37,84,65,174,104,13,249,208,111,186,181,21,79,99,63,76,251,231,143,246,202,95,216,22,191,179,0,142,142,224,41,35,245,159,13,203,165,252,215,58,123,23,238,190,3,244,220,118,151,85,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,77,45,46,78,76,79,181,50,180,50,212,241,76,177,50,176,50,208,9,72,44,74,205,43,1,49,1,78,75,80,76,29,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("63021f02-e6c9-46c2-810b-aaf44b0878cb");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,213,84,77,115,211,48,16,253,43,29,159,171,142,109,201,118,156,27,83,2,211,3,180,67,75,47,164,135,149,180,74,53,216,177,71,82,10,37,147,255,206,202,78,66,203,132,105,224,2,248,98,251,205,211,219,183,95,90,39,170,1,239,223,67,139,201,52,185,65,231,192,119,38,156,189,177,77,64,247,214,117,171,62,57,77,60,58,11,141,253,134,122,196,103,218,134,215,16,128,142,172,231,63,20,230,201,116,126,88,99,158,156,206,19,27,176,245,196,161,35,82,114,201,203,26,152,202,114,195,4,47,74,86,215,233,132,113,33,56,55,92,9,94,195,200,252,149,248,121,215,246,224,112,140,49,200,155,225,243,230,177,143,212,140,0,53,80,172,239,150,91,144,71,19,126,182,4,217,160,166,255,224,86,72,80,112,182,165,108,240,198,182,120,5,142,98,69,157,46,66,68,50,208,248,200,106,208,132,217,215,222,161,247,182,91,190,100,174,89,181,203,167,108,18,192,253,239,214,78,58,120,140,204,43,8,247,131,196,5,217,218,12,46,95,45,22,14,23,16,236,195,83,19,159,241,113,224,29,87,63,58,160,169,75,183,208,172,240,73,204,231,153,156,67,31,198,132,198,240,68,112,118,113,127,116,174,251,138,189,148,110,78,96,191,35,31,169,121,48,135,188,36,240,33,2,163,202,238,115,158,124,186,240,151,95,150,232,174,213,61,182,48,86,237,238,140,208,159,128,89,131,45,46,195,116,61,41,106,35,141,17,44,211,90,49,145,101,130,129,212,57,43,32,173,243,138,163,49,121,181,161,3,123,67,211,181,74,203,10,120,109,88,134,19,42,189,40,12,131,156,215,12,69,10,169,50,40,50,81,110,238,70,227,214,247,13,60,222,238,253,125,164,69,58,137,145,169,42,39,160,53,234,179,15,168,58,167,183,133,143,47,162,41,52,19,37,132,98,192,75,205,132,225,37,155,20,121,206,68,133,144,73,172,121,33,21,205,73,124,98,59,187,133,85,208,92,246,232,104,92,134,118,165,135,7,253,217,134,196,34,186,174,11,99,105,246,77,184,238,20,173,250,187,209,227,96,106,55,115,19,94,113,33,77,201,74,94,1,19,40,11,38,43,157,177,60,213,144,97,46,51,169,42,114,69,215,69,108,216,117,183,114,106,187,158,126,188,39,254,104,255,255,194,86,255,206,162,30,92,149,99,70,255,191,29,234,11,253,175,205,232,38,217,124,7,148,77,44,171,199,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,176,50,212,9,206,79,206,76,204,241,77,45,46,78,76,79,5,138,24,232,120,166,128,40,0,102,106,230,161,38,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("99ab74f3-cdbf-4054-83d8-96c433f423fe"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("b5abaf4a-f9f0-466b-b826-7a4745708a79");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,77,111,219,48,12,253,43,129,207,85,33,91,178,108,231,54,116,217,208,195,214,98,45,122,105,122,144,101,202,21,230,47,72,74,183,44,200,127,31,101,167,89,58,100,104,182,203,6,204,39,153,120,124,122,124,36,181,137,84,35,157,251,40,91,136,230,209,45,88,43,93,175,253,249,59,211,120,176,239,109,191,26,162,179,200,129,53,178,49,223,160,154,226,139,202,248,183,210,75,76,217,44,127,48,44,163,249,242,56,199,50,58,91,70,198,67,235,16,131,41,52,206,170,56,203,74,82,229,188,36,156,166,140,20,185,16,132,197,105,197,132,46,69,66,139,9,249,43,242,139,190,29,164,133,233,142,145,94,143,199,219,245,16,160,49,6,212,8,49,174,239,118,65,22,68,184,69,39,203,6,42,252,247,118,5,24,242,214,180,88,13,220,154,22,174,165,197,187,2,79,31,66,8,210,178,113,1,213,128,246,139,175,131,5,231,76,223,189,38,174,89,181,221,33,26,9,96,255,187,147,67,71,141,1,121,45,253,227,72,113,137,178,182,163,202,55,117,109,161,150,222,60,29,138,248,12,235,17,119,154,127,152,80,97,151,238,100,179,130,131,59,95,86,114,33,7,63,21,52,93,143,0,107,234,199,147,107,221,59,246,90,185,9,6,135,103,240,137,156,71,107,72,4,6,159,66,96,98,121,62,46,163,251,75,119,245,165,3,123,163,30,161,149,147,107,15,231,24,253,41,176,104,160,133,206,207,55,130,209,36,214,52,33,32,84,65,184,80,9,201,99,90,18,41,53,231,37,205,179,92,149,91,76,216,11,154,111,170,34,161,34,149,25,201,33,195,20,6,25,41,168,136,137,142,69,41,104,201,115,46,116,72,89,116,222,248,245,52,9,243,141,140,25,23,84,101,68,176,20,27,198,165,38,5,83,64,226,76,39,101,201,43,150,241,106,251,48,149,107,220,208,200,245,221,190,170,79,32,171,89,208,139,94,206,130,25,184,89,214,249,89,216,167,89,175,103,104,243,170,241,166,171,103,56,77,13,168,128,59,255,128,222,203,26,70,198,208,86,228,97,160,243,148,165,156,164,92,113,194,139,68,16,201,69,70,50,29,211,34,137,25,139,147,20,199,47,124,97,74,250,218,40,217,92,13,96,113,10,199,41,160,199,247,231,197,226,133,222,216,190,247,147,227,251,222,222,244,10,95,144,67,81,251,81,46,211,20,13,68,45,37,186,207,115,65,137,204,209,79,149,230,186,72,120,46,21,80,84,133,175,80,40,253,166,95,89,181,219,122,55,61,63,127,244,172,252,133,199,226,119,246,255,232,6,158,178,81,255,217,174,92,86,255,218,100,111,163,237,119,103,52,45,139,84,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,77,45,46,78,76,79,181,50,180,50,212,9,72,44,74,205,43,177,50,176,50,208,241,76,1,81,0,255,202,163,187,29,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddMentionNotificationUserTaskFlowElement

		/// <exclude/>
		public class AddMentionNotificationUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddMentionNotificationUserTaskFlowElement(UserConnection userConnection, ESNNotificationProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddMentionNotificationUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("17ba8704-d3e6-41f6-afba-676772da8162");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_IsRead = () => (bool)(false);
				_recordDefValues_Type = () => (Guid)(new Guid("85ab04b0-f624-49b4-8eb8-0cc5fb4108d6"));
				_recordDefValues_SocialMessage = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("SocialMessage").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("SocialMessageId") : Guid.Empty)));
				_recordDefValues_Owner = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_IsRead", () => _recordDefValues_IsRead.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SocialMessage", () => _recordDefValues_SocialMessage.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Owner", () => _recordDefValues_Owner.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<bool> _recordDefValues_IsRead;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_SocialMessage;
			internal Func<Guid> _recordDefValues_Owner;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("104d30b1-458a-49b9-8464-aef17d78b411");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _recordAddMode;
			public override string RecordAddMode {
				get {
					return _recordAddMode ?? (_recordAddMode = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,51,0,0,33,223,219,244,1,0,0,0 })));
				}
				set {
					_recordAddMode = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,219,110,219,70,16,134,95,133,96,114,169,21,246,124,208,173,227,2,6,236,212,176,147,220,88,190,216,195,108,76,148,34,13,146,106,225,10,122,247,14,105,201,39,52,74,211,54,5,130,154,23,148,184,220,153,29,254,252,63,206,110,202,183,195,221,45,148,139,242,3,116,157,239,219,60,204,143,218,14,230,231,93,27,161,239,231,167,109,244,117,245,187,15,53,156,251,206,175,96,128,238,147,175,215,208,159,86,253,48,43,158,135,149,179,242,237,175,211,221,114,113,181,41,79,6,88,125,60,73,152,29,20,181,86,240,68,76,162,64,100,8,134,88,19,57,201,146,230,32,60,147,145,42,12,142,109,189,94,53,103,48,248,115,63,220,148,139,77,57,101,195,4,201,104,35,65,72,226,168,150,68,114,110,72,136,54,16,227,148,178,193,10,201,148,43,183,179,178,143,55,176,242,211,162,143,193,140,202,36,104,96,68,42,235,137,116,193,17,43,49,141,135,204,76,50,54,72,198,198,224,221,252,199,192,236,235,30,198,59,169,234,111,107,127,247,233,139,19,110,159,137,243,116,202,102,121,175,241,178,92,44,191,164,242,238,247,114,42,254,185,206,47,37,94,150,179,101,121,217,174,187,56,102,20,120,241,238,73,109,211,34,211,148,23,151,123,77,113,164,89,215,245,110,228,157,31,252,126,226,126,184,77,85,174,32,157,52,151,123,41,167,44,116,119,144,63,57,237,143,251,218,254,73,216,153,111,252,103,232,222,163,0,143,181,63,84,249,1,101,220,39,118,52,104,21,178,37,52,231,72,36,147,12,29,101,28,225,146,83,252,227,179,163,102,138,190,128,12,29,52,17,254,102,97,23,208,79,106,143,102,222,213,53,74,181,45,183,219,217,83,139,27,151,132,201,193,18,47,53,90,28,130,38,62,82,75,152,182,38,139,156,193,2,59,104,113,43,101,84,32,52,49,57,25,124,162,136,140,176,148,136,66,227,219,96,104,148,42,255,251,22,191,122,115,218,182,191,172,111,231,138,198,24,172,29,235,151,138,200,4,129,56,149,198,132,60,58,157,99,114,86,206,173,242,129,202,64,73,214,28,49,116,65,18,11,248,204,24,171,50,174,65,109,210,111,174,15,17,243,176,222,241,229,251,162,105,7,52,91,244,67,213,54,197,8,201,124,5,205,120,1,169,184,107,215,69,133,163,55,80,172,144,13,180,197,125,226,87,210,254,99,210,2,119,138,26,150,137,1,239,208,216,154,19,155,152,39,142,185,144,133,17,60,103,126,136,180,191,98,172,111,34,141,139,172,77,118,142,36,160,1,211,132,128,5,33,250,49,211,196,92,202,202,57,121,144,52,96,44,249,32,145,19,42,40,158,152,36,1,4,35,134,26,74,163,200,140,101,251,61,72,187,58,233,127,254,173,129,238,94,159,197,212,60,174,231,56,250,98,224,184,134,145,131,197,70,11,202,89,166,156,128,142,40,189,198,142,105,25,62,179,247,89,34,133,214,216,24,182,24,240,208,50,22,155,228,56,213,202,227,183,3,80,18,41,192,140,45,147,145,204,116,208,52,72,172,53,143,33,199,200,217,112,119,52,105,180,216,120,38,164,166,248,197,209,66,161,164,210,103,226,68,4,194,76,230,33,224,3,27,153,182,215,95,35,251,2,124,42,118,4,23,9,189,52,255,169,234,250,161,168,240,213,21,109,46,58,232,215,245,80,53,159,11,124,55,53,196,113,222,252,236,21,238,31,24,238,64,1,77,200,5,178,227,70,184,149,35,1,59,2,137,140,114,41,66,76,218,132,111,130,59,101,225,209,115,140,32,102,216,215,51,119,196,5,235,176,225,48,70,153,176,92,50,126,16,238,224,164,83,12,113,9,62,98,69,220,83,226,162,97,68,235,40,12,215,156,171,108,254,95,112,211,132,195,217,140,239,200,140,123,103,133,81,222,43,130,219,140,160,156,22,129,122,249,157,224,62,106,155,193,199,225,181,115,63,28,63,18,220,232,42,220,143,42,220,89,103,224,184,35,69,184,109,74,148,120,75,5,122,202,138,148,196,215,224,190,222,254,1,226,240,5,62,100,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "5ca46f1711e94116b7e56dc129a6bce3",
							"BaseElements.AddMentionNotificationUserTask.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("0d13113a-287e-c0ff-f4f6-cf9ec5dddf35");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		public ESNNotificationProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ESNNotificationProcess";
			SchemaUId = new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5ca46f17-11e9-4116-b7e5-6dc129a6bce3");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ESNNotificationProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ESNNotificationProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public virtual Guid NotificationIdParameter {
			get;
			set;
		}

		private ProcessPostCommentLane _postCommentLane;
		public ProcessPostCommentLane PostCommentLane {
			get {
				return _postCommentLane ?? ((_postCommentLane) = new ProcessPostCommentLane(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminateProcess;
		public ProcessTerminateEvent TerminateProcess {
			get {
				return _terminateProcess ?? (_terminateProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateProcess",
					SchemaElementUId = new Guid("b31e7b6c-362c-41a5-9e34-85da4aeff8e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _onPostCommentedStartSignal;
		public ProcessStartSignalEvent OnPostCommentedStartSignal {
			get {
				return _onPostCommentedStartSignal ?? (_onPostCommentedStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "OnPostCommentedStartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("08f41d99-9838-418a-b579-a7177272506b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadCommentedPostUserTaskFlowElement _readCommentedPostUserTask;
		public ReadCommentedPostUserTaskFlowElement ReadCommentedPostUserTask {
			get {
				return _readCommentedPostUserTask ?? (_readCommentedPostUserTask = new ReadCommentedPostUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddCommentNotificationUserTaskFlowElement _addCommentNotificationUserTask;
		public AddCommentNotificationUserTaskFlowElement AddCommentNotificationUserTask {
			get {
				return _addCommentNotificationUserTask ?? (_addCommentNotificationUserTask = new AddCommentNotificationUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessStartSignalEvent _onLikeAddedStartSignal;
		public ProcessStartSignalEvent OnLikeAddedStartSignal {
			get {
				return _onLikeAddedStartSignal ?? (_onLikeAddedStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "OnLikeAddedStartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("1b77d543-2d8f-468e-ac45-367e57574f2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddLikedNotificationUserTaskFlowElement _addLikedNotificationUserTask;
		public AddLikedNotificationUserTaskFlowElement AddLikedNotificationUserTask {
			get {
				return _addLikedNotificationUserTask ?? (_addLikedNotificationUserTask = new AddLikedNotificationUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLikedPostUserTaskFlowElement _readLikedPostUserTask;
		public ReadLikedPostUserTaskFlowElement ReadLikedPostUserTask {
			get {
				return _readLikedPostUserTask ?? (_readLikedPostUserTask = new ReadLikedPostUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _sendNotificationScriptTask;
		public ProcessScriptTask SendNotificationScriptTask {
			get {
				return _sendNotificationScriptTask ?? (_sendNotificationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendNotificationScriptTask",
					SchemaElementUId = new Guid("32d0ae3e-a939-4d47-95b8-8a0fefbe6a8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SendNotificationScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _formulaTask1;
		public ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("c6a307e4-94ad-4577-b6c1-23185045e859"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway1;
		public ProcessInclusiveGateway InclusiveGateway1 {
			get {
				return _inclusiveGateway1 ?? (_inclusiveGateway1 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway1",
					SchemaElementUId = new Guid("8b08f239-cebb-480e-aa3e-b2513abac21b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.InclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _formulaTask2;
		public ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("109b1c48-4f13-4d85-b81a-a9a72ece3004"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessStartSignalEvent _onMentionAddedStartSignal;
		public ProcessStartSignalEvent OnMentionAddedStartSignal {
			get {
				return _onMentionAddedStartSignal ?? (_onMentionAddedStartSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "OnMentionAddedStartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("859fbff4-1ddc-4114-abd2-5a09273eff27"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask4FlowElement _readDataUserTask4;
		public ReadDataUserTask4FlowElement ReadDataUserTask4 {
			get {
				return _readDataUserTask4 ?? (_readDataUserTask4 = new ReadDataUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddMentionNotificationUserTaskFlowElement _addMentionNotificationUserTask;
		public AddMentionNotificationUserTaskFlowElement AddMentionNotificationUserTask {
			get {
				return _addMentionNotificationUserTask ?? (_addMentionNotificationUserTask = new AddMentionNotificationUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask3;
		public ProcessScriptTask FormulaTask3 {
			get {
				return _formulaTask3 ?? (_formulaTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask3",
					SchemaElementUId = new Guid("c23bd082-a1cf-453c-b6ea-7067d9f9c0dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("2e85559f-f12a-47bc-ab83-2d0181bfba46"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _formulaTask4;
		public ProcessScriptTask FormulaTask4 {
			get {
				return _formulaTask4 ?? (_formulaTask4 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask4",
					SchemaElementUId = new Guid("dc6f485e-b8a2-4027-84e9-46cb310090d1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask4Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TerminateProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateProcess };
			FlowElements[OnPostCommentedStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { OnPostCommentedStartSignal };
			FlowElements[ReadCommentedPostUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCommentedPostUserTask };
			FlowElements[AddCommentNotificationUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddCommentNotificationUserTask };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[OnLikeAddedStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { OnLikeAddedStartSignal };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[AddLikedNotificationUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddLikedNotificationUserTask };
			FlowElements[ReadLikedPostUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLikedPostUserTask };
			FlowElements[SendNotificationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendNotificationScriptTask };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[InclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[OnMentionAddedStartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { OnMentionAddedStartSignal };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[AddMentionNotificationUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddMentionNotificationUserTask };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[FormulaTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask4 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TerminateProcess":
						CompleteProcess();
						break;
					case "OnPostCommentedStartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ReadCommentedPostUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddCommentNotificationUserTask", e.Context.SenderName));
						break;
					case "AddCommentNotificationUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCommentedPostUserTask", e.Context.SenderName));
						break;
					case "OnLikeAddedStartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLikedPostUserTask", e.Context.SenderName));
						break;
					case "AddLikedNotificationUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "ReadLikedPostUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddLikedNotificationUserTask", e.Context.SenderName));
						break;
					case "SendNotificationScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateProcess", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
					case "InclusiveGateway1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendNotificationScriptTask", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
						break;
					case "OnMentionAddedStartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddMentionNotificationUserTask", e.Context.SenderName));
						break;
					case "AddMentionNotificationUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask4", e.Context.SenderName));
						break;
					case "FormulaTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("NotificationIdParameter")) {
				writer.WriteValue("NotificationIdParameter", NotificationIdParameter, Guid.Empty);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
			MetaPathParameterValues.Add("f0a3cf6a-71c5-4eef-add2-9dfe3c7b24a4", () => NotificationIdParameter);
			MetaPathParameterValues.Add("d70075ca-9e0b-44df-a779-e59e0e2f85b4", () => OnPostCommentedStartSignal.RecordId);
			MetaPathParameterValues.Add("2f478e43-a126-41ef-bd27-886141b52843", () => OnPostCommentedStartSignal.EntitySchemaUId);
			MetaPathParameterValues.Add("ba9ba9d2-475d-40f2-8404-7ac59bcee891", () => ReadCommentedPostUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("9a60810c-41d3-474d-908b-832435849593", () => ReadCommentedPostUserTask.ResultType);
			MetaPathParameterValues.Add("56642892-05c7-42ae-8a57-ac21482d70bb", () => ReadCommentedPostUserTask.ReadSomeTopRecords);
			MetaPathParameterValues.Add("0c54e3ed-b510-44aa-95e8-d5869d6647b7", () => ReadCommentedPostUserTask.NumberOfRecords);
			MetaPathParameterValues.Add("3ea11d01-ccd4-45c3-9644-14df37bc5ce0", () => ReadCommentedPostUserTask.FunctionType);
			MetaPathParameterValues.Add("fd3d7954-cc74-4986-a523-d221d7761c23", () => ReadCommentedPostUserTask.AggregationColumnName);
			MetaPathParameterValues.Add("92450397-12f0-4f17-a75d-d38567c6327b", () => ReadCommentedPostUserTask.OrderInfo);
			MetaPathParameterValues.Add("5a1f2b83-ed26-4c92-8480-206a321e9963", () => ReadCommentedPostUserTask.ResultEntity);
			MetaPathParameterValues.Add("2e4064fd-64ed-4abc-8260-c6a14fb6a6c5", () => ReadCommentedPostUserTask.ResultCount);
			MetaPathParameterValues.Add("fd53a939-0d8c-44b8-9ef1-fc1e8c5694e4", () => ReadCommentedPostUserTask.ResultIntegerFunction);
			MetaPathParameterValues.Add("d146f3f2-4cb7-4239-92bf-c9081aa150f5", () => ReadCommentedPostUserTask.ResultFloatFunction);
			MetaPathParameterValues.Add("4508d2c7-78c9-422c-977e-5f7441f0ef76", () => ReadCommentedPostUserTask.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0cc7df16-22da-417e-b78a-80ea545febad", () => ReadCommentedPostUserTask.ResultRowsCount);
			MetaPathParameterValues.Add("15a46e90-2180-4324-bb5b-dcb14fbe07ee", () => ReadCommentedPostUserTask.CanReadUncommitedData);
			MetaPathParameterValues.Add("720d957d-e275-469f-8956-e925ee0c382a", () => ReadCommentedPostUserTask.ResultEntityCollection);
			MetaPathParameterValues.Add("d7c50aae-200a-41d3-8177-d3acea16b585", () => ReadCommentedPostUserTask.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9702aa85-1629-4ea9-8aa4-2753d1f1692e", () => ReadCommentedPostUserTask.IgnoreDisplayValues);
			MetaPathParameterValues.Add("6a3574e7-1c32-41ba-9a16-e9ed315eef65", () => ReadCommentedPostUserTask.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f2c99b37-6016-4f45-af48-6e6f1c684e46", () => ReadCommentedPostUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("d2f54b5a-bf50-4842-a4f0-4d72ad23d06c", () => AddCommentNotificationUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("7f07f8e3-92dd-4b85-b1a9-b8d1a524e5d5", () => AddCommentNotificationUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("9abee62b-56b1-4c28-93ae-c885bfff3a39", () => AddCommentNotificationUserTask.RecordAddMode);
			MetaPathParameterValues.Add("a806be87-94ba-47b4-9129-331e6d19c0a5", () => AddCommentNotificationUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("b8bbeac4-174d-4926-9467-5e78622c517a", () => AddCommentNotificationUserTask.RecordDefValues);
			MetaPathParameterValues.Add("f640e209-6e76-4601-93eb-8e3eda7f8505", () => AddCommentNotificationUserTask.RecordId);
			MetaPathParameterValues.Add("f8d85b8c-3c7a-44ee-8684-d0653011114c", () => AddCommentNotificationUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("b16c2a23-8fa1-410c-8bf0-9ded1dcbf5b3", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("310495bd-78ef-46e8-bd4f-08a98a050897", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("cb3ef4f3-9764-4095-a7f4-5e41a35ac0ac", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("54c3435c-6332-48a2-a3e3-e3146231388c", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("48f7c6e0-02c8-4675-80b8-8367b0ef9190", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("d5e71c2a-4e7a-4bbc-8424-96fac9c00de2", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("062d7511-3234-4dc6-98d1-9a2bd134a872", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("21c4f994-ba78-446e-9942-d68f20139863", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("66e87786-c605-4fec-b02e-830988bb2e7d", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("a122acd7-cc81-49fd-8c39-9aab1b9c747c", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("677eaf70-16e1-4664-bae1-944189695e0b", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("f8162883-d725-4f4b-b85f-218697d31396", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("fc9471e4-6058-424b-acd0-8b0ae601c0c6", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("e98494ea-7338-4c9a-b507-c8b3dc9be58f", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("e0adb813-1f6d-4072-b83f-eafcb5ba680c", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("49fd90d6-76c8-48f2-8b16-ea83004edbda", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b833533c-49e1-4ebc-ac9f-1a911d02ccc4", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("7c3db1aa-d065-4619-9e55-0615dfb22975", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("fa088023-44c1-4370-afa4-5c6b45d07773", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e4cf7a08-cf11-4efc-aad9-78919c7c9593", () => OnLikeAddedStartSignal.RecordId);
			MetaPathParameterValues.Add("f836b77b-679f-4dfa-a647-9a7e89c1ec39", () => OnLikeAddedStartSignal.EntitySchemaUId);
			MetaPathParameterValues.Add("39c452ee-d582-4fc4-89da-188114ddf6aa", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("ab5d3b2f-e2fb-4c08-99ff-2f80f260179f", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("eb26905a-bd71-46d4-8d6a-d6ed38d0edde", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("c33a347d-db7a-4e6a-919d-dcec7662e460", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("9e247ae1-2b40-42ab-805b-c5d6096d9ba4", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("0a73401c-113f-4c6f-861a-7262b910e6cb", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("a2463ef1-b5d5-415d-b646-059986b3a408", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("d73fb076-b90d-4745-a4b2-fac13c95af7d", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("16d9166d-3ef0-42f4-8408-44ae67b0bbf8", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("7375ce45-bc51-437e-87e1-eedd8eff6e54", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("fe779b3d-abd3-45e1-aeab-f8081843611c", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("41b06c6a-fc83-481d-8934-d1b75bfe8a0f", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("074acb9f-4b51-4a71-96b0-a688dc1e4df0", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("f30a6c29-f244-4a31-9102-fcea5bed4454", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("5556b314-99f0-40b0-8172-959a76296469", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("990df6b1-021b-4232-9284-f92fa22ee682", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("272ed838-6e7e-4ec3-b267-81140797856d", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("daa71dc2-1fb1-4636-bb5a-75c107201ba4", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("489232d2-1dc4-492b-a5a8-1ef8e65ac76c", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("da240fb2-c774-4c74-99fd-2e1fdfae3964", () => AddLikedNotificationUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("17ac42d2-21e6-4d36-ba16-b249f630b24b", () => AddLikedNotificationUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("e8734de8-8d7a-4251-a4ab-c545f58d718b", () => AddLikedNotificationUserTask.RecordAddMode);
			MetaPathParameterValues.Add("644e1f0f-142c-4e1f-8cad-d8d970d36e91", () => AddLikedNotificationUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("56e0b34b-5e15-42e9-b5c8-2bb82ace64b4", () => AddLikedNotificationUserTask.RecordDefValues);
			MetaPathParameterValues.Add("8010ef15-aad8-4dba-850c-692c850d65b9", () => AddLikedNotificationUserTask.RecordId);
			MetaPathParameterValues.Add("0bd3a304-f122-4a32-b22a-9a226bd873df", () => AddLikedNotificationUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("bb823b89-4655-4e40-9e5c-0e10daf24deb", () => ReadLikedPostUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("df4038dc-6372-4684-8eec-b443a51b08be", () => ReadLikedPostUserTask.ResultType);
			MetaPathParameterValues.Add("b90f1d0e-459b-4ff2-84b9-84bdd7ae294d", () => ReadLikedPostUserTask.ReadSomeTopRecords);
			MetaPathParameterValues.Add("55f43d53-adf7-49ba-b7fc-3fdfc2fb2ef5", () => ReadLikedPostUserTask.NumberOfRecords);
			MetaPathParameterValues.Add("be6e2286-7b11-4750-807e-4ce55e79daca", () => ReadLikedPostUserTask.FunctionType);
			MetaPathParameterValues.Add("4e88fd04-f4da-40e3-b8c4-35afe197eb57", () => ReadLikedPostUserTask.AggregationColumnName);
			MetaPathParameterValues.Add("8e49b308-b01a-4375-803d-4e3f3770a686", () => ReadLikedPostUserTask.OrderInfo);
			MetaPathParameterValues.Add("83258719-cd7a-45a9-b2ee-39499a3a6013", () => ReadLikedPostUserTask.ResultEntity);
			MetaPathParameterValues.Add("c164263e-1a79-4940-9a57-e2dccc8fa7a0", () => ReadLikedPostUserTask.ResultCount);
			MetaPathParameterValues.Add("eec87964-39ad-40af-a379-61083fb27433", () => ReadLikedPostUserTask.ResultIntegerFunction);
			MetaPathParameterValues.Add("c2061afa-5a06-4890-9015-495796290789", () => ReadLikedPostUserTask.ResultFloatFunction);
			MetaPathParameterValues.Add("56e6c97a-488f-4add-9847-e81524046833", () => ReadLikedPostUserTask.ResultDateTimeFunction);
			MetaPathParameterValues.Add("8e5240fe-f6fb-4a6b-9ab0-214fcca33c93", () => ReadLikedPostUserTask.ResultRowsCount);
			MetaPathParameterValues.Add("ef6b4042-e216-4b4f-a5ee-db4fe2678424", () => ReadLikedPostUserTask.CanReadUncommitedData);
			MetaPathParameterValues.Add("8c09f3bd-485d-4bc4-8868-7ed8fdc1494b", () => ReadLikedPostUserTask.ResultEntityCollection);
			MetaPathParameterValues.Add("3001471f-45f4-4b10-bb93-e968de3645f2", () => ReadLikedPostUserTask.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("e2be980a-5e5d-46f0-b248-73fd2d5c1967", () => ReadLikedPostUserTask.IgnoreDisplayValues);
			MetaPathParameterValues.Add("7eced334-87e9-445d-b4fc-c349d0303875", () => ReadLikedPostUserTask.ResultCompositeObjectList);
			MetaPathParameterValues.Add("4e2a3f16-2ed0-4300-85ef-3daad88e98d6", () => ReadLikedPostUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("985f26f9-02d6-49a5-afcc-1da4c66649df", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("14407ed4-7b93-4bb0-8947-61bee5163314", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("4825dd82-7b93-46dc-930d-b83505b1dfac", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8dbf8aa1-5f3b-4120-a9f7-2ce998b5271d", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("97994f7a-bac7-48f6-b00e-124a48fb410b", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("4410d85f-c656-4d35-8868-6b0cf395c87f", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("cd03c654-a7de-4ffc-89fa-6c63a3c8eb4e", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("d92065a7-8e79-43e7-9061-f16b60b4846f", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("152ec142-0c82-4d70-a402-a52fef871f70", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("b2c24b55-7356-45da-b7fa-06d890b61f98", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("1533582a-753c-4ea4-a4b7-fbee9273241e", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("4d80d870-a1ef-4838-819a-2b0dfb2ceee5", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("379f0ed1-624c-4682-bc40-71ebf792b7c5", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("264b43ca-f583-4d03-9225-6c4c86add08b", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("5965ef63-7801-4c91-9a41-a15ad70a5605", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("838e5c55-a218-4d7e-8db5-2a2360539a1e", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9af0e793-7b1b-40b6-b726-89e6b53d8b6b", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("5bd1a28f-6eb3-4163-9ad0-e598003c1907", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("e9dd48c5-c7fe-46e1-b496-5b5dae63c6ee", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("c067a39f-1e8f-445f-a239-e40a0cfe4146", () => OnMentionAddedStartSignal.RecordId);
			MetaPathParameterValues.Add("50d03153-866c-49a1-b09f-f3572ef11b73", () => OnMentionAddedStartSignal.EntitySchemaUId);
			MetaPathParameterValues.Add("242ce24d-3ddd-45ff-9b66-b7ca7b504cbc", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("0cd58999-5230-4ef3-a513-99389ff530c0", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("99ae8ad0-6499-4567-8c65-86a56bbea68f", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("4c952f0e-dffd-4986-846d-384a7af8a09a", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("f8117a6f-4913-432b-b814-eeab6e96632d", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("0dca8765-93e1-4123-8811-6ec3651653bf", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("69d9d40d-db8f-43e9-88ae-a3abf24a965a", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("8cc5ccbc-2b9c-463a-9bab-aa349cb77cd2", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("1c4950dc-eb9d-4ad4-ab50-8fbb9420594b", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("290fc9b4-9025-4e3f-98b9-1747c5e4346a", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("575e6cd5-8a18-469a-9cd6-55e129df411f", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("4ae0aeb5-961a-4027-9a0c-5ac3d4a5ac77", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("68d9c290-aed7-4455-8d6c-9b0597a13528", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("cb390c3d-53e0-4db5-8ba9-d854ceef7d5e", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("e177f00d-bbb5-4a71-96a5-6b3bd5c30c02", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("7d9a88fc-ab6e-4c1a-b52c-764cccb74f1a", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("6ea463a5-4871-446f-af0b-1667f7dedda3", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("48bd0458-36a0-4710-9baf-d55b64ad2ab2", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("ad88c443-aa08-4a50-8ab0-0e7f5effc244", () => ReadDataUserTask4.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e037ba80-32fe-4970-89b0-011247b9cfca", () => AddMentionNotificationUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("aa175d01-463f-4eaa-b6dd-6e062b0a9fbe", () => AddMentionNotificationUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("31adc4d6-d5e5-44b1-a41c-9f6561db382d", () => AddMentionNotificationUserTask.RecordAddMode);
			MetaPathParameterValues.Add("75b974c3-f286-497f-b22e-63339fcad82c", () => AddMentionNotificationUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("4772da4a-5d0b-4678-8701-ff35ab251456", () => AddMentionNotificationUserTask.RecordDefValues);
			MetaPathParameterValues.Add("2d9562bc-844a-4dc6-86f8-0bfb638f3379", () => AddMentionNotificationUserTask.RecordId);
			MetaPathParameterValues.Add("80d16d3f-9a20-469c-960b-54cfe5e9b6df", () => AddMentionNotificationUserTask.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("ab84c217-21ad-45fe-a710-9a563a7cf619", () => StartSignal1.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "NotificationIdParameter":
					if (!hasValueToRead) break;
					NotificationIdParameter = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SendNotificationScriptTaskExecute(ProcessExecutingContext context) {
			var userConnection = UserConnection;
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "ESNNotification"){
				UseAdminRights = false
			};
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			var createdOnColumn = esq.AddColumn("CreatedOn");
			var socialMessageIdColumn = esq.AddColumn("SocialMessage.Id");
			var socialMessageTextColumn = esq.AddColumn("SocialMessage.Message");
			var socialMessageEntityIdColumn = esq.AddColumn("SocialMessage.EntityId");
			var socialMessageEntitySchemaUIdColumn = esq.AddColumn("SocialMessage.EntitySchemaUId");
			var socialMessageParentIdColumn = esq.AddColumn("SocialMessage.Parent.Id");
			var socialMessageParentEntityIdColumn = esq.AddColumn("SocialMessage.Parent.EntityId");
			var socialMessageParentEntitySchemaUIdColumn = esq.AddColumn("SocialMessage.Parent.EntitySchemaUId");
			var typeIdColumn = esq.AddColumn("Type.Id");
			var typeActionColumn = esq.AddColumn("Type.Action");
			var typeNameColumn = esq.AddColumn("Type.Name");
			var typeIconIdColumn = esq.AddColumn("Type.Icon");
			var createdByIdColumn = esq.AddColumn("CreatedBy.Id");
			var createdByNameColumn = esq.AddColumn("CreatedBy.Name");
			var createdByPhotoIdColumn = esq.AddColumn("CreatedBy.Photo");
			var ownerIdColumn = esq.AddColumn("Owner");
			var notificationFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", NotificationIdParameter);
			esq.Filters.Add(notificationFilter);
			var notifications = esq.GetEntityCollection(userConnection);
			if (notifications.Count == 0) {
				return false;
			}
			var notification = notifications[0];
			var createdOn = notification.GetTypedColumnValue<DateTime>(createdOnColumn.Name);
			if (createdOn.Kind == DateTimeKind.Local) {
				createdOn = DateTime.SpecifyKind(createdOn, DateTimeKind.Unspecified);
			}
			string createdOnString = DateTimeDataValueType.Serialize(createdOn, TimeZoneInfo.Utc);
			var notificationId = notification.PrimaryColumnValue;
			var socialMessageId = notification.GetTypedColumnValue<Guid>(socialMessageIdColumn.Name);
			var socialMessageText = notification.GetTypedColumnValue<string>(socialMessageTextColumn.Name);
			var socialMessageEntityId = notification.GetTypedColumnValue<Guid>(socialMessageEntityIdColumn.Name);
			var socialMessageEntitySchemaUId = notification.GetTypedColumnValue<Guid>(socialMessageEntitySchemaUIdColumn.Name);
			var socialMessageParentId = notification.GetTypedColumnValue<Guid>(socialMessageParentIdColumn.Name);
			var socialMessageParentEntityId = notification.GetTypedColumnValue<Guid>(socialMessageParentEntityIdColumn.Name);
			var socialMessageParentEntitySchemaUId = notification.GetTypedColumnValue<Guid>(socialMessageParentEntitySchemaUIdColumn.Name);
			var typeId = notification.GetTypedColumnValue<Guid>(typeIdColumn.Name);
			var typeAction = notification.GetTypedColumnValue<string>(typeActionColumn.Name);
			var typeIconId = notification.GetTypedColumnValue<Guid>("Type_IconId");
			var typeName = notification.GetTypedColumnValue<string>(typeNameColumn.Name);
			var createdById = notification.GetTypedColumnValue<Guid>(createdByIdColumn.Name);
			var createdByName = notification.GetTypedColumnValue<string>(createdByNameColumn.Name);
			var createdByPhotoId = notification.GetTypedColumnValue<Guid>("CreatedBy_PhotoId");
			var ownerId = notification.GetTypedColumnValue<Guid>("OwnerId");
			var esqSysAdminUnit = new EntitySchemaQuery(userConnection.EntitySchemaManager, "SysAdminUnit"){
				UseAdminRights = false
			};
			var idColumn = esqSysAdminUnit.AddColumn(esqSysAdminUnit.RootSchema.GetPrimaryColumnName());
			esqSysAdminUnit.Filters.Add(esqSysAdminUnit
				.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", ownerId));
			var entities = esqSysAdminUnit.GetEntityCollection(userConnection);
			if (entities.Count == 0) {
				return false;
			}
			var sysAdminUnit = entities[0];
			var sysAdminUnitId = sysAdminUnit.GetTypedColumnValue<Guid>(idColumn.Name);
			if (UserConnection.GetIsFeatureEnabled("NotificationV2")) {
				if (sysAdminUnitId == userConnection.CurrentUser.PrimaryColumnValue) {
					return false;	
				}
				ESNNotificationTextFormer textFormer = ClassFactory.Get<ESNNotificationTextFormer>(
					new ConstructorArgument("userConnection", userConnection));
				Guid entitySchemaUId = socialMessageParentId.IsEmpty()
					? socialMessageEntitySchemaUId
					: socialMessageParentEntitySchemaUId;
				Guid entityId = socialMessageParentId.IsEmpty()
					? socialMessageEntityId
					: socialMessageParentEntityId;
				string entitySchemaName = userConnection
					.EntitySchemaManager
					.FindInstanceByUId(entitySchemaUId).Name;
				NotificationInfo notificationInfo = new NotificationInfo {
					ImageId = createdByPhotoId,
					EntitySchemaName =  entitySchemaName,
					RemindTime = createdOn,
					MessageId = notificationId,
					EntityId = entityId,
					GroupName = "ESNNotification",
					SysAdminUnit = sysAdminUnitId,
					Body = textFormer.GetBody(new Dictionary<string, object> {
						{"CreatedOn", createdOn },
						{"CreatedByName", createdByName },
						{"Action", typeAction },
						{"Message", socialMessageText },
					}),
					Title = textFormer.GetTitle(new Dictionary<string, object> {
						{"TypeName", typeName }
					})
				};
				var notificationSender = ClassFactory.Get<INotificationSender>(
					new ConstructorArgument("userConnection", UserConnection));
				notificationSender.Send(new [] {notificationInfo});
			} else {
				string createdByString = string.Format("{{\"value\":\"{0}\", \"displayValue\":\"{1}\", \"primaryImageValue\":\"{2}\"}}",
					createdById, createdByName, createdByPhotoId);
				string socialMessageParentString = string.Format("{{\"id\":\"{0}\", \"entityId\":\"{1}\", \"entitySchemaUId\":\"{2}\"}}",
					socialMessageParentId, socialMessageParentEntityId, socialMessageParentEntitySchemaUId);
				string socialMessageTextJson = Newtonsoft.Json.JsonConvert.ToString(socialMessageText.ToString());
				string socialMessageString = string.Format(
					"{{\"id\":\"{0}\", \"value\":\"{1}\", \"displayValue\":{2}, \"entityId\":\"{3}\", \"entitySchemaUId\":\"{4}\", \"parent\":{5}}}",
					socialMessageId, socialMessageId, socialMessageTextJson, socialMessageEntityId, socialMessageEntitySchemaUId, socialMessageParentString);
				string typeString = string.Format("{{\"value\":\"{0}\", \"displayValue\":\"{1}\", \"primaryImageValue\":\"{2}\"}}",
					typeId, typeAction, typeIconId);
				var SimpleMessage = new SimpleMessage();
				SimpleMessage.Body = string.Format(
					"{{\"id\":\"{0}\", \"createdOn\":\"{1}\", \"createdBy\":{2}, \"socialMessage\":{3}, \"type\":{4}}}",
					NotificationIdParameter, createdOnString, createdByString, socialMessageString, typeString);
				SimpleMessage.Id = sysAdminUnitId;
				SimpleMessage.Header.Sender = "ESNNotification";
				MsgChannelManager manager = MsgChannelManager.Instance;
				IMsgChannel channel = manager.FindItemByUId(sysAdminUnitId);
				if(channel != null) {
					channel.PostMessage(SimpleMessage);
				}
			}
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localNotificationIdParameter = (AddCommentNotificationUserTask.RecordId);
			NotificationIdParameter = (System.Guid)localNotificationIdParameter;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localNotificationIdParameter = (AddLikedNotificationUserTask.RecordId);
			NotificationIdParameter = (System.Guid)localNotificationIdParameter;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localNotificationIdParameter = (AddMentionNotificationUserTask.RecordId);
			NotificationIdParameter = (System.Guid)localNotificationIdParameter;
			return true;
		}

		public virtual bool FormulaTask4Execute(ProcessExecutingContext context) {
			var localNotificationIdParameter = (StartSignal1.RecordId);
			NotificationIdParameter = (System.Guid)localNotificationIdParameter;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (ESNNotificationProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

