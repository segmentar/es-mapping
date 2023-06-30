using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedElevenEleventh(
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
                nameof(LoopMappedElevenEleventh),
                enumerator,
                position,
                division,
                origin,
                layer,
                bind,
                debug
                );

            bind = SAConstant.ResolveBindUnsuccess;

            var split = enumerator.Current.Symbol.Value.Split(new String[] { SASyntax.NameColonDouble }, StringSplitOptions.RemoveEmptyEntries);

            var safe_ONE__FIRST = (split.Length > 0) is true;

            if (safe_ONE__FIRST is true)
            {
                var first = split[0];

                bind = first;
            }
            else
                "false".ToString();

            mappedResult = LoopMappedTwelveTwelfth(
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
