using System.Net.NetworkInformation;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Tank tank = new Tank();
            tank.AssignDriver("Frank");

            Robot robot = new Robot();
            RobotAdapter adaptedRobot = new RobotAdapter(robot);
            adaptedRobot.AssignDriver("Mark");

            Console.WriteLine();

            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(adaptedRobot);

            foreach (IAttacker attacker in attackers)
            {
                Console.WriteLine($"Driver of attacker: {attacker.Driver}");
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine();
            }
        }
    }
}