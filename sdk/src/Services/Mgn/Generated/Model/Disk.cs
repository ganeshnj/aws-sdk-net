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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// The disk identifier.
    /// </summary>
    public partial class Disk
    {
        private long? _bytes;
        private string _deviceName;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// The amount of storage on the disk in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long Bytes
        {
            get { return this._bytes.GetValueOrDefault(); }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The disk or device name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

    }
}