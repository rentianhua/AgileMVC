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
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation.Properties;
using System.Reflection;
using System.Globalization;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Configuration
{
	/// <summary>
	/// Represents a <see cref="PropertyComparisonValidator"/>.
	/// </summary>
	public class PropertyComparisonValidatorData : ValueValidatorData
	{
		/// <summary>
		/// <para>Initializes a new instance of the <see cref="PropertyComparisonValidator"/> class.</para>
		/// </summary>
		public PropertyComparisonValidatorData()
		{ }

		/// <summary>
		/// <para>Initializes a new instance of the <see cref="PropertyComparisonValidator"/> class with a name.</para>
		/// </summary>
		/// <param name="name"></param>
		public PropertyComparisonValidatorData(string name)
			: base(name, typeof(PropertyComparisonValidator))
		{ }

		/// <summary>
		/// Creates the <see cref="PropertyComparisonValidator"/> described by the configuration object.
		/// </summary>
		/// <param name="targetType">The type of object that will be validated by the validator.</param>
		/// <param name="ownerType">The type of the object from which the value to validate is extracted.</param>
		/// <param name="memberValueAccessBuilder">The <see cref="MemberValueAccessBuilder"/> to use for validators that
		/// require access to properties.</param>
		/// <returns>The created <see cref="PropertyComparisonValidator"/>.</returns>	
		protected override Validator DoCreateValidator(Type targetType, Type ownerType, MemberValueAccessBuilder memberValueAccessBuilder)
		{
			if (string.IsNullOrEmpty(this.PropertyToCompare))
			{
				throw new ConfigurationErrorsException(Resources.ExceptionPropertyToCompareNull);
			}
			PropertyInfo propertyInfo = ValidationReflectionHelper.GetProperty(ownerType, this.PropertyToCompare, false);
			if (propertyInfo == null)
			{
				throw new ConfigurationErrorsException(
					string.Format(CultureInfo.CurrentUICulture,
						Resources.ExceptionPropertyToCompareNotFound,
						this.PropertyToCompare,
						ownerType.FullName));
			}

			return new PropertyComparisonValidator(memberValueAccessBuilder.GetPropertyValueAccess(propertyInfo),
				this.ComparisonOperator,
				this.Negated);
		}

		private const string ComparisonOperatorPropertyName = "operator";
		/// <summary>
		/// Gets or sets the <see cref="ComparisonOperator"/> describing the comparison that the represented <see cref="PropertyComparisonValidator"/>.
		/// </summary>
		[ConfigurationProperty(ComparisonOperatorPropertyName)]
		public ComparisonOperator ComparisonOperator
		{
			get { return (ComparisonOperator)this[ComparisonOperatorPropertyName]; }
			set { this[ComparisonOperatorPropertyName] = value; }
		}

		private const string PropertyToComparePropertyName = "propertyToCompare";
		/// <summary>
		/// Gets or sets the name of the property that the represented <see cref="PropertyComparisonValidator"/> will use to retrieve the value to compare.
		/// </summary>
		[ConfigurationProperty(PropertyToComparePropertyName, DefaultValue = "")]
		public string PropertyToCompare
		{
			get { return (string)this[PropertyToComparePropertyName]; }
			set { this[PropertyToComparePropertyName] = value; }
		}
	}
}