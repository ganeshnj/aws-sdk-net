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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Container for the parameters to the GetFeedback operation.
    /// Get feedback for an anomaly group.
    /// </summary>
    public partial class GetFeedbackRequest : AmazonLookoutMetricsRequest
    {
        private string _anomalyDetectorArn;
        private AnomalyGroupTimeSeries _anomalyGroupTimeSeriesFeedback;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string AnomalyDetectorArn
        {
            get { return this._anomalyDetectorArn; }
            set { this._anomalyDetectorArn = value; }
        }

        // Check to see if AnomalyDetectorArn property is set
        internal bool IsSetAnomalyDetectorArn()
        {
            return this._anomalyDetectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyGroupTimeSeriesFeedback. 
        /// <para>
        /// The anomalous metric and group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalyGroupTimeSeries AnomalyGroupTimeSeriesFeedback
        {
            get { return this._anomalyGroupTimeSeriesFeedback; }
            set { this._anomalyGroupTimeSeriesFeedback = value; }
        }

        // Check to see if AnomalyGroupTimeSeriesFeedback property is set
        internal bool IsSetAnomalyGroupTimeSeriesFeedback()
        {
            return this._anomalyGroupTimeSeriesFeedback != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token that's returned by a previous request to retrieve the
        /// next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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

    }
}