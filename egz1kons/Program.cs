namespace egz1kons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            methods.DisplayData(methods.GetDataFromTxt());
        }
    }
}
