﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackingandSavingPage.Features
{
    public class Logger
    {

    
    public void log(String lines)
    {

        // Write the string to a file.append mode is enabled so that the log
        // lines get appended to  test.txt than wiping content and writing the log

        System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\log.txt", true);
        file.WriteLine(lines);

        file.Close();

    }

    }
}
