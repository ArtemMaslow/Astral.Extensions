using Astral.Extensions.EnumHelper.Attributes;
using Astral.Extensions.EnumHelper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Astral.Extensions.EnumHelper
{
    public static class EnumHelper
    {
        private static Dictionary<ApplicationInfo, string> _allApplicationNames = new Dictionary<ApplicationInfo, string>();

        static EnumHelper()
        {
            ApplicationInfo[] vals = (ApplicationInfo[])Enum.GetValues(typeof(ApplicationInfo));
            for (int i = 0; i < vals.Length; i++)
            {
                _allApplicationNames.Add(vals[i], GetApplicationName(vals[i]));
            }
        }

        public static string[] GetAllApplicationNames()
        {
            ApplicationInfo[] vals = (ApplicationInfo[])Enum.GetValues(typeof(ApplicationInfo));
            string[] names = new string[vals.Length];
            for (int i = 0; i < vals.Length; i++)
            {
                names[i] = GetApplicationName(vals[i]);
            }
            return names;
        }

        public static string[] GetAllApplicationNames<T>()
        {
            T[] vals = (T[])Enum.GetValues(typeof(T));
            string[] names = new string[vals.Length];
            for (int i = 0; i < vals.Length; i++)
            {
                names[i] = GetApplicationName<T>(vals[i]);
            }
            return names;
        }

        public static string GetApplicationName(this ApplicationInfo applicationInfo)
        {
            object[] attribs = typeof(ApplicationInfo).GetField(applicationInfo.ToString()).GetCustomAttributes(typeof(EnumNameAttribute), false);

            if (attribs != null && attribs.Length > 0)
            {
                return ((EnumNameAttribute)attribs[attribs.Length - 1]).Description;
            }

            throw new NotImplementedException("Конвертация для данного формата не реализована");
        }

        public static string GetApplicationName<T>(this T applicationInfo)
        {
            var type = typeof(T);
            var fieldName = applicationInfo.ToString();
            object[] attribs = type.GetField(fieldName).GetCustomAttributes(typeof(EnumNameAttribute), false);

            if (attribs != null && attribs.Length > 0)
            {
                return ((EnumNameAttribute)attribs[attribs.Length - 1]).Description;
            }

            throw new NotImplementedException($"Поле {fieldName} типа {type.Name} не имеет {nameof(EnumNameAttribute)} атрибут");
        }

        public static string[] GetAllApplicationNamesOptimized()
        {
            return _allApplicationNames.Values.ToArray();
        }

        public static string GetApplicationNameOptimized(this ApplicationInfo applicationInfo)
        {
            return _allApplicationNames[applicationInfo];
        }
    }
}
