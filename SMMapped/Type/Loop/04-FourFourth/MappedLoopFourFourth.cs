using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedFourFourth(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
Boolean debug
            )
        {
            SMMapped mappedResult = default;

            Debug_MappedTraverseOuter(
                owner: nameof(LoopMappedFourFourth),
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                debug: debug
                );

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

            mappedResult = LoopMappedFiveFifth(
                map: map,
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                debug: debug
                );

            return mappedResult;
        }
    }
}
