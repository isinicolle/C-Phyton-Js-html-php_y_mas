
package ejercicio_vectores2;

import java.text.DecimalFormat;
import java.util.Scanner;

public class Ejercicio_vectores2 {

  
    public static void main(String[] args) 
    {
        DecimalFormat ndec= new DecimalFormat("#.00");
        Scanner t =new Scanner(System.in);        
        final byte tam=7;
        int i,pos=0;
        double v1[]=new double[tam];
        double v2[]=new double[tam];
        double v3[]=new double[tam];
        double max=0;
        for(i=0;i<tam;i++)
        {
            do{
                System.out.println("Ingrese un valor en la posicion ["+i+"]: ");
                v1[i]=t.nextDouble();
                if(v1[i]<10 || v1[i]>65)
                {
                    System.out.println("ERROR...Ingrese un numero de [10-65] ");
                }
                v2[i]=Math.random()*41+10;
                v3[i]=v1[i]+v2[i];
                if(v3[i]>max)
                {
                    max=v3[i];
                    pos=i;
                }
            }while(v1[i]<10 || v1[i]>65);
        }
        System.out.println("Datos ingresados en el vector 1: ");
        for(i=0;i<tam;i++)
        {
            System.out.print(" "+ndec.format(v1[i]));
        }
        System.out.println("Datos aleatorios en el vector 2: ");
        for(i=0;i<tam;i++)
        {
            System.out.print(" "+ndec.format(v2[i]));
        }
        System.out.println("Datos sumados en el vector 3: ");
        for(i=0;i<tam;i++)
        {
            System.out.print(" "+ndec.format(v3[i]));
        }
        System.out.println("Dato maximo en el vector sumado: "+ndec.format(max));
        System.out.println("Esta en la Posicion: "+pos);
        
        
}}
