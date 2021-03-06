﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PolicyProvider.Controllers
{
    [Route("api/[controller]")]
    [Controller]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [MinimumAgeAuthorize(21)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [MinimumAgeAuthorize(18)]
        public string Get(int id)
        {
            return "value";
        }
    }
}
