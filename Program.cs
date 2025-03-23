namespace StudentManagementSQLite
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

            //Application.Run(new FormLogin());
            FormLogin frmObj = new FormLogin();
            frmObj.ShowDialog();

            if (frmObj.DialogResult == DialogResult.OK)
            {
                FormStudent objMDI = new FormStudent();
                objMDI.ShowDialog();
            }
        }
    }
}