using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cloud_app.Context;
using cloud_app.Domain;
using Microsoft.AspNetCore.Mvc;

namespace cloud_app.Controllers
{   
    [Route("api")]
    [ApiController]
    public class Controller : ControllerBase
    {   

        private readonly ApplicationContext _applicationContext;
        
        public Controller(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        [HttpGet]
        public IActionResult Hello()
            {
                if (!_applicationContext.Data.Any())
                {
                    _applicationContext.Data.Add(new Data {Value = 1});
                }
                else
                {
                    _applicationContext.Data.First().Value++;
                }

                _applicationContext.SaveChanges();

                return Ok(_applicationContext.Data);
            }
    }
}