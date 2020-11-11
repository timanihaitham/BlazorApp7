using Microsoft.AspNetCore.Components;
using System;
using System.Threading;

namespace HexaSystems.Application.Controls
{
    public class Hex_Timer_Code : ComponentBase

    {
        public DateTime CurentTime { get; set; }

        public Hex_Timer_Code()
        {
            System.Threading.Timer _Tm = new System.Threading.Timer(new TimerCallback(Do), null, 0, 1000);
        }
        private void Do(object sender)
        {
            CurentTime = DateTime.Now;
            StateHasChanged();
        }
    }
}
