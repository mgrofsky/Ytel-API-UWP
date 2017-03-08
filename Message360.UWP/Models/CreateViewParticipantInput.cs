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
    public class CreateViewParticipantInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string conferenceSid;
        private string participantSid;
        private string responseType = "json";

        /// <summary>
        /// unique conference sid
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ParticipantSid")]
        public string ParticipantSid 
        { 
            get 
            {
                return this.participantSid; 
            } 
            set 
            {
                this.participantSid = value;
                onPropertyChanged("ParticipantSid");
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