#pragma checksum "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b14b454fb02e2fcbc9890f9a9c47ff8753ee97a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Story_Content), @"mvc.1.0.view", @"/Views/Story/Content.cshtml")]
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
#line 1 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
using BookStory.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b14b454fb02e2fcbc9890f9a9c47ff8753ee97a", @"/Views/Story/Content.cshtml")]
    #nullable restore
    public class Views_Story_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
  
    ViewBag.Title = "Content";
    Layout = "_StoryLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""chapter-big-container"" class=""container chapter"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <button type=""button""
                    class=""btn btn-responsive btn-success toggle-nav-open"">
                <span class=""glyphicon glyphicon-menu-updownswitch""></span>
            </button>
            <a class=""truyen-title""");
            BeginWriteAttribute("href", "\r\n               href=\"", 517, "\"", 574, 2);
            WriteAttributeValue("", 540, "/Story/Detail/", 540, 14, true);
#nullable restore
#line 17 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 554, ViewBag.Chapter.Sid, 554, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 575, "\"", 604, 1);
#nullable restore
#line 17 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 583, ViewBag.Chapter.Name, 583, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                                  Write(ViewBag.Chapter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <h2>\r\n                <a class=\"chapter-title\"");
            BeginWriteAttribute("href", " href=\"", 691, "\"", 761, 4);
            WriteAttributeValue("", 698, "/Story/Content/", 698, 15, true);
#nullable restore
#line 19 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 713, ViewBag.Chapter.Sid, 713, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 733, "/", 733, 1, true);
#nullable restore
#line 19 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 734, ViewBag.Chapter.Chapnumber, 734, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n                   title=\"", 762, "\"", 814, 1);
#nullable restore
#line 20 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 790, ViewBag.Chapter.Subname, 790, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span class=\"chapter-text\"><span>");
#nullable restore
#line 21 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                Write(ViewBag.Chapter.Subname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                </a>\r\n            </h2>\r\n            <hr class=\"chapter-start\">\r\n");
#nullable restore
#line 25 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
             if (Context.Session.GetString("user") != null)
            {
                if (ViewBag.IsSave == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1173, "\"", 1201, 1);
#nullable restore
#line 29 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1181, ViewBag.Chapter.Sid, 1181, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id\" id=\"sid\">\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1264, "\"", 1299, 1);
#nullable restore
#line 30 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1272, ViewBag.Chapter.Chapnumber, 1272, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id1\" id=\"chapnumber\">\r\n                    <button onclick=\"savechapter()\" class=\"btn btn-success\">Lưu chương</button>\r\n");
#nullable restore
#line 32 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1527, "\"", 1555, 1);
#nullable restore
#line 35 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1535, ViewBag.Chapter.Sid, 1535, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id\" id=\"sid\">\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1618, "\"", 1653, 1);
#nullable restore
#line 36 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 1626, ViewBag.Chapter.Chapnumber, 1626, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id1\" id=\"chapnumber\">\r\n                    <button onclick=\"unsavechapter()\" class=\"btn btn-success\">Bỏ lưu chương</button>\r\n");
#nullable restore
#line 38 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/User/Login/\"><button class=\"btn btn-success\">Lưu chương</button></a>\r\n");
#nullable restore
#line 43 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin-top: 30px\" class=\"chapter-nav\" id=\"chapter-nav-top\">\r\n                <input type=\"hidden\" id=\"ten-truyen\" value=\"co-vo-que-mua-tong-tai-tham-sau\">\r\n                <div class=\"btn-group\">\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 2207, "\"", 2302, 4);
            WriteAttributeValue("", 2215, "btn", 2215, 3, true);
            WriteAttributeValue(" ", 2218, "btn-success", 2219, 12, true);
            WriteAttributeValue(" ", 2230, "btn-chapter-nav", 2231, 16, true);
#nullable restore
#line 47 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue(" ", 2246, ViewBag.Chapter.Chapnumber.Equals("1")?"disabled":"", 2247, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", "\r\n                       href=\"", 2303, "\"", 2414, 4);
            WriteAttributeValue("", 2334, "/Story/Content/", 2334, 15, true);
#nullable restore
#line 48 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 2349, ViewBag.Chapter.Sid, 2349, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2369, "/", 2369, 1, true);
#nullable restore
#line 48 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 2370, int.Parse(ViewBag.Chapter.Chapnumber) - 1, 2370, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""prev_chap"" data-cid="""">
                        <span class=""glyphicon glyphicon-chevron-left""></span> <span class=""hidden-xs"">
                            Chương
                        </span>trước
                    </a>
                    <select class=""btn btn-success btn-chapter-nav"" onchange=""window.location.href=this.value"">
