//ejercicio de suma de dos numeros
#include <iostream>
using namespace std;
int main()
{
    int num1, num2, suma;
    cout << "Ingrese el primer numero: ";
    cin >> num1;
    cout << "Ingrese el segundo numero: ";
    cin >> num2;
    suma = num1 + num2;
    cout << "La suma de los numeros es: " << suma;
    return 0;
}
//ejercicio de resta de dos numeros
#include <iostream>
using namespace std;
int main()
{
    int num1, num2, resta;
    cout << "Ingrese el primer numero: ";
    cin >> num1;
    cout << "Ingrese el segundo numero: ";
    cin >> num2;
    resta = num1 - num2;
    cout << "La resta de los numeros es: " << resta;
    return 0;
}
//ejercicio de multiplicacion de dos numeros
#include <iostream>
using namespace std;
int main()
{
    int num1, num2, multiplicacion;
    cout << "Ingrese el primer numero: ";
    cin >> num1;
    cout << "Ingrese el segundo numero: ";
    cin >> num2;
    multiplicacion = num1 * num2;
    cout << "La multiplicacion de los numeros es: " << multiplicacion;
    return 0;
}
//ejercicio de division de dos numeros
#include <iostream>
using namespace std;
int main()
{
    int num1, num2, division;
    cout << "Ingrese el primer numero: ";
    cin >> num1;
    cout << "Ingrese el segundo numero: ";
    cin >> num2;
    division = num1 / num2;
    cout << "La division de los numeros es: " << division;
    return 0;
}

//pilas y colas
//ejercicio de pilas
#include <iostream>
using namespace std;
int main()
{
    int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
    cout << "Ingrese el primer numero: ";
    cin >> num1;
    cout << "Ingrese el segundo numero: ";
    cin >> num2;
    cout << "Ingrese el tercer numero: ";
    cin >> num3;
    cout << "Ingrese el cuarto numero: ";
    cin >> num4;
    cout << "Ingrese el quinto numero: ";
    cin >> num5;
    cout << "Ingrese el sexto numero: ";
    cin >> num6;
    cout << "Ingrese el septimo numero: ";
    cin >> num7;
    cout << "Ingrese el octavo numero: ";
    cin >> num8;
    cout << "Ingrese el noveno numero: ";
    cin >> num9;
    cout << "Ingrese el decimo numero: ";
    cin >> num10;
    cout << "Los numeros ingresados son: " << num1 << " " << num2 << " " << num3 << " " << num4 << " " << num5 << " " << num6 << " " << num7 << " " << num8 << " " << num9 << " " << num10;
    return 0;
}
//ejercicio de colas
#include <iostream>
using namespace std;
int main()
{
    int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
    cout << "Ingrese el primer numero: ";
    cin >> num1;
    cout << "Ingrese el segundo numero: ";
    cin >> num2;
    cout << "Ingrese el tercer numero: ";
    cin >> num3;
    cout << "Ingrese el cuarto numero: ";
    cin >> num4;
    cout << "Ingrese el quinto numero: ";
    cin >> num5;
    cout << "Ingrese el sexto numero: ";
    cin >> num6;
    cout << "Ingrese el septimo numero: ";
    cin >> num7;
    cout << "Ingrese el octavo numero: ";
    cin >> num8;
    cout << "Ingrese el noveno numero: ";
    cin >> num9;
    cout << "Ingrese el decimo numero: ";
    cin >> num10;
    cout << "Los numeros ingresados son: " << num1 << " " << num2 << " " << num3 << " " << num4 << " " << num5 << " " << num6 << " " << num7 << " " << num8 << " " << num9 << " " << num10;
    return 0;
}

//ejercicio de arboles binarios
#include <iostream>
using namespace std;
int main()
{
    int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
    cout << "Ingrese el primer numero: ";
    cin >> num1;
    cout << "Ingrese el segundo numero: ";
    cin >> num2;
    cout << "Ingrese el tercer numero: ";
    cin >> num3;
    cout << "Ingrese el cuarto numero: ";
    cin >> num4;
    cout << "Ingrese el quinto numero: ";
    cin >> num5;
    cout << "Ingrese el sexto numero: ";
    cin >> num6;
    cout << "Ingrese el septimo numero: ";
    cin >> num7;
    cout << "Ingrese el octavo numero: ";
    cin >> num8;
    cout << "Ingrese el noveno numero: ";
    cin >> num9;
    cout << "Ingrese el decimo numero: ";
    cin >> num10;
    cout << "Los numeros ingresados son: " << num1 << " " << num2 << " " << num3 << " " << num4 << " " << num5 << " " << num6 << " " << num7 << " " << num8 << " " << num9 << " " << num10;
    return 0;
}

//arboles binario ejercicio de internet
/*
* C++ - Arboles Binaros de busqueda -Recorridos por amplitud
*
* Copyright 2014 Martin Cruz Otiniano 
*
* Description: Recorrdos por Orden, Pre-Orden y Post-Orden
*
* Site: martincruz.me
*/

#include <iostream>
#include <cstdlib>
using namespace std;

struct nodo{
     int nro;
     struct nodo *izq, *der;
};

typedef struct nodo *ABB;
/* es un puntero de tipo nodo que hemos llamado ABB, que ulitizaremos
   para mayor facilidad de creacion de variables */

ABB crearNodo(int x)
{
     ABB nuevoNodo = new(struct nodo);
     nuevoNodo->nro = x;
     nuevoNodo->izq = NULL;
     nuevoNodo->der = NULL;

     return nuevoNodo;
}
void insertar(ABB &arbol, int x)
{
     if(arbol==NULL)
     {
           arbol = crearNodo(x);
     }
     else if(x < arbol->nro)
          insertar(arbol->izq, x);
     else if(x > arbol->nro)
          insertar(arbol->der, x);
}

void preOrden(ABB arbol)
{
     if(arbol!=NULL)
     {
          cout << arbol->nro <<" ";
          preOrden(arbol->izq);
          preOrden(arbol->der);
     }
}

void enOrden(ABB arbol)
{
     if(arbol!=NULL)
     {
          enOrden(arbol->izq);
          cout << arbol->nro << " ";
          enOrden(arbol->der);
     }
}

void postOrden(ABB arbol)
{
     if(arbol!=NULL)
     {
          postOrden(arbol->izq);
          postOrden(arbol->der);
          cout << arbol->nro << " ";
     }
}

void verArbol(ABB arbol, int n)
{
     if(arbol==NULL)
          return;
     verArbol(arbol->der, n+1);

     for(int i=0; i<n; i++)
         cout<<"   ";

     cout<< arbol->nro <<endl;

     verArbol(arbol->izq, n+1);
}

int main()
{
    ABB arbol = NULL;   // creado Arbol

    int n;  // numero de nodos del arbol
    int x; // elemento a insertar en cada nodo

    cout << "\n\t\t  ..[ ARBOL BINARIO DE BUSQUEDA ]..  \n\n";

    cout << " Numero de nodos del arbol:  ";
    cin >> n;
    cout << endl;

    for(int i=0; i<n; i++)
    {
        cout << " Numero del nodo " << i+1 << ": ";
        cin >> x;
        insertar( arbol, x);
    }

    cout << "\n Mostrando ABB \n\n";
    verArbol( arbol, 0);

    cout << "\n Recorridos del ABB";

    cout << "\n\n En orden   :  ";   enOrden(arbol);
    cout << "\n\n Pre Orden  :  ";   preOrden(arbol);
    cout << "\n\n Post Orden :  ";   postOrden(arbol);

    cout << endl << endl;

    system("pause");
    return 0;
}







