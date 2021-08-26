using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
       public static void Main(string first,string second)
        {
            try
            {
                if (first == "-v")
                {
                    Console.WriteLine(ThirdPartyTools.FileDetails.Version(second));
                }

                else if (first == "-v" || first == "--v" || first == "/v" || first == "--version")
                {
                    Console.WriteLine(ThirdPartyTools.FileDetails.Version(second));
                }
                else if (first == "-s" || first == "--s" || first == "/s" || first == "--size")
                {
                    Console.WriteLine(ThirdPartyTools.FileDetails.Size(second));
                }
            }



            catch(Exception ex)
            {
                log.error(ex.Message);
            }
    
    }
    }
}
