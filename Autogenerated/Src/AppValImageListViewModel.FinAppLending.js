define("AppValImageListViewModel", ["ModalBox", "ImageListViewModel"],
	function() {
		Ext.define("Terrasoft.configuration.AppValImageListViewModel", {
			alternateClassName: "Terrasoft.AppValImageListViewModel",
			extend: "Terrasoft.ImageListViewModel",

			//region Methods: Private

			/**
			 * Link click handler.
			 * @private
			 * @param {Object} event Event.
			 */
			onClickLink: function(event) {
				if (this.Ext.isFunction(this.linkClickHandler)) {
					event.stopEvent();
					this.linkClickHandler(this.get("Name"), event.target.href);
				}
			},

			//endregion

			//region Methods: Protected

			/**
			 * @inheritDoc Terrasoft.ImageListViewModel#insertEntityLink
			 */
			insertEntityLink: function() {
				this.callParent(arguments);
				var container = this.getLinkContainer();
				if (container && !this.isEntityLink) {
					container.wrapEl.el.on("click", this.onClickLink, this);
				}
			},

			/**
			 * @inheritDoc Terrasoft.Component#onDestroy
			 */
			onDestroy: function() {
				var container = this.getLinkContainer();
				if (container) {
					container.wrapEl.el.un("click", this.onClickLink, this);
				}
				this.callParent(arguments);
			}

			//endregion

		});
	});
