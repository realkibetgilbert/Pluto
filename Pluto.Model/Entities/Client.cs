namespace Pluto.Model.Entities
{
    /// <summary>
    /// Represents a client in the system.
    /// </summary>
    public class Client
    {
        public long Id { get; set; }

        public string? FirstName { get; set; }   
        public string? City { get; set; }    
        public bool HasCDNAccountNumber { get; set; }
    }
}
