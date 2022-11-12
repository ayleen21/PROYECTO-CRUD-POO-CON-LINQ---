using CRUDLINQ_POO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDLINQ_POO.Controllers
{
    public class NominaController
    {
        public NominaController()
        {
            _Nomina = new List<Nomina>();
        }

        private List<Nomina> _Nomina;
        public List<Nomina> Nomina { get { return _Nomina; } }

        private bool ListVacia()
        {
            if (Nomina.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region get
        public void ListarNomina()
        {
            if (ListVacia() == true)
            {
                Console.WriteLine("No se encontraron registros");
            }
            else
            {
                Console.WriteLine("Total Registros de Nomina : " + Nomina.Count);
                Console.WriteLine("---------Listado de Empleados---------");
                foreach (Nomina item in _Nomina)
                {
                    ImprimirNomina(item);
                }
            }
        }
        #endregion get

        //Imprime los datos en el metodo de listar
        private void ImprimirNomina(Nomina dato)
        {
            Console.WriteLine("\n");
            Console.WriteLine("| Id : {0} | Fecha : {1} | | IdEmpleado : {2} | Sueldo : {3} | Dias : {4} | TotalBasico: {5} | Comisiones: {6} | TotalDevengado: {7} |", dato.Id, dato.Fecha, dato.IdEmpleado, dato.Sueldo, dato.Dias, dato.TotalBasico, dato.Comisiones, dato.TotalDevengado);
            Console.WriteLine(">> {0} <<", dato.VDevengado());
        }

    #region getbyid
        public void BuscarNxId()
        {
            if (ListVacia() == true)
            {
                Console.WriteLine("No se encuentran datos en la lista");
            }
            else
            {
                int buscar;
                Console.Write("Ingrese el id a buscar: ");
                buscar = Convert.ToInt32(Console.ReadLine());

                foreach (Nomina item in _Nomina)
                {
                    if (buscar == item.Id)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("| Id : {0} | Fecha : {1} | IdEmpleado : {2} | Sueldo : {3} | Dias: {4} | TotalBasico: {5} | Comisiones: {6} | TotalDevengado: {7} |", item.Id, item.Fecha, item.IdEmpleado, item.Sueldo, item.Dias, item.TotalBasico, item.Comisiones, item.TotalDevengado);
                        Console.WriteLine(">> {0} <<", item.VDevengado());
                    }
                    else
                    {
                        Console.WriteLine("No hay registro con ese id");
                    }

                }
            }
        }

        #endregion getbyid

        //Insertar registro en nomina
        #region post

        public void PostNomina(int id, DateTime fecha, int idempleado, decimal sueldo, int dias, decimal totalbasico, decimal comisiones)
        {
            var verificarId = Nomina.Any(i => i.Id == id);

            Console.WriteLine("---------Insertar Nomina---------");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el id del empleado: ");
            idempleado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su sueldo: ");
            sueldo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese los dias laborados: ");
            dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de las comisiones");
            comisiones = Convert.ToDecimal(Console.ReadLine());

            if (!verificarId)
            {
                Nomina.Add(new Nomina()
                {
                    Id = id,
                    Fecha = fecha,
                    IdEmpleado = idempleado,
                    Sueldo = sueldo,
                    Dias = dias,
                    TotalBasico = Convert.ToInt32(sueldo * dias) / 30,
                    Comisiones = comisiones,
                    TotalDevengado = Convert.ToInt32(sueldo * dias) / 30 + comisiones
                });
                Console.WriteLine("Datos almacenados correctamente");
            }
            else
            {
                Console.WriteLine("El id ya se encuentra registrado");
            }

        }
        #endregion post

        //Actualizar registro en nomina
#region update

        public void UpdateNomina()
        {
            if (ListVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato");
            }
            else
            {
                Nomina np = new Nomina();
                int buscar;
                Console.Write("Ingresa id : ");
                buscar = Convert.ToInt32(Console.ReadLine());
                foreach (Nomina item in _Nomina)
                {
                    if (buscar == item.Id)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("| Id : {0} | Fecha : {1} | IdEmpleado : {2} | Sueldo : {3} | Dias: {4} | TotalBasico: {5} | Comisiones: {6} | TotalDevengado: {7} |", item.Id, item.Fecha, item.IdEmpleado, item.Sueldo, item.Dias, item.TotalBasico, item.Comisiones, item.TotalDevengado);
                        Console.WriteLine("\n");
                        Console.WriteLine("-------------------------------------------------------------------");

                        Console.WriteLine("Ingrese Id:");
                        np.Id = Convert.ToInt32(Console.ReadLine());
                        item.Id = np.Id;

                        Console.WriteLine("Ingrese el id del empleado: ");
                        np.IdEmpleado = Convert.ToInt32(Console.ReadLine());
                        item.IdEmpleado = np.IdEmpleado;

                        Console.WriteLine("Ingrese su sueldo: ");
                        np.Sueldo = Convert.ToDecimal(Console.ReadLine());
                        item.Sueldo = np.Sueldo;

                        Console.WriteLine("Ingrese los dias laborados: ");
                        np.Dias = Convert.ToInt32(Console.ReadLine());
                        item.Dias = np.Dias;

                        Console.WriteLine("Ingrese el valor de las comisiones");
                        np.Comisiones = Convert.ToDecimal(Console.ReadLine());
                        item.Comisiones = np.Comisiones;

                        item.TotalBasico = Convert.ToInt32(np.Sueldo * np.Dias) / 30;

                        item.TotalDevengado = Convert.ToInt32(np.Sueldo * np.Dias) / 30 + np.Comisiones;

                        Console.Write("\n");
                        Console.WriteLine("Datos modificados");
                    }
                else
                {
                    Console.WriteLine("El id ingresado no existe");
                }

            }
            }
        }
        #endregion update


        //Eliminar registro de nomina

        #region delete
        public void DeletexId(int id)
        {

            if (ListVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }
            else
            {
                Console.WriteLine("Ingrese Id: ");
                id = Convert.ToInt32(Console.ReadLine());

                var element = Nomina.FirstOrDefault(i => i.Id == id);
                if (element != null)
                {
                    Nomina.Remove(element);
                    Console.WriteLine("\n");
                    Console.WriteLine("El registro con el Id: " + id + "Ha sido eliminado correctamente");
                }
                else
                {
                    Console.WriteLine("No hay un registro con ese id");
                }
            }
        }
        #endregion delete

    }
}

