//Clase 20/11/2019 sub estructuras funciones 

#include<stdio.h>
#include<windows.h>

#define tam 4
int i;
int conM=0 , conF=0; //contadores

//Sub estructura
struct direccion
	{
		char pais[50];
		char colonia[50];
		int bloque;
		int casa;
	};
	
struct amigos //estructura
	{	
	char nombre[50];
	char genero;
	int edad;
	struct direccion direc; //referencia a la sub estructura
	
	}ami[tam];
//***************************************
double porcentajeGeneroF()
	{
		return (conF*100)/tam;
	}
//****************************************
void histograma()
	{
		printf("\n\tHistograma");
		printf("\n\t***********\n");
		
		printf("\nGenero Femenino [%d]",conF);
		printf("\nGenero Masculino [%d]",conM);
		
		for(i=0; i<conF ; i++)
		{
			printf("$");
	
		}
		
		for(i=0; i<conM ; i++)
		{
			printf("&");
	
		}
		
		printf("\n\n %% De Amigas: %.2lf",porcentajeGeneroF());
		
		
	}
//***************************************
void impresion()
	{
		printf("\n\tDatos de la estructura\n");
			
		for(i=0; i<tam ; i++)
		{
			printf("\n\tDatos del amigo %d", i+1);
			printf("\nNombre: %s",ami[i].nombre);
			printf("\nGenero: %c",ami[i].genero);
			printf("\nEdad: %d",ami[i].edad);
			printf("\nPais: %s",ami[i].direc.pais);
			printf("\nColonia: %s",ami[i].direc.colonia);
			printf("\nBloque: %d",ami[i].direc.bloque);
			printf("\nCasa: %d",ami[i].direc.casa);
		}
	system("pause");
	system("cls");
	}
//****************************************
void datos()
	{
		printf("\n\tIngreso de datos");
		printf("\n\t******* ** *****\n");
		
		for(i=0 ; i<tam ; i++)
		{
		printf("\n\tDatos del amigo %d\n", i+1);
		
		printf("\nIngrese el nombre: ");
		scanf("%s",&ami[i].nombre);
		
		do{
		printf("\nIngrese el genero: ");
		scanf("%s",&ami[i].genero);
		
		ami[i].genero=toupper(ami[i].genero); //toupper para conversion de mayusculas
		
			if(ami[i].genero!='F' && ami[i].genero!='M')
				printf("\n\a¡Error! Ingrese F o M");
				
		}while(ami[i].genero!='F' && ami[i].genero!='M');
		
		if(ami[i].genero=='F')
			conF++;
			else 
			conM++;
		
		printf("\nIngrese la edad: ");
		scanf("%d", &ami[i].edad);
		
		printf("\nIngrese el pais: ");
		scanf("%s",&ami[i].direc.pais);
		
		printf("\nIngrese la colonia: ");
		scanf("%s",&ami[i].direc.colonia);
		
		printf("\nIngrese el bloque: ");
		scanf("%d",&ami[i].direc.bloque);
		
		printf("\nIngrese la casa: ");
		scanf("%d",&ami[i].direc.casa);
		
		system("cls");
		
		}
	}
//*****************************************

main() 
	{	
		
		datos();
		impresion();
		histograma();
		
		return 0;
	}
