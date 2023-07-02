using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapperSequence
    {
        public SMMapper Mapper = default;

        public SMMapperSequence(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            Debug(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC, debug);

            var text_STATIC__TEMPLATE = new SGText(text_STATIC, false, true);

            var text_DYNAMIC_LEFT__TEMPLATE = new SGText(text_STATIC, false, true);

            var text_DYNAMIC_RIGHT__TEMPLATE = new SGText(text_STATIC, false, true);

            var list_SYMMETRY = new List<SNNester>(SNNester.NesterSymmetrySet(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC__TEMPLATE, text_DYNAMIC_LEFT__TEMPLATE, text_DYNAMIC_RIGHT__TEMPLATE));

            this.Mapper = new SMMapper(list_SYMMETRY, debug);

            return;
        }

        ~SMMapperSequence()
        {
            return;
        }
    }
}
