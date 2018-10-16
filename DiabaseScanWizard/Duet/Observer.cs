using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroconf;

namespace DiabaseScanWizard.Duet
{
    public class Observer : IObserver<IZeroconfHost>
    {
        private ListBox list;
        private List<MachineInfo> boardList;

        private readonly string HttpService = "_http._tcp.local.";

        public Observer(ListBox listToFill, List<MachineInfo> boards)
        {
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
                list.Enabled = true;
            }

            boardList.Add(info);
            list.Items.Add(info.Name);
            if (list.SelectedIndex == -1)
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
                        Task.Run(async () =>
                        {
#if !DEBUG
                            // Request oem.json from the Duet
                            OemInfo info = await OemInfo.Get(value.IPAddress);
                            if (info.Vendor == "diabase")
#endif
                            {
                                // This is a Diabase machine
                                ExtendedStatusResponse statusResponse = await ExtendedStatusResponse.Get(value.IPAddress);
                                MachineInfo boardInfo = new MachineInfo
                                {
                                    IPAddress = value.IPAddress,
                                    Name = statusResponse.Name
                                };

                                list.BeginInvoke(new ItemAddDelegate(AddItem), boardInfo);
                            }
                        });
                    }
                }
            }
        }
    }
}
