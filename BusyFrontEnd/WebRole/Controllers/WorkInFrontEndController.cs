﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace WebRole.Controllers
{
    public class WorkInFrontEndController : ApiController
    {
        [HttpPost]
        [Route("api/workinfrontend")]
        public HttpResponseMessage Post()
        {
            // Never create your own thread directly, this is the negative example.

            new Thread(() =>  
            {
                //Simulate processing
                Thread.SpinWait(Int32.MaxValue / 100);
            }).Start();

            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
    }
}
