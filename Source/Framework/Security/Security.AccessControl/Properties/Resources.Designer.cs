﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3031
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiiP.Framework.Security.AccessControl.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HiiP.Framework.Security.AccessControl.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is a connection problem to application server, please contact the administrator or retry it later..
        /// </summary>
        internal static string ConnectingFailure {
            get {
                return ResourceManager.GetString("ConnectingFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password is mandatory, please enter the password!.
        /// </summary>
        internal static string EmptyPassword {
            get {
                return ResourceManager.GetString("EmptyPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name is mandatory, please enter the user name!.
        /// </summary>
        internal static string EmptyUsername {
            get {
                return ResourceManager.GetString("EmptyUsername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must enter a valid user name and/or password..
        /// </summary>
        internal static string InvalidCredential {
            get {
                return ResourceManager.GetString("InvalidCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is failed to authenticate, you are not a legal authorised user!.
        /// </summary>
        internal static string NotAuthorizedUser {
            get {
                return ResourceManager.GetString("NotAuthorizedUser", resourceCulture);
            }
        }
    }
}