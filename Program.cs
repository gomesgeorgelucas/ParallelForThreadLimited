

ThreadPool.SetMaxThreads(7, 7);


Parallel.For(0, 100, (index) =>
{
    Thread.CurrentThread.Name = index.ToString();
    MyApi((MyHTTPMethod)Math.Floor((decimal)new Random().Next(3)), index);
});

string MyApi(MyHTTPMethod method, int data)
{
    Console.WriteLine($"ApiCall name: {Thread.CurrentThread.Name} - Method: {method.ToString()} - Started");

    Thread.Sleep(2000);

    Console.WriteLine($"ApiCall name: {Thread.CurrentThread.Name} - Method: {method.ToString()} - End");

    return "200";
}

enum MyHTTPMethod
{
    GET,
    POST,
    PUT,
    DELETE,
}
