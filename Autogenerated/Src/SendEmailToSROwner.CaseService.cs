namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using SysSettings = Terrasoft.Core.Configuration.SysSettings;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
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
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Mail;
	using Terrasoft.Mail.Sender;

	#region Class: SendEmailToSROwnerSchema

	/// <exclude/>
	public class SendEmailToSROwnerSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToSROwnerSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToSROwnerSchema(SendEmailToSROwnerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToSROwner";
			UId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698");
			CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.541";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 };
			RealUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateTemplateIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e2d6e188-0536-4cbb-a47d-546de3233a1d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.b47e41c6-94d0-4d02-8531-4054c157c2ac#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a7d24a5a-b023-47ad-be9a-c28a39a5ae4f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"SenderEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c4cbc9bd-932f-4649-87a1-e88804fb12c1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ebb67ae-b1e9-459b-b25c-d3ca6c2d1b78"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCloseAndExitParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("57bee078-709b-4064-8102-a8d287b5ba04"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"IsCloseAndExit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateSenderEmailParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateCaseRecordIdParameter());
			Parameters.Add(CreateIsCloseAndExitParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c046b569-c1d5-44ee-bef5-2f0c073b6e8d"),
				ContainerUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
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
				UId = new Guid("85939570-5e97-434a-8ec4-3e328c887084"),
				ContainerUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeStartSignal2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fae2fcb8-9ebc-4d88-a763-51a8fd7fa007"),
				ContainerUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
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
				UId = new Guid("df23ea66-cd2f-4c48-a92d-7b123685cf55"),
				ContainerUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9fe73c5e-c65c-4dc9-8a14-32ddee1d2062"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,85,77,111,219,48,12,253,43,129,207,85,33,219,178,36,231,54,116,217,208,203,90,172,197,46,75,15,148,68,37,198,252,17,200,78,183,174,200,127,31,109,167,89,91,164,107,54,96,88,7,52,151,216,196,35,245,72,235,241,221,70,182,132,182,253,0,21,70,211,232,18,67,128,182,241,221,241,187,162,236,48,188,15,205,122,21,29,69,45,134,2,202,226,59,186,49,62,115,69,247,22,58,160,148,219,249,207,10,243,104,58,223,95,99,30,29,205,163,162,195,170,37,12,165,248,204,228,10,12,103,82,9,193,132,19,192,140,69,96,200,211,88,103,78,164,60,143,71,228,83,197,79,154,106,5,1,199,51,134,242,126,120,188,188,89,245,208,152,2,118,128,20,109,83,111,131,105,79,162,157,213,96,74,116,244,222,133,53,82,168,11,69,69,221,224,101,81,225,57,4,58,171,175,211,244,33,2,121,40,219,30,85,162,239,102,223,86,1,219,182,104,234,231,200,149,235,170,190,143,166,2,184,123,221,210,225,3,199,30,121,14,221,114,40,113,74,180,54,3,203,55,139,69,192,5,116,197,245,125,18,95,240,102,192,29,54,63,74,112,244,149,62,65,185,198,123,103,62,236,228,4,86,221,216,208,120,60,1,66,177,88,30,220,235,110,98,207,181,155,80,112,117,7,62,176,230,222,30,18,73,193,235,62,48,86,185,123,156,71,159,79,219,179,175,53,134,11,187,196,10,198,169,93,29,83,244,81,96,86,98,133,117,55,189,69,233,114,207,53,103,90,122,201,132,231,156,129,144,146,249,132,199,232,165,65,149,103,27,74,216,17,154,222,90,46,164,201,100,206,108,236,50,38,4,34,51,232,51,150,120,110,185,74,141,68,237,54,87,35,241,162,93,149,112,51,112,31,59,92,226,196,66,139,147,37,180,19,131,88,79,168,255,98,81,163,155,116,205,164,233,169,31,127,68,219,4,183,253,18,253,31,229,89,43,108,46,173,96,113,172,56,19,96,61,3,157,35,203,165,214,144,122,101,193,27,186,56,244,163,156,92,43,244,74,231,76,199,54,165,158,44,50,109,210,132,57,106,79,106,35,51,52,175,218,250,133,182,14,155,223,171,182,158,211,150,116,202,38,134,52,146,36,92,49,161,48,99,64,114,99,92,167,152,56,5,24,59,247,72,91,30,48,241,214,104,150,163,177,180,214,180,102,160,100,202,178,24,180,119,202,3,231,234,41,109,157,244,186,130,218,141,50,154,216,128,180,191,221,94,57,9,203,185,224,152,176,52,85,164,250,140,167,164,250,52,99,105,162,77,198,57,196,30,183,114,234,245,84,54,139,194,66,121,182,194,64,87,102,88,135,241,126,35,121,224,64,253,146,10,77,211,141,227,217,45,185,158,230,192,229,238,186,73,151,230,38,35,69,199,253,30,18,60,67,70,163,161,219,151,104,145,163,79,92,44,50,34,67,46,220,239,193,139,102,29,236,214,245,218,209,126,255,200,86,255,129,89,254,142,255,237,117,160,67,28,229,191,245,138,191,187,233,95,63,247,11,91,95,167,47,101,19,109,162,205,15,216,121,190,243,4,12,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("faf88bc7-9ec3-474f-85c3-47d19c91dd4c"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("87c61dbc-e2fe-4c1d-a939-228b0714856a"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("489aeb16-3e43-4075-8bb1-f85b63fd422a"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bc13a1cb-f6d2-48da-8094-9471e8db4dc6"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c395b470-4a8b-4af1-9692-e47f4c846c96"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				UId = new Guid("38b53574-4673-4dd1-93d8-83f1e4d170ed"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,43,205,77,74,45,178,50,180,50,212,241,76,177,50,176,50,0,0,237,33,101,51,17,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("021d04f3-0d96-4292-a469-49763741f632"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d1a08149-aeef-49fe-8363-1b80aad76636"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				UId = new Guid("f4318b8e-a4ba-4399-bb71-48847b675f4d"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				UId = new Guid("eda4e7cd-cb31-419b-ad36-22a6022aa70d"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				UId = new Guid("655b9008-70a9-4c03-a04d-b2f308450e34"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				UId = new Guid("25e0fa4b-970d-43dd-b80e-b2a2625e0dd3"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				UId = new Guid("bf24a190-2262-4aa4-b32e-c6169bca3b2f"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("014d404c-3972-44b9-a7b0-4e7fca6be3b6"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7be14a6d-bf83-44ed-a78c-1601116baefd"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f4e0fd1b-8be5-40bd-9ac3-e85c039c4f9f"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ddb3398e-58cd-4e8c-9e32-678df8172a66"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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
				UId = new Guid("c4e67b30-1c3b-463c-a33c-d95308105c66"),
				ContainerUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
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

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("70b11618-c71a-4155-8014-3a53fd5cd1c8"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,93,111,211,48,20,253,43,85,158,231,41,137,29,39,238,219,52,10,218,11,155,216,180,23,202,131,99,95,119,22,249,146,237,14,74,213,255,206,117,210,149,13,21,173,240,2,18,121,114,142,206,61,62,247,203,219,68,53,210,251,247,178,133,100,158,220,129,115,210,247,38,156,191,181,77,0,247,206,245,235,33,57,75,60,56,43,27,251,13,244,132,47,180,13,111,100,144,24,178,93,254,80,88,38,243,229,113,141,101,114,182,76,108,128,214,35,7,67,42,86,9,202,68,69,106,158,106,194,152,0,34,42,154,18,90,139,66,152,76,211,28,242,137,249,43,241,203,190,29,164,131,233,142,81,222,140,199,187,205,16,169,25,2,106,164,88,223,119,123,144,70,19,126,209,201,186,1,141,255,193,173,1,161,224,108,139,217,192,157,109,225,70,58,188,43,234,244,17,66,146,145,141,143,172,6,76,88,124,29,28,120,111,251,238,53,115,205,186,237,158,179,81,0,14,191,123,59,233,232,49,50,111,100,120,24,37,174,208,214,110,116,121,177,90,57,88,201,96,31,159,155,248,12,155,145,119,90,253,48,64,99,151,238,101,179,134,103,119,190,204,228,82,14,97,74,104,186,30,9,206,174,30,78,206,245,80,177,215,210,205,17,28,158,200,39,106,30,205,33,231,8,62,70,96,82,121,58,46,147,143,87,254,250,75,7,238,86,61,64,43,167,170,125,58,71,244,39,96,209,64,11,93,152,111,107,101,40,64,105,8,175,76,65,152,81,146,72,86,107,2,58,83,89,89,8,170,170,122,135,1,7,67,243,109,154,103,58,101,134,146,84,11,78,88,46,114,12,225,130,48,81,114,90,178,204,112,154,199,144,69,23,108,216,76,147,48,223,150,41,207,83,157,166,4,24,72,194,42,157,17,97,180,34,172,40,115,163,116,165,89,134,23,77,233,90,63,52,114,115,127,200,234,3,72,61,83,210,195,44,86,2,215,202,249,48,139,203,52,235,205,12,107,188,110,130,237,86,51,28,165,6,84,236,229,249,5,214,125,213,1,140,122,177,169,168,34,11,90,106,35,74,66,105,134,35,195,211,156,212,101,85,19,202,50,73,139,90,209,204,224,200,236,226,23,103,164,95,89,37,155,235,1,28,206,224,56,3,233,241,237,121,177,118,177,51,174,239,195,84,239,67,103,47,251,46,72,21,70,59,79,35,172,120,165,141,174,13,41,202,26,43,194,177,9,2,10,74,104,197,57,55,166,150,25,85,232,7,95,159,152,245,109,191,118,106,191,237,126,122,118,254,232,57,249,11,143,196,239,236,253,209,205,59,101,147,254,179,29,185,250,135,102,122,151,236,190,3,116,120,106,19,70,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("67dd077f-eb7e-455c-bd25-7a2739501199"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("920a67b6-1c8c-4f36-a894-356d4b59f1df"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d32b69b8-da12-4d43-9e3f-b871199dc2ac"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5ef8e651-f0f6-44c6-bd11-f287de677557"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ff3266dd-6661-4954-9be1-753c4436c33c"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				UId = new Guid("f4581450-6bde-48e5-8aeb-24e01a3f6cb3"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("5719453e-2032-4300-a9bf-e4208bede94d"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76dd0aac-acbd-4d32-bed0-d30d3e00b7bf"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				UId = new Guid("485e921a-c9c1-4491-88dc-28252e30e587"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				UId = new Guid("250b6f40-ea89-421d-b1a1-885362269881"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				UId = new Guid("4a2e7dfa-30ae-4c59-b872-15ea611cc23d"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				UId = new Guid("e7d5edde-50a9-47cf-b4d3-02ad39fbec6a"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				UId = new Guid("984c8a1b-a1b9-4152-ae3f-a823be19b2fc"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("2d33dda1-70ec-434d-8bf0-4a150a70b973"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4e926dc-1916-4d49-b91e-d1b3b9ee27f6"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6e2df57d-caef-4ef7-9bda-a15c8fe5861b"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				UId = new Guid("416fa2d3-de4d-44d5-9978-c81f98f5e3f1"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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
				UId = new Guid("f082c002-fcd5-4525-b652-643120eef8b6"),
				ContainerUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
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

		protected virtual void InitializeFillEmailUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e4f314d3-291c-45de-a2c4-0bb7a7a4a043"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText")
			};
			subjectParameter.SourceValue = new ProcessSchemaParameterValue(subjectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var bodyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fd3e36ce-30b6-4382-a169-07ea62f57648"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"Body",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			bodyParameter.SourceValue = new ProcessSchemaParameterValue(bodyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(bodyParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4becebac-6618-4cf8-acff-5399dc9ef219"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8ada520f-9328-4d23-8e28-7cd84ab83abd"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			templateIdParameter.SourceValue = new ProcessSchemaParameterValue(templateIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.b47e41c6-94d0-4d02-8531-4054c157c2ac#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var sysEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19997124-7bc1-4d68-91c0-f2a7263fc478"),
				ContainerUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Name = @"SysEntitySchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			sysEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(sysEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{6a3f340b-79dd-4dc2-8779-5140388e5320}].[Parameter:{492ae6cd-2386-4f94-b3dc-ecfe0a561e90}].[EntityColumn:{ed98cf3e-1642-4755-acb2-a61181429306}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(sysEntitySchemaIdParameter);
		}

		protected virtual void InitializeReadDataUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("09d4d948-3e28-4f04-9934-8ff03d3aee8c"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,193,142,218,48,16,253,151,156,215,43,136,179,78,178,183,138,165,189,181,72,160,158,184,76,236,73,176,214,193,145,237,172,74,87,252,123,237,4,40,72,89,109,168,132,218,106,111,241,211,155,201,155,231,231,121,141,184,2,107,191,66,141,209,99,180,66,99,192,234,210,221,127,150,202,161,249,98,116,219,68,119,145,69,35,65,201,159,40,122,124,46,164,123,2,7,190,228,117,253,187,195,58,122,92,15,247,88,71,119,235,72,58,172,173,231,248,18,150,11,145,228,60,33,73,153,35,73,48,227,36,103,140,19,140,115,94,198,44,45,10,150,246,204,183,154,207,116,221,128,193,254,31,93,251,178,251,92,237,154,64,157,122,128,119,20,105,245,246,0,210,32,194,206,183,80,40,20,254,236,76,139,30,114,70,214,126,26,92,201,26,23,96,252,191,66,31,29,32,79,42,65,217,192,82,88,186,249,143,198,160,181,82,111,223,19,167,218,122,123,206,246,13,240,116,60,200,153,116,26,3,115,1,110,211,181,232,123,237,59,157,159,170,202,96,5,78,190,156,203,120,198,93,199,28,231,160,47,16,254,158,190,131,106,241,204,153,203,89,102,208,184,126,164,163,0,79,49,178,218,140,158,247,228,218,123,35,199,30,108,142,228,145,61,7,167,136,51,15,190,4,160,43,155,129,13,190,237,131,115,44,193,20,99,74,9,45,210,146,36,177,16,36,167,211,7,66,31,50,202,232,52,77,32,23,31,49,91,203,157,93,0,127,134,10,239,175,136,217,40,51,175,142,217,165,144,255,55,110,193,66,165,43,201,65,125,107,208,120,23,59,237,147,225,48,92,164,136,133,169,181,118,75,190,193,26,78,138,252,45,245,72,167,227,120,13,80,240,66,96,94,132,135,206,72,146,77,40,41,196,180,32,148,97,34,68,10,105,150,115,47,200,175,234,160,124,169,91,195,15,241,181,253,142,254,163,221,251,23,82,127,221,146,28,76,205,152,20,220,100,157,252,163,118,45,135,222,253,205,157,187,233,203,216,71,251,95,72,180,142,225,185,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fc417be0-069a-44c3-9150-0bb0efc91d55"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("58f21f7f-2f16-4ac7-8ac8-ce14b47deace"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a030b9d0-e7a0-4ced-bbbe-9539dfb1dd22"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3825a909-209e-4923-923d-23603fc8a105"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("702fea70-3f23-4480-8b9f-b553d0a194a6"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				UId = new Guid("9bcb9ea2-2f79-4c66-be40-60fc89827613"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,78,44,40,201,204,207,179,50,180,50,212,241,76,177,50,176,50,0,0,176,27,135,17,18,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("492ae6cd-2386-4f94-b3dc-ecfe0a561e90"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2fabbf13-01ca-42c6-9f0d-07f14a79d614"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				UId = new Guid("96c84c00-2797-4646-a698-7f02695068c7"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				UId = new Guid("6356bc10-9b8b-4a7c-b5e7-8b18ccb8d4cd"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				UId = new Guid("c5c8881b-1545-4573-bffe-420faeaa97bc"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				UId = new Guid("64c177fe-eb36-4a4b-b7ae-91f33fcd1623"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				UId = new Guid("18bfd995-e4af-4ba7-9844-31322fbc7da7"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("753cf6dc-9ea4-44fd-adc1-48898e488426"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e8af8fcc-bceb-41bc-99dd-9e7f54a2cc6e"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55390786-dd46-43fb-add4-4f851434760e"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fbec98f-004d-4f1f-87a7-b668063d0884"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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
				UId = new Guid("de308fad-dcf4-42c5-832a-534722bee38f"),
				ContainerUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
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

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("a244c08e-bd09-4ca7-8a99-1077520a1ec5"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
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
				Value = @"c449d832-a4cc-4b01-b9d5-8a12c42a9f89",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("31b660b1-300f-4f12-a4b2-98efc57cd867"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("441998e4-8821-4d10-8a9c-40c050c8dd78"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("dde1dd64-30a8-4ef6-b1d1-6d6d6661ac9b"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1d10b34a-77ec-4277-99b6-ce89fe7cd27d"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,219,110,27,55,16,253,21,65,13,208,23,83,224,253,226,183,94,82,212,64,210,6,113,218,151,56,15,67,114,152,168,149,181,193,106,213,192,53,252,239,61,43,219,77,226,180,138,220,194,113,2,72,128,45,236,138,151,33,57,103,206,153,225,249,244,193,112,246,154,167,135,211,103,220,247,180,234,218,48,251,174,235,121,246,164,239,10,175,86,179,71,93,161,197,252,79,202,11,126,66,61,157,242,192,253,175,180,88,243,234,209,124,53,28,76,222,239,54,61,152,62,248,99,243,235,244,240,249,249,244,104,224,211,95,142,42,70,183,85,82,108,84,69,107,54,9,235,83,19,49,170,34,92,84,156,157,180,214,196,136,206,165,91,172,79,151,143,121,160,39,52,188,154,30,158,79,55,163,109,6,40,77,146,81,34,180,26,132,173,153,4,73,105,5,91,101,178,10,206,88,163,166,23,7,211,85,121,197,167,180,153,244,109,231,98,109,170,209,104,65,182,20,97,179,84,34,167,234,68,36,165,139,213,148,90,76,99,231,171,246,111,59,62,255,234,249,209,234,231,55,75,238,143,55,227,30,54,90,172,248,197,12,111,111,188,248,123,115,14,207,139,45,185,164,92,69,50,186,97,173,88,112,12,164,4,199,24,165,109,25,115,170,139,23,95,189,24,103,172,243,213,235,5,157,253,250,225,196,199,235,252,27,151,225,178,217,235,247,182,254,221,134,231,39,151,39,120,50,61,60,249,183,51,188,250,190,180,248,253,83,188,121,128,39,211,131,147,233,113,183,238,203,56,162,193,195,247,239,88,184,153,100,211,228,198,227,245,137,225,205,114,189,88,92,189,249,158,6,186,110,120,253,186,171,243,54,231,122,180,60,190,62,168,205,40,242,234,35,254,225,223,245,231,210,182,255,211,237,49,45,233,37,247,63,97,3,222,218,254,183,149,207,176,141,215,3,187,66,198,53,37,5,41,56,139,45,62,8,74,158,132,137,166,146,167,70,165,149,77,239,167,220,184,231,101,225,255,104,216,83,94,109,118,123,132,202,149,93,227,86,93,76,47,46,14,222,5,144,103,101,201,41,18,133,70,167,82,217,9,50,20,68,14,45,165,20,164,46,198,111,5,144,179,73,21,99,154,224,164,1,160,66,81,144,11,73,84,27,149,100,114,182,56,127,23,0,122,212,117,191,175,95,207,130,203,182,154,148,133,115,117,28,161,122,17,43,246,215,32,30,144,139,53,249,18,102,172,163,81,149,139,192,238,74,81,155,194,52,82,54,236,154,170,94,114,50,177,248,143,225,230,106,190,111,202,48,255,99,62,156,77,70,112,204,30,158,210,124,177,135,210,189,64,41,235,228,100,80,77,4,38,132,126,246,122,60,121,18,73,165,220,76,64,140,108,122,27,148,118,241,156,91,65,169,89,83,181,172,227,8,85,11,27,52,108,209,37,11,213,140,46,172,88,185,44,183,66,201,171,200,193,73,35,34,168,71,88,167,171,32,50,120,108,193,135,164,163,51,217,221,39,23,61,92,240,41,47,135,195,243,228,157,146,37,176,224,17,79,54,90,96,222,90,22,161,148,134,221,76,32,78,186,120,159,188,90,53,108,124,97,97,100,246,2,180,12,67,149,79,66,226,244,188,110,46,120,27,63,78,94,63,210,178,46,120,130,45,71,131,129,39,173,235,39,176,112,190,152,188,153,15,175,38,167,84,250,110,53,251,182,171,103,123,80,222,11,40,139,108,210,250,145,8,188,134,103,100,184,71,180,236,68,178,42,213,18,157,242,89,125,82,126,211,45,88,200,184,138,168,159,140,176,45,108,108,113,162,166,232,36,235,106,148,219,46,16,157,206,202,115,141,194,131,168,193,111,18,250,43,70,44,48,83,44,57,39,103,56,125,38,2,145,66,213,32,115,2,185,105,172,53,64,22,103,78,160,118,29,201,32,166,17,219,182,131,64,228,101,229,254,235,213,37,176,246,56,186,23,28,213,154,13,41,230,49,62,70,164,37,32,183,28,64,115,85,50,88,98,20,47,185,126,90,28,149,160,98,200,69,248,160,29,116,162,241,240,50,208,92,37,11,90,107,129,179,9,91,113,36,75,118,35,41,139,40,71,206,80,148,161,19,65,215,145,156,76,202,26,74,49,127,22,228,134,248,85,93,140,13,10,214,129,133,243,56,43,75,16,23,41,36,94,163,88,204,233,6,185,185,160,146,69,32,16,90,162,181,53,216,104,130,8,65,18,169,101,204,92,57,217,58,118,121,184,28,32,29,191,219,236,209,225,121,205,77,75,61,170,82,107,45,224,10,41,146,75,179,162,70,118,89,69,111,180,220,33,159,123,202,84,39,221,184,194,73,133,39,205,126,152,247,171,97,50,199,193,77,186,54,233,121,181,94,12,243,229,203,9,78,102,129,188,111,222,45,247,170,245,30,19,192,207,142,32,27,199,130,72,147,4,103,9,126,171,155,4,16,170,85,74,103,188,2,66,101,72,219,43,40,161,160,136,98,131,136,78,67,135,35,66,9,242,141,68,211,64,116,214,178,84,101,62,11,96,3,92,134,57,52,225,99,67,8,107,5,165,30,200,126,193,85,21,72,132,100,74,204,55,128,45,181,170,40,173,24,33,145,14,8,171,211,104,40,84,171,77,193,27,8,139,6,144,126,8,236,49,92,88,100,250,0,118,26,39,98,36,249,38,85,68,144,28,116,136,172,188,10,59,2,187,208,138,119,198,245,81,221,179,245,23,153,138,42,21,42,26,161,158,167,161,79,193,36,22,65,1,69,10,85,188,87,202,21,78,165,222,10,212,9,158,102,27,57,1,246,98,144,45,114,202,108,84,22,6,34,34,200,100,26,254,182,130,154,154,163,96,170,1,163,129,160,44,130,147,136,88,140,80,46,192,28,149,124,174,250,14,171,58,54,235,224,9,25,121,0,52,49,2,68,44,148,44,16,20,18,215,226,81,183,209,109,22,154,175,166,37,43,154,241,176,12,171,20,210,199,2,147,1,116,153,77,194,206,239,88,213,121,140,50,38,206,250,178,168,243,243,122,120,217,1,90,123,48,125,145,96,218,197,119,110,5,166,10,115,172,196,21,1,41,133,180,42,89,9,157,150,181,72,174,146,204,192,104,252,8,152,74,84,0,99,64,165,94,2,131,214,64,64,83,137,21,203,178,164,147,1,255,152,120,135,96,74,94,49,116,168,135,253,26,211,87,136,143,44,71,98,130,241,236,145,91,148,34,103,81,154,49,73,196,174,69,152,7,67,21,0,239,221,88,34,69,69,71,194,104,105,111,91,34,45,40,209,188,236,250,179,189,224,252,130,225,180,139,247,220,46,147,12,206,101,151,138,48,37,32,181,109,30,192,202,10,81,60,86,210,14,247,13,141,218,86,56,69,217,128,24,152,16,80,215,71,245,209,65,112,58,143,234,173,110,40,209,140,117,25,121,7,153,228,208,227,107,139,251,95,255,190,191,82,251,196,14,158,80,80,118,185,69,33,91,195,137,66,7,224,90,20,23,80,122,76,190,67,160,150,100,248,164,25,85,105,168,137,104,212,70,180,70,221,209,170,154,32,190,80,239,70,86,85,18,233,108,165,165,237,25,85,50,14,238,56,150,124,80,112,193,29,118,17,164,49,64,208,185,194,201,131,231,98,239,144,47,154,105,42,68,220,164,183,140,27,8,107,124,3,190,146,196,181,179,247,161,72,142,222,218,153,151,38,143,23,150,194,43,25,46,249,130,188,245,66,121,76,94,8,33,34,202,29,249,98,115,137,54,57,30,104,88,175,102,223,188,161,249,152,215,236,197,215,23,201,22,187,248,206,199,192,244,226,226,47,99,162,16,103,62,34,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b80339a8-820c-40b9-aa5e-7542914dc2df"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
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
				UId = new Guid("94e9a24c-27da-4f2f-898d-31e395dc6cc2"),
				ContainerUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
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

		protected virtual void InitializeReadDataUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("977cad3d-2c65-430b-8902-f756c05291e4"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,115,155,48,16,253,43,25,206,33,195,135,13,182,111,25,215,237,248,210,100,38,158,94,130,15,43,105,193,154,2,98,36,57,173,235,225,191,119,5,54,113,82,215,77,123,105,78,192,227,233,105,247,237,219,189,199,75,48,230,51,84,232,205,188,21,106,13,70,229,246,230,163,44,45,234,79,90,109,27,239,218,51,168,37,148,242,7,138,30,95,8,105,63,128,5,58,178,207,158,21,50,111,150,157,215,200,188,235,204,147,22,43,67,28,58,146,135,34,153,196,34,240,25,79,192,31,141,195,196,103,99,17,251,105,60,17,41,139,194,68,228,78,237,130,248,178,238,229,59,229,188,123,93,237,26,199,26,17,192,85,213,128,150,70,213,7,48,118,247,155,69,13,172,68,65,223,86,111,145,32,171,101,69,141,224,74,86,120,15,154,174,113,58,202,65,68,202,161,52,142,85,98,110,23,223,27,141,198,72,85,95,174,107,174,202,109,85,159,178,73,0,135,207,67,57,65,87,163,99,222,131,221,116,18,115,48,244,167,237,234,188,45,10,141,5,88,249,116,90,198,87,220,117,204,183,153,71,7,4,141,232,11,148,91,60,220,26,6,191,52,51,135,198,246,61,29,43,32,138,198,28,53,214,28,31,248,6,43,24,186,124,38,200,98,115,34,226,134,250,120,193,147,193,217,63,217,18,17,216,28,201,151,125,30,52,207,118,26,37,4,62,57,160,87,57,190,102,222,227,210,220,125,171,81,247,173,245,222,174,111,8,125,5,12,250,179,125,138,140,37,41,160,207,66,156,146,223,83,230,179,104,204,125,17,115,72,120,36,66,150,78,218,117,95,135,52,77,9,187,174,148,193,178,43,141,92,105,113,181,20,29,199,61,232,15,27,35,164,249,36,240,99,38,104,138,1,227,254,52,21,220,103,163,105,200,68,10,163,40,113,121,104,219,117,235,66,81,170,66,114,40,239,26,212,112,152,88,112,62,211,47,150,193,249,160,149,178,175,38,121,203,41,91,210,82,158,78,114,69,183,209,174,59,43,31,212,86,115,236,23,204,244,75,254,79,203,251,31,246,242,239,86,237,55,65,126,75,48,223,75,228,150,239,42,78,173,215,254,4,237,208,219,167,83,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9c6f141c-5da9-4856-8b61-9f48b7911781"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4e3be632-b70c-4b4c-8308-380d8171b89f"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a4a0e571-6551-46d8-9aa9-dd1afda8956c"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3c26302-9b0d-4a54-8335-90d353b47af9"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3be3fe2d-ee9f-45c2-915c-ea7ebe38b5e3"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				UId = new Guid("9f627d7b-d9c3-4a70-aa62-1e7d41fa025c"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,180,50,4,0,252,157,29,132,13,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("d5304989-02e5-4d55-9d1d-091d6ef8ca92"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1217e6ca-8d64-4667-ae20-c8be0b49ba25"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				UId = new Guid("48649703-f62f-4c0f-a38e-076044d6d4b2"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				UId = new Guid("fd373003-c24e-424c-b3c5-56117473ca44"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				UId = new Guid("2b34f769-63d0-497e-ba58-140a71c665cd"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				UId = new Guid("dcbdb688-b666-4348-9e82-b8f414a14ff9"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				UId = new Guid("97d4b158-03da-42e6-8e2d-9c1391a6e264"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("23ad489e-59f4-4704-a50f-89d316ef79aa"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("07605453-95da-4cae-bb85-94983ae46c6d"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,5,193,129,9,0,48,8,3,176,139,10,150,118,120,143,206,249,255,9,75,60,119,163,68,228,78,194,211,133,138,48,158,169,102,30,89,252,2,221,81,196,36,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4df5accf-b45e-4785-839d-c9360472a236"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				UId = new Guid("dd5564ee-277d-43ad-bbc6-bf73ebd13b2e"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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
				UId = new Guid("5b165516-cbae-4f7a-b065-9fbf5cb28241"),
				ContainerUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask fillemailusertask = CreateFillEmailUserTaskUserTask();
			FlowElements.Add(fillemailusertask);
			ProcessSchemaUserTask readdatausertask3 = CreateReadDataUserTask3UserTask();
			FlowElements.Add(readdatausertask3);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask4 = CreateReadDataUserTask4UserTask();
			FlowElements.Add(readdatausertask4);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			FlowElements.Add(scripttask2);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("aa5ade14-1be3-4e08-ac39-209a6b873b1c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(154, 146),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a758c66e-b1b6-431b-9ce4-e115f3479d9c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(156, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(83, 192));
			schemaFlow.PolylinePointPositions.Add(new Point(83, 93));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("5ebcb3b3-95e2-4b52-b11b-1cd548bd659e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(504, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("a7874379-205f-41fe-96f1-309febd80697"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{046d588f-d451-4b32-ae0e-3a1932e938b9}].[Parameter:{5719453e-2032-4300-a9bf-e4208bede94d}].[EntityColumn:{dbf202ec-c444-479b-bcf4-d8e5b1863201}]#] != string.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(329, 163),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("bb807e9b-583c-4859-9c29-095a70d66f33"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(402, 267),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("b27c22ab-0638-4e97-9349-352e005e3609"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(510, 266),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("69b7d2e9-299a-4779-a633-d185a4b71e04"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(634, 269),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fac52282-ed67-44a7-bd72-ed38e5e56220"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(935, 233));
			schemaFlow.PolylinePointPositions.Add(new Point(935, 113));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("08cbffd4-ed3f-46f8-a81f-4f5c5cdf4834"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(564, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fac52282-ed67-44a7-bd72-ed38e5e56220"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1006, 55));
			schemaFlow.PolylinePointPositions.Add(new Point(610, 55));
			schemaFlow.PolylinePointPositions.Add(new Point(610, 93));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("689283cf-dd44-4ce0-9556-210b607aa27c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(274, 100),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("4b3aed1a-644a-45c5-815c-97053ed16b8b"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{3015559e-cbc6-406a-88af-07f7930be832}]#]==[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{70620d00-e4ea-48d1-9fdc-4572fcd8d41b}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(324, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(384, 35));
			schemaFlow.PolylinePointPositions.Add(new Point(567, 35));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("4af39791-80bf-4a7d-9619-a1bf7a5ced17"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b}].[Parameter:{021d04f3-0d96-4292-a469-49763741f632}].[EntityColumn:{b59a15ea-751e-4fd8-8281-f1a3dc7190ff}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(688, 428));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("f37ba6da-aaaf-466c-b9bb-0e6ea73adcfd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(688, 233));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("0ff8f18a-1b60-4d3b-8549-3705eda4a5a3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ed81272-95c4-4558-9999-a96862be7013"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("b41b1611-c34b-431b-a6ec-a0a0e41e3b57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ed81272-95c4-4558-9999-a96862be7013"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("43d381c1-2317-4601-9d21-a326412570ef"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(210, 93));
			schemaFlow.PolylinePointPositions.Add(new Point(210, 92));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("56043e87-d590-4613-b649-bf6fa7e632b6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(318, 92));
			schemaFlow.PolylinePointPositions.Add(new Point(318, 93));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("cdb788c4-3d14-4967-b75e-18d8e829c806"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{57bee078-709b-4064-8102-a8d287b5ba04}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(255, 92));
			schemaFlow.PolylinePointPositions.Add(new Point(255, 1));
			schemaFlow.PolylinePointPositions.Add(new Point(567, 1));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bab75b4b-ea1f-49e7-8a58-3a33ef7f9457"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bab75b4b-ea1f-49e7-8a58-3a33ef7f9457"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"Terminate1",
				Position = new Point(553, 79),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(40, 79),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("70620d00-e4ea-48d1-9fdc-4572fcd8d41b");
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal2StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(20, 178),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ReadDataUserTask1",
				Position = new Point(349, 65),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ReadDataUserTask2",
				Position = new Point(451, 65),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateFillEmailUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"FillEmailUserTask",
				Position = new Point(551, 280),
				SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeFillEmailUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ReadDataUserTask3",
				Position = new Point(451, 280),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"AddDataUserTask1",
				Position = new Point(831, 205),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fac52282-ed67-44a7-bd72-ed38e5e56220"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ScriptTask1",
				Position = new Point(971, 85),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,81,65,106,195,48,16,60,199,224,63,44,62,201,80,12,57,167,41,24,55,41,190,54,233,3,182,214,54,136,42,50,72,178,131,41,249,123,86,34,165,142,220,147,164,221,153,157,153,213,136,22,176,243,106,84,126,106,37,108,161,150,242,21,61,126,56,178,71,116,223,235,234,157,186,222,202,86,110,242,76,125,129,8,141,166,55,134,152,212,155,234,141,124,235,246,132,126,176,180,51,248,169,73,138,130,49,181,155,76,183,59,163,210,7,50,146,108,81,150,240,147,103,171,180,14,52,187,111,193,208,5,82,72,34,89,178,145,213,140,85,133,35,114,196,95,144,0,186,2,105,71,81,117,228,148,145,210,104,69,198,239,25,216,219,137,245,26,141,206,221,159,33,203,115,212,125,64,189,136,96,138,245,157,183,67,168,212,246,52,156,185,47,138,225,193,88,241,4,137,211,104,53,104,255,26,155,7,191,135,93,118,196,210,233,98,114,24,252,207,208,184,139,116,13,12,205,51,75,252,67,6,56,2,109,110,126,184,91,109,244,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ExclusiveGateway1",
				Position = new Point(660, 280),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ReadDataUserTask4",
				Position = new Point(731, 400),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("5ed81272-95c4-4558-9999-a96862be7013"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"FormulaTask1",
				Position = new Point(831, 400),
				ResultParameterMetaPath = @"c4cbc9bd-932f-4649-87a1-e88804fb12c1",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,207,189,106,195,48,20,64,225,87,17,201,226,80,110,144,172,171,95,8,25,130,135,76,41,237,24,60,220,88,87,164,96,171,224,184,180,197,228,221,235,118,236,35,100,61,112,134,175,58,175,207,199,219,233,179,240,248,218,93,121,160,152,169,191,113,187,93,234,191,208,244,60,112,153,226,108,124,103,21,43,6,239,44,2,26,170,193,103,39,1,45,105,148,10,115,246,246,190,12,207,52,210,192,19,143,113,78,70,75,12,62,128,172,217,0,38,99,32,36,149,64,6,149,44,103,223,81,168,127,151,166,76,111,211,247,225,189,255,24,74,156,49,117,89,146,86,224,114,114,203,117,33,32,41,17,24,149,190,40,103,52,106,117,111,215,237,102,123,44,137,191,78,185,90,189,52,81,172,54,98,183,19,82,236,69,245,16,58,177,144,254,92,226,233,65,68,63,150,200,134,88,118,2,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ScriptTask2",
				Position = new Point(120, 65),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,84,77,111,219,48,12,61,219,191,66,245,201,6,2,3,237,113,105,50,180,73,90,100,88,91,172,206,218,227,160,216,76,170,205,145,60,125,180,11,218,252,247,81,146,227,216,94,186,29,166,131,63,68,242,137,228,123,98,6,188,0,57,219,80,86,146,17,89,128,148,84,137,149,78,39,66,2,62,248,138,173,141,164,154,9,158,102,91,149,129,214,140,175,85,122,13,250,129,150,6,206,149,150,184,49,142,191,42,144,232,206,33,183,190,3,18,6,81,102,170,74,72,157,129,124,102,57,184,35,162,1,241,1,233,108,83,233,109,50,12,217,138,244,98,45,246,92,93,1,213,70,194,140,211,101,9,69,28,185,240,27,80,138,174,225,198,148,154,125,166,124,109,240,39,74,200,219,27,249,47,136,135,179,40,73,200,107,24,204,213,164,20,10,46,120,49,251,197,52,246,67,75,3,195,48,120,166,146,228,84,193,61,228,66,22,243,2,45,113,166,41,214,198,214,156,150,167,105,99,56,25,145,107,195,138,186,188,48,8,62,146,227,142,104,250,208,54,157,53,166,97,72,112,25,133,93,34,241,244,114,246,11,114,163,133,36,197,178,249,28,245,235,157,113,133,149,78,47,15,91,113,146,56,156,87,247,108,42,184,123,225,32,51,40,209,233,139,1,185,37,35,76,196,122,112,120,33,126,191,71,71,146,46,68,21,159,218,90,112,161,36,74,179,225,113,52,65,48,100,51,114,128,243,34,122,207,126,35,10,182,98,80,92,110,143,57,9,174,105,174,173,159,151,135,119,72,175,164,216,212,16,251,144,57,230,35,63,9,214,138,170,77,65,122,119,44,159,116,174,102,63,13,45,59,167,52,57,164,143,79,32,225,16,214,137,240,233,89,245,43,29,183,121,71,149,80,85,183,201,211,212,162,106,62,165,154,222,3,197,235,68,164,127,141,142,246,60,245,60,34,170,117,138,15,188,214,148,121,218,28,43,118,189,60,177,18,72,236,33,81,37,180,176,220,6,45,207,230,219,178,44,236,105,120,114,237,143,55,193,151,227,175,171,21,231,56,62,116,105,216,139,222,52,116,253,11,162,75,108,31,135,42,133,178,6,120,23,101,63,55,246,196,247,1,152,58,28,224,178,69,164,186,180,81,43,203,118,152,29,37,39,127,196,185,139,221,197,174,168,164,27,208,32,21,130,90,225,79,153,147,58,149,219,58,175,1,17,203,239,200,215,56,118,114,105,247,186,245,71,156,124,246,226,64,25,117,102,196,110,208,247,118,165,46,96,83,149,84,131,11,176,241,78,102,42,189,168,59,118,176,31,65,64,112,86,49,224,86,204,77,139,119,237,20,119,182,35,184,46,170,42,203,159,160,48,37,246,126,33,217,122,109,175,207,242,60,195,121,223,25,126,183,66,99,187,114,55,226,199,113,61,157,49,39,220,137,163,191,122,239,101,123,45,133,169,236,37,250,214,107,65,226,243,15,130,222,180,122,20,242,135,170,104,14,233,45,242,48,232,15,179,137,145,18,75,180,187,181,195,129,176,129,27,201,29,181,184,242,119,205,205,241,95,187,112,23,74,192,241,207,253,12,255,13,46,148,246,35,231,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ab8e2b9d-422d-4dce-b15c-eb177262002f"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"),
				Name = @"ExclusiveGateway2",
				Position = new Point(232, 64),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b664894c-10e2-4207-9f2a-e18100f3a271"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f4ad8837-96b8-46ff-9488-8002103ea83c"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("275e8026-6921-41d0-bf0e-2f9d9f0051c4"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3af073b6-ff03-4de8-a1ef-c261aabf7ba8"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c9759650-9711-40d6-a7e2-c5aba34fe0a9"),
				Name = "Terrasoft.Core.Scheduler",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4cc50205-bb0b-4854-abab-6a774187dd16"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("84ceba09-0dcf-4ced-a843-30e0b024f78b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4f275d04-4104-4f26-9f0f-7b1eb2419c23"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("70f57acd-ff6a-42b0-9dd8-ec32c122c084"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "SysSettings",
				CreatedInPackageId = new Guid("0d63071a-6d99-47e6-b34e-9457e3237a19")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendEmailToSROwner(userConnection);
		}

		public override object Clone() {
			return new SendEmailToSROwnerSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToSROwner

	/// <exclude/>
	public class SendEmailToSROwner : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("bcf3ee7f-68f5-4fca-a4bd-ed1c17593c8b");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,85,77,111,219,48,12,253,43,129,207,85,33,219,178,36,231,54,116,217,208,203,90,172,197,46,75,15,148,68,37,198,252,17,200,78,183,174,200,127,31,109,167,89,91,164,107,54,96,88,7,52,151,216,196,35,245,72,235,241,221,70,182,132,182,253,0,21,70,211,232,18,67,128,182,241,221,241,187,162,236,48,188,15,205,122,21,29,69,45,134,2,202,226,59,186,49,62,115,69,247,22,58,160,148,219,249,207,10,243,104,58,223,95,99,30,29,205,163,162,195,170,37,12,165,248,204,228,10,12,103,82,9,193,132,19,192,140,69,96,200,211,88,103,78,164,60,143,71,228,83,197,79,154,106,5,1,199,51,134,242,126,120,188,188,89,245,208,152,2,118,128,20,109,83,111,131,105,79,162,157,213,96,74,116,244,222,133,53,82,168,11,69,69,221,224,101,81,225,57,4,58,171,175,211,244,33,2,121,40,219,30,85,162,239,102,223,86,1,219,182,104,234,231,200,149,235,170,190,143,166,2,184,123,221,210,225,3,199,30,121,14,221,114,40,113,74,180,54,3,203,55,139,69,192,5,116,197,245,125,18,95,240,102,192,29,54,63,74,112,244,149,62,65,185,198,123,103,62,236,228,4,86,221,216,208,120,60,1,66,177,88,30,220,235,110,98,207,181,155,80,112,117,7,62,176,230,222,30,18,73,193,235,62,48,86,185,123,156,71,159,79,219,179,175,53,134,11,187,196,10,198,169,93,29,83,244,81,96,86,98,133,117,55,189,69,233,114,207,53,103,90,122,201,132,231,156,129,144,146,249,132,199,232,165,65,149,103,27,74,216,17,154,222,90,46,164,201,100,206,108,236,50,38,4,34,51,232,51,150,120,110,185,74,141,68,237,54,87,35,241,162,93,149,112,51,112,31,59,92,226,196,66,139,147,37,180,19,131,88,79,168,255,98,81,163,155,116,205,164,233,169,31,127,68,219,4,183,253,18,253,31,229,89,43,108,46,173,96,113,172,56,19,96,61,3,157,35,203,165,214,144,122,101,193,27,186,56,244,163,156,92,43,244,74,231,76,199,54,165,158,44,50,109,210,132,57,106,79,106,35,51,52,175,218,250,133,182,14,155,223,171,182,158,211,150,116,202,38,134,52,146,36,92,49,161,48,99,64,114,99,92,167,152,56,5,24,59,247,72,91,30,48,241,214,104,150,163,177,180,214,180,102,160,100,202,178,24,180,119,202,3,231,234,41,109,157,244,186,130,218,141,50,154,216,128,180,191,221,94,57,9,203,185,224,152,176,52,85,164,250,140,167,164,250,52,99,105,162,77,198,57,196,30,183,114,234,245,84,54,139,194,66,121,182,194,64,87,102,88,135,241,126,35,121,224,64,253,146,10,77,211,141,227,217,45,185,158,230,192,229,238,186,73,151,230,38,35,69,199,253,30,18,60,67,70,163,161,219,151,104,145,163,79,92,44,50,34,67,46,220,239,193,139,102,29,236,214,245,218,209,126,255,200,86,255,129,89,254,142,255,237,117,160,67,28,229,191,245,138,191,187,233,95,63,247,11,91,95,167,47,101,19,109,162,205,15,216,121,190,243,4,12,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,43,205,77,74,45,178,50,180,50,212,241,76,177,50,176,50,0,0,237,33,101,51,17,0,0,0 })));
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
								new Guid("117d32f9-8275-4534-8411-1c66115ce9cd")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private bool _canReadUncommitedData = false;
			public override bool CanReadUncommitedData {
				get {
					return _canReadUncommitedData;
				}
				set {
					_canReadUncommitedData = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("046d588f-d451-4b32-ae0e-3a1932e938b9");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,93,111,211,48,20,253,43,85,158,231,41,137,29,39,238,219,52,10,218,11,155,216,180,23,202,131,99,95,119,22,249,146,237,14,74,213,255,206,117,210,149,13,21,173,240,2,18,121,114,142,206,61,62,247,203,219,68,53,210,251,247,178,133,100,158,220,129,115,210,247,38,156,191,181,77,0,247,206,245,235,33,57,75,60,56,43,27,251,13,244,132,47,180,13,111,100,144,24,178,93,254,80,88,38,243,229,113,141,101,114,182,76,108,128,214,35,7,67,42,86,9,202,68,69,106,158,106,194,152,0,34,42,154,18,90,139,66,152,76,211,28,242,137,249,43,241,203,190,29,164,131,233,142,81,222,140,199,187,205,16,169,25,2,106,164,88,223,119,123,144,70,19,126,209,201,186,1,141,255,193,173,1,161,224,108,139,217,192,157,109,225,70,58,188,43,234,244,17,66,146,145,141,143,172,6,76,88,124,29,28,120,111,251,238,53,115,205,186,237,158,179,81,0,14,191,123,59,233,232,49,50,111,100,120,24,37,174,208,214,110,116,121,177,90,57,88,201,96,31,159,155,248,12,155,145,119,90,253,48,64,99,151,238,101,179,134,103,119,190,204,228,82,14,97,74,104,186,30,9,206,174,30,78,206,245,80,177,215,210,205,17,28,158,200,39,106,30,205,33,231,8,62,70,96,82,121,58,46,147,143,87,254,250,75,7,238,86,61,64,43,167,170,125,58,71,244,39,96,209,64,11,93,152,111,107,101,40,64,105,8,175,76,65,152,81,146,72,86,107,2,58,83,89,89,8,170,170,122,135,1,7,67,243,109,154,103,58,101,134,146,84,11,78,88,46,114,12,225,130,48,81,114,90,178,204,112,154,199,144,69,23,108,216,76,147,48,223,150,41,207,83,157,166,4,24,72,194,42,157,17,97,180,34,172,40,115,163,116,165,89,134,23,77,233,90,63,52,114,115,127,200,234,3,72,61,83,210,195,44,86,2,215,202,249,48,139,203,52,235,205,12,107,188,110,130,237,86,51,28,165,6,84,236,229,249,5,214,125,213,1,140,122,177,169,168,34,11,90,106,35,74,66,105,134,35,195,211,156,212,101,85,19,202,50,73,139,90,209,204,224,200,236,226,23,103,164,95,89,37,155,235,1,28,206,224,56,3,233,241,237,121,177,118,177,51,174,239,195,84,239,67,103,47,251,46,72,21,70,59,79,35,172,120,165,141,174,13,41,202,26,43,194,177,9,2,10,74,104,197,57,55,166,150,25,85,232,7,95,159,152,245,109,191,118,106,191,237,126,122,118,254,232,57,249,11,143,196,239,236,253,209,205,59,101,147,254,179,29,185,250,135,102,122,151,236,190,3,116,120,106,19,70,7,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,243,75,204,77,181,50,180,50,212,241,76,177,50,176,50,0,0,248,134,94,83,15,0,0,0 })));
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
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
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

		#region Class: FillEmailUserTaskFlowElement

		/// <exclude/>
		public class FillEmailUserTaskFlowElement : FillEmailTemplateUserTask
		{

			#region Constructors: Public

			public FillEmailUserTaskFlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FillEmailUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("96510c7e-efc0-4848-a44e-7ccf55d9b17a");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_templateId = () => (Guid)(new Guid("b47e41c6-94d0-4d02-8531-4054c157c2ac"));
				_sysEntitySchemaId = () => (Guid)(((process.ReadDataUserTask3.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask3.ResultEntity.Schema.Columns.GetByName("UId").ColumnValueName) ? process.ReadDataUserTask3.ResultEntity.GetTypedColumnValue<Guid>("UId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			internal Func<Guid> _templateId;
			public override Guid TemplateId {
				get {
					return (_templateId ?? (_templateId = () => Guid.Empty)).Invoke();
				}
				set {
					_templateId = () => { return value; };
				}
			}

			internal Func<Guid> _sysEntitySchemaId;
			public override Guid SysEntitySchemaId {
				get {
					return (_sysEntitySchemaId ?? (_sysEntitySchemaId = () => Guid.Empty)).Invoke();
				}
				set {
					_sysEntitySchemaId = () => { return value; };
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

			public ReadDataUserTask3FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("6a3f340b-79dd-4dc2-8779-5140388e5320");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,193,142,218,48,16,253,151,156,215,43,136,179,78,178,183,138,165,189,181,72,160,158,184,76,236,73,176,214,193,145,237,172,74,87,252,123,237,4,40,72,89,109,168,132,218,106,111,241,211,155,201,155,231,231,121,141,184,2,107,191,66,141,209,99,180,66,99,192,234,210,221,127,150,202,161,249,98,116,219,68,119,145,69,35,65,201,159,40,122,124,46,164,123,2,7,190,228,117,253,187,195,58,122,92,15,247,88,71,119,235,72,58,172,173,231,248,18,150,11,145,228,60,33,73,153,35,73,48,227,36,103,140,19,140,115,94,198,44,45,10,150,246,204,183,154,207,116,221,128,193,254,31,93,251,178,251,92,237,154,64,157,122,128,119,20,105,245,246,0,210,32,194,206,183,80,40,20,254,236,76,139,30,114,70,214,126,26,92,201,26,23,96,252,191,66,31,29,32,79,42,65,217,192,82,88,186,249,143,198,160,181,82,111,223,19,167,218,122,123,206,246,13,240,116,60,200,153,116,26,3,115,1,110,211,181,232,123,237,59,157,159,170,202,96,5,78,190,156,203,120,198,93,199,28,231,160,47,16,254,158,190,131,106,241,204,153,203,89,102,208,184,126,164,163,0,79,49,178,218,140,158,247,228,218,123,35,199,30,108,142,228,145,61,7,167,136,51,15,190,4,160,43,155,129,13,190,237,131,115,44,193,20,99,74,9,45,210,146,36,177,16,36,167,211,7,66,31,50,202,232,52,77,32,23,31,49,91,203,157,93,0,127,134,10,239,175,136,217,40,51,175,142,217,165,144,255,55,110,193,66,165,43,201,65,125,107,208,120,23,59,237,147,225,48,92,164,136,133,169,181,118,75,190,193,26,78,138,252,45,245,72,167,227,120,13,80,240,66,96,94,132,135,206,72,146,77,40,41,196,180,32,148,97,34,68,10,105,150,115,47,200,175,234,160,124,169,91,195,15,241,181,253,142,254,163,221,251,23,82,127,221,146,28,76,205,152,20,220,100,157,252,163,118,45,135,222,253,205,157,187,233,203,216,71,251,95,72,180,142,225,185,8,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,78,44,40,201,204,207,179,50,180,50,212,241,76,177,50,176,50,0,0,176,27,135,17,18,0,0,0 })));
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
								new Guid("6c7394db-06ff-4050-91ef-8278e21dce15")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private bool _canReadUncommitedData = false;
			public override bool CanReadUncommitedData {
				get {
					return _canReadUncommitedData;
				}
				set {
					_canReadUncommitedData = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"));
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

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("642b124c-467a-47e3-8a39-a64f0b375256");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Title = () => new LocalizableString((process.Subject));
				_recordDefValues_Type = () => (Guid)(new Guid("e2831dec-cfc0-df11-b00f-001d60e938c6"));
				_recordDefValues_Body = () => new LocalizableString((process.FillEmailUserTask.Body));
				_recordDefValues_Sender = () => new LocalizableString((process.SenderEmail));
				_recordDefValues_Recepient = () => new LocalizableString(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
				_recordDefValues_Case = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_MessageType = () => (Guid)(new Guid("7f6d3f94-f36b-1410-068c-20cf30b39373"));
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("8038a396-7825-e011-8165-00155d043204"));
				_recordDefValues_IsHtmlBody = () => (bool)(true);
				_recordDefValues_EmailSendStatus = () => (Guid)(new Guid("603ba6af-6107-e011-a646-16d83cab0980"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Body", () => _recordDefValues_Body.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Sender", () => _recordDefValues_Sender.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Recepient", () => _recordDefValues_Recepient.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_MessageType", () => _recordDefValues_MessageType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsHtmlBody", () => _recordDefValues_IsHtmlBody.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_EmailSendStatus", () => _recordDefValues_EmailSendStatus.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Title;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<string> _recordDefValues_Body;
			internal Func<string> _recordDefValues_Sender;
			internal Func<string> _recordDefValues_Recepient;
			internal Func<Guid> _recordDefValues_Case;
			internal Func<Guid> _recordDefValues_MessageType;
			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<bool> _recordDefValues_IsHtmlBody;
			internal Func<Guid> _recordDefValues_EmailSendStatus;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,219,110,27,55,16,253,21,65,13,208,23,83,224,253,226,183,94,82,212,64,210,6,113,218,151,56,15,67,114,152,168,149,181,193,106,213,192,53,252,239,61,43,219,77,226,180,138,220,194,113,2,72,128,45,236,138,151,33,57,103,206,153,225,249,244,193,112,246,154,167,135,211,103,220,247,180,234,218,48,251,174,235,121,246,164,239,10,175,86,179,71,93,161,197,252,79,202,11,126,66,61,157,242,192,253,175,180,88,243,234,209,124,53,28,76,222,239,54,61,152,62,248,99,243,235,244,240,249,249,244,104,224,211,95,142,42,70,183,85,82,108,84,69,107,54,9,235,83,19,49,170,34,92,84,156,157,180,214,196,136,206,165,91,172,79,151,143,121,160,39,52,188,154,30,158,79,55,163,109,6,40,77,146,81,34,180,26,132,173,153,4,73,105,5,91,101,178,10,206,88,163,166,23,7,211,85,121,197,167,180,153,244,109,231,98,109,170,209,104,65,182,20,97,179,84,34,167,234,68,36,165,139,213,148,90,76,99,231,171,246,111,59,62,255,234,249,209,234,231,55,75,238,143,55,227,30,54,90,172,248,197,12,111,111,188,248,123,115,14,207,139,45,185,164,92,69,50,186,97,173,88,112,12,164,4,199,24,165,109,25,115,170,139,23,95,189,24,103,172,243,213,235,5,157,253,250,225,196,199,235,252,27,151,225,178,217,235,247,182,254,221,134,231,39,151,39,120,50,61,60,249,183,51,188,250,190,180,248,253,83,188,121,128,39,211,131,147,233,113,183,238,203,56,162,193,195,247,239,88,184,153,100,211,228,198,227,245,137,225,205,114,189,88,92,189,249,158,6,186,110,120,253,186,171,243,54,231,122,180,60,190,62,168,205,40,242,234,35,254,225,223,245,231,210,182,255,211,237,49,45,233,37,247,63,97,3,222,218,254,183,149,207,176,141,215,3,187,66,198,53,37,5,41,56,139,45,62,8,74,158,132,137,166,146,167,70,165,149,77,239,167,220,184,231,101,225,255,104,216,83,94,109,118,123,132,202,149,93,227,86,93,76,47,46,14,222,5,144,103,101,201,41,18,133,70,167,82,217,9,50,20,68,14,45,165,20,164,46,198,111,5,144,179,73,21,99,154,224,164,1,160,66,81,144,11,73,84,27,149,100,114,182,56,127,23,0,122,212,117,191,175,95,207,130,203,182,154,148,133,115,117,28,161,122,17,43,246,215,32,30,144,139,53,249,18,102,172,163,81,149,139,192,238,74,81,155,194,52,82,54,236,154,170,94,114,50,177,248,143,225,230,106,190,111,202,48,255,99,62,156,77,70,112,204,30,158,210,124,177,135,210,189,64,41,235,228,100,80,77,4,38,132,126,246,122,60,121,18,73,165,220,76,64,140,108,122,27,148,118,241,156,91,65,169,89,83,181,172,227,8,85,11,27,52,108,209,37,11,213,140,46,172,88,185,44,183,66,201,171,200,193,73,35,34,168,71,88,167,171,32,50,120,108,193,135,164,163,51,217,221,39,23,61,92,240,41,47,135,195,243,228,157,146,37,176,224,17,79,54,90,96,222,90,22,161,148,134,221,76,32,78,186,120,159,188,90,53,108,124,97,97,100,246,2,180,12,67,149,79,66,226,244,188,110,46,120,27,63,78,94,63,210,178,46,120,130,45,71,131,129,39,173,235,39,176,112,190,152,188,153,15,175,38,167,84,250,110,53,251,182,171,103,123,80,222,11,40,139,108,210,250,145,8,188,134,103,100,184,71,180,236,68,178,42,213,18,157,242,89,125,82,126,211,45,88,200,184,138,168,159,140,176,45,108,108,113,162,166,232,36,235,106,148,219,46,16,157,206,202,115,141,194,131,168,193,111,18,250,43,70,44,48,83,44,57,39,103,56,125,38,2,145,66,213,32,115,2,185,105,172,53,64,22,103,78,160,118,29,201,32,166,17,219,182,131,64,228,101,229,254,235,213,37,176,246,56,186,23,28,213,154,13,41,230,49,62,70,164,37,32,183,28,64,115,85,50,88,98,20,47,185,126,90,28,149,160,98,200,69,248,160,29,116,162,241,240,50,208,92,37,11,90,107,129,179,9,91,113,36,75,118,35,41,139,40,71,206,80,148,161,19,65,215,145,156,76,202,26,74,49,127,22,228,134,248,85,93,140,13,10,214,129,133,243,56,43,75,16,23,41,36,94,163,88,204,233,6,185,185,160,146,69,32,16,90,162,181,53,216,104,130,8,65,18,169,101,204,92,57,217,58,118,121,184,28,32,29,191,219,236,209,225,121,205,77,75,61,170,82,107,45,224,10,41,146,75,179,162,70,118,89,69,111,180,220,33,159,123,202,84,39,221,184,194,73,133,39,205,126,152,247,171,97,50,199,193,77,186,54,233,121,181,94,12,243,229,203,9,78,102,129,188,111,222,45,247,170,245,30,19,192,207,142,32,27,199,130,72,147,4,103,9,126,171,155,4,16,170,85,74,103,188,2,66,101,72,219,43,40,161,160,136,98,131,136,78,67,135,35,66,9,242,141,68,211,64,116,214,178,84,101,62,11,96,3,92,134,57,52,225,99,67,8,107,5,165,30,200,126,193,85,21,72,132,100,74,204,55,128,45,181,170,40,173,24,33,145,14,8,171,211,104,40,84,171,77,193,27,8,139,6,144,126,8,236,49,92,88,100,250,0,118,26,39,98,36,249,38,85,68,144,28,116,136,172,188,10,59,2,187,208,138,119,198,245,81,221,179,245,23,153,138,42,21,42,26,161,158,167,161,79,193,36,22,65,1,69,10,85,188,87,202,21,78,165,222,10,212,9,158,102,27,57,1,246,98,144,45,114,202,108,84,22,6,34,34,200,100,26,254,182,130,154,154,163,96,170,1,163,129,160,44,130,147,136,88,140,80,46,192,28,149,124,174,250,14,171,58,54,235,224,9,25,121,0,52,49,2,68,44,148,44,16,20,18,215,226,81,183,209,109,22,154,175,166,37,43,154,241,176,12,171,20,210,199,2,147,1,116,153,77,194,206,239,88,213,121,140,50,38,206,250,178,168,243,243,122,120,217,1,90,123,48,125,145,96,218,197,119,110,5,166,10,115,172,196,21,1,41,133,180,42,89,9,157,150,181,72,174,146,204,192,104,252,8,152,74,84,0,99,64,165,94,2,131,214,64,64,83,137,21,203,178,164,147,1,255,152,120,135,96,74,94,49,116,168,135,253,26,211,87,136,143,44,71,98,130,241,236,145,91,148,34,103,81,154,49,73,196,174,69,152,7,67,21,0,239,221,88,34,69,69,71,194,104,105,111,91,34,45,40,209,188,236,250,179,189,224,252,130,225,180,139,247,220,46,147,12,206,101,151,138,48,37,32,181,109,30,192,202,10,81,60,86,210,14,247,13,141,218,86,56,69,217,128,24,152,16,80,215,71,245,209,65,112,58,143,234,173,110,40,209,140,117,25,121,7,153,228,208,227,107,139,251,95,255,190,191,82,251,196,14,158,80,80,118,185,69,33,91,195,137,66,7,224,90,20,23,80,122,76,190,67,160,150,100,248,164,25,85,105,168,137,104,212,70,180,70,221,209,170,154,32,190,80,239,70,86,85,18,233,108,165,165,237,25,85,50,14,238,56,150,124,80,112,193,29,118,17,164,49,64,208,185,194,201,131,231,98,239,144,47,154,105,42,68,220,164,183,140,27,8,107,124,3,190,146,196,181,179,247,161,72,142,222,218,153,151,38,143,23,150,194,43,25,46,249,130,188,245,66,121,76,94,8,33,34,202,29,249,98,115,137,54,57,30,104,88,175,102,223,188,161,249,152,215,236,197,215,23,201,22,187,248,206,199,192,244,226,226,47,99,162,16,103,62,34,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "77b64dfc5e5942e8baa6a231f1fdd698",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
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

		#region Class: ReadDataUserTask4FlowElement

		/// <exclude/>
		public class ReadDataUserTask4FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask4FlowElement(UserConnection userConnection, SendEmailToSROwner process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("58c61e1e-8764-45a2-8f70-46a34014ff86");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,115,155,48,16,253,43,25,206,33,195,135,13,182,111,25,215,237,248,210,100,38,158,94,130,15,43,105,193,154,2,98,36,57,173,235,225,191,119,5,54,113,82,215,77,123,105,78,192,227,233,105,247,237,219,189,199,75,48,230,51,84,232,205,188,21,106,13,70,229,246,230,163,44,45,234,79,90,109,27,239,218,51,168,37,148,242,7,138,30,95,8,105,63,128,5,58,178,207,158,21,50,111,150,157,215,200,188,235,204,147,22,43,67,28,58,146,135,34,153,196,34,240,25,79,192,31,141,195,196,103,99,17,251,105,60,17,41,139,194,68,228,78,237,130,248,178,238,229,59,229,188,123,93,237,26,199,26,17,192,85,213,128,150,70,213,7,48,118,247,155,69,13,172,68,65,223,86,111,145,32,171,101,69,141,224,74,86,120,15,154,174,113,58,202,65,68,202,161,52,142,85,98,110,23,223,27,141,198,72,85,95,174,107,174,202,109,85,159,178,73,0,135,207,67,57,65,87,163,99,222,131,221,116,18,115,48,244,167,237,234,188,45,10,141,5,88,249,116,90,198,87,220,117,204,183,153,71,7,4,141,232,11,148,91,60,220,26,6,191,52,51,135,198,246,61,29,43,32,138,198,28,53,214,28,31,248,6,43,24,186,124,38,200,98,115,34,226,134,250,120,193,147,193,217,63,217,18,17,216,28,201,151,125,30,52,207,118,26,37,4,62,57,160,87,57,190,102,222,227,210,220,125,171,81,247,173,245,222,174,111,8,125,5,12,250,179,125,138,140,37,41,160,207,66,156,146,223,83,230,179,104,204,125,17,115,72,120,36,66,150,78,218,117,95,135,52,77,9,187,174,148,193,178,43,141,92,105,113,181,20,29,199,61,232,15,27,35,164,249,36,240,99,38,104,138,1,227,254,52,21,220,103,163,105,200,68,10,163,40,113,121,104,219,117,235,66,81,170,66,114,40,239,26,212,112,152,88,112,62,211,47,150,193,249,160,149,178,175,38,121,203,41,91,210,82,158,78,114,69,183,209,174,59,43,31,212,86,115,236,23,204,244,75,254,79,203,251,31,246,242,239,86,237,55,65,126,75,48,223,75,228,150,239,42,78,173,215,254,4,237,208,219,167,83,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,115,46,74,77,44,73,77,241,207,179,50,180,50,4,0,252,157,29,132,13,0,0,0 })));
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
								new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,5,193,129,9,0,48,8,3,176,139,10,150,118,120,143,206,249,255,9,75,60,119,163,68,228,78,194,211,133,138,48,158,169,102,30,89,252,2,221,81,196,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		public SendEmailToSROwner(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToSROwner";
			SchemaUId = new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_templateId = () => { return (Guid)(new Guid("b47e41c6-94d0-4d02-8531-4054c157c2ac")); };
			_senderEmail = () => { return new LocalizableString(((String)SysSettings.GetValue(UserConnection, "SupportServiceEmail"))); };
			_subject = () => { return new LocalizableString((FillEmailUserTask.Subject)); };
			_caseRecordId = () => { return (Guid)(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("77b64dfc-5e59-42e8-baa6-a231f1fdd698");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToSROwner, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToSROwner, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		private Func<Guid> _templateId;
		public virtual Guid TemplateId {
			get {
				return (_templateId ?? (_templateId = () => Guid.Empty)).Invoke();
			}
			set {
				_templateId = () => { return value; };
			}
		}

		private Func<string> _senderEmail;
		public virtual string SenderEmail {
			get {
				return (_senderEmail ?? (_senderEmail = () => null)).Invoke();
			}
			set {
				_senderEmail = () => { return value; };
			}
		}

		private Func<string> _subject;
		public virtual string Subject {
			get {
				return (_subject ?? (_subject = () => null)).Invoke();
			}
			set {
				_subject = () => { return value; };
			}
		}

		private Func<Guid> _caseRecordId;
		public virtual Guid CaseRecordId {
			get {
				return (_caseRecordId ?? (_caseRecordId = () => Guid.Empty)).Invoke();
			}
			set {
				_caseRecordId = () => { return value; };
			}
		}

		public virtual bool IsCloseAndExit {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("33ec13b0-6c8a-4620-8921-30f51798762c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("e6d9f080-86f6-4f00-a466-f201ef6be795"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal2;
		public ProcessStartSignalEvent StartSignal2 {
			get {
				return _startSignal2 ?? (_startSignal2 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal2",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("6d7c2bd5-2207-47e5-a6d9-083e2d7ae1dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private FillEmailUserTaskFlowElement _fillEmailUserTask;
		public FillEmailUserTaskFlowElement FillEmailUserTask {
			get {
				return _fillEmailUserTask ?? (_fillEmailUserTask = new FillEmailUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("fac52282-ed67-44a7-bd72-ed38e5e56220"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("79a25b3e-6735-442d-b68f-a2544aeea005"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadDataUserTask4FlowElement _readDataUserTask4;
		public ReadDataUserTask4FlowElement ReadDataUserTask4 {
			get {
				return _readDataUserTask4 ?? (_readDataUserTask4 = new ReadDataUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("5ed81272-95c4-4558-9999-a96862be7013"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("94bba729-c06a-4c0c-954a-a363bb53f98a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("7059a9d3-af29-4546-b5d1-b46029a486d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("a7874379-205f-41fe-96f1-309febd80697"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("4b3aed1a-644a-45c5-815c-97053ed16b8b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("4af39791-80bf-4a7d-9619-a1bf7a5ced17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2;
		public ProcessConditionalFlow ConditionalSequenceFlow2 {
			get {
				return _conditionalSequenceFlow2 ?? (_conditionalSequenceFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2",
					SchemaElementUId = new Guid("cdb788c4-3d14-4967-b75e-18d8e829c806"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FillEmailUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillEmailUserTask };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask4 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask2", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FillEmailUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FillEmailUserTask", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask4", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask4":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "ScriptTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != string.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask2", "ConditionalFlow1", "((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != string.Empty", result);
			return result;
		}

		private bool ConditionalFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("ModifiedBy").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ModifiedById") : Guid.Empty))==((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadDataUserTask1", "ConditionalFlow2", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"ModifiedBy\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"ModifiedById\") : Guid.Empty))==((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"Owner\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"OwnerId\") : Guid.Empty))", result);
			return result;
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("ParentActivity").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ParentActivityId") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow1", "((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName(\"ParentActivity\").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>(\"ParentActivityId\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCloseAndExit));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "ConditionalSequenceFlow2", "(IsCloseAndExit)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("IsCloseAndExit")) {
				writer.WriteValue("IsCloseAndExit", IsCloseAndExit, false);
			}
			if (!HasMapping("TemplateId")) {
				writer.WriteValue("TemplateId", TemplateId, Guid.Empty);
			}
			if (!HasMapping("SenderEmail")) {
				writer.WriteValue("SenderEmail", SenderEmail, null);
			}
			if (!HasMapping("Subject")) {
				writer.WriteValue("Subject", Subject, null);
			}
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
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
			MetaPathParameterValues.Add("e2d6e188-0536-4cbb-a47d-546de3233a1d", () => TemplateId);
			MetaPathParameterValues.Add("a7d24a5a-b023-47ad-be9a-c28a39a5ae4f", () => SenderEmail);
			MetaPathParameterValues.Add("c4cbc9bd-932f-4649-87a1-e88804fb12c1", () => Subject);
			MetaPathParameterValues.Add("7ebb67ae-b1e9-459b-b25c-d3ca6c2d1b78", () => CaseRecordId);
			MetaPathParameterValues.Add("57bee078-709b-4064-8102-a8d287b5ba04", () => IsCloseAndExit);
			MetaPathParameterValues.Add("c046b569-c1d5-44ee-bef5-2f0c073b6e8d", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("85939570-5e97-434a-8ec4-3e328c887084", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("fae2fcb8-9ebc-4d88-a763-51a8fd7fa007", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("df23ea66-cd2f-4c48-a92d-7b123685cf55", () => StartSignal2.EntitySchemaUId);
			MetaPathParameterValues.Add("9fe73c5e-c65c-4dc9-8a14-32ddee1d2062", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("faf88bc7-9ec3-474f-85c3-47d19c91dd4c", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("87c61dbc-e2fe-4c1d-a939-228b0714856a", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("489aeb16-3e43-4075-8bb1-f85b63fd422a", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("bc13a1cb-f6d2-48da-8094-9471e8db4dc6", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("c395b470-4a8b-4af1-9692-e47f4c846c96", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("38b53574-4673-4dd1-93d8-83f1e4d170ed", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("021d04f3-0d96-4292-a469-49763741f632", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("d1a08149-aeef-49fe-8363-1b80aad76636", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("f4318b8e-a4ba-4399-bb71-48847b675f4d", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("eda4e7cd-cb31-419b-ad36-22a6022aa70d", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("655b9008-70a9-4c03-a04d-b2f308450e34", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("25e0fa4b-970d-43dd-b80e-b2a2625e0dd3", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("bf24a190-2262-4aa4-b32e-c6169bca3b2f", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("014d404c-3972-44b9-a7b0-4e7fca6be3b6", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("7be14a6d-bf83-44ed-a78c-1601116baefd", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("f4e0fd1b-8be5-40bd-9ac3-e85c039c4f9f", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("ddb3398e-58cd-4e8c-9e32-678df8172a66", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("c4e67b30-1c3b-463c-a33c-d95308105c66", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("70b11618-c71a-4155-8014-3a53fd5cd1c8", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("67dd077f-eb7e-455c-bd25-7a2739501199", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("920a67b6-1c8c-4f36-a894-356d4b59f1df", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("d32b69b8-da12-4d43-9e3f-b871199dc2ac", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("5ef8e651-f0f6-44c6-bd11-f287de677557", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("ff3266dd-6661-4954-9be1-753c4436c33c", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("f4581450-6bde-48e5-8aeb-24e01a3f6cb3", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("5719453e-2032-4300-a9bf-e4208bede94d", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("76dd0aac-acbd-4d32-bed0-d30d3e00b7bf", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("485e921a-c9c1-4491-88dc-28252e30e587", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("250b6f40-ea89-421d-b1a1-885362269881", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("4a2e7dfa-30ae-4c59-b872-15ea611cc23d", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("e7d5edde-50a9-47cf-b4d3-02ad39fbec6a", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("984c8a1b-a1b9-4152-ae3f-a823be19b2fc", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("2d33dda1-70ec-434d-8bf0-4a150a70b973", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("e4e926dc-1916-4d49-b91e-d1b3b9ee27f6", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("6e2df57d-caef-4ef7-9bda-a15c8fe5861b", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("416fa2d3-de4d-44d5-9978-c81f98f5e3f1", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("f082c002-fcd5-4525-b652-643120eef8b6", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("e4f314d3-291c-45de-a2c4-0bb7a7a4a043", () => FillEmailUserTask.Subject);
			MetaPathParameterValues.Add("fd3e36ce-30b6-4382-a169-07ea62f57648", () => FillEmailUserTask.Body);
			MetaPathParameterValues.Add("4becebac-6618-4cf8-acff-5399dc9ef219", () => FillEmailUserTask.RecordId);
			MetaPathParameterValues.Add("8ada520f-9328-4d23-8e28-7cd84ab83abd", () => FillEmailUserTask.TemplateId);
			MetaPathParameterValues.Add("19997124-7bc1-4d68-91c0-f2a7263fc478", () => FillEmailUserTask.SysEntitySchemaId);
			MetaPathParameterValues.Add("09d4d948-3e28-4f04-9934-8ff03d3aee8c", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("fc417be0-069a-44c3-9150-0bb0efc91d55", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("58f21f7f-2f16-4ac7-8ac8-ce14b47deace", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a030b9d0-e7a0-4ced-bbbe-9539dfb1dd22", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("3825a909-209e-4923-923d-23603fc8a105", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("702fea70-3f23-4480-8b9f-b553d0a194a6", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("9bcb9ea2-2f79-4c66-be40-60fc89827613", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("492ae6cd-2386-4f94-b3dc-ecfe0a561e90", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("2fabbf13-01ca-42c6-9f0d-07f14a79d614", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("96c84c00-2797-4646-a698-7f02695068c7", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("6356bc10-9b8b-4a7c-b5e7-8b18ccb8d4cd", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("c5c8881b-1545-4573-bffe-420faeaa97bc", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("64c177fe-eb36-4a4b-b7ae-91f33fcd1623", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("18bfd995-e4af-4ba7-9844-31322fbc7da7", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("753cf6dc-9ea4-44fd-adc1-48898e488426", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("e8af8fcc-bceb-41bc-99dd-9e7f54a2cc6e", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("55390786-dd46-43fb-add4-4f851434760e", () => ReadDataUserTask3.IgnoreDisplayValues);
			MetaPathParameterValues.Add("4fbec98f-004d-4f1f-87a7-b668063d0884", () => ReadDataUserTask3.ResultCompositeObjectList);
			MetaPathParameterValues.Add("de308fad-dcf4-42c5-832a-534722bee38f", () => ReadDataUserTask3.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("a244c08e-bd09-4ca7-8a99-1077520a1ec5", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("31b660b1-300f-4f12-a4b2-98efc57cd867", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("441998e4-8821-4d10-8a9c-40c050c8dd78", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("dde1dd64-30a8-4ef6-b1d1-6d6d6661ac9b", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("1d10b34a-77ec-4277-99b6-ce89fe7cd27d", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("b80339a8-820c-40b9-aa5e-7542914dc2df", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("94e9a24c-27da-4f2f-898d-31e395dc6cc2", () => AddDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("977cad3d-2c65-430b-8902-f756c05291e4", () => ReadDataUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("9c6f141c-5da9-4856-8b61-9f48b7911781", () => ReadDataUserTask4.ResultType);
			MetaPathParameterValues.Add("4e3be632-b70c-4b4c-8308-380d8171b89f", () => ReadDataUserTask4.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a4a0e571-6551-46d8-9aa9-dd1afda8956c", () => ReadDataUserTask4.NumberOfRecords);
			MetaPathParameterValues.Add("e3c26302-9b0d-4a54-8335-90d353b47af9", () => ReadDataUserTask4.FunctionType);
			MetaPathParameterValues.Add("3be3fe2d-ee9f-45c2-915c-ea7ebe38b5e3", () => ReadDataUserTask4.AggregationColumnName);
			MetaPathParameterValues.Add("9f627d7b-d9c3-4a70-aa62-1e7d41fa025c", () => ReadDataUserTask4.OrderInfo);
			MetaPathParameterValues.Add("d5304989-02e5-4d55-9d1d-091d6ef8ca92", () => ReadDataUserTask4.ResultEntity);
			MetaPathParameterValues.Add("1217e6ca-8d64-4667-ae20-c8be0b49ba25", () => ReadDataUserTask4.ResultCount);
			MetaPathParameterValues.Add("48649703-f62f-4c0f-a38e-076044d6d4b2", () => ReadDataUserTask4.ResultIntegerFunction);
			MetaPathParameterValues.Add("fd373003-c24e-424c-b3c5-56117473ca44", () => ReadDataUserTask4.ResultFloatFunction);
			MetaPathParameterValues.Add("2b34f769-63d0-497e-ba58-140a71c665cd", () => ReadDataUserTask4.ResultDateTimeFunction);
			MetaPathParameterValues.Add("dcbdb688-b666-4348-9e82-b8f414a14ff9", () => ReadDataUserTask4.ResultRowsCount);
			MetaPathParameterValues.Add("97d4b158-03da-42e6-8e2d-9c1391a6e264", () => ReadDataUserTask4.CanReadUncommitedData);
			MetaPathParameterValues.Add("23ad489e-59f4-4704-a50f-89d316ef79aa", () => ReadDataUserTask4.ResultEntityCollection);
			MetaPathParameterValues.Add("07605453-95da-4cae-bb85-94983ae46c6d", () => ReadDataUserTask4.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4df5accf-b45e-4785-839d-c9360472a236", () => ReadDataUserTask4.IgnoreDisplayValues);
			MetaPathParameterValues.Add("dd5564ee-277d-43ad-bbc6-bf73ebd13b2e", () => ReadDataUserTask4.ResultCompositeObjectList);
			MetaPathParameterValues.Add("5b165516-cbae-4f7a-b065-9fbf5cb28241", () => ReadDataUserTask4.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "IsCloseAndExit":
					if (!hasValueToRead) break;
					IsCloseAndExit = reader.GetValue<System.Boolean>();
				break;
				case "TemplateId":
					if (!hasValueToRead) break;
					TemplateId = reader.GetValue<System.Guid>();
				break;
				case "SenderEmail":
					if (!hasValueToRead) break;
					SenderEmail = reader.GetValue<System.String>();
				break;
				case "Subject":
					if (!hasValueToRead) break;
					Subject = reader.GetValue<System.String>();
				break;
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var activityId = AddDataUserTask1.RecordId;
			if (UserConnection.GetIsFeatureEnabled("UseAsyncEmailSender")) {
				AsyncEmailSender emailSender = new AsyncEmailSender(UserConnection);
				emailSender.SendAsync(activityId);
			} else {
				var emailClientFactory = ClassFactory.Get<EmailClientFactory>(new ConstructorArgument("userConnection", UserConnection));
				var activityEmailSender = new ActivityEmailSender(emailClientFactory, UserConnection);
				activityEmailSender.Send(activityId);
			}
				
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localSubject = (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null))).IndexOf("RE: ") == 0 ? (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null))) : "RE: " + (((ReadDataUserTask4.ResultEntity.IsColumnValueLoaded(ReadDataUserTask4.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask4.ResultEntity.GetTypedColumnValue<string>("Title") : null)));
			Subject = (System.String)localSubject;
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			SenderEmail = Terrasoft.Core.Configuration.SysSettings.GetValue<string>(UserConnection, 
				"SupportServiceEmail", string.Empty);
			if (UserConnection.GetIsFeatureEnabled("EmailMessageMultiLanguage") || UserConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2")) {
				IsCloseAndExit = true;
				var caseRecordId = (StartSignal1.RecordId != Guid.Empty)
					? StartSignal1.RecordId 
					: StartSignal2.RecordId;
			    using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection())
			    {
			    	var caseOwnerSelectQuery =
					    new Select(UserConnection).Top(1)
								.Column("Case", "OwnerId")
								.Column("Case", "ModifiedById")
								.Column("Contact", "Email")
							.From("Case")
								.InnerJoin("Contact")
									.On("Case", "OwnerId").IsEqual("Contact", "Id")
							.Where("Case", "Id").IsEqual(Column.Const(caseRecordId)) as Select;
			        using (IDataReader reader = caseOwnerSelectQuery.ExecuteReader(dbExecutor))
			        {
				        while (reader.Read())
				        {
					        var owner = reader.GetColumnValue<Guid>("OwnerId");
					        var modifiedBy = reader.GetColumnValue<Guid>("ModifiedById");
					        var assignee = reader.GetColumnValue<string>("Email");
					        var isModifiedByOwner = owner == modifiedBy;
					        if (!isModifiedByOwner) {
						        var parameters = new Dictionary<string, object>()
						        {
							        { "CaseRecordId", caseRecordId },
							        { "EmailTemplateId", CaseConsts.AssigneeTemplateId },
							        { "Recipient", assignee }
						        };
								AppScheduler.TriggerJob<SendMultiLanguageNotification>(string.Concat("SendMultiLanguageNotificationExecutorGroup", "_", caseRecordId),
									UserConnection.Workspace.Name, UserConnection.CurrentUser.Name, parameters, true);
					        }
						}
			        }
			    }
			}
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
			var cloneItem = (SendEmailToSROwner)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

