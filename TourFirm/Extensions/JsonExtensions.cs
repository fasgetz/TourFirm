using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourFirm.Extensions
{

    /// <summary>
    /// Расширения JSON <see cref="Newtonsoft.Json"/>
    /// </summary>
    public static class JsonExtensions
    {
        /// <summary>
        /// Сериализация объекта с виртуальными свойствами
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeObjectRefLoopHandl(this object? obj)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
            
            return json;
        }
    }
}
