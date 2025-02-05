namespace Supercell.Laser.Server.Networking
{
    using Supercell.Laser.Logic.Message.Account;
    using Supercell.Laser.Logic.Message.Team.Stream;
    using Supercell.Laser.Logic.Team.Stream;
    using Supercell.Laser.Server.Networking.Session;

    public static class Connections
    {
        public static int Count => ActiveConnections.Count;
        private static List<Connection> ActiveConnections;
        private static Thread Thread;
        private static long SecondsGone;

        public static void Init()
        {
            ActiveConnections = new List<Connection>();
            SecondsGone = 0;
        }


        public static void AddConnection(Connection connection)
        {
            ActiveConnections.Add(connection);
        }
    }
}
