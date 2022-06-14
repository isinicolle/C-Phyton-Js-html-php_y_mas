//Ejercicio #3 clase 25.11.2019
#include<stdio.h>
#include<windows.h>
#include<string.h>

main()
	{
		int vec[5];
		int*pvec;
		pvec=vec;
		int i;
		
		printf("\n\tIngreso de datos al vector");
		printf("\n\t******* ** ***** ** ******");
		
		for(i=0; i<5 ; i++)
		{
			printf("\n\tIngrese un numero en la posicion [%d] del vector: ",i);
			scanf("%d",&vec[i]);
		}
		
		system("cls");
		system("pause");
		
		printf("\n\tDatos del vector: ");
		printf("\n\t***** *** ******\n ");
		
		for(i=0 ; i<5 ; i++)
		{
			printf("\nEn la posicion %d esta el numero %d",i , vec[i]);	
			printf("\nEsta en la posicion de memoria %p ",pvec);
		}
		
		return 0;
	}
