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
    public class GroupCallInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string mfrom;
        private string to;
        private string url;
        private string responseType = "json";
        private string groupConfirmKey;
        private Models.AudioFormatEnum groupConfirmFile;
        private Models.HttpActionEnum? method;
        private string statusCallBackUrl;
        private Models.HttpActionEnum? statusCallBackMethod;
        private string fallBackUrl;
        private Models.HttpActionEnum? fallBackMethod;
        private string heartBeatUrl;
        private Models.HttpActionEnum? heartBeatMethod;
        private int? timeout;
        private string playDtmf;
        private string hideCallerId;
        private bool? record;
        private string recordCallBackUrl;
        private Models.HttpActionEnum? recordCallBackMethod;
        private bool? transcribe;
        private string transcribeCallBackUrl;

        /// <summary>
        /// This number to display on Caller ID as calling
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
        /// Please enter multiple E164 number. You can add max 10 numbers. Add numbers separated with comma. e.g : 1111111111,2222222222
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
        /// URL requested once the call connects
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
        /// TODO: Write general description for this method
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
        /// Define the DTMF that the called party should send to bridge the call. Allowed Values : 0-9, #, *
        /// </summary>
        [JsonProperty("GroupConfirmKey")]
        public string GroupConfirmKey 
        { 
            get 
            {
                return this.groupConfirmKey; 
            } 
            set 
            {
                this.groupConfirmKey = value;
                onPropertyChanged("GroupConfirmKey");
            }
        }

        /// <summary>
        /// Specify the audio file you want to play when the called party picks up the call
        /// </summary>
        [JsonProperty("GroupConfirmFile", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.AudioFormatEnum GroupConfirmFile 
        { 
            get 
            {
                return this.groupConfirmFile; 
            } 
            set 
            {
                this.groupConfirmFile = value;
                onPropertyChanged("GroupConfirmFile");
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
        [JsonProperty("FallBackUrl")]
        public string FallBackUrl 
        { 
            get 
            {
                return this.fallBackUrl; 
            } 
            set 
            {
                this.fallBackUrl = value;
                onPropertyChanged("FallBackUrl");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request the required FallbackUrl once call connects.
        /// </summary>
        [JsonProperty("FallBackMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? FallBackMethod 
        { 
            get 
            {
                return this.fallBackMethod; 
            } 
            set 
            {
                this.fallBackMethod = value;
                onPropertyChanged("FallBackMethod");
            }
        }

        /// <summary>
        /// URL that can be requested every 60 seconds during the call to notify of elapsed time and pass other general information.
        /// </summary>
        [JsonProperty("HeartBeatUrl")]
        public string HeartBeatUrl 
        { 
            get 
            {
                return this.heartBeatUrl; 
            } 
            set 
            {
                this.heartBeatUrl = value;
                onPropertyChanged("HeartBeatUrl");
            }
        }

        /// <summary>
        /// Specifies the HTTP method used to request HeartbeatUrl.
        /// </summary>
        [JsonProperty("HeartBeatMethod", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.HttpActionEnum? HeartBeatMethod 
        { 
            get 
            {
                return this.heartBeatMethod; 
            } 
            set 
            {
                this.heartBeatMethod = value;
                onPropertyChanged("HeartBeatMethod");
            }
        }

        /// <summary>
        /// Time (in seconds) we should wait while the call is ringing before canceling the call
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

        /// <summary>
        /// DTMF Digits to play to the call once it connects. 0-9, #, or *
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
        /// Specifies if the caller id will be hidden
        /// </summary>
        [JsonProperty("HideCallerId")]
        public string HideCallerId 
        { 
            get 
            {
                return this.hideCallerId; 
            } 
            set 
            {
                this.hideCallerId = value;
                onPropertyChanged("HideCallerId");
            }
        }

        /// <summary>
        /// Specifies if the call should be recorded
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
        /// Recording parameters will be sent here upon completion
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
        /// Method used to request the RecordCallback URL.
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
        /// Specifies if the call recording should be transcribed
        /// </summary>
        [JsonProperty("Transcribe")]
        public bool? Transcribe 
        { 
            get 
            {
                return this.transcribe; 
            } 
            set 
            {
                this.transcribe = value;
                onPropertyChanged("Transcribe");
            }
        }

        /// <summary>
        /// Transcription parameters will be sent here upon completion
        /// </summary>
        [JsonProperty("TranscribeCallBackUrl")]
        public string TranscribeCallBackUrl 
        { 
            get 
            {
                return this.transcribeCallBackUrl; 
            } 
            set 
            {
                this.transcribeCallBackUrl = value;
                onPropertyChanged("TranscribeCallBackUrl");
            }
        }
    }
} 