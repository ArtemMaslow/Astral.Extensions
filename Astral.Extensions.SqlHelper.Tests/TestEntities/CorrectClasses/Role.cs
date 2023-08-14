using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.SqlHelper.Tests.TestEntities.CorrectClasses
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
