namespace SingletonImpl
{
    public class DBConn
    {
        private static DBConn instance = null;
        private static readonly object plock = new object();
        private static int count = 0;

        private DBConn()
        {
            count++;
            System.Console.WriteLine($"Number of running instances : {count}");
        }

        public static DBConn getInstance()
        {
            lock (plock)
            {
                if (instance != null)
                {
                    return instance;
                }
                else
                {
                    instance = new DBConn();
                    return instance;
                }
            }
        }
    }
}