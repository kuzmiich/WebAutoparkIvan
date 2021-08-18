﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutopark.DataAccess.Repositories.Specification.Provider
{
    public class EntityInfo
    {
        internal EntityInfo(string tableName)
        {
            TableName = tableName;
            KeyName = tableName.Remove(tableName.Length - 1);
        }

        public string TableName { get; }
        public string KeyName { get; }
    }
}