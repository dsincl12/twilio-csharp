using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Messaging.V1.Service 
{

    /// <summary>
    /// CreatePhoneNumberOptions
    /// </summary>
    public class CreatePhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The phone_number_sid
        /// </summary>
        public string PhoneNumberSid { get; }

        /// <summary>
        /// Construct a new CreatePhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="phoneNumberSid"> The phone_number_sid </param>
        public CreatePhoneNumberOptions(string pathServiceSid, string phoneNumberSid)
        {
            PathServiceSid = pathServiceSid;
            PhoneNumberSid = phoneNumberSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PhoneNumberSid != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumberSid", PhoneNumberSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeletePhoneNumberOptions
    /// </summary>
    public class DeletePhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeletePhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeletePhoneNumberOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// ReadPhoneNumberOptions
    /// </summary>
    public class ReadPhoneNumberOptions : ReadOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadPhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        public ReadPhoneNumberOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchPhoneNumberOptions
    /// </summary>
    public class FetchPhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchPhoneNumberOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchPhoneNumberOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}