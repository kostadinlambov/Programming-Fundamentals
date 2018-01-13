namespace _5.BPM_Counter
{
    using System;
 
    public class Program
    {
        public static void Main()
        {
            var beatsPerMinute = int.Parse(Console.ReadLine());
            var numberOfBeats = int.Parse(Console.ReadLine());

            var bars = Math.Round(numberOfBeats / 4.0, 1);

            var minutes = numberOfBeats / beatsPerMinute; 
            var seconds = (60 * numberOfBeats / beatsPerMinute) % 60;

            var lengthOfTheSequence = $"{minutes}m {seconds}s";

            Console.WriteLine($"{bars} bars - {lengthOfTheSequence}");
        }
    }
}
