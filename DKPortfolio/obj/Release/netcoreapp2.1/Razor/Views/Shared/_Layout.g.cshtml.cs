#pragma checksum "C:\Users\dk95g\Desktop\DKPortfolio\DKPortfolio\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28cd6dc8cd4914c4dad01cd10ce4b32b45e2260d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\dk95g\Desktop\DKPortfolio\DKPortfolio\Views\_ViewImports.cshtml"
using DKPortfolio;

#line default
#line hidden
#line 2 "C:\Users\dk95g\Desktop\DKPortfolio\DKPortfolio\Views\_ViewImports.cshtml"
using DKPortfolio.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28cd6dc8cd4914c4dad01cd10ce4b32b45e2260d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90752b4e1715927d1a569f36ac5e5dc37ff55745", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/head.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mystyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/navmenu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navigation-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 12153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f70e096bd3504f809d9bb60f398dd9a4", async() => {
                BeginContext(29, 493, true);
                WriteLiteral(@"
    <title>Dilshan Karunanayaka - Freelance Web Developer Portfolio</title>
    <meta name=""description"" content=""Dilshan Karunanayaka is a freelance web developer.This is a portfolio showcasing the projects he has worked on as well as the technical skills he possess."" />
    <meta name=""keywords"" content=""Dilshan Karunanayaka, Freelance Web Developer, Freelancer, Developer, Programmer""/>

    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=899"">   
    <style>
        ");
                EndContext();
                BeginContext(523, 81, true);
                WriteLiteral("@import url(\'https://fonts.googleapis.com/css?family=Archivo\');\n    </style>\n    ");
                EndContext();
                BeginContext(604, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "054a4d44786d449d98a93d6def65b9a7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(646, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(651, 175, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7e50c561a1f4b2cb352118e9c5b8f7c", async() => {
                    BeginContext(686, 12, true);
                    WriteLiteral("   \n        ");
                    EndContext();
                    BeginContext(698, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5c503338d0048f28937d55cec572038", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(748, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(757, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5331114c90640b48d726104fe8cd0d4", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(807, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(826, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(831, 11337, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f6a6d4287d244279052ebd3bb054374", async() => {
                    BeginContext(866, 5486, true);
                    WriteLiteral(@"
        <style>
            .header-content h1,.header-content h2{animation-name:moveInRight;animation-duration:2s}.header,.skills{box-shadow:0 1.5rem 4rem rgba(0,0,0,.8);background-size:cover}.header,.projects,.skills{background-size:cover}*{margin:0;padding:0;box-sizing:border-box;color:#fff;font-family:Archivo,sans-serif}html{scroll-behavior:smooth}body{background-color:#C1C8E4}h1,h2{margin:1rem 0;font-size:2rem}.h4,h4{font-size:1.5rem}.h5,h5{font-size:1.25rem}.h6,h6{font-size:1rem}.width50{width:50%!important}.header{height:95vh;position:relative;background-image:linear-gradient(to right bottom,rgba(136,96,208,.7),rgba(90,185,234,.7)),url(../images/header.jpg);background-position:top}.header-content{position:absolute;top:25%;padding:1rem;word-wrap:break-word;text-align:center}.header-content h1{font-family:""Archivo Black"",sans-serif;font-size:4.5rem}.header-content h2{font-size:2rem;letter-spacing:.1rem}.header-content-body{margin:0 20%;text-align:center;animation-name:moveInLeft;animation-duration:2s}.");
                    WriteLiteral(@"header-content-body p{font-weight:800;font-size:1.2rem!important;margin:1rem 0}.my-container{margin-left:20%;padding:1rem;text-shadow:2px 2px #000}.my-container a{text-shadow:none}.contact-container-bigbox a,.contact-container-littlebox a{color:unset;text-shadow:2px 2px #000}.navigation-panel{background-image:linear-gradient(#84ceeb,#8860d0);width:20%;height:100vh;position:fixed}.my-nav,.my-nav-img{position:absolute;left:50%;transform:translate(-50%,-50%)}.my-nav{margin-top:2rem;top:50%;display:flex;flex-direction:column;font-weight:600}.projects-filter,.skills-body{flex-direction:row;display:flex}.my-nav-img{top:20%;border-radius:50%;border:1px solid #ddd;padding:5px;width:150px;height:150px}.projects-card:hover,.skills-card-img:hover{transform:scale(1.1)}.skills,.skills-header{width:100%;text-align:center;font-family:""Archivo Black"",sans-serif}.skills{height:100%;background-image:linear-gradient(to right bottom,rgba(136,96,208,.7),rgba(90,185,234,.7)),url(../images/skills.jpg)}.skills-card,.skills-card-img{");
                    WriteLiteral(@"box-shadow:inset 0 0 10px #000}.skills-body{justify-content:space-around;flex-wrap:wrap}.skills-card{width:15rem;height:12rem;background-color:red;margin:1rem;position:relative;border-radius:25px;background-image:linear-gradient(to right bottom,#84ceeb,#8860d0)}.skills-card-img{position:absolute;top:10%;left:10%;width:80%;height:80%;border-radius:50%;transition:all .5s}.projects,.projects-img{height:100%;width:100%}.projects{text-align:center}.projects-header{width:100%;text-align:center;font-family:""Archivo Black"",sans-serif}.projects-filter{width:100%;justify-content:center}.projects-body{display:flex;flex-direction:row;justify-content:center;flex-wrap:wrap}.projects-card{width:18rem;height:18rem;margin:1rem;transition:all .5s}.contact,.education{height:100%;background-size:cover;text-align:center;font-family:""Archivo Black"",sans-serif}.education{padding-top:1.5rem}.education-body{padding:2rem}.education-header{width:100%;text-align:center;font-family:""Archivo Black"",sans-serif}.contact{background-image:lin");
                    WriteLiteral(@"ear-gradient(to right bottom,rgba(136,96,208,.7),rgba(90,185,234,.7)),url(../images/contact.jpg);box-shadow:0 1.5rem 4rem rgba(0,0,0,.8);position:relative}.contact-header{position:absolute;top:45%;left:50%;transform:translate(-50%,-50%)}.contact-container{display:grid;grid-template-rows:repeat(2,17rem);grid-template-columns:1fr 1fr;grid-gap:4rem;margin:25px}.contact-container-bigbox-img,.contact-container-littlebox-img{display:block;max-height:50%;max-width:100%;margin:20px auto;animation:spin 8s linear infinite}.mybtn,.mybtn:link,.mybtn:visited{text-transform:uppercase;padding:10px 40px;display:inline-block;margin-bottom:10px;transition:all .2s;text-decoration:none}.clear{clear:both;line-height:0}.mybtn{border-radius:100px;border:0}.mybtn:link,.mybtn:visited{border-radius:100px}.mybtn:hover{transform:translateY(-3px)}.mybtn:active{transform:translateY(3px)}.mybtn-white{background-color:#fff;color:#777}.popup{position:fixed;top:0;left:0;background-color:rgba(0,0,0,.8);height:100vh;width:100%;z-index:1000;opac");
                    WriteLiteral(@"ity:0;visibility:hidden;transition:all .5s}.popup:target{opacity:1;visibility:visible}.popup-content{position:relative;top:50%;left:50%;width:90%;height:90%;background-image:linear-gradient(to right bottom,#84ceeb,#8860d0);transform:translate(-50%,-50%);margin:0;padding:0;display:table;overflow:hidden;border-radius:15px}.popup-content h1{font-size:3rem!important;padding:.5rem 0}.popup-content a{font-size:1.4rem;margin-bottom:2rem}.popup-content p{font-size:1.4rem;margin:1rem 0}.popup-content-left{width:33.3333333%;display:table-cell}.popup-content-right{width:66.6666667%;display:table-cell;height:50%;vertical-align:middle}.popup-content-img{width:33.33333%;display:block;height:60%;position:absolute;top:20%}.popup-close:link,.popup-close:visited{position:absolute;top:-3rem;right:3.5rem;font-size:9rem;text-decoration:none;display:inline-block}.popup-close:hover{color:#8860d0}.linktext,.linktext:hover{text-shadow:2px 2px #000!important;color:#d3d3d3}.linktext{font-family:Archivo,sans-serif}.appdevcheck:checked~.");
                    WriteLiteral(@"appdev,.othercheck:checked~.other,.webdevcheck:checked~.webdev{animation-name:fadeIn;animation-duration:3s}.appdevcheck:checked~.other,.appdevcheck:checked~.webdev,.othercheck:checked~.appdev,.othercheck:checked~.webdev,.webdevcheck:checked~.appdev,.webdevcheck:checked~.other{visibility:hidden;opacity:0;position:fixed}.test{animation:moveUpDown 2s linear infinite}");
                    EndContext();
                    BeginContext(6353, 57, true);
                    WriteLiteral("@keyframes moveUpDown{0%,100%{bottom:0}50%{bottom:200px}}");
                    EndContext();
                    BeginContext(6411, 118, true);
                    WriteLiteral("@-webkit-keyframes spin{from{transform:perspective(400px) rotateY(0)}to{transform:perspective(400px) rotateY(360deg)}}");
                    EndContext();
                    BeginContext(6530, 115, true);
                    WriteLiteral("@-moz-keyframes spin{from{transform:perspective(400px) rotateY(0)}to{transform:perspective(400px) rotateY(360deg)}}");
                    EndContext();
                    BeginContext(6646, 113, true);
                    WriteLiteral("@-o-keyframes spin{from{transform:perspective(400px) rotateY(0)}to{transform:perspective(400px) rotateY(360deg)}}");
                    EndContext();
                    BeginContext(6760, 110, true);
                    WriteLiteral("@keyframes spin{from{transform:perspective(400px) rotateY(0)}to{transform:perspective(400px) rotateY(360deg)}}");
                    EndContext();
                    BeginContext(6871, 47, true);
                    WriteLiteral("@keyframes fadeIn{0%{opacity:0}100%{opacity:1}}");
                    EndContext();
                    BeginContext(6919, 111, true);
                    WriteLiteral("@-webkit-keyframes moveInLeft{0%{opacity:0;transform:translate(-1rem,0)}100%{opacity:1;transform:translate(0)}}");
                    EndContext();
                    BeginContext(7031, 108, true);
                    WriteLiteral("@-moz-keyframes moveInLeft{0%{opacity:0;transform:translate(-1rem,0)}100%{opacity:1;transform:translate(0)}}");
                    EndContext();
                    BeginContext(7140, 106, true);
                    WriteLiteral("@-o-keyframes moveInLeft{0%{opacity:0;transform:translate(-1rem,0)}100%{opacity:1;transform:translate(0)}}");
                    EndContext();
                    BeginContext(7247, 103, true);
                    WriteLiteral("@keyframes moveInLeft{0%{opacity:0;transform:translate(-1rem,0)}100%{opacity:1;transform:translate(0)}}");
                    EndContext();
                    BeginContext(7351, 111, true);
                    WriteLiteral("@-webkit-keyframes moveInRight{0%{opacity:0;transform:translate(1rem,0)}100%{opacity:1;transform:translate(0)}}");
                    EndContext();
                    BeginContext(7463, 108, true);
                    WriteLiteral("@-moz-keyframes moveInRight{0%{opacity:0;transform:translate(1rem,0)}100%{opacity:1;transform:translate(0)}}");
                    EndContext();
                    BeginContext(7572, 106, true);
                    WriteLiteral("@-o-keyframes moveInRight{0%{opacity:0;transform:translate(1rem,0)}100%{opacity:1;transform:translate(0)}}");
                    EndContext();
                    BeginContext(7679, 103, true);
                    WriteLiteral("@keyframes moveInRight{0%{opacity:0;transform:translate(1rem,0)}100%{opacity:1;transform:translate(0)}}");
                    EndContext();
                    BeginContext(7783, 4125, true);
                    WriteLiteral(@"@media (max-width:900px){.my-container,.mybtn{margin:0}*{font-size:1.1rem}.mybtn{font-size:1.5rem;width:25%;padding:0}.navigation-panel{display:none}.popup-content-left{display:none;width:unset!important}.popup-content-right{width:100%!important;font-size:30px!important}.header{height:100%!important}.header-content{position:unset!important}.time-container{position:unset!important;width:100%!important}.left::before,.right::before,.time-container::after,.timeline::after{display:none}}.timeline{position:relative;max-width:1200px;margin:0 auto}.time-container::after,.timeline::after{content:'';position:absolute}.timeline::after{width:6px;background-color:#fff;top:0;bottom:0;left:50%;margin-left:-3px}.time-container{padding:10px 40px;position:relative;background-color:inherit;width:50%}.time-container::after{width:25px;height:25px;right:-17px;background-color:#fff;border:4px solid #FF9F55;top:15px;border-radius:50%;z-index:1}.left::before,.right::before{content:"" "";height:0;position:absolute;top:22px;width:0;z-ind");
                    WriteLiteral(@"ex:1}.left{left:-4px}.right{left:50%}.left::before{right:30px;border:solid #fff;border-width:10px 0 10px 10px;border-color:transparent transparent transparent #fff}.right::before{left:30px;border:solid #fff;border-width:10px 10px 10px 0;border-color:transparent #fff transparent transparent}.article,.content{position:relative;box-shadow:inset 0 0 10px #000}.right::after{left:-12px}.content{padding:20px 30px;background-color:#fff;border-radius:6px;background-image:linear-gradient(to right bottom,rgba(132,206,235,.8),rgba(136,96,208,.7))}.article{border-radius:25px;background-image:linear-gradient(to right bottom,#84ceeb,#8860d0);width:75%;padding:2rem 0;margin:2rem auto 0;word-break:break-all}.article p{padding:1rem}.article-title{margin:0;padding:0}.article:link,.article:visited{transition:all .2s}.article:hover{transform:translateY(-3px)}.article:active{transform:translateY(3px)}.clearstyle{all:unset}        </style>
        <style>
            .navigation-checkbox{display:none}.navigation-button{background-i");
                    WriteLiteral(@"mage:radial-gradient(#B7F8DB ,#50A7C2);height:7rem;width:7rem;position:fixed;top:2rem;right:1rem;border-radius:50%;z-index:2000;box-shadow:0 1rem 3rem rgba(1,1,1,.1);text-align:center;cursor:pointer}.navigation-background{height:6rem;width:6rem;border-radius:50%;position:fixed;top:2.5rem;right:1.5rem;background-image:radial-gradient(#ffb900,#ff7730);z-index:1000;transition:transform 1s cubic-bezier(.86,0,.07,1)}.navigation-nav{height:100vh;width:0;position:fixed;top:0;left:0;z-index:1500;opacity:0;transition:all .9s cubic-bezier(.86,0,.07,1);pointer-events:none}.navigation-checkbox:checked~.navigation-background+.navigation-nav{pointer-events:auto}.navigation-list{position:absolute;top:50%;left:50%;transform:translate(-50%,-50%);list-style:none;text-align:center;width:100%}.navigation-item{margin:1rem}.navigation-link:link,.navigation-link:visited{font-size:1.5rem;font-weight:300;color:#fff;padding:1rem 2rem;text-decoration:none;text-transform:uppercase;background-image:linear-gradient(120deg,transparent 0,tr");
                    WriteLiteral(@"ansparent 50%,#fff 50%);background-size:240%;transition:all .4s;display:inline}.navigation-link:hover{background-position:100%;color:#000}.navigation-checkbox:checked~.navigation-background{transform:scale(80)}.navigation-checkbox:checked~.navigation-nav{opacity:1;width:100%}.navigation-icon{width:3rem;height:2px;background-color:#000;display:inline-block;position:relative;margin-top:3.5rem}.navigation-icon::after,.navigation-icon::before{width:3rem;height:2px;background-color:#000;display:inline-block;content:"""";position:absolute;left:0}.navigation-icon::before{top:-.8rem}.navigation-icon::after{top:.8rem;transition:all .2s}.navigation-button:hover .navigation-icon::before{top:-1rem}.navigation-button:hover .navigation-icon::after{top:1rem}.navigation-checkbox:checked+.navigation-button .navigation-icon{background-color:transparent}.navigation-checkbox:checked+.navigation-button .navigation-icon::before{top:0;transform:rotate(135deg)}.navigation-checkbox:checked+.navigation-button .navigation-icon::after{top");
                    WriteLiteral(":0;transform:rotate(-135deg)}");
                    EndContext();
                    BeginContext(11909, 245, true);
                    WriteLiteral("@media(max-width:900px){.navigation-button{height:3.5rem;width:3.5rem}.navigation-background{height:2rem;width:2rem}.navigation-icon{width:2rem;margin-top:1.7rem}.navigation-icon::after,.navigation-icon::before{width:2rem}}\n        </style>\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12168, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12176, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(12177, 2802, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb0e767b76a64e8880645232a90b0818", async() => {
                BeginContext(12183, 496, true);
                WriteLiteral(@"
    <div>
        <input type=""checkbox"" class=""navigation-checkbox"" id=""nav-toggle"" />
        <label for=""nav-toggle"" class=""navigation-button""><span class=""navigation-icon"">&nbsp;</span></label>

        <div class=""navigation-background"">
            &nbsp;
        </div>
        <nav class=""navigation-nav"">
            <ul class=""navigation-list"">
                <li class=""navigation-item""><a class=""navigation-link"" href=""/"">Home</a></li>
                <li class=""navigation-item"">");
                EndContext();
                BeginContext(12679, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df780b98c0614185a5a1b82cefd29635", async() => {
                    BeginContext(12751, 4, true);
                    WriteLiteral("Blog");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12759, 55, true);
                WriteLiteral("</li>\r\n            </ul>\n        </nav>\n    </div>\n    ");
                EndContext();
                BeginContext(12815, 12, false);
#line 41 "C:\Users\dk95g\Desktop\DKPortfolio\DKPortfolio\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(12827, 2102, true);
                WriteLiteral(@"

    <script>
        if (window.innerWidth > 900) {
            var ifrm = document.createElement('iframe');
            ifrm.setAttribute('id', 'ifrm'); // assign an id

            // assign url
            ifrm.setAttribute('src', 'https://www.youtube.com/embed/scL-RmUg_70');
            document.getElementById(""galactic-vid"").appendChild(ifrm);
            document.getElementById(""ifrm"").classList.add(""popup-content-img"");

            var ifrm2 = document.createElement('iframe');
            ifrm2.setAttribute('id', 'ifrm2'); // assign an id

            // assign url
            ifrm2.setAttribute('src', 'https://www.youtube.com/embed/CrHX8cJrdDI');
            document.getElementById(""cvgs-vid"").appendChild(ifrm2);
            document.getElementById(""ifrm2"").classList.add(""popup-content-img"");
            document.getElementById(""ifrm2"").classList.add(""width50"");
        }

        document.getElementById(""allprojs"").addEventListener(""click"", function () {
            document.getElementById(""webdev");
                WriteLiteral(@"check"").checked = false;
            document.getElementById(""appdevcheck"").checked = false;
            document.getElementById(""othercheck"").checked = false;
        });
        document.getElementById(""webdev"").addEventListener(""click"", function () {
            document.getElementById(""webdevcheck"").checked = true;
            document.getElementById(""appdevcheck"").checked = false;
            document.getElementById(""othercheck"").checked = false;
        });
        document.getElementById(""appdev"").addEventListener(""click"", function () {
            document.getElementById(""webdevcheck"").checked = false;
            document.getElementById(""appdevcheck"").checked = true;
            document.getElementById(""othercheck"").checked = false;
        });
        document.getElementById(""other"").addEventListener(""click"", function () {
            document.getElementById(""webdevcheck"").checked = false;
            document.getElementById(""appdevcheck"").checked = false;
            document.getElementById(""otherc");
                WriteLiteral("heck\").checked = true;\n        });\n    </script>\n\n    ");
                EndContext();
                BeginContext(14930, 41, false);
#line 85 "C:\Users\dk95g\Desktop\DKPortfolio\DKPortfolio\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(14971, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14979, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
