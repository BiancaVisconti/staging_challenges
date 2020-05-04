using System;

namespace BrakingWell
{
    class Program
    {
        const double reactionTime = 1;
        const double g = 9.81;
        
        static void Main(string[] args)
        {
            Console.Write("Enter the vehicle's velocity in [km/h]: ");
            string velocity = Console.ReadLine();
            double v = double.Parse(velocity);

            Console.Write("Enter the coefficient of friction mu: ");
            string coefficient = Console.ReadLine();
            double mu = double.Parse(coefficient);

            double dist = TotalStoppingDistance(v, mu);
            double speed = CalculateSpeed(dist, mu);
            Console.WriteLine($"The total stopping distance is: {dist} [m]");
            Console.WriteLine($"The velocity is: {speed} [km/h]");
        }

        public static double TotalStoppingDistance(double v, double mu)
        {
          double velInMetersPerSecond = v*5/18;

          double reactionDistance = velInMetersPerSecond *reactionTime;
          double brakingDistance = velInMetersPerSecond*velInMetersPerSecond/(2*mu*g);

          double stoppingDistance = reactionDistance + brakingDistance;
          return stoppingDistance;
        }

        public static double CalculateSpeed(double d, double mu)
        {
          double positiveRoot = (-reactionTime+(Math.Sqrt(Math.Pow(reactionTime,2)-4*(1/(2*mu*g))*(-d))))/(2*1/(2*mu*g));
          double velInKilometersPerHour = positiveRoot*18/5;

          return velInKilometersPerHour;
        }
    }
}
