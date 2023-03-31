namespace ShopMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hether");
            {
                Console.WriteLine("헤더입니다.");
                Console.WriteLine("SignUp");
                Console.WriteLine("관리자");
            }

            Console.WriteLine("article");
            {
                Console.WriteLine("본문입니다.");
                Console.WriteLine("기사1");      // A#5
                Console.WriteLine("기사2");      // A#5

            }
            Console.WriteLine("footer");
            {
                Console.WriteLine("푸터입니다.");
            }
        }
    }
}