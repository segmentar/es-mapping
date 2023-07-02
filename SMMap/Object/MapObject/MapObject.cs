using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMap
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SMMap) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(NestList) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(LoneList) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ChildList) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ParentList) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(DynamicList) + ':' + ' ' + ". . . ",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(AsymmetryList) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(NestList) + ':',
                String.Empty + String.Join('\n'.ToString(), NestList),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(LoneList) + ':',
                String.Empty + String.Join('\n'.ToString(), LoneList),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(ChildList) + ':',
                String.Empty + String.Join('\n'.ToString(), ChildList),
                String.Empty,
                String.Empty + '~' + "40" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(ParentList) + ':',
                String.Empty + String.Join('\n'.ToString(), ParentList),
                String.Empty,
                String.Empty + '~' + "50" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(DynamicList) + ':',
                String.Empty + String.Join('\n'.ToString(), DynamicList),
                String.Empty,
                String.Empty + '~' + "60" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(AsymmetryList) + ':',
                String.Empty + String.Join('\n'.ToString(), AsymmetryList)
            });
        }
    }
}
