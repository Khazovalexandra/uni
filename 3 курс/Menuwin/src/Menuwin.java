import java.awt.*;
import java.awt.event.*;

public class Menuwin extends Frame implements WindowListener, ActionListener{
    public void windowOpened(WindowEvent e){}
    public void windowClosing(WindowEvent e){
        dispose();
        System.exit(0);
    }
    public void windowClosed(WindowEvent e){}
    public void windowIconified(WindowEvent e){}
    public void windowDeiconified(WindowEvent e){}
    public void windowActivated(WindowEvent e){}
    public void windowDeactivated(WindowEvent e){}
    Label label = new Label("Это компонента Label", Label.CENTER);
    void CreateMenu(){
        Menu m = new Menu("Меню");
        m.addActionListener(this);
        m.add(new MenuItem("carnivore"));
        m.add(new MenuItem("pianist"));
        m.add(new MenuItem("tree"));
        m.add(new MenuItem("game"));
        m.add(new MenuItem("quit"));
        MenuBar mBar = new MenuBar();
        mBar.add(m);
        setMenuBar(mBar);
    }    
    public void actionPerformed(ActionEvent e){
        System.out.println("Menu event:"+e);
        String cmd = e.getActionCommand();
        if (cmd.equals("carnivore")) {label.setText("Tiger is a carnivore");}
        else if (cmd.equals("pianist")) {label.setText("Rihter is a pianist");}
        else if (cmd.equals("tree")) {label.setText("Maple is a tree");}
        else if (cmd.equals("game")) {label.setText("Soccer is a game");}
        else if(cmd.equals("quit")) {dispose(); System.exit(0);}
    }
    public Menuwin(){
        super("Menuwin");
        CreateMenu();
        addWindowListener(this);
        setSize(400,200);
        setLayout(new BorderLayout());
        add(label, BorderLayout.CENTER);
        show();
    }
    public static void main(String[] args) throws Exception {
        new Menuwin();
    }
}
