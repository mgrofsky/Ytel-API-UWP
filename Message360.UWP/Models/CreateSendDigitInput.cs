/*
 * Message360.UWP
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using message360;
using message360.Utilities;

namespace message360.Models
{
    public class CreateSendDigitInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string callSid;
        private string playDtmf;
        private Models.Direction? playDtmfDirection;
        private string responseType = "json";

        /// <summary>
        /// The unique identifier of each call resource
        /// </summary>
        [JsonProperty("CallSid")]
        public string CallSid 
        { 
            get 
            {
                return this.callSid; 
            } 
            set 
            {
                this.callSid = value;
                onPropertyChanged("CallSid");
            }
        }

        /// <summary>
        /// DTMF digits to play to the call. 0-9, #, *, W, or w
        /// </summary>
        [JsonProperty("PlayDtmf")]
        public string PlayDtmf 
        { 
            get 
            {
                return this.playDtmf; 
            } 
            set 
            {
                this.playDtmf = value;
                onPropertyChanged("PlayDtmf");
            }
        }

        /// <summary>
        /// The leg of the call DTMF digits should be sent to
        /// </summary>
        [JsonProperty("PlayDtmfDirection", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.Direction? PlayDtmfDirection 
        { 
            get 
            {
                return this.playDtmfDirection; 
            } 
            set 
            {
                this.playDtmfDirection = value;
                onPropertyChanged("PlayDtmfDirection");
            }
        }

        /// <summary>
        /// Response type format xml or json
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType 
        { 
            get 
            {
                return this.responseType; 
            } 
            set 
            {
                this.responseType = value;
                onPropertyChanged("ResponseType");
            }
        }
    }
} 