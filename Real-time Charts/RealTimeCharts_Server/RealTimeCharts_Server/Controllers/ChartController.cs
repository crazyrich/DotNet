using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RealTimeCharts_Server.DataStorage;
using RealTimeCharts_Server.HubConfig;
using RealTimeCharts_Server.TimerFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeCharts_Server.Controllers
{
    [Route("api/chart")]
    [ApiController]
    public class ChartController :ControllerBase
    {
        private IHubContext<ChartHub> _hub;
        public ChartController(IHubContext<ChartHub> hub)
        {
            _hub = hub;
        }

        public IActionResult Get()
        {
            var timeManager = new TimeManager(() => _hub.Clients.All.SendAsync("transferChartData", DataManager.GetData()));
            return Ok(new { Message = "Request Completed!" });
        }
    }
}
