// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Aggregate Series query. Allows to calculate an aggregated time series
    /// from events for a given Time Series ID and search span.
    /// </summary>
    public partial class AggregateSeries
    {
        /// <summary>
        /// Initializes a new instance of the AggregateSeries class.
        /// </summary>
        public AggregateSeries()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AggregateSeries class.
        /// </summary>
        /// <param name="timeSeriesId">A single Time Series ID value that
        /// uniquely identifies a single time series instance (e.g. a device).
        /// Note that a single Time Series ID can be composite if multiple
        /// properties are specified as Time Series ID at environment creation
        /// time. The position and type of values must match Time Series ID
        /// properties specified on the environment and returned by Get Model
        /// Setting API. Cannot be null.</param>
        /// <param name="searchSpan">The range of time on which the query is
        /// executed. Cannot be null.</param>
        /// <param name="interval">Interval size is specified in ISO-8601
        /// duration format. All intervals are the same size. One month is
        /// always converted to 30 days, and one year is always 365 days.
        /// Examples: 1 minute is "PT1M", 1 millisecond is "PT0.001S". For more
        /// information, see
        /// https://www.w3.org/TR/xmlschema-2/#duration</param>
        /// <param name="filter">Top-level filter over the events that
        /// restricts the number of events being considered for computation.
        /// This filter is AND'ed with filter in each variable. Example:
        /// "$event.Status.String='Good'". Optional.</param>
        /// <param name="projectedVariables">This allows the user to optionally
        /// select the variables that needs to be projected. When it is null or
        /// not set, all the variables from inlineVariables and model are
        /// returned. Can be null.</param>
        /// <param name="inlineVariables">This allows the user the optionally
        /// define inline-variables apart from the ones already defined in the
        /// model. When the inline variable names have the same name as the
        /// model, the inline variable definition takes precedence. Can be
        /// null.</param>
        public AggregateSeries(IList<object> timeSeriesId, DateTimeRange searchSpan, System.TimeSpan interval, Tsx filter = default(Tsx), IList<string> projectedVariables = default(IList<string>), IDictionary<string, InlineVariable> inlineVariables = default(IDictionary<string, InlineVariable>))
        {
            TimeSeriesId = timeSeriesId;
            SearchSpan = searchSpan;
            Filter = filter;
            Interval = interval;
            ProjectedVariables = projectedVariables;
            InlineVariables = inlineVariables;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a single Time Series ID value that uniquely identifies
        /// a single time series instance (e.g. a device). Note that a single
        /// Time Series ID can be composite if multiple properties are
        /// specified as Time Series ID at environment creation time. The
        /// position and type of values must match Time Series ID properties
        /// specified on the environment and returned by Get Model Setting API.
        /// Cannot be null.
        /// </summary>
        [JsonProperty(PropertyName = "timeSeriesId")]
        public IList<object> TimeSeriesId { get; set; }

        /// <summary>
        /// Gets or sets the range of time on which the query is executed.
        /// Cannot be null.
        /// </summary>
        [JsonProperty(PropertyName = "searchSpan")]
        public DateTimeRange SearchSpan { get; set; }

        /// <summary>
        /// Gets or sets top-level filter over the events that restricts the
        /// number of events being considered for computation. This filter is
        /// AND'ed with filter in each variable. Example:
        /// "$event.Status.String='Good'". Optional.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public Tsx Filter { get; set; }

        /// <summary>
        /// Gets or sets interval size is specified in ISO-8601 duration
        /// format. All intervals are the same size. One month is always
        /// converted to 30 days, and one year is always 365 days. Examples: 1
        /// minute is "PT1M", 1 millisecond is "PT0.001S". For more
        /// information, see https://www.w3.org/TR/xmlschema-2/#duration
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public System.TimeSpan Interval { get; set; }

        /// <summary>
        /// Gets or sets this allows the user to optionally select the
        /// variables that needs to be projected. When it is null or not set,
        /// all the variables from inlineVariables and model are returned. Can
        /// be null.
        /// </summary>
        [JsonProperty(PropertyName = "projectedVariables")]
        public IList<string> ProjectedVariables { get; set; }

        /// <summary>
        /// Gets or sets this allows the user the optionally define
        /// inline-variables apart from the ones already defined in the model.
        /// When the inline variable names have the same name as the model, the
        /// inline variable definition takes precedence. Can be null.
        /// </summary>
        [JsonProperty(PropertyName = "inlineVariables")]
        public IDictionary<string, InlineVariable> InlineVariables { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeSeriesId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeSeriesId");
            }
            if (SearchSpan == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SearchSpan");
            }
            if (SearchSpan != null)
            {
                SearchSpan.Validate();
            }
            if (Filter != null)
            {
                Filter.Validate();
            }
            if (InlineVariables != null)
            {
                foreach (var valueElement in InlineVariables.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
