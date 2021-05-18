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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociatePhoneNumbersFromVoiceConnectorGroup Request Marshaller
    /// </summary>       
    public class DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller : IMarshaller<IRequest, DisassociatePhoneNumbersFromVoiceConnectorGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociatePhoneNumbersFromVoiceConnectorGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";            
            request.HttpMethod = "POST";

            request.AddSubResource("operation", "disassociate-phone-numbers");
            if (!publicRequest.IsSetVoiceConnectorGroupId())
                throw new AmazonChimeException("Request object does not have required field VoiceConnectorGroupId set");
            request.AddPathResource("{voiceConnectorGroupId}", StringUtils.FromString(publicRequest.VoiceConnectorGroupId));
            request.ResourcePath = "/voice-connector-groups/{voiceConnectorGroupId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetE164PhoneNumbers())
                {
                    context.Writer.WritePropertyName("E164PhoneNumbers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestE164PhoneNumbersListValue in publicRequest.E164PhoneNumbers)
                    {
                            context.Writer.Write(publicRequestE164PhoneNumbersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller _instance = new DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller();        

        internal static DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}