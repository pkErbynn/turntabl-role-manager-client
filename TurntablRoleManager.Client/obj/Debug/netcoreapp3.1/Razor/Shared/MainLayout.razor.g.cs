#pragma checksum "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ae4330b65cf24891e29a16ae281702f8ff955ff"
// <auto-generated/>
#pragma warning disable 1591
namespace TurntablRoleManager.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Shared;

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
            __builder.OpenComponent<TurntablRoleManager.Client.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.AddAttribute(17, "id", "footer");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col text-center");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "footer");
            __builder.AddMarkupContent(23, "\r\n                <br><br><hr>\r\n                ");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, "Copyright ©  ");
            __builder.AddContent(26, 
#nullable restore
#line 17 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Shared\MainLayout.razor"
                                      DateTime.Now.Year

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " - Turntabl Role Service Application");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
