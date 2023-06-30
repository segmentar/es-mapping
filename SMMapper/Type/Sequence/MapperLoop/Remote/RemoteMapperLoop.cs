using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapperLoop
    {
        public static void Remote
(
String owner,
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
            var safe_match__ONE_FIRST = (owner == nameof(SMMapper.LoopMapperTenTenth)) is true;

            if (safe_match__ONE_FIRST)
            {
                SATracker.MapperRecurseNumber = SATracker.MapperRecurseNumber + 1;
            }
            else
            {
                SATracker.MapperTraverseNumber = SATracker.MapperTraverseNumber + 1;
            }

            if (safe_match__ONE_FIRST is true)
            {
                SATracker.MapperTraverseNumber = 0;
            }
            else
                "false".ToString();

            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = new SMMapper(
                        symbolLeft: symbol_LEFT,
                        symbolRight: symbol_RIGHT,
                        delimiterLeft: delimiter_LEFT,
                        delimiterRight: delimiter_RIGHT,
                        staticText: text_STATIC,
                        dynamicText: text_DYNAMIC,
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

                    var tracker = String.Empty;

                    tracker = tracker + message;

                    tracker = tracker + '\n';
                
                    tracker = tracker + String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SMMapper) + ' ' + "::" + ' ' + nameof(SATracker) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(owner) + ':' + ' ' + $"[{owner}]",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(SATracker.MapperRecurseNumber) + ':' + ' ' + SATracker.MapperRecurseNumber,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(SATracker.MapperTraverseNumber) + ':' + ' ' + SATracker.MapperTraverseNumber,
                        String.Empty + '}'
                    });

                    SLLogger.Runtime_MakeLoggerNew(tracker);
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
