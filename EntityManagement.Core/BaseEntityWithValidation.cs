using System;
using FluentValidation;

namespace EntityManagement.Core
{
    /// <summary>
    /// Base Entity With Validator
    /// </summary>
    /// <typeparam name="TEntity">Type of <see cref="BaseEntity{TId}"/> to be validated</typeparam>
    /// <typeparam name="TId">Type of ID property for <typeparamref name="TEntity"/></typeparam>
    /// <typeparam name="TValidator">Type of <see cref="AbstractValidator{T}"/> to use</typeparam>
    public class BaseEntityWithValidation<TEntity, TId, TValidator> : BaseEntity<TId>
        where TEntity : BaseEntity<TId>
        where TValidator : AbstractValidator<TEntity>, new()
    {
        /// <summary>
        /// Validate
        /// </summary>
        /// <param name="entity">Entity to validate</param>
        /// <exception cref="ValidationException">Thrown if validation fails</exception>
        protected static void Validate(TEntity entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var validator = new TValidator();
            var result = validator.Validate(entity);

            if (result?.Errors?.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
