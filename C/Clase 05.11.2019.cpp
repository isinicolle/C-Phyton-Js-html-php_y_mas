//Clase 05/11/2019 
#include<stdio.h>
#include<windows.h>

double IMC (double peso, double estatura)
	{
		double imc;
		imc= peso/(estatura*estatura);
		return imc;
	}

double validacion (double valor , double vmin, double vmax)

	{
		while(valor<vmin || valor>vmax)
		{
			printf("\n\a¡Error! ingrese un valor entre %.2lf y %.2lf" ,vmin, vmax);
			scanf("%lf", &valor);
			return valor;
		}
	}
void datos()  //Cuerpo de la funcion
	{
		char nombre[50] , genero;
		double altura, peso , resultadoimc;
		
		printf("\n\tIndice de masa corporal");
		printf("\n\t****** ** **** ********\n");
		
		printf("\n\tIngrese el nombre de la persona: ");
		scanf("%s",&nombre);
		
		printf("\n\tIngrese el genero de la persona: ");
		scanf("%s",&genero);
		
		printf("\n\tIngrese la altura de la persona: ");
		scanf("%lf",&altura);
		altura=validacion(altura, 0.5 , 2.2);
		
		printf("\n\tIngrese el peso de la persona: ");
		scanf("%lf",&peso);
		
		peso=validacion(peso, 5 , 120);
		
		resultadoimc=IMC(peso , altura);
		printf("\n\tEl indice de masa corporal es: %.2lf",resultadoimc);
	}	
	
main() 
	{
		datos();
		
		return 0;
	}
