using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapper
    {
        public static SMMapper LoopMapperFiveFifth
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
                owner: nameof(LoopMapperFiveFifth),
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

            queue_PARENT__FURTHER.Clear();

            var nester_PARENT__FURTHER = SNNester.Runtime_MakeNesterInnerRight(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, text_DYNAMIC);

            var safe_match_ZERO__TEN_parent_further = (nester_PARENT__FURTHER == default) is true;

            if (safe_match_ZERO__TEN_parent_further)
            {
                goto skip;
            }
            else
            {
                queue_PARENT__FURTHER.Enqueue(nester_PARENT__FURTHER);
            }

            var match_ONE__FIRST = (nester_PARENT__FURTHER.LayerMinimum < queue_CHILD.Peek().LayerMinimum) is true;

            if (match_ONE__FIRST is true)
            {
                goto align_SWAP;

                align_SWAP:
                {
                    var parent = queue_PARENT.Dequeue();

                    var parent_further = queue_PARENT__FURTHER.Dequeue();

                    queue_PARENT.Enqueue(parent_further);

                    queue_PARENT__FURTHER.Enqueue(parent);
                }
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
