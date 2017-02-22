/*
 * Message360.UWP
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 02/22/2017
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using message360;
using message360.Utilities;

namespace message360.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum IfMachine
    {
        CONTINUE, //TODO: Write general description for this method
        HANGUP, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type IfMachine
    /// </summary>
    public static class IfMachineHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "continue", "hangup" };

        /// <summary>
        /// Converts a IfMachine value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The IfMachine value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(IfMachine enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case IfMachine.CONTINUE:
                case IfMachine.HANGUP:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of IfMachine values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of IfMachine values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<IfMachine> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into IfMachine value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed IfMachine value</returns>
        public static IfMachine ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type IfMachine", value));

            return (IfMachine) index;
        }
    }
} 