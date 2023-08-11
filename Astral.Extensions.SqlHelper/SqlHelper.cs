using Astral.Extensions.SqlHelper.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Astral.Extensions.SqlHelper
{
    public class SqlHelper
    {
        private Dictionary<string, PropertyInfo> _checkedPrperties = new Dictionary<string, PropertyInfo>();
        private Dictionary<string, PropertyInfo[]> _types = new Dictionary<string, PropertyInfo[]>();
        private List<string> _fields = new List<string>();
        private List<string> _joins = new List<string>();
        private int _aliasCounter = 0;

        public string GetSqlSelect<T>()
        {
            var type = typeof(T);
            var properties = type.GetProperties();
            var tableName = GetCustomAttribute<TableAttribute>(type, false).Name;
            var tableAlias = GetTableAlias();
            _types.Add(type.FullName, properties);
            GetSql(properties, tableAlias);

            var allFields = string.Join($",{Environment.NewLine}", _fields);
            var allJoins = string.Join($"{Environment.NewLine}", _joins);
            return $"select{Environment.NewLine}{allFields}{Environment.NewLine}from {tableName} {tableAlias}{Environment.NewLine}{allJoins};"; 
        }

        private void GetSql(PropertyInfo[] properties, string tableAlias)
        {
            foreach (var property in properties) 
            {
                if (property.PropertyType.IsClass && 
                    property.PropertyType != typeof(string) &&
                    Attribute.IsDefined(property, typeof(JoinOn)) &&
                    !_checkedPrperties.ContainsKey($"{property.ReflectedType.Name}.{property.Name}"))
                {
                    _checkedPrperties.Add($"{property.ReflectedType.Name}.{property.Name}", property);
                    PropertyInfo[] innerClassProperties;
                    if (_types.ContainsKey(property.PropertyType.FullName))
                    {
                        innerClassProperties = _types[property.PropertyType.FullName];
                    }
                    else
                    {
                        innerClassProperties = property.PropertyType.GetProperties();
                        _types.Add(property.PropertyType.FullName, innerClassProperties);
                    }
                    var innerTableName = GetCustomAttribute<TableAttribute>(property.PropertyType, false).Name;

                    var innerTableAlias = GetTableAlias();
                    var joinOnAttribute = GetCustomAttribute<JoinOn>(property, false);
                    var leftProp = properties.Single(p => p.Name == joinOnAttribute.LeftPart);
                    var lefPropColumn = GetCustomAttribute<ColumnAttribute>(leftProp, false).Name; 
                    var rightProp = innerClassProperties.Single(p => p.Name == joinOnAttribute.RightPart);
                    var rightPropColumn = GetCustomAttribute<ColumnAttribute>(rightProp, false).Name;
                    _joins.Add($"\tjoin {innerTableName} {innerTableAlias} on {tableAlias}.{lefPropColumn} = {innerTableAlias}.{rightPropColumn}");
                    GetSql(innerClassProperties, innerTableAlias);
                    continue;
                }

                var columnAttribute = property.GetCustomAttribute<ColumnAttribute>();
                if (columnAttribute != null)
                {
                    _fields.Add($"\t{tableAlias}.{columnAttribute.Name} as \"{property.Name}\"");
                }
            }
        }

        private string GetTableAlias()
        {
            _aliasCounter++;
            return $"t{_aliasCounter}";
        }

        private void AttributeIsDefined<T>(MemberInfo type)
        {
            if (!Attribute.IsDefined(type, typeof(T)))
            {
                var value = type.ReflectedType != null ? $"{type.ReflectedType.Name}.{type.Name}" : $"{type.Name}";
                throw new Exception($"У {value} отсутсвует атрибут {typeof(T).Name}");
            }
        }

        private T GetCustomAttribute<T>(MemberInfo member, bool inherit) where T : Attribute 
        {
            AttributeIsDefined<T>(member);
            return member.GetCustomAttribute<T>(inherit);
        }

    }
}
