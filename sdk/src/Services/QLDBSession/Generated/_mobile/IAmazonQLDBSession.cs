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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QLDBSession.Model;

namespace Amazon.QLDBSession
{
    /// <summary>
    /// Interface for accessing QLDBSession
    ///
    /// The transactional data APIs for Amazon QLDB
    /// </summary>
    public partial interface IAmazonQLDBSession : IAmazonService, IDisposable
    {
                
        #region  SendCommand



        /// <summary>
        /// Sends a command to an Amazon QLDB ledger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by QLDBSession.</returns>
        /// <exception cref="Amazon.QLDBSession.Model.BadRequestException">
        /// Returned if the request is malformed or contains an error such as an invalid parameter
        /// value or a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.InvalidSessionException">
        /// Returned if the session doesn't exist anymore because it timed-out or expired.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.LimitExceededException">
        /// Returned if a resource limit such as number of active sessions is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.OccConflictException">
        /// Returned when a transaction cannot be written to the journal due to a failure in the
        /// verification phase of Optimistic Concurrency Control.
        /// </exception>
        /// <exception cref="Amazon.QLDBSession.Model.RateExceededException">
        /// Returned when the rate of requests exceeds the allowed throughput.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qldb-session-2019-07-11/SendCommand">REST API Reference for SendCommand Operation</seealso>
        Task<SendCommandResponse> SendCommandAsync(SendCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}