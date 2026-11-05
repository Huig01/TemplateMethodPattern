namespace TemplateMethodPattern
{
    internal class ChocolateMilkWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Nice Hot Chocolate Milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding WhipCream");
        }

        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like WhipCream with your Chocolate Milk (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}
