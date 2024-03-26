using lab3_1;

class Program
{
    static void Main(string[] args)
    {
        string directoryPath = @"C:\Users\Asus\Desktop\прога 2 семестр\lab3_1\bin\Debug\net6.0";
        string fileName = "sequence.json";
        string filePath = Path.Combine(directoryPath, fileName);


        if (File.Exists(filePath))
        {
            Sequencee seq = Sequencee.LoadFromJsonFile(filePath);

            int[] numbers2 = { 1, 2, 4, 7, 11, 16, 22, 29, 37 };
            Sequencee seq2 = new Sequencee(numbers2);

            Console.WriteLine("increasing: " + seq.Increase());
            Console.WriteLine("decreasing: " + seq.Decrease());
            Console.WriteLine("nondecreasing: " + seq.NonDecrease());
            Console.WriteLine("nonincreasing: " + seq.NonIncrease());
            Console.WriteLine("arithmetic progression: " + seq.ArithmeticProgression());
            Console.WriteLine("geometric progression: " + seq.GeometricProgression());
            Console.WriteLine("equal: " + seq.Equal(seq2));
            Console.WriteLine("contain 4: " + seq.Contain(4));
            Console.WriteLine("max: " + seq.Maximum());
            Console.WriteLine("min: " + seq.Minimum());
            Console.WriteLine("subsequence simple: " + string.Join(", ", seq.SimpleSub()));
            Console.WriteLine("min simple: " + seq.MinSim());
            Console.WriteLine("max simple: " + seq.MaxSim());
            Console.WriteLine("subsequence even: " + string.Join(", ", seq.EvenSub()));
            Console.WriteLine("min even: " + seq.MinEve());
            Console.WriteLine("max even: " + seq.MaxEve());
            Console.WriteLine(seq.CompareSubsequences());
        }
        else
        {
            int[] defaultData = { 1, 2, 4, 7, 11, 16, 22, 29, 37 };
            Sequencee seq = new Sequencee(defaultData);
            seq.SaveToJsonFile(directoryPath, fileName);
            Console.WriteLine("Default data file created.");
        }
    }
}