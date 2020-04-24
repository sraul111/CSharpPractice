
namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public override double Cost()
        {
            return 2.00;
        }

        public override string GetDescription()
        {
            return "Super Latte";
        }
    }
}
