using Core;

namespace Core.Shared
{
    using System;

    public partial struct SMMapperDataDynamic
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SMMapper) + ' ' + "::" + ' ' + nameof(SMMapperDataDynamic) + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ChildNesterQueue) + ':' + ' ' + ". . ." + ' ' + $"[{ChildNesterQueue.Count}]",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ParentNesterQueue) + ':' + ' ' + ". . ." + ' ' + $"[{ParentNesterQueue.Count}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ChildFurtherNesterQueue) + ':' + ' ' + ". . ." + $"[{ChildFurtherNesterQueue.Count}]",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ParentFurtherNesterQueue) + ':' + ' ' + ". . ." + $"[{ParentFurtherNesterQueue.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ChildNesterQueue) + ':',
                String.Empty + String.Join('\n'.ToString(), ChildNesterQueue),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ParentNesterQueue) + ':',
                String.Empty + String.Join('\n'.ToString(), ParentNesterQueue),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ChildFurtherNesterQueue) + ':',
                String.Empty + String.Join('\n'.ToString(), ChildFurtherNesterQueue),
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(ParentFurtherNesterQueue) + ':',
                String.Empty + String.Join('\n'.ToString(), ParentFurtherNesterQueue)
            });
        }
    }
}
