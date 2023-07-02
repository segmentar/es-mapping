using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void LoopMappedOneFirst
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
            SMMappedLoop.Remote(nameof(LoopMappedOneFirst), resolved_CURRENT, position, division, origin, layer, bind, debug);

            /*if (enumerator.MoveNext() is false)
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
            }(*/

            return;
        }
    }
}
