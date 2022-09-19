using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//inica espacio de nombre (namespace)
namespace division
{
    //Inicia la clase (class)
    internal class cldivision
    {
        private double n1, n2; //Atributos, Campos, Caracteristicas.

        //Constructor
        public cldivision(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }//Fin del constructor

        public cldivision(double n1)
        {
            this.n1 = n1;
        }//Fin del constructor

        //inicio del metodo
        public double division()
        {
            return n1/n2;
        }//fin del metodod

    }//Finaliza la clase (class)

}//finaliza espacio de nombre (namespace)

