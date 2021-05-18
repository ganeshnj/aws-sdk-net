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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetPrincipalTagAttributeMap Request Marshaller
    /// </summary>       
    public class SetPrincipalTagAttributeMapRequestMarshaller : IMarshaller<IRequest, SetPrincipalTagAttributeMapRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetPrincipalTagAttributeMapRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SetPrincipalTagAttributeMapRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentity");
            string target = "AWSCognitoIdentityService.SetPrincipalTagAttributeMap";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-06-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIdentityPoolId())
                {
                    context.Writer.WritePropertyName("IdentityPoolId");
                    context.Writer.Write(publicRequest.IdentityPoolId);
                }

                if(publicRequest.IsSetIdentityProviderName())
                {
                    context.Writer.WritePropertyName("IdentityProviderName");
                    context.Writer.Write(publicRequest.IdentityProviderName);
                }

                if(publicRequest.IsSetPrincipalTags())
                {
                    context.Writer.WritePropertyName("PrincipalTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestPrincipalTagsKvp in publicRequest.PrincipalTags)
                    {
                        context.Writer.WritePropertyName(publicRequestPrincipalTagsKvp.Key);
                        var publicRequestPrincipalTagsValue = publicRequestPrincipalTagsKvp.Value;

                            context.Writer.Write(publicRequestPrincipalTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUseDefaults())
                {
                    context.Writer.WritePropertyName("UseDefaults");
                    context.Writer.Write(publicRequest.UseDefaults);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SetPrincipalTagAttributeMapRequestMarshaller _instance = new SetPrincipalTagAttributeMapRequestMarshaller();        

        internal static SetPrincipalTagAttributeMapRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetPrincipalTagAttributeMapRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}