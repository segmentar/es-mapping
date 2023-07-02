using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void LoopMappedTwoSecond
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
            SMMappedLoop.Remote(nameof(LoopMappedTwoSecond), resolved_CURRENT, position, division, origin, layer, bind, debug);

            var safe_match_ONE__FIRST = (resolved_CURRENT.ResolvedParent == default) is true;

            if (safe_match_ONE__FIRST)
            {
                var indexer = 0;

                foreach (SNNester nester in map.AsymmetryList)
                {
                    indexer = indexer + 1;

                    var safe_ONE__FIRST = true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (nester.Left.Position == resolved_CURRENT.StartIndex) is true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (nester.Right.Position == resolved_CURRENT.EndIndex) is true;

                    if (safe_ONE__FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    position = indexer;

                    break;
                }
            }
            else
            {
                position = resolved_CURRENT.ResolvedParent.ResolvedChildList.IndexOf(resolved_CURRENT);

                goto align_ENO;

                align_ENO:
                {
                    var position_ALIGN__ENO = position;

                    position_ALIGN__ENO = position_ALIGN__ENO + 1;

                    position = position_ALIGN__ENO;
                }
            }

            return;
        }
    }
}
