//Caracteristicas de un dinosaurio
#include<stdio.h> //Librerias
#include<windows.h>
	main()//inicializa el programa
	{
		//Declaracion de las variables ah utilizar
		char NombreDinosaurio[30];
		int PesoEnToneladas, LongitudEnPies;
		const int tonelada = 1000;
		const float metro = 3.28;
		double pesoEnKg  , longitudEnMetros;
		
		//Inicio del programa
		 printf("\n\tCaracteristicas de un Dinosaurio"); 
		 printf("\n\t*************** ** ** **********");
		//Ingresar los datos especificos del dinosaurio
		printf("\n\nIngrese el nombre del Dinosaurio: ");
		scanf("%s" ,&NombreDinosaurio);
		
		printf("\n\nIngrese el peso en toneladas del Dinosaurio: ");
		scanf("%d" ,&PesoEnToneladas);
		
		printf("\n\nIngrese la longitud en pies del Dinosaurio: ");
		scanf("%d" ,&LongitudEnPies);
		
		system("cls"); //Borrar en pantalla los datos anteriores
		
		 printf("\n\tCaracteristicas de un Dinosaurio"); 
		 printf("\n\t*************** ** ** **********");
		 
		 pesoEnKg=(double)PesoEnToneladas*tonelada;
		 longitudEnMetros=(double)LongitudEnPies*metro;
		 //El double entre parentesis significa que hice conversion de datos porque estaban declaradas como entero las que estan usandose en la operacion
		 printf("\n\nNombre del Dinosaurio: %s" ,NombreDinosaurio);
		 printf("\n\nPeso del Dinosaurio en kg: %.2lf" ,pesoEnKg);
		 printf("\n\nLongitud del Dinosaurio en metros: %.2lf" ,longitudEnMetros);
		 
		 
		 
		 
		 
		
		
		 
		return 0; //le da final al programa
	}
