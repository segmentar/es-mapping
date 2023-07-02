using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMap
    {
        public List<SNNest> NestList;

        public List<SNNester> LoneList;

        public List<SNNester> ChildList;

        public List<SNNester> ParentList;

        public List<SNNester> DynamicList;

        public List<SNNester> AsymmetryList;
    }
}
