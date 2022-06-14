//clase 30/octubre/2019
#include<stdio.h>
#include<windows.h>
#include<stdlib.h>
#include<time.h>

#define e 5
main()
{
	srand(time(NULL));
	
	int i=0;
	int vector1[5] , vector2[e] , vector3[e];
	
	printf("\n\tDatos del vector 1: \n\n");
	
	for(i=0 ; i<5 ; i++)
	{
		vector1[i]=10 + rand() %21;
		vector2[i]=20 + rand() %31;
		printf("%5d",vector1[i]);
		
	}
		printf("\n");
	
	printf("\n\tDatos del vector 2: \n\n");
	printf("\n");
	for(i=0 ; i<5 ; i++)
	{
		
		printf("%5d",vector2[i]);
		vector3[i]=vector1[i] + vector2[e-1-i];
	}
		printf("\n");
	
		printf("\n\tSuma del vector: \n\n");
		
	
	for(i=0 ; i<5 ; i++)
	{
		printf("%5d",vector2[i]);
	
	}
		printf("\n");
	
	
	
	return 0;
}
