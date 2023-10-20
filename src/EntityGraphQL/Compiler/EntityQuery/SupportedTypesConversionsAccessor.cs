using System;

namespace EntityGraphQL.Compiler.EntityQuery
{
    public static class SupportedTypesConversionsAccessor
    {
        public static readonly SupportedTypeConversion[] SuportedTypesConversions = new SupportedTypeConversion[]
        {
            new SupportedTypeConversion()
            {
                Type = typeof(Guid),
                ConversionClass = typeof(Guid),
                ConversionMethod = nameof(Guid.Parse)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(string),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(object),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(decimal),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(decimal?),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(Int64),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(Int64?),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(Int32),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(Int32?),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(Int16),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            },
            new SupportedTypeConversion()
            {
                Type = typeof(Int16?),
                ConversionClass = typeof(TypeChanger),
                ConversionMethod = nameof(TypeChanger.ConvertToType)
            }
        };
    }
}
