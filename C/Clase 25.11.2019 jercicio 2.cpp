//Ejercico #2 clase 25.11.2019
#include<stdio.h>
#include<windows.h>
#include<string.h>

main()
	{
		//char*msj es una variable char que es un apuntador llamada mensaje
		
		char msj[9];
		int numero;
		int *pnumero=&numero;
		
		printf("\n\tNumeros positivos , negativos y neutros");
		printf("\n\t******* *********   ********* * *******");
		
		do{
			printf("\n\tIngrese un numero: ");
			scanf("%d",&numero);
			
				if(numero<-100 || numero>100)
					printf("\n\aIngrese un numero entre -100 y 100");
				
		}while(numero<-100 || numero>100);
		
		if(numero>0)
			strcpy(msj, "Positivo");
			
			else if(numero<0)
					strcpy(msj, "Negativo");
					else
						strcpy(msj, "Neutro");
						
		system("cls");
		system("pause");
		
		printf("\n\tNumeros positivos , negativos y neutros");
		printf("\n\t******* *********   ********* * *******");
		printf("\nEl numero %d es un numero %s",numero , msj);
		printf("\nESTA EN LA DIRECCION DE MEMORIA: %p",pnumero);
		
		return 0;
	}
