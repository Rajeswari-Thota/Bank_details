namespace Bank_operations
{
    class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Village { get; set; }
        public string DOB { get; set; }
        public string Mobileno { get; set; }
        public string Username { get; set; }
    }
    class Bank
    {
        int n = 0;
        Customer[] customers;
        public void details()
        {
            Console.WriteLine("Enter no of customers:");
            n=Convert.ToInt32(Console.ReadLine());
            customers =new Customer[n];
            for(int i = 0; i < n; i++)
            {
                
                Console.WriteLine($"Enter first name of customer {i + 1}");
                string firstname=Console.ReadLine();
                Console.WriteLine($"Enter last name of customer {i + 1}");
                string lastname = Console.ReadLine();
                Console.WriteLine($"Enter village name of customer {i + 1}");
                string villagename = Console.ReadLine();
                Console.WriteLine($"Enter date of birth of customer {i + 1} in DD/MM/YYYY format");
                string dob=Console.ReadLine();
                Console.WriteLine($"Enter mobile number of {i+1}");
                string mobileno = Console.ReadLine();
                if(mobileno.Length != 10)
                {
                    Console.WriteLine("you have entered invalid mobile number.....please enter a valid number ");
                    mobileno = Console.ReadLine();
                }
                customers[i] = new Customer() {Firstname=firstname,Lastname=lastname,Village=villagename,DOB=dob,Mobileno=mobileno };
                

            }

        }
        public void randomuserid()
        {
            for(int i = 0; i < n; i++) 
            {
                string fname = customers[i].Firstname;
                string lname = customers[i].Lastname;
                Random rnd = new Random();
                int randomNum = rnd.Next(1000, 9999);
                string username = $"{fname}.{lname}{randomNum}";
                Console.WriteLine($"{customers[i].Firstname} username: {username}");
                customers[i].Username = username;
            }
        }
        public void show()
        {
            Console.WriteLine("Enter last name of the customer:");
            string lname = Console.ReadLine();
            for ( int i = 0; i < n; i++)
            {
                if (customers[i].Lastname == lname)
                {   
                    Console.WriteLine($"{ customers[i].Firstname}\t\t{customers[i].Lastname}\t\t{customers[i].Village}\t\t{customers[i].DOB}\t\t{customers[i].Mobileno}\t\t{customers[i].Username}");
                  
                }
            }
        }
        public void samevillage()
        {
           Console.WriteLine("enter a village name");
           string vname=Console.ReadLine();
            for (int i = 0;i < n; i++)
            {
                if (customers[i].Village == vname)
                { 
                    Console.WriteLine($"{customers[i].Firstname} \t {customers[i].Lastname} \t {customers[i].Village} \t {customers[i].DOB} \t {customers[i].Mobileno} \t {customers[i].Username}");
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.details();
            bank.randomuserid();
            bank.show();
            bank.samevillage();
             
            
        }
    }
}