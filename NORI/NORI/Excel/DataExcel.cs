using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORI.Excel
{
    public class DataExcel
    {
        public DataTable LeerExcelEnDataTable(string rutaArchivo)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Para evitar advertencias de licencia

            using (var paquete = new ExcelPackage(new FileInfo(rutaArchivo)))
            {
                var hoja = paquete.Workbook.Worksheets[0]; // Accede a la primera hoja
                DataTable dt = new DataTable();

                // Leer encabezados
                foreach (var celda in hoja.Cells[1, 1, 1, hoja.Dimension.End.Column])
                {
                    dt.Columns.Add(celda.Text);
                }

                // Leer filas
                for (int fila = 2; fila <= hoja.Dimension.End.Row; fila++)
                {
                    DataRow nuevaFila = dt.NewRow();
                    for (int col = 1; col <= hoja.Dimension.End.Column; col++)
                    {
                        nuevaFila[col - 1] = hoja.Cells[fila, col].Text;
                    }
                    dt.Rows.Add(nuevaFila);
                }

                return dt;
            }
        }
    }
}
