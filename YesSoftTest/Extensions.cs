using System;
using System.Collections.Generic;
using System.Text;

namespace YesSoftTest
{
    public static class Extensions
    {
        public static bool IsDivisableInterface(this Type @interface)
        {
            if (!@interface.IsGenericType)
            {
                return false;
            }
            Type typeDefinition = @interface.GetGenericTypeDefinition();

            return typeDefinition == typeof(IDivisable<>);
        }
    }
}
