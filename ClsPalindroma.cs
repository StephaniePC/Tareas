using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindroma
{
    class ClsPalindroma
    {
        char[] datos;
        int contador;
        //Se crea un metodo llamado palindroma, donde se inicializa el contador en -1
        public void Palindroma()
        {
            contador = -1;
        }
        //Se crea un metodo char, donde se invierta el String insertado y poder validar si la palabra es palindroma
        public char[] InvertirString(String dtos)
        {
            //Se agrega la palabra a dato
            datos = dtos.ToCharArray();
            //Se suma a contador 1
            contador += 1;

            return datos;

        }
        //Se crea un metodo que me verifique si la palabra es palindroma 
        public bool esPalindroma()
        {
            //Declaro variable booleana
            bool result = false;
            //A lo largo de la palabra le resto 1
            int cont = datos.Length - 1;
            //Recorro el arreglo
            for (int i = 0; i < datos.Length; i++)
            {
                //Verifico si lo que se reccorio es lo mismo que se guardo en Datos[cont]
                if (datos[i] == datos[cont])
                {
                    //Si es cierto devuelve true
                    result = true;
                }
                //Al cont se le resta 1
                cont--;
            }

            return result;

        }
      
      
    }
}
