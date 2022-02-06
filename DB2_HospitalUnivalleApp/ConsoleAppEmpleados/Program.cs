using System;
using System.Collections.Generic;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl;


namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.ConsoleAppEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pruebas para telefono
            /*  Telefono telefono1 = new Telefono()
              {   IdTelefono = Guid.NewGuid(),
                  Numero = 12345678,
                  TipoTelefono = new TipoTelefono() { IdTipoTelefono = 1 },
                  Persona = new Persona() { IdPersona = new System.Guid("3f2504e0-4f89-11d3-9a0c-0305e82c3301") }
              };

              EmpleadosBrl.TelefonoBrl.Insertar(telefono1);*/

            /*Telefono telefono1 = EmpleadosBrl.TelefonoBrl.Obtener(new System.Guid("f4f47414-d404-470b-92d1-b5d06e602dbf"));
            telefono1.Numero = 1111111;

            EmpleadosBrl.TelefonoBrl.Actualizar(telefono1);*/

            // EmpleadosBrl.TelefonoBrl.Eliminar(new System.Guid("f4f47414-d404-470b-92d1-b5d06e602dbf"));

            //Pruebas para Usuario
            /* Usuario usuario1 = new Usuario()
             {   IdUsuario= Guid.NewGuid(),
                 Contrasenia = "12345678",
                 Nombre = "anonimus"
             };
             UsuarioBrl.Insertar(usuario1);

             usuario1.Nombre = "juanito";
             UsuarioBrl.Actualizar(usuario1);

             Usuario usuario2 = UsuarioBrl.Obtener(usuario1.IdUsuario);

             UsuarioBrl.Eliminar(usuario1.IdUsuario);*/

            //Pruebas para solo Persona
            /*Persona persona1 = new Persona()
            {
                IdPersona = Guid.NewGuid(),
                Nombre = "Carlos",
                PrimerApellido = "Gamboa",
                SegundoApellido = "Siles",
            };

            persona1.Usuario = new Usuario()
            {
                IdUsuario = persona1.IdPersona,
                Nombre = "carlosgs",
                Contrasenia = "123"
            };

            Telefono telefono1 = new Telefono()
            {
                IdTelefono = Guid.NewGuid(),
                Numero = 12345678,
                TipoTelefono = new TipoTelefono() { IdTipoTelefono = 1 },
                Persona = new Persona() { IdPersona = persona1.IdPersona }
            };

            persona1.Telefonos = new List<Telefono>();
            persona1.Telefonos.Add(telefono1);

            Telefono telefono2 = new Telefono()
            {
                IdTelefono = Guid.NewGuid(),
                Numero = 22222222,
                TipoTelefono = new TipoTelefono() { IdTipoTelefono = 2 },
                Persona = new Persona() { IdPersona = persona1.IdPersona },
            };
            persona1.Telefonos.Add(telefono2);

            PersonaBrl.Insertar(persona1);*/

            //Pruebas para solo Empleados
          /*  Empleado empleado1 = new Empleado()
            {
                IdPersona = Guid.NewGuid(),
                Nombre = "Maria",
                PrimerApellido = "Rosales",
                SegundoApellido = "Siles",
                FechaContratacion = DateTime.Now
            };

            empleado1.Usuario = new Usuario()
            {
                IdUsuario = empleado1.IdPersona,
                Nombre = "mariars",
                Contrasenia = "123"
            };

            Telefono telefono1 = new Telefono()
            {
                IdTelefono = Guid.NewGuid(),
                Numero = 12345678,
                TipoTelefono = new TipoTelefono() { IdTipoTelefono = 1 },
                Persona = empleado1 
            };

            empleado1.Telefonos = new List<Telefono>();
            empleado1.Telefonos.Add(telefono1);

            Telefono telefono2 = new Telefono()
            {
                IdTelefono = Guid.NewGuid(),
                Numero = 22222222,
                TipoTelefono = new TipoTelefono() { IdTipoTelefono = 2 },
                Persona = empleado1
            };
            empleado1.Telefonos.Add(telefono2);

            EmpleadoBrl.Insertar(empleado1);*/

            Empleado empleado = EmpleadosBrl.EmpleadoBrl.Obtener(new Guid("fb708293-97af-40ac-a83b-3dd42f022890"));
            empleado.Telefonos[0].Numero = 888888;
            EmpleadosBrl.EmpleadoBrl.Actualizar(empleado);

        }
    }
}
