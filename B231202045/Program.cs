/******************************************************************************
 *                    OBJECT ORIENTED PROGRAMMING PROJECT                     *
 ****************************************************************************** 
 * Student Name   : Berkan                                                    *
 * Student Surname: Akten                                                     *
 * Student Number : B231202045                                                *
 * Lecturer       : Gülüzar Çit                                               *
 * Course Name    : OBJECT ORIENTED PROGRAMMING                               *
 * Assignment     : Term Project                                              *
 * Date Submitted : 15.05.2025                                                *
 ******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B231202045
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
