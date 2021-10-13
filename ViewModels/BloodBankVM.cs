using bloodbank.Models;

namespace BloodBank_Backend.ViewModels {
    public class BloodBankVM {

        public int Id { get; set; }
        public string BankName { get; set; }
        public ContactInfoVM ContactInfo { get; set; }
    }
}