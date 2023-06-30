﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMapped
    {
        public static SMMapped MakeMappedNew(SMMappingInformation information, SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            return MappedTrigger(information, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, debug);
        }
    }
}