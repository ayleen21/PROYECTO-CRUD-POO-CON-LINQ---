using CRUDLINQ_POO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDLINQ_POO.Controllers
{
    public class AreasController
    {
        public AreasController()
        {
            _Areas = new List<Areas>();
        }

        private List<Areas> _Areas;
        public List<Areas> Areas { get { return _Areas; } }

        private bool ListaV()
        {
            if (Areas.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Listar Area
        #region get
        public void ListaArea()
        {
            if (ListaV() == true)
            {
                Console.WriteLine("No se encontraron registros");
            }
            else
            {
                Console.WriteLine("Total de Registros de Areas : " + Areas.Count);
                Console.WriteLine("---------Listado de Areas---------");
                foreach (Areas item in _Areas)
                {
                    ImprimirArea(item);
                }
            }
        }

        #endregion get

        //Imprime los datos en el metodo de listar
        private void ImprimirArea(Areas dato)
        {
            Console.WriteLine("\n");
            Console.WriteLine("| Id : {0} | Nombre : {1} |", dato.Id, dato.Nombre);
        }

        //Buscar registro por id
        #region getbyid
        public void BuscarAxId()
        {
            if (ListaV() == true)
            {
                Console.WriteLine("No se encuentran datos en la lista");
            }
            else
            {
                int buscarA;
                Console.Write("Ingrese el id a buscar: ");
                buscarA = Convert.ToInt32(Console.ReadLine());

                foreach (Areas item in _Areas)
                {
                    if (buscarA == item.Id)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("| Id : {0} | Nombre : {1} |", item.Id, item.Nombre);
                    }
                    else
                    {
                        Console.WriteLine("No hay registro con ese id");
                    }

                }
            }
        }
    #endregion getbyid

        //Insertar registro en areas
        #region Post
        public void PostArea(int id, string nombre)
        {
            var verificarId = Areas.Any(i => i.Id == id);

            Console.WriteLine("---------Insertar Area---------");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese Id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Nombre:");
            nombre = Console.ReadLine();


            if (!verificarId)
            {
                Areas.Add(new Areas()
                {
                    Id = id,
                    Nombre = nombre,
                   

                });
                Console.WriteLine("Datos almacenados correctamente");
            }
            else
            {
                Console.WriteLine("El id ya se encuentra registrado");
            }

        }
    #endregion Post

        //Put registro en area
        #region Update
        public void UpdateAreas()
        {
            if (ListaV() == true)
            {
                Console.WriteLine("No se encuentra ningun dato");
            }
            else
            {
               Areas ac = new Areas();
                int buscar;
                Console.Write("Ingresa id : ");
                buscar = Convert.ToInt32(Console.ReadLine());
                foreach (Areas item in _Areas)
                {
                    if (buscar == item.Id)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("| Id : {0} | Nombre : {1} | ", item.Id, item.Nombre);
                        Console.WriteLine("\n");
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Ingrese Id:");
                        ac.Id = Convert.ToInt32(Console.ReadLine());
                        item.Id = ac.Id;

                        Console.WriteLine("Ingrese Nombre:");
                        ac.Nombre = Console.ReadLine();
                        item.Nombre = ac.Nombre;

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
        #endregion Update

        //Eliminar registro en area
        #region delete
        public void DeleteAxId(int id)
        {

            if (ListaV() == true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }
            else
            {
                Console.WriteLine("Ingrese Id: ");
                id = Convert.ToInt32(Console.ReadLine());

                var element = Areas.FirstOrDefault(i => i.Id == id);
                if (element != null)
                {
                    Areas.Remove(element);
                    Console.WriteLine("El registro con Id: " + id + " ha sido eliminado correctamente");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("No hay un registro con ese id");
                }
                #endregion delete
            }
        }

    }
}
