using NoriCFDI;
using NoriSAPB1SDK;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace NORI
{
    internal static class Program
    {

        public static NoriSDK.Nori Nori = new NoriSDK.Nori();

        public static List<Sucursal> sucursales = new List<Sucursal>();

        public static NoriSAPSQL NoriSAP;

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
            Application.Run(new FormVistaPrevia());
        }
    }
}
