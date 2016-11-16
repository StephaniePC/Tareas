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
	Tarea Corta 4
	Estudiante: [Stephanie Padilla]
	
	Enunciado:
	Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
	La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
	Palindromo: https://es.wikipedia.org/wiki/Pal%C3%ADndromo
*/


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
