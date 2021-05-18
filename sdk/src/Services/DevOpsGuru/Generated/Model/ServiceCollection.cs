/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// A collection of the names of AWS services.
    /// </summary>
    public partial class ServiceCollection
    {
        private List<string> _serviceNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ServiceNames. 
        /// <para>
        /// An array of strings that each specifies the name of an AWS service.
        /// </para>
        /// </summary>
        public List<string> ServiceNames
        {
            get { return this._serviceNames; }
            set { this._serviceNames = value; }
        }

        // Check to see if ServiceNames property is set
        internal bool IsSetServiceNames()
        {
            return this._serviceNames != null && this._serviceNames.Count > 0; 
        }

    }
}