using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrystalUpdater.Data
{
    [Serializable]
    public class UpdateFileInfo
    {
        public UpdateFileInfo(String name, String desc, String path, String md5)
        {
            Name = name;
            Size = desc;
            Path = path;
            MD5 = md5;
        }

        public String Name { get; set; }
        public String Size { get; set; }
        public String Path { get; set; }
        public String MD5 { get; set; }
    }
}
