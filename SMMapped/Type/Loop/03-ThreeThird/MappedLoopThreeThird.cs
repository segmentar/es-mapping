using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedThreeThird(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
Boolean debug
            )
        {
            SMMapped mappedResult = default;

            Debug_MappedTraverseOuter(
                owner: nameof(LoopMappedThreeThird),
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                debug: debug
                );

            foreach (SRResolved resolved in list_RESOLVED)
            {
                var list_RESOLVED__CHILD = new List<SRResolved>();

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

                    safe_match__ONE_FIRST = safe_match__ONE_FIRST && (resolved.StartIndex == current.Parent.Left.Position) is true;

                    safe_match__ONE_FIRST = safe_match__ONE_FIRST && (resolved.EndIndex == current.Parent.Right.Position) is true;

                    if (safe_match__ONE_FIRST is false)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var resolved_CHILD = SRResolved.Runtime_MakeResolvedNew(current.Child);

                    list_RESOLVED__CHILD.Add(resolved_CHILD);

                    continue;

                } while (true);

                resolved.ResolvedChildList = list_RESOLVED__CHILD;

                continue;
            }

            mappedResult = LoopMappedFourFourth(
                map: map,
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                debug: debug
                );

            return mappedResult;
        }
    }
}
