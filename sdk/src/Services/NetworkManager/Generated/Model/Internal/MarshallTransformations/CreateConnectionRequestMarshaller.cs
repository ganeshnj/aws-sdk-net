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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConnection Request Marshaller
    /// </summary>       
    public class CreateConnectionRequestMarshaller : IMarshaller<IRequest, CreateConnectionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConnectionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateConnectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetGlobalNetworkId())
                throw new AmazonNetworkManagerException("Request object does not have required field GlobalNetworkId set");
            request.AddPathResource("{globalNetworkId}", StringUtils.FromString(publicRequest.GlobalNetworkId));
            request.ResourcePath = "/global-networks/{globalNetworkId}/connections";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConnectedDeviceId())
                {
                    context.Writer.WritePropertyName("ConnectedDeviceId");
                    context.Writer.Write(publicRequest.ConnectedDeviceId);
                }

                if(publicRequest.IsSetConnectedLinkId())
                {
                    context.Writer.WritePropertyName("ConnectedLinkId");
                    context.Writer.Write(publicRequest.ConnectedLinkId);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDeviceId())
                {
                    context.Writer.WritePropertyName("DeviceId");
                    context.Writer.Write(publicRequest.DeviceId);
                }

                if(publicRequest.IsSetLinkId())
                {
                    context.Writer.WritePropertyName("LinkId");
                    context.Writer.Write(publicRequest.LinkId);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateConnectionRequestMarshaller _instance = new CreateConnectionRequestMarshaller();        

        internal static CreateConnectionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConnectionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}