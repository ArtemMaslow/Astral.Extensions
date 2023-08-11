using Astral.Extensions.SqlHelper.Tests.TestEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.SqlHelper.Tests
{
    public class SqlHelperTests
    {
        [Test]
        public void GetSqlSelect_ErrorTableAttribute()
        {
            var sqlHelper = new SqlHelper();
            var ex = Assert.Throws<Exception>(() => sqlHelper.GetSqlSelect<UserWithoutTableAttribute>());
            Assert.That(ex.Message, Is.EqualTo("У UserWithoutTableAttribute отсутсвует атрибут TableAttribute"));
        }
    }
}
