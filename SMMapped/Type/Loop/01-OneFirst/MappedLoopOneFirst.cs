using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedOneFirst(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
Boolean debug
            )
        {
            SMMapped mappedResult = default;

            Debug_MappedTraverseOuter(
                owner: nameof(LoopMappedOneFirst),
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                debug: debug
                );

            foreach (SNNester nester in map.NesterList)
            {
                var resolved = SRResolved.Runtime_MakeResolvedNew(nester);

                list_RESOLVED.Add(resolved);

                continue;
            }

            mappedResult = LoopMappedTwoSecond(
                map: map,
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                debug: debug
                );

            return mappedResult;
        }
    }
}
