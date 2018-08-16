using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Voice;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace msft_gather_2.Controllers
{
    public class VoiceController : TwilioController
    {
        public TwiMLResult Index()
        {
            var response = new VoiceResponse();
            var gather = new Gather(action: new Uri("http://corey.ngrok.io/action"), input: new List<Gather.InputEnum> { Gather.InputEnum.Speech });
            gather.Say("Hi. I'm looking for Corey Weathers");
            response.Append(gather);
            return TwiML(response);
        }
    }
}
