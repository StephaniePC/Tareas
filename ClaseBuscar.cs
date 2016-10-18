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
	Tarea Corta 3
	Estudiante: [Stephanie Padilla]
	
	Enunciado:
	Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
*/
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
