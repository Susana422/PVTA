using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using NoriCFDI;
using NoriSAPB1SDK;
using NoriSDK;


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
            Application.Run(new frmAcceder());
        }
    }
}
