using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMappedLoop
    {
        public SMMapped Mapped = default;

        public SMMappedLoop(SMMap map, List<SRResolved> list_RESOLVED, List<SRResolver> list_RESOLVER, List<SRResolve> list_RESOLVE, Boolean debug)
        {
            var enumerator = list_RESOLVED.GetEnumerator();

            do
            {
                if (enumerator.MoveNext() is false)
                {
                    break;
                }
                else
                    "false".ToString();

                var position = SAConstantUnsuccess.ResolvePositionUnsuccess;

                var division = SAConstantUnsuccess.ResolveDivisionUnsuccess;

                var origin = SAConstantUnsuccess.ResolveOriginUnsuccess;

                var layer = SAConstantUnsuccess.ResolveLayerUnsuccess;

                var bind = SAConstantEmpty.ResolveBindEmpty;

                var current = enumerator.Current;

                SMMapped.LoopMappedOneFirst(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, current, ref position, ref division, ref origin, ref layer, ref bind, debug);

                SMMapped.LoopMappedTwoSecond(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, current, ref position, ref division, ref origin, ref layer, ref bind, debug);

                SMMapped.LoopMappedThreeThird(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, current, ref position, ref division, ref origin, ref layer, ref bind, debug);

                SMMapped.LoopMappedFourFourth(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, current, ref position, ref division, ref origin, ref layer, ref bind, debug);

                SMMapped.LoopMappedFiveFifth(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, current, ref position, ref division, ref origin, ref layer, ref bind, debug);

                SMMapped.LoopMappedSixSixth(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, current, ref position, ref division, ref origin, ref layer, ref bind, debug);

                continue;

            } while (true);

            this.Mapped = new SMMapped(list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            return;
        }

        ~SMMappedLoop()
        {
            return;
        }
    }
}
