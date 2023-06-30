﻿using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.SqlClient;

    public partial class SMMapper
    {
        public static SMMapper LoopMapperFourFourth
(
SGText text_STATIC,
SGText text_DYNAMIC,
SGSymbol symbol_LEFT,
SGSymbol symbol_RIGHT,
SGDelimiter delimiter_LEFT,
SGDelimiter delimiter_RIGHT,
List<SNNester> list_ORIGIN,
List<SNNester> list_LONE,
List<SNNester> list_CHAIN,
List<SNNester> list_CHILD,
List<SNNester> list_PARENT,
List<SNNester> list_NESTER__STATIC,
List<SNNester> list_NESTER__DYNAMIC,
List<SNNest> list_NEST,
Queue<SNNester> queue_CHILD,
Queue<SNNester> queue_PARENT,
Queue<SNNester> queue_CHILD__FURTHER,
Queue<SNNester> queue_PARENT__FURTHER,
Boolean debug
)
        {
            SMMapper mapperResult = default;

            SMMapperLoop.Remote(
                owner: nameof(LoopMapperFourFourth),
                text_STATIC: text_STATIC,
                text_DYNAMIC: text_DYNAMIC,
                symbol_LEFT: symbol_LEFT,
                symbol_RIGHT: symbol_RIGHT,
                delimiter_LEFT: delimiter_LEFT,
                delimiter_RIGHT: delimiter_RIGHT,
                list_ORIGIN: list_ORIGIN,
                list_LONE: list_LONE,
                list_CHAIN: list_CHAIN,
                list_CHILD: list_CHILD,
                list_PARENT: list_PARENT,
                list_NESTER__STATIC: list_NESTER__STATIC,
                list_NESTER__DYNAMIC: list_NESTER__DYNAMIC,
                list_NEST: list_NEST,
                queue_CHILD: queue_CHILD,
                queue_PARENT: queue_PARENT,
                queue_CHILD__FURTHER: queue_CHILD__FURTHER,
                queue_PARENT__FURTHER: queue_PARENT__FURTHER,
                debug: debug
                );

            queue_PARENT.Clear();

            var nester_PARENT = SNNester.Runtime_MakeNesterInnerLeft(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, text_DYNAMIC);

            var match_ZERO__TEN_parent = (nester_PARENT == default) is false;

            if (match_ZERO__TEN_parent is true)
            {
                queue_PARENT.Enqueue(nester_PARENT);
            }
            else
                "false".ToString();

            goto skip;

            skip:
            {
                return mapperResult;
            }
        }
    }
}
