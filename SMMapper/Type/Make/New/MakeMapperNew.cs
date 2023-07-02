using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMapper
    {
        public static SMMapper MakeMapperNew(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            SMMapper mapperResult = default;

            var mapper = new SMMapperSequence(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, debug).Mapper;

            ArrayList.Add(mapper);

            mapperResult = mapper;

            return mapperResult;
        }
    }
}
