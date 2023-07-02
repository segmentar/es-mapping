using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void LoopMappedFourFourth
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
            SMMappedLoop.Remote(nameof(LoopMappedFourFourth), resolved_CURRENT, position, division, origin, layer, bind, debug);

            var safe_ONE__FIRST = (resolved_CURRENT.ResolvedParent == default) is false;

            var indexer_TWO__SECOND = 0;

            foreach (SRResolved resolved_ORIGIN in list_RESOLVED)
            {
                var safe_TWO__SECOND = true;

                safe_ONE__FIRST = safe_ONE__FIRST && (resolved_ORIGIN.LayerNumber == 1) is true;

                if (safe_TWO__SECOND is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                indexer_TWO__SECOND = indexer_TWO__SECOND + 1;

                safe_ONE__FIRST = safe_ONE__FIRST && (resolved_ORIGIN.StartIndex < resolved_CURRENT.StartIndex) is true;

                safe_ONE__FIRST = safe_ONE__FIRST && (resolved_ORIGIN.EndIndex > resolved_CURRENT.EndIndex) is true;

                if (safe_TWO__SECOND is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                origin = indexer_TWO__SECOND;

                break;
            }

            return;
        }
    }
}
