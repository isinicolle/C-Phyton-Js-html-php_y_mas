
package paquete;


public class Biblioteca {

    
    protected static int codigo;
    protected static  String titulo;
    protected static  int anio;
    
    
    
    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public int getAnio() {
        return anio;
    }

    public void setAnio(int anio) {
        this.anio = anio;
    }
    
    
    public void detalles(int co,int a,String T)
    {
        codigo = co;
        titulo = T;
        anio = a;
    }
    
    //para polimorfismo
    public String ToString()
    {
        return "Anio: "+anio + " Titulo: "+titulo+" Codigo: "+codigo;
    }
}
