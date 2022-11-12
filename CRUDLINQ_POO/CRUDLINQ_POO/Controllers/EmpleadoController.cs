using CRUDLINQ_POO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDLINQ_POO.Controllers
{
    public class EmpleadoController
    {
        public EmpleadoController()
        {
            _Empleado = new List<Empleado>();
        }

        private List<Empleado> _Empleado;
        public List<Empleado> Empleado { get { return _Empleado; } }

        private bool ListaVacia()
        {
            if (Empleado.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Listar empleadoos
        #region get
        public void Lista()
        {
            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encontraron registros");
            }
            else
            {
                Console.WriteLine("Total de Registros de empleados : " + Empleado.Count);
                Console.WriteLine("---------Listado de Empleados---------");
                foreach (Empleado item in _Empleado)
                {
                    Imprimir(item);
                }
            }
        }
        #endregion get

        //Metodo que imprime los datos de empleado

        private void Imprimir(Empleado dato)
        {
            Console.WriteLine("\n");
            Console.WriteLine("| Id : {0} | Nombre : {1} | Apellidos : {2} | Direccion : {3} | Telefono: {4} | Fecha_Ingreso: {5} | IdArea: {6} |", dato.Id, dato.Nombre, dato.Apellidos, dato.Direccion, dato.Telefono, dato.Fecha_Ingreso, dato.IdArea);

        }

        //buscar registro por id
        #region getbyid
        public void BuscarxId()
        {
            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encuentran datos en la lista");
            }
            else
            {
                int buscar;
                Console.Write("Ingrese el id a buscar: ");
                buscar = Convert.ToInt32(Console.ReadLine());

                foreach (Empleado item in _Empleado)
                {
                    if (buscar == item.Id)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("| Id : {0} | Nombre : {1} | Apellidos : {2} | Direccion : {3} | Telefono: {4} | Fecha_Ingreso: {5} | IdArea: {6} |", item.Id, item.Nombre, item.Apellidos, item.Direccion, item.Telefono, item.Fecha_Ingreso, item.IdArea);

                    }
                    else
                    {
                        Console.WriteLine("No se encontraron registros con ese id");
                    }
                }
            }
        }
        #endregion getbyid

        //Insertar registro en empleado
        #region post

        public void PostEmpleado(int id, string nombre, string apellidos, string direccion, string telefono, DateTime fecha_ingreso, int idArea)
        {
            var verificarId = Empleado.Any(i => i.Id == id);

            Console.WriteLine("---------Insertar Empleado---------");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese Id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Apellidos:");
            apellidos = Console.ReadLine();

            Console.WriteLine("Ingrese Direccion:");
            direccion = Console.ReadLine();

            Console.WriteLine("Ingrese Telefono:");
            telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el Id del Area:");
            idArea = Convert.ToInt32(Console.ReadLine());

            if (!verificarId)
            {
                Empleado.Add(new Empleado()
                {
                    Id = id,
                    Nombre = nombre,
                    Apellidos = apellidos,
                    Direccion = direccion,
                    Telefono = telefono,
                    Fecha_Ingreso = fecha_ingreso,
                    IdArea = idArea

                });
                Console.WriteLine("Datos almacenados correctamente");
            }
            else
            {
                Console.WriteLine("El id ya se encuentra registrado");
            }

        }
        #endregion post

        //Actualizar registro en empleado
        #region put
        public void UpdateEmpleado()
        {
            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato");
            }
            else
            {
                Empleado ap = new Empleado();
                int buscar;
                Console.Write("Ingresa id : ");
                buscar = Convert.ToInt32(Console.ReadLine());
                foreach (Empleado item in _Empleado)
                {
                    if (buscar == item.Id)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("| Id : {0} | Nombre : {1} | Apellidos : {2} | Direccion : {3} | Telefono: {4} | Fecha_Ingreso: {5} | IdArea: {6} |", item.Id, item.Nombre, item.Apellidos, item.Direccion, item.Telefono, item.Fecha_Ingreso, item.IdArea);
                        Console.WriteLine("\n");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Ingrese Id:");
                        ap.Id = Convert.ToInt32(Console.ReadLine());
                        item.Id = ap.Id;

                        Console.WriteLine("Ingrese Nombre:");
                        ap.Nombre = Console.ReadLine();
                        item.Nombre = ap.Nombre;

                        Console.WriteLine("Ingrese Apellidos:");
                        ap.Apellidos = Console.ReadLine();
                        item.Apellidos = ap.Apellidos;

                        Console.WriteLine("Ingrese Direccion:");
                        ap.Direccion = Console.ReadLine();
                        item.Direccion = ap.Direccion;

                        Console.WriteLine("Ingrese Telefono:");
                        ap.Telefono = Console.ReadLine();
                        item.Telefono = ap.Telefono;

                        Console.WriteLine("Ingrese el Id del Area:");
                        ap.IdArea = Convert.ToInt32(Console.ReadLine());
                        item.IdArea = ap.IdArea;

                        Console.Write("\n");
                        Console.WriteLine("Datos modificados");
                    }else
                    {
                        Console.WriteLine("El id ingresado no existe");
                    }
                }
            }
        }
        #endregion put

        //Eliminar registro de empleados
        #region delete
        public void DeletexId(int id)
        {
            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }
            else
            {
                Console.WriteLine("Ingrese Id: ");
                id = Convert.ToInt32(Console.ReadLine());

                var element = Empleado.FirstOrDefault(i => i.Id == id);
                if (element != null)
                {
                    Empleado.Remove(element);
                    Console.WriteLine("\n");
                    Console.WriteLine("Registro eliminado correctamente");
                }
                else
                {
                    Console.WriteLine("No hay elemento con ese id");
                }

            }

        }
        #endregion delete

    }
}









