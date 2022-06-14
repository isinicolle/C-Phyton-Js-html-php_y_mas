//Prograna que calcula la nota final de un estudiante que reaizo tres examenes 

//Uso de librerias
#include <stdio.h>
#include <windows.h>

//Funci?n principal del programa
main()
      {
      	//Definici?n de variables
        float promedio, acumuladorPromedio=0, max = -1, min = 101;
        int nota1, nota2, nota3, i; 
		char respuesta='S' , *obs, nombre[20];
		char*obs1= " "; 
		int contapro=0 , contarepro=0;
		
		
				for(i=0; i<= 3; i = i + 1)
				{
			
			    system("CLS"); //Lipiar pantalla
				obs1=" ";
		        printf("\t Nota Final de un estudiante\n");
				printf("\t **** ***** ** ** **********\n"); 
				
				//Captura de datos
				printf("\n Introduzca el nombre del alumno: ");
				scanf("%s", &nombre);
		        
				printf("\n Introduzca la primera nota: ");
				scanf("%d", &nota1);
			    
				printf("\n Introduzca la segunda nota: ");
				scanf("%d", &nota2);
				
				printf("\n Introduzca la tercera nota: ");
				scanf("%d", &nota3);
		        
		        //Proceso
				promedio = (float)(nota1*0.25+nota2*0.35+nota3*.40);
				acumuladorPromedio=(acumuladorPromedio+promedio);
			
				//Decisiones
				if(promedio >= 70) {
				contapro=contapro+1;
				   obs = "APROBADO"; }
				 else {
				contarepro=contarepro+1;
		           obs = "REPROBADO"; }
		         
				if(promedio >= 91)
		           obs1 = "Tu promedio es excelente para optar a una beca\n\n";
		   		
		        system("CLS"); //Lipiar pantalla
		        
		        //Nota Maxima
				if(promedio>max)
					max = promedio;
				else
					if(promedio<min)
							min = promedio;
						else
					
		        
		        //Datos de salida
		        printf("\t Nota Final de un estudiante\n");
				printf("\t **** ***** ** ** **********\n"); 
				printf("\n\n Alumno %s",nombre);
				printf("\n\n Promedio: %.2f",promedio);
				printf("\n\n Estado: %s \n\n", obs); 
		      	printf("%s \n\n", obs1); 
		      			
		      	system("pause");
				system("cls");
    	    	}
    		
    		
    			printf("\n\tEl promedio de la clase es: %.2f",acumuladorPromedio/(contapro+contarepro));
				printf("\n\tNumero de estudiantes aprobados: %d",contapro);
				printf("\n\tNumero de estudiantes reprobados: %d",contarepro);
				printf("\n\tPromedio maximo: %.2f",max);
				printf("\n\tPromedio minimo: %.2f",min);
		
			
	    return 0;
       }
