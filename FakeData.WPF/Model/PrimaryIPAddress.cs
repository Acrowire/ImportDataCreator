using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class PrimaryIPAddress : IP
    {

    }

    public class PrimaryIPAddressValidator : AbstractValidator<PrimaryIPAddress>
    {
        public PrimaryIPAddressValidator()
        {
            //TODO: Approach not finished.
            RuleFor(ip => ip.Octet1)
                .Must((ip, Ip1Value1) => Ip1Value1 <= ip.MaxOctet1).WithMessage("Value should be lower.");

            RuleFor(ip => ip.MaxOctet1)
                .Must((ip, Ip2Value1) => Ip2Value1 >= ip.Octet1).WithMessage("Value should be greater.");

            //RuleFor(ip => ip.Ip2Value1).Must(BeGreaterThan).WithMessage("Error!");
        }

        private bool BeGreaterThan(IP instance, int ip)
        {
            return instance.Octet1 < ip;
            //DateTime start = DateTime.Parse(instance.StartDate + " " + instance.StartTime);
            //DateTime end = DateTime.Parse(instance.EndDate + " " + instance.EndTime);
            //return (DateTime.Compare(start, end) <= 0);
        }
    }
}