");
#nullable restore
#line 54 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                         foreach (Chapter c in ViewBag.AllChapters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 2894, "\"", 2937, 4);
            WriteAttributeValue("", 2902, "/Story/Content/", 2902, 15, true);
#nullable restore
#line 56 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 2917, c.Sid, 2917, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2923, "/", 2923, 1, true);
#nullable restore
#line 56 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 2924, c.Chapnumber, 2924, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 56 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                            Write(c.Chapnumber == @ViewBag.Chapter.Chapnumber?"selected":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Chương ");
#nullable restore
#line 56 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                                                                                               Write(c.Chapnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 57 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 3111, "\"", 3239, 4);
            WriteAttributeValue("", 3119, "btn", 3119, 3, true);
            WriteAttributeValue(" ", 3122, "btn-success", 3123, 12, true);
            WriteAttributeValue(" ", 3134, "btn-chapter-nav", 3135, 16, true);
#nullable restore
#line 59 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue(" ", 3150, ViewBag.Chapter.Chapnumber.Equals(ViewBag.AllChapters.Count.ToString())?"disabled":"", 3151, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", "\r\n                       href=\"", 3240, "\"", 3351, 4);
            WriteAttributeValue("", 3271, "/Story/Content/", 3271, 15, true);
#nullable restore
#line 60 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 3286, ViewBag.Chapter.Sid, 3286, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3306, "/", 3306, 1, true);
#nullable restore
#line 60 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 3307, int.Parse(ViewBag.Chapter.Chapnumber) + 1, 3307, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                       id=""next_chap"" data-cid=""2834632"">
                        <span class=""hidden-xs"">Chương </span>tiếp <span class=""glyphicon glyphicon-chevron-right""></span>
                    </a>
                </div>
            </div><br />
            <hr class=""chapter-end"">
            <div id=""chapter-c"" class=""chapter-c"">
                ");
