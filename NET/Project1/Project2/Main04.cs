using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Main04
    {
        static void main(String[] args)
        {

            Car car = new Car("말리부", "가솔린");
            car.drive();
            // 오버라이드 된다고 원본이 바뀌지 않는다.

            GasolineCar gasolineCar = new GasolineCar("소나타", "가솔린엔진");
            gasolineCar.drive();

            HybridCar hybridCar = new HybridCar("프리우스", "가솔린엔진,전기모터");
            hybridCar.drive();

            car.drive();

        }
    }
}
