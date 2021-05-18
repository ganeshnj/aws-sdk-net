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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// This is the response object from the DescribeDetectorModelAnalysis operation.
    /// </summary>
    public partial class DescribeDetectorModelAnalysisResponse : AmazonWebServiceResponse
    {
        private AnalysisStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the analysis activity. The status can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RUNNING</code> - AWS IoT Events is analyzing your detector model. This process
        /// can take several minutes to complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETE</code> - AWS IoT Events finished analyzing your detector model .
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - AWS IoT Events couldn't analyze your detector model. Try again
        /// later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalysisStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}