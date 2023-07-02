using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void ForgeMappedThreeThird
(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER, 
List<SRResolve> list_RESOLVE,
Boolean debug
)
        {
            SMMappedForge.Remote(nameof(ForgeMappedThreeThird), map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            foreach (SRResolved resolved in list_RESOLVED)
            {
                var list_RESOLVED__CHILD = new List<SRResolved>();

                foreach (SNNest nest in map.NestList)
                {
                    var safe_match__ONE_FIRST = true;

                    safe_match__ONE_FIRST = safe_match__ONE_FIRST && (resolved.StartIndex == nest.Parent.Left.Position) is true;

                    safe_match__ONE_FIRST = safe_match__ONE_FIRST && (resolved.EndIndex == nest.Parent.Right.Position) is true;

                    if (safe_match__ONE_FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var resolved_CHILD = SRResolved.Runtime_MakeResolvedNew(nest.Child);

                    list_RESOLVED__CHILD.Add(resolved_CHILD);

                    continue;
                }

                resolved.ResolvedChildList = list_RESOLVED__CHILD;

                continue;
            }

            return;
        }
    }
}
