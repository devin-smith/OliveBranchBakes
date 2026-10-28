using OliveBranchBakes.Forms;
namespace OliveBranchBakes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());


            // Initialize bakery data storage.
            var dataStore = new OliveBranchBakes.Services.DataStore();

            // Create sample records only if no saved data exists.
            if (!dataStore.DataFileExists())
            {
                var seedData =
                    OliveBranchBakes.Services.SeedData.Create();

                dataStore.Save(seedData);

                MessageBox.Show(
                    "Bakery seed data created successfully!\n\n" +
                    $"Menu Items: {seedData.MenuItems.Count}\n" +
                    $"Customers: {seedData.Customers.Count}\n" +
                    $"Orders: {seedData.Orders.Count}",
                    "Olive Branch Bakes");
            }
            else
            {
                // Load existing data without overwriting it.
                var savedData = dataStore.Load();

                MessageBox.Show(
                    "Existing bakery data loaded successfully!\n\n" +
                    $"Menu Items: {savedData.MenuItems.Count}\n" +
                    $"Customers: {savedData.Customers.Count}\n" +
                    $"Orders: {savedData.Orders.Count}",
                    "Olive Branch Bakes");
            }


            Application.Run(new WelcomeForm());
        }
    }
}