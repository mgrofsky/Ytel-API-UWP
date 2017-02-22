/*
 * Message360.UWP
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 02/22/2017
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
    public class CreateVoiceEffectInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string callSid;
        private Models.AudioDirection? audioDirection;
        private double? pitchSemiTones;
        private double? pitchOctaves;
        private double? pitch;
        private double? rate;
        private double? tempo;
        private string responseType = "json";

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AudioDirection", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.AudioDirection? AudioDirection 
        { 
            get 
            {
                return this.audioDirection; 
            } 
            set 
            {
                this.audioDirection = value;
                onPropertyChanged("AudioDirection");
            }
        }

        /// <summary>
        /// value between -14 and 14
        /// </summary>
        [JsonProperty("PitchSemiTones")]
        public double? PitchSemiTones 
        { 
            get 
            {
                return this.pitchSemiTones; 
            } 
            set 
            {
                this.pitchSemiTones = value;
                onPropertyChanged("PitchSemiTones");
            }
        }

        /// <summary>
        /// value between -1 and 1
        /// </summary>
        [JsonProperty("PitchOctaves")]
        public double? PitchOctaves 
        { 
            get 
            {
                return this.pitchOctaves; 
            } 
            set 
            {
                this.pitchOctaves = value;
                onPropertyChanged("PitchOctaves");
            }
        }

        /// <summary>
        /// value greater than 0
        /// </summary>
        [JsonProperty("Pitch")]
        public double? Pitch 
        { 
            get 
            {
                return this.pitch; 
            } 
            set 
            {
                this.pitch = value;
                onPropertyChanged("Pitch");
            }
        }

        /// <summary>
        /// value greater than 0
        /// </summary>
        [JsonProperty("Rate")]
        public double? Rate 
        { 
            get 
            {
                return this.rate; 
            } 
            set 
            {
                this.rate = value;
                onPropertyChanged("Rate");
            }
        }

        /// <summary>
        /// value greater than 0
        /// </summary>
        [JsonProperty("Tempo")]
        public double? Tempo 
        { 
            get 
            {
                return this.tempo; 
            } 
            set 
            {
                this.tempo = value;
                onPropertyChanged("Tempo");
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
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 