using Astral.Extensions.SqlHelper.Tests.TestEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.SqlHelper.Tests
{
    public class SqlHelperTests
    {

        private SqlHelper _sqlHelper;

        [SetUp]
        public void SetUp()
        {
            _sqlHelper = new SqlHelper();
        }

        [Test]
        public void GetSqlSelect_ErrorTableAttribute()
        {
            var ex = Assert.Throws<Exception>(() => _sqlHelper.GetSqlSelect<UserWithoutTableAttribute>());
            Assert.That(ex.Message, Is.EqualTo("У UserWithoutTableAttribute отсутсвует атрибут TableAttribute"));
        }

        [Test]
        public void GetSqlSelect_ErrorIncorrectNameInJoinOnAttribute()
        {
            var ex = Assert.Throws<Exception>(() => _sqlHelper.GetSqlSelect<UserWithIncorrectNameInJoinOnAttribute>());
            Assert.That(ex.Message, Is.EqualTo("Отсутствует свойство RoleI в классе UserWithIncorrectNameInJoinOnAttribute"));
        }

        [Test]
        public void GetSqlSelect_ErrorColumnAttributeOnBoundProperty()
        {
            var ex = Assert.Throws<Exception>(() => _sqlHelper.GetSqlSelect<UserWithoutColumnAttributeOnBoundProperty>());
            Assert.That(ex.Message, Is.EqualTo("У UserWithoutColumnAttributeOnBoundProperty.RoleId отсутсвует атрибут ColumnAttribute"));
        }

        [Test]
        public void GetSqlSelect_Correct()
        {
            var sqls = new List<string>();
            var assembly = typeof(SqlHelperTests).Assembly;
            var correctClasses = assembly.ExportedTypes.Where(et => et.Namespace.Contains("CorrectClasses"));
            MethodInfo method = typeof(SqlHelper).GetMethod(nameof(SqlHelper.GetSqlSelect));
            foreach (var type in correctClasses) 
            {
                MethodInfo generic = method.MakeGenericMethod(type);
                var result = (string)generic.Invoke(_sqlHelper, null);
                sqls.Add(result);
            }

            Assert.IsNotEmpty(sqls);
        }
    }
}
