namespace TemplateMethodPattern
{
    internal class SimpleChocolateMilk
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewChocoBeans();
            PourInCup();
            AddWhipCream();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void BrewChocoBeans()
        {
            Console.WriteLine("Brewing hot choclate");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
        public void AddWhipCream()
        {
            Console.WriteLine("Adding WhipCream");
        }
    }
}
