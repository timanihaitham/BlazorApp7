using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using SysTimer = System.Timers;

namespace HexaSystems.Application.Controls
{
    public class Hex_Timer_Code : ComponentBase

    {
        public DateTime CurentTime { get; set; }

        public Hex_Timer_Code()
            {
               System.Threading.Timer _Tm=new System.Threading.Timer(new TimerCallback(Do),null,0,1000);
            }
        private void Do(object sender)
        {
            CurentTime = DateTime.Now;
            StateHasChanged();
        }
    }
}
