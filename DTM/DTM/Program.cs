using NCFDI;
using SAPB1SDK;
using SDK;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace DTM
{
    internal static class Program
    {

        public static SDK.DTM dtm = new SDK.DTM();

        public static List<Sucursal> sucursales = new List<Sucursal>();

        public static NSAPSQL SAP;

        public static CFDI CFDI;

        public static object ObjetoDinamico = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmHome());
            Application.Run(new frmHome());
        }
    }
}
