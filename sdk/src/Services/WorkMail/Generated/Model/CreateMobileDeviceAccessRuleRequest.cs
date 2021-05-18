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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMobileDeviceAccessRule operation.
    /// Creates a new mobile device access rule for the specified Amazon WorkMail organization.
    /// </summary>
    public partial class CreateMobileDeviceAccessRuleRequest : AmazonWorkMailRequest
    {
        private string _clientToken;
        private string _description;
        private List<string> _deviceModels = new List<string>();
        private List<string> _deviceOperatingSystems = new List<string>();
        private List<string> _deviceTypes = new List<string>();
        private List<string> _deviceUserAgents = new List<string>();
        private MobileDeviceAccessRuleEffect _effect;
        private string _name;
        private List<string> _notDeviceModels = new List<string>();
        private List<string> _notDeviceOperatingSystems = new List<string>();
        private List<string> _notDeviceTypes = new List<string>();
        private List<string> _notDeviceUserAgents = new List<string>();
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the client request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The rule description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceModels. 
        /// <para>
        /// Device models that the rule will match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DeviceModels
        {
            get { return this._deviceModels; }
            set { this._deviceModels = value; }
        }

        // Check to see if DeviceModels property is set
        internal bool IsSetDeviceModels()
        {
            return this._deviceModels != null && this._deviceModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceOperatingSystems. 
        /// <para>
        /// Device operating systems that the rule will match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DeviceOperatingSystems
        {
            get { return this._deviceOperatingSystems; }
            set { this._deviceOperatingSystems = value; }
        }

        // Check to see if DeviceOperatingSystems property is set
        internal bool IsSetDeviceOperatingSystems()
        {
            return this._deviceOperatingSystems != null && this._deviceOperatingSystems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceTypes. 
        /// <para>
        /// Device types that the rule will match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DeviceTypes
        {
            get { return this._deviceTypes; }
            set { this._deviceTypes = value; }
        }

        // Check to see if DeviceTypes property is set
        internal bool IsSetDeviceTypes()
        {
            return this._deviceTypes != null && this._deviceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeviceUserAgents. 
        /// <para>
        /// Device user agents that the rule will match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DeviceUserAgents
        {
            get { return this._deviceUserAgents; }
            set { this._deviceUserAgents = value; }
        }

        // Check to see if DeviceUserAgents property is set
        internal bool IsSetDeviceUserAgents()
        {
            return this._deviceUserAgents != null && this._deviceUserAgents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the rule when it matches. Allowed values are <code>ALLOW</code> or <code>DENY</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MobileDeviceAccessRuleEffect Effect
        {
            get { return this._effect; }
            set { this._effect = value; }
        }

        // Check to see if Effect property is set
        internal bool IsSetEffect()
        {
            return this._effect != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The rule name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotDeviceModels. 
        /// <para>
        /// Device models that the rule <b>will not</b> match. All other device models will match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotDeviceModels
        {
            get { return this._notDeviceModels; }
            set { this._notDeviceModels = value; }
        }

        // Check to see if NotDeviceModels property is set
        internal bool IsSetNotDeviceModels()
        {
            return this._notDeviceModels != null && this._notDeviceModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotDeviceOperatingSystems. 
        /// <para>
        /// Device operating systems that the rule <b>will not</b> match. All other device operating
        /// systems will match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotDeviceOperatingSystems
        {
            get { return this._notDeviceOperatingSystems; }
            set { this._notDeviceOperatingSystems = value; }
        }

        // Check to see if NotDeviceOperatingSystems property is set
        internal bool IsSetNotDeviceOperatingSystems()
        {
            return this._notDeviceOperatingSystems != null && this._notDeviceOperatingSystems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotDeviceTypes. 
        /// <para>
        /// Device types that the rule <b>will not</b> match. All other device types will match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotDeviceTypes
        {
            get { return this._notDeviceTypes; }
            set { this._notDeviceTypes = value; }
        }

        // Check to see if NotDeviceTypes property is set
        internal bool IsSetNotDeviceTypes()
        {
            return this._notDeviceTypes != null && this._notDeviceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotDeviceUserAgents. 
        /// <para>
        /// Device user agents that the rule <b>will not</b> match. All other device user agents
        /// will match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotDeviceUserAgents
        {
            get { return this._notDeviceUserAgents; }
            set { this._notDeviceUserAgents = value; }
        }

        // Check to see if NotDeviceUserAgents property is set
        internal bool IsSetNotDeviceUserAgents()
        {
            return this._notDeviceUserAgents != null && this._notDeviceUserAgents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The Amazon WorkMail organization under which the rule will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}