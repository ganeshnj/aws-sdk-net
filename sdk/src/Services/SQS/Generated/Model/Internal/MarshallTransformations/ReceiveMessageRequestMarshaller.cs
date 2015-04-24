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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReceiveMessage Request Marshaller
    /// </summary>       
    public class ReceiveMessageRequestMarshaller : IMarshaller<IRequest, ReceiveMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReceiveMessageRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReceiveMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            request.Parameters.Add("Action", "ReceiveMessage");
            request.Parameters.Add("Version", "2012-11-05");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttributeNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.AttributeNames)
                    {
                        request.Parameters.Add("AttributeName" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetMaxNumberOfMessages())
                {
                    request.Parameters.Add("MaxNumberOfMessages", StringUtils.FromInt(publicRequest.MaxNumberOfMessages));
                }
                if(publicRequest.IsSetMessageAttributeNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.MessageAttributeNames)
                    {
                        request.Parameters.Add("MessageAttributeName" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetQueueUrl())
                {
                    request.Parameters.Add("QueueUrl", StringUtils.FromString(publicRequest.QueueUrl));
                }
                if(publicRequest.IsSetVisibilityTimeout())
                {
                    request.Parameters.Add("VisibilityTimeout", StringUtils.FromInt(publicRequest.VisibilityTimeout));
                }
                if(publicRequest.IsSetWaitTimeSeconds())
                {
                    request.Parameters.Add("WaitTimeSeconds", StringUtils.FromInt(publicRequest.WaitTimeSeconds));
                }
            }
            return request;
        }
    }
}