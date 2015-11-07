namespace Model
{
    public class CarPassport
    {
        public CarPassport(Car car)
        {
            Car = car;
            Owner = "Emty";
        }

        public string Owner { get; set; }
        public Car Car { get; }
    }
}
