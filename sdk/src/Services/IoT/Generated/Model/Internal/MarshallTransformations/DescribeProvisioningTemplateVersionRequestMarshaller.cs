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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeProvisioningTemplateVersion Request Marshaller
    /// </summary>       
    public class DescribeProvisioningTemplateVersionRequestMarshaller : IMarshaller<IRequest, DescribeProvisioningTemplateVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeProvisioningTemplateVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeProvisioningTemplateVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetTemplateName())
                throw new AmazonIoTException("Request object does not have required field TemplateName set");
            request.AddPathResource("{templateName}", StringUtils.FromString(publicRequest.TemplateName));
            if (!publicRequest.IsSetVersionId())
                throw new AmazonIoTException("Request object does not have required field VersionId set");
            request.AddPathResource("{versionId}", StringUtils.FromInt(publicRequest.VersionId));
            request.ResourcePath = "/provisioning-templates/{templateName}/versions/{versionId}";

            return request;
        }
        private static DescribeProvisioningTemplateVersionRequestMarshaller _instance = new DescribeProvisioningTemplateVersionRequestMarshaller();        

        internal static DescribeProvisioningTemplateVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeProvisioningTemplateVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}