using Core;

namespace Core.Shared
{
    using System;

    public partial struct SMMapperDataExecute
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SMMapper) + ' ' + "::" + ' ' + nameof(SMMapperDataStatic) + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(LoneList) + ':' + ' ' + ". . ." + ' ' + $"[{LoneList.Count}]",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ChainList) + ':' + ' ' + ". . ." + ' ' + $"[{ChainList.Count}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ChildList) + ':' + ' ' + ". . ." + ' ' + $"[{ChildList.Count}]",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ParentList) + ':' + ' ' + ". . ." + ' ' + $"[{ParentList.Count}]",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(NesterStaticList) + ':' + ' ' + ". . ." + ' ' + $"[{NesterStaticList.Count}]",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(NesterDynamicList) + ':' + ' ' + ". . ." + ' ' + $"[{NesterDynamicList.Count}]",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(nestList) + ':' + ' ' + ". . ." + ' ' + $"[{nestList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(LoneList) + ':',
                String.Empty + String.Join('\n'.ToString(), LoneList),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ChainList) + ':',
                String.Empty + String.Join('\n'.ToString(), ChainList),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ChildList) + ':',
                String.Empty + String.Join('\n'.ToString(), ChildList),
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(ParentList) + ':',
                String.Empty + String.Join('\n'.ToString(), ParentList),
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(NesterStaticList) + ':',
                String.Empty + String.Join('\n'.ToString(), NesterStaticList),
                String.Empty,
                String.Empty + '~' + "60" + ' ' + nameof(NesterDynamicList) + ':',
                String.Empty + String.Join('\n'.ToString(), NesterDynamicList),
                String.Empty,
                String.Empty + '~' + "70" + ' ' + nameof(nestList) + ':',
                String.Empty + String.Join('\n'.ToString(), nestList)
            });
        }
    }
}
