namespace Singleton.Singlton
{
    internal class SomeConfiguration
    {
        private string user { set; get; }
        private string host { set; get; }
        private static SomeConfiguration config=new SomeConfiguration();
        private  SomeConfiguration()
        {
            this.user = "me";
            this.host = "localhost";

        }
        public static SomeConfiguration Config()
        {
            return config;
        }
        public string getUser()
        {
            return user;
        }
        public string getHost()
        {
            return host;
        }
        public void setUser(string user)
        {
           this.user=user;
        }
        public void setHost(string host)
        {
            this.host=host;
        }
    }
}
