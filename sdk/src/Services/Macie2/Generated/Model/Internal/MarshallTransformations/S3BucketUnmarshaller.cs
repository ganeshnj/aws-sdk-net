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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3Bucket Object
    /// </summary>  
    public class S3BucketUnmarshaller : IUnmarshaller<S3Bucket, XmlUnmarshallerContext>, IUnmarshaller<S3Bucket, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        S3Bucket IUnmarshaller<S3Bucket, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3Bucket Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            S3Bucket unmarshalledObject = new S3Bucket();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allowsUnencryptedObjectUploads", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AllowsUnencryptedObjectUploads = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultServerSideEncryption", targetDepth))
                {
                    var unmarshaller = ServerSideEncryptionUnmarshaller.Instance;
                    unmarshalledObject.DefaultServerSideEncryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("owner", targetDepth))
                {
                    var unmarshaller = S3BucketOwnerUnmarshaller.Instance;
                    unmarshalledObject.Owner = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publicAccess", targetDepth))
                {
                    var unmarshaller = BucketPublicAccessUnmarshaller.Instance;
                    unmarshalledObject.PublicAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyValuePair, KeyValuePairUnmarshaller>(KeyValuePairUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static S3BucketUnmarshaller _instance = new S3BucketUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3BucketUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}