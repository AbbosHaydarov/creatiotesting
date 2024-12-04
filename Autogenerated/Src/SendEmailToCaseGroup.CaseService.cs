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
	using Terrasoft.Mail;
	using Terrasoft.Mail.Sender;

	#region Class: SendEmailToCaseGroupSchema

	/// <exclude/>
	public class SendEmailToCaseGroupSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendEmailToCaseGroupSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendEmailToCaseGroupSchema(SendEmailToCaseGroupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendEmailToCaseGroup";
			UId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
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
			RealUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateIsNeedSendEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("56772c15-0da6-416b-89f3-18ff8e888563"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"IsNeedSendEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateRecipientEmailsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7ea8c009-6542-4fdd-9572-6a844d21ab92"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"RecipientEmails",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateTemplateIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("94d0d4a6-3942-434c-add8-db0c09b339ba"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.0dc0759c-80b3-48b3-a832-7e32925d748b#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ce79eab9-3a98-423f-b3e9-66323aac7d60"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("50441308-78db-4135-97ae-5d3c91b5f48f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailSenderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fb6b20e1-ef67-4e02-ae21-d8d6528daffe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"EmailSender",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsNeedSendEmailParameter());
			Parameters.Add(CreateRecipientEmailsParameter());
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateCaseRecordIdParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateEmailSenderParameter());
		}

		protected virtual void InitializeReadCaseDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4bff0fd5-1b5b-42da-97ec-43b95e6ba9cb"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,115,155,48,16,253,43,25,206,81,6,1,22,224,91,199,117,59,190,52,153,137,39,151,146,195,34,45,182,166,96,24,73,78,235,122,252,223,187,2,219,113,58,238,196,205,37,225,2,122,60,189,125,251,181,13,100,13,214,126,131,6,131,113,48,71,99,192,182,149,187,249,162,107,135,230,171,105,215,93,112,29,88,52,26,106,253,27,213,128,79,149,118,159,193,1,93,217,22,207,10,69,48,46,206,107,20,193,117,17,104,135,141,37,14,93,137,195,60,229,66,164,44,18,163,17,75,66,21,178,50,9,83,150,0,86,32,226,60,143,146,108,96,254,75,124,210,54,29,24,28,98,244,242,85,255,57,223,116,158,202,9,144,61,69,219,118,181,7,99,111,194,78,87,80,214,168,232,236,204,26,9,114,70,55,148,13,206,117,131,119,96,40,150,215,105,61,68,164,10,106,235,89,53,86,110,250,171,51,104,173,110,87,175,153,171,215,205,234,148,77,2,120,60,238,237,132,189,71,207,188,3,183,236,37,102,100,107,215,187,252,180,88,24,92,128,211,79,167,38,126,224,166,231,93,86,63,186,160,168,75,15,80,175,241,36,230,203,76,38,208,185,33,161,33,60,17,140,94,44,47,206,245,88,177,215,210,141,8,236,14,228,11,53,207,230,16,9,2,159,60,48,168,28,62,139,224,251,204,222,254,92,161,185,151,75,108,96,168,218,227,13,161,127,1,71,253,241,86,98,154,35,148,57,139,33,207,88,18,197,21,43,99,204,153,16,113,20,3,200,84,137,112,247,56,248,208,182,171,97,243,112,12,55,1,139,87,6,101,107,212,213,190,116,254,69,127,184,202,36,23,145,98,16,103,21,75,202,44,99,32,65,50,228,35,142,82,102,163,84,132,212,105,255,248,134,180,11,45,161,190,237,208,80,195,251,130,243,243,163,250,98,198,125,25,76,219,186,33,185,99,25,189,171,222,203,97,88,178,72,34,77,4,103,42,27,1,165,8,130,149,185,138,153,200,69,37,149,226,156,251,16,59,218,115,95,233,251,118,109,228,126,175,236,176,224,111,90,220,119,88,199,255,217,176,179,51,126,201,204,126,148,105,156,125,148,73,219,5,187,63,86,247,126,159,70,6,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a33f837c-29dc-4fee-a6ce-9b43656fdcf8"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abb94808-5aed-4a2b-91a0-b3c4e019244f"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5c31db74-03b4-4e13-b937-a5bd1c4b9346"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("43f58502-a3f9-4d89-8b05-bfd006634914"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9bbb4181-ec2f-4b6d-9c67-a8acb3d3bb29"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("71f14a14-3659-44b0-8b17-52639bb50b8b"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("b3e79b7f-0cf2-4db9-a3b5-50f22bd30da9"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b94c3537-238d-4c55-bf91-3524d23fa348"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("11c9e107-95c8-4c1c-9999-e948c31b229b"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("ec11c857-840d-4bf0-81d9-e4b22444f6a4"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("a7dfeac1-20f7-4098-9ddf-8b4e9e037ab5"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("3b5fc9e6-f635-4946-96d0-99a07663b06a"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("1b1d7240-335a-4137-9822-956528e4d5c8"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("79abe934-9fa1-465e-b36c-e6a83fcae767"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a7890ce-b0ce-4cb6-9467-4d2a3d591114"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("957348b6-6c6f-4f23-9005-92046516fcbf"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("74549e07-b7b2-4d9e-a3ca-5d66f1b86360"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("3e942e6c-6660-4f9a-a3f3-043202ffc52e"),
				ContainerUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
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
				UId = new Guid("5601149a-7688-4bb0-829b-346b4f6428e9"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,211,64,20,253,23,175,235,200,142,227,87,119,40,4,118,16,41,17,43,111,174,199,215,206,168,118,108,205,76,42,66,21,137,63,160,221,34,248,7,132,84,21,33,186,105,212,21,127,193,151,112,103,28,66,42,5,213,84,138,0,177,24,105,124,116,230,206,185,103,142,239,153,197,74,144,242,25,84,104,29,91,83,20,2,100,157,171,222,19,94,42,20,79,69,189,104,172,35,75,162,224,80,242,87,152,181,248,40,227,234,49,40,160,35,103,201,207,10,137,117,156,236,175,145,88,71,137,197,21,86,146,56,116,36,138,48,205,195,192,179,253,220,79,237,129,159,229,118,10,78,100,251,94,26,100,24,167,81,218,143,91,230,175,138,15,235,170,1,129,237,29,166,124,110,182,211,101,163,169,46,1,204,80,184,172,231,27,208,211,34,228,104,14,105,137,25,125,43,177,64,130,148,224,21,117,131,83,94,225,24,4,221,165,235,212,26,34,82,14,165,212,172,18,115,53,122,217,8,148,146,215,243,251,196,149,139,106,190,203,166,2,184,253,220,200,113,140,70,205,28,131,154,153,18,109,173,149,209,249,168,40,4,22,160,248,233,174,140,19,92,26,102,55,7,233,64,70,239,244,2,202,5,238,56,115,183,151,33,52,170,109,41,177,214,231,95,223,173,207,111,190,172,47,110,222,152,227,130,23,179,206,125,111,221,187,175,245,62,129,205,15,114,199,154,123,187,233,71,4,158,106,192,28,27,130,212,254,173,180,131,110,223,203,124,8,115,27,125,39,182,7,12,29,59,142,67,180,49,240,82,6,238,192,77,29,248,31,51,54,89,202,49,176,19,40,176,215,61,110,221,204,124,64,220,110,63,81,220,62,208,250,76,235,114,125,241,237,245,219,30,237,222,111,208,43,90,31,55,251,107,90,154,125,249,47,7,83,155,93,214,5,103,80,62,111,80,144,223,70,187,179,63,54,119,242,22,232,174,235,90,77,216,12,43,216,42,162,247,108,17,163,99,251,96,97,159,158,10,67,219,143,125,143,230,195,32,180,33,140,60,59,112,7,145,23,48,230,3,115,73,16,13,119,173,124,82,47,4,219,4,93,182,83,253,65,211,250,15,252,31,191,55,86,247,166,166,75,10,14,50,120,254,82,187,38,251,38,196,193,157,59,232,159,177,178,86,223,1,34,58,131,223,235,8,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("33bce745-fb67-43b6-b483-90cf9af1f475"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1bec890-46fb-4d20-8d4a-05948010b323"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b2c93dd-c44c-440a-9072-328f06f7b94c"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f13d3489-febd-495e-87cf-34c08df24766"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5109a2ba-50c9-44b0-8714-4102a725b645"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("82ffd8c0-e88a-4530-87aa-024e8633e4d5"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("6f04cfdc-2015-4135-b910-ee8e91e73e65"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("81e8c52d-6348-476a-919b-4c222b549563"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("f54c25eb-87ff-4e05-9ea4-fa641521ef7d"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("bf35315a-7b9b-4e81-9cca-4628bc3abbe5"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("19ab1ec6-b279-4170-9439-600c31df5a4a"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("bafbaee0-2586-4010-ba1c-e98dd9e853cc"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("6abdacf3-1dd7-4b36-b7bc-80b7b2a13122"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("31a337f9-edbe-45b5-995e-4c7b22eee133"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9f758c03-00f6-4843-b6eb-99c9178eaf1a"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bbc539f4-868f-49dd-9dd3-cef59500c068"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("805f2f6b-54fa-4d2e-a41b-6cf52ce7d3b8"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("82ffbb9b-0add-45df-861f-c2a25682c5a7"),
				ContainerUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
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
				UId = new Guid("eb64ce85-4fbd-4226-97de-985e5b9fef59"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				UId = new Guid("35173a57-a2e2-479f-aa27-bd861b439f14"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				UId = new Guid("80f75966-6900-4fcd-8f09-804f82c014af"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dc83797-2f02-421a-8c91-14b4b0109539}].[Parameter:{b3e79b7f-0cf2-4db9-a3b5-50f22bd30da9}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86a9ca15-a29b-468f-92c9-7070bbd6f371"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.0dc0759c-80b3-48b3-a832-7e32925d748b#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var sysEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9fbf2e69-990b-41f6-8ec5-c33d551a4914"),
				ContainerUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
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
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{d8487221-4c12-4a8e-9887-24309eafbaea}].[Parameter:{6f04cfdc-2015-4135-b910-ee8e91e73e65}].[EntityColumn:{ed98cf3e-1642-4755-acb2-a61181429306}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(sysEntitySchemaIdParameter);
		}

		protected virtual void InitializeAddEmailDataUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("847cacd4-6fdf-4340-890f-2d494c4c5c98"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("31e0eb82-93a1-4879-91aa-b744930a4611"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("567a0c1b-7356-49ce-93db-d58cb11abf8f"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("6a9f6041-ec7b-424a-88e3-3c868e83e490"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("91d4d62a-3cec-433d-b549-0651c8113c05"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,93,79,91,71,16,253,43,150,147,71,214,218,239,15,191,181,73,170,34,37,109,20,210,188,4,30,102,119,103,137,91,99,163,235,75,34,138,248,239,61,215,64,18,104,107,160,21,129,72,248,225,218,190,190,187,59,59,59,103,206,204,241,201,248,105,127,124,200,227,233,248,45,119,29,173,150,173,159,60,91,118,60,121,221,45,11,175,86,147,151,203,66,243,217,159,148,231,252,154,58,58,224,158,187,119,52,63,226,213,203,217,170,223,26,93,30,54,222,26,63,253,184,254,117,60,125,127,50,222,238,249,224,183,237,138,217,171,38,21,3,177,208,89,89,97,139,149,34,154,162,132,42,201,5,233,11,103,31,49,184,44,231,71,7,139,87,220,211,107,234,63,140,167,39,227,245,108,152,192,214,210,36,25,37,66,171,65,216,154,73,144,148,86,176,85,38,171,224,140,53,106,124,186,53,94,149,15,124,64,235,69,191,12,46,214,166,26,141,22,100,75,17,54,75,37,114,170,78,68,82,186,88,77,169,197,52,12,62,127,254,203,192,247,79,222,111,175,126,253,180,224,110,103,61,239,180,209,124,197,123,19,220,189,114,227,179,115,166,39,78,90,24,37,163,8,177,102,129,143,78,164,97,235,174,154,146,84,118,205,198,118,186,247,100,111,88,177,206,86,135,115,58,126,247,247,133,119,142,242,239,92,250,179,199,14,47,185,254,235,7,79,118,207,78,112,119,60,221,253,183,51,60,127,63,179,248,242,41,94,61,192,221,241,214,238,120,103,121,212,149,97,70,131,47,207,191,178,112,189,200,250,145,43,95,47,78,12,119,22,71,243,249,249,157,231,212,211,197,131,23,183,151,117,214,102,92,183,23,59,23,7,181,158,69,158,191,196,63,92,46,94,103,182,253,159,97,175,104,65,251,220,253,2,7,124,177,253,179,149,111,225,198,139,137,93,33,227,154,146,130,20,130,197,22,31,4,37,79,194,68,83,201,83,163,210,202,122,244,27,110,220,241,162,240,127,52,236,13,175,214,222,30,160,114,110,215,224,170,211,241,233,233,214,215,0,74,133,67,114,201,9,237,170,23,54,229,44,114,54,30,113,140,0,46,94,231,104,204,70,0,121,21,57,56,105,128,187,140,29,57,93,5,145,193,215,22,124,72,58,58,147,221,125,2,232,197,156,15,120,209,79,79,176,140,101,226,44,42,53,172,21,148,23,177,70,18,140,252,209,116,244,41,84,115,122,25,113,198,169,96,200,225,140,52,107,12,73,13,123,211,65,228,26,189,202,214,164,166,236,245,136,251,153,22,117,206,35,184,28,15,244,60,106,203,110,4,11,103,243,209,167,89,255,97,116,64,165,91,174,38,63,46,235,241,35,40,239,5,148,69,54,105,61,206,21,23,137,40,44,32,17,203,200,174,86,165,90,162,83,62,171,111,10,202,144,36,35,86,171,40,3,21,89,107,129,8,67,69,104,41,51,194,84,185,22,55,179,154,179,73,21,99,154,224,52,108,171,80,20,8,227,36,170,141,74,50,57,91,156,191,11,80,190,92,46,255,56,58,156,4,151,109,53,41,11,231,234,48,3,50,75,172,72,122,166,217,68,46,214,228,75,152,176,142,70,85,46,2,41,79,138,218,20,150,145,178,193,107,170,122,201,201,196,226,175,131,214,249,122,63,148,126,246,113,214,31,143,6,198,154,188,24,176,245,8,165,123,129,82,214,201,201,160,154,8,76,73,88,246,122,56,121,18,73,165,220,76,48,186,53,189,9,74,55,137,156,91,65,73,167,160,168,69,37,124,171,12,36,52,6,172,163,21,197,5,23,89,115,105,109,51,191,81,115,20,76,53,0,31,98,21,21,88,18,17,155,17,10,19,20,86,201,231,170,239,16,74,54,235,224,9,110,8,10,101,173,205,137,68,230,84,133,9,137,107,241,0,139,110,147,208,124,53,45,89,209,140,135,101,22,14,147,62,14,249,162,52,35,179,73,240,252,13,161,244,10,5,29,206,250,12,73,191,30,245,251,203,217,98,255,17,76,223,37,152,110,18,59,183,227,165,152,216,33,51,163,89,210,48,72,33,91,231,170,130,104,156,66,116,150,164,147,188,17,76,37,42,219,40,40,193,82,161,133,49,218,9,42,177,98,91,150,116,50,92,149,137,119,8,166,228,21,107,25,61,170,111,141,229,235,80,202,73,212,190,86,102,197,222,86,95,138,156,68,105,34,153,4,175,69,152,7,67,21,0,239,221,192,75,72,74,18,70,75,123,91,94,42,168,251,246,151,221,241,35,55,125,199,112,186,73,244,220,10,78,46,17,177,68,161,233,157,67,239,21,129,207,1,8,34,213,68,236,82,96,180,23,155,203,60,168,30,158,107,20,30,77,36,200,77,86,145,98,68,193,151,41,150,156,147,51,156,30,136,120,209,178,207,96,80,32,191,161,231,181,44,177,46,107,37,106,172,222,233,136,158,172,241,245,173,212,186,180,27,173,120,81,185,123,36,165,123,65,81,173,217,144,98,22,50,112,4,10,128,162,28,128,167,42,25,82,192,80,193,231,250,77,155,165,162,178,138,132,70,158,8,0,178,50,38,32,154,7,102,74,168,237,108,86,53,208,102,9,48,20,168,128,54,136,232,6,86,195,70,4,249,70,2,28,23,51,130,182,128,149,30,132,130,1,43,35,184,59,8,221,0,31,171,145,187,34,148,63,20,124,121,88,24,185,200,164,43,10,70,54,144,119,114,64,87,85,26,134,212,156,4,65,144,17,78,54,173,115,53,178,210,122,200,139,69,15,158,122,182,246,209,244,100,200,74,22,82,149,40,118,200,111,141,161,128,152,161,112,160,28,116,136,172,188,10,215,131,245,13,58,88,48,223,138,71,21,129,52,154,252,52,235,86,253,104,134,131,27,45,219,168,227,213,209,188,71,113,57,194,201,204,161,72,206,150,139,201,118,125,68,245,119,201,141,74,65,61,211,13,189,145,14,136,24,200,230,144,80,80,57,169,226,189,82,104,148,82,169,183,66,181,180,218,58,106,74,52,176,33,164,55,219,64,109,18,98,1,148,139,98,32,204,171,180,25,213,178,100,55,216,45,48,10,162,142,162,12,9,100,64,12,57,153,148,53,4,112,63,16,110,132,207,35,148,158,132,58,192,2,164,173,130,198,93,208,96,245,104,81,102,192,244,164,111,2,183,50,59,156,33,81,156,137,139,171,71,36,221,11,146,30,156,152,232,32,226,39,11,32,64,251,195,197,59,104,129,53,123,72,131,18,236,17,2,138,200,205,85,102,148,13,12,8,34,8,144,236,48,139,3,63,58,15,97,70,55,148,157,67,173,41,239,0,73,125,135,183,13,1,127,241,251,227,95,88,223,56,192,147,204,222,229,22,133,108,195,255,40,80,155,68,12,208,150,181,69,115,20,240,95,74,146,23,18,221,157,5,248,222,233,95,131,101,45,171,97,30,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("296257aa-1125-48e6-a411-79017af52a29"),
				ContainerUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
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
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4d3f858a-52c5-430f-800f-6955ea542711"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,219,48,16,252,149,128,231,200,80,36,129,142,124,11,92,183,200,165,9,16,163,151,42,135,149,184,146,137,82,162,64,82,105,93,195,255,222,37,229,40,78,225,34,110,129,162,213,137,26,204,206,206,190,118,172,82,96,237,71,104,145,45,216,26,141,1,171,107,55,123,47,149,67,243,193,232,161,103,151,204,162,145,160,228,119,20,35,190,18,210,189,3,7,20,178,43,94,20,10,182,40,78,107,20,236,178,96,210,97,107,137,67,33,215,25,114,94,227,60,42,227,252,42,202,50,33,34,72,106,30,149,200,235,140,231,49,136,148,143,204,95,137,47,117,219,131,193,49,71,144,175,195,115,189,237,61,245,138,128,42,80,164,213,221,1,76,189,9,187,234,160,84,40,232,223,153,1,9,114,70,182,84,13,174,101,139,247,96,40,151,215,209,30,34,82,13,202,122,150,194,218,173,190,245,6,173,149,186,123,203,156,26,218,238,152,77,2,56,253,30,236,196,193,163,103,222,131,219,4,137,37,88,156,221,146,183,125,176,122,211,52,6,27,112,242,233,216,201,23,220,6,242,121,77,164,0,65,163,250,4,106,192,163,196,175,203,89,66,239,198,170,70,15,33,204,200,102,115,118,201,83,227,222,170,58,33,176,127,38,159,169,121,178,138,132,19,248,228,129,81,229,249,89,176,207,183,246,238,107,135,230,161,218,96,11,99,223,30,103,132,254,4,76,250,139,93,133,243,28,161,204,163,20,242,235,40,75,210,58,42,83,204,35,206,211,36,5,168,230,130,199,251,199,209,135,180,189,130,109,176,50,53,236,194,96,165,141,184,8,179,243,159,111,177,110,100,5,234,174,71,67,35,12,13,140,79,111,224,171,213,245,101,25,173,221,104,118,106,203,77,69,107,32,29,141,254,104,5,40,25,157,167,239,204,131,30,76,117,56,7,59,222,229,31,221,219,63,184,162,223,62,140,147,139,121,206,162,137,255,97,133,254,246,122,236,217,254,7,161,80,80,219,214,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bfbc3d0d-9a1e-43da-adb7-89e445d1a625"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("18710cc5-5550-481e-a010-e0505fa8b2a9"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("66e99c9d-a861-41c9-9892-3b4320edcabf"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("55a48763-bffc-4c07-9950-003aefdc3654"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d00b0ee2-e935-4829-a4db-fe5abd649d41"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("39985f73-d9e1-4a6e-8cd4-a40b31d7e533"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				UId = new Guid("9c756e63-5afb-42ed-94f8-3ee3f4bf4d9d"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ea2ee12d-af13-403c-883f-817b024d86a9"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("fd47a28a-0a99-4a41-8153-9064ca9dad24"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("ab1d5b68-f04f-4772-8051-b480bf6acbc0"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("d83f0b00-f100-417a-a588-eb7796e2396a"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("4295e0df-6d0d-459b-a4fe-8ae3f18b4356"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("67446c2d-1033-4a62-98c7-f79a1d2cff50"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("a65afada-0121-4d32-8046-c15726057d12"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("85c368fc-5947-409e-9f8d-423a3de5d035"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7f41d79-3f1f-44f6-97ed-626171550655"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("d78ac6ad-2675-488a-b5e5-3b3a6eaeb04c"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
				UId = new Guid("7c6410e7-e8f2-4fd7-9fe6-dec682178ae7"),
				ContainerUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
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
			ProcessSchemaUserTask readcasedata = CreateReadCaseDataUserTask();
			FlowElements.Add(readcasedata);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask fillemailusertask = CreateFillEmailUserTaskUserTask();
			FlowElements.Add(fillemailusertask);
			ProcessSchemaScriptTask preparerecipientemails = CreatePrepareRecipientEmailsScriptTask();
			FlowElements.Add(preparerecipientemails);
			ProcessSchemaUserTask addemaildatausertask = CreateAddEmailDataUserTaskUserTask();
			FlowElements.Add(addemaildatausertask);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask sendemailscripttask = CreateSendEmailScriptTaskScriptTask();
			FlowElements.Add(sendemailscripttask);
			ProcessSchemaStartEvent startevent1 = CreateStartEvent1StartEvent();
			FlowElements.Add(startevent1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("57a6edbc-8a5e-418d-bf67-29dcb9cdfef0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("cb98fa26-176c-4258-957d-5f366e784589"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("5b6bbda6-2544-4984-a493-33ea3d53997e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60f2028e-d6aa-415b-bb5b-ef027be86bcf"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("96c28b67-1288-4df0-96f5-2a55923ff807"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60f2028e-d6aa-415b-bb5b-ef027be86bcf"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fce8a14e-9408-4274-8948-3165aeb15892"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("217c6685-36c5-4584-8a80-2f2f04b00727"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("75bdf120-c093-47fd-b23e-d52f059ec58c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{56772c15-0da6-416b-89f3-18ff8e888563}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(535, 332));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("8b7489eb-b116-4b26-a892-34fb88add808"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fce8a14e-9408-4274-8948-3165aeb15892"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(535, 146));
			schemaFlow.PolylinePointPositions.Add(new Point(1093, 146));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("b5a3673d-f005-4df7-b7e5-edef707a8f96"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("58c9e19e-5a97-42fa-8666-4613269c9517"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("8f83be51-9c06-45ff-b8d8-dd8224eb633a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4dc83797-2f02-421a-8c91-14b4b0109539}].[Parameter:{b3e79b7f-0cf2-4db9-a3b5-50f22bd30da9}].[EntityColumn:{a93cb111-ce30-4da4-89ec-d2a2f3dd71c4}]#] ==[#Lookup.b17869fe-43f9-487a-af82-b7626f1fc810.7f9e1f1e-f46b-1410-3492-0050ba5d6c38#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(627, 407));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("bf943044-0e65-4a76-9f79-6e7bcf838238"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eeede76c-0137-4ded-80aa-cc1cc3f876de"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("f74b17bb-0662-4a73-b5ab-e34bcda5b0bc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(627, 203));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("86e8cd15-190e-497b-8609-884788958143"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				SequenceFlowEndPointPosition = new Point(0, 0),
				SequenceFlowStartPointPosition = new Point(0, 0),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eeede76c-0137-4ded-80aa-cc1cc3f876de"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b1d52543-8143-4b41-b705-fbf73d8e80ca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b1d52543-8143-4b41-b705-fbf73d8e80ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaUserTask CreateReadCaseDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"ReadCaseData",
				Position = new Point(171, 176),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadCaseDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"ReadDataUserTask2",
				Position = new Point(281, 176),
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
				UId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"FillEmailUserTask",
				Position = new Point(391, 176),
				SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeFillEmailUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareRecipientEmailsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"PrepareRecipientEmails",
				Position = new Point(501, 176),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,193,138,219,48,16,61,39,144,127,80,125,146,105,48,123,110,218,192,226,122,67,14,221,182,241,110,123,88,122,16,246,36,17,200,146,59,26,109,49,203,254,123,71,86,146,186,129,5,99,240,248,205,123,111,222,76,213,41,109,106,176,45,160,248,36,164,39,212,246,144,63,0,162,242,110,79,69,233,16,248,101,247,250,16,80,145,118,182,168,7,95,3,17,227,124,177,1,250,161,76,128,143,169,113,45,31,61,32,195,45,52,17,187,20,139,249,44,171,67,223,59,164,26,240,89,55,80,69,197,108,41,234,177,163,168,186,158,134,124,181,152,63,43,20,144,220,24,238,102,55,22,254,136,202,146,166,161,110,142,252,235,123,0,28,174,20,138,41,224,139,178,234,0,184,20,25,123,188,109,59,109,31,173,166,236,63,246,210,153,208,89,102,159,104,21,183,109,155,234,50,99,106,82,92,74,54,207,173,7,116,161,223,182,220,182,3,213,150,202,195,103,69,170,216,129,15,134,146,133,152,197,195,208,195,137,41,197,178,9,186,93,203,108,147,218,71,186,169,238,157,54,4,232,163,190,156,214,75,4,69,144,254,254,212,116,252,166,80,117,16,161,50,21,75,215,245,10,181,119,54,74,22,213,239,160,12,143,253,196,115,199,124,182,118,231,12,124,56,125,253,138,43,139,5,78,253,52,72,126,30,172,113,198,164,36,175,34,225,105,210,92,229,5,113,21,125,164,216,250,123,128,54,222,207,152,23,115,252,35,228,179,9,150,196,90,220,48,112,7,141,238,53,88,26,113,158,129,233,98,210,254,25,176,231,67,83,205,81,142,139,26,133,133,182,19,182,92,188,240,45,93,214,24,221,190,29,251,249,26,39,27,47,238,57,193,124,21,15,82,239,133,124,119,146,231,1,130,49,95,113,180,145,240,121,146,154,93,91,126,127,241,124,231,176,83,36,179,151,155,215,21,103,154,186,120,134,217,235,98,206,15,2,5,180,130,48,192,74,252,5,210,39,117,232,97,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddEmailDataUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"AddEmailDataUserTask",
				Position = new Point(831, 176),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeAddEmailDataUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("fce8a14e-9408-4274-8948-3165aeb15892"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"Terminate1",
				Position = new Point(1080, 190),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSendEmailScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("60f2028e-d6aa-415b-bb5b-ef027be86bcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"SendEmailScriptTask",
				Position = new Point(980, 176),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,82,193,110,131,48,12,61,23,137,127,176,56,129,132,248,1,214,73,136,210,137,235,70,63,32,35,166,138,26,146,42,9,157,208,180,127,159,19,13,141,193,78,113,236,103,191,247,226,60,152,1,214,59,241,16,110,110,57,28,161,226,188,25,153,144,39,230,216,197,162,233,152,189,21,175,216,107,195,91,94,198,145,24,32,245,249,90,43,133,212,168,85,241,130,174,181,103,100,110,50,216,40,246,46,145,167,9,97,42,59,171,62,12,123,67,197,209,36,89,6,159,113,116,216,230,1,87,241,17,20,126,192,22,178,161,204,72,200,97,213,85,248,35,244,164,191,102,60,232,11,80,90,12,172,15,114,26,90,106,41,80,185,51,1,181,153,137,175,150,204,218,159,171,247,242,212,236,80,207,169,23,69,252,214,153,201,103,42,115,157,70,170,167,201,244,71,88,146,195,70,105,144,234,185,23,97,205,222,108,191,171,164,123,165,187,201,126,112,135,198,48,171,7,87,80,97,16,215,201,176,176,146,90,143,163,86,23,39,164,112,2,45,221,239,243,89,72,60,161,163,185,155,215,204,161,195,241,46,153,195,150,231,171,223,144,67,18,36,45,85,50,151,44,90,41,166,167,192,172,4,82,241,143,181,176,145,237,50,226,200,32,125,18,21,90,203,111,69,198,69,68,123,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartEvent CreateStartEvent1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("58c9e19e-5a97-42fa-8666-4613269c9517"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"StartEvent1",
				Position = new Point(80, 190),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"ExclusiveGateway1",
				Position = new Point(600, 305),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"ReadDataUserTask1",
				Position = new Point(680, 380),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] { 31,139,8,0,0,0,0,0,0,10,3,0,0,0,0,0,0,0,0,0 }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("eeede76c-0137-4ded-80aa-cc1cc3f876de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("996dfe48-590a-43d9-a7fb-c3907c19dda5"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"),
				Name = @"FormulaTask1",
				Position = new Point(831, 380),
				ResultParameterMetaPath = @"50441308-78db-4135-97ae-5d3c91b5f48f",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,144,189,110,131,48,20,70,95,197,74,22,162,230,34,28,95,126,165,168,3,98,96,162,106,198,136,225,130,175,19,36,48,149,161,106,171,40,239,94,43,99,30,33,235,209,119,134,243,5,231,237,185,94,154,31,203,238,212,95,121,162,194,208,184,112,27,122,250,4,170,145,39,182,107,113,203,49,233,242,44,86,16,75,133,128,156,196,144,229,82,67,122,64,67,40,123,102,165,239,94,248,32,71,19,175,236,188,210,167,113,194,137,87,200,116,128,7,214,144,163,201,64,249,173,193,206,160,206,31,74,101,215,97,253,43,231,241,123,178,197,13,117,111,34,82,18,82,163,83,64,221,17,80,20,33,48,74,213,201,52,86,168,228,189,221,182,187,176,182,154,127,27,19,108,62,171,66,108,246,226,180,186,193,94,202,121,250,34,55,44,179,13,27,167,7,75,99,125,177,179,227,146,22,222,137,227,81,68,226,93,4,47,241,128,240,217,143,118,241,246,34,69,255,68,39,120,43,154,2,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6eceebac-b0e5-4cc8-b022-84e50eb7f42e"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb35bbc2-5e4c-4518-a793-46d126c86da9"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bab858b4-c2ef-4534-94c5-1f8e9452cf9b"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4256f56b-80d4-4887-900e-0f587b83f100"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendEmailToCaseGroup(userConnection);
		}

		public override object Clone() {
			return new SendEmailToCaseGroupSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb"));
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailToCaseGroup

	/// <exclude/>
	public class SendEmailToCaseGroup : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadCaseDataFlowElement

		/// <exclude/>
		public class ReadCaseDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadCaseDataFlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadCaseData";
				IsLogging = true;
				SchemaElementUId = new Guid("4dc83797-2f02-421a-8c91-14b4b0109539");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,77,115,155,48,16,253,43,25,206,81,6,1,22,224,91,199,117,59,190,52,153,137,39,151,146,195,34,45,182,166,96,24,73,78,235,122,252,223,187,2,219,113,58,238,196,205,37,225,2,122,60,189,125,251,181,13,100,13,214,126,131,6,131,113,48,71,99,192,182,149,187,249,162,107,135,230,171,105,215,93,112,29,88,52,26,106,253,27,213,128,79,149,118,159,193,1,93,217,22,207,10,69,48,46,206,107,20,193,117,17,104,135,141,37,14,93,137,195,60,229,66,164,44,18,163,17,75,66,21,178,50,9,83,150,0,86,32,226,60,143,146,108,96,254,75,124,210,54,29,24,28,98,244,242,85,255,57,223,116,158,202,9,144,61,69,219,118,181,7,99,111,194,78,87,80,214,168,232,236,204,26,9,114,70,55,148,13,206,117,131,119,96,40,150,215,105,61,68,164,10,106,235,89,53,86,110,250,171,51,104,173,110,87,175,153,171,215,205,234,148,77,2,120,60,238,237,132,189,71,207,188,3,183,236,37,102,100,107,215,187,252,180,88,24,92,128,211,79,167,38,126,224,166,231,93,86,63,186,160,168,75,15,80,175,241,36,230,203,76,38,208,185,33,161,33,60,17,140,94,44,47,206,245,88,177,215,210,141,8,236,14,228,11,53,207,230,16,9,2,159,60,48,168,28,62,139,224,251,204,222,254,92,161,185,151,75,108,96,168,218,227,13,161,127,1,71,253,241,86,98,154,35,148,57,139,33,207,88,18,197,21,43,99,204,153,16,113,20,3,200,84,137,112,247,56,248,208,182,171,97,243,112,12,55,1,139,87,6,101,107,212,213,190,116,254,69,127,184,202,36,23,145,98,16,103,21,75,202,44,99,32,65,50,228,35,142,82,102,163,84,132,212,105,255,248,134,180,11,45,161,190,237,208,80,195,251,130,243,243,163,250,98,198,125,25,76,219,186,33,185,99,25,189,171,222,203,97,88,178,72,34,77,4,103,42,27,1,165,8,130,149,185,138,153,200,69,37,149,226,156,251,16,59,218,115,95,233,251,118,109,228,126,175,236,176,224,111,90,220,119,88,199,255,217,176,179,51,126,201,204,126,148,105,156,125,148,73,219,5,187,63,86,247,126,159,70,6,0,0 })));
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

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("d8487221-4c12-4a8e-9887-24309eafbaea");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,229,84,203,110,211,64,20,253,23,175,235,200,142,227,87,119,40,4,118,16,41,17,43,111,174,199,215,206,168,118,108,205,76,42,66,21,137,63,160,221,34,248,7,132,84,21,33,186,105,212,21,127,193,151,112,103,28,66,42,5,213,84,138,0,177,24,105,124,116,230,206,185,103,142,239,153,197,74,144,242,25,84,104,29,91,83,20,2,100,157,171,222,19,94,42,20,79,69,189,104,172,35,75,162,224,80,242,87,152,181,248,40,227,234,49,40,160,35,103,201,207,10,137,117,156,236,175,145,88,71,137,197,21,86,146,56,116,36,138,48,205,195,192,179,253,220,79,237,129,159,229,118,10,78,100,251,94,26,100,24,167,81,218,143,91,230,175,138,15,235,170,1,129,237,29,166,124,110,182,211,101,163,169,46,1,204,80,184,172,231,27,208,211,34,228,104,14,105,137,25,125,43,177,64,130,148,224,21,117,131,83,94,225,24,4,221,165,235,212,26,34,82,14,165,212,172,18,115,53,122,217,8,148,146,215,243,251,196,149,139,106,190,203,166,2,184,253,220,200,113,140,70,205,28,131,154,153,18,109,173,149,209,249,168,40,4,22,160,248,233,174,140,19,92,26,102,55,7,233,64,70,239,244,2,202,5,238,56,115,183,151,33,52,170,109,41,177,214,231,95,223,173,207,111,190,172,47,110,222,152,227,130,23,179,206,125,111,221,187,175,245,62,129,205,15,114,199,154,123,187,233,71,4,158,106,192,28,27,130,212,254,173,180,131,110,223,203,124,8,115,27,125,39,182,7,12,29,59,142,67,180,49,240,82,6,238,192,77,29,248,31,51,54,89,202,49,176,19,40,176,215,61,110,221,204,124,64,220,110,63,81,220,62,208,250,76,235,114,125,241,237,245,219,30,237,222,111,208,43,90,31,55,251,107,90,154,125,249,47,7,83,155,93,214,5,103,80,62,111,80,144,223,70,187,179,63,54,119,242,22,232,174,235,90,77,216,12,43,216,42,162,247,108,17,163,99,251,96,97,159,158,10,67,219,143,125,143,230,195,32,180,33,140,60,59,112,7,145,23,48,230,3,115,73,16,13,119,173,124,82,47,4,219,4,93,182,83,253,65,211,250,15,252,31,191,55,86,247,166,166,75,10,14,50,120,254,82,187,38,251,38,196,193,157,59,232,159,177,178,86,223,1,34,58,131,223,235,8,0,0 })));
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

		#region Class: FillEmailUserTaskFlowElement

		/// <exclude/>
		public class FillEmailUserTaskFlowElement : FillEmailTemplateUserTask
		{

			#region Constructors: Public

			public FillEmailUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "FillEmailUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("8324eaeb-dafc-4716-8d8a-e87af28697d3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordId = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_templateId = () => (Guid)(new Guid("0dc0759c-80b3-48b3-a832-7e32925d748b"));
				_sysEntitySchemaId = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("UId").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("UId") : Guid.Empty)));
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

		#region Class: AddEmailDataUserTaskFlowElement

		/// <exclude/>
		public class AddEmailDataUserTaskFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddEmailDataUserTaskFlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddEmailDataUserTask";
				IsLogging = true;
				SchemaElementUId = new Guid("ff0726c2-565e-4ac8-8c9a-a57108ff3533");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Title = () => new LocalizableString((process.Subject));
				_recordDefValues_Body = () => new LocalizableString((process.FillEmailUserTask.Body));
				_recordDefValues_Type = () => (Guid)(new Guid("e2831dec-cfc0-df11-b00f-001d60e938c6"));
				_recordDefValues_MessageType = () => (Guid)(new Guid("7f6d3f94-f36b-1410-068c-20cf30b39373"));
				_recordDefValues_ActivityCategory = () => (Guid)(new Guid("8038a396-7825-e011-8165-00155d043204"));
				_recordDefValues_Sender = () => new LocalizableString((process.EmailSender));
				_recordDefValues_Case = () => (Guid)(((process.ReadCaseData.ResultEntity.IsColumnValueLoaded(process.ReadCaseData.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_Recepient = () => new LocalizableString((process.RecipientEmails));
				_recordDefValues_IsHtmlBody = () => (bool)(true);
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Title", () => _recordDefValues_Title.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Body", () => _recordDefValues_Body.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Type", () => _recordDefValues_Type.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_MessageType", () => _recordDefValues_MessageType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_ActivityCategory", () => _recordDefValues_ActivityCategory.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Sender", () => _recordDefValues_Sender.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Recepient", () => _recordDefValues_Recepient.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_IsHtmlBody", () => _recordDefValues_IsHtmlBody.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Title;
			internal Func<string> _recordDefValues_Body;
			internal Func<Guid> _recordDefValues_Type;
			internal Func<Guid> _recordDefValues_MessageType;
			internal Func<Guid> _recordDefValues_ActivityCategory;
			internal Func<string> _recordDefValues_Sender;
			internal Func<Guid> _recordDefValues_Case;
			internal Func<string> _recordDefValues_Recepient;
			internal Func<bool> _recordDefValues_IsHtmlBody;

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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,89,93,79,91,71,16,253,43,150,147,71,214,218,239,15,191,181,73,170,34,37,109,20,210,188,4,30,102,119,103,137,91,99,163,235,75,34,138,248,239,61,215,64,18,104,107,160,21,129,72,248,225,218,190,190,187,59,59,59,103,206,204,241,201,248,105,127,124,200,227,233,248,45,119,29,173,150,173,159,60,91,118,60,121,221,45,11,175,86,147,151,203,66,243,217,159,148,231,252,154,58,58,224,158,187,119,52,63,226,213,203,217,170,223,26,93,30,54,222,26,63,253,184,254,117,60,125,127,50,222,238,249,224,183,237,138,217,171,38,21,3,177,208,89,89,97,139,149,34,154,162,132,42,201,5,233,11,103,31,49,184,44,231,71,7,139,87,220,211,107,234,63,140,167,39,227,245,108,152,192,214,210,36,25,37,66,171,65,216,154,73,144,148,86,176,85,38,171,224,140,53,106,124,186,53,94,149,15,124,64,235,69,191,12,46,214,166,26,141,22,100,75,17,54,75,37,114,170,78,68,82,186,88,77,169,197,52,12,62,127,254,203,192,247,79,222,111,175,126,253,180,224,110,103,61,239,180,209,124,197,123,19,220,189,114,227,179,115,166,39,78,90,24,37,163,8,177,102,129,143,78,164,97,235,174,154,146,84,118,205,198,118,186,247,100,111,88,177,206,86,135,115,58,126,247,247,133,119,142,242,239,92,250,179,199,14,47,185,254,235,7,79,118,207,78,112,119,60,221,253,183,51,60,127,63,179,248,242,41,94,61,192,221,241,214,238,120,103,121,212,149,97,70,131,47,207,191,178,112,189,200,250,145,43,95,47,78,12,119,22,71,243,249,249,157,231,212,211,197,131,23,183,151,117,214,102,92,183,23,59,23,7,181,158,69,158,191,196,63,92,46,94,103,182,253,159,97,175,104,65,251,220,253,2,7,124,177,253,179,149,111,225,198,139,137,93,33,227,154,146,130,20,130,197,22,31,4,37,79,194,68,83,201,83,163,210,202,122,244,27,110,220,241,162,240,127,52,236,13,175,214,222,30,160,114,110,215,224,170,211,241,233,233,214,215,0,74,133,67,114,201,9,237,170,23,54,229,44,114,54,30,113,140,0,46,94,231,104,204,70,0,121,21,57,56,105,128,187,140,29,57,93,5,145,193,215,22,124,72,58,58,147,221,125,2,232,197,156,15,120,209,79,79,176,140,101,226,44,42,53,172,21,148,23,177,70,18,140,252,209,116,244,41,84,115,122,25,113,198,169,96,200,225,140,52,107,12,73,13,123,211,65,228,26,189,202,214,164,166,236,245,136,251,153,22,117,206,35,184,28,15,244,60,106,203,110,4,11,103,243,209,167,89,255,97,116,64,165,91,174,38,63,46,235,241,35,40,239,5,148,69,54,105,61,206,21,23,137,40,44,32,17,203,200,174,86,165,90,162,83,62,171,111,10,202,144,36,35,86,171,40,3,21,89,107,129,8,67,69,104,41,51,194,84,185,22,55,179,154,179,73,21,99,154,224,52,108,171,80,20,8,227,36,170,141,74,50,57,91,156,191,11,80,190,92,46,255,56,58,156,4,151,109,53,41,11,231,234,48,3,50,75,172,72,122,166,217,68,46,214,228,75,152,176,142,70,85,46,2,41,79,138,218,20,150,145,178,193,107,170,122,201,201,196,226,175,131,214,249,122,63,148,126,246,113,214,31,143,6,198,154,188,24,176,245,8,165,123,129,82,214,201,201,160,154,8,76,73,88,246,122,56,121,18,73,165,220,76,48,186,53,189,9,74,55,137,156,91,65,73,167,160,168,69,37,124,171,12,36,52,6,172,163,21,197,5,23,89,115,105,109,51,191,81,115,20,76,53,0,31,98,21,21,88,18,17,155,17,10,19,20,86,201,231,170,239,16,74,54,235,224,9,110,8,10,101,173,205,137,68,230,84,133,9,137,107,241,0,139,110,147,208,124,53,45,89,209,140,135,101,22,14,147,62,14,249,162,52,35,179,73,240,252,13,161,244,10,5,29,206,250,12,73,191,30,245,251,203,217,98,255,17,76,223,37,152,110,18,59,183,227,165,152,216,33,51,163,89,210,48,72,33,91,231,170,130,104,156,66,116,150,164,147,188,17,76,37,42,219,40,40,193,82,161,133,49,218,9,42,177,98,91,150,116,50,92,149,137,119,8,166,228,21,107,25,61,170,111,141,229,235,80,202,73,212,190,86,102,197,222,86,95,138,156,68,105,34,153,4,175,69,152,7,67,21,0,239,221,192,75,72,74,18,70,75,123,91,94,42,168,251,246,151,221,241,35,55,125,199,112,186,73,244,220,10,78,46,17,177,68,161,233,157,67,239,21,129,207,1,8,34,213,68,236,82,96,180,23,155,203,60,168,30,158,107,20,30,77,36,200,77,86,145,98,68,193,151,41,150,156,147,51,156,30,136,120,209,178,207,96,80,32,191,161,231,181,44,177,46,107,37,106,172,222,233,136,158,172,241,245,173,212,186,180,27,173,120,81,185,123,36,165,123,65,81,173,217,144,98,22,50,112,4,10,128,162,28,128,167,42,25,82,192,80,193,231,250,77,155,165,162,178,138,132,70,158,8,0,178,50,38,32,154,7,102,74,168,237,108,86,53,208,102,9,48,20,168,128,54,136,232,6,86,195,70,4,249,70,2,28,23,51,130,182,128,149,30,132,130,1,43,35,184,59,8,221,0,31,171,145,187,34,148,63,20,124,121,88,24,185,200,164,43,10,70,54,144,119,114,64,87,85,26,134,212,156,4,65,144,17,78,54,173,115,53,178,210,122,200,139,69,15,158,122,182,246,209,244,100,200,74,22,82,149,40,118,200,111,141,161,128,152,161,112,160,28,116,136,172,188,10,215,131,245,13,58,88,48,223,138,71,21,129,52,154,252,52,235,86,253,104,134,131,27,45,219,168,227,213,209,188,71,113,57,194,201,204,161,72,206,150,139,201,118,125,68,245,119,201,141,74,65,61,211,13,189,145,14,136,24,200,230,144,80,80,57,169,226,189,82,104,148,82,169,183,66,181,180,218,58,106,74,52,176,33,164,55,219,64,109,18,98,1,148,139,98,32,204,171,180,25,213,178,100,55,216,45,48,10,162,142,162,12,9,100,64,12,57,153,148,53,4,112,63,16,110,132,207,35,148,158,132,58,192,2,164,173,130,198,93,208,96,245,104,81,102,192,244,164,111,2,183,50,59,156,33,81,156,137,139,171,71,36,221,11,146,30,156,152,232,32,226,39,11,32,64,251,195,197,59,104,129,53,123,72,131,18,236,17,2,138,200,205,85,102,148,13,12,8,34,8,144,236,48,139,3,63,58,15,97,70,55,148,157,67,173,41,239,0,73,125,135,183,13,1,127,241,251,227,95,88,223,56,192,147,204,222,229,22,133,108,195,255,40,80,155,68,12,208,150,181,69,115,20,240,95,74,146,23,18,221,157,5,248,222,233,95,131,101,45,171,97,30,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "c68f5a4ead064c8388c4040d2480facb",
							"BaseElements.AddEmailDataUserTask.Parameters.RecordDefValues.Value");
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

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SendEmailToCaseGroup process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("946b9853-5134-4e65-891d-724fa41cee3d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,203,110,219,48,16,252,149,128,231,200,80,36,129,142,124,11,92,183,200,165,9,16,163,151,42,135,149,184,146,137,82,162,64,82,105,93,195,255,222,37,229,40,78,225,34,110,129,162,213,137,26,204,206,206,190,118,172,82,96,237,71,104,145,45,216,26,141,1,171,107,55,123,47,149,67,243,193,232,161,103,151,204,162,145,160,228,119,20,35,190,18,210,189,3,7,20,178,43,94,20,10,182,40,78,107,20,236,178,96,210,97,107,137,67,33,215,25,114,94,227,60,42,227,252,42,202,50,33,34,72,106,30,149,200,235,140,231,49,136,148,143,204,95,137,47,117,219,131,193,49,71,144,175,195,115,189,237,61,245,138,128,42,80,164,213,221,1,76,189,9,187,234,160,84,40,232,223,153,1,9,114,70,182,84,13,174,101,139,247,96,40,151,215,209,30,34,82,13,202,122,150,194,218,173,190,245,6,173,149,186,123,203,156,26,218,238,152,77,2,56,253,30,236,196,193,163,103,222,131,219,4,137,37,88,156,221,146,183,125,176,122,211,52,6,27,112,242,233,216,201,23,220,6,242,121,77,164,0,65,163,250,4,106,192,163,196,175,203,89,66,239,198,170,70,15,33,204,200,102,115,118,201,83,227,222,170,58,33,176,127,38,159,169,121,178,138,132,19,248,228,129,81,229,249,89,176,207,183,246,238,107,135,230,161,218,96,11,99,223,30,103,132,254,4,76,250,139,93,133,243,28,161,204,163,20,242,235,40,75,210,58,42,83,204,35,206,211,36,5,168,230,130,199,251,199,209,135,180,189,130,109,176,50,53,236,194,96,165,141,184,8,179,243,159,111,177,110,100,5,234,174,71,67,35,12,13,140,79,111,224,171,213,245,101,25,173,221,104,118,106,203,77,69,107,32,29,141,254,104,5,40,25,157,167,239,204,131,30,76,117,56,7,59,222,229,31,221,219,63,184,162,223,62,140,147,139,121,206,162,137,255,97,133,254,246,122,236,217,254,7,161,80,80,219,214,5,0,0 })));
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

		public SendEmailToCaseGroup(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendEmailToCaseGroup";
			SchemaUId = new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_isNeedSendEmail = () => { return (bool)(false); };
			_templateId = () => { return (Guid)(new Guid("0dc0759c-80b3-48b3-a832-7e32925d748b")); };
			_subject = () => { return new LocalizableString((FillEmailUserTask.Subject)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c68f5a4e-ad06-4c83-88c4-040d2480facb");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SendEmailToCaseGroup, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SendEmailToCaseGroup, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		private Func<bool> _isNeedSendEmail;
		public virtual bool IsNeedSendEmail {
			get {
				return (_isNeedSendEmail ?? (_isNeedSendEmail = () => false)).Invoke();
			}
			set {
				_isNeedSendEmail = () => { return value; };
			}
		}

		public virtual string RecipientEmails {
			get;
			set;
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

		public virtual Guid CaseRecordId {
			get;
			set;
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

		public virtual string EmailSender {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ReadCaseDataFlowElement _readCaseData;
		public ReadCaseDataFlowElement ReadCaseData {
			get {
				return _readCaseData ?? (_readCaseData = new ReadCaseDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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

		private ProcessScriptTask _prepareRecipientEmails;
		public ProcessScriptTask PrepareRecipientEmails {
			get {
				return _prepareRecipientEmails ?? (_prepareRecipientEmails = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareRecipientEmails",
					SchemaElementUId = new Guid("4a1291aa-8caf-4e54-8275-887b0bb550c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = PrepareRecipientEmailsExecute,
				});
			}
		}

		private AddEmailDataUserTaskFlowElement _addEmailDataUserTask;
		public AddEmailDataUserTaskFlowElement AddEmailDataUserTask {
			get {
				return _addEmailDataUserTask ?? (_addEmailDataUserTask = new AddEmailDataUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("fce8a14e-9408-4274-8948-3165aeb15892"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _sendEmailScriptTask;
		public ProcessScriptTask SendEmailScriptTask {
			get {
				return _sendEmailScriptTask ?? (_sendEmailScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendEmailScriptTask",
					SchemaElementUId = new Guid("60f2028e-d6aa-415b-bb5b-ef027be86bcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SendEmailScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _startEvent1;
		public ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("58c9e19e-5a97-42fa-8666-4613269c9517"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("b19e5a82-b497-469b-b25d-0c491fd8111a"),
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

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("eeede76c-0137-4ded-80aa-cc1cc3f876de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
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
					SchemaElementUId = new Guid("75bdf120-c093-47fd-b23e-d52f059ec58c"),
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
					SchemaElementUId = new Guid("8f83be51-9c06-45ff-b8d8-dd8224eb633a"),
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
			FlowElements[ReadCaseData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadCaseData };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FillEmailUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FillEmailUserTask };
			FlowElements[PrepareRecipientEmails.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareRecipientEmails };
			FlowElements[AddEmailDataUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AddEmailDataUserTask };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[SendEmailScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendEmailScriptTask };
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ReadCaseData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FillEmailUserTask", e.Context.SenderName));
						break;
					case "FillEmailUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PrepareRecipientEmails", e.Context.SenderName));
						break;
					case "PrepareRecipientEmails":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "PrepareRecipientEmails");
						break;
					case "AddEmailDataUserTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendEmailScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "SendEmailScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadCaseData", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddEmailDataUserTask", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddEmailDataUserTask", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			bool result = Convert.ToBoolean((IsNeedSendEmail));
			Log.InfoFormat(ConditionalExpressionLogMessage, "PrepareRecipientEmails", "ConditionalSequenceFlow1", "(IsNeedSendEmail)", result);
			return result;
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName("Origin").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("OriginId") : Guid.Empty)) ==new Guid("7f9e1f1e-f46b-1410-3492-0050ba5d6c38"));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow2", "((ReadCaseData.ResultEntity.IsColumnValueLoaded(ReadCaseData.ResultEntity.Schema.Columns.GetByName(\"Origin\").ColumnValueName) ? ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>(\"OriginId\") : Guid.Empty)) ==new Guid(\"7f9e1f1e-f46b-1410-3492-0050ba5d6c38\")", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("RecipientEmails")) {
				writer.WriteValue("RecipientEmails", RecipientEmails, null);
			}
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
			}
			if (!HasMapping("EmailSender")) {
				writer.WriteValue("EmailSender", EmailSender, null);
			}
			if (!HasMapping("IsNeedSendEmail")) {
				writer.WriteValue("IsNeedSendEmail", IsNeedSendEmail, false);
			}
			if (!HasMapping("TemplateId")) {
				writer.WriteValue("TemplateId", TemplateId, Guid.Empty);
			}
			if (!HasMapping("Subject")) {
				writer.WriteValue("Subject", Subject, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartEvent1", string.Empty));
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
			MetaPathParameterValues.Add("56772c15-0da6-416b-89f3-18ff8e888563", () => IsNeedSendEmail);
			MetaPathParameterValues.Add("7ea8c009-6542-4fdd-9572-6a844d21ab92", () => RecipientEmails);
			MetaPathParameterValues.Add("94d0d4a6-3942-434c-add8-db0c09b339ba", () => TemplateId);
			MetaPathParameterValues.Add("ce79eab9-3a98-423f-b3e9-66323aac7d60", () => CaseRecordId);
			MetaPathParameterValues.Add("50441308-78db-4135-97ae-5d3c91b5f48f", () => Subject);
			MetaPathParameterValues.Add("fb6b20e1-ef67-4e02-ae21-d8d6528daffe", () => EmailSender);
			MetaPathParameterValues.Add("4bff0fd5-1b5b-42da-97ec-43b95e6ba9cb", () => ReadCaseData.DataSourceFilters);
			MetaPathParameterValues.Add("a33f837c-29dc-4fee-a6ce-9b43656fdcf8", () => ReadCaseData.ResultType);
			MetaPathParameterValues.Add("abb94808-5aed-4a2b-91a0-b3c4e019244f", () => ReadCaseData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("5c31db74-03b4-4e13-b937-a5bd1c4b9346", () => ReadCaseData.NumberOfRecords);
			MetaPathParameterValues.Add("43f58502-a3f9-4d89-8b05-bfd006634914", () => ReadCaseData.FunctionType);
			MetaPathParameterValues.Add("9bbb4181-ec2f-4b6d-9c67-a8acb3d3bb29", () => ReadCaseData.AggregationColumnName);
			MetaPathParameterValues.Add("71f14a14-3659-44b0-8b17-52639bb50b8b", () => ReadCaseData.OrderInfo);
			MetaPathParameterValues.Add("b3e79b7f-0cf2-4db9-a3b5-50f22bd30da9", () => ReadCaseData.ResultEntity);
			MetaPathParameterValues.Add("b94c3537-238d-4c55-bf91-3524d23fa348", () => ReadCaseData.ResultCount);
			MetaPathParameterValues.Add("11c9e107-95c8-4c1c-9999-e948c31b229b", () => ReadCaseData.ResultIntegerFunction);
			MetaPathParameterValues.Add("ec11c857-840d-4bf0-81d9-e4b22444f6a4", () => ReadCaseData.ResultFloatFunction);
			MetaPathParameterValues.Add("a7dfeac1-20f7-4098-9ddf-8b4e9e037ab5", () => ReadCaseData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("3b5fc9e6-f635-4946-96d0-99a07663b06a", () => ReadCaseData.ResultRowsCount);
			MetaPathParameterValues.Add("1b1d7240-335a-4137-9822-956528e4d5c8", () => ReadCaseData.CanReadUncommitedData);
			MetaPathParameterValues.Add("79abe934-9fa1-465e-b36c-e6a83fcae767", () => ReadCaseData.ResultEntityCollection);
			MetaPathParameterValues.Add("0a7890ce-b0ce-4cb6-9467-4d2a3d591114", () => ReadCaseData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("957348b6-6c6f-4f23-9005-92046516fcbf", () => ReadCaseData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("74549e07-b7b2-4d9e-a3ca-5d66f1b86360", () => ReadCaseData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("3e942e6c-6660-4f9a-a3f3-043202ffc52e", () => ReadCaseData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("5601149a-7688-4bb0-829b-346b4f6428e9", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("33bce745-fb67-43b6-b483-90cf9af1f475", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("c1bec890-46fb-4d20-8d4a-05948010b323", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("9b2c93dd-c44c-440a-9072-328f06f7b94c", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("f13d3489-febd-495e-87cf-34c08df24766", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("5109a2ba-50c9-44b0-8714-4102a725b645", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("82ffd8c0-e88a-4530-87aa-024e8633e4d5", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("6f04cfdc-2015-4135-b910-ee8e91e73e65", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("81e8c52d-6348-476a-919b-4c222b549563", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("f54c25eb-87ff-4e05-9ea4-fa641521ef7d", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("bf35315a-7b9b-4e81-9cca-4628bc3abbe5", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("19ab1ec6-b279-4170-9439-600c31df5a4a", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("bafbaee0-2586-4010-ba1c-e98dd9e853cc", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("6abdacf3-1dd7-4b36-b7bc-80b7b2a13122", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("31a337f9-edbe-45b5-995e-4c7b22eee133", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("9f758c03-00f6-4843-b6eb-99c9178eaf1a", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("bbc539f4-868f-49dd-9dd3-cef59500c068", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("805f2f6b-54fa-4d2e-a41b-6cf52ce7d3b8", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("82ffbb9b-0add-45df-861f-c2a25682c5a7", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("eb64ce85-4fbd-4226-97de-985e5b9fef59", () => FillEmailUserTask.Subject);
			MetaPathParameterValues.Add("35173a57-a2e2-479f-aa27-bd861b439f14", () => FillEmailUserTask.Body);
			MetaPathParameterValues.Add("80f75966-6900-4fcd-8f09-804f82c014af", () => FillEmailUserTask.RecordId);
			MetaPathParameterValues.Add("86a9ca15-a29b-468f-92c9-7070bbd6f371", () => FillEmailUserTask.TemplateId);
			MetaPathParameterValues.Add("9fbf2e69-990b-41f6-8ec5-c33d551a4914", () => FillEmailUserTask.SysEntitySchemaId);
			MetaPathParameterValues.Add("847cacd4-6fdf-4340-890f-2d494c4c5c98", () => AddEmailDataUserTask.EntitySchemaId);
			MetaPathParameterValues.Add("31e0eb82-93a1-4879-91aa-b744930a4611", () => AddEmailDataUserTask.DataSourceFilters);
			MetaPathParameterValues.Add("567a0c1b-7356-49ce-93db-d58cb11abf8f", () => AddEmailDataUserTask.RecordAddMode);
			MetaPathParameterValues.Add("6a9f6041-ec7b-424a-88e3-3c868e83e490", () => AddEmailDataUserTask.FilterEntitySchemaId);
			MetaPathParameterValues.Add("91d4d62a-3cec-433d-b549-0651c8113c05", () => AddEmailDataUserTask.RecordDefValues);
			MetaPathParameterValues.Add("296257aa-1125-48e6-a411-79017af52a29", () => AddEmailDataUserTask.RecordId);
			MetaPathParameterValues.Add("4d3f858a-52c5-430f-800f-6955ea542711", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("bfbc3d0d-9a1e-43da-adb7-89e445d1a625", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("18710cc5-5550-481e-a010-e0505fa8b2a9", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("66e99c9d-a861-41c9-9892-3b4320edcabf", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("55a48763-bffc-4c07-9950-003aefdc3654", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("d00b0ee2-e935-4829-a4db-fe5abd649d41", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("39985f73-d9e1-4a6e-8cd4-a40b31d7e533", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("9c756e63-5afb-42ed-94f8-3ee3f4bf4d9d", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("ea2ee12d-af13-403c-883f-817b024d86a9", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("fd47a28a-0a99-4a41-8153-9064ca9dad24", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("ab1d5b68-f04f-4772-8051-b480bf6acbc0", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("d83f0b00-f100-417a-a588-eb7796e2396a", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("4295e0df-6d0d-459b-a4fe-8ae3f18b4356", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("67446c2d-1033-4a62-98c7-f79a1d2cff50", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("a65afada-0121-4d32-8046-c15726057d12", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("85c368fc-5947-409e-9f8d-423a3de5d035", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b7f41d79-3f1f-44f6-97ed-626171550655", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("d78ac6ad-2675-488a-b5e5-3b3a6eaeb04c", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("7c6410e7-e8f2-4fd7-9fe6-dec682178ae7", () => ReadDataUserTask1.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "RecipientEmails":
					if (!hasValueToRead) break;
					RecipientEmails = reader.GetValue<System.String>();
				break;
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
				case "EmailSender":
					if (!hasValueToRead) break;
					EmailSender = reader.GetValue<System.String>();
				break;
				case "IsNeedSendEmail":
					if (!hasValueToRead) break;
					IsNeedSendEmail = reader.GetValue<System.Boolean>();
				break;
				case "TemplateId":
					if (!hasValueToRead) break;
					TemplateId = reader.GetValue<System.Guid>();
				break;
				case "Subject":
					if (!hasValueToRead) break;
					Subject = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool PrepareRecipientEmailsExecute(ProcessExecutingContext context) {
			EmailSender = (string)Terrasoft.Core.Configuration.SysSettings.GetValue<string>(UserConnection, 
				"SupportServiceEmail", String.Empty);
			var emailSelect = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			var emailColumn = emailSelect.AddColumn("Contact.Email");
			var groupId = ReadCaseData.ResultEntity.GetTypedColumnValue<Guid>("GroupId");
			emailSelect.Filters.Add(emailSelect.CreateFilterWithParameters(FilterComparisonType.Equal, "[SysUserInRole:SysUser].SysRole", groupId));
			var collection = emailSelect.GetEntityCollection(UserConnection);
			IsNeedSendEmail = collection.Count > 0;
			RecipientEmails = string.Empty;
			foreach(var entity in collection) {
				var email = entity.GetTypedColumnValue<string>(emailColumn.Name); 
				if (!string.IsNullOrEmpty(email)) {
					RecipientEmails += string.Format("{0};", email);
				}
			}
			return true; 
		}

		public virtual bool SendEmailScriptTaskExecute(ProcessExecutingContext context) {
			var activityId = AddEmailDataUserTask.RecordId;
			if (UserConnection.GetIsFeatureEnabled("UseAsyncEmailSender")) {
				AsyncEmailSender emailSender = new AsyncEmailSender(UserConnection);
				emailSender.SendAsync(activityId);
			} else {
				var emailClientFactory = ClassFactory.Get<EmailClientFactory>(new ConstructorArgument("userConnection", UserConnection));
				var activityEmailSender = new ActivityEmailSender(emailClientFactory, UserConnection);
				Terrasoft.Configuration.CommonUtilities.CopyFileDetail(UserConnection, TemplateId, activityId, "EmailTemplate", "Activity", true); 
				activityEmailSender.Send(activityId);
			}
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localSubject = (((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<string>("Title") : null))).IndexOf("RE: ", StringComparison.OrdinalIgnoreCase) == 0 ? (((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<string>("Title") : null))) : "RE: " + (((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<string>("Title") : null)));
			Subject = (System.String)localSubject;
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
			var cloneItem = (SendEmailToCaseGroup)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

