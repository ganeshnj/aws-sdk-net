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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// This is the response object from the ListResponsePlans operation.
    /// </summary>
    public partial class ListResponsePlansResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResponsePlanSummary> _responsePlanSummaries = new List<ResponsePlanSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to continue to the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResponsePlanSummaries. 
        /// <para>
        /// Details of each response plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<ResponsePlanSummary> ResponsePlanSummaries
        {
            get { return this._responsePlanSummaries; }
            set { this._responsePlanSummaries = value; }
        }

        // Check to see if ResponsePlanSummaries property is set
        internal bool IsSetResponsePlanSummaries()
        {
            return this._responsePlanSummaries != null && this._responsePlanSummaries.Count > 0; 
        }

    }
}