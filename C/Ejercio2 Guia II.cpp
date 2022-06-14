//Promedio de un estudiante
#include<stdio.h>
#include<windows.h>
	main()
	{
		char*obs, nde[30]; //NDE=Nombre del estudiante
		int n1,n2,n3,n4; //N=Notas
		double prom; //Prom=promedio
		
		printf("\n\t Promedio de un alumno");
		printf("\n\t ******** ** ** ******");
		
		printf("\n\n Ingrese Nombre del alumno: ");
		scanf("%s",&nde);
		
		printf("\n\n Ingrese su primera nota: ");
		scanf("%d",&n1);
		
		printf("\n\n Ingrese su segunda nota: ");
		scanf("%d",&n2);
		
		printf("\n\n Ingrese su tercera nota: ");
		scanf("%d",&n3);
		
		printf("\n\n Ingrese su cuarta nota: ");
		scanf("%d",&n4);
		
		prom=(double)(n1+n2+n3+n4)/4; 
		
		if (prom >= 70)	
			obs= "Aprobado";
		 else
		 	obs="Reprobado";
			  	
		system("cls"); // Limpiar pantalla
		
			
		printf("\n\t Promedio de un alumno");
		printf("\n\t ******** ** ** ******");
		
		printf("\n\n Alumno: %s",nde);
		printf("\n\n Nota 1: %d",n1);
		printf("\n\n Nota 2: %d",n2);
		printf("\n\n Nota 3: %d",n3);
		printf("\n\n Nota 4: %d",n4);
		printf("\n\n Su promedio final: %.2lf",prom);
		printf("\n\n El estudiante esta: %s\n\n", obs);
		return 0;
	}
