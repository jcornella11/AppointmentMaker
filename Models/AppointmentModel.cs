using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [DisplayName("Patient's Full Name")]
        [StringLength(20, MinimumLength = 4)]
        public string patientName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Apointment Request Date")]
        public DateTime dateTime { get; set; }

        [Required]
        [DisplayName("Patient's approximate net worth. To see the doctor must be more than $90,000")]
        [DataType(DataType.Currency)]
        public decimal PatientNetWorth { get; set; }

        [Required]
        [DisplayName("Primary Doctor's Name")]
        public string DoctorName { get; set; }

        [Required]
        [Range(6, 10)]
        [DisplayName("Patient's percieved level of pain 1 low to 10 high. " +
            "Doctor refuses to see patient unless pain level is above a 5")]
        public int PainLevel { get; set; }

        [Required]
        [DisplayName("Patient's Street Address")]
        [StringLength(20, MinimumLength = 4)]
        public string streetAddress { get; set; }

        [Required]
        [DisplayName("Patient's City")]
        [StringLength(20, MinimumLength = 4)]
        public string city { get; set; }

        [Required]
        [DisplayName("Patient's Zip Code")]
        [DataType(DataType.PostalCode)]
        public int zipCode { get; set; }

        [Required]
        [DisplayName("Patient's Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [DisplayName("Patient's Phone")]
        [DataType(DataType.PhoneNumber)]
        public int phoneNumber { get; set; }

        public AppointmentModel(string patientName, DateTime dateTime, decimal patientNetWorth, string doctorName, int painLevel, string streetAddress, string city, int zipCode, string email, int phoneNumber)
        {
            this.patientName = patientName;
            this.dateTime = dateTime;
            PatientNetWorth = patientNetWorth;
            DoctorName = doctorName;
            PainLevel = painLevel;
            this.streetAddress = streetAddress;
            this.city = city;
            this.zipCode = zipCode;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public AppointmentModel() { }
    }
}
