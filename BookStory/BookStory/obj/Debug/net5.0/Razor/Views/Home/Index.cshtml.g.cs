#pragma checksum "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c06d77ed195fa35ec8fc5f1dd5962860db9b715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
using BookStory.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c06d77ed195fa35ec8fc5f1dd5962860db9b715", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home";
    Layout = "_StoryLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"" id=""intro-index"">
    <div class=""title-list"">
        <a href=""/Story/Search/Hot"" title=""Truyện hot"">
            <span class=""glyphicon glyphicon-fire""></span>
        </a>
        <h2><a href=""/Story/Search/Hot"" title=""Truyện hot"">Truyện hot</a></h2>
        <h2><a href=""/Story/Search/New"" title=""Truyện mới"">Truyện mới</a></h2>
        <h2><a href=""/Story/Search/Full"" title=""Truyện full"">Truyện full</a></h2>
        <form action=""/Home/Index/"" method=""post"">
            <select name=""id"" onchange=""this.form.submit()"" id=""hot-select""
                    class=""form-control new-select"" aria-label=""Chọn thể loại"">
                <option value=""0"">Tất cả</option>
");
#nullable restore
#line 21 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                 foreach (Category c in ViewBag.Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 965, "\"", 979, 1);
#nullable restore
#line 23 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 973, c.Cid, 973, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 23 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                       Write(ViewBag.CurrentId == c.Cid ?"selected":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 23 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                                                                   Write(c.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 24 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </form>\r\n    </div>\r\n    <div class=\"index-intro\">\r\n");
#nullable restore
#line 29 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
         foreach (Story s in ViewBag.Stories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item top-1\" itemscope");
            BeginWriteAttribute("itemtype", " itemtype=\"", 1250, "\"", 1261, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1283, "\"", 1310, 2);
            WriteAttributeValue("", 1290, "/Story/Detail/", 1290, 14, true);
#nullable restore
#line 32 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 1304, s.Sid, 1304, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" itemprop=\"url\">\r\n                    <span");
            BeginWriteAttribute("class", " class=\"", 1354, "\"", 1394, 1);
#nullable restore
#line 33 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 1362, s.Status == 1?"full-label":"", 1362, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span><img");
            BeginWriteAttribute("src", " src=\"", 1407, "\"", 1421, 1);
#nullable restore
#line 33 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 1413, s.Image, 1413, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                                                           alt=\"", 1422, "\"", 1511, 1);
#nullable restore
#line 34 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 1504, s.Name, 1504, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive item-img\" itemprop=\"image\">\r\n                    <div class=\"title\">\r\n                        <h3 itemprop=\"name\">");
#nullable restore
#line 36 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                       Write(s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 40 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<div class=""container"" id=""list-index"">
    <div class=""row text-center"">
        <div id=""banner-bio-link""></div>
    </div>
    <div class=""hide"" id=""history-holder""></div>
    <div class=""list list-truyen list-new col-xs-12 col-sm-12 col-md-8 col-truyen-main"">
        <div class=""title-list"">
            <h2>
                <a href=""#"" title=""Truyện mới cập nhật"">Truyện mới cập nhật chương mới</a>
            </h2>
        </div>
");
#nullable restore
#line 54 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
         foreach (var c in ViewBag.ListNewChapters)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\" itemscope )\">\r\n                <div class=\"col-xs-9 col-sm-6 col-md-5 col-title\">\r\n                    <span class=\"label-title label-new\"></span>\r\n                    <h3 itemprop=\"name\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2522, "\"", 2553, 2);
            WriteAttributeValue("", 2529, "/Story/Detail/", 2529, 14, true);
#nullable restore
#line 60 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 2543, c.Key.Sid, 2543, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                       title=\"", 2554, "\"", 2597, 1);
#nullable restore
#line 61 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 2586, c.Key.Name, 2586, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" itemprop=\"url\">\r\n                            ");
#nullable restore
#line 62 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                       Write(c.Key.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </h3>\r\n                </div>\r\n                <div class=\"hidden-xs col-sm-3 col-md-3 col-cat text-888\">\r\n");
#nullable restore
#line 67 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                     foreach (var ct in @c.Value)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a itemprop=\"genre\"");
            BeginWriteAttribute("href", "\r\n                   href=\"", 2931, "\"", 2979, 2);
            WriteAttributeValue("", 2958, "/Story/Search/", 2958, 14, true);
#nullable restore
#line 70 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 2972, ct.Cid, 2972, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2980, "\"", 2988, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                                    Write(ct.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 71 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-xs-3 col-sm-3 col-md-2 col-chap text-info\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3151, "\"", 3201, 4);
            WriteAttributeValue("", 3158, "/Story/Content/", 3158, 15, true);
#nullable restore
#line 74 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 3173, c.Key.Sid, 3173, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3183, "/", 3183, 1, true);
#nullable restore
#line 74 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 3184, c.Key.Chapnumber, 3184, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                   title=\"", 3202, "\"", 3268, 4);
#nullable restore
#line 75 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 3230, c.Key.Name, 3230, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3241, "-", 3242, 2, true);
            WriteAttributeValue(" ", 3243, "Chương", 3244, 7, true);
