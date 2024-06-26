﻿namespace Pluto.Model.Entities
{
    /// <summary>
    /// Represents the relationship between a role and a permission in the system.
    /// </summary>
    public class RolePermission
    {
        public long Id { get; set; }

        public long RoleId { get; set; }

        public Role Role { get; set; }

        public long PermissionId { get; set; }
        public Permission Permission { get; set; }
    }
}
