using System.ComponentModel.DataAnnotations.Schema;

namespace Astral.Extensions.Console.Models
{
    [Table("Roles")]
    public class Role
    {
        [Column("RoleIdentificator")]
        public int RoleId { get; private set; }

        [Column("Name")]
        public string RoleName { get; set; }

        [Column("RoleGuid")]
        public Guid Guid { get; set; }
    }
}
