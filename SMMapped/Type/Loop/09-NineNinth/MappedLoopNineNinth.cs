using Core;

namespace Core.Shared
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class SMMapped
    {
        public static SMMapped LoopMappedNineNinth(
SMMap map,
List<SRResolved> list_RESOLVED,
List<SRResolver> list_RESOLVER,
IEnumerator<SRResolved> enumerator,
Int32 position,
Int32 division,
Int32 origin,
Int32 layer,
String bind,
Boolean debug
            )
        {
            SMMapped mappedResult = default;

            Debug_MappedTraverseInner(
                nameof(LoopMappedNineNinth),
                enumerator,
                position,
                division,
                origin,
                layer,
                bind,
                debug
                );

            division = SAConstant.ResolveDivisionUnsuccess;

            var safe_ONE__FIRST = (enumerator.Current.ResolvedParent == default) is false;

            /*if (safe_ONE__FIRST)
            {
                division = enumerator.Current.ResolvedParent.ResolvedParent.ResolvedChildList.IndexOf(enumerator.Current.ResolvedParent);

                var division_ALIGN__ENO = division;

                division_ALIGN__ENO = division_ALIGN__ENO + 1;

                division = division_ALIGN__ENO;
            }
            else
            {
                /*division = 0;// resolved.ResolvedParent.ResolvedChildList.IndexOf(resolved);

                var division_ALIGN__ENO = division;

                division_ALIGN__ENO = division_ALIGN__ENO + 1;

                division = division_ALIGN__ENO;
            }*/

            mappedResult = LoopMappedTenTenth(
                map: map,
                list_RESOLVED: list_RESOLVED,
                list_RESOLVER: list_RESOLVER,
                enumerator: enumerator,
                position: position,
                division: division,
                origin: origin,
                layer: layer,
                bind: bind,
                debug: debug
                );

            return mappedResult;
        }
    }
}
