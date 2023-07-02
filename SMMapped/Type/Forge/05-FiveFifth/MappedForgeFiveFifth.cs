using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void ForgeMappedFiveFifth
(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER, 
List<SRResolve> list_RESOLVE,
Boolean debug
)
        {
            SMMappedForge.Remote(nameof(ForgeMappedFiveFifth), map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            foreach (SRResolved resolved_PARENT in list_RESOLVED)
            {
                var list_RESOLVED__CHILD = new List<SRResolved>();

                foreach (SRResolved resolved_CHILD in resolved_PARENT.ResolvedChildList)
                {
                    foreach (SRResolved resolved_REBASE in list_RESOLVED)
                    {
                        var safe_ONE__FIRST = true;

                        safe_ONE__FIRST = safe_ONE__FIRST && (resolved_CHILD.StartIndex == resolved_REBASE.StartIndex) is true;

                        safe_ONE__FIRST = safe_ONE__FIRST && (resolved_CHILD.EndIndex == resolved_REBASE.EndIndex) is true;

                        if (safe_ONE__FIRST is false)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        list_RESOLVED__CHILD.Add(resolved_REBASE);

                        break;
                    }

                    continue;
                }

                resolved_PARENT.ResolvedChildList = list_RESOLVED__CHILD;

                continue;
            }

            return;
        }
    }
}
