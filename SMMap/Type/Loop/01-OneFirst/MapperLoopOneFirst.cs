using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMap
    {
        public static void LoopMapperOneFirst
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
            do
            {
                if (enumerator.MoveNext() is false)
                {
                    break;
                }
                else
                    "false".ToString();

                var current = enumerator.Current;

                SMMapSequence.Remote(
                    owner: nameof(LoopMapperOneFirst),
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

                list_DYNAMIC.Add(current);

                foreach (SNNester nester in new List<SNNester>(list_DYNAMIC))
                {
                    var safe_ONE__FIRST_contagious = true;

                    safe_ONE__FIRST_contagious = safe_ONE__FIRST_contagious && (stack_NESTER__STATIC.Count > 0) is true;

                    safe_ONE__FIRST_contagious = safe_ONE__FIRST_contagious && (stack_NESTER__STATIC.Peek() == default) is false;

                    safe_ONE__FIRST_contagious = safe_ONE__FIRST_contagious && (stack_NESTER__STATIC.Peek() == nester) is false;

                    if (safe_ONE__FIRST_contagious is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var difference = (nester.LayerMinimum - stack_NESTER__STATIC.Peek().LayerMinimum);

                    safe_ONE__FIRST_contagious = safe_ONE__FIRST_contagious && (difference == 0) is false;

                    safe_ONE__FIRST_contagious = safe_ONE__FIRST_contagious && (stack_NESTER__STATIC.Peek().Left.Position < nester.Left.Position) is true;

                    safe_ONE__FIRST_contagious = safe_ONE__FIRST_contagious && (stack_NESTER__STATIC.Peek().Right.Position > nester.Right.Position) is true;

                    if (safe_ONE__FIRST_contagious is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    list_DYNAMIC.Remove(nester);

                    var list_CHAIN__COLLAPSE = new List<SNNester>(stack_NESTER__CHAIN);

                    stack_NESTER__CHAIN.Clear();

                    var nest = SNNest.Runtime_MakeNestNew(stack_NESTER__STATIC.Peek(), nester, list_CHAIN__COLLAPSE);

                    list_NEST.Add(nest);

                    continue;
                }

                stack_NESTER__STATIC.Push(current);

                continue;

            } while (true);

            return;
        }
    }
}
