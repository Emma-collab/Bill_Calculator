using System.Xml.Linq;

namespace Bill_Calculator
{
    class Customer
    {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Plotnumber { get; set; }
        public string Location { get; set; }
        public char User { get; set; }
        public int Waterused { get; set; }
        public double PotableCost { get; set; }
        public double WastewaterCost { get; set; }
        public double Vat { get; set; }
        public double Total { get; set; }



        public Customer()
        {
      
        }

        public void PrintStars()
        {
            Console.WriteLine("****************************************");
        }


        public void LoginDetails()

        {
            //Login Attempts counter
            int loginAttempts = 0;

            //Simple iteration upto three times
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (username != "pass1" || password != "valid")
                    loginAttempts++;
                else if (username != "cus01" || password != "pa$1")
                    break;
            }

            //Display the result
            if (loginAttempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Login successful");

            Console.ReadKey();


        }


        public void GetUser()
            {
                char user;



                user = Convert.ToChar(Console.ReadLine());
                PrintStars();

                switch (user)
            { global::System.Console.WriteLine("Please select - A : Domestic User" );

            {
                global::System.Console.WriteLine("Please select - B : Commercial User");


                    case 'A':
                    case 'a':

                        Console.WriteLine("Welcome To Water Utiliites : Domestic User Services");
                        break;

                    case 'B':
                    case 'b':

                        Console.WriteLine("Welcome To Water Utiliites : Industrial User Services");
                        break;

                    default:

                        Console.WriteLine("INVALID SELECTION.PLEASE SELECT VALID INPUT!");
                        break;





                }


            }


    }
}

       