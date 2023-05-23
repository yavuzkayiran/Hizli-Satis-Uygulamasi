using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.AppMpdels
{
    class configFile
    {
        static string filepath = "config.json";
        int a;

        public configFile()
        {

        }


        public static object readConfig()
        {
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);
                foreach (var item in jobj.Properties())
                {
                    item.Value = item.Value.ToString().Replace("v1", "v2");
                }
                return jobj;

            }


        }
        public static void writeConfig(string result)
        {

            File.WriteAllText(filepath, result);

        }

    }
}
