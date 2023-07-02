using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void LoopMappedFiveFifth
(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
List<SRResolve> list_RESOLVE,
SRResolved resolved_CURRENT,
ref Int32 position,
ref Int32 division,
ref Int32 origin,
ref Int32 layer,
ref String bind,
Boolean debug
)
        {
            SMMappedLoop.Remote(nameof(LoopMappedFiveFifth), resolved_CURRENT, position, division, origin, layer, bind, debug);

            var split = resolved_CURRENT.Middle.Value.Split(new String[] { SASyntax.NameColonDouble }, StringSplitOptions.RemoveEmptyEntries);

            var safe_ONE__FIRST = (split.Length > 0) is true;

            if (safe_ONE__FIRST is true)
            {
                var first = split[0];

                bind = first;
            }
            else
                "false".ToString();

            return;
        }
    }
}
