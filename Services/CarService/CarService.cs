namespace Alta.Services.CarService
{
    public class CarService : ICarService
    {
        public List<Car> Cars { get; set; } = new List<Car>
        {
            new Car
            {
                Id = 1,
                Name = "Mercedec CLS 63",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDescription = "Really cool car!",
                ImageSrc = "images/imgs/cls63.jpg",
                Price = 108900
            },
            new Car
            {
                Id = 2,
                Name = "BMW e60",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDescription = "Really cool car! my friend recommends to buy it",
                ImageSrc = "images/imgs/e60.jpg",
                Price = 22718
            },
            new Car
            {
                Id = 3,
                Name = "Toyota Rav4",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDescription = "Really cool car! i recommend to buy it!",
                ImageSrc = "images/imgs/rav4.jpg",
                Price = 22000
            },
            new Car
            {
                Id = 4,
                Name = "Mercedec G Class 63",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDescription = "Really cool car!",
                ImageSrc = "images/imgs/g63.jpg",
                Price = 160000
            },
            new Car
            {
                Id = 5,
                Name = "Toyota Supra",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDescription = "Really FAST car!",
                ImageSrc = "images/imgs/supra.webp",
                Price = 43540
            },
            new Car
            {
                Id = 6,
                Name = "Nissan GTR 35",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDescription = "Really cool loking car car!",
                ImageSrc = "images/imgs/gtr.jpg",
                Price = 117000
            },
        };
        public double CartTotalPrice { get; set; }
        public List<Car> Cart { get; set; } = new List<Car>();

        public Car? GetCarById(int? id)
        {
            return Cars.Find(x => x.Id == id);
        }

        public void AddCar(Car car)
        {
            var newCar = new Car
            {
                Id = Cars.Last().Id + 1,
                Name = car.Name,
                Description = car.Description,
                ShortDescription = car.ShortDescription,
                ImageSrc = car.ImageSrc,
            };
            Cars.Add(newCar);
        }

        public void EditCar(Car car)
        {
            var foundCar = Cars.Find(x =>x.Id == car.Id);
            if(foundCar != null)
            {
                foundCar.Name = car.Name;
                foundCar.Description = car.Description;
                foundCar.ShortDescription = car.ShortDescription;
                foundCar.ImageSrc = car.ImageSrc;
                foundCar.Price = car.Price;
            }
        }

        public void RemoveCar(int carId)
        {
            var foundCar = Cars.Find(x => x.Id == carId);
            if(foundCar != null)
            {
                Cars.Remove(foundCar);
            }
        }

        public void AddToCart(int id)
        {
            var foundCar = Cars.Find(x=>x.Id == id);
            if(foundCar != null)
            {
                Cart.Add(foundCar);
                CartTotalPrice += foundCar.Price;
            }
        }

        public void RemoveFromCart(int id)
        {
            var foundCar = Cars.Find(x => x.Id == id);
            if (foundCar != null)
            {
                Cart.Remove(foundCar);
                CartTotalPrice -= foundCar.Price;
            }
        }
    }
}
