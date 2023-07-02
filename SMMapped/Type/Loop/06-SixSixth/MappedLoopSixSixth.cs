using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void LoopMappedSixSixth
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
            SMMappedLoop.Remote(nameof(LoopMappedSixSixth), resolved_CURRENT, position, division, origin, layer, bind, debug);

            var resolve = SRResolve.Runtime_MakeResolveNew(resolved_CURRENT, position, division, origin, layer, bind);

            list_RESOLVE.Add(resolve);

            var resolver = SRResolver.Runtime_MakeResolverNew(resolved_CURRENT);

            list_RESOLVER.Add(resolver);

            return;
        }
    }
}
