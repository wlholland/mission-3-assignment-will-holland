
using System.Collections.Generic; // Required for List

using mission_3_assignment;
class Program
{
    static void Main(string[] args)
    {
        // 1. Create the list to store inventory [3]
        List<FoodItem> inventory = new List<FoodItem>();

        // variable to control the loop- set to true to start it unless user chooses to exit
        bool running = true;

        while (running)
        {
            // Print Menu [2]
            Console.WriteLine("\n--- Food Bank Inventory System ---");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            // Handle Menu Choices
            if (choice == "1")
            {
                Console.Write("Enter Food Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Category: ");
                string category = Console.ReadLine();

                Console.Write("Enter Quantity: ");
                // Basic Error Handling for Quantity [3]
                int quantity = 0;
                // Note: This assumes valid integer input; consider try-catch or int.TryParse for robustness
                quantity = int.Parse(Console.ReadLine());

                if (quantity < 0)
                {
                    Console.WriteLine("Error: Quantity cannot be negative.");
                }
                else
                {
                    Console.Write("Enter Expiration Date: ");
                    string expiration = Console.ReadLine();

                    // Create the object using the Constructor
                    FoodItem newItem = new FoodItem(name, category, quantity, expiration);

                    // Add to the list
                    inventory.Add(newItem);
                    Console.WriteLine("Item added successfully!");
                }
            }
            else if (choice == "2")
            {
                // Reuse the printing logic so they can see what to delete
                Console.WriteLine("Select an item number to delete:");

                // Loop through with index
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventory[i].Name}");
                }

                // Get user input
                if (int.TryParse(Console.ReadLine(), out int indexToDelete))
                {
                    // Adjust for 0-based index for readablity and useability
                    int actualIndex = indexToDelete - 1;

                    // Error Handling: Ensure index exists in list [3]
                    if (actualIndex >= 0 && actualIndex < inventory.Count)
                    {
                        inventory.RemoveAt(actualIndex);
                        Console.WriteLine("Item deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid item number.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nCurrent Inventory:");
                if (inventory.Count == 0)
                {
                    Console.WriteLine("Inventory is empty.");
                }
                else
                {
                    foreach (FoodItem item in inventory)
                    {
                        // Uses the ToString() method we created in Step 1, or print properties manually
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            else if (choice == "4")
            {
                running = false; // Exit the loop [2]
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again."); // Basic error handling [3]
            }
        }
    }
}