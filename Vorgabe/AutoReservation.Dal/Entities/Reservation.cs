using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoReservation.Dal.Entities
{
    public class Reservation
    {
        int AutoId { get; set; }
        DateTime Bis { get; set; }
        int KundeId { get; set; }
        int ReservationsNr { get; set; }
        byte[] RowVersion { get; set; }
        DateTime Von { get; set; }
    }
}
