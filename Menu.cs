using EasyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRChat_Analytics_Blocker
{
    public class MenuProgram : Program
    {
        public MenuProgram() : base("VRChat Analytics Blocker", breadcrumbHeader: true)
        {
            AddPage(new MainPage(this));
            SetPage<MainPage>();
        }
    }

    public class MainPage : MenuPage
    {
        public MainPage(Program program) : base("VRChat Analytics Blocker", program,
          new Option("Block Analytics", () => { Actions.ModifyAnalyticsBlocking(true); }),
          new Option("Unblock Analytics", () => { Actions.ModifyAnalyticsBlocking(false); }))
        {
        }
    }
}
