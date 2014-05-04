// Type: Mathcad.IMathcadWorksheets
// Assembly: Interop.Mathcad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: D:\Aspiranture\Dis_project\simulations\GenerateTestData\obj\Debug\Interop.Mathcad.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mathcad
{
    [Guid("0F8C6000-AE35-11D1-B19D-0060971E663A")]
    [TypeLibType(4160)]
    [ComImport]
    public interface IMathcadWorksheets : IEnumerable
    {
        [TypeLibFunc(65)]
        [DispId(-4)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        new IEnumerator GetEnumerator();

        [DispId(4)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        Worksheet Add();

        [DispId(0)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        Worksheet Item([MarshalAs(UnmanagedType.Struct), In, Optional] object index);

        [DispId(5)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        Worksheet Open([MarshalAs(UnmanagedType.BStr), In] string pFileName);

        [DispId(6)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void Remove([MarshalAs(UnmanagedType.Struct), In] object index);

        [DispId(1)]
        Application Application { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        get; }

        [DispId(2)]
        int Count { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        get; }

        [DispId(3)]
        Application Parent { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        get; }
    }
}
