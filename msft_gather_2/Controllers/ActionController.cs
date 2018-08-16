using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace msft_gather_2.Controllers
{
    public class ActionController : TwilioController
    {
        public TwiMLResult Index([FromBody]string speechResult)
        {
            var response = new VoiceResponse();
            response.Say($"I think we've captured the result here: {speechResult}");
            return TwiML(response);
        }
    }
}
