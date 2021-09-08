using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagkageHusWebApp.Services
{
    public static class PostService
    {
        static object lockobject = new object();

        public static bool SendInformation(bool kiosk, List<string> obj)
        {
            if (WriteToFile.PathExist(kiosk))
            {
                byte[] barr = Encoding.UTF8.GetBytes(obj.ToString());
                WriteToFile.Write(kiosk,barr);
                return true;
            }
            return false;
        }

    }
}
