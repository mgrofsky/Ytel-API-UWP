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
using APIMATIC.SDK.Common;


namespace message360.Models
{
    public class CreateSendEmailInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string to;
        private string mfrom;
        private Models.SendEmailAsEnum type = SendEmailAsEnum.HTML;
        private string subject;
        private string message;
        private string cc;
        private string bcc;
        private string attachment;
        private string responseType = "json";

        /// <summary>
        /// The to email address
        /// </summary>
        [JsonProperty("to")]
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
        /// The from email address
        /// </summary>
        [JsonProperty("from")]
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
        /// email format type, html or text
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.SendEmailAsEnum Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Email subject
        /// </summary>
        [JsonProperty("subject")]
        public string Subject 
        { 
            get 
            {
                return this.subject; 
            } 
            set 
            {
                this.subject = value;
                onPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// The body of the email message
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// CC Email address
        /// </summary>
        [JsonProperty("cc")]
        public string Cc 
        { 
            get 
            {
                return this.cc; 
            } 
            set 
            {
                this.cc = value;
                onPropertyChanged("Cc");
            }
        }

        /// <summary>
        /// BCC Email address
        /// </summary>
        [JsonProperty("bcc")]
        public string Bcc 
        { 
            get 
            {
                return this.bcc; 
            } 
            set 
            {
                this.bcc = value;
                onPropertyChanged("Bcc");
            }
        }

        /// <summary>
        /// File to be attached.File must be less than 7MB.
        /// </summary>
        [JsonProperty("attachment")]
        public string Attachment 
        { 
            get 
            {
                return this.attachment; 
            } 
            set 
            {
                this.attachment = value;
                onPropertyChanged("Attachment");
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