namespace GymDesktop
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
<<<<<<< HEAD
//<<<<<<< HEAD
            Application.Run(new AddMember());
//=======
            //Application.Run(new Payment());
//>>>>>>> sara
=======
<<<<<<< Updated upstream
            Application.Run(new ViewMembers());
=======

            Application.Run(new AddMember());


>>>>>>> Stashed changes
>>>>>>> osama
        }
    }
}