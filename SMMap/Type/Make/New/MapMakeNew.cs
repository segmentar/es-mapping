using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMap
    {
        public static SMMap MakeMapNew(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            SMMap mapResult = default;

            mapResult = MakeMapTrigger(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, debug);

            return mapResult;
        }
    }
}
