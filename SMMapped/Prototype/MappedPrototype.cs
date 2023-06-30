using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public SMMapped(List<SRResolved> resolvedList, List<SRResolver> resolverList, Boolean debug)
        {
            this.ResolvedList = resolvedList;

            this.ResolverList = resolverList;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
