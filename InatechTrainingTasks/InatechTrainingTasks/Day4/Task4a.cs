using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InatechTrainingTasks.Day4
{
    public abstract class Membership
    {
        public abstract void membershipType();

    }
    public class Silver_Membership : Membership
    {
        public override void membershipType()
        {
            Console.WriteLine("3 days accomodation at resort ");
        }
    }
    public class Gold_Membership : Membership
    {
        public override void membershipType()
        {
            Console.WriteLine("5 days accomodation at resort and 2 dinners on the house ");
        }
    }
    public class Platinum_Membership : Membership
    {
        public override void membershipType()
        {
            Console.WriteLine("7 days accomodation at resort and 5 dinners on the house ");
        }
    }
    public class Task4a
    {
        public static void Main(string[] args)
        {
            Task4a m1 = new Task4a();
            string membership_choice = "";
            Console.WriteLine("Enter the membership choice either silver,gold,platinum:");
            membership_choice = Console.ReadLine();

            Membership membership;
            switch (membership_choice)
            {
                case "silver":
                    membership = new Silver_Membership();
                    break;
                case "gold":
                    membership = new Gold_Membership();
                    break;
                case "platinum":
                    membership = new Platinum_Membership();
                    break;
                default:
                    Console.WriteLine("Invalid membership choice");
                    return;
            }
            membership.membershipType();
        }
    }
}
