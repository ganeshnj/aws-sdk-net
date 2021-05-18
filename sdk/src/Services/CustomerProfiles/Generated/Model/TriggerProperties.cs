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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Specifies the configuration details that control the trigger for a flow. Currently,
    /// these settings only apply to the Scheduled trigger type.
    /// </summary>
    public partial class TriggerProperties
    {
        private ScheduledTriggerProperties _scheduled;

        /// <summary>
        /// Gets and sets the property Scheduled. 
        /// <para>
        /// Specifies the configuration details of a schedule-triggered flow that you define.
        /// </para>
        /// </summary>
        public ScheduledTriggerProperties Scheduled
        {
            get { return this._scheduled; }
            set { this._scheduled = value; }
        }

        // Check to see if Scheduled property is set
        internal bool IsSetScheduled()
        {
            return this._scheduled != null;
        }

    }
}