using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMap
    {
        public SMMap
(
List<SNNest> nestList,
List<SNNester> loneList,
List<SNNester> childList,
List<SNNester> parentList,
List<SNNester> dynamicList,
List<SNNester> asymmetryList,
Boolean debug
)
        {
            this.NestList = nestList;

            this.LoneList = loneList;

            this.ChildList = childList;

            this.ParentList = parentList;

            this.DynamicList = dynamicList;

            this.AsymmetryList = asymmetryList;

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
