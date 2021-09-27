using System.Collections.Generic;
using System.Linq;
using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.ViewModels;

namespace BloodBank_Backend.Services {
    public class ContactInfoService {
        private BloodBankContext _context;
        public ContactInfoService(BloodBankContext context) {
            _context = context;
        }

        public void AddContactInfo(ContactInfoVM contactInfo) {
            var _contactInfo = new ContactInfo() {
                Address = contactInfo.Address,
                PostalCode = contactInfo.PostalCode,
                City = contactInfo.City,
                State = contactInfo.PostalCode,
                Country = contactInfo.Country,
                Email = contactInfo.Email,
                Phone = contactInfo.Phone
            };
            _context.ContactInfo.Add(_contactInfo);
            _context.SaveChanges();
        }

        public List<ContactInfo> GetAll() {
            return _context.ContactInfo.ToList();
        }

        public ContactInfo GetContactInfo(int id) {
            return _context.ContactInfo.FirstOrDefault(contact => contact.Id == id);
        }

        public ContactInfo Update(int id, ContactInfoVM contactInfo) {
            var _contactInfo = _context.ContactInfo.FirstOrDefault(contact => contact.Id == id);
            if (_contactInfo != null) {
                _contactInfo.Address = contactInfo.Address;
                _contactInfo.PostalCode = contactInfo.PostalCode;
                _contactInfo.City = contactInfo.City;
                _contactInfo.State = contactInfo.State;
                _contactInfo.Country = contactInfo.Country;
                _contactInfo.Email = contactInfo.Email;
                _contactInfo.Phone = contactInfo.Phone;
                _context.SaveChanges();
            }
            return _contactInfo;
        }

        public void Delete(int id) {
            var _contactInfo = _context.ContactInfo.FirstOrDefault(contact => contact.Id == id);
            if (_contactInfo != null) {
                _context.ContactInfo.Remove(_contactInfo);
                _context.SaveChanges();
            }
        }
    }
}