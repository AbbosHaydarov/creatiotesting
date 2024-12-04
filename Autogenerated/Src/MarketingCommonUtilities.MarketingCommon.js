define("MarketingCommonUtilities", [],
	function() {

		/**
		 * ########## ######### #### # #######, ####### ##### ## ######## url.
		 * @param {String} message ############ #########.
		 * @param {String} url ######.
		 * @param {String} goButtonCaption ######### ###### ########.
		 * @param {Object} scope ######## ##########.
		 */
		function showConfirmationDialogWithGoButton(message, url, goButtonCaption, scope) {
			var goButtonConfig = {
				className: "Terrasoft.Button",
				returnCode: "goButton",
				style: "blue",
				caption: goButtonCaption
			};
			scope.showConfirmationDialog(message,
				function(returnCode) {
					if (returnCode === "goButton") {
						window.open(url);
					}
				}, [goButtonConfig, "cancel"]);
		}

		function showConfirmationDialogWithRedirectButton(message, handler, redirectButtonCaption, scope) {
			var redirectButtonConfig = {
				className: "Terrasoft.Button",
				returnCode: "redirectButton",
				style: "blue",
				caption: redirectButtonCaption
			};
			scope.showConfirmationDialog(message,handler, [redirectButtonConfig, "cancel"]);
		}

		function showConfirmationDialogWithBtnHandler(message, goButtonCaption, handler, scope) {
			var goButtonConfig = {
				className: "Terrasoft.Button",
				returnCode: "goButton",
				style: "blue",
				caption: goButtonCaption,
				markerValue: goButtonCaption
			};
			scope.showConfirmationDialog(message, handler, [goButtonConfig, "cancel"]);
		}

		return {
			ShowConfirmationDialogWithGoButton: showConfirmationDialogWithGoButton,
			ShowConfirmationDialogWithRedirectButton: showConfirmationDialogWithRedirectButton,
			ShowConfirmationDialogWithBtnHandler: showConfirmationDialogWithBtnHandler,
		};
	});
