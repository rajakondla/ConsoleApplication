using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Disposable:IDisposable
    {
        private bool _isDisposed = false;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool dispose)
        {
            if (!_isDisposed)
            {
                if (dispose)
                {

                }
                else
                {

                }
                _isDisposed = true;
            }
        }
    }
}
