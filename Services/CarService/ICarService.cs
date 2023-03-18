namespace Alta.Services.CarService
{
    public interface ICarService
    {
        public List<Car> Cars { get; set; }
        public List<Car> Cart { get; set; }
        public double CartTotalPrice { get; set; }
        public Car? GetCarById(int? id);
        public void AddCar(Car car);
        public void RemoveCar(int carId);
        public void EditCar(Car car);
        public void AddToCart(int id);
        public void RemoveFromCart(int id);
    }
}
