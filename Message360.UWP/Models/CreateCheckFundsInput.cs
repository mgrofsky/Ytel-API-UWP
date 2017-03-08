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
    public class CreateCheckFundsInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountSid;
        private string authToken;

        /// <summary>
        /// Your message360 Account SID
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid 
        { 
            get 
            {
                return this.accountSid; 
            } 
            set 
            {
                this.accountSid = value;
                onPropertyChanged("AccountSid");
            }
        }

        /// <summary>
        /// Your message360 Token
        /// </summary>
        [JsonProperty("auth_token")]
        public string AuthToken 
        { 
            get 
            {
                return this.authToken; 
            } 
            set 
            {
                this.authToken = value;
                onPropertyChanged("AuthToken");
            }
        }
    }
} 