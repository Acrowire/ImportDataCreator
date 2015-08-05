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

        private DataCenter dataCenter = new DataCenter();

        public DataCenter DataCenter
        {
            get { return dataCenter; }
            set { dataCenter = value; }
        }

        private DeviceType deviceType = new DeviceType();

        public DeviceType DeviceType
        {
            get { return deviceType; }
            set { deviceType = value; }
        }

        private SystemType systemType = new SystemType();

        public SystemType SystemType
        {
            get { return systemType; }
            set { systemType = value; }
        }


        #endregion

        #region Methods

        public void SaveData(int amountRows)
        {
            ProNetModel db = new ProNetModel();

            #region Percentages

            int rowsSNPercentage1 = (scannerName.Value1 * amountRows) / 100;
            int rowsSNPercentage2 = (scannerName.Value2 * amountRows) / 100;

            int rowsSTPercentage1 = (scanTime.Value1 * amountRows) / 100;
            int rowsSTPercentage2 = (scanTime.Value2 * amountRows) / 100;

            int rowsDCPercentage1 = (dataCenter.Value1 * amountRows) / 100;
            int rowsDCPercentage2 = (dataCenter.Value2 * amountRows) / 100;

            int rowsDTPercentage1 = (deviceType.Value1 * amountRows) / 100;
            int rowsDTPercentage2 = (deviceType.Value2 * amountRows) / 100;

            int rowsSysTPercentage1 = (systemType.Value1 * amountRows) / 100;
            int rowsSysTPercentage2 = (systemType.Value2 * amountRows) / 100;

            #endregion

            for (int i = 1; i <= amountRows; i++)
            {
                ProNetScanResultStage obj = new ProNetScanResultStage();

                // TODO[WC]: Duplicate code, refactor after the approach is ok.

                #region Scanner Name
                
                switch (scannerName.Option1)
                {
                    case ValueOption.Percentage:
                        if(i <= rowsSNPercentage1)
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
                    case ValueOption.Percentage:
                        if(i > rowsSNPercentage1 && i <= (rowsSNPercentage1 + rowsSNPercentage2))
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

                switch (scanTime.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsSTPercentage1)
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
                    case ValueOption.Percentage:
                        if (i > rowsSTPercentage1 && i <= (rowsSTPercentage1 + rowsSTPercentage2))
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

                #region Data Center

                switch (dataCenter.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsDCPercentage1)
                            obj.DataCenter = dataCenter.DataCenter1;
                        break;
                    case ValueOption.Amount:
                        if (i <= dataCenter.Value1)
                            obj.DataCenter = dataCenter.DataCenter1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (dataCenter.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsDCPercentage1 && i <= (rowsDCPercentage1 + rowsDCPercentage2))
                            obj.DataCenter = dataCenter.DataCenter2;
                        break;
                    case ValueOption.Amount:
                        if (i > dataCenter.Value1 && i <= (dataCenter.Value1 + dataCenter.Value2))
                            obj.DataCenter = dataCenter.DataCenter2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region Device Type

                switch (deviceType.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsDTPercentage1)
                            obj.DeviceType = deviceType.DeviceType1;
                        break;
                    case ValueOption.Amount:
                        if (i <= deviceType.Value1)
                            obj.DeviceType = deviceType.DeviceType1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (deviceType.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsDTPercentage1 && i <= (rowsDTPercentage1 + rowsDTPercentage2))
                            obj.DeviceType = deviceType.DeviceType2;
                        break;
                    case ValueOption.Amount:
                        if (i > deviceType.Value1 && i <= (deviceType.Value1 + deviceType.Value2))
                            obj.DeviceType = deviceType.DeviceType2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region System Type

                switch (systemType.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsSysTPercentage1)
                            obj.SystemType = systemType.SystemType1;
                        break;
                    case ValueOption.Amount:
                        if (i <= systemType.Value1)
                            obj.SystemType = systemType.SystemType1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (systemType.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsSysTPercentage1 && i <= (rowsSysTPercentage1 + rowsSysTPercentage2))
                            obj.SystemType = systemType.SystemType2;
                        break;
                    case ValueOption.Amount:
                        if (i > systemType.Value1 && i <= (systemType.Value1 + systemType.Value2))
                            obj.SystemType = systemType.SystemType2;
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
