#include<stdio.h>
#include<windows.h>
#include<stdlib.h>
#include<time.h>

# define f 3
# define c 4

main()
	{
		srand(time(NULL));
		int matrizA[f][c], matrizB[f][c], matrizC[f][c];
		int i, j, posA,posA1, posB,posB1, posC,posC1, minima1=1205, minima2=1205, minima3=1205;
		
		printf("\n Datos ingresados a la matriz");
		
		for(i=0; i<f; i++)//I controla las filas
		 {
		 	for(j=0; j<c; j++)//j controla las columnas
		 		{
		 			printf("\n Ingrese un numero en la posicion [%d] [%d]: ",i,j);
		 			scanf("%d",&matrizA[i][j]);
		 			
		 				if(matrizA[i][j]<minima1)
					{
						minima1=matrizA[i][j];
						posA=i;
						posA1=j;
		 			}
		 			
		 			matrizB[i][j]=10+rand()%41;
		 				if(matrizB[i][j]<minima2)
					{
						minima2=matrizB[i][j];
						posB=i;
						posB1=j;
		 			}
		 			
		 			matrizC[i][j]= matrizA[i][j]+ matrizB[i][j];
		 				if(matrizC[i][j]<minima3)
					{
						minima3=matrizC[i][j];
						posC=i;
						posC1=j;
		 			}
		 			
		 		}
		 }
		system("cls");
		printf("\n Datos ingresados a la matriz\n");
		
		for(i=0; i<f; i++)
		{
			for(j=0; j<c; j++)
			{
				printf("%5d",matrizA[i][j]);
			}
			printf("\n");
			
			
		}
		
			
		printf("\n Datos Aleatorios a la matriz\n");
		
		for(i=0; i<f; i++)
		{
			for(j=0; j<c; j++)
			{
				printf("%5d",matrizB[i][j]);
			}
			printf("\n");
			
		}
		
		printf("\n Suma de Matrices\n");
		
		for(i=0; i<f; i++)
		{
			for(j=0; j<c; j++)
			{
				printf("%5d",matrizC[i][j]);
			}
			printf("\n");
			
		}
		
	
				
		printf("\n\nNota minima: %d esta en la posicion %d %d\n",minima1, posA,posA1);
		printf("\n\nNota minima: %d esta en la posicion %d %d\n",minima2, posB,posB1);
		printf("\n\nNota minima: %d esta en la posicion %d %d\n",minima3, posC,posC1);
				
	
		
		return 0;	
	}
