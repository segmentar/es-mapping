using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMap
    {
        public SMMap(List<SNNester> originList, List<SNNester> loneList, List<SNNester> childList, List<SNNester> parentList, List<SNNester> nesterList, List<SNNest> nestList, Boolean debug)
        {
            this.OriginList = originList;

            this.LoneList = loneList;

            this.ChildList = childList;

            this.ParentList = parentList;

            this.NesterList = nesterList;

            this.NestList = nestList;

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
