#pragma checksum "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Pages\ViewAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fbc988b86187615ae45fb6eeb734706ae692728"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNPAssignment.Pages
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
#line 2 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Pages\ViewAdults.razor"
using DNPAssignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Pages\ViewAdults.razor"
using Microsoft.AspNetCore.Mvc.Filters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Pages\ViewAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAdults")]
    public partial class ViewAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\jtyta\RiderProjects\DNPAssignment\DNPAssignment\Pages\ViewAdults.razor"
 

    private IList<Person> adults;
    private IList<Person> peopleToShow;

    private void Filter(ChangeEventArgs changeEventArgs)
    {
        string? filterByName = "";
        try
        {
            filterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
        }
        if (filterByName != "")
        {
            peopleToShow = adults.Where(t => t.FirstName == filterByName).ToList();
        }
        else
        {
            peopleToShow = adults;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        adults = GetAdults.GetAllAdults();
        peopleToShow = adults;

        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login");
        }
    }
    
    private void RemovePerson(int personId)
    {
        Person personToRemove = adults.First(t => t.Id == personId);
        GetAdults.RemovePerson(personId);
        adults.Remove(personToRemove);
    }
    
    
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InterfaceGetAdults GetAdults { get; set; }
    }
}
#pragma warning restore 1591
