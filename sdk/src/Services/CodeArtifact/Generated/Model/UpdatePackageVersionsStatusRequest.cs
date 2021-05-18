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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePackageVersionsStatus operation.
    /// Updates the status of one or more versions of a package.
    /// </summary>
    public partial class UpdatePackageVersionsStatusRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private PackageVersionStatus _expectedStatus;
        private PackageFormat _format;
        private string _awsNamespace;
        private string _package;
        private string _repository;
        private PackageVersionStatus _targetStatus;
        private Dictionary<string, string> _versionRevisions = new Dictionary<string, string>();
        private List<string> _versions = new List<string>();

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the repository that contains the package versions
        /// with a status to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the AWS account that owns the domain. It does not
        /// include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainOwner
        {
            get { return this._domainOwner; }
            set { this._domainOwner = value; }
        }

        // Check to see if DomainOwner property is set
        internal bool IsSetDomainOwner()
        {
            return this._domainOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedStatus. 
        /// <para>
        ///  The package version’s expected status before it is updated. If <code>expectedStatus</code>
        /// is provided, the package version's status is updated only if its status at the time
        /// <code>UpdatePackageVersionsStatus</code> is called matches <code>expectedStatus</code>.
        /// 
        /// </para>
        /// </summary>
        public PackageVersionStatus ExpectedStatus
        {
            get { return this._expectedStatus; }
            set { this._expectedStatus = value; }
        }

        // Check to see if ExpectedStatus property is set
        internal bool IsSetExpectedStatus()
        {
            return this._expectedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  A format that specifies the type of the package with the statuses to update. The
        /// valid values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>npm</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pypi</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>maven</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        ///  The namespace of the package. The package component that specifies its namespace
        /// depends on its type. For example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package is its <code>groupId</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm package is its <code>scope</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  A Python package does not contain a corresponding component, so Python packages do
        /// not have a namespace. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Package. 
        /// <para>
        ///  The name of the package with the version statuses to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Package
        {
            get { return this._package; }
            set { this._package = value; }
        }

        // Check to see if Package property is set
        internal bool IsSetPackage()
        {
            return this._package != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The repository that contains the package versions with the status you want to update.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property TargetStatus. 
        /// <para>
        ///  The status you want to change the package version status to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageVersionStatus TargetStatus
        {
            get { return this._targetStatus; }
            set { this._targetStatus = value; }
        }

        // Check to see if TargetStatus property is set
        internal bool IsSetTargetStatus()
        {
            return this._targetStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VersionRevisions. 
        /// <para>
        ///  A map of package versions and package version revisions. The map <code>key</code>
        /// is the package version (for example, <code>3.5.2</code>), and the map <code>value</code>
        /// is the package version revision. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> VersionRevisions
        {
            get { return this._versionRevisions; }
            set { this._versionRevisions = value; }
        }

        // Check to see if VersionRevisions property is set
        internal bool IsSetVersionRevisions()
        {
            return this._versionRevisions != null && this._versionRevisions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        ///  An array of strings that specify the versions of the package with the statuses to
        /// update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public List<string> Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null && this._versions.Count > 0; 
        }

    }
}