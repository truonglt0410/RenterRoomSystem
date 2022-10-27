using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Domain.Base
{
    public class ResultDataModel
    {
        public object Data { get; set; }
        public string Status { get; set; }
        public string Messages { get; set; }

    }
}
