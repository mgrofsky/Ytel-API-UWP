/*
 * Ytel.UWP
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;

namespace ytel.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AudioFormatEnum
    {
        MP3, //mp3 file
        WAV, //wav file
    }

    /// <summary>
    /// Helper for the enum type AudioFormatEnum
    /// </summary>
    public static class AudioFormatEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "mp3", "wav" };

        /// <summary>
        /// Converts a AudioFormatEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AudioFormatEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AudioFormatEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AudioFormatEnum.MP3:
                case AudioFormatEnum.WAV:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AudioFormatEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AudioFormatEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AudioFormatEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into AudioFormatEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AudioFormatEnum value</returns>
        public static AudioFormatEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type AudioFormatEnum", value));

            return (AudioFormatEnum) index;
        }
    }
} 