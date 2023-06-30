using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedTenTenth(
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
                nameof(LoopMappedTenTenth),
                enumerator,
                position,
                division,
                origin,
                layer,
                bind,
                debug
                );

            origin = SAConstant.ResolveOriginUnsuccess;

            var safe_ONE__FIRST = (enumerator.Current.ResolvedParent == default) is false;

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

                safe_ONE__FIRST = safe_ONE__FIRST && (resolved_ORIGIN.StartIndex < enumerator.Current.StartIndex) is true;

                safe_ONE__FIRST = safe_ONE__FIRST && (resolved_ORIGIN.EndIndex > enumerator.Current.EndIndex) is true;

                if (safe_TWO__SECOND is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                origin = indexer_TWO__SECOND;

                break;
            }

            mappedResult = LoopMappedElevenEleventh(
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
