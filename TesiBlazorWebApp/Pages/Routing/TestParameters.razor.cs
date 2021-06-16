using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesiBlazorWebApp.Pages.Routing
{
    public partial class TestParameters
    {
        [Parameter]
        public string Text { get; set; }
    }
}
