﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Праткическая_49_Тепляков.Context.Config
{
    public class Config
    {
        public static readonly string StrConnect = "server=127.0.0.1;port=3303;uid=root;database=TaskManager";
        public static MySqlServerVersion mySqlServerVersion = new MySqlServerVersion(new System.Version(8, 0, 11));
    }
}
