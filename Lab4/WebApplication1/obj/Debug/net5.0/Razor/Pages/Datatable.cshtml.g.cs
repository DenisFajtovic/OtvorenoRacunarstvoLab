#pragma checksum "C:\Users\Link\Documents\GitHub\OtvorenoRacunarstvoLab\Lab4\WebApplication1\Pages\Datatable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f4e35f6eb57a67bf7ba70ad48a0bf395d8f7fbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_Datatable), @"mvc.1.0.razor-page", @"/Pages/Datatable.cshtml")]
namespace WebApplication1.Pages
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
#line 1 "C:\Users\Link\Documents\GitHub\OtvorenoRacunarstvoLab\Lab4\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f4e35f6eb57a67bf7ba70ad48a0bf395d8f7fbe", @"/Pages/Datatable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Datatable : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Link\Documents\GitHub\OtvorenoRacunarstvoLab\Lab4\WebApplication1\Pages\Datatable.cshtml"
  
    ViewData["Title"] = "Datatable";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Link\Documents\GitHub\OtvorenoRacunarstvoLab\Lab4\WebApplication1\Pages\Datatable.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div>
    <button onclick=""fun_csv()"">Export to CSV</button>
    <button onclick=""fun_json()"">Export to JSON</button>
    <hr />
</div>
<table id=""example"" class=""display"" style=""width:100%"">
</table>
<script>

    window.onload = fun_auto();

    async function fun_json() {
        //$('#example').DataTable();

        //var arg=
        //console.log(""________"");
        //$('#example').on('search.dt', function () {
            var value = $('.dataTables_filter input').val();
            //console.log(value); // <-- the value
        //});
        //console.log(""________"");
        var apiUrl = 'http://localhost:5000/api/Database/0/' + value;
        console.log(apiUrl);
        window.open(apiUrl, '_blank');
        /*
        await fetch(apiUrl).then(response => {
            console.log(""here lives the response:"", response);
            var headers = response.headers;
            var blob = new Blob([response.body], { type: headers['application/json'] });
           ");
            WriteLiteral(@" var link = document.createElement('a');
            link.href = window.URL.createObjectURL(blob);
            link.download = ""Filename.json"";
            link.click();
        });
     */   
    }
    async function fun_csv() {
        var value = $('.dataTables_filter input').val();
        var apiUrl = 'http://localhost:5000/api/Database/1/' + value;
        console.log(apiUrl);
        window.open(apiUrl, '_blank');

    }
    async function fun_auto() {
        //var apiUrl = 'http://localhost:5359/api/Database';
        var apiUrl = 'http://localhost:5000/api/Database';
       
        
        await fetch(apiUrl).then(response => {
            return response.json();
        }).then(data => {
            // Work with JSON data here
            let dat = data.data;
            let head = data.rowNames;

            var tablehtml = document.getElementById(""example"");
            var extrahtml = """";
            extrahtml += ""<thead><tr>"";
            for (let i = 0; i < head.");
            WriteLiteral(@"length; i++) {
                extrahtml += ""<th>"" + head[i] + ""</th>"";
            }
            extrahtml += ""</tr></thead>"";
            
            for (let i = 0; i < dat.length; i++) {
                extrahtml += ""<tr>"";
                for (let j = 0; j < head.length; j++) {
                    extrahtml += ""<th>"" + dat[i][j] + ""</th>"";
                }
                extrahtml += ""</tr>"";
            }
            tablehtml.innerHTML += extrahtml;

            $('#example').DataTable();
        }).catch(err => {
            alert(err);
    });
    

    }
</script>  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
