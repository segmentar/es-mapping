using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMapped
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SMMapped) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ResolvedList) + ':' + ' ' + ". . ." + ' ' + $"[{ResolvedList.Count}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ResolverList) + ':' + ' ' + ". . ." + ' ' + $"[{ResolverList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ResolvedList) + ':',
                String.Empty + String.Join('\n'.ToString(), ResolvedList),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ResolverList) + ':',
                String.Empty + String.Join('\n'.ToString(), ResolverList)
            });
        }
    }
}
