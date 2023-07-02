using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void ForgeMappedSixSixth
(
SMMap map, 
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER, 
List<SRResolve> list_RESOLVE, 
Boolean debug
)
        {
            SMMappedForge.Remote(nameof(ForgeMappedSixSixth), map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            /*var enumerator = list_RESOLVED.GetEnumerator();

            var position = default(Int32);

            var division = default(Int32);

            var origin = default(Int32);

            var layer = default(Int32);

            var bind = default(String);

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
                );*/

            return;
        }
    }
}
