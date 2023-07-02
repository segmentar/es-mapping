using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMappedForge
    {
        public SMMapped Mapped = default;

        public SMMappedForge(SMMap map, List<SRResolved> list_RESOLVED, List<SRResolver> list_RESOLVER, List<SRResolve> list_RESOLVE, Boolean debug)
        {
            Debug(String.Empty, map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            SMMapped.ForgeMappedOneFirst(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            SMMapped.ForgeMappedTwoSecond(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            SMMapped.ForgeMappedThreeThird(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            SMMapped.ForgeMappedFourFourth(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            SMMapped.ForgeMappedFiveFifth(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            SMMapped.ForgeMappedSixSixth(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug);

            var mapped = new SMMappedLoop(map, list_RESOLVED, list_RESOLVER, list_RESOLVE, debug).Mapped;

            this.Mapped = mapped;

            return;
        }

        ~SMMappedForge()
        {
            return;
        }
    }
}
