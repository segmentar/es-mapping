using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapper
    {
        public SMMapper
(
SGText staticText,
SGText dynamicText,
SGSymbol symbolLeft,
SGSymbol symbolRight,
SGDelimiter delimiterLeft,
SGDelimiter delimiterRight,
List<SNNester> originList,
List<SNNester> loneList,
List<SNNester> chainList,
List<SNNester> childList,
List<SNNester> parentList,
List<SNNester> nesterStaticList,
List<SNNester> nesterDynamicList,
List<SNNest> nestList,
Queue<SNNester> childNester,
Queue<SNNester> parentNester,
Queue<SNNester> childFurtherNester,
Queue<SNNester> parentFurtherNester,
Boolean debug
)
        {
            this.StaticText = staticText;

            this.DynamicText = dynamicText;

            this.OriginList = originList;

            SMMapperDataStatic mapperDataStatic = new SMMapperDataStatic();

            mapperDataStatic.SymbolLeft = symbolLeft;
            
            mapperDataStatic.SymbolRight = symbolRight;

            mapperDataStatic.DelimiterLeft = delimiterLeft;

            mapperDataStatic.DelimiterRight = delimiterRight;

            SMMapperDataExecute mapperDataExecute = new SMMapperDataExecute();

            mapperDataExecute.LoneList = loneList;

            mapperDataExecute.ChainList = chainList;

            mapperDataExecute.ChildList = childList;

            mapperDataExecute.ParentList = parentList;

            mapperDataExecute.NesterStaticList = nesterStaticList;

            mapperDataExecute.NesterDynamicList = nesterDynamicList;

            mapperDataExecute.nestList = nestList;

            SMMapperDataDynamic mapperDataDynamic = new SMMapperDataDynamic();

            mapperDataDynamic.ChildNesterQueue = childNester;

            mapperDataDynamic.ChildFurtherNesterQueue = childFurtherNester;

            mapperDataDynamic.ParentNesterQueue = parentNester;

            mapperDataDynamic.ParentFurtherNesterQueue = parentFurtherNester;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            this.Dynamic = mapperDataDynamic;

            this.Execute = mapperDataExecute;

            this.Static = mapperDataStatic;

            return;
        }
    }
}
