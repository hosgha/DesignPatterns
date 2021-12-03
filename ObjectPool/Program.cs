
using ObjectPool;
using System.Diagnostics;

var sw = Stopwatch.StartNew();

#region Without ThreadPool
//for (int i = 0; i <= 10000; i++)
//{
//    ClinetClass client = new ClinetClass();
//    Console.WriteLine(client.GetValue(i));
//}
#endregion

#region With ThreadPool
ObjectPool<ClinetClass> pool = new ObjectPool<ClinetClass>(() => new ClinetClass());
Parallel.For(0, 10000, (i, loopState) =>
{
    ClinetClass client = pool.GetObject();

    Console.CursorLeft = 0;
    Console.WriteLine(client.GetValue(i));

    pool.PutObject(client);
});
#endregion

sw.Stop();
Console.WriteLine($"\n Elapsed time is => {sw.Elapsed}");