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
    public class SendEmailInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string to;
        private Models.SendEmailAsEnum type = Models.SendEmailAsEnum.HTML;
        private string subject;
        private string message;
        private string responseType = "json";
        private string mfrom;
        private string cc;
        private string bcc;
        private string attachment;

        /// <summary>
        /// A valid address that will receive the email. Multiple addresses can be separated by using commas.
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
        /// Specifies the type of email to be sent
        /// </summary>
        [JsonProperty("Type", ItemConverterType = typeof(StringValuedEnumConverter))]
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
        /// The subject of the mail. Must be a valid string.
        /// </summary>
        [JsonProperty("Subject")]
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
        /// The email message that is to be sent in the text.
        /// </summary>
        [JsonProperty("Message")]
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
        /// A valid address that will send the email.
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
        /// Carbon copy. A valid address that will receive the email. Multiple addresses can be separated by using commas.
        /// </summary>
        [JsonProperty("Cc")]
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
        /// Blind carbon copy. A valid address that will receive the email. Multiple addresses can be separated by using commas.
        /// </summary>
        [JsonProperty("Bcc")]
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
        /// A file that is attached to the email. Must be less than 7 MB in size.
        /// </summary>
        [JsonProperty("Attachment")]
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
    }
} 