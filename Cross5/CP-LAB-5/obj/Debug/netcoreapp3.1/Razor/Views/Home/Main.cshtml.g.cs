#pragma checksum "C:\Users\si010\Downloads\Cross5\CP-LAB-5\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b30278ec8a40d055779d5d4e0d31e2cf78894559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\si010\Downloads\Cross5\CP-LAB-5\Views\_ViewImports.cshtml"
using CP_LAB_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\si010\Downloads\Cross5\CP-LAB-5\Views\_ViewImports.cshtml"
using CP_LAB_5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b30278ec8a40d055779d5d4e0d31e2cf78894559", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d29d1ef31492a4d99cf437f8f77a7ce67dac19e1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\si010\Downloads\Cross5\CP-LAB-5\Views\Home\Main.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Вітання!</h1>
    <h2>Це Лабораторна робота 5 з Кроспл. прогр.</h2>
    <p>Потрібно створити веб застосунок (ASP.NET Core MVC)</p>
</div>

<div class=""d-flex"">
    <ul class=""list-inline mx-auto justify-content-center list-group"">
        <li class=""list-group-item"">1: На веб додатку повинно бути 3 сторінки для кожної лаб. роботи (1-3).</li>
        <li class=""list-group-item"">2: Головна сторінка з описом та основною інф.</li>
        <li class=""list-group-item"">3: Сторінка логіну, реєстрації та профілю користувача.</li>
        <li class=""list-group-item"">4: Доступ до сторінок окрім Головної та Реєстрації\Логіну доступний після авторизації.</li>
        <li class=""list-group-item"">5: Авторизація і аунифікація реалізується через OAuth2.</li>
        <li class=""list-group-item"">6: На сторінці профілю можна переглядати дані, але не змінювати.</li>
    </ul>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591