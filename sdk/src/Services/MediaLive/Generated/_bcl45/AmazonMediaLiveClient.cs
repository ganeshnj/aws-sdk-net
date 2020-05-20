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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaLive.Model;
using Amazon.MediaLive.Model.Internal.MarshallTransformations;
using Amazon.MediaLive.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaLive
{
    /// <summary>
    /// Implementation for accessing MediaLive
    ///
    /// API for AWS Elemental MediaLive
    /// </summary>
    public partial class AmazonMediaLiveClient : AmazonServiceClient, IAmazonMediaLive
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaLiveMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaLiveClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonMediaLiveClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaLiveConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaLiveClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaLiveConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonMediaLiveClient Configuration Object</param>
        public AmazonMediaLiveClient(AmazonMediaLiveConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaLiveClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaLiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaLiveClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaLiveConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Credentials and an
        /// AmazonMediaLiveClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaLiveClient Configuration Object</param>
        public AmazonMediaLiveClient(AWSCredentials credentials, AmazonMediaLiveConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaLiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaLiveConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaLiveClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaLiveClient Configuration Object</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaLiveConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaLiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaLiveConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaLiveClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaLiveClient Configuration Object</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaLiveConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  BatchUpdateSchedule


        /// <summary>
        /// Update a channel schedule
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateSchedule service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchUpdateSchedule">REST API Reference for BatchUpdateSchedule Operation</seealso>
        public virtual BatchUpdateScheduleResponse BatchUpdateSchedule(BatchUpdateScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateScheduleResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateScheduleResponse>(request, options);
        }


        /// <summary>
        /// Update a channel schedule
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchUpdateSchedule">REST API Reference for BatchUpdateSchedule Operation</seealso>
        public virtual Task<BatchUpdateScheduleResponse> BatchUpdateScheduleAsync(BatchUpdateScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateScheduleResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchUpdateScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Creates a new channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }


        /// <summary>
        /// Creates a new channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInput


        /// <summary>
        /// Create an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInput service method.</param>
        /// 
        /// <returns>The response from the CreateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual CreateInputResponse CreateInput(CreateInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputResponseUnmarshaller.Instance;

            return Invoke<CreateInputResponse>(request, options);
        }


        /// <summary>
        /// Create an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual Task<CreateInputResponse> CreateInputAsync(CreateInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInputSecurityGroup


        /// <summary>
        /// Creates a Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        public virtual CreateInputSecurityGroupResponse CreateInputSecurityGroup(CreateInputSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateInputSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Creates a Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        public virtual Task<CreateInputSecurityGroupResponse> CreateInputSecurityGroupAsync(CreateInputSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInputSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMultiplex


        /// <summary>
        /// Create a new multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiplex service method.</param>
        /// 
        /// <returns>The response from the CreateMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplex">REST API Reference for CreateMultiplex Operation</seealso>
        public virtual CreateMultiplexResponse CreateMultiplex(CreateMultiplexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultiplexResponseUnmarshaller.Instance;

            return Invoke<CreateMultiplexResponse>(request, options);
        }


        /// <summary>
        /// Create a new multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiplex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplex">REST API Reference for CreateMultiplex Operation</seealso>
        public virtual Task<CreateMultiplexResponse> CreateMultiplexAsync(CreateMultiplexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultiplexResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMultiplexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMultiplexProgram


        /// <summary>
        /// Create a new program in the multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiplexProgram service method.</param>
        /// 
        /// <returns>The response from the CreateMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplexProgram">REST API Reference for CreateMultiplexProgram Operation</seealso>
        public virtual CreateMultiplexProgramResponse CreateMultiplexProgram(CreateMultiplexProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMultiplexProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultiplexProgramResponseUnmarshaller.Instance;

            return Invoke<CreateMultiplexProgramResponse>(request, options);
        }


        /// <summary>
        /// Create a new program in the multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiplexProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplexProgram">REST API Reference for CreateMultiplexProgram Operation</seealso>
        public virtual Task<CreateMultiplexProgramResponse> CreateMultiplexProgramAsync(CreateMultiplexProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMultiplexProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultiplexProgramResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMultiplexProgramResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Create tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }


        /// <summary>
        /// Create tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Starts deletion of channel. The associated outputs are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }


        /// <summary>
        /// Starts deletion of channel. The associated outputs are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInput


        /// <summary>
        /// Deletes the input end point
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput service method.</param>
        /// 
        /// <returns>The response from the DeleteInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual DeleteInputResponse DeleteInput(DeleteInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputResponseUnmarshaller.Instance;

            return Invoke<DeleteInputResponse>(request, options);
        }


        /// <summary>
        /// Deletes the input end point
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual Task<DeleteInputResponse> DeleteInputAsync(DeleteInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInputSecurityGroup


        /// <summary>
        /// Deletes an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        public virtual DeleteInputSecurityGroupResponse DeleteInputSecurityGroup(DeleteInputSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteInputSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        public virtual Task<DeleteInputSecurityGroupResponse> DeleteInputSecurityGroupAsync(DeleteInputSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInputSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMultiplex


        /// <summary>
        /// Delete a multiplex. The multiplex must be idle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiplex service method.</param>
        /// 
        /// <returns>The response from the DeleteMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplex">REST API Reference for DeleteMultiplex Operation</seealso>
        public virtual DeleteMultiplexResponse DeleteMultiplex(DeleteMultiplexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMultiplexResponseUnmarshaller.Instance;

            return Invoke<DeleteMultiplexResponse>(request, options);
        }


        /// <summary>
        /// Delete a multiplex. The multiplex must be idle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiplex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplex">REST API Reference for DeleteMultiplex Operation</seealso>
        public virtual Task<DeleteMultiplexResponse> DeleteMultiplexAsync(DeleteMultiplexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMultiplexResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMultiplexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMultiplexProgram


        /// <summary>
        /// Delete a program from a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiplexProgram service method.</param>
        /// 
        /// <returns>The response from the DeleteMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplexProgram">REST API Reference for DeleteMultiplexProgram Operation</seealso>
        public virtual DeleteMultiplexProgramResponse DeleteMultiplexProgram(DeleteMultiplexProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMultiplexProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMultiplexProgramResponseUnmarshaller.Instance;

            return Invoke<DeleteMultiplexProgramResponse>(request, options);
        }


        /// <summary>
        /// Delete a program from a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiplexProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplexProgram">REST API Reference for DeleteMultiplexProgram Operation</seealso>
        public virtual Task<DeleteMultiplexProgramResponse> DeleteMultiplexProgramAsync(DeleteMultiplexProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMultiplexProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMultiplexProgramResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMultiplexProgramResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReservation


        /// <summary>
        /// Delete an expired reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReservation service method.</param>
        /// 
        /// <returns>The response from the DeleteReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteReservation">REST API Reference for DeleteReservation Operation</seealso>
        public virtual DeleteReservationResponse DeleteReservation(DeleteReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReservationResponseUnmarshaller.Instance;

            return Invoke<DeleteReservationResponse>(request, options);
        }


        /// <summary>
        /// Delete an expired reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteReservation">REST API Reference for DeleteReservation Operation</seealso>
        public virtual Task<DeleteReservationResponse> DeleteReservationAsync(DeleteReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReservationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSchedule


        /// <summary>
        /// Delete all schedule actions on a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        public virtual DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduleResponse>(request, options);
        }


        /// <summary>
        /// Delete all schedule actions on a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        public virtual Task<DeleteScheduleResponse> DeleteScheduleAsync(DeleteScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Removes tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }


        /// <summary>
        /// Removes tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannel


        /// <summary>
        /// Gets details about a channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }


        /// <summary>
        /// Gets details about a channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInput


        /// <summary>
        /// Produces details about an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput service method.</param>
        /// 
        /// <returns>The response from the DescribeInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual DescribeInputResponse DescribeInput(DescribeInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputResponseUnmarshaller.Instance;

            return Invoke<DescribeInputResponse>(request, options);
        }


        /// <summary>
        /// Produces details about an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual Task<DescribeInputResponse> DescribeInputAsync(DescribeInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInputDevice


        /// <summary>
        /// Gets the details for the input device
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputDevice">REST API Reference for DescribeInputDevice Operation</seealso>
        public virtual DescribeInputDeviceResponse DescribeInputDevice(DescribeInputDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeInputDeviceResponse>(request, options);
        }


        /// <summary>
        /// Gets the details for the input device
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputDevice">REST API Reference for DescribeInputDevice Operation</seealso>
        public virtual Task<DescribeInputDeviceResponse> DescribeInputDeviceAsync(DescribeInputDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputDeviceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInputDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInputSecurityGroup


        /// <summary>
        /// Produces a summary of an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        public virtual DescribeInputSecurityGroupResponse DescribeInputSecurityGroup(DescribeInputSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeInputSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Produces a summary of an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        public virtual Task<DescribeInputSecurityGroupResponse> DescribeInputSecurityGroupAsync(DescribeInputSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInputSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMultiplex


        /// <summary>
        /// Gets details about a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiplex service method.</param>
        /// 
        /// <returns>The response from the DescribeMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplex">REST API Reference for DescribeMultiplex Operation</seealso>
        public virtual DescribeMultiplexResponse DescribeMultiplex(DescribeMultiplexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMultiplexResponseUnmarshaller.Instance;

            return Invoke<DescribeMultiplexResponse>(request, options);
        }


        /// <summary>
        /// Gets details about a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiplex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplex">REST API Reference for DescribeMultiplex Operation</seealso>
        public virtual Task<DescribeMultiplexResponse> DescribeMultiplexAsync(DescribeMultiplexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMultiplexResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMultiplexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMultiplexProgram


        /// <summary>
        /// Get the details for a program in a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiplexProgram service method.</param>
        /// 
        /// <returns>The response from the DescribeMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplexProgram">REST API Reference for DescribeMultiplexProgram Operation</seealso>
        public virtual DescribeMultiplexProgramResponse DescribeMultiplexProgram(DescribeMultiplexProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMultiplexProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMultiplexProgramResponseUnmarshaller.Instance;

            return Invoke<DescribeMultiplexProgramResponse>(request, options);
        }


        /// <summary>
        /// Get the details for a program in a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiplexProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplexProgram">REST API Reference for DescribeMultiplexProgram Operation</seealso>
        public virtual Task<DescribeMultiplexProgramResponse> DescribeMultiplexProgramAsync(DescribeMultiplexProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMultiplexProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMultiplexProgramResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMultiplexProgramResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOffering


        /// <summary>
        /// Get details for an offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering service method.</param>
        /// 
        /// <returns>The response from the DescribeOffering service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        public virtual DescribeOfferingResponse DescribeOffering(DescribeOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOfferingResponseUnmarshaller.Instance;

            return Invoke<DescribeOfferingResponse>(request, options);
        }


        /// <summary>
        /// Get details for an offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOffering service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        public virtual Task<DescribeOfferingResponse> DescribeOfferingAsync(DescribeOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOfferingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservation


        /// <summary>
        /// Get details for a reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation service method.</param>
        /// 
        /// <returns>The response from the DescribeReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        public virtual DescribeReservationResponse DescribeReservation(DescribeReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservationResponseUnmarshaller.Instance;

            return Invoke<DescribeReservationResponse>(request, options);
        }


        /// <summary>
        /// Get details for a reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        public virtual Task<DescribeReservationResponse> DescribeReservationAsync(DescribeReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSchedule


        /// <summary>
        /// Get a channel schedule
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        public virtual DescribeScheduleResponse DescribeSchedule(DescribeScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduleResponse>(request, options);
        }


        /// <summary>
        /// Get a channel schedule
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        public virtual Task<DescribeScheduleResponse> DescribeScheduleAsync(DescribeScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Produces list of channels that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }


        /// <summary>
        /// Produces list of channels that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInputDevices


        /// <summary>
        /// List input devices
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputDevices service method.</param>
        /// 
        /// <returns>The response from the ListInputDevices service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputDevices">REST API Reference for ListInputDevices Operation</seealso>
        public virtual ListInputDevicesResponse ListInputDevices(ListInputDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputDevicesResponseUnmarshaller.Instance;

            return Invoke<ListInputDevicesResponse>(request, options);
        }


        /// <summary>
        /// List input devices
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInputDevices service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputDevices">REST API Reference for ListInputDevices Operation</seealso>
        public virtual Task<ListInputDevicesResponse> ListInputDevicesAsync(ListInputDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputDevicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInputDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInputs


        /// <summary>
        /// Produces list of inputs that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputs service method.</param>
        /// 
        /// <returns>The response from the ListInputs service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual ListInputsResponse ListInputs(ListInputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputsResponseUnmarshaller.Instance;

            return Invoke<ListInputsResponse>(request, options);
        }


        /// <summary>
        /// Produces list of inputs that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInputs service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual Task<ListInputsResponse> ListInputsAsync(ListInputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInputSecurityGroups


        /// <summary>
        /// Produces a list of Input Security Groups for an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the ListInputSecurityGroups service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        public virtual ListInputSecurityGroupsResponse ListInputSecurityGroups(ListInputSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInputSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Produces a list of Input Security Groups for an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInputSecurityGroups service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        public virtual Task<ListInputSecurityGroupsResponse> ListInputSecurityGroupsAsync(ListInputSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputSecurityGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInputSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMultiplexes


        /// <summary>
        /// Retrieve a list of the existing multiplexes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexes service method.</param>
        /// 
        /// <returns>The response from the ListMultiplexes service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexes">REST API Reference for ListMultiplexes Operation</seealso>
        public virtual ListMultiplexesResponse ListMultiplexes(ListMultiplexesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultiplexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultiplexesResponseUnmarshaller.Instance;

            return Invoke<ListMultiplexesResponse>(request, options);
        }


        /// <summary>
        /// Retrieve a list of the existing multiplexes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultiplexes service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexes">REST API Reference for ListMultiplexes Operation</seealso>
        public virtual Task<ListMultiplexesResponse> ListMultiplexesAsync(ListMultiplexesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultiplexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultiplexesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMultiplexesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMultiplexPrograms


        /// <summary>
        /// List the programs that currently exist for a specific multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexPrograms service method.</param>
        /// 
        /// <returns>The response from the ListMultiplexPrograms service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexPrograms">REST API Reference for ListMultiplexPrograms Operation</seealso>
        public virtual ListMultiplexProgramsResponse ListMultiplexPrograms(ListMultiplexProgramsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultiplexProgramsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultiplexProgramsResponseUnmarshaller.Instance;

            return Invoke<ListMultiplexProgramsResponse>(request, options);
        }


        /// <summary>
        /// List the programs that currently exist for a specific multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexPrograms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultiplexPrograms service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexPrograms">REST API Reference for ListMultiplexPrograms Operation</seealso>
        public virtual Task<ListMultiplexProgramsResponse> ListMultiplexProgramsAsync(ListMultiplexProgramsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultiplexProgramsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultiplexProgramsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMultiplexProgramsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOfferings


        /// <summary>
        /// List offerings available for purchase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual ListOfferingsResponse ListOfferings(ListOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingsResponse>(request, options);
        }


        /// <summary>
        /// List offerings available for purchase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual Task<ListOfferingsResponse> ListOfferingsAsync(ListOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReservations


        /// <summary>
        /// List purchased reservations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
        /// 
        /// <returns>The response from the ListReservations service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual ListReservationsResponse ListReservations(ListReservationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return Invoke<ListReservationsResponse>(request, options);
        }


        /// <summary>
        /// List purchased reservations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReservations service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual Task<ListReservationsResponse> ListReservationsAsync(ListReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListReservationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Produces list of tags that have been created for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Produces list of tags that have been created for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseOffering


        /// <summary>
        /// Purchase an offering and create a reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseOfferingResponse>(request, options);
        }


        /// <summary>
        /// Purchase an offering and create a reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual Task<PurchaseOfferingResponse> PurchaseOfferingAsync(PurchaseOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PurchaseOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartChannel


        /// <summary>
        /// Starts an existing channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual StartChannelResponse StartChannel(StartChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChannelResponseUnmarshaller.Instance;

            return Invoke<StartChannelResponse>(request, options);
        }


        /// <summary>
        /// Starts an existing channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual Task<StartChannelResponse> StartChannelAsync(StartChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMultiplex


        /// <summary>
        /// Start (run) the multiplex. Starting the multiplex does not start the channels. You
        /// must explicitly start each channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMultiplex service method.</param>
        /// 
        /// <returns>The response from the StartMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartMultiplex">REST API Reference for StartMultiplex Operation</seealso>
        public virtual StartMultiplexResponse StartMultiplex(StartMultiplexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMultiplexResponseUnmarshaller.Instance;

            return Invoke<StartMultiplexResponse>(request, options);
        }


        /// <summary>
        /// Start (run) the multiplex. Starting the multiplex does not start the channels. You
        /// must explicitly start each channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMultiplex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartMultiplex">REST API Reference for StartMultiplex Operation</seealso>
        public virtual Task<StartMultiplexResponse> StartMultiplexAsync(StartMultiplexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMultiplexResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMultiplexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopChannel


        /// <summary>
        /// Stops a running channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual StopChannelResponse StopChannel(StopChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopChannelResponseUnmarshaller.Instance;

            return Invoke<StopChannelResponse>(request, options);
        }


        /// <summary>
        /// Stops a running channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual Task<StopChannelResponse> StopChannelAsync(StopChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopMultiplex


        /// <summary>
        /// Stops a running multiplex. If the multiplex isn't running, this action has no effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMultiplex service method.</param>
        /// 
        /// <returns>The response from the StopMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopMultiplex">REST API Reference for StopMultiplex Operation</seealso>
        public virtual StopMultiplexResponse StopMultiplex(StopMultiplexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMultiplexResponseUnmarshaller.Instance;

            return Invoke<StopMultiplexResponse>(request, options);
        }


        /// <summary>
        /// Stops a running multiplex. If the multiplex isn't running, this action has no effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMultiplex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopMultiplex">REST API Reference for StopMultiplex Operation</seealso>
        public virtual Task<StopMultiplexResponse> StopMultiplexAsync(StopMultiplexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMultiplexResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopMultiplexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }


        /// <summary>
        /// Updates a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannelClass


        /// <summary>
        /// Changes the class of the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelClass service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelClass service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannelClass">REST API Reference for UpdateChannelClass Operation</seealso>
        public virtual UpdateChannelClassResponse UpdateChannelClass(UpdateChannelClassRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelClassRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelClassResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelClassResponse>(request, options);
        }


        /// <summary>
        /// Changes the class of the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelClass service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannelClass service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannelClass">REST API Reference for UpdateChannelClass Operation</seealso>
        public virtual Task<UpdateChannelClassResponse> UpdateChannelClassAsync(UpdateChannelClassRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelClassRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelClassResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateChannelClassResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInput


        /// <summary>
        /// Updates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput service method.</param>
        /// 
        /// <returns>The response from the UpdateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual UpdateInputResponse UpdateInput(UpdateInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputResponseUnmarshaller.Instance;

            return Invoke<UpdateInputResponse>(request, options);
        }


        /// <summary>
        /// Updates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual Task<UpdateInputResponse> UpdateInputAsync(UpdateInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInputDevice


        /// <summary>
        /// Updates the parameters for the input device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputDevice">REST API Reference for UpdateInputDevice Operation</seealso>
        public virtual UpdateInputDeviceResponse UpdateInputDevice(UpdateInputDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateInputDeviceResponse>(request, options);
        }


        /// <summary>
        /// Updates the parameters for the input device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputDevice">REST API Reference for UpdateInputDevice Operation</seealso>
        public virtual Task<UpdateInputDeviceResponse> UpdateInputDeviceAsync(UpdateInputDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputDeviceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateInputDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInputSecurityGroup


        /// <summary>
        /// Update an Input Security Group's Whilelists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputSecurityGroup">REST API Reference for UpdateInputSecurityGroup Operation</seealso>
        public virtual UpdateInputSecurityGroupResponse UpdateInputSecurityGroup(UpdateInputSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateInputSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Update an Input Security Group's Whilelists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputSecurityGroup">REST API Reference for UpdateInputSecurityGroup Operation</seealso>
        public virtual Task<UpdateInputSecurityGroupResponse> UpdateInputSecurityGroupAsync(UpdateInputSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateInputSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMultiplex


        /// <summary>
        /// Updates a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMultiplex service method.</param>
        /// 
        /// <returns>The response from the UpdateMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplex">REST API Reference for UpdateMultiplex Operation</seealso>
        public virtual UpdateMultiplexResponse UpdateMultiplex(UpdateMultiplexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMultiplexResponseUnmarshaller.Instance;

            return Invoke<UpdateMultiplexResponse>(request, options);
        }


        /// <summary>
        /// Updates a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMultiplex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplex">REST API Reference for UpdateMultiplex Operation</seealso>
        public virtual Task<UpdateMultiplexResponse> UpdateMultiplexAsync(UpdateMultiplexRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMultiplexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMultiplexResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMultiplexResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMultiplexProgram


        /// <summary>
        /// Update a program in a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMultiplexProgram service method.</param>
        /// 
        /// <returns>The response from the UpdateMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplexProgram">REST API Reference for UpdateMultiplexProgram Operation</seealso>
        public virtual UpdateMultiplexProgramResponse UpdateMultiplexProgram(UpdateMultiplexProgramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMultiplexProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMultiplexProgramResponseUnmarshaller.Instance;

            return Invoke<UpdateMultiplexProgramResponse>(request, options);
        }


        /// <summary>
        /// Update a program in a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMultiplexProgram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplexProgram">REST API Reference for UpdateMultiplexProgram Operation</seealso>
        public virtual Task<UpdateMultiplexProgramResponse> UpdateMultiplexProgramAsync(UpdateMultiplexProgramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMultiplexProgramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMultiplexProgramResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMultiplexProgramResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateReservation


        /// <summary>
        /// Update reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReservation service method.</param>
        /// 
        /// <returns>The response from the UpdateReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateReservation">REST API Reference for UpdateReservation Operation</seealso>
        public virtual UpdateReservationResponse UpdateReservation(UpdateReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReservationResponseUnmarshaller.Instance;

            return Invoke<UpdateReservationResponse>(request, options);
        }


        /// <summary>
        /// Update reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateReservation">REST API Reference for UpdateReservation Operation</seealso>
        public virtual Task<UpdateReservationResponse> UpdateReservationAsync(UpdateReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReservationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}