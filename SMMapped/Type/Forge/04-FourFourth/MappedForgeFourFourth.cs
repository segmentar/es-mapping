using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static void ForgeMappedFourFourth
(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
List<SRResolve> list_RESOLVE,
Boolean debug
)
        {
            SMMappedForge.Remote(nameof(ForgeMappedFourFourth), map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            foreach (SRResolved resolved_CHILD in list_RESOLVED)
            {
                foreach (SRResolved resolved_PARENT in list_RESOLVED)
                {
                    var safe_ONE__FIRST = true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (resolved_CHILD.ResolvedParent == default) is false;

                    safe_ONE__FIRST = safe_ONE__FIRST && (resolved_CHILD.ResolvedParent.StartIndex == resolved_PARENT.StartIndex) is true;

                    safe_ONE__FIRST = safe_ONE__FIRST && (resolved_CHILD.ResolvedParent.EndIndex == resolved_PARENT.EndIndex) is true;

                    if (safe_ONE__FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    resolved_CHILD.ResolvedParent = resolved_PARENT;

                    continue;
                }

                continue;
            }

            return;
        }
    }
}
