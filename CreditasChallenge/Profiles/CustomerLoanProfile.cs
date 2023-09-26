using AutoMapper;
using CreditasChallenge.Domain;
using CreditasChallenge.Dto;

namespace CreditasChallenge.Profiles
{
    public class CustomerLoanProfile: Profile
    {

        public CustomerLoanProfile()
        {
            CreateMap<CustomerDto, Customer>();
        }
    }
}
