using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AutoReservation.Dal.Entities
{
  public class Kunde
    {
        DateTime Geburtsdatum { get; set; }
        int Id { get; set; }
        string Nachname { get; set; }
        byte[] RowVersion { get; set; }
        string Vorname { get; set; }
    }
}
