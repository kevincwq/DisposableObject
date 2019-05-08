using System;

namespace DisposableObject
{
    class DisposableObject : IDisposable
    {
        // Flag: Has Dispose already been called?
        protected bool disposed = false;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                ReleaseManagedResources();
            }

            // Free any unmanaged objects here.
            ReleaseUnmanagedResources();
            disposed = true;
        }

        ~DisposableObject()
        {
            Dispose(false);
        }

        protected virtual void ReleaseManagedResources()
        {

        }

        protected virtual void ReleaseUnmanagedResources()
        {

        }
    }
}
