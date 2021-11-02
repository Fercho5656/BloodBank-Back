using bloodbank.Context;
using bloodbank.Models;
using BloodBank_Backend.Base;

namespace BloodBank_Backend.Services {
    public class RequestService : EntityBaseRepository<Request>, IRequestService {
        public RequestService(BloodBankContext context) : base(context) {
        }
    }
}