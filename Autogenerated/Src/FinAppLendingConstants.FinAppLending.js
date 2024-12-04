define("FinAppLendingConstants", ["FinAppLendingConstantsResources"], function(resources) {
	/**
	 * @class Terrasoft.configuration.FinAppLendingConstants
	 * FinApplication class provides configuration constants specific to fin application operations.
	 */
	Ext.define("Terrasoft.configuration.FinAppLendingConstants", {
		alternateClassName: "Terrasoft.FinAppLendingConstants",

		AppValidation: {
			ConductVerificationMode: {
				OneParticipant: {
					value: 0,
					displayValue: resources.localizableStrings.OneParticipantCaption
				},
				MoreParticipants: {
					value: 1,
					displayValue: resources.localizableStrings.MoreParticipantsCaption
				},
				HarmonizeApplication: {
					value: 2,
					displayValue: resources.localizableStrings.HarmonizeApplicationCaption
				}
			},
			PerformActionMode: {
				EmployeesGroup: {
					value: 0,
					displayValue: resources.localizableStrings.EmployeesGroupCaption
				},
				ResponsibleOfficer: {
					value: 1,
					displayValue: resources.localizableStrings.ResponsibleOfficerCaption
				}
			},
			ValidationDisplayMode: {
				AddNewRecord: {
					value: 0,
					displayValue: resources.localizableStrings.AddNewRecordCaption
				},
				EditExistingRecord: {
					value: 1,
					displayValue: resources.localizableStrings.EditExistingRecordCaption
				}
			},
			DefaultAppValidationPage: {
				name: "PreconfiguredAppValidationPage",
				uId: "f4c32205-515b-4dfb-9367-dfeb57fcd361"
			}

		},
		AppValidationResult: {
			Approved: {
				code: "Approved",
				value: "a674d6cd-44e0-42a4-8f7f-7a1d55902081"
			},
			NotApproved: {
				code: "NotApproved",
				value: "c274081c-1417-4083-aa37-7c15ad0bb333"
			},
			ToWork: {
				code: "ToWork",
				value: "79553cf6-edb2-4d6b-b6c3-1324017a21ae"
			}
		},
		AppValidationAnswer: {
			Other: "b2b19d84-8159-48f2-aa65-fd638c661193",
			Yes: "a78723b5-7a4b-4cec-a65d-2da030fda3d1",
			No: "7631a2c6-763b-4e69-996f-af1d971a7223"
		}
	});

	return Ext.create("Terrasoft.FinAppLendingConstants");
});
