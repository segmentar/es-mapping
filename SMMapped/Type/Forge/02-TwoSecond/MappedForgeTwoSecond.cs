using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void ForgeMappedTwoSecond
(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
List<SRResolve> list_RESOLVE,
Boolean debug
)
        {
            SMMappedForge.Remote(nameof(ForgeMappedTwoSecond), map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            foreach (SRResolved resolved in list_RESOLVED)
            {
                foreach (SNNest nest in map.NestList)
                {
                    var safe_ONE__FIRST = true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (resolved.StartIndex == nest.Child.Left.Position) is true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (resolved.EndIndex == nest.Child.Right.Position) is true;

                    if (safe_ONE__FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var resolved_PARENT = SRResolved.Runtime_MakeResolvedNew(nest.Parent);

                    resolved.ResolvedParent = resolved_PARENT;

                    continue;
                }

                continue;
            }

            return;
        }
    }
}
