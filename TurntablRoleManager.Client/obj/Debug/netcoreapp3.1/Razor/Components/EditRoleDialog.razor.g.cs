#pragma checksum "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6215cd5d0bd046189c9ea3742c855259a6a10b8e"
// <auto-generated/>
#pragma warning disable 1591
namespace TurntablRoleManager.Client.Components
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
    public partial class EditRoleDialog : EditRoleDialogBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
 if (ShowDialog)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<h5 class=\"modal-title\" id=\"titleLabel\"><strong>Update Role</strong></h5>\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "data-dismiss", "modal");
            __builder.AddAttribute(22, "aria-label", "Close");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
                                                                                                          Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-body");
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(31);
            __builder.AddAttribute(32, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
                                      RoleModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
                                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.AddMarkupContent(39, "<label for=\"name\">Name : </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "id", "name");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "placeholder", "Enter name");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
                                                                                    RoleModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RoleModel.Name = __value, RoleModel.Name))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RoleModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.AddMarkupContent(52, "<label for=\"description\">Description : </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "id", "description");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "placeholder", "Enter description");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
                                                                                           RoleModel.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RoleModel.Description = __value, RoleModel.Description))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RoleModel.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n                        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "modal-footer");
                __builder2.AddMarkupContent(64, "\r\n                            ");
                __builder2.AddMarkupContent(65, "<button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n                            ");
                __builder2.OpenElement(66, "button");
                __builder2.AddAttribute(67, "type", "button");
                __builder2.AddAttribute(68, "class", "btn btn-secondary");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
                                                                                      Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "data-dismiss", "modal");
                __builder2.AddContent(71, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 36 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 38 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 41 "C:\Users\Mr. Erbynn\dev\TURNTABL\deploy\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\EditRoleDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
