using Core;

namespace Core.Shared
{
    using System;

    public partial struct SMMapperDataStatic
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
                String.Empty + nameof(SMMapper) + ' ' + "::" + ' ' + nameof(SMMapperDataStatic) + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(SymbolLeft) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(SymbolRight) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(DelimiterLeft) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(DelimiterRight) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(SymbolLeft) + ':',
                String.Empty + SymbolLeft,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(SymbolRight) + ':',
                String.Empty + SymbolRight,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(DelimiterLeft) + ':',
                String.Empty + DelimiterLeft,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(DelimiterRight) + ':',
                String.Empty + DelimiterRight
            });
        }
    }
}
