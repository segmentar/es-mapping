using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMappedForge
    {
        public static void Remote(String owner, SMMap map, List<SRResolved> list_RESOLVED, List<SRResolver> list_RESOLVER, List<SRResolve> list_RESOLVE, Boolean debug)
        {
            SATracker.MappedMajorNumber = SATracker.MappedMajorNumber + 1;

            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SMMapped) + ' ' + "::" + ' ' + nameof(SATracker) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(owner) + ':' + ' ' + $"[{owner}]",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(SATracker.MappedMajorNumber) + ':' + ' ' + SATracker.MappedMajorNumber,
                        String.Empty + '}'
                    });

                    SMMappedForge.Debug(message, map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
