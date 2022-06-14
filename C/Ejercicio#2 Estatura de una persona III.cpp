//Estatura de una persona
#include<stdio.h>
#include<windows.h>

main()
	{
		char nombre[20];
		char*msj ,*obs;
		int edad;
		double estatura;
		
		printf("\n\tDatos Personales: ");
		printf("\n\t****** *********** ");
		
		printf("\n\n*Ingrese su nombre: ");
		scanf("%s",&nombre);
		
		printf("\n\n*Ingrese su edad: ");
		scanf("%d",&edad);
		
		printf("\n\n*Ingrese su estarura en metros: ");
		scanf("%lf",&estatura);
		printf("\n\n");
		
		system("\pause");
		
			if(edad>=21)
			msj="Mayor de edad";
		else 
			msj="Menor de edad";
			
		
	
		system("cls");
		
		if(estatura>=1.70)
			obs="Alto";
		else
			obs="Bajo";
			
		printf("\n\tDatos Personales: ");
		printf("\n\t****** *********** ");
		
		printf("\n\n**Nombre: %s",nombre);
		printf("\n\n**Edad: %d" ,edad);
		printf("\n\n**%s",msj);
		printf("\n\n**Estatura: %.2lf",estatura);
		printf("\n\n**%s",obs);
			
			
		
		return 0;
	}
