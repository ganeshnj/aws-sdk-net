﻿/*
 *Copyright Amazon.com, Inc.or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 *You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 *
 *or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// <para>The request class for WriteGetObjectReponse operation</para>
    /// </summary>
    public partial class WriteGetObjectResponseRequest : AmazonWebServiceRequest
    {
        private string requestRoute;
        private string requestToken;
        private int? statusCode;
        private string errorCode;
        private string errorMessage;
        private string acceptRanges;
        private string cacheControl;
        private string contentDisposition;
        private string contentEncoding;
        private string contentLanguage;
        private long? contentLength;
        private string contentRange;
        private string contentType;
        private bool? deleteMarker;
        private string eTag;
        private DateTime? expires;
        private string expiration;
        private DateTime? lastModified;
        private int? missingMeta;
        private MetadataCollection metadataCollection = new MetadataCollection();
        private ObjectLockMode objectLockMode;
        private ObjectLockLegalHoldStatus objectLockLegalHoldStatus;
        private DateTime? objectLockRetainUntilDate;
        private int? partsCount;
        private ReplicationStatus replicationStatus;
        private RequestCharged requestCharged;
        private string restore;
        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod sSECustomerAlgorithm;
        private string sSEKMSKeyId;
        private string sSECustomerKeyMD5;
        private S3StorageClass storageClass;
        private int? tagCount;
        private string versionId;
        private bool? bucketKeyEnabled;
        private Stream inputStream;

        /// <summary>
        /// <para>Route prefix to the HTTP URL generated.</para>
        /// </summary>
        public string RequestRoute
        {
            get { return this.requestRoute; }
            set { this.requestRoute = value; }
        }

        internal bool IsSetRequestRoute()
        {
            return !(string.IsNullOrEmpty(this.requestRoute));
        }

        /// <summary>
        /// <para>A single use encrypted token that maps <code>WriteGetObjectResponse</code> to the end user <code>GetObject</code> request.</para>
        /// </summary>
        public string RequestToken
        {
            get { return this.requestToken; }
            set { this.requestToken = value; }
        }

        internal bool IsSetRequestToken()
        {
            return !(string.IsNullOrEmpty(this.requestToken));
        }

        /// <summary>
        /// <para>The integer status code for an HTTP response of a corresponding <code>GetObject</code> request.</para> <para class=\"title\"> <b>Status Codes</b> </para> <ul> <li> <para> <i>200 - OK</i> </para> </li> <li> <para> <i>206 - Partial Content</i> </para> </li> <li> <para> <i>304 - Not Modified</i> </para> </li> <li> <para> <i>400 - Bad Request</i> </para> </li> <li> <para> <i>401 - Unauthorized</i> </para> </li> <li> <para> <i>403 - Forbidden</i> </para> </li> <li> <para> <i>404 - Not Found</i> </para> </li> <li> <para> <i>405 - Method Not Allowed</i> </para> </li> <li> <para> <i>409 - Conflict</i> </para> </li> <li> <para> <i>411 - Length Required</i> </para> </li> <li> <para> <i>412 - Precondition Failed</i> </para> </li> <li> <para> <i>416 - Range Not Satisfiable</i> </para> </li> <li> <para> <i>500 - Internal Server Error</i> </para> </li> <li> <para> <i>503 - Service Unavailable</i> </para> </li> </ul>
        /// </summary>
        public int? StatusCode
        {
            get { return this.statusCode; }
            set { this.statusCode = value; }
        }

        internal bool IsSetStatusCode()
        {
            return this.statusCode.HasValue;
        }

        /// <summary>
        /// <para>A string that uniquely identifies an error condition. Returned in &lt;Code&gt; tag of error XML response for corresponding GetObject call. Cannot be used with successful <code>StatusCode</code> header or when transformed object is provided in body.</para>
        /// </summary>
        public string ErrorCode
        {
            get { return this.errorCode; }
            set { this.errorCode = value; }
        }

        internal bool IsSetErrorCode()
        {
            return !(string.IsNullOrEmpty(this.errorCode));
        }

        /// <summary>
        /// <para>Contains a generic description of the error condition. Returned in &lt;Message&gt; tag of error XML response for corresponding GetObject call. Cannot be used with successful <code>StatusCode</code> header or when transformed object is provided in body.</para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this.errorMessage; }
            set { this.errorMessage = value; }
        }

        internal bool IsSetErrorMessage()
        {
            return !(string.IsNullOrEmpty(this.errorMessage));
        }

        /// <summary>
        /// <para>Indicates that a range of bytes was specified.</para>
        /// </summary>
        public string AcceptRanges
        {
            get { return this.acceptRanges; }
            set { this.acceptRanges = value; }
        }

        internal bool IsSetAcceptRanges()
        {
            return this.acceptRanges != null;
        }

        /// <summary>
        /// <para>Specifies caching behavior along the request/reply chain.</para>
        /// </summary>
        public string CacheControl
        {
            get { return this.cacheControl; }
            set { this.cacheControl = value; }
        }

        internal bool IsSetCacheControl()
        {
            return !(string.IsNullOrEmpty(this.cacheControl));
        }

        /// <summary>
        /// <para>Specifies presentational information for the object.</para>
        /// </summary>
        public string ContentDisposition
        {
            get { return this.contentDisposition; }
            set { this.contentDisposition = value; }
        }

        internal bool IsSetContentDisposition()
        {
            return !(string.IsNullOrEmpty(this.contentDisposition));
        }

        /// <summary>
        /// <para>Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type referenced by the Content-Type header field.</para>
        /// </summary>
        public string ContentEncoding
        {
            get { return this.contentEncoding; }
            set { this.contentEncoding = value; }
        }

        internal bool IsSetContentEncoding()
        {
            return !(string.IsNullOrEmpty(this.contentEncoding));
        }

        /// <summary>
        /// <para>The language the content is in.</para>
        /// </summary>
        public string ContentLanguage
        {
            get { return this.contentLanguage; }
            set { this.contentLanguage = value; }
        }

        internal bool IsSetContentLanguage()
        {
            return !(string.IsNullOrEmpty(this.contentLanguage));
        }

        /// <summary>
        /// <para>The size of the body in bytes.</para>
        /// </summary>
        public long? ContentLength
        {
            get { return this.contentLength; }
            set { this.contentLength = value; }
        }

        internal bool IsSetContentLength()
        {
            return this.contentLength.HasValue;
        }

        /// <summary>
        /// <para>The portion of the object returned in the response.</para>
        /// </summary>
        public string ContentRange
        {
            get { return this.contentRange; }
            set { this.contentRange = value; }
        }

        internal bool IsSetContentRange()
        {
            return !(string.IsNullOrEmpty(this.contentRange));
        }

        /// <summary>
        /// <para>A standard MIME type describing the format of the object data.</para>
        /// </summary>
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        internal bool IsSetContentType()
        {
            return !(string.IsNullOrEmpty(this.contentType));
        }

        /// <summary>
        /// <para>Specifies whether an object stored in Amazon S3 is (<code>true</code>) or is not (<code>false</code>) a delete marker.</para>
        /// </summary>
        public bool DeleteMarker
        {
            get { return this.deleteMarker.GetValueOrDefault(); }
            set { this.deleteMarker = value; }
        }

        internal bool IsSetDeleteMarker()
        {
            return deleteMarker.HasValue;
        }

        /// <summary>
        /// <para>An ETag is an opaque identifier assigned by a web server to a specific version of a resource found at a URL.</para>
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        internal bool IsSetETag()
        {
            return this.eTag != null;
        }

        /// <summary>
        /// <para>The date and time at which the object is no longer cacheable.</para>
        /// </summary>
        public DateTime Expires
        {
            get { return this.expires.GetValueOrDefault(); }
            set { this.expires = value; }
        }

        internal bool IsSetExpires()
        {
            return this.expires.HasValue;
        }

        /// <summary>
        /// <para>If object stored in Amazon S3 expiration is configured (see PUT Bucket lifecycle) it includes expiry-date and rule-id key-value pairs providing object expiration information. The value of the rule-id is URL encoded.</para>
        /// </summary>
        public string Expiration
        {
            get { return this.expiration; }
            set { this.expiration = value; }
        }

        internal bool IsSetExpiration()
        {
            return !(string.IsNullOrEmpty(this.expiration));
        }

        /// <summary>
        /// <para>Date and time the object was last modified.</para>
        /// </summary>
        public DateTime LastModified
        {
            get { return this.lastModified.GetValueOrDefault(); }
            set { this.lastModified = value; }
        }

        internal bool IsSetLastModified()
        {
            return this.lastModified.HasValue;
        }

        /// <summary>
        /// <para>Set to the number of metadata entries not returned in <code>x-amz-meta</code> headers. This can happen if you create metadata using an API like SOAP that supports more flexible metadata than the REST API. For example, using SOAP, you can create metadata whose values are not legal HTTP headers.</para>
        /// </summary>
        public int? MissingMeta
        {
            get { return this.missingMeta; }
            set { this.missingMeta = value; }
        }

        internal bool IsSetMissingMeta()
        {
            return this.missingMeta.HasValue;
        }

        /// <summary>
        /// <para>A map of metadata to store with the object in S3.</para>
        /// </summary>
        public MetadataCollection Metadata
        {
            get
            {
                if (this.metadataCollection == null)
                    this.metadataCollection = new MetadataCollection();
                return this.metadataCollection;
            }
        }

        /// <summary>
        /// <para>Indicates whether an object stored in Amazon S3 has Object Lock enabled. For more information about S3 Object Lock, see <a href=\"https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock.html\">Object Lock</a>.</para>
        /// </summary>
        public ObjectLockMode ObjectLockMode
        {
            get { return this.objectLockMode; }
            set { this.objectLockMode = value; }
        }

        internal bool IsSetObjectLockMode()
        {
            return this.objectLockMode != null;
        }

        /// <summary>
        /// <para>Indicates whether object stored in Amazon S3 has an active legal hold.</para>
        /// </summary>
        public ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus
        {
            get { return this.objectLockLegalHoldStatus; }
            set { this.objectLockLegalHoldStatus = value; }
        }

        internal bool IsSetObjectLockLegalHoldStatus()
        {
            return this.objectLockLegalHoldStatus != null;
        }

        /// <summary>
        /// <para>Date and time when Object Lock is configured to expire.</para>
        /// </summary>
        public DateTime ObjectLockRetainUntilDate
        {
            get { return this.objectLockRetainUntilDate.GetValueOrDefault(); }
            set { this.objectLockRetainUntilDate = value; }
        }

        internal bool IsSetObjectLockRetainUntilDate()
        {
            return this.objectLockRetainUntilDate.HasValue;
        }

        /// <summary>
        /// <para>The count of parts this object has.</para>
        /// </summary>
        public int? PartsCount
        {
            get { return this.partsCount; }
            set { this.partsCount = value; }
        }

        internal bool IsSetPartsCount()
        {
            return this.partsCount.HasValue;
        }

        /// <summary>
        /// <para>Indicates if request involves bucket that is either a source or destination in a Replication rule. For more information about S3 Replication, see <a href=\"https://docs.aws.amazon.com/AmazonS3/latest/userguide/replication.html\">Replication</a>.</para>
        /// </summary>
        public ReplicationStatus ReplicationStatus
        {
            get { return this.replicationStatus; }
            set { this.replicationStatus = value; }
        }

        internal bool IsSetReplicationStatus()
        {
            return ReplicationStatus != null;
        }

        /// <summary>
        /// <para>If present, indicates that the requester was successfully charged for the request.</para>
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this.requestCharged; }
            set { this.requestCharged = value; }
        }

        internal bool IsSetRequestCharged()
        {
            return requestCharged != null;
        }

        /// <summary>
        /// <para>Provides information about object restoration operation and expiration time of the restored object copy.</para>
        /// </summary>
        public string Restore
        {
            get { return this.restore; }
            set { this.restore = value; }
        }

        internal bool IsSetRestore()
        {
            return !(string.IsNullOrEmpty(this.restore));
        }

        /// <summary>
        /// <para>The server-side encryption algorithm used when storing requested object in Amazon S3 (for example, AES256, aws:kms).</para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryption != null && this.serverSideEncryption != ServerSideEncryptionMethod.None;
        }

        /// <summary>
        /// <para>Encryption algorithm used if server-side encryption with a customer-provided encryption key was specified for object stored in Amazon S3.</para>
        /// </summary>
        public ServerSideEncryptionCustomerMethod SSECustomerAlgorithm
        {
            get { return this.sSECustomerAlgorithm; }
            set { this.sSECustomerAlgorithm = value; }
        }

        internal bool IsSetSSECustomerAlgorithm()
        {
            return this.sSECustomerAlgorithm != null && this.sSECustomerAlgorithm != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// <para>If present, specifies the ID of the AWS Key Management Service (AWS KMS) symmetric customer managed customer master key (CMK) that was used for stored in Amazon S3 object.</para>
        /// </summary>
        public string SSEKMSKeyId
        {
            get { return this.sSEKMSKeyId; }
            set { this.sSEKMSKeyId = value; }
        }

        internal bool IsSetSSEKMSKeyId()
        {
            return !System.String.IsNullOrEmpty(this.sSEKMSKeyId);
        }

        /// <summary>
        /// <para>128-bit MD5 digest of customer-provided encryption key used in Amazon S3 to encrypt data stored in S3. For more information, see <a href=\"https://docs.aws.amazon.com/AmazonS3/latest/userguide/ServerSideEncryptionCustomerKeys.html\">Server-Side Encryption (Using Customer-Provided Encryption Keys</a>.</para>
        /// </summary>
        public string SSECustomerKeyMD5
        {
            get { return this.sSECustomerKeyMD5; }
            set { this.sSECustomerKeyMD5 = value; }
        }

        internal bool IsSetSSECustomerKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.sSECustomerKeyMD5);
        }

        /// <summary>
        /// <para> The class of storage used to store object in Amazon S3.</para>
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }

        /// <summary>
        /// <para>The number of tags, if any, on the object.</para>
        /// </summary>
        public int? TagCount
        {
            get { return this.tagCount; }
            set { this.tagCount = value; }
        }

        internal bool IsSetTagCount()
        {
            return this.tagCount.HasValue;
        }

        /// <summary>
        /// <para>VersionId used to reference a specific version of the object.</para>
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        internal bool IsSetVersionId()
        {
            return !(string.IsNullOrEmpty(this.versionId));
        }

        /// <summary>
        /// <para>Indicates whether the object stored in Amazon S3 uses a S3 Bucket Key for server-side encryption with AWS KMS (SSE-KMS).</para>
        /// </summary>
        public bool BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled.GetValueOrDefault(); }
            set { this.bucketKeyEnabled = value; }
        }

        internal bool IsSetBucketKeyEnabled()
        {
            return bucketKeyEnabled.HasValue;
        }

        /// <summary>
        /// <para>The object data</para>.
        /// </summary>
        public Stream Body
        {
            get { return this.inputStream; }
            set { this.inputStream = value; }
        }

        internal bool IsSetInputStream()
        {
            return this.inputStream != null;
        }
    }
}
