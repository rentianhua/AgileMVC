using Microsoft.Practices.Unity.InterceptionExtension;

namespace Smartac.SR.Core.EntLib.IoC
{
    public abstract class AutoInterceptorPolicy
    {
        /// <summary>
        /// Gets the <see cref="T:Microsoft.Practices.Unity.InterceptionExtension.IInstanceInterceptor" />.
        /// </summary>
        public abstract IInstanceInterceptor Interceptor
        {
            get;
        }
    }
}
