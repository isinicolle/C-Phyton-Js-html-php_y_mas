
package Clases;


public class ClsEstudiante {
    
    //atributos
    protected static int codigo;
    protected static String nombre;
    protected static String apellido;
    protected static int edad;
    
    
    //propiedades accesoras (Encapsulamiento)
    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        ClsEstudiante.codigo = codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        ClsEstudiante.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        ClsEstudiante.apellido = apellido;
    }

    public int getEdad() {
        return edad;
    }

    
    public void setEdad(int edad) {
        ClsEstudiante.edad = edad;
    }
    
    
    
    
    
}
