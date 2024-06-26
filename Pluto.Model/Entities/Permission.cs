namespace Pluto.Model.Entities
{
    /// <summary>
    /// Represents a permission in the system.
    /// </summary>
    public class Permission
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public List<RolePermission> RolePermissions { get; set; }
    }
}
