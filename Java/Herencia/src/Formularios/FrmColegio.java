
package Formularios;

import Clases.ClsColegio;
import java.text.DecimalFormat;


public class FrmColegio extends javax.swing.JFrame {

   
    public FrmColegio() {
        initComponents();
    }

    DecimalFormat df = new DecimalFormat("#.00");
    ClsColegio cole = new ClsColegio();
    
    public void cargarDatos()
    {
        cole.setNota1(Integer.parseInt(txtnota1.getText()));
        cole.setNota2(Integer.parseInt(txtnota2.getText()));
        cole.setNota3(Integer.parseInt(txtnota3.getText()));
        cole.setNota4(Integer.parseInt(txtnota4.getText()));
        
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        txAdatos = new javax.swing.JTextArea();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        lblestado = new javax.swing.JLabel();
        txtnota1 = new javax.swing.JTextField();
        txtnota2 = new javax.swing.JTextField();
        txtnota3 = new javax.swing.JTextField();
        txtnota4 = new javax.swing.JTextField();
        txtpromedio = new javax.swing.JTextField();
        btnregresar = new javax.swing.JButton();
        btncalcular = new javax.swing.JButton();
        btnlimpiar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Estudiantes de Colegio");
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowOpened(java.awt.event.WindowEvent evt) {
                formWindowOpened(evt);
            }
        });
        getContentPane().setLayout(null);

        jLabel1.setText("Datos Personales");
        getContentPane().add(jLabel1);
        jLabel1.setBounds(41, 22, 98, 16);

        txAdatos.setColumns(20);
        txAdatos.setRows(5);
        txAdatos.setEnabled(false);
        jScrollPane1.setViewportView(txAdatos);

        getContentPane().add(jScrollPane1);
        jScrollPane1.setBounds(41, 49, 166, 96);

        jLabel2.setText("Nota 1:");
        getContentPane().add(jLabel2);
        jLabel2.setBounds(41, 163, 42, 16);

        jLabel3.setText("Nota 2:");
        getContentPane().add(jLabel3);
        jLabel3.setBounds(41, 197, 42, 16);

        jLabel4.setText("Nota 3:");
        getContentPane().add(jLabel4);
        jLabel4.setBounds(41, 231, 42, 16);

        jLabel5.setText("Nota 4:");
        getContentPane().add(jLabel5);
        jLabel5.setBounds(41, 265, 42, 16);

        jLabel6.setText("Promedio:");
        getContentPane().add(jLabel6);
        jLabel6.setBounds(218, 163, 59, 16);

        jLabel7.setText("Estado:");
        getContentPane().add(jLabel7);
        jLabel7.setBounds(218, 197, 43, 16);

        lblestado.setText("--");
        getContentPane().add(lblestado);
        lblestado.setBounds(280, 200, 41, 16);
        getContentPane().add(txtnota1);
        txtnota1.setBounds(110, 160, 80, 22);
        getContentPane().add(txtnota2);
        txtnota2.setBounds(110, 190, 80, 22);
        getContentPane().add(txtnota3);
        txtnota3.setBounds(110, 230, 80, 22);
        getContentPane().add(txtnota4);
        txtnota4.setBounds(110, 260, 80, 22);

        txtpromedio.setEditable(false);
        getContentPane().add(txtpromedio);
        txtpromedio.setBounds(290, 160, 80, 22);

        btnregresar.setText("Regresar");
        btnregresar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnregresarActionPerformed(evt);
            }
        });
        getContentPane().add(btnregresar);
        btnregresar.setBounds(260, 30, 90, 25);

        btncalcular.setText("Calcular");
        btncalcular.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btncalcularActionPerformed(evt);
            }
        });
        getContentPane().add(btncalcular);
        btncalcular.setBounds(260, 70, 90, 25);

        btnlimpiar.setText("Limpiar");
        btnlimpiar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnlimpiarActionPerformed(evt);
            }
        });
        getContentPane().add(btnlimpiar);
        btnlimpiar.setBounds(260, 110, 90, 25);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btncalcularActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btncalcularActionPerformed
        
        cargarDatos();
        cole.calcularPromedio();
        cole.obtenerEstado();
        
        txtpromedio.setText("" + df.format(cole.getPromedio()));
        lblestado.setText(cole.getEstado());
        
    }//GEN-LAST:event_btncalcularActionPerformed

    private void formWindowOpened(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowOpened
        
        txAdatos.setText("Codigo: " + cole.getCodigo() + "\nNombre: " + cole.getNombre() +
                         "\nApellido: " + cole.getApellido() + "\nEdad: " + cole.getEdad());
        
        
    }//GEN-LAST:event_formWindowOpened

    private void btnregresarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnregresarActionPerformed
       dispose();
    }//GEN-LAST:event_btnregresarActionPerformed

    private void btnlimpiarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnlimpiarActionPerformed
       txtnota1.setText(null);
       txtnota2.setText(null);
       txtnota3.setText(null);
       txtnota4.setText(null);
       txtpromedio.setText(null);
       lblestado.setText("--");
    }//GEN-LAST:event_btnlimpiarActionPerformed

   
    /*public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrmColegio().setVisible(true);
            }
        });
    }*/

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btncalcular;
    private javax.swing.JButton btnlimpiar;
    private javax.swing.JButton btnregresar;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblestado;
    private javax.swing.JTextArea txAdatos;
    private javax.swing.JTextField txtnota1;
    private javax.swing.JTextField txtnota2;
    private javax.swing.JTextField txtnota3;
    private javax.swing.JTextField txtnota4;
    private javax.swing.JTextField txtpromedio;
    // End of variables declaration//GEN-END:variables
}
