using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMapped
    {
        public static SMMapped MakeMappedCluster(SMMappingInformation information, SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            SMMapped mappedResult = default;

            mappedResult = MappedClusterTrigger(information, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, debug);

            return mappedResult;
        }
    }
}
    