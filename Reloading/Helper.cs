namespace Reloading
{
    public static class ListBindingHelper
    {
        public static string CnnVal(string name)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
