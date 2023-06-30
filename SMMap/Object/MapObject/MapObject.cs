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
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(OriginList) + ':' + ' ' + ". . ." + ' ' + $"[{OriginList.Count}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(LoneList) + ':' + ' ' + ". . ." + ' ' + $"[{LoneList.Count}]",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ChildList) + ':' + ' ' + ". . ." + ' ' + $"[{ChildList.Count}]",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ParentList) + ':' + ' ' + ". . ." + ' ' + $"[{ParentList.Count}]",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(NesterList) + ':' + ' ' + ". . ." + ' ' + $"[{NesterList.Count}]",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(NestList) + ':' + ' ' + ". . ." + ' ' + $"[{NestList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(OriginList) + ':',
                String.Empty + $"[{String.Join('\n'.ToString(), OriginList)}]",
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(LoneList) + ':',
                String.Empty + $"{{{String.Join('\n'.ToString(), LoneList)}}}",
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ChildList) + ':',
                String.Empty + $"{{{String.Join('\n'.ToString(), ChildList)}}}",
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(ParentList) + ':',
                String.Empty + $"{{{String.Join('\n'.ToString(), ParentList)}}}",
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(NesterList) + ':',
                String.Empty + $"{{{String.Join('\n'.ToString(), NesterList)}}}",
                String.Empty,
                String.Empty + '~' + "60" + ' ' + nameof(NestList) + ':',
                String.Empty + $"{{{String.Join('\n'.ToString(), NestList)}}}"
            });
        }
    }
}
