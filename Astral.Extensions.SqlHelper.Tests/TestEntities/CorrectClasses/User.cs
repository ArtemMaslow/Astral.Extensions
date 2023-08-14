using Astral.Extensions.SqlHelper.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.SqlHelper.Tests.TestEntities.CorrectClasses
{
    [Table("Users")]
    public class User
    {
        [Column("UserIdentificator")]
        public int UserId { get; private set; }

        [Column("Login")]
        public string UserLogin { get; set; }

        [Column("Password")]
        public string UserPassword { get; set; }

        [Column("RoleIdentificator")]
        public int RoleId { get; private set; }

        [Column("AdvancedRoleIdentificator")]
        public Guid AdvancedRoleId { get; set; }

        [JoinOn("RoleId", "RoleId")]
        public Role Role { get; set; }

        [JoinOn("AdvancedRoleId", "Guid")]
        public Role AdvancedRole { get; set; }
    }
}
