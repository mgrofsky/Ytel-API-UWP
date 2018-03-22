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
    public class CreateConferenceInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mfrom;
        private string to;
        private string url;
        private string responseType = "json";
        private Models.HttpActionEnum? method = Models.HttpActionEnum.POST;
        private string statusCallBackUrl;
        private Models.HttpActionEnum? statusCallBackMethod;
        private string fallbackUrl;
        private Models.HttpActionEnum? fallbackMethod;
        private bool? record;
        private string recordCallBackUrl;
        private Models.HttpActionEnum? recordCallBackMethod;
        private string scheduleTime;
        private int? timeout;

        /// <summary>
        /// A valid 10-digit number (E.164 format) that will be initiating the conference call.
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
        /// A valid 10-digit number (E.164 format) that is to receive the conference call.
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
        /// URL requested once the conference connects
        /// </summary>
        [JsonProperty("Url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
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
        /// URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the conference is finished.
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
        /// Specifies the HTTP methodlinkclass used to request StatusCallbackUrl.
        /// </summary>
        [JsonProperty("StatusCallBackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? StatusCallBackMethod 
        { 
            get 
            {
                return this.statusCallBackMethod; 
            } 
            set 
            {
                this.statusCallBackMethod = value;
                onPropertyChanged("StatusCallBackMethod");
            }
        }

        /// <summary>
        /// URL requested if the initial Url parameter fails or encounters an error
        /// </summary>
        [JsonProperty("FallbackUrl")]
        public string FallbackUrl 
        { 
            get 
            {
                return this.fallbackUrl; 
            } 
            set 
            {
                this.fallbackUrl = value;
                onPropertyChanged("FallbackUrl");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required FallbackUrl once call connects.
        /// </summary>
        [JsonProperty("FallbackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? FallbackMethod 
        { 
            get 
            {
                return this.fallbackMethod; 
            } 
            set 
            {
                this.fallbackMethod = value;
                onPropertyChanged("FallbackMethod");
            }
        }

        /// <summary>
        /// Specifies if the conference should be recorded.
        /// </summary>
        [JsonProperty("Record")]
        public bool? Record 
        { 
            get 
            {
                return this.record; 
            } 
            set 
            {
                this.record = value;
                onPropertyChanged("Record");
            }
        }

        /// <summary>
        /// Recording parameters will be sent here upon completion.
        /// </summary>
        [JsonProperty("RecordCallBackUrl")]
        public string RecordCallBackUrl 
        { 
            get 
            {
                return this.recordCallBackUrl; 
            } 
            set 
            {
                this.recordCallBackUrl = value;
                onPropertyChanged("RecordCallBackUrl");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required URL once conference connects.
        /// </summary>
        [JsonProperty("RecordCallBackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? RecordCallBackMethod 
        { 
            get 
            {
                return this.recordCallBackMethod; 
            } 
            set 
            {
                this.recordCallBackMethod = value;
                onPropertyChanged("RecordCallBackMethod");
            }
        }

        /// <summary>
        /// Schedule conference in future. Schedule time must be greater than current time
        /// </summary>
        [JsonProperty("ScheduleTime")]
        public string ScheduleTime 
        { 
            get 
            {
                return this.scheduleTime; 
            } 
            set 
            {
                this.scheduleTime = value;
                onPropertyChanged("ScheduleTime");
            }
        }

        /// <summary>
        /// The number of seconds the call stays on the line while waiting for an answer. The max time limit is 999 and the default limit is 60 seconds but lower times can be set.
        /// </summary>
        [JsonProperty("Timeout")]
        public int? Timeout 
        { 
            get 
            {
                return this.timeout; 
            } 
            set 
            {
                this.timeout = value;
                onPropertyChanged("Timeout");
            }
        }
    }
} 