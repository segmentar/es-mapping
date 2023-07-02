using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMap
    {
        public static void LoopMapperTwoSecond
(
IEnumerable<SNNester> enumerable,
IEnumerator<SNNester> enumerator,
SGText text_STATIC,
SGText text_DYNAMIC,
SGSymbol symbol_LEFT,
SGSymbol symbol_RIGHT,
SGDelimiter delimiter_LEFT,
SGDelimiter delimiter_RIGHT,
List<SNNest> list_NEST,
List<SNNester> list_LONE,
List<SNNester> list_CHILD,
List<SNNester> list_PARENT,
List<SNNester> list_DYNAMIC,
List<SNNester> list_ASYMMETRY,
Stack<SNNester> stack_NESTER__STATIC,
Stack<SNNester> stack_NESTER__CHAIN,
Boolean debug
)
        {
            SMMapSequence.Remote(
                owner: nameof(LoopMapperTwoSecond),
                enumerable: enumerable,
                enumerator: enumerator,
                text_STATIC: text_STATIC,
                text_DYNAMIC: text_DYNAMIC,
                symbol_LEFT: symbol_LEFT,
                symbol_RIGHT: symbol_RIGHT,
                delimiter_LEFT: delimiter_LEFT,
                delimiter_RIGHT: delimiter_RIGHT,
                list_NEST: list_NEST,
                list_LONE: list_LONE,
                list_CHILD: list_CHILD,
                list_PARENT: list_PARENT,
                list_DYNAMIC: list_DYNAMIC,
                list_ASYMMETRY: list_ASYMMETRY,
                stack_NESTER__STATIC: stack_NESTER__STATIC,
                stack_NESTER__CHAIN: stack_NESTER__CHAIN,
                debug: debug
                );

            list_LONE.Clear();

            foreach (SNNester nester in list_DYNAMIC)
            {
                list_LONE.Add(nester);

                continue;
            }

            list_CHILD.Clear();

            foreach (SNNest nest in list_NEST)
            {
                list_CHILD.Add(nest.Child);

                continue;
            }

            list_PARENT.Clear();

            foreach (SNNest nest in list_NEST)
            {
                list_PARENT.Add(nest.Parent);

                continue;
            }

            list_ASYMMETRY.Clear();

            foreach (SNNester nester in list_LONE)
            {
                list_ASYMMETRY.Add(nester);

                continue;
            }

            foreach (SNNester nester in list_CHILD)
            {
                list_ASYMMETRY.Add(nester);

                continue;
            }

            return;
        }
    }
}
