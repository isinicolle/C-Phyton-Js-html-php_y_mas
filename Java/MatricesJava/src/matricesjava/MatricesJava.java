
package matricesjava;

import java.text.DecimalFormat;
import java.util.Scanner;


public class MatricesJava {


    public static void main(String[] args) 
    {
       DecimalFormat ndec = new DecimalFormat ("#.00"); 
      Scanner scan = new Scanner(System.in);
      
      final byte fila = 4;
      final byte columna = 3;
      
      float matriz[][] = new float [fila] [columna];
      float suma = 0;
      float promedio;
      float pesoMax = 0;
      float posiFila =0;
      float posiColumna = 0;
      int i , j;
              
        System.out.println("\tEjercicio Matrices");
        System.out.println("\t******************\n\n");
        
        System.out.println("Ingreso de datos a la matriz");
        
        for(i=0 ; i<fila ; i++)
        {
            for(j=0 ; j<columna ; j++)
            {
               do
               {
                   System.out.print("Ingrese Peso en la posicion: ["+i+"] ["+j+"]: ");
                   matriz[i][j] = scan.nextFloat();
                   
                   suma = matriz[i][j] + suma;
                   //tambien suma += matriz[i][j];
                   
                   if(matriz[i][j]>pesoMax)
                   {
                       pesoMax = matriz[i][j];
                       posiFila=i;
                       posiColumna= j;
                   }
                           
                           
                   if(matriz[i][j]<10 || matriz[i][j]>99)
                   {
                       System.out.println("Ingrese un numero valido entre 10 a 99");
                   }
                   
               }while(matriz[i][j]<10 || matriz[i][j]>99); //validacion de la matriz 
            }
        }
        
        System.out.println("\tDatos ingresados a la matriz");
        System.out.println("\t****************************");
        
        for(i=0 ; i<fila ; i++)
        {
            for(j=0 ; j<columna ; j++)
            {
                System.out.print("   "+ndec.format(matriz[i][j]));
            }
            System.out.println("\n");
        }
        
        promedio = suma / (fila*columna);
        
        System.out.println("La suma de los pesos es: "+ndec.format(suma));
        System.out.println("El promedio es: "+ndec.format(promedio));
        System.out.println("Peso maximo: "+ndec.format(pesoMax));
        System.out.println("Peso maximo esta en la fila: "+posiFila);
        System.out.println("El peso maximo esta en la columna: "+posiColumna);
        
        
        
        
       
      
      
      
      
      
      
      
      
      //Return 0;
    }
    
}
