using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMapper
    {
        public static SMMapper Runtime_MakeMapperNew(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC)
        {
            SMMapper mapperResult = default;

            mapperResult = MakeMapperNew(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, SAPolicy.MapperDebugPolicy);

            return mapperResult;
        }
    }
}
