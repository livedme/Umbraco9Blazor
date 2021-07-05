using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmbracoBlazor.BlazorComponents
{
    public class TwoWayDataBindingBase: ComponentBase
    {
        public string Name { get; set; } = "My Name";
    }
}
