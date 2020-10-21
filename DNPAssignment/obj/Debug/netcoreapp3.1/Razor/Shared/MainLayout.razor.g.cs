#pragma checksum "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc10be724b1539226cdb4673096cf3efef0faee3"
// <auto-generated/>
#pragma warning disable 1591
namespace DNPAssignment.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using DNPAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\_Imports.razor"
using DNPAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Shared\MainLayout.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<DNPAssignment.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<LoginComponent.Login>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddContent(19, 
#nullable restore
#line 17 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Shared\MainLayout.razor"
      

    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login");
    // NavigationManager.NavigateTo($"/Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
