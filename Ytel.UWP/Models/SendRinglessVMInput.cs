/*
 * Ytel.UWP
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
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
using APIMATIC.SDK.Common;


namespace ytel.Models
{
    public class SendRinglessVMInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mfrom;
        private string rVMCallerId;
        private string to;
        private string voiceMailURL;
        private string responseType = "json";
        private Models.HttpActionEnum? method = Models.HttpActionEnum.GET;
        private string statusCallBackUrl;
        private Models.HttpActionEnum? statsCallBackMethod;

        /// <summary>
        /// A valid Ytel Voice enabled number (E.164 format) that will be initiating the phone call.
        /// </summary>
        [JsonProperty("From")]
        public string From 
        { 
            get 
            {
                return this.mfrom; 
            } 
            set 
            {
                this.mfrom = value;
                onPropertyChanged("From");
            }
        }

        /// <summary>
        /// A required secondary Caller ID for RVM to work.
        /// </summary>
        [JsonProperty("RVMCallerId")]
        public string RVMCallerId 
        { 
            get 
            {
                return this.rVMCallerId; 
            } 
            set 
            {
                this.rVMCallerId = value;
                onPropertyChanged("RVMCallerId");
            }
        }

        /// <summary>
        /// A valid number (E.164 format) that will receive the phone call.
        /// </summary>
        [JsonProperty("To")]
        public string To 
        { 
            get 
            {
                return this.to; 
            } 
            set 
            {
                this.to = value;
                onPropertyChanged("To");
            }
        }

        /// <summary>
        /// The URL requested once the RVM connects. A set of default parameters will be sent here.
        /// </summary>
        [JsonProperty("VoiceMailURL")]
        public string VoiceMailURL 
        { 
            get 
            {
                return this.voiceMailURL; 
            } 
            set 
            {
                this.voiceMailURL = value;
                onPropertyChanged("VoiceMailURL");
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

        /// <summary>
        /// Specifies the HTTP method used to request the required URL once call connects.
        /// </summary>
        [JsonProperty("Method", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? Method 
        { 
            get 
            {
                return this.method; 
            } 
            set 
            {
                this.method = value;
                onPropertyChanged("Method");
            }
        }

        /// <summary>
        /// URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished.
        /// </summary>
        [JsonProperty("StatusCallBackUrl")]
        public string StatusCallBackUrl 
        { 
            get 
            {
                return this.statusCallBackUrl; 
            } 
            set 
            {
                this.statusCallBackUrl = value;
                onPropertyChanged("StatusCallBackUrl");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required StatusCallBackUrl once call connects.
        /// </summary>
        [JsonProperty("StatsCallBackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? StatsCallBackMethod 
        { 
            get 
            {
                return this.statsCallBackMethod; 
            } 
            set 
            {
                this.statsCallBackMethod = value;
                onPropertyChanged("StatsCallBackMethod");
            }
        }
    }
} 