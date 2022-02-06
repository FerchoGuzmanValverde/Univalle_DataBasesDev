using System;
using Ferale.SistemaDeInformacionApp.ClienteBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using Ferale.SistemaDeInformacionApp.EmpleadoBrl;
using Ferale.SistemaDeInformacionApp.ProductosBrl;
using Ferale.SistemaDeInformacionApp.UsuarioBrl;
using System.Collections.Generic;
using Ferale.SistemaDeInformacionApp.VentasBrl;

namespace AplicacionPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cliente

            /*
             * Insertar cliente
             * Cliente cliente = new Cliente();

            Domicilio casita = new Domicilio();
            casita.Descripcion = "Calle los helechos";
            casita.Estado = 1;

            Provincia lugar = new Provincia();
            lugar.NombreProvincia = "Manuel Maria Caballero";
            lugar.IdProvincia = 1;

            TelefonosList lista = new TelefonosList();
            Telefono nuevo = new Telefono();
            nuevo.NroTelefono = "1234";
            lista.Add(nuevo);


            Usuario usuario = new Usuario();
            usuario.LoginUsuario = "fercho123";
            usuario.PasswordUsuario = "fercho123";

            cliente.CedulaIdentidad = "1234";
            cliente.Domicilio = casita;
            cliente.Estado = 1;
            cliente.Nombre = "Fernando";
            cliente.PrimerApellido = "Guzman";
            cliente.Provincia = lugar;
            cliente.RazonSocial = "Estudiante";
            cliente.SegundoApellido = "Valverde";
            cliente.Telefonos = lista;
            cliente.TipoPersona = 1;
            cliente.Usuario = usuario;
            ClienteBrl.Insertar(cliente);*/



            /*
             * Actualizar Cliente
             * Cliente cliente = new Cliente();

            Domicilio casita = new Domicilio();
            casita.Descripcion = "Calle las Orquideas";

            Provincia lugar = new Provincia();
            lugar.NombreProvincia = "Manuel Maria Caballero";
            lugar.IdProvincia = 1;

            TelefonosList lista = new TelefonosList();
            Telefono nuevo = new Telefono();
            nuevo.NroTelefono = "4321";
            lista.Add(nuevo);


            Usuario usuario = new Usuario();
            usuario.LoginUsuario = "fercho";
            usuario.PasswordUsuario = "fercho";

            cliente.IdCliente = 6;
            cliente.CedulaIdentidad = "4321";
            cliente.Domicilio = casita;
            cliente.Nombre = "Alejandro";
            cliente.PrimerApellido = "Valverde";
            cliente.Provincia = lugar;
            cliente.RazonSocial = "Administrador";
            cliente.SegundoApellido = "Guzman";
            cliente.Telefonos = lista;
            cliente.TipoPersona = 2;
            cliente.Usuario = usuario;
            ClienteBrl.Actualizar(cliente);*/



            /*
             * Eliminar Cliente
             * Cliente cliente = new Cliente();

            cliente.IdCliente = 6;

            ClienteBrl.Eliminar(cliente.IdCliente);*/



            /*
             * Obtener Cliente
             * Cliente cliente = new Cliente();

            cliente = ClienteBrl.Obtener(6);

            Console.WriteLine(cliente.Nombre);

            Console.ReadLine();*/

            #endregion

            #region Empleado

            /*
             * Insertar Empleado
             * Empleado empleado = new Empleado();

            Domicilio casita = new Domicilio();
            casita.Descripcion = "Calle los helechos";
            casita.Estado = 1;

            Provincia lugar = new Provincia();
            lugar.NombreProvincia = "Manuel Maria Caballero";
            lugar.IdProvincia = 1;

            TelefonosList lista = new TelefonosList();
            Telefono nuevo = new Telefono();
            nuevo.NroTelefono = "1234";
            lista.Add(nuevo);


            Usuario usuario = new Usuario();
            usuario.LoginUsuario = "ale123";
            usuario.PasswordUsuario = "ale123";

            Cargo cargo = new Cargo();
            cargo.IdCargo = 1;
            cargo.NombreCargo = "Administrador";

            empleado.CedulaIdentidad = "1234";
            empleado.Domicilio = casita;
            empleado.Estado = 1;
            empleado.Nombre = "Fernando";
            empleado.PrimerApellido = "Guzman";
            empleado.Provincia = lugar;
            empleado.FechaNacimiento = DateTime.Parse("18-03-1998");
            empleado.Sexo = 0;
            empleado.NroCuentaBancaria = "123456789";
            empleado.Cargo = cargo;
            empleado.SegundoApellido = "Valverde";
            empleado.Telefonos = lista;
            empleado.TipoPersona = 1;
            empleado.Usuario = usuario;
            EmpleadoBrl.Insertar(empleado);*/

            
            /*
             * Actualizar Empleado
             * Empleado empleado = new Empleado();

            Domicilio casita = new Domicilio();
            casita.Descripcion = "Barrio los Tajibos";
            casita.Estado = 1;

            Provincia lugar = new Provincia();
            lugar.NombreProvincia = "Manuel Maria Caballero";
            lugar.IdProvincia = 1;

            TelefonosList lista = new TelefonosList();
            Telefono nuevo = new Telefono();
            nuevo.NroTelefono = "4321";
            lista.Add(nuevo);


            Usuario usuario = new Usuario();
            usuario.LoginUsuario = "fer123";
            usuario.PasswordUsuario = "fer123";

            Cargo cargo = new Cargo();
            cargo.IdCargo = 1;
            cargo.NombreCargo = "Administrador";

            empleado.IdEmpleado = 7;
            empleado.CedulaIdentidad = "4321";
            empleado.Domicilio = casita;
            empleado.Estado = 1;
            empleado.Nombre = "Norma";
            empleado.PrimerApellido = "Valverde";
            empleado.Provincia = lugar;
            empleado.FechaNacimiento = DateTime.Parse("18-03-1998");
            empleado.Sexo = 0;
            empleado.NroCuentaBancaria = "12345";
            empleado.Cargo = cargo;
            empleado.SegundoApellido = "Morales";
            empleado.Telefonos = lista;
            empleado.TipoPersona = 1;
            empleado.Usuario = usuario;
            EmpleadoBrl.Actualizar(empleado);*/


            /*
             * Obtener Empleado
             * Empleado empleado = new Empleado();

            empleado = EmpleadoBrl.Obtener(7);

            Console.WriteLine(empleado.Nombre);

            Console.ReadLine();*/


            /*
             * Eliminar Empleado
             * Empleado empleado = new Empleado();

            empleado.IdEmpleado = 7;

            EmpleadoBrl.Eliminar(empleado.IdEmpleado);*/

            #endregion

            #region Producto

            /*
             * Insertar Producto
             * Producto producto = new Producto();

            producto.NombreProducto = "Chirimoya";
            producto.PrecioBase = 35;
            producto.Variedad = "Campas";
            producto.AreaProducto = 0;

            ProductoBrl.Insertar(producto);*/

            
            /*
             * ActualizarProducto
             * Producto producto = new Producto();

            producto.IdProducto = 1;
            producto.NombreProducto = "Chirimoyo";
            producto.PrecioBase = 30;
            producto.Variedad = "Atemoya";
            producto.AreaProducto = 0;

            ProductoBrl.Actualizar(producto);*/


            /*
             * Obtener Producto
             * Producto producto = new Producto();

            producto = ProductoBrl.Obtener(1);

            Console.WriteLine(producto.NombreProducto);

            Console.ReadLine();*/


            /*
             * Eliminar Producto
             * 
            ProductoBrl.Eliminar(1);
            */

            #endregion

            #region Usuarios

            /*
             * Insertar Usuario
             * Usuario user = new Usuario();

            user.LoginUsuario = "fernandito";
            user.PasswordUsuario = "fernandito";

            UsuariosBrl.Insertar(user);*/


            /*
             * Actualizar Usuario
             * Usuario user = new Usuario();

            user.IdUsuario = 8;
            user.LoginUsuario = "norma";
            user.PasswordUsuario = "norma";

            UsuariosBrl.Actualizar(user);*/


            /*
             * Obtener Usuario
             * Usuario user = new Usuario();

            user = UsuariosBrl.Obtener(8);

            Console.WriteLine(user.LoginUsuario);

            Console.ReadLine();*/


            /*
             * Eliminar Usuario
             * 
            UsuariosBrl.Eliminar(8);*/

            #endregion

            #region Cliente

            /*
             * INSERTAR VENTA Y ACTUALIZAR
             * int cantidad = 14;
            byte precio = 15;
            List<DetalleVenta> lst = new List<DetalleVenta>();
            Producto p = new Producto();
            p.IdProducto = 6;
            Cliente c = new Cliente();
            c.IdCliente = 14;
            Empleado e  = new Empleado();
            e.IdEmpleado = 13;

            DetalleVenta nuevo = new DetalleVenta();

            nuevo.cantidad = cantidad;
            nuevo.PrecioUnitario = precio;
            nuevo.Producto = p;

            Venta venta = new Venta();

            lst.Add(nuevo);

            venta.IdVenta = 1;
            venta.FechaHoraVenta = DateTime.Now;
            venta.MontoTotalFinal = cantidad * precio; //Arreglar para calcular con porcentaje de descuento
            venta.Descuento = 20;
            venta.TipoVenta = 1;
            venta.Cliente = c;
            venta.Empleado = e;
            venta.Detalles = lst;

            //VentaBrl.Insertar(venta);

            VentaBrl.Actualizar(venta, venta.IdVenta);*/

            /*
             * OBTENER VENTA
             * Venta nuevo = new Venta();

            nuevo = VentaBrl.Obtener(1);

            Console.WriteLine(nuevo.Cliente.Nombre);

            Console.Read();*/

            /*
             * ELIMINAR VENTA
             * VentaBrl.Eliminar(1);*/

            #endregion
        }
    }
}
