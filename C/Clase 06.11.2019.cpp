//Clase 05/11/2019 
#include<stdio.h>
#include<windows.h>

//************************************************************************************
char*obs(double imc)
	{
		char*msj;
		
		if(imc<18)
			msj="Bajo Peso";
		else if(imc>25)
			msj="Sobrepeso";
		else
			msj="Buen peso";
			
		return msj;
	}
//************************************************************************************

double IMC (double peso, double estatura)
	{
		double imc;
		imc= peso/(estatura*estatura);
		return imc;
	}
//************************************************************************************
double validacion (double valor , double vmin, double vmax)

	{
		while(valor<vmin || valor>vmax)
		{
			printf("\n\a¡Error! ingrese un valor entre %.2lf y %.2lf" ,vmin, vmax);
			scanf("%lf", &valor);
			return valor;
		}
	}
//************************************************************************************
void datos()  //Cuerpo de la funcion
	{
		char nombre[50] , genero;
		double altura, peso , resultadoimc;
		
		printf("\n\tIndice de masa corporal");
		printf("\n\t****** ** **** ********\n");
		
		printf("\n\tIngrese el nombre de la persona: ");
		scanf("%s",&nombre);
		do{
		printf("\n\tIngrese el genero de la persona: ");
		scanf("%s",&genero);
		
		genero=toupper(genero);
		
			if(genero!='F' && genero!='M');
				printf("\n\a\a¡Error! Introduzca [F/M]");
				
		}while(genero!='M' && genero!='F'); 
		
		printf("\n\tIngrese la altura de la persona: ");
		scanf("%lf",&altura);
		altura=validacion(altura, 0.5 , 2.2);
		
		printf("\n\tIngrese el peso de la persona: ");
		scanf("%lf",&peso);
		
		peso=validacion(peso, 5 , 120);
		
		resultadoimc=IMC(peso , altura);
		
		printf("\n\tEl indice de masa corporal es: %.2lf",resultadoimc);
		printf("\n\tEstado: [%s]",obs(resultadoimc));
	}	
//************************************************************************************	
void repeticion()
	{
		char respuesta;
		do
		{ 
			do{
				printf("\n\tPresione [S] para continuar");
				scanf("%s",&respuesta);
			    respuesta=toupper(respuesta);
			    
			if(respuesta!='S' && respuesta!='N')
			printf("\n\aError Introduzca[S/N]:");
				}while(respuesta!='S' && respuesta!='N');
		}while(respuesta=='S');
	}
//************************************************************************************	

main() 
	{
		datos();
		
		return 0;
	}
