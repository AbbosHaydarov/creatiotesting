namespace Terrasoft.Configuration
{
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core.Factories;

	/// <summary>
	/// Interface for creating a chain of bulk email validators.
	/// </summary>
	public interface IBulkEmailValidatorFactory
	{
		/// <summary>
		/// Creates a chain of bulk email validators.
		/// </summary>
		BaseMessageValidator CreateChainOfBulkEmailValidators(SendingType sendingType);
	}

	/// <summary>
	/// Creates and manages a chain of bulk email validators.
	/// </summary>
	[DefaultBinding(typeof(IBulkEmailValidatorFactory))]
	public class BulkEmailValidatorFactory : IBulkEmailValidatorFactory
	{

		#region Methods: Public

		/// <inheritdoc cref="IBulkEmailValidatorFactory.CreateChainOfBulkEmailValidators"/>
		public BaseMessageValidator CreateChainOfBulkEmailValidators(SendingType sendingType) {
			List<BaseMessageValidator> bulkEmailValidators = ClassFactory
				.GetAll<BaseMessageValidator>()
				.Where(validator => validator.SendingTypesToValidate.Contains(sendingType))
				.OrderBy(validator => validator.Priority)
				.ToList();
			BaseMessageValidator firstValidator = bulkEmailValidators.FirstOrDefault();
			if (firstValidator == null) {
				return null;
			}
			BaseMessageValidator currentValidator = firstValidator;
			foreach (BaseMessageValidator bulkEmailValidator in bulkEmailValidators.Skip(1)) {
				currentValidator = currentValidator.SetNext(bulkEmailValidator);
			}
			return firstValidator;
		}

		#endregion

	}
	
}

