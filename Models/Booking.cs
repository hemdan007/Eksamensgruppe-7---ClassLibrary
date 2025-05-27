//BY KEVIN
namespace Eksamensgruppe_7___ClassLibrary.Models
{
    public class Booking
    {
        public int AnimalId { get; set; }           //ID of the animal being visited
        public string VisitorName { get; set; }     //Name of person making booking
        public string VisitorType { get; set; }     //Type of visitor (doctor or customer)
        public DateTime VisitDate { get; set; }     //Time of visit
        public string Note { get; set; }            //Notes for the visit
    }
}
