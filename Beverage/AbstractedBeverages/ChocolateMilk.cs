namespace TemplateMethodPattern
{
    public class ChocolateMilkWith : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Nice Hot Chocolate Milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding WhipCream");
        }
    }
}
