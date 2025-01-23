using SAPB1SDK;
using SDK;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DTM
{

    public static class FuncionesSAP
    {
        public static DataTable ObtenerExistencias(string sku)
        {
            try
            {
                return DBSAP.EjecutarQuery($"SELECT ItemCode SKU, WhsCode Almacén, OnHand Stock FROM OITW WHERE ItemCode = '{sku}' AND OnHand > 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM") + NSAP.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                return new DataTable();
            }
        }

        public static decimal ObtenerStock(string sku, string almacen)
        {
            try
            {
                decimal num = DBSAP.EjecutarEscalarDecimal($"SELECT OnHand FROM OITW WHERE ItemCode = '{sku}' AND WhsCode = '{almacen}'");
                if (num == 0m && Articulo.Articulos().Any((Articulo x) => x.sku == sku && !x.almacenable))
                {
                    num = 100m;
                }
                return num;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM") + NoriSAP.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                return 0m;
            }
        }

        public static bool StockNegativo(decimal cantidad, string sku, string unidad_medida, string almacen)
        {
            try
            {
                decimal num = DBSAP.EjecutarEscalarDecimal(string.Format("SELECT OnHand / (SELECT BaseQty FROM UGP1 WHERE UgpEntry = (SELECT UgpEntry FROM OITM WHERE ItemCode = '{0}') AND UomEntry = '{1}') FROM OITW WHERE ItemCode = '{0}' AND WhsCode = '{2}'", sku, unidad_medida, almacen));
                if (num <= 0m && Articulo.Articulos().Any((Articulo x) => x.sku == sku && !x.almacenable))
                {
                    num = 100m;
                }
                return (num < cantidad) ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM") + NoriSAP.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                return false;
            }
        }
    }

}
