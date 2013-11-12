using StudentApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplication.Services.Concrete
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Administrator\Downloads\WriteLines2.txt", true))
            {
                file.WriteLine(message);
            }
        }
    }
}