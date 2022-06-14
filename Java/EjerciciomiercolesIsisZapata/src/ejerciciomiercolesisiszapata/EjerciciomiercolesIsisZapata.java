/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejerciciomiercolesisiszapata;

import java.text.DecimalFormat;
import java.util.Scanner;



/**
 *
 * @author Lab4
 */
public class EjerciciomiercolesIsisZapata {

  
    
    
   
    
    
    public static void main(String[] args) {
       
     DecimalFormat ndec = new DecimalFormat("#,00");
     
     Scanner entrada = new Scanner (System.in);
    
    String nombre;
    char genero;
    int n1,n2,n3;
    double notaFinal;
    
        System.out.print("Ingrese el nombre del estudiante: ");
        
        nombre = entrada.next();
        
        System.out.print("Ingrese el genero del estudiante: ");
        
        genero = entrada.next().charAt(0);
        
        System.out.print("Ingrese la nota 1: ");
        
        n1 = entrada.nextInt();
        
         
        System.out.print("Ingrese la nota 2: ");
        
        n2 = entrada.nextInt();
                
         
        System.out.print("Ingrese la nota 3: ");
        
        n3 = entrada.nextInt();
        
        n1 = (int) (n1*0.25);
        n2 = (int) (n2*0.35); 
        n3 = (int) (n3*0.40);
        
        notaFinal = n1 + n2 + n3;
        
        System.out.println("Nombre del estudiante: "+nombre);
        System.out.println("Genero del estudiante: "+genero);
        System.out.println("Nota 1: "+n1);
        System.out.println("Nota 2: "+n2);
        System.out.println("Nota 3: "+n3);
        
        System.out.println("Nota Final: "+ndec.format(notaFinal));
        
    }
    
    
}
