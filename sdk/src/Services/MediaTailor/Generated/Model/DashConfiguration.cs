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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for DASH content.
    /// </summary>
    public partial class DashConfiguration
    {
        private string _manifestEndpointPrefix;
        private string _mpdLocation;
        private OriginManifestType _originManifestType;

        /// <summary>
        /// Gets and sets the property ManifestEndpointPrefix. 
        /// <para>
        /// The URL generated by MediaTailor to initiate a playback session. The session uses
        /// server-side reporting. This setting is ignored in PUT operations.
        /// </para>
        /// </summary>
        public string ManifestEndpointPrefix
        {
            get { return this._manifestEndpointPrefix; }
            set { this._manifestEndpointPrefix = value; }
        }

        // Check to see if ManifestEndpointPrefix property is set
        internal bool IsSetManifestEndpointPrefix()
        {
            return this._manifestEndpointPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property MpdLocation. 
        /// <para>
        /// The setting that controls whether MediaTailor includes the Location tag in DASH manifests.
        /// MediaTailor populates the Location tag with the URL for manifest update requests,
        /// to be used by players that don't support sticky redirects. Disable this if you have
        /// CDN routing rules set up for accessing MediaTailor manifests, and you are either using
        /// client-side reporting or your players support sticky HTTP redirects. Valid values
        /// are DISABLED and EMT_DEFAULT. The EMT_DEFAULT setting enables the inclusion of the
        /// tag and is the default value.
        /// </para>
        /// </summary>
        public string MpdLocation
        {
            get { return this._mpdLocation; }
            set { this._mpdLocation = value; }
        }

        // Check to see if MpdLocation property is set
        internal bool IsSetMpdLocation()
        {
            return this._mpdLocation != null;
        }

        /// <summary>
        /// Gets and sets the property OriginManifestType. 
        /// <para>
        /// The setting that controls whether MediaTailor handles manifests from the origin server
        /// as multi-period manifests or single-period manifests. If your origin server produces
        /// single-period manifests, set this to SINGLE_PERIOD. The default setting is MULTI_PERIOD.
        /// For multi-period manifests, omit this setting or set it to MULTI_PERIOD.
        /// </para>
        /// </summary>
        public OriginManifestType OriginManifestType
        {
            get { return this._originManifestType; }
            set { this._originManifestType = value; }
        }

        // Check to see if OriginManifestType property is set
        internal bool IsSetOriginManifestType()
        {
            return this._originManifestType != null;
        }

    }
}