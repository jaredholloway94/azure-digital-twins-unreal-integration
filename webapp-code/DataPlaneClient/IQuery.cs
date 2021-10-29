// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Query operations.
    /// </summary>
    public partial interface IQuery
    {
        /// <summary>
        /// Returns the time range and distribution of event count over the
        /// event timestamp ($ts). This API can be used to provide landing
        /// experience of navigating to the environment.
        /// </summary>
        /// <param name='storeType'>
        /// For the environments with warm store enabled, the query can be
        /// executed either on the 'WarmStore' or 'ColdStore'. This parameter
        /// in the query defines which store the query should be executed on.
        /// If not defined, the query will be executed on the cold store.
        /// </param>
        /// <param name='clientRequestId'>
        /// Optional client request ID. Service records this value. Allows the
        /// service to trace operation across services, and allows the customer
        /// to contact support regarding a particular request.
        /// </param>
        /// <param name='clientSessionId'>
        /// Optional client session ID. Service records this value. Allows the
        /// service to trace a group of related operations across services, and
        /// allows the customer to contact support regarding a particular group
        /// of requests.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="TsiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AvailabilityResponse,QueryGetAvailabilityHeaders>> GetAvailabilityWithHttpMessagesAsync(string storeType = default(string), string clientRequestId = default(string), string clientSessionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns environment event schema for a given search span. Event
        /// schema is a set of property definitions. Event schema may not be
        /// contain all persisted properties when there are too many
        /// properties.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters to get event schema.
        /// </param>
        /// <param name='storeType'>
        /// For the environments with warm store enabled, the query can be
        /// executed either on the 'WarmStore' or 'ColdStore'. This parameter
        /// in the query defines which store the query should be executed on.
        /// If not defined, the query will be executed on the cold store.
        /// </param>
        /// <param name='clientRequestId'>
        /// Optional client request ID. Service records this value. Allows the
        /// service to trace operation across services, and allows the customer
        /// to contact support regarding a particular request.
        /// </param>
        /// <param name='clientSessionId'>
        /// Optional client session ID. Service records this value. Allows the
        /// service to trace a group of related operations across services, and
        /// allows the customer to contact support regarding a particular group
        /// of requests.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="TsiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<EventSchema,QueryGetEventSchemaHeaders>> GetEventSchemaWithHttpMessagesAsync(GetEventSchemaRequest parameters, string storeType = default(string), string clientRequestId = default(string), string clientSessionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Executes Time Series Query in pages of results - Get Events, Get
        /// Series or Aggregate Series.
        /// </summary>
        /// <param name='parameters'>
        /// Time series query request body.
        /// </param>
        /// <param name='storeType'>
        /// For the environments with warm store enabled, the query can be
        /// executed either on the 'WarmStore' or 'ColdStore'. This parameter
        /// in the query defines which store the query should be executed on.
        /// If not defined, the query will be executed on the cold store.
        /// </param>
        /// <param name='continuationToken'>
        /// Continuation token from previous page of results to retrieve the
        /// next page of the results in calls that support pagination. To get
        /// the first page results, specify null continuation token as
        /// parameter value. Returned continuation token is null if all results
        /// have been returned, and there is no next page of results.
        /// </param>
        /// <param name='clientRequestId'>
        /// Optional client request ID. Service records this value. Allows the
        /// service to trace operation across services, and allows the customer
        /// to contact support regarding a particular request.
        /// </param>
        /// <param name='clientSessionId'>
        /// Optional client session ID. Service records this value. Allows the
        /// service to trace a group of related operations across services, and
        /// allows the customer to contact support regarding a particular group
        /// of requests.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="TsiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<QueryResultPage,QueryExecuteHeaders>> ExecuteWithHttpMessagesAsync(QueryRequest parameters, string storeType = default(string), string continuationToken = default(string), string clientRequestId = default(string), string clientSessionId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Executes Time Series Query in pages of results - Get Events, Get Series or
        /// Aggregate Series.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='parameters'>
        /// Time series query request body.
        /// </param>
        /// <param name='storeType'>
        /// For the environments with warm store enabled, the query can be executed
        /// either on the 'WarmStore' or 'ColdStore'. This parameter in the query
        /// defines which store the query should be executed on. If not defined, the
        /// query will be executed on the cold store.
        /// </param>
        /// <param name='continuationToken'>
        /// Continuation token from previous page of results to retrieve the next page
        /// of the results in calls that support pagination. To get the first page
        /// results, specify null continuation token as parameter value. Returned
        /// continuation token is null if all results have been returned, and there is
        /// no next page of results.
        /// </param>
        /// <param name='clientRequestId'>
        /// Optional client request ID. Service records this value. Allows the service
        /// to trace operation across services, and allows the customer to contact
        /// support regarding a particular request.
        /// </param>
        /// <param name='clientSessionId'>
        /// Optional client session ID. Service records this value. Allows the service
        /// to trace a group of related operations across services, and allows the
        /// customer to contact support regarding a particular group of requests.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        //Task<QueryResultPage> ExecuteAsync(this IQuery operations, QueryRequest parameters, string storeType = default(string), string continuationToken = default(string), string clientRequestId = default(string), string clientSessionId = default(string), CancellationToken cancellationToken = default(CancellationToken));
    }
}
