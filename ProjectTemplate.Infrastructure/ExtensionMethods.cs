using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ProjectTemplate.Infrastructure
{
    public static class ExtensionMethods
    {
        public static string DisplayName(this Enum value)
        {
            Type enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            MemberInfo member = enumType.GetMember(enumValue)[0];

            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
            var outString = ((DisplayAttribute)attrs[0]).Name;

            if (((DisplayAttribute)attrs[0]).ResourceType != null)
            {
                outString = ((DisplayAttribute)attrs[0]).GetName();
            }
            return outString;

        }

        public static int DisplayValues(this Enum value)
        {
            return Convert.ToInt16(value);
        }
    }
}
