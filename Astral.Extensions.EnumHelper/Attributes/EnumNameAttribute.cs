using System;
using System.Collections.Generic;
using System.Text;

namespace Astral.Extensions.EnumHelper.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumNameAttribute : Attribute
    {
        public readonly string Description;

        public EnumNameAttribute(string description)
        {
            this.Description = description;
        }
    }
}
