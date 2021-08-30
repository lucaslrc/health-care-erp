using System;
using System.IO;

namespace HealthCareERP.Utils
{
    public class Log
    {
        public static void CommitInLog(string content)
        {
            var pathLogFile = @"../Public/System/log.txt";
             
             try
             {
                 File.WriteAllTextAsync(pathLogFile, content);
             }
             catch (System.Exception ex)
             {
                 throw new Exception(ex.ToString());
             }
        }
    }
}