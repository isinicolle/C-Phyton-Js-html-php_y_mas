
package otrotrabajo;

import java.text.DecimalFormat;
import java.util.Scanner;


public class OtroTrabajo {

   
    public static void main(String[] args) {
        
        Scanner scan = new Scanner(System.in);
        DecimalFormat ndec = new DecimalFormat("#.00");
        
        final byte tam = 7;
        
        int i, posicion=0;
        double maximo=0;
        
        double vector1[] = new double [tam];
        double vector2[] = new double [tam];
        double vector3[] = new double [tam];
        
        for(i=0 ; i<tam ; i++)
        {
            System.out.println("\tIngresando datos al vector");
            System.out.println("\t**************************");
           
          
          do
            {
                
            System.out.println("\nIngrese un valor en la posicon "+i);
            vector1[i] = scan.nextDouble();
            
                if(vector1[i]<10 || vector1[i]>65)
                {
                    System.out.println("Ingrese un dato valido al vector");
                }
            
                vector2[i]=Math.random()*41+10;
                //Math ses la declaracion de una libreria o clase que debe
                //colocarse en M mayuscula
                
                vector3[i]= vector1[i] + vector2[i];
                
                if(vector3[i]>maximo)
                {
                    maximo=vector3[i];
                    posicion=i;
                }
                
                
                
          }while(vector1[i]<10 || vector1[i]>65);
          //fin del ciclo do while del vector 1 con su validacion
          
            System.out.println("\n\tDatos ingresados al vector #1");
            System.out.println("\t**************************");
            
            for(i=0 ; i<tam ; i++)
            {
                System.out.println(" "+ndec.format(vector1[i]));
                
            }
            
            
            System.out.println("\n\tDatos ingresados al vector #2");
            System.out.println("\t**************************");
            
            for(i=0 ; i<tam ; i++)
            {
                System.out.println(" "+ndec.format(vector2[i]));
                
            }
         
            
            System.out.println("\n\tDatos ingresados al vector #3");
            System.out.println("\t**************************");
            
            for(i=0 ; i<tam ; i++)
            {
                System.out.println(" "+ndec.format(vector3[i]));
                
            }
            
            System.out.println("Numero maximo del vector sumado: "+ndec.format(maximo));
            System.out.println("Y esta en la posicion: "+poscion);
          
        }
         
    }
    
}
