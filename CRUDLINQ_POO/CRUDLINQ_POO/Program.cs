using CRUDLINQ_POO.Controllers;
using System;

namespace CRUDLINQ_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio el menu
            Menu start = new Menu();
            //Llamo a el metodo Iniciar del menu
            start.Iniciar();
        }
    }
}
