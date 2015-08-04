using FakeData.DAL;
using FakeData.WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class ProNetScanResult : CustomNotifyPropertyChanged
    {
        #region Properties

        private ScannerName scannerName = new ScannerName();

        public ScannerName ScannerName
        {
            get { return scannerName; }
            set { scannerName = value; }
        }

        private ScanTime scanTime = new ScanTime();

        public ScanTime ScanTime
        {
            get { return scanTime; }
            set { scanTime = value; }
        }

        #endregion

        #region Methods

        public void SaveData(int amountRows)
        {
            ProNetModel db = new ProNetModel();

            for (int i = 1; i <= amountRows; i++)
            {
                ProNetScanResultStage obj = new ProNetScanResultStage();

                #region Scanner Name

                int rowsSNPercentaje1 = (scannerName.Value1 * amountRows) / 100;
                int rowsSNPercentaje2 = (scannerName.Value2 * amountRows) / 100;

                switch (scannerName.Option1)
                {
                    case ValueOption.Percentaje:
                        if(i <= rowsSNPercentaje1)
                            obj.ScannerName = scannerName.ScannerName1;
                        break;
                    case ValueOption.Amount:
                        if (i <= scannerName.Value1)
                            obj.ScannerName = scannerName.ScannerName1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (scannerName.Option2)
                {
                    case ValueOption.Percentaje:
                        if(i > rowsSNPercentaje1 && i <= (rowsSNPercentaje1 + rowsSNPercentaje2))
                            obj.ScannerName = scannerName.ScannerName2;
                        break;
                    case ValueOption.Amount:
                        if (i > scannerName.Value1 && i <= (scannerName.Value1 + scannerName.Value2))
                            obj.ScannerName = scannerName.ScannerName2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region Scan Time

                int rowsSTPercentaje1 = (scanTime.Value1 * amountRows) / 100;
                int rowsSTPercentaje2 = (scanTime.Value2 * amountRows) / 100;

                switch (scanTime.Option1)
                {
                    case ValueOption.Percentaje:
                        if (i <= rowsSTPercentaje1)
                            obj.ScanTime = scanTime.Date1;
                        break;
                    case ValueOption.Amount:
                        if (i <= scanTime.Value1)
                            obj.ScanTime = scanTime.Date1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (scanTime.Option2)
                {
                    case ValueOption.Percentaje:
                        if (i > rowsSTPercentaje1 && i <= (rowsSTPercentaje1 + rowsSTPercentaje2))
                            obj.ScanTime = scanTime.Date2;
                        break;
                    case ValueOption.Amount:
                        if (i > scanTime.Value1 && i <= (scanTime.Value1 + scanTime.Value2))
                            obj.ScanTime = scanTime.Date2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                db.ProNetScanResultStages.Add(obj);
            }

            db.SaveChanges();
        }

        #endregion
    }
}
