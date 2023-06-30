using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMap
    {
        public static SMMap MakeMapNew(SMMappingInformation information, SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            SMMap mapResult = default;

            var mapper = SMMapper.Runtime_MakeMapperNew(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC);

            information.Mapper = mapper;

            mapResult = new SMMap(
                mapper.OriginList,
                mapper.Execute.LoneList, 
                mapper.Execute.ChildList,
                mapper.Execute.ParentList,
                mapper.Execute.NesterStaticList,
                mapper.Execute.nestList,
                debug
                );

            return mapResult;
        }
    }
}