#nullable restore
#line 68 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
           Write(Html.Raw(ViewBag.Chapter.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <hr class=\"chapter-end\">\r\n");
#nullable restore
#line 71 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
             if (Context.Session.GetString("user") != null)
            {
                if (ViewBag.IsSave == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3994, "\"", 4022, 1);
#nullable restore
#line 75 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 4002, ViewBag.Chapter.Sid, 4002, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id\" id=\"sid\">\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4085, "\"", 4120, 1);
#nullable restore
#line 76 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 4093, ViewBag.Chapter.Chapnumber, 4093, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id1\" id=\"chapnumber\">\r\n                    <button onclick=\"savechapter()\" class=\"btn btn-success\">Lưu chương</button>\r\n");
#nullable restore
#line 78 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4348, "\"", 4376, 1);
#nullable restore
#line 81 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 4356, ViewBag.Chapter.Sid, 4356, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id\" id=\"sid\">\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4439, "\"", 4474, 1);
#nullable restore
#line 82 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 4447, ViewBag.Chapter.Chapnumber, 4447, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id1\" id=\"chapnumber\">\r\n                    <button onclick=\"unsavechapter()\" class=\"btn btn-success\">Bỏ lưu chương</button>\r\n");
#nullable restore
#line 84 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/User/Login/\"><button class=\"btn btn-success\">Lưu chương</button></a>\r\n");
#nullable restore
#line 89 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin-top: 30px\" class=\"chapter-nav\" id=\"chapter-nav-bot\">\r\n                <div class=\"btn-group\">\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 4933, "\"", 5028, 4);
            WriteAttributeValue("", 4941, "btn", 4941, 3, true);
            WriteAttributeValue(" ", 4944, "btn-success", 4945, 12, true);
            WriteAttributeValue(" ", 4956, "btn-chapter-nav", 4957, 16, true);
#nullable restore
#line 92 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue(" ", 4972, ViewBag.Chapter.Chapnumber.Equals("1")?"disabled":"", 4973, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", "\r\n                       href=\"", 5029, "\"", 5140, 4);
            WriteAttributeValue("", 5060, "/Story/Content/", 5060, 15, true);
#nullable restore
#line 93 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 5075, ViewBag.Chapter.Sid, 5075, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5095, "/", 5095, 1, true);
#nullable restore
#line 93 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 5096, int.Parse(ViewBag.Chapter.Chapnumber) - 1, 5096, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""glyphicon glyphicon-chevron-left""></span> <span class=""hidden-xs"">
                            Chương
                        </span>trước
                    </a>
                    <select class=""btn btn-success btn-chapter-nav"" onchange=""window.location.href=this.value"">
");
#nullable restore
#line 99 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                         foreach (Chapter c in ViewBag.AllChapters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 5593, "\"", 5636, 4);
            WriteAttributeValue("", 5601, "/Story/Content/", 5601, 15, true);
#nullable restore
#line 101 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 5616, c.Sid, 5616, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5622, "/", 5622, 1, true);
#nullable restore
#line 101 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 5623, c.Chapnumber, 5623, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 101 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                            Write(c.Chapnumber == @ViewBag.Chapter.Chapnumber?"selected":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">Chương ");
#nullable restore
#line 101 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                                                                                               Write(c.Chapnumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 102 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                    <a");
            BeginWriteAttribute("class", " class=\"", 5810, "\"", 5938, 4);
            WriteAttributeValue("", 5818, "btn", 5818, 3, true);
            WriteAttributeValue(" ", 5821, "btn-success", 5822, 12, true);
            WriteAttributeValue(" ", 5833, "btn-chapter-nav", 5834, 16, true);
#nullable restore
#line 104 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue(" ", 5849, ViewBag.Chapter.Chapnumber.Equals(ViewBag.AllChapters.Count.ToString())?"disabled":"", 5850, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", "\r\n                       href=\"", 5939, "\"", 6050, 4);
            WriteAttributeValue("", 5970, "/Story/Content/", 5970, 15, true);
#nullable restore
#line 105 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 5985, ViewBag.Chapter.Sid, 5985, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6005, "/", 6005, 1, true);
#nullable restore
#line 105 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 6006, int.Parse(ViewBag.Chapter.Chapnumber) + 1, 6006, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""hidden-xs"">Chương </span>tiếp <span class=""glyphicon glyphicon-chevron-right""></span>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <div class=""panel-body"">
        <div class=""story-comment-wrapper"">
            <div class=""media"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title pull-left"">
                        <i class=""fa fa-comments""></i>
                        <span>Đang có ");
#nullable restore
#line 118 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                 Write(ViewBag.ListComments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" bình luận</span>
                    </h3><div class=""clearfix"">
                    </div>
                </div>
                <div class=""media-body"" style=""width: 100%;"">
                    <form action=""/Story/CommentChapter"" method=""post"">
                        <div>
                            <input type=""hidden"" name=""ctid""");
            BeginWriteAttribute("value", " value=\"", 6953, "\"", 6982, 1);
#nullable restore
#line 125 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 6961, ViewBag.Chapter.Ctid, 6961, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"chapnumber\"");
            BeginWriteAttribute("value", " value=\"", 7052, "\"", 7087, 1);
#nullable restore
#line 126 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 7060, ViewBag.Chapter.Chapnumber, 7060, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"sid\"");
            BeginWriteAttribute("value", " value=\"", 7150, "\"", 7178, 1);
#nullable restore
#line 127 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
WriteAttributeValue("", 7158, ViewBag.Chapter.Sid, 7158, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <textarea name=""comment"" id=""comment-content-area"" class=""form-control"" maxlength=""500"" required></textarea>
                        </div>
                        <div class=""clearfix mt-15"">
                            <div class=""pull-left"">
                                <p> <small>Bạn cần đăng nhập để đánh giá và bình luận.</small></p>
                            </div>
                            <div class=""pull-right"" style=""margin: 10px 0px"">
                                <button type=""submit"" class=""btn btn-sm btn-info"" id=""sky-comment"">Gửi bình luận </button>
                            </div>
                            <div class=""clearfix""></div>
                        </div>
                    </form>
                </div>
            </div>
            <div id=""list-comments-media"" class=""mt-10"">
                <div class=""media"">

                    <div class=""media-body"">
");
#nullable restore
#line 146 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                         if (ViewBag.ListComments != null)
                        {
                            foreach (Rating item in ViewBag.ListComments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"panel panel-default\">\r\n                                    <div class=\"panel-heading\">\r\n                                        <h4 class=\"media-heading pull-left\">\r\n");
#nullable restore
#line 153 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                              
                                                StoryDBContext storyDBContext = new StoryDBContext();
                                                List<User> listU = storyDBContext.Users.ToList();
                                                foreach (User u in listU)
                                                {
                                                    if (item.Uid == u.Uid)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span>\r\n                                                            ");
#nullable restore
#line 161 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                       Write(u.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </span>\r\n");
#nullable restore
#line 163 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                    }
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </h4>\r\n                                        <div class=\"pull-right\">\r\n                                            <small> <span class=\"text-muted\"> <i class=\"fa fa-clock-o\"></i>&nbsp;&nbsp; <time class=\"timer\">");
#nullable restore
#line 168 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                                                                                       Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</time> </span> </small>
                                        </div>
                                        <div class=""clearfix""></div>
                                    </div>
                                    <div class=""panel-body "">
                                        <span class=""form-content pull-left"">");
#nullable restore
#line 173 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                                                                        Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 176 "D:\KY5\PRN211\.NET\BookStory\BookStory\Views\Story\Content.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"list-childs\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
