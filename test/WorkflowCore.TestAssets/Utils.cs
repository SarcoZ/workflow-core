﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkflowCore.TestAssets
{
    public static class Utils
    {
        private static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, DateFormatHandling = DateFormatHandling.IsoDateFormat, DateTimeZoneHandling = DateTimeZoneHandling.Utc };
              
        public static T DeepCopy<T>(T obj)
        {
            string str = JsonConvert.SerializeObject(obj, SerializerSettings);
            T result = JsonConvert.DeserializeObject<T>(str);
            return result;
        }
    }
}

