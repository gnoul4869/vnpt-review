#pragma checksum "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f333d5a5b5c38e0f90bb9057fd5483791239d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offices_Index), @"mvc.1.0.view", @"/Views/Offices/Index.cshtml")]
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
#line 1 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\_ViewImports.cshtml"
using VNPT_Review;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\_ViewImports.cshtml"
using VNPT_Review.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f333d5a5b5c38e0f90bb9057fd5483791239d4", @"/Views/Offices/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c760d82600bd198577a6cb6fddbf4edf7260d8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Offices_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VNPT_Review.Models.UOfficeReview>
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
#line 3 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f333d5a5b5c38e0f90bb9057fd5483791239d43719", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table id=\"offices\" class=\"table table-striped table-bordered\" style=\"width:100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.office.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.office.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.office.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.office.FatherId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.office.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.office.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\gnoul\Synced Folder\Google Drive\Web\_webapp\VNPT_Review\Views\Offices\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.office.UpdatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n");
            WriteLiteral("</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function() {
            $('#offices').DataTable({
                processing: true,
                serverSide: true,
                searching: true,
                ordering: true,
                paging: true,
                ""ajax"": {
                    ""url"": ""api/APIOffice"",
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                columns: [
                    { ""data"": ""id"", ""name"": ""Mã phòng ban"", ""autoWidth"": true },
                    { ""data"": ""name"", ""name"": ""Tên phòng ban"", ""autoWidth"": true },
                    { ""data"": ""note"", ""name"": ""Ghi chú"", ""autoWidth"": true },
                    { ""data"": ""fatherId"", ""name"": ""Đơn vị cha"", ""autoWidth"": true },
                    { ""data"": ""active"", ""name"": ""Hoạt động"", ""autoWidth"": true },
                    { ""data"": ""createdAt"", ""name"": ""Ngày tạo"", ""autoWidth"": true},
                    { ""data"": ""updatedAt"",");
                WriteLiteral(" \"name\": \"Ngày cập nhật\", \"autoWidth\": true }\r\n                ],\r\n                language: {\r\n                    \"emptyTable\": \"Không tìm thấy dữ liệu nào :(\"\r\n                }\r\n            });\r\n        });\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VNPT_Review.Models.UOfficeReview> Html { get; private set; }
    }
}
#pragma warning restore 1591
