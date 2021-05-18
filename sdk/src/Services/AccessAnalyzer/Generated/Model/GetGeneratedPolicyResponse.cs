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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// This is the response object from the GetGeneratedPolicy operation.
    /// </summary>
    public partial class GetGeneratedPolicyResponse : AmazonWebServiceResponse
    {
        private GeneratedPolicyResult _generatedPolicyResult;
        private JobDetails _jobDetails;

        /// <summary>
        /// Gets and sets the property GeneratedPolicyResult. 
        /// <para>
        /// A <code>GeneratedPolicyResult</code> object that contains the generated policies and
        /// associated details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeneratedPolicyResult GeneratedPolicyResult
        {
            get { return this._generatedPolicyResult; }
            set { this._generatedPolicyResult = value; }
        }

        // Check to see if GeneratedPolicyResult property is set
        internal bool IsSetGeneratedPolicyResult()
        {
            return this._generatedPolicyResult != null;
        }

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// A <code>GeneratedPolicyDetails</code> object that contains details about the generated
        /// policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobDetails JobDetails
        {
            get { return this._jobDetails; }
            set { this._jobDetails = value; }
        }

        // Check to see if JobDetails property is set
        internal bool IsSetJobDetails()
        {
            return this._jobDetails != null;
        }

    }
}