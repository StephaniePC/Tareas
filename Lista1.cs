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
	Escriba una funcion que retorne el elemento mas grande de una lista no ordenada	
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementoGrande
{
    class Lista1
    {
        List<int> lista = new List<int>(); //Se crea lista
        public int agregar(int numero) //Se crea un metodo, al que se le pasa por parametro un numero tipo int
        {
            
                lista.Add(numero);//Se agrega el numero a la lista
            
            return numero;// Devuelve el numero
        }
        public int maximo()//Se crea un metodo que averigue el máximo de la lista
        {
            int max = 0;//Se crea una variable 
            for (int i = 0; i < lista.Count; i++)//Se recorre la lista
            {
                if (lista[i] == 0) //Se valida si la lista no contiene numeros
                {
                    max = 0;//Si es verdadero el maximo va a ser 0 
                }
                else
                {
                     max= lista.Max(); //Caso contrario se agrega el maximo a la variable max
                }
            }
            
            
            return max; //Se retorna el maximo 
        }

       
        
    }
}
