﻿using System;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.Unity;

namespace Smartac.SR.Core.EntLib.IoC
{
    internal static class TypeExtensions
    {
        public static bool IsTypeOfUnity(this Type type)
        {
            string @string = Encoding.Default.GetString(type.Assembly.GetName().GetPublicKeyToken());
            string string2 = Encoding.Default.GetString(typeof(IUnityContainer).Assembly.GetName().GetPublicKeyToken());
            return @string == string2;
        }

        public static bool IsTypeOfEntLib(this Type type)
        {
            string @string = Encoding.Default.GetString(type.Assembly.GetName().GetPublicKeyToken());
            string string2 = Encoding.Default.GetString(typeof(SerializableConfigurationSection).Assembly.GetName().GetPublicKeyToken());
            return @string == string2;
        }
    }
}
