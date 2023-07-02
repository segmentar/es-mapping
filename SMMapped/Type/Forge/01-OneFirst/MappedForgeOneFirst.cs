using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void ForgeMappedOneFirst
(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
List<SRResolve> list_RESOLVE,
Boolean debug
)
        {
            SMMappedForge.Remote(nameof(ForgeMappedOneFirst), map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            foreach (SNNester nester in map.AsymmetryList)
            {
                var resolved = SRResolved.Runtime_MakeResolvedNew(nester);

                list_RESOLVED.Add(resolved);

                continue;
            }

            return;
        }
    }
}
