namespace Acuarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heightInCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeAcuarium = lenghtInCm * widthInCm * heightInCm;

            double lettersInAcuarium = volumeAcuarium * 0.001;

            double percentIn = percent * 0.01;

            double lettersWeNeed = lettersInAcuarium * (1 - percentIn);

            Console.WriteLine(lettersWeNeed);
        }
    }
}