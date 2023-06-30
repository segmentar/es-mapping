using Core;

namespace Core.Shared
{
    using System;

    using System.Collections.Generic;

    public partial class SMMapped
    {
        public static void Debug_MappedTraverseOuter(
            String owner,
            List<SRResolved> list_RESOLVED,
            List<SRResolver> list_RESOLVER,
            Boolean debug
            )
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(SMMapped) + ' ' + "::" + ' ' + owner + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(list_RESOLVED) + ':' + ' ' + ". . ." + ' ' + $"[{list_RESOLVED.Count}]",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(list_RESOLVER) + ':' + ' ' + ". . ." + ' ' + $"[{list_RESOLVED.Count}]",
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(list_RESOLVED) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_RESOLVED),
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(list_RESOLVER) + ':',
                        String.Empty + String.Join('\n'.ToString(), list_RESOLVER),
                    });

                    Console.Clear();

                    Console.Out.WriteLine(message);

                    Console.ReadKey();
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
