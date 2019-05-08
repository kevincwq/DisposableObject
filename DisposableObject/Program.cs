namespace DisposableObject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var obj = new DerivedDisposableObject())
            {
                obj.TestMethod();
                obj.Dispose();
            }
        }
    }
}
