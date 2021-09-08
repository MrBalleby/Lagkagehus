using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LagkageHusWebApp.Services
{
    public static class WriteToFile
    {
        public static bool PathExist(bool Kiosk)
        {
            if (Kiosk)
            {
                bool b = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Kiosk"));
                if (!b)
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Kiosk"));
                }
                return b;
            }
            else
            {
                bool b = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Bruger"));
                if (!b)
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Bruger"));
                }
                return b;
            }
        }

        public static bool Write(bool Kiosk, byte[] data)
        {
            if (Kiosk)
            {
                try
                {
                    using (FileStream file = File.OpenWrite(Path.Combine(Directory.GetCurrentDirectory(), "Kiosk")))
                    {
                        file.Write(data);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    using (FileStream file = File.OpenWrite(Path.Combine(Directory.GetCurrentDirectory(), "Bruger")))
                    {
                        file.Write(data);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
