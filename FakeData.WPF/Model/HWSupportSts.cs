using FakeData.WPF.ViewModels.Helpers;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class HWSupportSts : GenericModelBase<string>, IDataErrorInfo
    {
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
            return ValidationHelper.Validate<HWSupportStsValidator, HWSupportSts>(this);
        }

        #endregion
    }

    public class HWSupportStsValidator : AbstractValidator<HWSupportSts>
    {
        public HWSupportStsValidator()
        {
            RuleFor(o => o.Value1).Length(0, 1);
            RuleFor(o => o.Value2).Length(0, 1);
        }
    }
}
