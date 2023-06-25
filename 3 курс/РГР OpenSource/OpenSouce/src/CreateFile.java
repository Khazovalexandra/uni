import java.io.File;
import java.io.*;
import java.util.*;

public class CreateFile {
    public static void main(String[] args)throws IOException {
        int[] a = new int[20];
        for (int i = 0; i < a.length; i++) {
            a[i] = (int)(Math.random() * 1001);
            System.out.println(a[i]);
        }
        File file = new File("Data.txt");
        file.createNewFile();
        FileWriter writer = new FileWriter(file);
        for (int i = 0; i < a.length; i++) {
            final String s = Integer.toString(a[i]);
            writer.write(s);
            writer.write(System.lineSeparator());
        }
        writer.close();
    }
}
