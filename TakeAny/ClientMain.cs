
namespace TakeAny
{
    internal class ClientMain
    {
        static async void Main()
        {
            TakeAnyClient client = new TakeAnyClient();
            await client.Run();
        }
    }
}
