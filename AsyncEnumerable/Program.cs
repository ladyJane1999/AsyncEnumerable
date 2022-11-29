   class Repository
    {
        List<string> data = new List<string>{ "Tom", "Sam", "Kate", "Alice", "Bob" };
        public async IAsyncEnumerable<string> GetDataAsync()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
                await Task.Delay(500);
                yield return item;
            }
        }
    }

    public class Program { 
    public static async Task Main(string[] args)
    {
        Repository repo = new Repository();
        IAsyncEnumerable<string> data = repo.GetDataAsync();
        await foreach (var name in data)
        {
            Console.WriteLine(name);
        }
    }
}
