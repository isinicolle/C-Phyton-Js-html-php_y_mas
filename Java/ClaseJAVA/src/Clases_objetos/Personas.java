
package Clases_objetos;

import javax.swing.JOptionPane;


public class Personas {
    
///LAS CLASES TIENEN ATRIBUTOS Y METODOS XD
//O PUEDEN TENER AMBAS O UNA PERO NO NINGUNA XD

                
            //Definicion de los atributos jsjsjjs
    
    int ID;
    String nombre;
    float peso;
    double estatura;
    
   public static void main (String[] art) {
       //funcion principal 
       Personas per1; //metodo constructor , se crea auttomaticamente cuando se crea una clase
        per1 = new Personas();
        
         Personas per2;
        per2 = new Personas();
       
        per1.ID = 1;
        per1.nombre = "Ana";
        per1.peso = 65f;
        per1.estatura = 1.70;
        
        System.out.println("ID: "+per1.ID);
        System.out.println("Nombre: "+per1.nombre);
        System.out.println("Peso: "+per1.peso);
        System.out.println("Estatura: "+per1.estatura);
        
        
        per2.ID = Integer.parseInt(JOptionPane.showInputDialog("Ingrese su ID: "));
        per2.nombre=JOptionPane.showInputDialog("Ingrese su nombre: ");
        per2.estatura = Double.parseDouble(JOptionPane.showInputDialog("Ingrese su estatura: "));
        per2.peso = Float.parseFloat(JOptionPane.showInputDialog("Ingrese su peso: "));
        
        // :D
        
        System.out.println("ID: "+per2.ID);
        System.out.println("Nombre: "+per2.nombre);
        System.out.println("Peso: "+per2.peso);
        System.out.println("Estatura: "+per2.estatura);
        
     
        
        //Definir clase , usar atributos con los objetos
        
        
        
        
   }    




//RETUrN 0;    
}
