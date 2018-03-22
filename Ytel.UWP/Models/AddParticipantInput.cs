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
    public class AddParticipantInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string conferenceSid;
        private string participantNumber;
        private string responseType = "json";
        private bool? muted;
        private bool? deaf;

        /// <summary>
        /// The unique identifier for a conference object.
        /// </summary>
        [JsonProperty("ConferenceSid")]
        public string ConferenceSid 
        { 
            get 
            {
                return this.conferenceSid; 
            } 
            set 
            {
                this.conferenceSid = value;
                onPropertyChanged("ConferenceSid");
            }
        }

        /// <summary>
        /// The phone number of the participant to be added.
        /// </summary>
        [JsonProperty("ParticipantNumber")]
        public string ParticipantNumber 
        { 
            get 
            {
                return this.participantNumber; 
            } 
            set 
            {
                this.participantNumber = value;
                onPropertyChanged("ParticipantNumber");
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
        /// Specifies if participant should be muted.
        /// </summary>
        [JsonProperty("Muted")]
        public bool? Muted 
        { 
            get 
            {
                return this.muted; 
            } 
            set 
            {
                this.muted = value;
                onPropertyChanged("Muted");
            }
        }

        /// <summary>
        /// Specifies if the participant should hear audio in the conference.
        /// </summary>
        [JsonProperty("Deaf")]
        public bool? Deaf 
        { 
            get 
            {
                return this.deaf; 
            } 
            set 
            {
                this.deaf = value;
                onPropertyChanged("Deaf");
            }
        }
    }
} 