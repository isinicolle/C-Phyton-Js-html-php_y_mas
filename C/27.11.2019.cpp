//Clase 26/11/2019 programa usando archivos
#include<stdio.h>
#include<windows.h>

FILE*puntero_archivo;

struct pacientes
	{
		int codigo;
		char nombre[50];
		int year;
		double peso;
		double estatura;
		double imc;
	}paci;
//**************************************************************************
void consultar()
	{
		
	}
//***************************************************************************
void agregar() //27.11.2019
	{
		 char r;
			
		puntero_archivo=fopen("Pacientes.dat", "r");
		
			if(puntero_archivo==NULL)
				printf("\n\a¡El Archivo no existe!"); 
			
			else 
		 		puntero_archivo=fopen("Pacientes.dat" , "at"); //agregar texto al archivo
		 		
		 		
		printf("\n\tIngreso de datos");
		printf("\n\t******* ** *****\n");
		
		do{
			
			printf("\n\tIngrese el codigo: ");
			scanf("%d",&paci.codigo); 
			
			printf("\n\tIngrese el nombre: ");
			scanf("%s",&paci.nombre); 
			
			printf("\n\tIngrese el A%co de nacimiento: ",164);
			scanf("%d",&paci.year); 
			
			printf("\n\tIngrese el peso: ");
			scanf("%lf",&paci.peso); 
			
			printf("\n\tIngrese la estatura: ");
			scanf("%lf",&paci.estatura);
			
			paci.peso=paci.peso/(paci.estatura*paci.estatura);
			printf("\nIMC: %.2lf",paci.imc);
			
			fprintf(puntero_archivo,"\nCodigo: ");//Mandare imprimir lo que esta en el archivo por eso la F xD, en parentesis en donde esta guardado XD
			fprintf(puntero_archivo,"%d",paci.codigo);
			
			fprintf(puntero_archivo,"\nNombre: ");//Mandare imprimir lo que esta en el archivo por eso la F xD, en parentesis en donde esta guardado XD
			fprintf(puntero_archivo,"%s",paci.nombre);
			
			fprintf(puntero_archivo,"\nA%co: ",164);//Mandare imprimir lo que esta en el archivo por eso la F xD, en parentesis en donde esta guardado XD
			fprintf(puntero_archivo,"%d",paci.year);
			
			fprintf(puntero_archivo,"\nPeso: ");//Mandare imprimir lo que esta en el archivo por eso la F xD, en parentesis en donde esta guardado XD
			fprintf(puntero_archivo,"%.2lf",paci.peso);
			
			fprintf(puntero_archivo,"\nEstatura: ");//Mandare imprimir lo que esta en el archivo por eso la F xD, en parentesis en donde esta guardado XD
			fprintf(puntero_archivo,"%.2lf",paci.estatura);
			
			fprintf(puntero_archivo,"\nIMC: ");//Mandare imprimir lo que esta en el archivo por eso la F xD, en parentesis en donde esta guardado XD
			fprintf(puntero_archivo,"%.2lf",paci.imc);
			
			do{
				printf("\n\t¿Desea continuar?: ");
				scanf("%s",&r);
				r=toupper(r);
				
			}while(r!='S' && r!='N');
			
			
		}while(r=='S');
		system("pause");
		
		fclose(puntero_archivo);
			

	}
//****************************************************************************
void crear()
	{
		//R para leer (read=leer) si existe
		//W para escribir (wrie=escribir) crear lo sobre escribe se borra lo que estaba
		//AT para adiconar(add==adiconae) XD agregar datos , lo sobre escribe se borra lo que estaba , sobre escribe la informacion que estaba
		//la primera vcz que se lea el archivo y no existe va tomar el valor de nulo
		//f open para abrir
		
		puntero_archivo=fopen("Pacientes.dat","r"); //.dat porque es de datos , r porque elegimos leer 
		
	 // abrir archivo // peimwe parametro nombre del archivo, segundo el tipo de archivo
	 	if(puntero_archivo!=NULL)
	 	{
	 		printf("\nEl archivo ya existe");
	 	}
	 	else 
	 		{
	 			puntero_archivo=fopen("Pacientes.dat" , "wt"); //write text
	 			printf("\n¡El Archivo se ah creado con exito!\n\n");
	 		}
	 	//el archivo cuando no esta creado esta en modo escritura XDXDXD
	 	system("\npause");
	 	fclose(puntero_archivo);
	}
//*****************************************************************************
void menu()
	{
		int op;
		//como es distinta de 4 sale del ciclo , cuando ingresa otros datos que no son 4 se mantiene en el ciclo
		do{
		
		system("cls");
			
		printf("\n\tMenu principal");
		printf("\n\t**** *********");
		printf("\n\n[1]...Crear Archivo\n\n[2]...Agregar Datos al archivo\n\n[3]...Consultar\n\n[4]...Salir\n");
		
			do{
				printf("\nIngrese una opcion: ");
				scanf("%d",&op);
		
				if(op<1 || op>4)
					printf("\n\a¡Error! Ingrese una opcion valida");
					
			}while(op<1 || op>4);
			
			switch(op)
			{
				case 1:
					crear();
					break;
				case 2:
					agregar();
					break;
				case 3:
					consultar();
					break;
				default://cerraremos el archivo con FCLOSE
					fclose(puntero_archivo);
					printf("\nEl programa ah finalizado\n\t¡Gracias por su preferencia! :D");
					//exit para salir de la aplicacion
					exit(0);
			}
		
		}while(op!=4);
	}
//*****************************************************************************
main()
	{
	/*	printf("\n\tPrograma usando archivos");
		printf("\n\t******** ****** ********"); */
	
		
		menu();
	
		
		return 0;
	}
