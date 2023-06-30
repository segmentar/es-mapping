using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapper
    {
        public static SMMapper LoopMapperOneFirst
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
                owner: nameof(LoopMapperOneFirst),
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

            queue_CHILD.Clear();

            var nester_CHILD = SNNester.Runtime_MakeNesterInnerLeft(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, text_DYNAMIC);

            var safe_match_ZERO__TEN_child = (nester_CHILD == default) is true;

            if (safe_match_ZERO__TEN_child)
            {
                mapperResult = new SMMapper(
                    staticText: text_STATIC,
                    dynamicText: text_DYNAMIC,
                    symbolLeft: symbol_LEFT,
                    symbolRight: symbol_RIGHT,
                    delimiterLeft: delimiter_LEFT,
                    delimiterRight: delimiter_RIGHT,
                    originList: list_ORIGIN,
                    loneList: list_LONE,
                    chainList: list_CHAIN,
                    childList: list_CHILD,
                    parentList: list_PARENT,
                    nesterStaticList: list_NESTER__STATIC,
                    nesterDynamicList: list_NESTER__DYNAMIC,
                    nestList: list_NEST,
                    childNester: queue_CHILD,
                    parentNester: queue_PARENT,
                    childFurtherNester: queue_CHILD__FURTHER,
                    parentFurtherNester: queue_PARENT__FURTHER,
                    debug: debug
                );

                return mapperResult;
            }
            else
            {
                queue_CHILD.Enqueue(nester_CHILD);

                list_CHAIN.Add(nester_CHILD);

                list_NESTER__DYNAMIC.Add(nester_CHILD);
            }

            goto skip;

            skip:
            {
                return mapperResult;
            }
        }
    }
}
