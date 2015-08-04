using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FakeData.DAL;
using System.Collections.ObjectModel;
using FakeData.WPF.Model;
using FakeData.WPF.ViewModels.Helpers;
using System.Windows.Input;


namespace FakeData.WPF.ViewModels
{
    public class MainWindowVM : CustomNotifyPropertyChanged
    {
        #region Properties

        private int amountRows;

        public int AmountRows
        {
            get { return amountRows; }
            set { amountRows = value; }
        }

        private ProNetScanResult proNetScanResult;

        public ProNetScanResult ProNetScanResult
        {
            get
            {
                if (proNetScanResult == null)
                    proNetScanResult = new ProNetScanResult();
                return proNetScanResult;
            }
            set
            {
                proNetScanResult = value; 
            }
        }

        private ICommand saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                return saveCommand ?? (saveCommand = new SaveCommand(() => SaveData()));
            }
            set { saveCommand = value; }
        }

        private ObservableCollection<ProNetScanResultStage> scanResults;

        public ObservableCollection<ProNetScanResultStage> ScanResults
        {
            get
            {
                if (scanResults == null)
                    scanResults = new ObservableCollection<ProNetScanResultStage>();
                return scanResults;
            }

            set
            {
                scanResults = value;
            }
        }

        public IEnumerable<ValueOption> ValuOptionEnum
        {
            get
            {
                return Enum.GetValues(typeof(ValueOption))
                    .Cast<ValueOption>();
            }
        }

        #endregion

        #region Methods

        private void SaveData()
        {
            proNetScanResult.SaveData(amountRows);
        }

        #endregion
    }
}
