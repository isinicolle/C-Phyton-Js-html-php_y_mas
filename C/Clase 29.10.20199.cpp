// programa de vectores 
//Tarea sacar la posicon que esta sus cordenadas , numero mayor y  menor

#include<stdio.h>
#include<windows.h>
#include<stdlib.h>
#include<time.h>

#define f 3
#define c 3
main (){
	srand(time(NULL));
	
	int matrizA[f][c], i, j, matrizB[f][c], matrizC[f][c];
	
	printf("\nIngrese datos de la matriz A: ");
	for(i=0;i<f;i++)//control de fila
	{
		for(j=0;j<c;j++)//control columna	
		{
			printf("\nIngrese un numero en la posicion[%d][%d]: ",i,j);
			scanf("%d" , & matrizA[i][j]);
			
			matrizB[i][j]=10+rand()% 41;
			
			matrizC[i][j]=matrizA[i][j]+matrizB[i][j];
		}
	}

	system("cls");
	
	printf("\n\nDatos Ingresados a la matriz\n");
	for(i=0;i<f;i++)
	{
		for(j=0;j<c;j++)
		{
			printf("%5d",matrizA[i][j]);
	
		}
		printf("\n");
	}
	
	printf("\n\nDatos aleatorios de la matriz\n");
	for(i=0;i<f;i++)
	{
		for(j=0;j<c;j++)
		{
			printf("%5d",matrizB[i][j]);
	
		}
		printf("\n");
	}
	
	printf("\n\nSuma de matrices\n");
	for(i=0;i<f;i++)
	{
		for(j=0;j<c;j++)
		{
			printf("%5d",matrizC[i][j]);
	
		}
		printf("\n");
	}
	return 0;
}
