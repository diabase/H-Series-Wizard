using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroconf;

namespace DiabasePrintingWizard.Duet
{
    public class Observer : IObserver<IZeroconfHost>
    {
        private CheckBox manualConfig;
        private ListBox list;
        private List<MachineInfo> boardList;

        private readonly string HttpService = "_http._tcp.local.";

        public Observer(CheckBox manualSetup, ListBox listToFill, List<MachineInfo> boards)
        {
            manualConfig = manualSetup;
            list = listToFill;
            boardList = boards;

            ZeroconfResolver.ResolveContinuous(HttpService).Subscribe(this);
        }

        public void OnCompleted()
        {
            // unused
        }

        public void OnError(Exception error)
        {
            // unused
        }

        private delegate void ItemAddDelegate(MachineInfo info);
        private void AddItem(MachineInfo info)
        {
            if (!list.Enabled)
            {
                list.Items.Clear();
                list.Enabled = manualConfig.Checked;
            }

            if (list.Items.Count > 0)
            {
                list.Items.Insert(list.Items.Count - 1, info.Name);
            }
            else
            {
                list.Items.Add(info.Name);
            }
            boardList.Add(info);

            if (list.SelectedIndex == -1 && manualConfig.Checked)
            {
                list.SelectedIndex = 0;
            }
        }

        public void OnNext(IZeroconfHost value)
        {
            if (!String.IsNullOrEmpty(value.IPAddress))
            {
                foreach (var property in value.Services[HttpService].Properties)
                {
                    if (property.TryGetValue("product", out var product) && product.StartsWith("Duet"))
                    {
                        CheckMachine(value.IPAddress, (boardInfo) => list.BeginInvoke(new ItemAddDelegate(AddItem), boardInfo));
                    }
                }
            }
        }

        public static async Task CheckMachine(string address, Action<MachineInfo> callback)
        {
#if !DEBUG
            // Request oem.json from the Duet
            OemInfo info = await OemInfo.Get(value.IPAddress);
            if (info.Vendor == "diabase")
#endif
            {
                // This is a Diabase machine. Check the tool configuration
                ExtendedStatusResponse statusResponse = await ExtendedStatusResponse.Get(address);
                ConfigResponse configResponse = await ConfigResponse.Get(address);

                MachineInfo boardInfo = new MachineInfo
                {
                    IPAddress = address,
                    Name = statusResponse.Name,
                    Axes = statusResponse.Axes,
                    Accelerations = configResponse.Accelerations,
                    MinFeedrates = configResponse.MinFeedrates,
                    MaxFeedrates = configResponse.MaxFeedrates
                };
                foreach (var tool in statusResponse.Tools)
                {
                    boardInfo.Tools.Add(new MachineInfo.Tool
                    {
                        Number = tool.Number,
                        NumDrives = tool.Drives.Count,
                        NumHeaters = tool.Heaters.Count,
                        HasSpindle = statusResponse.Spindles.Any(spindle => spindle.Tool == tool.Number)
                    });
                }

                callback(boardInfo);
            }
        }
    }
}
