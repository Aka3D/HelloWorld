namespace HelloWorld.Model
{
    public class Datenbank
    {
        public string Name { get; set; }
    }
    public class Login
    {
        /// <summary>
        /// The user who wants access
        /// </summary>
        public string Benutzer { get; set; }

        /// <summary>
        /// The user specific password
        /// Nur beim POST-Request als SHA256-Hash (beim GET-Request wird dieses Feld nicht mehr zurückgegeben)
        /// </summary>
        public string Passwort { get; set; }

        /// <summary>
        /// Datenbank
        /// </summary>
        public Datenbank Datenbank { get; set; }


        /// <summary>
        /// All PX modules we want to use
        /// Beim POST-Request müssen alle Lizenzen angegeben werden, welche für diese Session freigeschaltet werden sollen
        /// </summary>
        public IList<string> Module { get; set; }
    }
}
