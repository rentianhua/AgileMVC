#region

using Smartac.SR.Core.ApplicationContexts;

#endregion

namespace Smartac.SR.Framework.Common
{
    public interface IApplicationContextAwareObject
    {
        /// <summary>
        ///     Gets the current application context.
        /// </summary>
        /// <value>The current application context.</value>
        ApplicationContext ApplicationContext { get; }
    }
}