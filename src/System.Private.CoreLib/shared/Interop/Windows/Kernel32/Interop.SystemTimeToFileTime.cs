// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class Kernel32
    {
        [DllImport(Libraries.Kernel32)]
        internal static unsafe extern Interop.BOOL SystemTimeToFileTime(Interop.Kernel32.SYSTEMTIME* lpSystemTime, long* lpFileTime);
    }
}
