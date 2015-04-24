/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeVault operation
    /// </summary>  
    public class DescribeVaultResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeVaultResponse response = new DescribeVaultResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller.Instance;
                    response.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastInventoryDate", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller.Instance;
                    response.LastInventoryDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfArchives", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.NumberOfArchives = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.SizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VaultARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VaultARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VaultName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VaultName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
            {
                return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameterValueException"))
            {
                return new MissingParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
            {
                return new ServiceUnavailableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonGlacierException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeVaultResponseUnmarshaller _instance = new DescribeVaultResponseUnmarshaller();        

        internal static DescribeVaultResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeVaultResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}