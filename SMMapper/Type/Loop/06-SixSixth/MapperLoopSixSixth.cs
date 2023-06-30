using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapper
    {
        public static SMMapper LoopMapperSixSixth
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
                owner: nameof(LoopMapperSixSixth),
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

            var match_ZERO__TEN_parent = (queue_PARENT.Count == 1) is true;

            if (match_ZERO__TEN_parent is true)
            {
                foreach (SNNester nester_DYNAMIC in new List<SNNester>(list_NESTER__DYNAMIC))
                {
                    var safe_ONE__FIRST = true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (queue_PARENT.Peek().Left.Position < nester_DYNAMIC.Left.Position) is true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (queue_PARENT.Peek().Right.Position > nester_DYNAMIC.Right.Position) is true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (((queue_PARENT.Peek().LayerMinimum - nester_DYNAMIC.LayerMinimum) + 1) == 0) is true;

                    if (safe_ONE__FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var list_CHAIN__COLLAPSE = new List<SNNester>();

                    foreach (SNNester nester_CHAIN in new List<SNNester>(list_CHAIN))
                    {
                        list_CHAIN__COLLAPSE.Add(nester_CHAIN);

                        list_CHAIN.Remove(nester_CHAIN);

                        continue;
                    }

                    list_NESTER__DYNAMIC.Remove(nester_DYNAMIC);

                    var nest = SNNest.Runtime_MakeNestNew(queue_PARENT.Peek(), nester_DYNAMIC, list_CHAIN__COLLAPSE);

                    list_NEST.Add(nest);

                    continue;
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
