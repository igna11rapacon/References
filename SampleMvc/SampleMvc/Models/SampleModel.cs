using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvc.Models
{
    public class SampleModel
    {
        public string SampleProperty1 { get; set; }
        public string SampleProperty2 { get; set; }
        public string SampleProperty3 {
            get
            {
                return SampleProperty1 + SampleProperty2;
            }
        }
    }
}