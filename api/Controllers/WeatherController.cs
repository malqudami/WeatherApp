using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        [Route("getWeather")]
        public IActionResult getWeather([FromBody]Weather whichDay)
        {
            var Day = JsonConvert.SerializeObject(whichDay.day);
            int d = Convert.ToInt32(Day);

            switch(d){
                case 1:
                    return Ok("Temp is: 23 C");
                case 2:
                    return Ok("Temp is: 25 C");
                case 3:
                    return Ok("Temp is: 27 C");
                case 4:
                    return Ok("Temp is: 28 C");
                case 5:
                    return Ok("Temp is: 30 C");
                case 6:
                    return Ok("Temp is: 32 C");
                case 7:
                    return Ok("Temp is: 36 C");
                default :
                    return Ok("Please Enter a number from 1 ... 7");
            }            
        }
    }
}