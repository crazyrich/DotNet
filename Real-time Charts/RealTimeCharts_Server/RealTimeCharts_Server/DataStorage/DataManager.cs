using RealTimeCharts_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeCharts_Server.DataStorage
{
    public class DataManager
    {
        public static List<ChartModel> GetData()
        {
            var random = new Random();
            return new List<ChartModel>()
            {
                new ChartModel{ Data = new List<int>{ random.Next(1,40)},Label ="Barcelona" },
                new ChartModel{ Data = new List<int>{ random.Next(1,40)},Label ="Liverpool" },
                new ChartModel{ Data = new List<int>{ random.Next(1,40)},Label="Ajax" },
                new ChartModel{ Data = new List<int>{ random.Next(1,40)},Label="Tottenham Hotspur" }
            };
        }
    }
}
