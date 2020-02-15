//-----------------------------------------------------------------------
// <copyright file="BubbleSort.cs" company="BridgeLabz">
// copyright (c) 2020. All rights reserved.
// </copyright>
// <creator name="Shivam Dewangan"/>
//-----------------------------------------------------------------------
namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// BubbleSort Class.
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// The log.
        /// </summary>
        private static readonly log4net.ILog Log = LogHelper.GetLogger();

        /// <summary>
        /// Sorting this instance.
        /// </summary>
        public static void Sorting()
        {
            try
            {
                Console.WriteLine("Enter Length of Array:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter elements of array:");
                int[] array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                int temp;

                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        while (array[i] > array[i + 1])
                        {
                            temp = array[i + 1];
                            array[i + 1] = array[i];
                            array[i] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted Array is:");
                foreach (int p in array)
                {
                    Console.Write(p + " ");
                }
            }
            catch (System.FormatException)
            {
                Log.Error("Invalid Format Exception, Array should be of Integer type.");
            }
            catch (System.OverflowException)
            {
                Log.Error("\n OverFlowException,Enter length of Array in Postive Value.");
            }
        }
    }
}
