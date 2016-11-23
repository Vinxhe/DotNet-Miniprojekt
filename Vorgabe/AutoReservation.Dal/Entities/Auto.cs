using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AutoReservation.Dal.Entities
{
 public abstract class Auto
    {
        int Id { get; set; }
        string Marke { get; set; }
        byte[] RowVersion { get; set; }
        int Tagestarif { get; set; }
    }

public class LuxusklasseAuto : Auto
    {
        int BasisTarif { get; set; }
    }

public class MittelKlasseAuto : Auto { }

public class StandardAuto : Auto { }
}
