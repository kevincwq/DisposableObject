using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DisposableObject
{
    class DerivedDisposableObject : DisposableObject
    {
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        protected override void ReleaseManagedResources()
        {
            Debug.WriteLine("DerivedDisposableObject: ReleaseManagedResources");
            handle.Dispose();
            base.ReleaseManagedResources();
        }

        protected override void ReleaseUnmanagedResources()
        {
            Debug.WriteLine("DerivedDisposableObject: ReleaseUnmanagedResources");
            base.ReleaseUnmanagedResources();
        }

        public void TestMethod()
        {
            Debug.WriteLine("DerivedDisposableObject: Test");
        }
    }
}
