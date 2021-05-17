﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.csFile
{
    public static class Global
    {
        static Global() { UserID = 1234; }
        public static int UserID { get; private set; }

        public static void setUserID(int id)
        {
            UserID = id;
        }
    }
}
