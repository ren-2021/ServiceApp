﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using ServiceApp.ServiceApp.ServiceLayer.Services;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.ModelRequest;
using ServiceApp.Shared.Model.Services.Accounting;
using Unity;

namespace ServiceApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private ITransactionService transactionService;

        public TransactionController(ITransactionService _transactionService)
        {

            this.transactionService = _transactionService;
        }

        [HttpPost("Process")]
        public ActionResult<bool> Process([FromBody] JsonRequest _jsonRequest)
        {
            MainRequest mainRequest = new MainRequest();
            mainRequest = JsonConvert.DeserializeObject<MainRequest>(_jsonRequest.JsonString);
            return this.transactionService.AddTransaction(_jsonRequest.JsonString);
        }
    }
}