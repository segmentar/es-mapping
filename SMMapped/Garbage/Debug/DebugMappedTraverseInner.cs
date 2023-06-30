using Core;

namespace Core.Shared
{
    using System;

    using System.Collections.Generic;

    public partial class SMMapped
    {
        public static void Debug_MappedTraverseInner(
            String owner,
            IEnumerator<SRResolved> enumerator,
            Int32 position,
            Int32 division,
            Int32 origin,
            Int32 layer,
            String bind,
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
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(enumerator) + ':' + ' ' + ". . ." + ' ' + $"[{enumerator.Current == default}]",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(position) + ':' + ' ' + ". . ." + ' ' + position,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(division) + ':' + ' ' + ". . ." + ' ' + division,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(origin) + ':' + ' ' + ". . ." + ' ' + origin,
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(layer) + ':' + ' ' + layer,
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(bind) + ':' + ' ' + $"[{bind}]",
                        String.Empty + '\t' + '~' + "07" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(enumerator) + ':',
                        String.Empty + enumerator.Current
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
