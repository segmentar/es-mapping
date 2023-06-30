using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedSevenSeventh(
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
                nameof(LoopMappedSevenSeventh),
                enumerator,
                position,
                division,
                origin,
                layer,
                bind,
                debug
                );

            if (enumerator.MoveNext() is false)
            {
                var list_ISOLATE = SRResolver.ResolverIsolateSet(1, list_RESOLVER);

                var list_SORT = SRResolver.ResolverSortSet(list_ISOLATE);

                list_RESOLVER = new List<SRResolver>(list_SORT);

                mappedResult = new SMMapped(
                    list_RESOLVED,
                    list_RESOLVER,
                    debug
                    );

                return mappedResult;
            }
            else
            {
                SRResolved.TraverseSort(enumerator.Current);
            }

            mappedResult = LoopMappedEightEighth(
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
