//Calcular el indice de masa corporal
#include<stdio.h>
#include<windows.h>
main()
 {
 	char nombre[30];
	double estatura , pesol , estaturap;
	double pesok, estaturam, imc;
	const float kg=0.453592, m=0.3048;
 	char*msj;
 	
 	printf("\n\tIndice de masa corporal");
 	printf("\n\t****** ** **** ********");
 	
 	printf("\n\nIngrese su Nombre: ");
 	scanf("%s",&nombre);
 	
 	printf("\n\nIngrese su peso en libras: ");
 	scanf("%lf" ,&pesol);
 	
 	printf("\n\nIngrese su estatura en pies: ");
 	scanf("%lf",&estaturap);
 	
	pesok=pesol*kg;
	estaturam=estaturap*m;
	imc=pesok/(estaturam*estaturam);
	
	/*if(imc>=18 && imc<=25)
		msj="Saludable";
	else
		msj="Cuida tu salud";*/
		
	if(imc<18)
		msj="Delgado";
	else
		if(imc>25)
			msj="Sobrepeso";
		else
			msj="Buen peso";
				
	system("cls");
	
	printf("\n\tIndice masa de corporal");
 	printf("\n\t****** **** ** ********");
	
	printf("\n\nNombre del paciente: %s" ,nombre);

	printf("\n\nPeso del paciente en Kilogramos: %.2lf",pesok);
	printf("\n\nEstatura del paciente en metros: %.2lf",estaturam);
	
	printf("\n\nEl indice de masa corporal es: %.2lf",imc);
	printf("\n\n%s",msj);
	
	
	
	
 	
 	
 	
 	
 	
	  
 	return 0;
 }
