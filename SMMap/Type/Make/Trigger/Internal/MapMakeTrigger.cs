using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMap
    {
        public static SMMap MakeMapTrigger(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            SMMap mapResult = default;

            var mapper = SMMapper.Runtime_MakeMapperNew(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC);

            var list_NEST = new List<SNNest>();

            var list_LONE = new List<SNNester>();

            var list_CHILD = new List<SNNester>();

            var list_PARENT = new List<SNNester>();

            var list_DYNAMIC = new List<SNNester>();

            var list_ASYMMETRY = new List<SNNester>();

            var stack_NESTER__STATIC = new Stack<SNNester>();

            var stack_NESTER__CHAIN = new Stack<SNNester>();

            var text_TEMPLATE_STATIC = new SGText(text_STATIC, false, true);

            var text_TEMPLATE_DYNAMIC = new SGText(text_STATIC, false, true);

            var map = new SMMapSequence(
                mapper.NesterSymmetryList,
                mapper.NesterSymmetryList.GetEnumerator(),
                text_TEMPLATE_STATIC,
                text_TEMPLATE_DYNAMIC,
                symbol_LEFT,
                symbol_RIGHT,
                delimiter_LEFT,
                delimiter_RIGHT,
                list_NEST,
                list_LONE,
                list_CHILD,
                list_PARENT,
                list_DYNAMIC,
                list_ASYMMETRY,
                stack_NESTER__STATIC,
                stack_NESTER__CHAIN,
                debug
                ).Map;

            mapResult = map;

            return mapResult;
        }
    }
}
