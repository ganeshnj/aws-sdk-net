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
    /// Contains the names of AWS CloudFormation stacks used to update a collection of stacks.
    /// You can specify up to 500 AWS CloudFormation stacks.
    /// </summary>
    public partial class UpdateCloudFormationCollectionFilter
    {
        private List<string> _stackNames = new List<string>();

        /// <summary>
        /// Gets and sets the property StackNames. 
        /// <para>
        ///  An array of the names of the AWS CloudFormation stacks to update. You can specify
        /// up to 500 AWS CloudFormation stacks. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> StackNames
        {
            get { return this._stackNames; }
            set { this._stackNames = value; }
        }

        // Check to see if StackNames property is set
        internal bool IsSetStackNames()
        {
            return this._stackNames != null && this._stackNames.Count > 0; 
        }

    }
}