#nullable restore
#line 75 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3250, c.Key.Chapnumber, 3251, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <span class=\"chapter-text\"><span>Chương </span></span>");
#nullable restore
#line 76 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                                                         Write(c.Key.Chapnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n                <div class=\"hidden-xs hidden-sm col-md-2 col-time text-888 timer\">");
#nullable restore
#line 79 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                                                             Write(c.Key.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 81 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-4 col-truyen-side\">\r\n");
#nullable restore
#line 84 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
          
            User u = null;
            string json = Context.Session.GetString("user");
            if (json != null) u = JsonConvert.DeserializeObject<User>(json);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
         if (u != null && ViewBag.SaveChapters.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"list list-truyen list-history col-xs-12\">\r\n                <div class=\"title-list\">\r\n                    <h2><a");
            BeginWriteAttribute("href", " href=\"", 4008, "\"", 4038, 2);
            WriteAttributeValue("", 4015, "/Story/ListSaved/", 4015, 17, true);
#nullable restore
#line 93 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 4032, u.Uid, 4032, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chương đã lưu</a></h2>\r\n                </div>\r\n");
#nullable restore
#line 95 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                 foreach (Chapter c in ViewBag.SaveChapters)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-md-5 col-lg-7"">
                            <span class=""glyphicon glyphicon-chevron-right""></span>
                            <h3 itemprop=""name"">
                                <a");
            BeginWriteAttribute("title", " title=\"", 4434, "\"", 4449, 1);
#nullable restore
#line 101 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 4442, c.Name, 4442, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4450, "\"", 4477, 2);
            WriteAttributeValue("", 4457, "/Story/Detail/", 4457, 14, true);
#nullable restore
#line 101 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 4471, c.Sid, 4471, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 101 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                                                          Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h3>\r\n                        </div>\r\n                        <div class=\"col-md-7 col-lg-5 text-info\">\r\n                            <a");
            BeginWriteAttribute("title", " title=\"", 4656, "\"", 4692, 3);
#nullable restore
#line 105 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 4664, c.Name, 4664, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4671, "Chương", 4672, 7, true);
#nullable restore
#line 105 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4678, c.Chapnumber, 4679, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4693, "\"", 4735, 4);
            WriteAttributeValue("", 4700, "/Story/Content/", 4700, 15, true);
#nullable restore
#line 105 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 4715, c.Sid, 4715, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4721, "/", 4721, 1, true);
#nullable restore
#line 105 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 4722, c.Chapnumber, 4722, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đọc tiếp chương ");
#nullable restore
#line 105 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                                                                                                          Write(c.Chapnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 108 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 110 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""visible-md-block visible-lg-block text-center"">
            <div class=""hide"" id=""history-holder-side""></div>
            <div class=""list list-truyen list-cat col-xs-12"">
                <div class=""title-list"">
                    <h4>Thể loại truyện</h4>
                </div>
                <div class=""row"">
");
#nullable restore
#line 118 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                     foreach (Category c in ViewBag.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-xs-6\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5390, "\"", 5417, 2);
            WriteAttributeValue("", 5397, "/Story/Search/", 5397, 14, true);
#nullable restore
#line 121 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 5411, c.Cid, 5411, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                           title=\"", 5418, "\"", 5462, 1);
#nullable restore
#line 122 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 5454, c.Title, 5454, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 122 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                       Write(c.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n");
#nullable restore
#line 124 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<div class=""container"" id=""truyen-slide"">
    <div class=""list list-thumbnail col-xs-12"">
        <div class=""title-list"">
            <h2>
                <a href=""/Story/Search/Full"" title=""Truyện full"">
                    Truyện đã hoàn
                    thành
                </a>
            </h2><a href=""#""
                    title=""Truyện full""><span class=""glyphicon glyphicon-menu-right""></span></a>
        </div>
        <div class=""row"">
");
#nullable restore
#line 142 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
             foreach (Story s in ViewBag.FullStories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xs-4 col-sm-3 col-md-2\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 6230, "\"", 6257, 2);
            WriteAttributeValue("", 6237, "/Story/Detail/", 6237, 14, true);
#nullable restore
#line 145 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 6251, s.Sid, 6251, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                   title=\"", 6258, "\"", 6293, 1);
#nullable restore
#line 146 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
WriteAttributeValue("", 6286, s.Name, 6286, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"lazyimg\"\r\n                         data-desk-image=\"");
#nullable restore
#line 148 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                     Write(s.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                         data-image=\"");
#nullable restore
#line 149 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                                Write(s.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                         data-alt=\"");
#nullable restore
#line 150 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                              Write(s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n                        <div class=\"caption\">\r\n                            <h3>");
#nullable restore
#line 152 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                           Write(s.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> <small class=\"btn-xs label-primary\">\r\n                                Full -\r\n                                ");
#nullable restore
#line 154 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
                           Write(s.Chapters.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Chương\r\n                            </small>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 159 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
