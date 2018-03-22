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
    public class CreateTokenInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accountSid;
        private string authToken;
        private string username;
        private string password;

        /// <summary>
        /// Your Ytel Account SID
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
        /// Your Ytel Token
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

        /// <summary>
        /// WebRTC username authentication
        /// </summary>
        [JsonProperty("username")]
        public string Username 
        { 
            get 
            {
                return this.username; 
            } 
            set 
            {
                this.username = value;
                onPropertyChanged("Username");
            }
        }

        /// <summary>
        /// WebRTC password authentication
        /// </summary>
        [JsonProperty("password")]
        public string Password 
        { 
            get 
            {
                return this.password; 
            } 
            set 
            {
                this.password = value;
                onPropertyChanged("Password");
            }
        }
    }
} 