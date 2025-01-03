using DevExpress.XtraSplashScreen;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NORI.API
{
    internal class Recibir
    {
        public async Task<bool> Articulos()
        {
            try
            {
                ArticuloAPI api = new ArticuloAPI();
                DateTime fecha_inicio_sincronizacion = DateTime.Now;
                FechaSincronizacion fecha_sincronizacion = FechaSincronizacion.Obtener("articulos");
                fecha_sincronizacion.fecha = fecha_sincronizacion.fecha.AddMinutes(-3.0);
                List<ArticuloAPI> articulos = await api.ActualizadosAPI(fecha_sincronizacion.fecha);
                int index_articulos = 0;
                foreach (ArticuloAPI articulo_api in articulos)
                {
                    try
                    {
                        SplashScreenManager.Default.SetWaitFormDescription($"Recibiendo artículo {index_articulos} de {articulos.Count}");
                        Articulo articulo_local = Articulo.Obtener(articulo_api.articulo.sku);
                        int articulo_id = articulo_local.id;
                        articulo_api.articulo.CopyProperties(articulo_local);
                        articulo_local.id = articulo_id;
                        if (articulo_id != 0)
                        {
                            articulo_local.Actualizar();
                        }
                        else
                        {
                            articulo_local.Agregar();
                        }
                        try
                        {
                            List<Articulo.Precio> precios = articulo_api.precios;
                            foreach (Articulo.Precio precio in precios)
                            {
                                Articulo.Precio precio_local = Articulo.Precio.Obtener(articulo_local.id, precio.lista_precio_id);
                                int precio_id = precio_local.id;
                                precio.CopyProperties(precio_local);
                                precio_local.id = precio_id;
                                precio_local.articulo_id = articulo_local.id;
                                if (precio_id != 0)
                                {
                                    precio_local.Actualizar();
                                }
                                else
                                {
                                    precio_local.Agregar();
                                }
                            }
                        }
                        catch
                        {
                            goto end_IL_0122;
                        }
                        try
                        {
                            List<Articulo.Inventario> inventarios = articulo_api.inventario;
                            foreach (Articulo.Inventario inventario in inventarios)
                            {
                                Articulo.Inventario inventario_local = Articulo.Inventario.Obtener(articulo_local.id, inventario.almacen_id);
                                int inventario_id = inventario_local.id;
                                inventario.CopyProperties(inventario_local);
                                inventario_local.id = inventario_id;
                                inventario_local.articulo_id = articulo_local.id;
                                if (inventario_id != 0)
                                {
                                    inventario_local.Actualizar();
                                }
                                else
                                {
                                    inventario_local.Agregar();
                                }
                            }
                        }
                        catch
                        {
                            goto end_IL_0122;
                        }
                        goto IL_0421;
                    end_IL_0122:;
                    }
                    catch
                    {
                    }
                    continue;
                IL_0421:
                    index_articulos++;
                }
                fecha_sincronizacion.Actualizar(fecha_inicio_sincronizacion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private async Task<bool> Precios(FechaSincronizacion fecha_sincronizacion)
        {
            try
            {
                ArticuloAPI articulo_api = new ArticuloAPI();
                fecha_sincronizacion.fecha = fecha_sincronizacion.fecha.AddMinutes(-3.0);
                foreach (Articulo.Precio precio in await articulo_api.PreciosActualizados(fecha_sincronizacion.fecha))
                {
                    try
                    {
                        Articulo.Precio precio_local = Articulo.Precio.Obtener(precio.articulo_id, precio.lista_precio_id);
                        precio.CopyProperties(precio_local);
                        if (precio_local.id != 0)
                        {
                            precio_local.Actualizar();
                        }
                        else
                        {
                            precio_local.Agregar();
                        }
                    }
                    catch
                    {
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private async Task<bool> Inventario(FechaSincronizacion fecha_sincronizacion)
        {
            try
            {
                ArticuloAPI articulo_api = new ArticuloAPI();
                fecha_sincronizacion.fecha = fecha_sincronizacion.fecha.AddMinutes(-3.0);
                foreach (Articulo.Inventario inventario in await articulo_api.InventariosActualizados(fecha_sincronizacion.fecha))
                {
                    try
                    {
                        Articulo.Inventario inventario_local = Articulo.Inventario.Obtener(inventario.articulo_id, inventario.almacen_id);
                        inventario.CopyProperties(inventario_local);
                        if (inventario_local.id != 0)
                        {
                            inventario_local.Actualizar();
                        }
                        else
                        {
                            inventario_local.Agregar();
                        }
                    }
                    catch
                    {
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private async Task<bool> CodigosBarras(FechaSincronizacion fecha_sincronizacion)
        {
            try
            {
                ArticuloAPI articulo_api = new ArticuloAPI();
                fecha_sincronizacion.fecha = fecha_sincronizacion.fecha.AddMinutes(-3.0);
                foreach (Articulo.CodigoBarras codigo_barras in await articulo_api.CodigosBarrasActualizados(fecha_sincronizacion.fecha))
                {
                    try
                    {
                        Articulo.CodigoBarras codigo_barras_local = Articulo.CodigoBarras.Obtener(codigo_barras.codigo);
                        codigo_barras.CopyProperties(codigo_barras_local);
                        if (codigo_barras_local.id != 0)
                        {
                            codigo_barras_local.Actualizar();
                        }
                        else
                        {
                            codigo_barras_local.Agregar();
                        }
                    }
                    catch
                    {
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Descuentos()
        {
            try
            {
                ArticuloAPI articulo_api = new ArticuloAPI();
                DateTime fecha_inicio_sincronizacion = DateTime.Now;
                FechaSincronizacion fecha_sincronizacion = FechaSincronizacion.Obtener("descuentos");
                fecha_sincronizacion.fecha = fecha_sincronizacion.fecha.AddMinutes(-3.0);
                foreach (Descuento descuento3 in await articulo_api.DescuentosActualizados(fecha_sincronizacion.fecha))
                {
                    try
                    {
                        Descuento descuento_local3 = Descuento.Obtener(descuento3.articulo_id, descuento3.socio_id, descuento3.lista_precio_id);
                        int descuento_id3 = descuento_local3.id;
                        descuento3.CopyProperties(descuento_local3);
                        if (descuento_id3 != 0)
                        {
                            descuento_local3.Actualizar();
                        }
                        else
                        {
                            descuento_local3.Agregar();
                        }
                    }
                    catch
                    {
                    }
                }
                foreach (Descuento.Periodo descuento2 in await articulo_api.DescuentosPeriodoActualizados(fecha_sincronizacion.fecha))
                {
                    try
                    {
                        Descuento.Periodo descuento_local2 = Descuento.Periodo.Obtener(descuento2.articulo_id, descuento2.socio_id, descuento2.lista_precio_id);
                        int descuento_id2 = descuento_local2.id;
                        descuento2.CopyProperties(descuento_local2);
                        if (descuento_id2 != 0)
                        {
                            descuento_local2.Actualizar();
                        }
                        else
                        {
                            descuento_local2.Agregar();
                        }
                    }
                    catch
                    {
                    }
                }
                foreach (Descuento.Cantidad descuento in await articulo_api.DescuentosCantidadActualizados(fecha_sincronizacion.fecha))
                {
                    try
                    {
                        Descuento.Cantidad descuento_local = Descuento.Cantidad.Obtener(descuento.cantidad, descuento.articulo_id, descuento.socio_id);
                        int descuento_id = descuento_local.id;
                        descuento.CopyProperties(descuento_local);
                        if (descuento_id != 0)
                        {
                            descuento_local.Actualizar();
                        }
                        else
                        {
                            descuento_local.Agregar();
                        }
                    }
                    catch
                    {
                    }
                }
                fecha_sincronizacion.Actualizar(fecha_inicio_sincronizacion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Socios()
        {
            try
            {
                SocioAPI socio_api = new SocioAPI();
                DateTime fecha_inicio_sincronizacion = DateTime.Now;
                FechaSincronizacion fecha_sincronizacion = FechaSincronizacion.Obtener("socios");
                fecha_sincronizacion.fecha = fecha_sincronizacion.fecha.AddMinutes(-3.0);
                foreach (Socio socio in await socio_api.Actualizados(fecha_sincronizacion.fecha))
                {
                    try
                    {
                        Socio socio_local = Socio.Obtener(socio.codigo);
                        int socio_id = socio_local.id;
                        socio.CopyProperties(socio_local);
                        if (socio_id != 0)
                        {
                            socio_local.Actualizar(agregar_sincronizacion: false);
                        }
                        else
                        {
                            socio_local.Agregar(agregar_sincronizacion: false);
                        }
                        foreach (Socio.Direccion direccion in await socio_api.Direcciones(socio.id))
                        {
                            Socio.Direccion direccion_local = Socio.Direccion.Obtener(socio_local.id, direccion.nombre);
                            _ = direccion_local.id;
                            direccion.CopyProperties(direccion_local);
                            direccion_local.socio_id = socio_local.id;
                            if (direccion_local.id != 0)
                            {
                                direccion_local.Actualizar();
                            }
                            else
                            {
                                direccion_local.Agregar();
                            }
                        }
                        foreach (Socio.PersonaContacto persona_contacto in await socio_api.PersonasContacto(socio.id))
                        {
                            Socio.PersonaContacto persona_contacto_local = Socio.PersonaContacto.Obtener(socio_local.id, persona_contacto.codigo);
                            int persona_contacto_id = persona_contacto_local.id;
                            persona_contacto.CopyProperties(persona_contacto_local);
                            persona_contacto_local.socio_id = socio_local.id;
                            if (persona_contacto_id != 0)
                            {
                                persona_contacto_local.Actualizar();
                            }
                            else
                            {
                                persona_contacto_local.Agregar();
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                fecha_sincronizacion.Actualizar(fecha_inicio_sincronizacion);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
