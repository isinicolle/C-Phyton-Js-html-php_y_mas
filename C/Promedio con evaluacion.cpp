//Prograna que calcula la nota final de un estudiante que reaizo tres examenes 

//Uso de librerias
#include <stdio.h>
#include <windows.h>

//Funci?n principal del programa
main()
      {
      	//Definici?n de variables
        float promedio;
        int nota1, nota2, nota3; 
		char*obs, nombre[20];
		char*obs1= " "; 
		char respuesta;

		do
			{  	
			    system("CLS"); //Lipiar pantalla
				obs1=" ";
		        printf("\t Nota Final de un estudiante\n");
				printf("\t **** ***** ** ** **********\n"); 
				
				//Captura de datos
				printf("\n Introduzca el nombre del alumno: ");
				scanf("%s", &nombre);
		do
		{
				printf("\n Introduzca la primera nota: ");
				scanf("%d", &nota1);
					if(nota1<0 || nota1>100)
						printf("\n\a\a¡Error! Ingrese una nota entre 0 y 100\n");
		} 
		while (nota1<0 || nota1>100);
			    
		do
		{
				printf("\n Introduzca la segunda nota: ");
				scanf("%d", &nota2);
    		if(nota2<0 || nota2>100)
						printf("\n\a\a¡Error! Ingrese una nota entre 0 y 100\n");
		} 
		while (nota2<0 || nota2>100);
    	
    	do
		{
				printf("\n Introduzca la tercera nota: ");
				scanf("%d", &nota3);
			if(nota3<0 || nota3>100)
						printf("\n\a\a¡Error! Ingrese una nota entre 0 y 100\n");
		} 
		while (nota3<0 || nota3>100);
		
		        //Proceso
				promedio = (float)(nota1*0.25+nota2*0.35+nota3*.40);
				
				//Decisiones
				if(promedio >= 70)
				   obs = "APROBADO";
				 else
		           obs = "REPROBADO";
		         
				if(promedio >= 91)
		           obs1 = "Tu promedio es excelente para optar a una beca\n\n";
		   		
		        system("CLS"); //Lipiar pantalla
		        
		        //Datos de salida
		        printf("\t Nota Final de un estudiante\n");
				printf("\t **** ***** ** ** **********\n"); 
				printf("\n\n Alumno %s",nombre);
				printf("\n\n Promedio: %.2f",promedio);
				printf("\n\n Estado: %s \n\n", obs); 
		      	printf("%s \n\n", obs1); 
		do
	    {
		      	printf("\n\nDesea Continuar: [S/N]: ");
				scanf("%s",&respuesta);	
				if(respuesta!='S' && respuesta!='s' && respuesta!='N' && respuesta!='n');
				printf("\n\a\a¡Error! Ingrese una opcion valida\n\nIngrese S para Si y N para No");
	     
		}
		while(respuesta!='S' && respuesta!='s' && respuesta!='N' && respuesta!='n');
	     
    		}
			while(respuesta=='S'|| respuesta=='s');
			
	
			
	    return 0;
       }
