//Calcular el area de una figura
#include<stdio.h>
#include<windows.h>
main ()
	{
		char opcion;
		float area, lado, base;
			
		
		printf("\n\tArea de una figura");
		printf("\n\t**** ** *** ******");
		
		printf("\n\nIngrese la opcion segun el area que desea calcular");
		printf("\n\n[B]....Area del rectangulo");
		printf("\n\n[C]....Area del triangulo");
		printf("\n\n[D]....Salir");
		printf("\n\nIngrese su opcion de [A a D]: ");
		scanf("%c",&opcion);
		
		printf("\n\n");
		system("pause");	
		system("cls");
		
		printf("\n\tArea de una figura");
		printf("\n\t**** ** *** ******");
		
		switch (opcion)
			{ 
		case 'A':
			printf("\n\nIngrese el valor de un lado del cuadrado: ");
			scanf("%f",&lado);
			
			area=lado*lado;
			
			printf("\n\nEl area es: %.2f",area);
		break;
		case 'B':
			printf("\n\nIngrese el valor de la altura del rectangulo: ");
			scanf("%f",&lado);
			
			printf("\n\nIngrese el valor de la base del rectangulo: ");
			scanf("%f",&base);
		
			area=base*lado;
			
			printf("\n\nEl area es: %.2f",area);
		break;
		case 'C':
			printf("\n\nIngrese el valor de la altura del triangulo: ");
			scanf("%f",&lado);
			
			printf("\n\nIngrese el valor de la base del triangulo: ");
			scanf("%f",&base);
			
			area=(base*lado)/2;
			
			printf("\n\nEl area es: %.2f",area);
		break;
		case 'D':
			printf("\n\n\tFin del programa");
		break;
		default:
			printf("\n\n\tFin del programa");
		}	
		
		
		return 0;
	}
