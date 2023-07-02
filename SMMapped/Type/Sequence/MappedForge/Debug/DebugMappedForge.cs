using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMappedForge
    {
        public static void Debug(String extend, SMMap map, List<SRResolved> list_RESOLVED, List<SRResolver> list_RESOLVER, List<SRResolve> list_RESOLVE, Boolean debug)
        {
            SATracker.MappedMajorNumber = 1;

            SATracker.MappedMinorNumber = 1;

            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SMMapped) + ' ' + "::" + ' ' + nameof(SMMappedForge) + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(map) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(list_RESOLVED) + ':' + ' ' + ". . ." + ' ' + $"[{list_RESOLVED.Count}]",
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(list_RESOLVER) + ':' + ' ' + ". . ." + ' ' + $"[{list_RESOLVER.Count}]",
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(list_RESOLVE) + ':' + ' ' + ". . ." + ' ' + $"[{list_RESOLVE.Count}]",
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(map) + ':',
                        String.Empty + map,
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(list_RESOLVED) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_RESOLVED),
                        String.Empty,
                        String.Empty + '~' + "30" + ' ' + nameof(list_RESOLVER) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_RESOLVER),
                        String.Empty,
                        String.Empty + '~' + "40" + ' ' + nameof(list_RESOLVE) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_RESOLVE),
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
