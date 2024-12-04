define("OBSWConstants", ["ext-base"],
	function(Ext) {
		/**
		 * @class Terrasoft.configuration.OBSWConstants
		 * Class OBSWConstants contains configuration constants for OBSW.
		 */
		Ext.define("Terrasoft.configuration.OBSWConstants", {
			extend: "Terrasoft.BaseObject",
			alternateClassName: "Terrasoft.OBSWConstants",

			/**
			 * Object with types of the OBSW view mode.
			 * @type {Object}
			 */
			OBSWViewMode: {
				Search: "search",
				Consultation: "consultation"
			},

			/**
			 * Object with constants of the case.
			 * @type {Object}
			 */
			Case: {
				Status: {
					Closed: "3e7f420c-f46b-1410-fc9a-0050ba5d6c38",
					New: "ae5f2f10-f46b-1410-fd9a-0050ba5d6c38",
					Canceled: "6e5f4218-f46b-1410-fe9a-0050ba5d6c38",
					InWork: "7e9f1204-f46b-1410-fb9a-0050ba5d6c38"
				}
			},

			/**
			 * Object with types of the QualifyStatus.
			 * @type {Object}
			 */
			QualifyStatus: {
				Qualification: "d790a45d-03ff-4ddb-9dea-8087722c582c",
				Distribution: "14cfc644-e3ed-497e-8279-ed4319bb8093",
				Disqualified: "128c3718-771a-4d1e-9035-6fa135ca5f70",
				TransferForSale: "ceb70b3c-985f-4867-ae7c-88f9dd710688",
				WaitingForSale: "7a90900b-53b5-4598-92b3-0aee90626c56",
				Satisfied: "0a0808c5-5415-41f0-bea3-118cc3089959",
				Absent: "51adc3ec-3503-4b10-a00b-8be3b0e11f08"
			},

			/**
			 * Object with constants of the finapplication.
			 * @type {Object}
			 */
			FinApplication: {
				Status: {
					Closed: "c8bd7900-de8f-428d-b3c7-d191518d7f35",
					New: "adfeed22-daf5-44ac-a0e4-477892f5362b",
					Canceled: "3f862a76-8cde-4357-9c92-fe0b4b9ba8a5",
					InWork: "ddbc52bc-e014-4d73-92cb-9314b9e58da7",
					OnVerification: "a6a4dd53-1f77-4adc-b8e6-d7803197efcb"
				}
			},

			/**
			 * Object with types of the theme consultation.
			 * @type {Object}
			 */
			ConsultationThemesInBlock: {
				Group: "0ef974e2-f30f-48e1-a466-212ecff0f4b6",
				Theme: "a7ca5e27-906c-497e-a3dc-f3f46939f676"
			},

			/**
			 * Object with types of anniversary.
			 * @type {Object}
			 */
			AnniversaryType: {
				CompanyFoundationDay: "294463e7-fdca-df11-9b2a-001d60e938c6"
			}
		});
		return Ext.create("Terrasoft.OBSWConstants");
	});
