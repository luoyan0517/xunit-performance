﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Xunit.Performance
{
    /// <summary>
    /// Allows specification of whether a <see cref="BenchmarkAttribute"/> method allocates new objects from the GC heap.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class AllocatesAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocatesAttribute"/> class.
        /// </summary>
        /// <param name="allocates">True if the test allocates from the GC heap, otherwise false.</param>
        public AllocatesAttribute(bool allocates) { Allocates = allocates; }

        /// <summary>
        /// Indicates whether the test to which this attribute is applied allocates objects from the GC heap.
        /// </summary>
        public bool Allocates { get; private set; }
    }
}