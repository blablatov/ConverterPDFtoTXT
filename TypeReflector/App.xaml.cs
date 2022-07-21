using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Text;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Collections;
using System.Xml;
using System.IO;
using System.Collections.ObjectModel;

namespace TypeReflector
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

    }


    static class Data
    {
        public static string strGetPdfFile { get; set; }
        public static string strPutTxtFile { get; set; }
   
    }
}
