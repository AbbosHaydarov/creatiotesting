define("BaseEditableSpecificationInObjectViewModel",
	["SpecificationBankConstants", "LookupUtilities", "BaseEditableSpecificationInObjectViewModelResources"],
	function(SpecificationBankConstants, LookupUtilities, resources) {
		Ext.define("Terrasoft.configuration.BaseEditableSpecificationInObjectViewModel", {
			alternateClassName: "Terrasoft.BaseEditableSpecificationInObjectViewModel",
			extend: "Terrasoft.BaseViewModel",
			/**
			 * ########## ######### ######## # ########### ## #### #########.
			 * @param {String} tag ### #########.
			 * @returns {Boolean} ######### ########.
			 */
			getControlVisible: function(tag) {
				var dataType = this.get("DataType");
				var type = SpecificationBankConstants.DataTypes[dataType.value].type;
				return tag === type;
			},
			/**
			 * ########## ##### ## ######
			 */
			onLabelClick: function() {
				if (SpecificationBankConstants.DataTypes[this.get("DataType").value].type === "Boolean") {
					this.set("BooleanValue", !this.get("BooleanValue"));
				}
			},
			/**
			 * ######### ######## # ComboBox.
			 * @returns {Boolean} ######### ########.
			 */
			getConfigVisible: function() {
				return this.isDeleted !== true;
			},
			/**
			 * ######### ######## # ComboBox.
			 * @param {String} entitySchemaName ######## ########.
			 * @param {Terrasoft.FilterGroup} filters #######.
			 */
			loadComboBoxList: function(entitySchemaName, filters) {
				var select = Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: entitySchemaName
				});
				select.addColumn("Id");
				select.addColumn("Name");
				if (filters) {
					select.filters.addItem(filters);
				}
				select.getEntityCollection(function(response) {
					if (response.success) {
						var newCollection = new Terrasoft.Collection();
						var collection = response.collection;
						collection.each(function(item) {
							newCollection.add(item.get("Id"), {
								value: item.get("Id"),
								displayValue: item.get("Name")
							});
						}, this);
						this.set("ListItemValues", newCollection);
					}
				}, this);
			},
			/**
			 * ############## ######### ######### ComboBox.
			 */
			prepareListItemValues: function() {
				this.loadComboBoxList("SpecificationListItem", this.getSpecificationSubTypeFilter());
			},
			/**
			 * ########## ###### ####### ######### ## ######## #########.
			 * @returns {Terrasoft.FilterGroup} ###### ## #########.
			 */
			getSpecificationSubTypeFilter: function() {
				var filterGroup = Terrasoft.createFilterGroup();
				var specification = this.get("Specification");
				var specificationId = Ext.isObject(specification) && specification.value ? specification.value
					: this.get("Id");
				filterGroup.addItem(Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "Specification", specificationId));
				return filterGroup;
			},
			/**
			 * ########## ######## #########.
			 * @returns {String} ######## #########.
			 */
			getLabelCaption: function() {
				var specification = this.get("Specification");
				if (specification) {
					var caption = specification.displayValue ? specification.displayValue : specification;
					return caption;
				}
				return "";
			},
			/**
			 * ########## ###### ###### ########.
			 * @returns {String} data-item-marker.
			 */
			getDeleteMarkerValue: function() {
				return resources.localizableStrings.DeleteCaption + this.getLabelCaption();
			},
			/**
			 * ####### #######.
			 */
			deleteItem: function() {
				this.isDeleted = true;
				this.set("isDeleted", true);
				this.fireEvent("change", this, {
					OperationType: "Delete"
				});
			},
			/**
			 * ######### ###### ### ########## ########
			 * @private
			 * @returns {Terrasoft.InsertQuery} ########## ###### ## ##########
			 */
			getSaveQuery: function() {
				var entitySchema = this.entitySchema;
				if (entitySchema == null) {
					throw new Terrasoft.exceptions.ArgumentNullOrEmptyException({argumentName: "entitySchema"});
				}
				var query = null;
				if (this.isDeleted && !this.isNew) {
					query = this.getDeleteQuery();
					query.enablePrimaryColumnFilter(this.get("Id"));
					return query;
				} else if (this.isNew && !this.isDeleted) {
					this.set("Id", Terrasoft.generateGUID());
					query = this.getInsertQuery();
				} else if (!this.isNew && !this.isDeleted) {
					query = this.getUpdateQuery();
					query.enablePrimaryColumnFilter(this.get("Id"));
				}
				if (!query) {
					return null;
				}
				var columnValues = query.columnValues;
				columnValues.clear();
				var columnNames = new Terrasoft.Collection();
				columnNames.collection.addAll(this.get("DetailColumnName"), "ListItemValue", "Specification",
					"FloatValue", "IntValue", "BooleanValue", "StringValue");
				for (var columnName in this.changedValues) {
					if (this.changedValues.hasOwnProperty(columnName)) {
						var column = this.columns[columnName];
						if (column && columnNames.collection.contains(columnName)) {
							column.type = Terrasoft.ViewModelColumnType.ENTITY_COLUMN;
							column.columnPath = column.name;
						}
						if (!column || column.type !== Terrasoft.ViewModelColumnType.ENTITY_COLUMN) {
							continue;
						}
						var columnPath = column.columnPath;
						if (!entitySchema.isColumnExist(columnPath)) {
							continue;
						}
						var columnValue = this.get(columnName);
						if (column.isLookup && columnValue) {
							columnValue = columnValue.value;
						}
						columnValues.setParameterValue(columnPath, columnValue, this.getColumnDataType(columnName));
					}
				}
				return query;
			}
		});
	});
