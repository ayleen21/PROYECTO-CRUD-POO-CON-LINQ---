using CRUDLINQ_POO.Controllers;
using CRUDLINQ_POO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDLINQ_POO
{
    public class Menu : EmpleadoController
    {
        //Variable que guardara la opcion
        string opc_menu = "";

        //Instanciar
        AreasController ac = new AreasController();
        NominaController nc = new NominaController();

        //Metodo para iniciar el menu
        public void Iniciar()
        {
            do
            {
                MensajeInicio();

            } while (opc_menu != "0");
        }

        private void MensajeInicio()
        {
            Console.WriteLine("-------Nomina de Empleados----------");
            Console.WriteLine("\n");
            Console.WriteLine("------Menu Principal-------");
            Console.WriteLine("\n");
 
            Console.WriteLine("Selecciona la entidad que desee visuaizar:");
            Console.WriteLine("1. [Empleado]   |   2.[Area]   |   3.[Nomina]"); 
            Console.WriteLine("\n");
            Console.WriteLine("Seleccione una opcion...");
            opc_menu = Console.ReadLine();
            SelectOpcMenu(opc_menu);
        }

        private void SelectOpcMenu(string op)
        { 
            int id = 0;
            
            switch (op)
            {
                //Visualizar Empleado
                case "1":
                    int OpCrud = 0;
                    Console.Clear();
                    Console.WriteLine("-----------Menu Opciones Crud------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("1 [Crear Registro]  |  3.[Eliminar Registro]");
                    Console.WriteLine("2 [Listados]        |  4.[Modificar Registro]");
                    Console.WriteLine("0 [Salir]           |  5.[Buscar Registro por Id]");
                    Console.WriteLine("\n");

                    OpCrud = Convert.ToInt32(Console.ReadLine());

                    switch (OpCrud)
                    {
                        case 1:
                            Console.Clear();
                            Empleado ap = new Empleado();
                            PostEmpleado(ap.Id, ap.Nombre, ap.Apellidos, ap.Direccion, ap.Telefono, ap.Fecha_Ingreso, ap.IdArea);
                            Lista();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Lista();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            DeletexId(id);
                            Lista();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            UpdateEmpleado();
                            Lista();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            BuscarxId();
                            ReturnMenu();
                            Console.ReadKey();
                            break;

                        case 0:
                            Console.Clear();
                            MensajeInicio();
                            Console.ReadKey();
                            break;

                        default:
                   
                            Console.Write("Opcion invalida,presione enter e intente de nuevo");
                            Console.ReadKey();
                            Console.Clear();
                            MensajeInicio();
                            break;
                    }
                    break;

                //Visualizar Area
                case "2":
                    int OpC = 0;
                    Console.Clear();
                    Console.WriteLine("-----------Menu Opciones Crud------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("1 [Crear Registro]  |  3.[Eliminar Registro]");
                    Console.WriteLine("2 [Listados]        |  4.[Modificar Registro]");
                    Console.WriteLine("0 [Salir]           |  5.[Buscar Registro por Id]");
                    Console.WriteLine("\n");

                    OpC = Convert.ToInt32(Console.ReadLine());

                    switch (OpC)
                    {
                        case 1:
                            Console.Clear();
                            Areas arc = new Areas();
                            ac.PostArea(arc.Id, arc.Nombre);
                            ac.ListaArea();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            ac.ListaArea();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            ac.DeleteAxId(id);
                            ac.ListaArea();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            ac.UpdateAreas();
                            ac.ListaArea();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            ac.BuscarAxId();
                            ReturnMenu();
                            Console.ReadKey();
                            break;

                        case 0:
                            Console.Clear();
                            MensajeInicio();
                            Console.ReadKey();
                            break;

                        default:
                            Console.Write("Opcion invalida,presione enter e intente de nuevo");
                            Console.ReadKey();
                            Console.Clear();
                            MensajeInicio();
                            break;
                    }
                    break;
                    //Visualizar nomina
                case "3":
                    int Opc = 0;
                    Console.Clear();
                    Console.WriteLine("-----------Menu Opciones Crud------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("1 [Crear Registro]  |  3.[Eliminar Registro]");
                    Console.WriteLine("2 [Listados]        |  4.[Modificar Registro]");
                    Console.WriteLine("0 [Salir]           |  5.[Buscar Registro por Id]");
                    Console.WriteLine("\n");

                    Opc = Convert.ToInt32(Console.ReadLine());
                    switch (Opc)
                    {
                        case 1:
                            Console.Clear();
                            Nomina nomc = new Nomina();
                            nc.PostNomina(nomc.Id, nomc.Fecha, nomc.IdEmpleado, nomc.Sueldo,nomc.Dias,nomc.TotalBasico, nomc.Comisiones);
                            nc.ListarNomina();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                           
                        case 2:
                            Console.Clear();
                            nc.ListarNomina();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            nc.DeletexId(id);
                            nc.ListarNomina();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            nc.UpdateNomina();
                            nc.ListarNomina();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            nc.BuscarNxId();
                            ReturnMenu();
                            Console.ReadKey();
                            break;
                        case 0:
                            Console.Clear();
                            MensajeInicio();
                            Console.ReadKey();
                            break;

                        default:
                            Console.Write("Opcion invalida,presione enter e intente de nuevo");
                            Console.ReadKey();
                            Console.Clear();
                            MensajeInicio();
                            break;
                    }

                    break;
                case "R" :
                    Console.Clear();
                    MensajeInicio();
                    break;

                default:
                    Console.Write("\n");
                    Console.Write("Opcion invalida,presione enter e intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    MensajeInicio();
                    break;
            }
           
        }
        
        //Metodo que retorna el menu principal
        private void ReturnMenu()
        {
            string op;
            Console.Write("\n");
            Console.WriteLine("Presione la letra R para retornar al menu principal");
            op = Console.ReadLine();
            SelectOpcMenu(op);

        }
    }
}
