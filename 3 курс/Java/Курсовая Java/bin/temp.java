import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.applet.*;

class MessageDialog extends Dialog {
    protected Button okButt;

    public MessageDialog(Frame parent, String message) {
        super(parent, true);
        setSize(100, 150);
        okButt = new Button("OK");
        Label messageLabel = new Label(message);
        setLayout(new FlowLayout());
        add(messageLabel);
        add(okButt);
    }

    public boolean action(Event evt, Object whichAction) {
        if (evt.target == okButt) {
            hide();
        }
        return true;
    }
}

class InputDialog extends Dialog {
    protected Button okButt;
    TextField txtField;
    String ans = "undef";

    public InputDialog(Frame parent, String message) {
        super(parent, true);
        setSize(100, 150);
        okButt = new Button("OK");
        Label messageLabel = new Label(message);
        txtField = new TextField(10);
        setLayout(new FlowLayout());
        add(messageLabel);
        add(okButt);
        add(txtField);
    }

    public boolean action(Event evt, Object whichAction) {
        if (evt.target == okButt) {
            String sI = txtField.getText();
            ans = sI;
            hide();
        }
        return true;
    }

    public String getValue1() {
        return ans;
    }
}

class win1 extends Frame implements WindowListener {
    Label l1 = new Label("Name", Label.CENTER);
    Button btn1 = new Button("Mess");
    Button btn2 = new Button("Input");

    public void windowOpened(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowClosing(WindowEvent arg0) {
        String w = arg0.toString();
        l1.setText(w);
        dispose();
    }

    public void windowClosed(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowIconified(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowDeiconified(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowActivated(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowDeactivated(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public boolean action(Event evt, Object obj) {

        if (evt.target == btn1) {
            Dialog ok = new MessageDialog(this, "Message1");
            ok.show();
            return true;
        } else if (evt.target == btn2) {
            InputDialog ok = new InputDialog(this, "Input2");
            ok.show();
            l1.setText(ok.getValue1());
            return true;
        } else
            return false;

    }

    public win1() {
        super("StdWindow");
        addWindowListener(this);
        setSize(600, 600);
        // TextArea text = new TextArea("some text");
        // text.setLocation(300, 300);
        // setLayout(new BorderLayout());
        add(l1);
        setLayout(new FlowLayout());
        btn1.setLocation(100, 100);
        btn1.setSize(50, 50);
        add(btn1);
        btn2.setLocation(100, 200);
        btn2.setSize(50, 50);
        add(btn2);
        // add(text);
        show();
    }
}

public class temp extends Frame implements WindowListener,
        ActionListener {
    Label l = new Label("Component label", Label.CENTER);

    public void windowOpened(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowClosing(WindowEvent arg0) {
        dispose();
        System.exit(0);
    }

    public void windowClosed(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowIconified(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowDeiconified(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowActivated(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void windowDeactivated(WindowEvent arg0) {
        // TODO Auto-generated method stub
    }

    public void actionPerformed(ActionEvent arg0) {
        String cwd = arg0.getActionCommand();
        if (cwd.equals("Punkt1")) {
            l.setText("Punkt1");
            new win1();
            show();
        } else if (cwd.equals("Punkt2")) {
            l.setText("Punkt2");
            new win1();
            show();
        }
    }

    void CreateMenu() {
        Menu m = new Menu("menu1");
        m.addActionListener(this);
        m.add(new MenuItem("Punkt1"));
        m.add(new MenuItem("Punkt2"));
        MenuBar mbar = new MenuBar();
        mbar.add(m);
        setMenuBar(mbar);
    }

    public temp() {
        super("menu");
        CreateMenu();
        addWindowListener(this);
        setSize(600, 600);
        setLayout(new BorderLayout());
        add(l, BorderLayout.CENTER);
        show();
    }

    public static void main(String[] args) {
        new menu();
    }
}
