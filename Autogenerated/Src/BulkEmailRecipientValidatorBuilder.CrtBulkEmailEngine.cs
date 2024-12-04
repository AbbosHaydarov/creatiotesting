namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using System.Linq;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Core.Entities;

	#region Class: BulkEmailRecipientValidatorBuilder

	/// <summary>
	/// Represents a class for building macro validation rules.
	/// </summary>
	public class BulkEmailRecipientValidatorBuilder
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="BulkEmailRecipientValidatorBuilder"/> class.
		/// </summary>
		/// <param name="serviceApi">Service for working with api.</param>
		[Obsolete("7.18.4 | Use BulkEmailRecipientValidatorBuilder() instead.")]
		public BulkEmailRecipientValidatorBuilder(ICESApi serviceApi) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BulkEmailRecipientValidatorBuilder"/> class.
		/// </summary>
		/// <param name="serviceApi">Service for working with api.</param>
		/// <param name="bulkEmail">BulkEmail entity.</param>
		[Obsolete("8.1.2 | Use BulkEmailRecipientValidatorBuilder() instead.")]
		public BulkEmailRecipientValidatorBuilder(ICESApi serviceApi, Entity bulkEmail) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BulkEmailRecipientValidatorBuilder"/> class.
		/// </summary>
		public BulkEmailRecipientValidatorBuilder() {
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Initializes validation rules.
		/// </summary>
		public List<BaseValidationRule> InitRules() {
			var result = new List<BaseValidationRule> {
				new FromNameNotNullValidationRule(),
				new FromEmailMaskValidationRule()
			};
			return result;
		}

		#endregion

	}

	#endregion

}

