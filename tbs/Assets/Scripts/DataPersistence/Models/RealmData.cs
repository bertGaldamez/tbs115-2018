﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.DataPersistence.Models
{
    [Serializable]
    public class RealmData : IDataType
    {
        private Dictionary<string, string> data = new Dictionary<string, string>();
        
        public string LoadDataLocally(string key)
        {
            if (data.ContainsKey(key))
                return data[key];
            return null;
        }

        public void SaveDataLocally(string key, string value)
        {
                data.Add(key, value);
                
        }
    }
}
