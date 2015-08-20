using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FakeData.WPF.ViewModels.Helpers;
using FluentValidation.Results;
using System.ComponentModel;

namespace FakeData.WPF.Model
{
    public class IP : GenericModelBase<string>, IDataErrorInfo
    {
        //Second Approach
        #region Properties

        #region Octets

        protected int octet1;

        public int Octet1
        {
            get { return octet1; }
            set { octet1 = value; NotifyPropertyChanged(); NotifyPropertyChanged("Ip2Value1"); }
        }

        protected int octet2;

        public int Octet2
        {
            get { return octet2; }
            set { octet2 = value; NotifyPropertyChanged(); }
        }

        protected int octet3;

        public int Octet3
        {
            get { return octet3; }
            set { octet3 = value; NotifyPropertyChanged(); }
        }

        protected int octet4;

        public int Octet4
        {
            get { return octet4; }
            set { octet4 = value; NotifyPropertyChanged(); }
        }

        #endregion

        #region Original Values

        public int OriginalValue1 { get; set; }

        public int OriginalValue2 { get; set; }

        public int OriginalValue3 { get; set; }

        public int OriginalValue4 { get; set; }

        #endregion

        #region Max Values

        protected int maxOctet1;

        public int MaxOctet1
        {
            get { return maxOctet1; }
            set { maxOctet1 = value; NotifyPropertyChanged(); NotifyPropertyChanged("Ip1Value1"); }
        }

        protected int maxOctet2;

        public int MaxOctet2
        {
            get { return maxOctet2; }
            set { maxOctet2 = value; NotifyPropertyChanged(); }
        }

        protected int maxOctet3;

        public int MaxOctet3
        {
            get { return maxOctet3; }
            set { maxOctet3 = value; NotifyPropertyChanged(); }
        }

        protected int maxOctet4;

        public int MaxOctet4
        {
            get { return maxOctet4; }
            set { maxOctet4 = value; NotifyPropertyChanged(); }
        }

        #endregion

        public string Value
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", octet1, octet2, octet3, octet4);
            }
        }

        #endregion

        #region Methods

        public void NextAddress()
        {
            if (octet4 < maxOctet4)
                octet4++;
            else if (octet3 < maxOctet3)
            {
                octet4 = OriginalValue4;
                octet3++;
            }
            else if (octet2 < maxOctet2)
            {
                octet4 = OriginalValue4;
                octet3 = OriginalValue3;
                octet2++;
            }
            else if (octet1 < maxOctet1)
            {
                octet4 = OriginalValue4;
                octet3 = OriginalValue3;
                octet2 = OriginalValue2;
                octet1++;
            }
            else
                ResetValues();
        }

        public void SaveOriginalValues()
        {
            OriginalValue1 = octet1;
            OriginalValue2 = octet2;
            OriginalValue3 = octet3;
            OriginalValue4 = octet4;
        }

        public void ResetValues()
        {
            octet4 = OriginalValue4;
            octet3 = OriginalValue3;
            octet2 = OriginalValue2;
            octet1 = OriginalValue1;
        }

        #endregion

        #region IDataErrorInfo

        public string Error { get { return ValidationHelper.GetError(SelfValidate()); } }
        public string this[string columnName]
        {
            get
            {
                var __ValidationResults = SelfValidate();
                if (__ValidationResults == null)
                    return string.Empty;

                var __ColumnResults = __ValidationResults.Errors.FirstOrDefault<ValidationFailure>(x => string.Compare(x.PropertyName, columnName, true) == 0);

                return __ColumnResults != null ? __ColumnResults.ErrorMessage : string.Empty;
            }
        }

        #endregion

        #region FluentValidation Members

        public bool IsValid
        {
            get { return SelfValidate().IsValid; }
        }

        public ValidationResult SelfValidate()
        {
            return ValidationHelper.Validate<IPValidator, IP>(this);
        }

        #endregion

    }

    public class IPValidator : AbstractValidator<IP>
    {
        public IPValidator()
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
