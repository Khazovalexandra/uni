import java.awt.event.*;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.Color;
import javax.swing.SwingConstants;

public class frmSquareEquation extends JFrame implements ActionListener{
    private JPanel contentPane;
    private JLabel lblTaskName, lbl_b, lblRightPart, label, lblSolution;
    private JTextField txt_b, txt_c;
    private JButton btnSolve;

    public frmSquareEquation(){
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setBounds(100, 100, 362, 288);
        contentPane = new JPanel();
        contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
        setContentPane(contentPane);
        contentPane.setLayout(null);
        lblTaskName = new JLabel("Линейное уравнение");
        lblTaskName.setBounds(83, 15, 184, 30);
        lblTaskName.setFont(new Font("Tahoma", Font.BOLD, 16));
        contentPane.add(lblTaskName);
        /*lbl_a = new JLabel("x + ");
        lbl_a.setBounds(70, 66, 32, 15);
        lbl_a.setFont(new Font("Tahoma", Font.PLAIN, 14));
        contentPane.add(lbl_a);
        txt_a = new JTextField();
        txt_a.setBounds(5, 64, 58, 21);
        txt_a.setText("0");
        txt_a.setFont(new Font("Tahoma", Font.PLAIN, 12));
        contentPane.add(txt_a);
        txt_a.setColumns(10);*/
        txt_b = new JTextField();
        txt_b.setBounds(108, 63, 58, 21);
        txt_b.setText("0");
        txt_b.setFont(new Font("Tahoma", Font.PLAIN, 12));
        txt_b.setColumns(10);
        contentPane.add(txt_b);
        lbl_b = new JLabel("x + ");
        lbl_b.setBounds(172, 66, 32, 15);
        lbl_b.setFont(new Font("Tahoma", Font.PLAIN, 14));
        contentPane.add(lbl_b);
        txt_c = new JTextField();
        txt_c.setBounds(200, 64, 47, 21);
        txt_c.setText("0");
        txt_c.setFont(new Font("Tahoma", Font.PLAIN, 12));
        contentPane.add(txt_c);
        txt_c.setColumns(10);
        lblRightPart = new JLabel("= 0");
        lblRightPart.setBounds(268, 66, 20, 15);
        contentPane.add(lblRightPart);
        btnSolve = new JButton("Решить уравнение");
        btnSolve.setBounds(75, 119, 213, 23);
        contentPane.add(btnSolve);
        btnSolve.addActionListener(this);
        label = new JLabel("Решение:");
        label.setBounds(147, 151, 64, 21);
        label.setFont(new Font("Tahoma", Font.BOLD, 12));
        contentPane.add(label);
        lblSolution = new JLabel(" ");
        lblSolution.setBackground(Color.WHITE);
        lblSolution.setBounds(10, 183, 326, 30);
        lblSolution.setHorizontalAlignment(SwingConstants.CENTER);
        lblSolution.setFont(new Font("Tahoma", Font.BOLD, 14));
        contentPane.add(lblSolution);       
    }
    public void actionPerformed(ActionEvent e){
        JButton button = (JButton) e.getSource();
        if (button == btnSolve){
            double b, c;
            /*try{
                a = Double.parseDouble(txt_a.getText());
            }
            catch(NumberFormatException nfe){
                a = 0.0;
                txt_a.setText("0.0");
            }*/
            try{
                b = Double.parseDouble(txt_b.getText());
            }
            catch(NumberFormatException nfe){
                b = 0.0;
                txt_b.setText("0.0");
            }
            try{
                c = Double.parseDouble(txt_c.getText());
            }
            catch(NumberFormatException nfe){
                c = 0.0;
                txt_c.setText("0.0");
            }
            double x1;
            String Sol = "";
            if (b==0 && c!=0) Sol="Действительных корней нет";
            else if(b!=0){
                x1 = -c/b;
                Sol = "Корень: х = " + x1;
            }
            else if(b==0 && c==0) Sol = "Корней бесконечное множетсво";
            lblSolution.setText(Sol);
        }
    }
    public static void main(String[] args){
        frmSquareEquation frame = new frmSquareEquation();
        frame.setVisible(true);
    }
}
