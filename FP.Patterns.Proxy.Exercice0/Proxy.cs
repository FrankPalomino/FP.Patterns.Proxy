namespace FP.Patterns.Proxy
{
    public class Proxy
    {
        public interface ISubject
        {
            void Request(int option);
        }

        public class SimpleProxy : ISubject
        {
            private Kitchen kitchen;

            public void Request(int option)
            {
                if (kitchen == null)
                {
                    Console.WriteLine("Creating a new kitchen");
                    kitchen = new Kitchen();
                }

                if (option == 1)
                    kitchen.SecretRecipe();

                if (option == 2)
                    kitchen.Cook(5);
            }
        }

        public class SafeProxy : ISubject
        {
            private Kitchen kitchen;

            public void Request(int option)
            {
                string password;

                Console.WriteLine("Enter the password: ");
                password = Console.ReadLine();

                if (password == "secret")
                {
                    if (kitchen == null)
                    {
                        Console.WriteLine("Creating a new kitchen");
                        kitchen = new Kitchen();
                    }

                    if (option == 1)
                        kitchen.SecretRecipe();

                    if (option == 2)
                        kitchen.Cook(5);
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
        }

        private class Kitchen
        {
            public void SecretRecipe()
            {
                Console.WriteLine("Bread");
                Console.WriteLine("Water");
                Console.WriteLine("Salt");
                Console.WriteLine("Oil");
                Console.WriteLine("Cheese");
            }

            public void Cook(int quatity)
            {
                Console.WriteLine("Cooking {0} recepis", quatity);
            }
        }
    }
}
