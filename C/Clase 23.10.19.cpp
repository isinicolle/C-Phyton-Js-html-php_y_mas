//Clase 23/10/2019

//Librerias
#include<stdio.h>
#include<windows.h>
#include<stdlib.h>
#include<time.h>
main()
	{
		srand(time(NULL));
		
		int VA[6] , VE[6], VF[6]; //Vector A=Acumulativo E=Examen F=nota final
		int i ,p, contApro=0 , contRepro=0 , nm=101; //p=posicion , nm=nota minima 
		
		printf("\n\n\tNota Final de 6 estudiantes\n");
		
			for(i=0; i>6 ; i++)
			{
				VA[i]=5 + rand () %36;
				
				printf("\n\tIngrese la nota del examen del estudiante %d: ",i+1);
				scanf("%d",&VE[i]);
				
				VF[i]=VA[i] + VE[i];
				
				if(VF[i] < nm)
				{	
					nm = VF[i]; 
					p = i; 
				}
				
					if(VF[i] >= 70) 
						contApro++;
					else
						contRepro++;
						
	
				
			}
		
			system("cls");
			
			printf("\n\n\tNota Final de 6 estudiantes\n");
			printf("\n\tAcumulativo:      ");
			
			for(i=0; i<6 ; i++) //si ya termino un ciclo puedo seguir usando la misma variable para otro ciclo
			printf("%5d", VA[i]);
			
			printf("\n\tExamen:      ");
			
			for(i=0; i<6 ; i++) //si ya termino un ciclo puedo seguir usando la misma variable para otro ciclo
			printf("%5d", VE[i]);
			
			printf("\n\tNota Final:      ");
			
			for(i=0; i<6 ; i++) //si ya termino un ciclo puedo seguir usando la misma variable para otro ciclo
			printf("%5d", VF[i]);
			
			printf("\n\n Nota Minima: %d esta en la posicion %d",nm , p);
			
			printf("\n\n Cantidad de aprobados: %d",contApro);
			printf("\n\n Cantidad de reprobados: %d", contRepro);
			printf("\n\n\tHistograma");
			
			printf("\n\nAprobados [%d] ",contApro);
			for(i=0 ; i<contApro; i++)
			printf("*");
			
			printf("\n\nReprobados [%d] ",contApro);
			for(i=0 ; i<contRepro; i++)
			printf("*");
			
		return 0;
	}
