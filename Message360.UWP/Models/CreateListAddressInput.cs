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
    public class CreateListAddressInput : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? page = 1;
        private int? pageSize = 10;
        private string addressSID;
        private string dateCreated;
        private string responseType = "json";

        /// <summary>
        /// Return requested # of items starting the value, default=0, must be an integer
        /// </summary>
        [JsonProperty("Page")]
        public int? Page 
        { 
            get 
            {
                return this.page; 
            } 
            set 
            {
                this.page = value;
                onPropertyChanged("Page");
            }
        }

        /// <summary>
        /// How many results to return, default is 10, max is 100, must be an integer
        /// </summary>
        [JsonProperty("PageSize")]
        public int? PageSize 
        { 
            get 
            {
                return this.pageSize; 
            } 
            set 
            {
                this.pageSize = value;
                onPropertyChanged("PageSize");
            }
        }

        /// <summary>
        /// addresses Sid
        /// </summary>
        [JsonProperty("AddressSID")]
        public string AddressSID 
        { 
            get 
            {
                return this.addressSID; 
            } 
            set 
            {
                this.addressSID = value;
                onPropertyChanged("AddressSID");
            }
        }

        /// <summary>
        /// date created address.
        /// </summary>
        [JsonProperty("DateCreated")]
        public string DateCreated 
        { 
            get 
            {
                return this.dateCreated; 
            } 
            set 
            {
                this.dateCreated = value;
                onPropertyChanged("DateCreated");
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