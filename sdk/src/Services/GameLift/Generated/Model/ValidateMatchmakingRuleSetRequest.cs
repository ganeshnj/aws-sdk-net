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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the ValidateMatchmakingRuleSet operation.
    /// Validates the syntax of a matchmaking rule or rule set. This operation checks that
    /// the rule set is using syntactically correct JSON and that it conforms to allowed property
    /// expressions. To validate syntax, provide a rule set JSON string.
    /// 
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-rulesets.html">Build
    /// a rule set</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a>CreateMatchmakingConfiguration</a> | <a>DescribeMatchmakingConfigurations</a>
    /// | <a>UpdateMatchmakingConfiguration</a> | <a>DeleteMatchmakingConfiguration</a> |
    /// <a>CreateMatchmakingRuleSet</a> | <a>DescribeMatchmakingRuleSets</a> | <a>ValidateMatchmakingRuleSet</a>
    /// | <a>DeleteMatchmakingRuleSet</a> | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class ValidateMatchmakingRuleSetRequest : AmazonGameLiftRequest
    {
        private string _ruleSetBody;

        /// <summary>
        /// Gets and sets the property RuleSetBody. 
        /// <para>
        /// A collection of matchmaking rules to validate, formatted as a JSON string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public string RuleSetBody
        {
            get { return this._ruleSetBody; }
            set { this._ruleSetBody = value; }
        }

        // Check to see if RuleSetBody property is set
        internal bool IsSetRuleSetBody()
        {
            return this._ruleSetBody != null;
        }

    }
}