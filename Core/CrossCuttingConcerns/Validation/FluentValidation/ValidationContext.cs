namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    internal class ValidationContext<T>
    {
        private object entity;

        public ValidationContext(object entity)
        {
            this.entity = entity;
        }
    }
}