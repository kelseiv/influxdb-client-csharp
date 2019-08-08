/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// Threshold
    /// </summary>
    [DataContract]
    public partial class Threshold :  IEquatable<Threshold>
    {
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public CheckStatusLevel? Level { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Threshold" /> class.
        /// </summary>
        /// <param name="level">level.</param>
        /// <param name="allValues">if true, only alert if all values meet threshold.</param>
        /// <param name="lowerBound">lowerBound.</param>
        /// <param name="upperBound">upperBound.</param>
        public Threshold(CheckStatusLevel? level = default(CheckStatusLevel?), bool? allValues = default(bool?), float? lowerBound = default(float?), float? upperBound = default(float?))
        {
            this.Level = level;
            this.AllValues = allValues;
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
        }


        /// <summary>
        /// if true, only alert if all values meet threshold
        /// </summary>
        /// <value>if true, only alert if all values meet threshold</value>
        [DataMember(Name="allValues", EmitDefaultValue=false)]
        public bool? AllValues { get; set; }

        /// <summary>
        /// Gets or Sets LowerBound
        /// </summary>
        [DataMember(Name="lowerBound", EmitDefaultValue=false)]
        public float? LowerBound { get; set; }

        /// <summary>
        /// Gets or Sets UpperBound
        /// </summary>
        [DataMember(Name="upperBound", EmitDefaultValue=false)]
        public float? UpperBound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Threshold {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  AllValues: ").Append(AllValues).Append("\n");
            sb.Append("  LowerBound: ").Append(LowerBound).Append("\n");
            sb.Append("  UpperBound: ").Append(UpperBound).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Threshold);
        }

        /// <summary>
        /// Returns true if Threshold instances are equal
        /// </summary>
        /// <param name="input">Instance of Threshold to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Threshold input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.AllValues == input.AllValues ||
                    (this.AllValues != null &&
                    this.AllValues.Equals(input.AllValues))
                ) && 
                (
                    this.LowerBound == input.LowerBound ||
                    (this.LowerBound != null &&
                    this.LowerBound.Equals(input.LowerBound))
                ) && 
                (
                    this.UpperBound == input.UpperBound ||
                    (this.UpperBound != null &&
                    this.UpperBound.Equals(input.UpperBound))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.AllValues != null)
                    hashCode = hashCode * 59 + this.AllValues.GetHashCode();
                if (this.LowerBound != null)
                    hashCode = hashCode * 59 + this.LowerBound.GetHashCode();
                if (this.UpperBound != null)
                    hashCode = hashCode * 59 + this.UpperBound.GetHashCode();
                return hashCode;
            }
        }

    }

}