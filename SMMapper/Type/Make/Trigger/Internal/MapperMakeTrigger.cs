using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapper
    {
        public static SMMapper MakeMapperTrigger(SGSymbol symbol_LEFT, SGSymbol symbol_RIGHT, SGDelimiter delimiter_LEFT, SGDelimiter delimiter_RIGHT, SGText text_STATIC, Boolean debug)
        {
            SMMapper mapperResult = default;

            var text_STATIC__TEMPLATE = new SGText(text_STATIC, false, true);

            var text_DYNAMIC__TEMPLATE = new SGText(text_STATIC, false, true);

            var list_ORIGIN = new List<SNNester>(SNNester.NesterOriginSet(symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, text_STATIC__TEMPLATE, text_DYNAMIC__TEMPLATE));

            var list_LONE = new List<SNNester>();

            var list_CHAIN = new List<SNNester>();

            var list_CHILD = new List<SNNester>();

            var list_PARENT = new List<SNNester>();

            var list_NESTER__STATIC = new List<SNNester>();

            var list_NESTER__DYNAMIC = new List<SNNester>();

            var list_NEST = new List<SNNest>();

            var queue_CHILD = new Queue<SNNester>();

            var queue_PARENT = new Queue<SNNester>();

            var queue_CHILD__FURTHER = new Queue<SNNester>();

            var queue_PARENT__FURTHER = new Queue<SNNester>();

            SATracker.MapperRecurseNumber = 1;

            SATracker.MapperTraverseNumber = 0;

            var mapper = new SMMapperLoop(
                text_STATIC,
                text_STATIC,
                symbol_LEFT,
                symbol_RIGHT,
                delimiter_LEFT,
                delimiter_RIGHT,
                list_ORIGIN,
                list_LONE,
                list_CHAIN,
                list_CHILD,
                list_PARENT,
                list_NESTER__STATIC,
                list_NESTER__DYNAMIC,
                list_NEST,
                queue_CHILD,
                queue_PARENT,
                queue_CHILD__FURTHER,
                queue_PARENT__FURTHER,
                debug
                ).Mapper;

            mapperResult = mapper;

            return mapperResult;
        }
    }
}
