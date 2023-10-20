using EntityGraphQL.Extensions;
using System;
using System.Globalization;

namespace EntityGraphQL.Compiler.EntityQuery
{
    public static class TypeChanger
    {
        public static T? ConvertToType<T>(object o)
        {
            var toType = typeof(T);
            if (toType.IsGenericType && toType.IsNullableType())
            {
                toType = toType.GetGenericArguments()[0];
            }

            var ret = Convert.ChangeType(o, toType, CultureInfo.InvariantCulture);
            if (ret != null)
            {
                return (T)ret;
            }

            return default;
        }
    }
}
