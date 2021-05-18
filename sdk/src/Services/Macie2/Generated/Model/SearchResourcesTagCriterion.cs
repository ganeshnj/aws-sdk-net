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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies a tag-based filter condition that determines which AWS resources are included
    /// or excluded from the query results.
    /// </summary>
    public partial class SearchResourcesTagCriterion
    {
        private SearchResourcesComparator _comparator;
        private List<SearchResourcesTagCriterionPair> _tagValues = new List<SearchResourcesTagCriterionPair>();

        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// The operator to use in the condition. Valid values are EQ (equals) and NE (not equals).
        /// </para>
        /// </summary>
        public SearchResourcesComparator Comparator
        {
            get { return this._comparator; }
            set { this._comparator = value; }
        }

        // Check to see if Comparator property is set
        internal bool IsSetComparator()
        {
            return this._comparator != null;
        }

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// The tag keys, tag values, or tag key and value pairs to use in the condition.
        /// </para>
        /// </summary>
        public List<SearchResourcesTagCriterionPair> TagValues
        {
            get { return this._tagValues; }
            set { this._tagValues = value; }
        }

        // Check to see if TagValues property is set
        internal bool IsSetTagValues()
        {
            return this._tagValues != null && this._tagValues.Count > 0; 
        }

    }
}