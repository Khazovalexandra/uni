Thread thr1 = new Thread(() =>
{
    for (int i = 0; i < 5; i++)
        Console.Write("A");
    });
Thread thr2 = new Thread(() =>
{
    for (int i= 0; i < 5; i++)
        Console.Write("B");
});
Thread thr3 = new Thread(() =>

{
    for (int i = 0; i < 5; i++)
        Console.Write("C");
});
thr1.Start();
thr2.Start();
thr1.Join();
thr3.Start();
