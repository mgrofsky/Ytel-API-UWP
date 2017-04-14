/*
 * Message360.UWP
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;

namespace message360.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AudioDirectionEnum
    {
        IN, //TODO: Write general description for this method
        OUT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type AudioDirectionEnum
    /// </summary>
    public static class AudioDirectionEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "in", "out" };

        /// <summary>
        /// Converts a AudioDirectionEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AudioDirectionEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AudioDirectionEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AudioDirectionEnum.IN:
                case AudioDirectionEnum.OUT:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AudioDirectionEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AudioDirectionEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AudioDirectionEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into AudioDirectionEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AudioDirectionEnum value</returns>
        public static AudioDirectionEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type AudioDirectionEnum", value));

            return (AudioDirectionEnum) index;
        }
    }
} 