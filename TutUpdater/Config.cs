using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrystalUpdater
{
    public static class Config
    {
        public static string LocalUpdateFile = @".\UpdateInfo.dat";
        public static string UpdateURL = "http://localhost:8081/Updates/UpdateInfo.dat";
        public static string NewsURL = "http://localhost:8081/news.txt";
    }
}
