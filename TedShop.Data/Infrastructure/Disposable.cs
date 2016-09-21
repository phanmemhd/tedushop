using System;

namespace TeduShop.Data.Infrastructure
{
    public class Disposable : IDisposable // ke thua phuong co san trong C# "cai dat cac phuong thuc tu huy"
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // GC la phuong thuc thu hoach bo nho
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        // Ovveride this to dispose custom objects
        protected virtual void DisposeCore()
        {
        }
    }
}