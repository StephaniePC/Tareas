using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarLista
{
    class ClaseBuscar
    {
        List<int> l1 = new List<int>();//Se crea lista
        public int agregar(int numero)//Metodo que se le pase por parametro un numero
        {

            l1.Add(numero);//Se agrega el numero

            return numero;//Retorna el numero ingresado
        }
        public int buscar(int numero)//Metodo buscar al que se le pasa por parametro un numero
        {
            int contador = 0;//Variable contador en 0
            for (int i = 0; i < l1.Count; i++)//Se recorre la lista
            {
                if (numero == l1[i])//Se valida si el numero ingresado conside con alguno que este en la lista 
                {
                    contador++;//Si se cumple, el contador va a aumentar en 1
                }
                else
                    if (contador == 0)//Se valida si el contador es 0
                {
                    contador = 0;//Si se cumple es porque no hay ningun numero que consida con el ingresado 
                }

            }
            
            return contador;//Se retorna el contador 
        }

    }
}
