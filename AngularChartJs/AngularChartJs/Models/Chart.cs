using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularChartJs.Models
{
    public class Chart
    {
        public string Series { get; set; }
        public List<ChartData> ChartData { get; set; }
    }
}