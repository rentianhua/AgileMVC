//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Validation Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Globalization;
using System.Reflection;
using Microsoft.Practices.EnterpriseLibrary.Validation.Properties;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Validators
{
	/// <summary>
	/// Represents the logic to access values from a field.
	/// </summary>
	/// <seealso cref="ValueAccess"/>
	internal sealed class FieldValueAccess : ValueAccess
	{
		private FieldInfo fieldInfo;

		public FieldValueAccess(FieldInfo fieldInfo)
		{
			this.fieldInfo = fieldInfo;
		}

		public override bool GetValue(object source, out object value, out string valueAccessFailureMessage)
		{
			value = null;
			valueAccessFailureMessage = null;

			if (null == source)
			{
				valueAccessFailureMessage = string.Format(CultureInfo.CurrentUICulture,
					Resources.ErrorValueAccessNull,
					this.Key);
				return false;
			}
			if (!this.fieldInfo.DeclaringType.IsAssignableFrom(source.GetType()))
			{
				valueAccessFailureMessage = string.Format(CultureInfo.CurrentUICulture,
					Resources.ErrorValueAccessInvalidType,
					this.Key,
					source.GetType().FullName);
				return false;
			}

			value = this.fieldInfo.GetValue(source);
			return true;
		}

		public override string Key
		{
			get { return this.fieldInfo.Name; }
		}

		#region test only properties

		internal FieldInfo FieldInfo
		{
			get { return this.fieldInfo; }
		}

		#endregion
	}
}
