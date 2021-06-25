using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CankutayUcarMvc.WebUI.Helper
{
    public static class SessionGeneratorHelper
    {
        public static void SetObject(this ISession obj, object o, string key)
        {
            string veri = Newtonsoft.Json.JsonConvert.SerializeObject(o);
            obj.SetString(key, veri);
        }
        public static T GetObject<T>(this ISession obj, string key)
            where T : new()
        {
            T t = new T();
            string veri = obj.GetString(key);
            if (veri != null) { t = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(veri); }
            return t;
        }
    }
}
