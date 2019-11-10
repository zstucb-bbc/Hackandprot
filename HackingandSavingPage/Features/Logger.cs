using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackingandSavingPage.Features
{
    public class Logger
    {

        public void Warning(String lines)
        {

            // Write the string to a file.append mode is enabled so that the log
            // lines get appended to  test.txt than wiping content and writing the log

            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Benjamin\\source\\repos\\Hackandprot\\HackingandSavingPage\\Logs\\logs.txt", true);
            file.WriteLine("WARNING: " + lines); ;

            file.Close();

        }

        public void Error(String lines)
        {

            // Write the string to a file.append mode is enabled so that the log
            // lines get appended to  test.txt than wiping content and writing the log

            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Benjamin\\source\\repos\\Hackandprot\\HackingandSavingPage\\Logs\\logs.txt", true);
            file.WriteLine("Error: " + lines); ;

            file.Close();

        }

        public void Info(String lines)
    {

        // Write the string to a file.append mode is enabled so that the log
        // lines get appended to  test.txt than wiping content and writing the log

        System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Benjamin\\source\\repos\\Hackandprot\\HackingandSavingPage\\Logs\\logs.txt", true);
            file.WriteLine("Info: " + lines); ;

            file.Close();

    }
    }
}
