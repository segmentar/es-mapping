using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapSequence
    {
        public static void Debug
(
String extend,
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
            SATracker.MapMajorNumber = 1;

            SATracker.MapMinorNumber = 0;

            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SMMap) + ' ' + "::" + ' ' + nameof(SMMapSequence) + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(enumerable) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(enumerator) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(text_STATIC) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(text_DYNAMIC) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(symbol_LEFT) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(symbol_RIGHT) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "07" + ' ' + nameof(delimiter_LEFT) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "08" + ' ' + nameof(delimiter_RIGHT) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "09" + ' ' + nameof(list_NEST) + ':' + ' ' + ". . ." + ' ' + $"[{list_NEST.Count}]",
                        String.Empty + '\t' + '~' + "10" + ' ' + nameof(list_LONE) + ':' + ' ' + ". . ." + ' ' + $"[{list_LONE.Count}]",
                        String.Empty + '\t' + '~' + "11" + ' ' + nameof(list_CHILD) + ':' + ' ' + ". . ." + ' ' + $"[{list_CHILD.Count}]",
                        String.Empty + '\t' + '~' + "12" + ' ' + nameof(list_PARENT) + ':' + ' ' + ". . ." + ' ' + $"[{list_PARENT.Count}]",
                        String.Empty + '\t' + '~' + "13" + ' ' + nameof(list_DYNAMIC) + ':' + ' ' + ". . ." + ' ' + $"[{list_DYNAMIC.Count}]",
                        String.Empty + '\t' + '~' + "14" + ' ' + nameof(list_ASYMMETRY) + ':' + ' ' + ". . ." + ' ' + $"[{list_ASYMMETRY.Count}]", 
                        String.Empty + '\t' + '~' + "15" + ' ' + nameof(stack_NESTER__STATIC) + ':' + ' ' + ". . ." + ' ' + $"[{stack_NESTER__STATIC.Count}]",
                        String.Empty + '\t' + '~' + "16" + ' ' + nameof(stack_NESTER__CHAIN) + ':' + ' ' + ". . ." + ' ' + $"[{stack_NESTER__CHAIN.Count}]",
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(enumerable) + ':',
                        String.Empty + String.Join('\n'.ToString(), enumerable),
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(enumerator) + ':',
                        String.Empty + String.Join('\n'.ToString(), enumerator),
                        String.Empty,
                        String.Empty + '~' + "30" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(list_NEST) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_NEST),
                        String.Empty,
                        String.Empty + '~' + "40" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(list_LONE) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_LONE),
                        String.Empty,
                        String.Empty + '~' + "50" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(list_CHILD) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_CHILD),
                        String.Empty,
                        String.Empty + '~' + "60" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(list_PARENT) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_PARENT),
                        String.Empty,
                        String.Empty + '~' + "70" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(list_DYNAMIC) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_DYNAMIC),
                        String.Empty,
                        String.Empty + '~' + "80" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(list_ASYMMETRY) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_ASYMMETRY),
                        String.Empty,
                        String.Empty + '~' + "90" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(stack_NESTER__STATIC) + ':',
                        String.Empty + String.Join('\n'.ToString(), stack_NESTER__STATIC),
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(stack_NESTER__CHAIN) + ':',
                        String.Empty + String.Join('\n'.ToString(), stack_NESTER__CHAIN),
                        String.Empty,
                        String.Empty + extend
                    });

                    SLLogger.Runtime_MakeLoggerNew(message);
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
