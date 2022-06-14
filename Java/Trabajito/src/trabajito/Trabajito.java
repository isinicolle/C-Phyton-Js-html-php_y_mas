//Trabajo Isis Zapata

package trabajito;


import java.text.DecimalFormat;
import java.util.Scanner;

/**
 *
 * @author Isis
 */

public class Trabajito {

    
    public static void main(String[] args) {
        
        DecimalFormat formato1 = new DecimalFormat("#.00");
     
     Scanner entrada = new Scanner (System.in);
    
    String nombre;
    char genero;
    int n1,n2,n3;
    double notaFinal;
    
        System.out.print("Ingrese el nombre del estudiante: ");
        
        nombre = entrada.nextLine();
        
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
        System.out.println("Nota 1: "+formato1.format(n1));
        System.out.println("Nota 2: "+formato1.format(n2));
        System.out.println("Nota 3: "+formato1.format(n3));
        
        System.out.println("Nota Final: "+formato1.format(notaFinal));
        
    }
    
}
