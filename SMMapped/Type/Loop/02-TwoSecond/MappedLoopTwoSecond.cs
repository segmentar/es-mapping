using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedTwoSecond(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
Boolean debug
            )
        {
            SMMapped mappedResult = default;

            Debug_MappedTraverseOuter(
                owner: nameof(LoopMappedTwoSecond),
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                debug: debug
                );

            foreach (SRResolved resolved in list_RESOLVED)
            {
                var enumerator = map.NestList.GetEnumerator();

                do
                {
                    if (enumerator.MoveNext() is false)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var current = enumerator.Current;

                    var safe_match__ONE_FIRST = true;

                    safe_match__ONE_FIRST = safe_match__ONE_FIRST && (resolved.StartIndex == current.Child.Left.Position) is true;

                    safe_match__ONE_FIRST = safe_match__ONE_FIRST && (resolved.EndIndex == current.Child.Right.Position) is true;

                    if (safe_match__ONE_FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var resolved_PARENT = SRResolved.Runtime_MakeResolvedNew(current.Parent);

                    resolved.ResolvedParent = resolved_PARENT;

                    continue;

                } while (true);

                continue;
            }

            mappedResult = LoopMappedThreeThird(
                map: map,
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                debug: debug
                );

            return mappedResult;
        }
    }
}
