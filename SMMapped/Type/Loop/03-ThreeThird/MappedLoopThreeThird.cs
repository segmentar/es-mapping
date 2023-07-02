using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void LoopMappedThreeThird
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
            SMMappedLoop.Remote(nameof(LoopMappedThreeThird), resolved_CURRENT, position, division, origin, layer, bind, debug);

            var safe_ONE__FIRST = (resolved_CURRENT.ResolvedParent == default) is false;

            if (safe_ONE__FIRST)
            {
                /*division = resolved_CURRENT.ResolvedParent.ResolvedParent.ResolvedChildList.IndexOf(resolved_CURRENT.ResolvedParent);

                var division_ALIGN__ENO = division;

                division_ALIGN__ENO = division_ALIGN__ENO + 1;

                division = division_ALIGN__ENO;*/
            }
            else
            {
                /*division = 0;// resolved.ResolvedParent.ResolvedChildList.IndexOf(resolved);

                var division_ALIGN__ENO = division;

                division_ALIGN__ENO = division_ALIGN__ENO + 1;

                division = division_ALIGN__ENO;*/
            }

            return;
        }
    }
}
