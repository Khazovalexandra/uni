import java.util.*;
public class StackL {
    public static List fill(List a){
        for (int i = 0; i < 10; i++)
            a.add(Integer.toString(i));
            return a;
        }
        private static Iterator it;
        private LinkedList list = new LinkedList<>();
        public void put(Object v){list.addLast(v);}
        public Object get(){return list.removeFirst();}
        public Object isEmpty() {return list;}

    public static void main(String[] args){
        Collection a = fill(new LinkedList<>());
        it = a.iterator();
        System.out.println("a = "+a);
        StackL queue = new StackL();
        for(int i = 0; i<10; i++)
            queue.put(it.next());
        System.out.println("queue = "+queue.list);
        System.out.println(queue.get());
        System.out.println(queue.get());
        queue.put("1");
        queue.put("2");     
        System.out.println(queue.list);
    }
}
