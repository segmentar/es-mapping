using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMapper
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SMMapper) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StaticText) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(DynamicText) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(OriginList) + ':' + ' ' + ". . ." + ' ' + $"[{OriginList.Count}]",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Static) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Execute) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(Dynamic) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(StaticText) + ':',
                String.Empty + StaticText,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(DynamicText) + ':',
                String.Empty + DynamicText,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(OriginList) + ':',
                String.Empty + String.Join('\n'.ToString(), OriginList),
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(Static) + ':',
                String.Empty + Static,
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(Execute) + ':',
                String.Empty + Execute,
                String.Empty,
                String.Empty + '~' + "60" + ' ' + nameof(Dynamic) + ':',
                String.Empty + Dynamic
            });
        }
    }
}
