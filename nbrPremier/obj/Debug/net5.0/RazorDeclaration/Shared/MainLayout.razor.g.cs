// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace nbrPremier.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using nbrPremier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\_Imports.razor"
using nbrPremier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\Shared\MainLayout.razor"
using nbrPremier.Outils;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\vielf\Documents\Mike\blazor\nbrPremier\nbrPremier\nbrPremier\Shared\MainLayout.razor"
      
    private string footerTitre = "@nbrPremier's Copyright 2021";
    private bool premier = false;
    private bool noPremier = false;


    private void onInputPrems(ChangeEventArgs args)
    {
      if (args.Value.ToString() != "")
      {
        int nombre = 0;
        try
        {
          nombre = int.Parse(args.Value.ToString());
        }catch(Exception ex)
        {
          nombre = 4;
        }
        //int nombre = int.Parse(args.Value.ToString());


        int result = NombrePremier.nbrPremier(nombre);
        if (result == 0)
        {
          noPremier = true;
          premier = false;
        }
        if (result == 1)
        {
          noPremier = false;
          premier = true;
        }

      }
      else
      {
        noPremier = false;
        premier = false;
      }
      //registerValidationForm.mail = args.Value.ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
