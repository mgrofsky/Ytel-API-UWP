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
    public class CreateAreaMailInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string routes;
        private string attachbyid;
        private string front;
        private string back;
        private string responseType = "json";
        private string description;
        private string targettype;
        private string htmldata;

        /// <summary>
        /// List of routes that AreaMail should be delivered to.  A single route can be either a zipcode or a carrier route.List of routes that AreaMail should be delivered to.  A single route can be either a zipcode or a carrier route. A carrier route is in the form of 92610-C043 where the carrier route is composed of 5 numbers for zipcode, 1 letter for carrier route type, and 3 numbers for carrier route code. Delivery can be sent to mutliple routes by separating them with a commas. Valid Values: 92656, 92610-C043
        /// </summary>
        [JsonProperty("routes")]
        public string Routes 
        { 
            get 
            {
                return this.routes; 
            } 
            set 
            {
                this.routes = value;
                onPropertyChanged("Routes");
            }
        }

        /// <summary>
        /// Set an existing areamail by attaching its AreamailId.
        /// </summary>
        [JsonProperty("attachbyid")]
        public string Attachbyid 
        { 
            get 
            {
                return this.attachbyid; 
            } 
            set 
            {
                this.attachbyid = value;
                onPropertyChanged("Attachbyid");
            }
        }

        /// <summary>
        /// The front of the AreaMail item to be created. This can be a URL, local file, or an HTML string. Supported file types are PDF, PNG, and JPEG. Back required
        /// </summary>
        [JsonProperty("front")]
        public string Front 
        { 
            get 
            {
                return this.front; 
            } 
            set 
            {
                this.front = value;
                onPropertyChanged("Front");
            }
        }

        /// <summary>
        /// The back of the AreaMail item to be created. This can be a URL, local file, or an HTML string. Supported file types are PDF, PNG, and JPEG.
        /// </summary>
        [JsonProperty("back")]
        public string Back 
        { 
            get 
            {
                return this.back; 
            } 
            set 
            {
                this.back = value;
                onPropertyChanged("Back");
            }
        }

        /// <summary>
        /// Response Type either json or xml
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
        /// A string value to use as a description for this AreaMail item.
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The delivery location type.
        /// </summary>
        [JsonProperty("targettype")]
        public string Targettype 
        { 
            get 
            {
                return this.targettype; 
            } 
            set 
            {
                this.targettype = value;
                onPropertyChanged("Targettype");
            }
        }

        /// <summary>
        /// A string value that contains HTML markup.
        /// </summary>
        [JsonProperty("htmldata")]
        public string Htmldata 
        { 
            get 
            {
                return this.htmldata; 
            } 
            set 
            {
                this.htmldata = value;
                onPropertyChanged("Htmldata");
            }
        }
    }
} 