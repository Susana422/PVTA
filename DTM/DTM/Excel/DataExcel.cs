using OfficeOpenXml;
using System;
using System.Data;
using System.IO;

namespace DTM.Excel
{
    public class DataExcel
    {
        public DataTable LeerExcelEnDataTable(string rutaArchivo)
        {
            DataTable dt = new DataTable();
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Para evitar advertencias de licencia

                using (var paquete = new ExcelPackage(new FileInfo(rutaArchivo)))
                {
                    var hoja = paquete.Workbook.Worksheets[0]; // Accede a la primera hoja

                    // Leer encabezados (primer fila)
                    dt.Columns.Add("Articulo"); // Columna 1: Articulo
                    dt.Columns.Add("Cantidad"); // Columna 2: Cantidad

                    // Leer filas a partir de la segunda (las filas de datos)
                    for (int fila = 2; fila <= hoja.Dimension.End.Row; fila++) // Empezamos desde la fila 2
                    {
                        DataRow nuevaFila = dt.NewRow();

                        // Accedemos a las celdas y verificamos su contenido
                        var articulo = hoja.Cells[fila, 1].Value?.ToString();
                        var cantidad = hoja.Cells[fila, 2].Value?.ToString();

                        // Si el valor es nulo o vacío, se asigna null, de lo contrario, se asigna el valor de la celda
                        nuevaFila["Articulo"] = string.IsNullOrEmpty(articulo) ? null : articulo;
                        nuevaFila["Cantidad"] = string.IsNullOrEmpty(cantidad) ? null : cantidad;

                        dt.Rows.Add(nuevaFila);
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes manejar la excepción y registrar el error, si es necesario
                Console.WriteLine("Error: " + ex.Message);
            }

            return dt;
        }


    }
}
