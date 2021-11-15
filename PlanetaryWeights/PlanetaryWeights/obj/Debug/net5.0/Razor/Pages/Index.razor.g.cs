#pragma checksum "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69527028884d3a87ac223d5e897ad633bcf99f38"
// <auto-generated/>
#pragma warning disable 1591
namespace PlanetaryWeights.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using PlanetaryWeights;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\_Imports.razor"
using PlanetaryWeights.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Let\'s calculate your weight on different planets!</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div>How much do you weigh here on Earth?</div>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "class", "form-control");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
                                               Pounds

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pounds = __value, Pounds));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.AddMarkupContent(8, "<div>And on what planet would you like to know your weight?</div>\r\n");
            __builder.OpenElement(9, "select");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
                                    ChosenPlanet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ChosenPlanet = __value, ChosenPlanet));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 9 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
     foreach (string planet in planets)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 11 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
                        planet

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 11 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
__builder.AddContent(15, planet);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
 switch (ChosenPlanet)
{
    case "Mercury":
        WeightOnPlanet = Mass * 3.7;
        break;
    case "Venus":
        WeightOnPlanet = Mass * 8.87;
        break;
    case "Mars":
        WeightOnPlanet = Mass * 3.711;
        break;
    case "Jupiter":
        WeightOnPlanet = Mass * 24.79;
        break;
    case "Saturn":
        WeightOnPlanet = Mass * 10.44;
        break;
    case "Uranus":
        WeightOnPlanet = Mass * 8.69;
        break;
    case "Neptune":
        WeightOnPlanet = Mass * 11.15;
        break;
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddContent(17, "You would weigh ");
#nullable restore
#line 42 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
__builder.AddContent(18, WeightOnPlanetFormatted);

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, " lbs on ");
#nullable restore
#line 42 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
__builder.AddContent(20, ChosenPlanet);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\sethj\Documents\PlanetaryWeights\PlanetaryWeights\Pages\Index.razor"
              
            public int Pounds { get; set; }
            public double Mass => Pounds / 9.81;
            public string ChosenPlanet { get; set; }
            public double WeightOnPlanet { get; set; }
            public string WeightOnPlanetFormatted => WeightOnPlanet.ToString("0.####");
            public List<string> planets = new List<string>() { "Mercury", "Venus", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
