using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapper
    {
        public SMMapper(List<SNNester> nesterSymmetryList, Boolean debug)
        {
            this.NesterSymmetryList = nesterSymmetryList;

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
