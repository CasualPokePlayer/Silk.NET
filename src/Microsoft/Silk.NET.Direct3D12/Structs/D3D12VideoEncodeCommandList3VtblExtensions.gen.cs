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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12VideoEncodeCommandList3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CommandListType GetType(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CommandListType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, CommandListType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12CommandAllocator* pAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12CommandAllocator pAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearState(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, void>)@this->LpVtbl[11])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResourceBarrier(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceBarrier* pBarriers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriers);
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ResourceBarrier pBarriers)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in DiscardRegion pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (DiscardRegion* pRegionPtr = &pRegion)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegion);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in DiscardRegion pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginQuery(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndQuery(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, void>)@this->LpVtbl[20])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimator, pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorInput pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimator, pOutputArguments, pInputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorOutput pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimator, pOutputArgumentsPtr, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorOutput pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorInput pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
        {
            fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimator, pOutputArgumentsPtr, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoMotionEstimator pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArguments, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoMotionEstimator pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorInput pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
        {
            fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArguments, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoMotionEstimator pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorOutput pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
        {
            fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArgumentsPtr, pInputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoMotionEstimator pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorOutput pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorInput pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
        {
            fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResolveVideoMotionVectorHeapOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResolveVideoMotionVectorHeapInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)@this->LpVtbl[22])(@this, pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResolveVideoMotionVectorHeapOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ResolveVideoMotionVectorHeapInput pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ResolveVideoMotionVectorHeapInput* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)@this->LpVtbl[22])(@this, pOutputArguments, pInputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ResolveVideoMotionVectorHeapOutput pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResolveVideoMotionVectorHeapInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ResolveVideoMotionVectorHeapOutput* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)@this->LpVtbl[22])(@this, pOutputArgumentsPtr, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveMotionVectorHeap(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ResolveVideoMotionVectorHeapOutput pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ResolveVideoMotionVectorHeapInput pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ResolveVideoMotionVectorHeapOutput* pOutputArgumentsPtr = &pOutputArguments)
        {
            fixed (ResolveVideoMotionVectorHeapInput* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)@this->LpVtbl[22])(@this, pOutputArgumentsPtr, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[23])(@this, Count, pParams, pModes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in WritebufferimmediateMode pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateMode* pModesPtr = &pModes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[23])(@this, Count, pParams, pModesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in WritebufferimmediateParameter pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[23])(@this, Count, pParamsPtr, pModes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in WritebufferimmediateParameter pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in WritebufferimmediateMode pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[23])(@this, Count, pParamsPtr, pModesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetProtectedResourceSession(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12ProtectedResourceSession* pProtectedResourceSession)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[24])(@this, pProtectedResourceSession);
    }

    /// <summary>To be documented.</summary>
    public static void SetProtectedResourceSession(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12ProtectedResourceSession pProtectedResourceSession)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[24])(@this, pProtectedResourceSessionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pInitializationParametersPtr = &pInitializationParameters)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommand, pInitializationParametersPtr, InitializationParametersSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParameters, InitializationParametersSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void InitializeExtensionCommand<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pInitializationParametersPtr = &pInitializationParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParametersPtr, InitializationParametersSizeInBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pExecutionParametersPtr = &pExecutionParameters)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
        {
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoder, pHeap, pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoder, pHeap, pInputArguments, pOutputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoder, pHeap, pInputArgumentsPtr, pOutputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
        {
            fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoder, pHeap, pInputArgumentsPtr, pOutputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoder, pHeapPtr, pInputArguments, pOutputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
        {
            fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoder, pHeapPtr, pInputArguments, pOutputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
        {
            fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoder, pHeapPtr, pInputArgumentsPtr, pOutputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
        {
            fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
            {
                fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoder, pHeapPtr, pInputArgumentsPtr, pOutputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoderPtr, pHeap, pInputArguments, pOutputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
        {
            fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoderPtr, pHeap, pInputArguments, pOutputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
        {
            fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoderPtr, pHeap, pInputArgumentsPtr, pOutputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
        {
            fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
            {
                fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoderPtr, pHeap, pInputArgumentsPtr, pOutputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
        {
            fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoderPtr, pHeapPtr, pInputArguments, pOutputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
        {
            fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
            {
                fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoderPtr, pHeapPtr, pInputArguments, pOutputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
        {
            fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
            {
                fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoderPtr, pHeapPtr, pInputArgumentsPtr, pOutputArguments);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
        {
            fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
            {
                fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)@this->LpVtbl[27])(@this, pEncoderPtr, pHeapPtr, pInputArgumentsPtr, pOutputArgumentsPtr);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveEncoderOutputMetadata(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderResolveMetadataInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderResolveMetadataOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, VideoEncoderResolveMetadataInputArguments*, VideoEncoderResolveMetadataOutputArguments*, void>)@this->LpVtbl[28])(@this, pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveEncoderOutputMetadata(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderResolveMetadataInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderResolveMetadataOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoEncoderResolveMetadataOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, VideoEncoderResolveMetadataInputArguments*, VideoEncoderResolveMetadataOutputArguments*, void>)@this->LpVtbl[28])(@this, pInputArguments, pOutputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveEncoderOutputMetadata(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderResolveMetadataInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderResolveMetadataOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoEncoderResolveMetadataInputArguments* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, VideoEncoderResolveMetadataInputArguments*, VideoEncoderResolveMetadataOutputArguments*, void>)@this->LpVtbl[28])(@this, pInputArgumentsPtr, pOutputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveEncoderOutputMetadata(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderResolveMetadataInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderResolveMetadataOutputArguments pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoEncoderResolveMetadataInputArguments* pInputArgumentsPtr = &pInputArguments)
        {
            fixed (VideoEncoderResolveMetadataOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, VideoEncoderResolveMetadataInputArguments*, VideoEncoderResolveMetadataOutputArguments*, void>)@this->LpVtbl[28])(@this, pInputArgumentsPtr, pOutputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Barrier(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint NumBarrierGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BarrierGroup* pBarrierGroups)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, BarrierGroup*, void>)@this->LpVtbl[29])(@this, NumBarrierGroups, pBarrierGroups);
    }

    /// <summary>To be documented.</summary>
    public static void Barrier(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint NumBarrierGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in BarrierGroup pBarrierGroups)
    {
        var @this = thisVtbl.Handle;
        fixed (BarrierGroup* pBarrierGroupsPtr = &pBarrierGroups)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, BarrierGroup*, void>)@this->LpVtbl[29])(@this, NumBarrierGroups, pBarrierGroupsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pAllocator) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reset((ID3D12CommandAllocator*) pAllocator.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12CommandAllocator> pAllocator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reset(ref pAllocator.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceBarrier> pBarriers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResourceBarrier(NumBarriers, in pBarriers.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DiscardResource((ID3D12Resource*) pResource.Handle, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DiscardRegion> pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(pResource, in pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in DiscardRegion pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DiscardResource((ID3D12Resource*) pResource.Handle, in pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), pRegion);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DiscardRegion> pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), in pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->BeginQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EndQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EndQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0, TI1>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI1> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(pQueryHeap, Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, ref pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI0> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData(ref pQueryHeap, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetPredication((ID3D12Resource*) pBuffer.Handle, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12Resource> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetPredication(ref pBuffer.GetPinnableReference(), AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetMarker(Metadata, in pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginEvent(Metadata, in pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoMotionEstimator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EstimateMotion((ID3D12VideoMotionEstimator*) pMotionEstimator.Handle, pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorInput> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EstimateMotion(pMotionEstimator, pOutputArguments, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorInput pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoMotionEstimator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EstimateMotion((ID3D12VideoMotionEstimator*) pMotionEstimator.Handle, pOutputArguments, in pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorOutput> pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EstimateMotion(pMotionEstimator, in pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorOutput pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoMotionEstimator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EstimateMotion((ID3D12VideoMotionEstimator*) pMotionEstimator.Handle, in pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorOutput> pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorInput> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EstimateMotion(pMotionEstimator, in pOutputArguments.GetPinnableReference(), in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EstimateMotion<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorOutput pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoMotionEstimatorInput pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoMotionEstimator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EstimateMotion((ID3D12VideoMotionEstimator*) pMotionEstimator.Handle, in pOutputArguments, in pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoMotionEstimator> pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EstimateMotion(ref pMotionEstimator.GetPinnableReference(), pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoMotionEstimator> pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorInput> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EstimateMotion(ref pMotionEstimator.GetPinnableReference(), pOutputArguments, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoMotionEstimator> pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorOutput> pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoMotionEstimatorInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EstimateMotion(ref pMotionEstimator.GetPinnableReference(), in pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void EstimateMotion(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoMotionEstimator> pMotionEstimator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorOutput> pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoMotionEstimatorInput> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EstimateMotion(ref pMotionEstimator.GetPinnableReference(), in pOutputArguments.GetPinnableReference(), in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResolveVideoMotionVectorHeapOutput* pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResolveVideoMotionVectorHeapInput> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveMotionVectorHeap(pOutputArguments, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResolveVideoMotionVectorHeapOutput> pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResolveVideoMotionVectorHeapInput* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveMotionVectorHeap(in pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveMotionVectorHeap(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResolveVideoMotionVectorHeapOutput> pOutputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResolveVideoMotionVectorHeapInput> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveMotionVectorHeap(in pOutputArguments.GetPinnableReference(), in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WritebufferimmediateMode> pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, pParams, in pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WritebufferimmediateParameter> pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, in pParams.GetPinnableReference(), pModes);
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WritebufferimmediateParameter> pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WritebufferimmediateMode> pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, in pParams.GetPinnableReference(), in pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetProtectedResourceSession<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetProtectedResourceSession((ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SetProtectedResourceSession(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetProtectedResourceSession(ref pProtectedResourceSession.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInitializationParameters, nuint InitializationParametersSizeInBytes) where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->InitializeExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, pInitializationParameters, InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->InitializeExtensionCommand(pExtensionCommand, in pInitializationParameters.GetPinnableReference(), InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static void InitializeExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->InitializeExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, in pInitializationParameters, InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void InitializeExtensionCommand(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->InitializeExtensionCommand(ref pExtensionCommand.GetPinnableReference(), pInitializationParameters, InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static void InitializeExtensionCommand<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->InitializeExtensionCommand(ref pExtensionCommand.GetPinnableReference(), in pInitializationParameters.GetPinnableReference(), InitializationParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes) where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, pExecutionParameters, ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteExtensionCommand(pExtensionCommand, in pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteExtensionCommand<T0, TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, in pExecutionParameters, ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteExtensionCommand(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), pExecutionParameters, ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteExtensionCommand<T0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoExtensionCommand> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ExecuteExtensionCommand(ref pExtensionCommand.GetPinnableReference(), in pExecutionParameters.GetPinnableReference(), ExecutionParametersSizeInBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0, TI1>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pEncoder, ComPtr<TI1> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame((ID3D12VideoEncoder*) pEncoder.Handle, (ID3D12VideoEncoderHeap*) pHeap.Handle, pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(pEncoder, pHeap, pInputArguments, in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0, TI1>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pEncoder, ComPtr<TI1> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame((ID3D12VideoEncoder*) pEncoder.Handle, (ID3D12VideoEncoderHeap*) pHeap.Handle, pInputArguments, in pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(pEncoder, pHeap, in pInputArguments.GetPinnableReference(), pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0, TI1>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pEncoder, ComPtr<TI1> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame((ID3D12VideoEncoder*) pEncoder.Handle, (ID3D12VideoEncoderHeap*) pHeap.Handle, in pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(pEncoder, pHeap, in pInputArguments.GetPinnableReference(), in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EncodeFrame<TI0, TI1>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pEncoder, ComPtr<TI1> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame((ID3D12VideoEncoder*) pEncoder.Handle, (ID3D12VideoEncoderHeap*) pHeap.Handle, in pInputArguments, in pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, Span<ID3D12VideoEncoderHeap> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(pEncoder, ref pHeap.GetPinnableReference(), pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame((ID3D12VideoEncoder*) pEncoder.Handle, ref pHeap, pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, Span<ID3D12VideoEncoderHeap> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(pEncoder, ref pHeap.GetPinnableReference(), pInputArguments, in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame((ID3D12VideoEncoder*) pEncoder.Handle, ref pHeap, pInputArguments, in pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, Span<ID3D12VideoEncoderHeap> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(pEncoder, ref pHeap.GetPinnableReference(), in pInputArguments.GetPinnableReference(), pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame((ID3D12VideoEncoder*) pEncoder.Handle, ref pHeap, in pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ID3D12VideoEncoder* pEncoder, Span<ID3D12VideoEncoderHeap> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(pEncoder, ref pHeap.GetPinnableReference(), in pInputArguments.GetPinnableReference(), in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EncodeFrame<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ComPtr<TI0> pEncoder, ref ID3D12VideoEncoderHeap pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame((ID3D12VideoEncoder*) pEncoder.Handle, ref pHeap, in pInputArguments, in pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoEncoder> pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(ref pEncoder.GetPinnableReference(), pHeap, pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ComPtr<TI0> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame(ref pEncoder, (ID3D12VideoEncoderHeap*) pHeap.Handle, pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoEncoder> pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(ref pEncoder.GetPinnableReference(), pHeap, pInputArguments, in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ComPtr<TI0> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame(ref pEncoder, (ID3D12VideoEncoderHeap*) pHeap.Handle, pInputArguments, in pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoEncoder> pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(ref pEncoder.GetPinnableReference(), pHeap, in pInputArguments.GetPinnableReference(), pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ComPtr<TI0> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame(ref pEncoder, (ID3D12VideoEncoderHeap*) pHeap.Handle, in pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoEncoder> pEncoder, ID3D12VideoEncoderHeap* pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(ref pEncoder.GetPinnableReference(), pHeap, in pInputArguments.GetPinnableReference(), in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void EncodeFrame<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, ref ID3D12VideoEncoder pEncoder, ComPtr<TI0> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeInputArguments pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in VideoEncoderEncodeframeOutputArguments pOutputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EncodeFrame(ref pEncoder, (ID3D12VideoEncoderHeap*) pHeap.Handle, in pInputArguments, in pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoEncoder> pEncoder, Span<ID3D12VideoEncoderHeap> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(ref pEncoder.GetPinnableReference(), ref pHeap.GetPinnableReference(), pInputArguments, pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoEncoder> pEncoder, Span<ID3D12VideoEncoderHeap> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(ref pEncoder.GetPinnableReference(), ref pHeap.GetPinnableReference(), pInputArguments, in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoEncoder> pEncoder, Span<ID3D12VideoEncoderHeap> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderEncodeframeOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(ref pEncoder.GetPinnableReference(), ref pHeap.GetPinnableReference(), in pInputArguments.GetPinnableReference(), pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void EncodeFrame(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, Span<ID3D12VideoEncoder> pEncoder, Span<ID3D12VideoEncoderHeap> pHeap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderEncodeframeOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EncodeFrame(ref pEncoder.GetPinnableReference(), ref pHeap.GetPinnableReference(), in pInputArguments.GetPinnableReference(), in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveEncoderOutputMetadata(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderResolveMetadataInputArguments* pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderResolveMetadataOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveEncoderOutputMetadata(pInputArguments, in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveEncoderOutputMetadata(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderResolveMetadataInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoEncoderResolveMetadataOutputArguments* pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveEncoderOutputMetadata(in pInputArguments.GetPinnableReference(), pOutputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveEncoderOutputMetadata(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderResolveMetadataInputArguments> pInputArguments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoEncoderResolveMetadataOutputArguments> pOutputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveEncoderOutputMetadata(in pInputArguments.GetPinnableReference(), in pOutputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void Barrier(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl, uint NumBarrierGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BarrierGroup> pBarrierGroups)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Barrier(NumBarrierGroups, in pBarrierGroups.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0>(this ComPtr<ID3D12VideoEncodeCommandList3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
