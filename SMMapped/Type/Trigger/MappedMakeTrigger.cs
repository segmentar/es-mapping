﻿using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped MappedTrigger(SMMappingInformation information, SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            SMMapped mappedResult = default;

            var map = SMMap.Runtime_MakeMapNew(information, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC);

            information.Map = map;

            var list_RESOLVED = new List<SRResolved>();

            var list_RESOLVER = new List<SRResolver>();

            mappedResult = LoopMappedOneFirst(map, list_RESOLVED, list_RESOLVER, debug);

            return mappedResult;
        }
    }
}