//Calcular el indice de masa corporal
#include<stdio.h>
#include<windows.h>
main()
 {
 	char*msj, nombre[30];
	double pesok, estaturam, imc;

 	
 	printf("\n\tIndice de masa corporal");
 	printf("\n\t****** ** **** ********");
 	
 	printf("\n\nIngrese su Nombre: ");
 	scanf("%s",&nombre);
 	
 	printf("\n\nIngrese su peso en kilogramos: ");
 	scanf("%lf" ,&pesok);
 	
 	printf("\n\nIngrese su estatura en metros: ");
 	scanf("%lf",&estaturam);
 	

	imc=(pesok/(estaturam*estaturam));
	
	system("pause");
	system("cls");
	
	
	if(imc>=18 && imc<=25)
		msj="Saludable";
	else
		msj="Cuida tu salud";
		
				
	printf("\n\tIndice masa de corporal");
 	printf("\n\t****** **** ** ********");
	
	printf("\n\nNombre del paciente: %s" ,nombre);

	printf("\n\nPeso del paciente en Kilogramos: %.2lf",pesok);
	printf("\n\nEstatura del paciente en metros: %.2lf",estaturam);
	
	printf("\n\nEl indice de masa corporal es: %.2lf",imc);
	printf("\n\nEstado: %s",msj);
	
	
	
	
 	
 	
 	
 	
 	
	  
 	return 0;
 }
