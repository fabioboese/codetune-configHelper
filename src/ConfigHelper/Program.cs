namespace ConfigHelper;

static class Program
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
        Application.Run(new ConfigHelper());
    }    

    private static void NewConnection()
    {
        MSDASC.DataLinks dataLinks = new MSDASC.DataLinks();    
        var connection = dataLinks.PromptNew();
        string s = connection.ConnectionString;
    }
}