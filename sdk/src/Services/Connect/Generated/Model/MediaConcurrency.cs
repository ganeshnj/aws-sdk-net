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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about which channels are supported, and how many contacts an
    /// agent can have on a channel simultaneously.
    /// </summary>
    public partial class MediaConcurrency
    {
        private Channel _channel;
        private int? _concurrency;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channels that agents can handle in the Contact Control Panel (CCP).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property Concurrency. 
        /// <para>
        /// The number of contacts an agent can have on a channel simultaneously.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <code>VOICE</code>: Minimum value of 1. Maximum value of 1.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <code>CHAT</code>: Minimum value of 1. Maximum value of 5.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <code>TASK</code>: Minimum value of 1. Maximum value of 10.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int Concurrency
        {
            get { return this._concurrency.GetValueOrDefault(); }
            set { this._concurrency = value; }
        }

        // Check to see if Concurrency property is set
        internal bool IsSetConcurrency()
        {
            return this._concurrency.HasValue; 
        }

    }
}