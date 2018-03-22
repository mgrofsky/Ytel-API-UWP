/*
 * Ytel.UWP
 *
 * This file was automatically generated for ytel by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;

namespace ytel.Controllers
{
    public partial class WebRTCController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static WebRTCController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static WebRTCController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new WebRTCController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Ytel webrtc
        /// </summary>
        /// <param name="Models.CreateTokenInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateToken(Models.CreateTokenInput input)
        {
            Task<string> t = CreateTokenAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Ytel webrtc
        /// </summary>
        /// <param name="Models.CreateTokenInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateTokenAsync(Models.CreateTokenInput input)
        {
            //validating required parameters
            if (null == input.AccountSid)
                throw new ArgumentNullException("accountSid", "The property \"AccountSid\" in the input object cannot be null.");

            if (null == input.AuthToken)
                throw new ArgumentNullException("authToken", "The property \"AuthToken\" in the input object cannot be null.");

            if (null == input.Username)
                throw new ArgumentNullException("username", "The property \"Username\" in the input object cannot be null.");

            if (null == input.Password)
                throw new ArgumentNullException("password", "The property \"Password\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/webrtc/agentLogin.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "account_sid", input.AccountSid ),
                new KeyValuePair<string, object>( "auth_token", input.AuthToken ),
                new KeyValuePair<string, object>( "username", input.Username ),
                new KeyValuePair<string, object>( "password", input.Password )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.CheckFundsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public string CheckFunds(Models.CheckFundsInput input)
        {
            Task<string> t = CheckFundsAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.CheckFundsInput">Object containing request parameters</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CheckFundsAsync(Models.CheckFundsInput input)
        {
            //validating required parameters
            if (null == input.AccountSid)
                throw new ArgumentNullException("accountSid", "The property \"AccountSid\" in the input object cannot be null.");

            if (null == input.AuthToken)
                throw new ArgumentNullException("authToken", "The property \"AuthToken\" in the input object cannot be null.");

            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/webrtc/checkFunds.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "ytel-api" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "account_sid", input.AccountSid ),
                new KeyValuePair<string, object>( "auth_token", input.AuthToken )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 