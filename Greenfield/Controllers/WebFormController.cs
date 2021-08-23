﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Greenfield.Controllers
{
    [ApiController]
    [Route("WebForm1.aspx")]
    public class WebFormController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "GREENFIELD ASPX";
        }
    }
}