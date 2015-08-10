using FakeData.DAL;
using FakeData.WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class ProNetScanResult : CustomNotifyPropertyChanged
    {
        #region Constructors

        public ProNetScanResult()
        {
            YesNoList.Clear();
            YesNoList.Add("Yes");
            YesNoList.Add("No");
        }

        #endregion

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

        private Listeners listeners = new Listeners();

        public Listeners Listeners
        {
            get { return listeners; }
            set { listeners = value; }
        }

        private Location localtion = new Location();

        public Location Location
        {
            get { return localtion; }
            set { localtion = value; }
        }

        private DNSName dnsName = new DNSName();

        public DNSName DNSName
        {
            get { return dnsName; }
            set { dnsName = value; }
        }

        private SoftwareSource softwareSource = new SoftwareSource();

        public SoftwareSource SoftwareSource
        {
            get { return softwareSource; }
            set { softwareSource = value; }
        }

        private ScanStart scanStart = new ScanStart();

        public ScanStart ScanStart
        {
            get { return scanStart; }
            set { scanStart = value; }
        }

        private HostName hostName = new HostName();

        public HostName HostName
        {
            get { return hostName; }
            set { hostName = value; }
        }

        private IP ip = new IP();

        public IP IP
        {
            get { return ip; }
            set { ip = value; }
        }

        private PrimaryIP primaryIP = new PrimaryIP();

        public PrimaryIP PrimaryIP
        {
            get { return primaryIP; }
            set { primaryIP = value; }
        }

        private PrimaryIPAddress primaryIPAddress = new PrimaryIPAddress();

        public PrimaryIPAddress PrimaryIPAddress
        {
            get { return primaryIPAddress; }
            set { primaryIPAddress = value; }
        }

        private WMI wmi = new WMI();

        public WMI WMI
        {
            get { return wmi; }
            set { wmi = value; }
        }

        private WMIIndex wmiIndex = new WMIIndex();

        public WMIIndex WMIIndex
        {
            get { return wmiIndex; }
            set { wmiIndex = value; }
        }

        private VM vm = new VM();

        public VM VM
        {
            get { return vm; }
            set { vm = value; }
        }
        private ObservableCollection<string> yesnolist = new ObservableCollection<string>();

        public ObservableCollection<string> YesNoList
        {
            get { return yesnolist; }
            set { yesnolist = value; NotifyPropertyChanged(); }
        }   


        #endregion

        #region Methods

        public void SaveData(int amountRows)
        {
            ProNetModel db = new ProNetModel();

            #region Percentages

            int rowsSNPercentage1 = (scannerName.Amount1 * amountRows) / 100;
            int rowsSNPercentage2 = (scannerName.Amount2 * amountRows) / 100;

            int rowsSTPercentage1 = (scanTime.Amount1 * amountRows) / 100;
            int rowsSTPercentage2 = (scanTime.Amount2 * amountRows) / 100;

            int rowsDCPercentage1 = (dataCenter.Amount1 * amountRows) / 100;
            int rowsDCPercentage2 = (dataCenter.Amount2 * amountRows) / 100;

            int rowsDTPercentage1 = (deviceType.Amount1 * amountRows) / 100;
            int rowsDTPercentage2 = (deviceType.Amount2 * amountRows) / 100;

            int rowsSysTPercentage1 = (systemType.Amount1 * amountRows) / 100;
            int rowsSysTPercentage2 = (systemType.Amount2 * amountRows) / 100;

            int rowsLPercentage1 = (listeners.Amount1 * amountRows) / 100;
            int rowsLPercentage2 = (listeners.Amount2 * amountRows) / 100;

            int rowsLocPercetage1 = (localtion.Amount1 * amountRows) / 100;
            int rowsLocPercetage2 = (localtion.Amount2 * amountRows) / 100;

            int rowsDNSPercentage1 = (dnsName.Amount1 * amountRows) / 100;
            int rowsDNSPercentage2 = (dnsName.Amount2 * amountRows) / 100;

            int rowsSFPercentage1 = (softwareSource.Amount1 * amountRows) / 100;
            int rowsSFPercentage2 = (softwareSource.Amount2 * amountRows) / 100;

            int rowsSSPercentage1 = (scanStart.Amount1 * amountRows) / 100;
            int rowsSSPercentage2 = (scanStart.Amount2 * amountRows) / 100;

            int rowsHNPercentage1 = (hostName.Amount1 * amountRows) / 100;
            int rowsHNPercentage2 = (hostName.Amount2 * amountRows) / 100;

            int rowsIPPercentage1 = (ip.Amount1 * amountRows) / 100;
            int rowsIPPercentage2 = (ip.Amount2 * amountRows) / 100;

            int rowsPIPPercentage1 = (primaryIP.Amount1 * amountRows) / 100;
            int rowsPIPPercentage2 = (primaryIP.Amount2 * amountRows) / 100;

            int rowsPIPAddressPerc1 = (primaryIPAddress.Amount1 * amountRows) / 100;
            int rowsPIPAddressPerc2 = (primaryIPAddress.Amount2 * amountRows) / 100;

            int rowsWMIPercentage1 = (wmi.Amount1 * amountRows) / 100;
            int rowsWMIPercentage2 = (wmi.Amount2 * amountRows) / 100;

            int rowsWMIIndexPerc1 = (wmiIndex.Amount1 * amountRows) / 100;
            int rowsWMIIndexPerc2 = (wmiIndex.Amount2 * amountRows) / 100;

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
                            obj.ScannerName = scannerName.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= scannerName.Amount1)
                            obj.ScannerName = scannerName.Value1;
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
                            obj.ScannerName = scannerName.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > scannerName.Amount1 && i <= (scannerName.Amount1 + scannerName.Amount2))
                            obj.ScannerName = scannerName.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region IP

                switch (ip.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsIPPercentage1)
                            obj.IP = ip.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= ip.Amount1)
                            obj.IP = ip.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (ip.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsIPPercentage1 && i <= (rowsIPPercentage1 + rowsIPPercentage2))
                            obj.IP = ip.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > ip.Amount1 && i <= (ip.Amount1 + ip.Amount2))
                            obj.IP = ip.Value2;
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
                            obj.ScanTime = scanTime.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= scanTime.Amount1)
                            obj.ScanTime = scanTime.Value1;
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
                            obj.ScanTime = scanTime.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > scanTime.Amount1 && i <= (scanTime.Amount1 + scanTime.Amount2))
                            obj.ScanTime = scanTime.Value2;
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
                            obj.DataCenter = dataCenter.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= dataCenter.Amount1)
                            obj.DataCenter = dataCenter.Value1;
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
                            obj.DataCenter = dataCenter.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > dataCenter.Amount1 && i <= (dataCenter.Amount1 + dataCenter.Amount2))
                            obj.DataCenter = dataCenter.Value2;
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
                            obj.DeviceType = deviceType.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= deviceType.Amount1)
                            obj.DeviceType = deviceType.Value1;
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
                            obj.DeviceType = deviceType.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > deviceType.Amount1 && i <= (deviceType.Amount1 + deviceType.Amount2))
                            obj.DeviceType = deviceType.Value2;
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
                            obj.SystemType = systemType.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= systemType.Amount1)
                            obj.SystemType = systemType.Value1;
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
                            obj.SystemType = systemType.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > systemType.Amount1 && i <= (systemType.Amount1 + systemType.Amount2))
                            obj.SystemType = systemType.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region Primary IP

                switch (primaryIP.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsPIPPercentage1)
                            obj.PrimaryIP = primaryIP.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= primaryIP.Amount1)
                            obj.PrimaryIP = primaryIP.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (primaryIP.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsPIPPercentage1 && i <= (rowsPIPPercentage1 + rowsPIPPercentage2))
                            obj.PrimaryIP = primaryIP.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > primaryIP.Amount1 && i <= (primaryIP.Amount1 + primaryIP.Amount2))
                            obj.PrimaryIP = primaryIP.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }


                #endregion

                #region Primary IP Address

                switch (primaryIPAddress.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsPIPAddressPerc1)
                            obj.PrimaryIPAddress = primaryIPAddress.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= primaryIPAddress.Amount1)
                            obj.PrimaryIPAddress = primaryIPAddress.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (primaryIPAddress.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsPIPAddressPerc1 && i <= (rowsPIPAddressPerc1 + rowsPIPAddressPerc2))
                            obj.PrimaryIPAddress = primaryIPAddress.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > primaryIPAddress.Amount1 && i <= (primaryIPAddress.Amount1 + primaryIPAddress.Amount2))
                            obj.PrimaryIPAddress = primaryIPAddress.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }


                #endregion

                #region WMI

                switch (wmi.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsWMIPercentage1)
                            obj.wmi = wmi.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= wmi.Amount1)
                            obj.wmi = wmi.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (wmi.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsWMIPercentage1 && i <= (rowsWMIPercentage1 + rowsWMIPercentage2))
                            obj.wmi = wmi.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > wmi.Amount1 && i <= (wmi.Amount1 + wmi.Amount2))
                            obj.wmi = wmi.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }


                #endregion

                #region WMI Index

                switch (wmiIndex.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsWMIIndexPerc1)
                            obj.wmiIndex = wmiIndex.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= wmiIndex.Amount1)
                            obj.wmiIndex = wmiIndex.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (wmiIndex.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsWMIIndexPerc1 && i <= (rowsWMIIndexPerc1 + rowsWMIIndexPerc2))
                            obj.wmiIndex = wmiIndex.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > wmiIndex.Amount1 && i <= (wmiIndex.Amount1 + wmiIndex.Amount2))
                            obj.wmiIndex = wmiIndex.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }


                #endregion

                #region Listeners

                switch (listeners.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsLPercentage1)
                            obj.listeners = listeners.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= listeners.Amount1)
                            obj.listeners = listeners.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (listeners.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsLPercentage1 && i <= (rowsLPercentage1 + rowsLPercentage2))
                            obj.listeners = listeners.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > listeners.Amount1 && i <= (listeners.Amount1 + listeners.Amount2))
                            obj.listeners = listeners.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region Location

                switch (localtion.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsLocPercetage1)
                            obj.Location = localtion.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= localtion.Amount1)
                            obj.Location = localtion.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (localtion.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsLocPercetage1 && i <= (rowsLocPercetage1 + rowsLocPercetage2))
                            obj.Location = localtion.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > localtion.Amount1 && i <= (localtion.Amount1 + localtion.Amount2))
                            obj.Location = localtion.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region DNS Name

                switch (dnsName.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsDNSPercentage1)
                            obj.DNSName = dnsName.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= dnsName.Amount1)
                            obj.DNSName = dnsName.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (dnsName.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsDNSPercentage1 && i <= (rowsDNSPercentage1 + rowsDNSPercentage2))
                            obj.DNSName = dnsName.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > dnsName.Amount1 && i <= (dnsName.Amount1 + dnsName.Amount2))
                            obj.DNSName = dnsName.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region Software Source

                switch (softwareSource.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsSFPercentage1)
                            obj.SoftwareSource = softwareSource.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= softwareSource.Amount1)
                            obj.SoftwareSource = softwareSource.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (softwareSource.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsSFPercentage1 && i <= (rowsSFPercentage1 + rowsSFPercentage2))
                            obj.SoftwareSource = softwareSource.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > softwareSource.Amount1 && i <= (softwareSource.Amount1 + softwareSource.Amount2))
                            obj.SoftwareSource = softwareSource.Value2;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }


                #endregion

                #region Scan Start

                // Example data seems to be datetime.

                switch (scanStart.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsSSPercentage1)
                            obj.ScanStart = scanStart.Value1.ToString(); 
                        break;
                    case ValueOption.Amount:
                        if (i <= scanStart.Amount1)
                            obj.ScanStart = scanStart.Value1.ToString();
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (scanStart.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsSSPercentage1 && i <= (rowsSSPercentage1 + rowsSSPercentage2))
                            obj.ScanStart = scanStart.Value2.ToString();
                        break;
                    case ValueOption.Amount:
                        if (i > scanStart.Amount1 && i <= (scanStart.Amount1 + scanStart.Amount2))
                            obj.ScanStart = scanStart.Value2.ToString();
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                #endregion

                #region Host Name

                switch (hostName.Option1)
                {
                    case ValueOption.Percentage:
                        if (i <= rowsHNPercentage1)
                            obj.Hostname = hostName.Value1;
                        break;
                    case ValueOption.Amount:
                        if (i <= hostName.Amount1)
                            obj.Hostname = hostName.Value1;
                        break;
                    case ValueOption.Remain:
                        break;
                    default:
                        break;
                }

                switch (hostName.Option2)
                {
                    case ValueOption.Percentage:
                        if (i > rowsHNPercentage1 && i <= (rowsHNPercentage1 + rowsHNPercentage2))
                            obj.Hostname = hostName.Value2;
                        break;
                    case ValueOption.Amount:
                        if (i > hostName.Amount1 && i <= (hostName.Amount1 + hostName.Amount2))
                            obj.Hostname = hostName.Value2;
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
