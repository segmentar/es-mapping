using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapperLoop
    {
        public SMMapper Mapper = default;

        public SMMapperLoop
(
SGText text_STATIC,
SGText text_DYNAMIC,
SGSymbol symbol_LEFT,
SGSymbol symbol_RIGHT,
SGDelimiter delimiter_LEFT,
SGDelimiter delimiter_RIGHT,
List<SNNester> list_ORIGIN,
List<SNNester> list_LONE,
List<SNNester> list_CHAIN,
List<SNNester> list_CHILD,
List<SNNester> list_PARENT,
List<SNNester> list_NESTER__STATIC,
List<SNNester> list_NESTER__DYNAMIC,    
List<SNNest> list_NEST,
Queue<SNNester> queue_CHILD,
Queue<SNNester> queue_PARENT,
Queue<SNNester> queue_CHILD__FURTHER,
Queue<SNNester> queue_PARENT__FURTHER,
Boolean debug
)
        {
            while (((this.Mapper = SMMapper.LoopMapperOneFirst(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug)) == default) is true)
            {
                this.Mapper = SMMapper.LoopMapperTwoSecond(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                this.Mapper = SMMapper.LoopMapperThreeThird(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                this.Mapper = SMMapper.LoopMapperFourFourth(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                this.Mapper = SMMapper.LoopMapperFiveFifth(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                this.Mapper = SMMapper.LoopMapperSixSixth(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                this.Mapper = SMMapper.LoopMapperSevenSeventh(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                this.Mapper = SMMapper.LoopMapperEightEighth(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                this.Mapper = SMMapper.LoopMapperNineNinth(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                this.Mapper = SMMapper.LoopMapperTenTenth(text_STATIC, text_DYNAMIC, symbol_LEFT, symbol_RIGHT, delimiter_LEFT, delimiter_RIGHT, list_ORIGIN, list_LONE, list_CHAIN, list_CHILD, list_PARENT, list_NESTER__STATIC, list_NESTER__DYNAMIC, list_NEST, queue_CHILD, queue_PARENT, queue_CHILD__FURTHER, queue_PARENT__FURTHER, debug);

                continue;
            }

            return;
        }

        ~SMMapperLoop()
        {
            return;
        }
    }
}
