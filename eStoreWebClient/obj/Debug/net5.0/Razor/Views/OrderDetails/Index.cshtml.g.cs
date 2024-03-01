#pragma checksum "D:\PRN211\Assignment3\eStoreWebClient\Views\OrderDetails\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "53e488cc259eb6f3eebe58edfceb0cfd19080c2ca74fe7513d4e3cfd573818a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails_Index), @"mvc.1.0.view", @"/Views/OrderDetails/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PRN211\Assignment3\eStoreWebClient\Views\_ViewImports.cshtml"
using eStoreWebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRN211\Assignment3\eStoreWebClient\Views\_ViewImports.cshtml"
using eStoreWebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"53e488cc259eb6f3eebe58edfceb0cfd19080c2ca74fe7513d4e3cfd573818a3", @"/Views/OrderDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a55d4d89a62ff95361bab10baf5af0817f08a77b9cecfb74ddd5b30d5288287f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_OrderDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessObject.Models.OrderDetail>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRN211\Assignment3\eStoreWebClient\Views\OrderDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var orderId = ViewData["OrderId"] ?? "Unknown";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<style>\r\n    .table img.delete, .table img.edit {\r\n        width: 25px; /* Điều chỉnh kích thước theo nhu cầu */\r\n        height: auto; /* Duy trì tỉ lệ */\r\n        cursor: pointer; /* Chỉ báo có thể click */\r\n    }\r\n</style>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53e488cc259eb6f3eebe58edfceb0cfd19080c2ca74fe7513d4e3cfd573818a34127", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\PRN211\Assignment3\eStoreWebClient\Views\OrderDetails\Index.cshtml"
                             WriteLiteral(orderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<div class=""container-fluid"">
    <h2>OrderDetails</h2>
    <table class=""table table-sm table-striped table-bordered m-2"">
        <thead>
            <tr>
                <th>orderId</th>
                <th>productid</th>
                <th>unitprice</th>
                <th>quantity</th>
                <th>discount</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>
<script type=""text/javascript"">
    $(document).ready(function () {
        ShowAllOrders();

        function ShowAllOrders() {

            $(""table tbody"").html("""");
            $.ajax({
                url: ""http://localhost:33147/api/OrderDetails/"" + ");
#nullable restore
#line 43 "D:\PRN211\Assignment3\eStoreWebClient\Views\OrderDetails\Index.cshtml"
                                                             Write(orderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (result, status, xhr) {
                    $.each(result, function (index, value) {
                        var row = $(""<tr></tr>"");
                        row.append($(""<td>"").text(value.orderId));
                        row.append($(""<td>"").text(value.productId));
                        row.append($(""<td>"").text(value.unitPrice));
                        row.append($(""<td>"").text(value.quantity));
                        row.append($(""<td>"").text(value.discount));

                        var editUrl = ""/OrderDetails/Edit?oid="" + value.orderId + ""&pid="" + value.productId;
                        row.append($(""<td>"").html(""<a href='"" + editUrl + ""'><img class='edit' src='icon/edit.jpg' /></a>""));
                        row.append($(""<td>"").html(""<img class='delete' src='icon/delete.jpg' data-product-id='"" + value.orderId + ""'/>""));
                        ");
            WriteLiteral(@"$(""table tbody"").append(row);
                    });

                    $(""img.edit, img.delete"").css({
                        ""width"": ""25px"",
                        ""height"": ""auto"",
                        ""cursor"": ""pointer""
                    });

                },
                error: function (xhr, status, error) {
                    console.error(xhr);
                }
            });
        }
        $(""table"").on(""click"", ""img.delete"", function () {
            var oid = $(this).closest(""tr"").find(""td:nth-child(1)"").text();
            var productId = $(this).closest(""tr"").find(""td:nth-child(2)"").text();
            $.ajax({
                url: ""http://localhost:33147/api/OrderDetails?oid="" + oid + ""&pid="" + productId,
                type: ""DELETE"",
                contentType: ""application/json"",
                success: function (result, status, xhr) {
                    ShowAllOrders();
                },
                error: function (xhr, status, error)");
            WriteLiteral(" {\r\n                    console.error(xhr);\r\n                }\r\n            });\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessObject.Models.OrderDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
