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
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration.Design.Properties;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Configuration.Design.ValidatorNodes
{
    /// <summary>
    /// Respresents the designtime configuration node for a <see cref="NotNullValidatorData"/>.
    /// </summary>
    public class NotNullValidatorNode : ValueValidatorNode
    {
        /// <summary>
        /// Creates an instance of <see cref="NotNullValidatorNode"/> based on default values.
        /// </summary>
        public NotNullValidatorNode()
            : base(new NotNullValidatorData(Resources.NotNullValidatorNodeName))
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="NotNullValidatorNode"/> based on runtime configuration data.
        /// </summary>
        /// <param name="validatorData">The corresponding runtime configuration data.</param>
        public NotNullValidatorNode(NotNullValidatorData validatorData)
            : base(validatorData)
        {
        }

        /// <summary>
        /// Returns the runtime configuration data that is represented by this node.
        /// </summary>
        /// <returns>An instance of <see cref="NotNullValidatorData"/> that can be persisted to a configuration file.</returns>
        public override ValidatorData CreateValidatorData()
        {
            NotNullValidatorData validatorData = new NotNullValidatorData(Name);
            SetValidatorBaseProperties(validatorData);
			SetValueValidatorBaseProperties(validatorData);

            return validatorData;
        }
    }
}
