//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
// copyright (c) 2020. All rights reserved.
// </copyright>
// <creator name="Shivam Dewangan"/>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApp1
{
    /// <summary>
    /// Main Class to Call Programs.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The log.
        /// </summary>
        private static readonly ILog Log = LogHelper.GetLogger(); // log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {

            Console.WriteLine("1. Anagram \n 2. bubbleSort");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Anagram.AnaGram();
                    break;

                case 2:
                    BubbleSort.Sorting();
                    break;

                case 3:
             
                    break;
            }

            Console.ReadLine();
        }
    }
}
