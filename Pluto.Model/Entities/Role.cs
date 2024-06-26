namespace Pluto.Model.Entities
{
    /// <summary>
    /// Represents a role in the system.
    /// </summary>
    public class Role
    {
        public long Id { get; set; }

        public string? Name { get; set; }
        public List<User> Users { get; set; }

        public List<RolePermission> RolePermissions { get; set; }
    }
}
