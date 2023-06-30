using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct SMMapperDataExecute
    {
        public List<SNNester> LoneList;

        public List<SNNester> ChainList;

        public List<SNNester> ChildList;

        public List<SNNester> ParentList;

        public List<SNNester> NesterStaticList;

        public List<SNNester> NesterDynamicList;

        public List<SNNest> nestList;
    }
}
