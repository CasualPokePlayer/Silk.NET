// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition;

public unsafe static class DCompositionColorMatrixEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, uint index, ref Silk.NET.Core.Native.IUnknown input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* inputPtr = &input)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, inputPtr, flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMatrix(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Silk.NET.Maths.Matrix5X4<float>* matrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Maths.Matrix5X4<float>*, int>)@this->LpVtbl[4])(@this, matrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMatrix(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, ref Silk.NET.Maths.Matrix5X4<float> matrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Matrix5X4<float>* matrixPtr = &matrix)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Maths.Matrix5X4<float>*, int>)@this->LpVtbl[4])(@this, matrixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMatrixElement(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, int row, int column, float value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, int, int, float, int>)@this->LpVtbl[6])(@this, row, column, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaMode(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Silk.NET.Direct2D.ColormatrixAlphaMode mode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Direct2D.ColormatrixAlphaMode, int>)@this->LpVtbl[7])(@this, mode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClampOutput(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Silk.NET.Core.Bool32 clamp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, clamp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput<TI0>(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, uint index, ComPtr<TI0> input, uint flags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetInput(index, (Silk.NET.Core.Native.IUnknown*) input.Handle, flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetInput(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, uint index, Span<Silk.NET.Core.Native.IUnknown> input, uint flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetInput(index, ref input.GetPinnableReference(), flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetMatrix(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Span<Silk.NET.Maths.Matrix5X4<float>> matrix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetMatrix(ref matrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
