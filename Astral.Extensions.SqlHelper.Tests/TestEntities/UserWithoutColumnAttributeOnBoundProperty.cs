using Astral.Extensions.SqlHelper.CustomAttributes;
using Astral.Extensions.SqlHelper.Tests.TestEntities.CorrectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.SqlHelper.Tests.TestEntities
{
    [Table("Users")]
    public class UserWithoutColumnAttributeOnBoundProperty
    {
        public int RoleId { get; private set; }

        [JoinOn("RoleId", "RoleId")]
        public Role Role { get; set; }
    }
}
