using System;

namespace EntityGraphQL.Compiler.EntityQuery
{
    public record SupportedTypeConversion
    {
        public Type Type { get; set; } = null!;
        public Type ConversionClass { get; set; } = null!;
        public string ConversionMethod { get; set; } = null!;
    }
}
