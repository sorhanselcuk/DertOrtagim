namespace Core.Entities.SecurityModels
{
    public class AuthorizationType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
