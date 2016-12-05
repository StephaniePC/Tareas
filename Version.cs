/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 1
	Estudiante: [Stephanie Padilla]
	
	Enunciado:
	Haga una funcion que compare versiones, retornando -1 si el primer numero es mayor, 1 si el segundo numero es mayor y 0 y son iguales.
	Pueden asumir que los strings solo contienen numeros y el caracter '.'
	No hay un limite para la cantidad de subversiones que se pueden enviar: 1.1.1.1.1.1.1.1.1.1 es valido.
	0.1 < 1.0 < 1.0.1
	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versiones
{
    class Version
    {
       
        public int validarVer(string cadena )
        {
            int num = 0;
            string[] cadena1 = cadena.Split('.').ToArray();//separo los puntos del string y lo convierto en un array
            if (Convert.ToInt32(cadena1[0]) < Convert.ToInt32(cadena1[1]))//Se pregunta si el numero que esta en la posicion 0 es menor que lo que se encuentra en la posicion 1 
            {
                //Si se cumple, entonces num, pasa a tomar el valor de 1
                num = 1;
                Console.WriteLine("Retornara 1 si el segundo numero es el mayor "+num );
            }
                //Valido si la posicion 0 es mayor a la posicion 1
            else if (Convert.ToInt32(cadena1[0]) > Convert.ToInt32(cadena1[1]))
            {
                //Si se cumple, num pasa a tomar valor -1
                num = -1;
                Console.WriteLine("Retornara -1 si el primero numero es el mayor" +num);
            }
            else
            {
                /*De lo contrario, va a retornar 0, ya que quiere decir que los numeros en la posicion
                  0 y 1 son iguales
                 
                 */
                
                num = 0;
                Console.WriteLine("Retornara 0 si los numeros son iguales "+ num);
            }
            return num;//Retorno num.
        }
    }
}
