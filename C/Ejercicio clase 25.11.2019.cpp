//Clase 25.11.2019 el asternan da para guardar parte de la memoria , el asteristico es un apuntador , puntero
#include<stdio.h>
#include<windows.h>

main()
	{
		int dia=14;
		int*pdia; //puntero , que tiene su propio espacio , pero apunta a otro
		
		pdia=&dia;
		
		printf("\n\tValores de las variables");
		printf("\n\t******* ** *** *********");
		
		printf("\n\tEl valor del dia es: %d\n",dia);
		printf("\n\tEsta guardado en la direccion de memoria: %p",&dia);
		
		printf("\n\nLos valores de las variables apuntadoras: ");
		printf("\n*** ******* ** *** ********* *********** \n");
		
		printf("\n\tEl valor del dia es %d\n",*pdia);
		printf("\n\tEsta guardado en la direccion de memoria: %p\n",pdia);
		
		return 0;
	}
