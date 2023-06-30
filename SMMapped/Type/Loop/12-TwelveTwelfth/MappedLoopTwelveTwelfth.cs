using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedTwelveTwelfth(
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
                nameof(LoopMappedTwelveTwelfth),
                enumerator,
                position,
                division,
                origin,
                layer,
                bind,
                debug
                );

            layer = SAConstant.ResolveLayerUnsuccess;

            layer = enumerator.Current.LayerNumber;

            var resolve = SRResolve.Runtime_MakeResolveNew(position, division, origin, layer, bind);

            var resolver = SRResolver.Runtime_MakeResolverNew(resolve, enumerator.Current);

            list_RESOLVER.Add(resolver);

            mappedResult = LoopMappedSevenSeventh(
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
