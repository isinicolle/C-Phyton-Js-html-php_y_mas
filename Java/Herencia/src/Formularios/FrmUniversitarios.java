
package Formularios;

import Clases.ClsUniversitarios;
import java.text.DecimalFormat;


public class FrmUniversitarios extends javax.swing.JFrame {

    
    public FrmUniversitarios() {
        initComponents();
    }
    
    DecimalFormat df = new DecimalFormat("#.00");
    ClsUniversitarios uni = new ClsUniversitarios();

    public void cargarDatos()
    {
        uni.setNota1(Integer.parseInt(txtnota1.getText()));
        uni.setNota2(Integer.parseInt(txtnota2.getText()));
        uni.setNota3(Integer.parseInt(txtnota3.getText()));
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        txADatos = new javax.swing.JTextArea();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        lblestado = new javax.swing.JLabel();
        txtnota1 = new javax.swing.JTextField();
        txtnota2 = new javax.swing.JTextField();
        txtnota3 = new javax.swing.JTextField();
        txtpromedio = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowOpened(java.awt.event.WindowEvent evt) {
                formWindowOpened(evt);
            }
        });

        jPanel1.setLayout(null);

        jLabel1.setText("Datos Personales:");
        jPanel1.add(jLabel1);
        jLabel1.setBounds(31, 24, 103, 16);

        txADatos.setColumns(20);
        txADatos.setRows(5);
        txADatos.setEnabled(false);
        jScrollPane1.setViewportView(txADatos);

        jPanel1.add(jScrollPane1);
        jScrollPane1.setBounds(31, 46, 166, 108);

        jLabel2.setText("Nota 1:");
        jPanel1.add(jLabel2);
        jLabel2.setBounds(31, 175, 42, 16);

        jLabel3.setText("Nota 2:");
        jPanel1.add(jLabel3);
        jLabel3.setBounds(31, 220, 42, 16);

        jLabel4.setText("Nota 3:");
        jPanel1.add(jLabel4);
        jLabel4.setBounds(31, 260, 42, 16);

        jLabel5.setText("Promedio:");
        jPanel1.add(jLabel5);
        jLabel5.setBounds(210, 170, 60, 20);

        jLabel6.setText("Estado:");
        jPanel1.add(jLabel6);
        jLabel6.setBounds(210, 210, 43, 20);

        lblestado.setText("--");
        jPanel1.add(lblestado);
        lblestado.setBounds(280, 210, 70, 20);
        jPanel1.add(txtnota1);
        txtnota1.setBounds(91, 172, 70, 22);
        jPanel1.add(txtnota2);
        txtnota2.setBounds(91, 217, 70, 22);
        jPanel1.add(txtnota3);
        txtnota3.setBounds(91, 257, 70, 22);

        txtpromedio.setEnabled(false);
        jPanel1.add(txtpromedio);
        txtpromedio.setBounds(280, 170, 70, 20);

        jButton1.setText("Regresar");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton1);
        jButton1.setBounds(258, 46, 90, 25);

        jButton2.setText("Calcular");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton2);
        jButton2.setBounds(258, 82, 90, 25);

        jButton3.setText("Limpiar");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });
        jPanel1.add(jButton3);
        jButton3.setBounds(258, 120, 90, 25);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 300, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formWindowOpened(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowOpened
        txADatos.setText("Codigo: " + uni.getCodigo() + "\nNombre: " + uni.getNombre() +
                         " " + uni.getApellido() + "\nEdad: " + uni.getEdad());
    }//GEN-LAST:event_formWindowOpened

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        cargarDatos();
        
        uni.calcularPromedio();
        uni.obtenerEstado();
        
        txtpromedio.setText("" + df.format(uni.getPromedio()));
        lblestado.setText(uni.getEstado());
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        dispose();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        txtnota1.setText(null);
       txtnota2.setText(null);
       txtnota3.setText(null);
       txtpromedio.setText(null);
       lblestado.setText("--");
    }//GEN-LAST:event_jButton3ActionPerformed

    /*public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrmUniversitarios().setVisible(true);
            }
        });
    }*/

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblestado;
    private javax.swing.JTextArea txADatos;
    private javax.swing.JTextField txtnota1;
    private javax.swing.JTextField txtnota2;
    private javax.swing.JTextField txtnota3;
    private javax.swing.JTextField txtpromedio;
    // End of variables declaration//GEN-END:variables
}
