import java.awt.*;
import java.awt.event.*;
import java.io.IOException;
import java.io.*;
import javax.swing.*;
import java.io.BufferedReader;

public class DataInputOutput extends JFrame implements ActionListener{
    int size = 20;
    int[] a5 = new int[size];
    private JTextArea txt = new JTextArea(4, 57);
    Label lbl = new Label("         Нажмите на меню      ", Label.CENTER);
    Label lbl3 = new Label("__________________________________________", Label.CENTER);
    public void actionPerformed(ActionEvent e){
        System.out.println("Menu event: "+e);
        String cmd = e.getActionCommand();
        if(cmd.equals("Open")){
            lbl.setText("        Нажата кнопка Open      ");
            String file="";
            file = JOptionPane.showInputDialog("Введите название файла с данными");
            System.out.println(file);
            try{
                FileInputStream fis = new FileInputStream(file);
                InputStreamReader isr = new InputStreamReader(fis);
                BufferedReader br = new BufferedReader(isr);
                String line;
                int i = 0;
                while((line = br.readLine()) != null){
                    a5[i] = Integer.parseInt(line);
                    i++;
                    System.out.println(line);
                }
                br.close();
            }
            catch(IOException el){
                el.printStackTrace();
            }
            txt.setLineWrap(true);
            txt.setWrapStyleWord(true);
            txt.append("Массив: ");
            for(int i = 0; i< a5.length; i++){
                txt.append(a5[i] + " ");
            }
            txt.append("\n");
        }
        else if (cmd.equals("Exit")){
            lbl.setText("       Нажата кнопка Exit        ");
            dispose();
            System.exit(0);
        }
        else if(cmd.equals("Sort")){
            lbl.setText("        Нажата кнопка Sort        ");
            txt.setLineWrap(true);
            txt.setWrapStyleWord(true);
            txt.append("Отсортированный массив: ");
            int in;
            for (int out = 1; out<a5.length; out++){
                int temp = a5[out];
                in = out;
                while(in>0 && a5[in-1] >= temp){
                    a5[in] = a5[in-1];
                    --in;
                }
                a5[in] = temp;
            }
            for(int i = 0; i<a5.length; i++){
                txt.append(a5[i] + " ");
            }
            txt.append("\n");
        }
        else if(cmd.equals("Find")){
            lbl.setText("        Нажата кнопка Find       ");
            String val="";
            val = JOptionPane.showInputDialog("Введите ключ поиска?");
            int val1 = Integer.parseInt(val);
            System.out.println(val1);
            int k=-1;
            int low = 0;
            int high = a5.length - 1;
            int m;
            while (low <= high){
                m = low + (high - low)/2;
                if (a5[m] < val1){
                    low = m +1;
                } else if (a5[m]>val1){
                    high = m -1;
                } else if (a5[m] == val1){
                    k = m;
                    break;
                }
            }           
            if (k!=-1)
                lbl3.setText("Найден элемент "+val1+" с индексом " +k);  
            else lbl3.setText("Данного значения нет в массиве");
        }
    }
    void Menu(){
        JMenu m1 = new JMenu("File");
        JMenuItem Item1 = new JMenuItem("Open");
        JMenuItem Item2 = new JMenuItem("Exit");
        m1.add(Item1);
        Item1.addActionListener(this);
        m1.add(Item2);
        Item2.addActionListener(this);
        JMenu m2 = new JMenu("Work");
        JMenuItem Item3 = new JMenuItem("Sort");
        JMenuItem Item4 = new JMenuItem("Find");
        m2.add(Item3);
        Item3.addActionListener(this);
        m2.add(Item4);
        Item4.addActionListener(this);
        JMenuBar mBar = new JMenuBar();
        mBar.add(m1);
        mBar.add(m2);
        setJMenuBar(mBar);
    }
    public DataInputOutput(){
        super("DataIntupOutput");
        Menu();
        setSize(660, 350);
        Container cp = getContentPane();
        JLabel lbl2 = new JLabel();
        lbl2.setText("<html>Расчетно-графическая работа Хазовой Александры Сергеевны ИС-29 Вариант 8 <br> Метод сортировки: вставка <br> Метод поиска: бинарный</html>");
        cp.add(lbl2);
        cp.setLayout(new FlowLayout(FlowLayout.CENTER));
        cp.add(lbl);
        cp.add(new JScrollPane(txt));
        cp.add(lbl3);
        setVisible(true);
    }
    public static void main(String[] args) throws Exception {
        new DataInputOutput();
    }
}
