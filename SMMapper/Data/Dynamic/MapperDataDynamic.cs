using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct SMMapperDataDynamic
    {
        public Queue<SNNester> ChildNesterQueue;

        public Queue<SNNester> ParentNesterQueue;

        public Queue<SNNester> ChildFurtherNesterQueue;

        public Queue<SNNester> ParentFurtherNesterQueue;
    }
}
