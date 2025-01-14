﻿// <copyright file="UnsafeSlabAllocator.cs" company="BovineLabs">
//     Copyright (c) BovineLabs. All rights reserved.
// </copyright>

namespace BovineLabs.Core.Memory
{
    using System;
    using BovineLabs.Core.Collections;
    using Unity.Collections;
    using Unity.Collections.LowLevel.Unsafe;
    using UnityEngine;

    //[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
    //public unsafe struct UnsafeSlabAllocator<T> : IDisposable
    //    where T : unmanaged
    //{
    //    private readonly int countPerSlab;
    //    private readonly Allocator allocator;

    //    private UnsafeListPtr<Ptr> slabs;

    //    [NativeDisableUnsafePtrRestriction]
    //    private int* count;

    //    public UnsafeSlabAllocator(int countPerSlab, Allocator allocator)
    //    {
    //        Debug.Assert(countPerSlab > 0);

    //        this.slabs = new UnsafeListPtr<Ptr>(0, allocator);
    //        this.allocator = allocator;
    //        this.countPerSlab = countPerSlab;

    //        this.count = (int*)Memory.Unmanaged.Allocate(UnsafeUtility.SizeOf<int>(), UnsafeUtility.AlignOf<int>(), allocator);
    //        *this.count = countPerSlab;
    //    }

    //    public int AllocationCount => (this.countPerSlab * (this.slabs.Length - 1)) + *this.count;

    //    public bool IsCreated => this.count != null;

    //    /// <summary> Returns a pointer. This memory is not cleared. </summary>
    //    /// <returns> The pointer. </returns>
    //    public T* Alloc()
    //    {
    //        if (*this.count == this.countPerSlab)
    //        {
    //            *this.count = 0;
    //            var ptr = (Ptr)Memory.Unmanaged.Allocate(this.countPerSlab * UnsafeUtility.SizeOf<T>(), UnsafeUtility.AlignOf<T>(), this.allocator);
    //            this.slabs.Add(ptr);
    //        }

    //        var lastSlab = (T*)this.slabs[^1];
    //        return lastSlab + (*this.count)++;
    //    }

    //    public void Clear()
    //    {
    //        for (var i = 0; i < this.slabs.Length; i++)
    //        {
    //            UnsafeUtility.Free(this.slabs[i], this.allocator);
    //        }

    //        this.slabs.Clear();
    //        *this.count = this.countPerSlab;
    //    }

    //    /// <inheritdoc/>
    //    public void Dispose()
    //    {
    //        this.Clear();
    //        this.slabs.Dispose();

    //        Memory.Unmanaged.Free(this.count, this.allocator);

    //        this.count = default;
    //        this.slabs = default;
    //    }
    //}
}
