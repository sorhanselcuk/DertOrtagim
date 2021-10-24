namespace Core.Entities.SecurityModels
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public int AuthorizationTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
