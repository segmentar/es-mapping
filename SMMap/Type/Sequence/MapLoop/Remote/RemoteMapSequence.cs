using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapSequence
    {
        public static void Remote
(
String owner,
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
            var safe_match__ONE_FIRST = (owner == nameof(SMMap.LoopMapperTwoSecond)) is true;

            if (safe_match__ONE_FIRST)
            {
                SATracker.MapMajorNumber = SATracker.MapMajorNumber + 1;
            }
            else
            {
                SATracker.MapMinorNumber = SATracker.MapMinorNumber + 1;
            }

            if (safe_match__ONE_FIRST is true)
            {
                SATracker.MapMinorNumber = 0;
            }
            else
                "false".ToString();

            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SMMap) + ' ' + "::" + ' ' + nameof(SATracker) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(owner) + ':' + ' ' + $"[{owner}]",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(SATracker.MapMajorNumber) + ':' + ' ' + SATracker.MapMajorNumber,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(SATracker.MapMinorNumber) + ':' + ' ' + SATracker.MapMinorNumber,
                        String.Empty + '}'
                    });

                    Debug(
                        extend: message,
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
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
