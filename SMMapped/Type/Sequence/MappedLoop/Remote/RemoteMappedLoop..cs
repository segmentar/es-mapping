using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMappedLoop
    {
        public static void Remote
(
String owner,
SRResolved resolved,
Int32 position,
Int32 division,
Int32 origin,
Int32 layer,
String bind,
Boolean debug
)
        {
            SATracker.MappedMinorNumber = SATracker.MappedMinorNumber + 1;

            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SMMapped) + ' ' + "::" + ' ' + nameof(SMMappedLoop) + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(resolved) + ':' + ' ' + ". . ." + ' ' + $"[{resolved == default}]",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(position) + ':' + ' ' + ". . ." + ' ' + position,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(division) + ':' + ' ' + ". . ." + ' ' + division,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(origin) + ':' + ' ' + ". . ." + ' ' + origin,
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(layer) + ':' + ' ' + layer,
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(bind) + ':' + ' ' + $"[{bind}]",
                        String.Empty + '\t' + '~' + "07" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(resolved) + ':',
                        String.Empty + resolved
                    });

                    var tracker = String.Empty;

                    tracker = tracker + message;

                    tracker = tracker + '\n';

                    tracker = tracker + String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SMMapped) + ' ' + "::" + ' ' + nameof(SATracker) + ' ' + '{',
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(owner) + ':' + ' ' + $"[{owner}]",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(SATracker.MappedMinorNumber) + ':' + ' ' + SATracker.MappedMinorNumber,
                        String.Empty + '}'
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
