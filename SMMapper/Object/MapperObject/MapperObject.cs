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
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(NesterSymmetryList) + ':' + ' ' + ". . ." + ' ' + $"[{NesterSymmetryList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + SAConstant.DebugVisibilityLine + ' ' + nameof(NesterSymmetryList) + ':',
                String.Empty + $"[{String.Join('\n'.ToString(), NesterSymmetryList)}]"
            });
        }
    }
}
