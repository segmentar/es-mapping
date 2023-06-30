using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedEightEighth(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
IEnumerator<SRResolved> enumerator,
Int32 position,
Int32 division,
Int32 origin,
Int32 layer,
String bind,
Boolean debug
            )
        {
            SMMapped mappedResult = default;

            Debug_MappedTraverseInner(
                nameof(LoopMappedEightEighth),
                enumerator,
                position,
                division,
                origin,
                layer,
                bind,
                debug
                );

            position = SAConstant.ResolvePositionUnsuccess;

            var safe_ONE__FIRST = (enumerator.Current.ResolvedParent == default) is false;

            if (safe_ONE__FIRST)
            {
                position = enumerator.Current.ResolvedParent.ResolvedChildList.IndexOf(enumerator.Current);

                var position_ALIGN__ENO = position;

                position_ALIGN__ENO = position_ALIGN__ENO + 1;

                position = position_ALIGN__ENO;
            }
            else
            {
                var indxer_ONE__FIRST = 0;

                foreach (SRResolved resolved_ORIGIN in SRResolved.ResolvedSortSet(list_RESOLVED))
                {
                    var safe_TWO__SECOND = true;

                    safe_TWO__SECOND = safe_TWO__SECOND && (resolved_ORIGIN.LayerNumber == 1) is true;

                    if (safe_TWO__SECOND is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    indxer_ONE__FIRST = indxer_ONE__FIRST + 1;

                    safe_TWO__SECOND = safe_TWO__SECOND && (resolved_ORIGIN == enumerator.Current) is true;

                    if (safe_TWO__SECOND is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    position = indxer_ONE__FIRST;

                    break;
                }
            }

            mappedResult = LoopMappedNineNinth(
                map: map,
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                enumerator: enumerator,
                position: position,
                division: division,
                origin: origin,
                layer: layer,
                bind: bind,
                debug: debug
                );

            return mappedResult;
        }
    }
}
