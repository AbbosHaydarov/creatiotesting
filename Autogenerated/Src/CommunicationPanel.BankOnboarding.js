define("CommunicationPanel", ["terrasoft"],
		function() {
			return {
				messages: {},
				attributes: {},
				diff: [
					{
						"operation": "merge",
						"name": "OBSW",
						"values": {
							"visible": {
								"bindTo": "getIsNotPortalUser"
							}
						}
					}
				]
			};
		});
