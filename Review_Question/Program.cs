namespace Review_Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice Review Question 
            //Try FirstOrDefault and LastOrDefault Methord
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int result = arr1.FirstOrDefault(x => x == 10);
            Console.WriteLine( arr1.FirstOrDefault(x=> x==2));
            Console.WriteLine(arr1.LastOrDefault(x=> x==2));
            // Console.WriteLine( result);
            string str = "Sanjay";
           // char result2 = str.FirstOrDefault(x => x == 'a');
            char result3 = str.FirstOrDefault(x => x == 't');
            char result4 = str.LastOrDefault(x => x == 'a');
           // Console.WriteLine(result4);
            string[] strings = { "sanjay", "Tiwari" };
            string str3 = strings.FirstOrDefault(x => x == "sanjay");
            string str4 = strings.LastOrDefault(x => x == "sanjay");
            //Console.WriteLine(str4);
            //Console.WriteLine(str3);


            //Console.WriteLine(result3);


            //Console.WriteLine(result2);

        }
    }
}
