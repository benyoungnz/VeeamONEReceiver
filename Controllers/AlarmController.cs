using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace VeeamONEReceiver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmController : ControllerBase
    {

        private readonly IHubContext<Hubs.AlarmHub> _alarmHubContext;
        public AlarmController(IHubContext<Hubs.AlarmHub> alarmHubContext)
        {
            _alarmHubContext = alarmHubContext;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "test", "test2" };
        }

        [HttpPost]
        public async Task<IActionResult> Receive([FromBody] Models.AlarmReceive alarm)
        {
            
            await _alarmHubContext.Clients.All.SendAsync("AlarmReceived", alarm);

            return Ok();
        }

    
    }
}
