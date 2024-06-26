namespace Pluto.Model.Entities
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>

    public class User
    {
        public long Id { get; set; }

        public string? UserName { get; set; }

        public long FkRole { get; set; }

        public Role Role { get; set; }
        
    }
}
