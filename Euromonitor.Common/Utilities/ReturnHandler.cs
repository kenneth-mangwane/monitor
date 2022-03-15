using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euromonitor.Common.Utilities
{
    public class ReturnHandler
    {
        public static object Handle<T>(T data)
        {
            if (data is Exception)
            {
                return new { error = true, message = data?.ToString(), data };
            }
            else
            {
                return new { error = false, message = "success", data };
            }
        }
    }
}
