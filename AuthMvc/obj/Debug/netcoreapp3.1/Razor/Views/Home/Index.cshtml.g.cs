#pragma checksum "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d2f5f6eea148bb44cfdfdf948d23227e87523e"
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
#line 1 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\_ViewImports.cshtml"
using AuthMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\_ViewImports.cshtml"
using AuthMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d2f5f6eea148bb44cfdfdf948d23227e87523e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08fb7e97ec638d34771ce52da483c4e9a7a01546", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AuthMvc.Models.Chambre>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("book-now-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div id=""myCarousel1"" class=""carousel slide"" data-ride=""carousel"">
    <!-- Indicators -->

    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel1"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel1"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel1"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
        <div class=""item active"">
            <img src=""images/banner.png"" style=""width:100%; height: 500px"" alt=""First slide"">
            <div class=""carousel-caption"">
                <h1>vacayhome<br> spa & Resort</h1>
            </div>
        </div>
        <div class=""item"">
            <img src=""images/banner2.png"" style=""width:100%; height: 500px"" alt=""Second slide"">
            <div class=""carousel-caption"">
                <h1>vacayhome<br> spa & Resort</h1>
            </div>
        </div>
        <div class=""item"">
            <img src=""images/banner3.png"" style=""width:100%; height: 500px"" alt=""Third sli");
            WriteLiteral(@"de"">
            <div class=""carousel-caption"">
                <h1>vacayhome<br> spa & Resort</h1>
            </div>
        </div>

    </div>
    <a class=""left carousel-control"" href=""#myCarousel1"" data-slide=""prev""> <img src=""images/icons/left-arrow.png"" onmouseover=""this.src = 'images/icons/left-arrow-hover.png'"" onmouseout=""this.src = 'images/icons/left-arrow.png'"" alt=""left""></a>
    <a class=""right carousel-control"" href=""#myCarousel1"" data-slide=""next""><img src=""images/icons/right-arrow.png"" onmouseover=""this.src = 'images/icons/right-arrow-hover.png'"" onmouseout=""this.src = 'images/icons/right-arrow.png'"" alt=""left""></a>

</div>
<div class=""clearfix""></div>

<!--service block--->
<section class=""service-block"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3 col-sm-3 col-xs-6 width-50"">
                <div class=""service-details text-center"">
                    <div class=""service-image"">
                        <img alt=""image"" class=""i");
            WriteLiteral(@"mg-responsive"" src=""images/icons/wifi.png"">
                    </div>
                    <h4><a>free wifi</a></h4>
                </div>
            </div>
            <div class=""col-md-3 col-sm-3 col-xs-6 width-50"">
                <div class=""service-details text-center"">
                    <div class=""service-image"">
                        <img alt=""image"" class=""img-responsive"" src=""images/icons/key.png"">
                    </div>
                    <h4><a>room service</a></h4>
                </div>
            </div>
            <div class=""col-md-3 col-sm-3 col-xs-6 mt-25"">
                <div class=""service-details text-center"">
                    <div class=""service-image"">
                        <img alt=""image"" class=""img-responsive"" src=""images/icons/car.png"">
                    </div>
                    <h4><a>free parking</a></h4>
                </div>
            </div>
            <div class=""col-md-3 col-sm-3 col-xs-6 mt-25"">
                <div class=""ser");
            WriteLiteral(@"vice-details text-center"">
                    <div class=""service-image"">
                        <img alt=""image"" class=""img-responsive"" src=""images/icons/user.png"">
                    </div>
                    <h4><a>customer support</a></h4>
                </div>
            </div>
        </div>
    </div>
</section>

<!--gallery block--->
<section class=""gallery-block gallery-front"">
    <div class=""container"">
        <div class=""row"">
  

");
#nullable restore
#line 83 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Home\Index.cshtml"
             foreach (var room in Model)
            {
               

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""details"">
                        <div class=""container"">
                        <div class=""row"">

                            <!-- Details Image -->
                            <div class=""col-xl-7 col-lg-6"">
                                <div class=""details_image"">
                                    <div class=""background_image""");
            BeginWriteAttribute("style", " style=\"", 4037, "\"", 4085, 3);
            WriteAttributeValue("", 4045, "background-image:url(images/", 4045, 28, true);
#nullable restore
#line 93 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 4073, room.Image, 4073, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4084, ")", 4084, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                </div>
                            </div>

                            <!-- Details Content -->
                            <div class=""col-xl-5 col-lg-6"">
                                <div class=""details_content"">
                                    <div class=""details_title"">
                                        <div>
                                            <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d2f5f6eea148bb44cfdfdf948d23227e87523e9757", async() => {
#nullable restore
#line 102 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Home\Index.cshtml"
                                                                                                                           Write(room.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Home\Index.cshtml"
                                                                                                   WriteLiteral(room.IdChambre);

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
            WriteLiteral(@"</h2>
                                        </div>
                                    </div>
                                    <div class=""details_list"">
                                        <ul>
                                            <li>");
#nullable restore
#line 107 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Home\Index.cshtml"
                                           Write(room.Surface);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" m² Patio</li>
                                            <li>Balcony with view</li>
                                            <li>Garden / Mountain view</li>
                                            <li>Flat-screen TV</li>
                                            <li>Air conditioning</li>
                                            <li>Soundproofing</li>
                                            <li>Private bathroom</li>
                                            <li>Free WiFi</li>
                                        </ul>
                                    </div>
                                    <div class=""details_long_list"">
                                        <p>
                                            ");
#nullable restore
#line 119 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Home\Index.cshtml"
                                       Write(room.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    </div>
");
#nullable restore
#line 128 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Home\Index.cshtml"
           

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</section>

<!--offer block-->
<section class=""vacation-offer-block"">
    <div class=""vacation-offer-bgbanner"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-5 col-sm-6 col-xs-12"">
                    <div class=""vacation-offer-details"">
                        <h1>Your vacation Awaits</h1>
                        <h4>Lorem ipsum dolor sit amet, conse ctetuer adipiscing elit.</h4>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d2f5f6eea148bb44cfdfdf948d23227e87523e14767", async() => {
                WriteLiteral("Choose a package");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--End-->
<!----resort-overview--->
<section class=""resort-overview-block"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-12 col-xs-12 remove-padd-right"">
                <div class=""side-A"">
                    <div class=""product-thumb"">
                        <div class=""image"">
                            <a><img src=""images/category1.png"" class=""img-responsive"" alt=""image""></a>
                        </div>
                    </div>
                </div>
                <div class=""side-B"">
                    <div class=""product-desc-side"">
                        <h3><a>luxury spa</a></h3>
                        <p>Lorem ipsum dolor sit amet, consec adipiscing elit. Nunc lorem nulla, ornare eu felis luctus non maximus vitae, portt neque. ipsum dolor sit amet, consec adipiscing elit.</p>
                        <div class");
            WriteLiteral(@"=""links""><a href=""single-blog.html"">Read more</a></div>
                    </div>
                </div>
            </div>
            <div class=""clear""></div>
            <div class=""col-md-6 col-sm-12 col-xs-12 remove-padd-left"">
                <div class=""side-A"">
                    <div class=""product-thumb"">
                        <div class=""image"">
                            <a><img alt=""image"" class=""img-responsive"" src=""images/category2.png""></a>
                        </div>
                    </div>
                </div>
                <div class=""side-B"">
                    <div class=""product-desc-side"">
                        <h3><a>Beatusish ingl</a></h3>
                        <p>Lorem ipsum dolor sit amet, consec adipiscing elit. Nunc lorem nulla, ornare eu felis luctus non maximus vitae, portt neque. ipsum dolor sit amet, consec adipiscing elit.</p>
                        <div class=""links""><a href=""single-blog.html"">Read more</a></div>
                    </");
            WriteLiteral(@"div>
                </div>
            </div>
            <div class=""clear""></div>
            <div class=""col-md-6 col-sm-12 col-xs-12 remove-padd-right"">
                <div class=""side-A"">
                    <div class=""product-desc-side"">
                        <h3><a>luxury room</a></h3>
                        <p>Lorem ipsum dolor sit amet, consec adipiscing elit. Nunc lorem nulla, ornare eu felis luctus non maximus vitae, portt neque. ipsum dolor sit amet, consec adipiscing elit.</p>
                        <div class=""links""><a href=""single-blog.html"">Read more</a></div>
                    </div>
                </div>

                <div class=""side-B"">
                    <div class=""product-thumb"">
                        <div class=""image txt-rgt"">
                            <a class=""arrow-left""><img src=""images/category3.png"" class=""img-responsive"" alt=""imaga""></a>
                        </div>
                    </div>
                </div>
            </div>
  ");
            WriteLiteral(@"          <div class=""clear""></div>
            <div class=""col-md-6 col-sm-12 col-xs-12 remove-padd-left"">
                <div class=""side-A"">
                    <div class=""product-desc-side"">
                        <h3><a>heaven seanery</a></h3>
                        <p>Lorem ipsum dolor sit amet, consec adipiscing elit. Nunc lorem nulla, ornare eu felis luctus non maximus vitae, portt neque. ipsum dolor sit amet, consec adipiscing elit.</p>
                        <div class=""links""><a href=""single-blog.html"">Read more</a></div>
                    </div>
                </div>

                <div class=""side-B"">
                    <div class=""product-thumb txt-rgt"">
                        <div class=""image"">
                            <a class=""arrow-left""><img src=""images/category4.png"" class=""img-responsive"" alt=""imaga""></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""clearfix""></div>

        ");
            WriteLiteral(@"</div>
    </div>
</section>

<!-----blog slider----->
<!--blog trainer block-->
<section class=""blog-block-slider"">
    <div class=""blog-block-slider-fix-image"">
        <div id=""myCarousel2"" class=""carousel slide"" data-ride=""carousel"">
            <div class=""container"">
                <!-- Wrapper for slides -->
                <ol class=""carousel-indicators"">
                    <li data-target=""#myCarousel2"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#myCarousel2"" data-slide-to=""1""></li>
                    <li data-target=""#myCarousel2"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"" role=""listbox"">
                    <div class=""item active"">
                        <div class=""blog-box"">
                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley o");
            WriteLiteral(@"f type and scrambled it to make a type specimen book. It has survived not only</p>
                        </div>
                        <div class=""blog-view-box"">
                            <div class=""media"">
                                <div class=""media-left"">
                                    <img src=""images/client1.png"" class=""media-object"">
                                </div>
                                <div class=""media-body"">
                                    <h3 class=""media-heading blog-title"">Walter Hucko</h3>
                                    <h5 class=""blog-rev"">Satisfied Customer</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""blog-box"">
                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text e");
            WriteLiteral(@"ver since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only</p>
                        </div>
                        <div class=""blog-view-box"">
                            <div class=""media"">
                                <div class=""media-left"">
                                    <img src=""images/client2.png"" class=""media-object"">
                                </div>
                                <div class=""media-body"">
                                    <h3 class=""media-heading blog-title"">Jules Boutin</h3>
                                    <h5 class=""blog-rev"">Satisfied Customer</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""blog-box"">
                            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industr");
            WriteLiteral(@"y. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only</p>
                        </div>
                        <div class=""blog-view-box"">
                            <div class=""media"">
                                <div class=""media-left"">
                                    <img src=""images/client3.png"" class=""media-object"">
                                </div>
                                <div class=""media-body"">
                                    <h3 class=""media-heading blog-title"">Attilio Marzi</h3>
                                    <h5 class=""blog-rev"">Satisfied Customer</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""clearfix""></div>
</section>

<!---blog ");
            WriteLiteral(@"block--->
<section class=""blog-block"">
    <div class=""container"">
        <div class=""row offspace-45"">
            <div class=""view-set-block"">
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    <div class=""event-blog-image"">
                        <img alt=""image"" class=""img-responsive"" src=""images/blog1.png"">
                    </div>
                </div>
                <div class=""col-md-6 col-sm-6 col-xs-12 side-in-image"">
                    <div class=""event-blog-details"">
                        <h4><a href=""single-blog.html"">Lorem ipsum dolor sit amet</a></h4>
                        <h5>Post By Admin <a><i aria-hidden=""true"" class=""fa fa-heart-o fa-lg""></i>Likes</a><a><i aria-hidden=""true"" class=""fa fa-comment-o fa-lg""></i>comments</a></h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc lorem nulla, ornare eu felis quis, efficitur posuere nulla. Aliquam ac luctus turpis, non faucibus sem. Fusce ornare turpis neq");
            WriteLiteral(@"ue, eu commodo sapien porta sed. Nam ut ante turpis. Nam arcu odio, scelerisque a vehicula vitae, auctor sit amet lectus. </p>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc lorem nulla, ornare eu felis quis, efficitur posuere nulla. Aliquam ac luctus turpis, non faucibus sem. Fusce ornard hendrerit tortor vulputate id. Vestibulum mauris nibh, luctus non maximus vitae, porttitor eget neque. Donec tristique nunc facilisis, dapibus libero ac</p>
                        <a class=""btn btn-default"" href=""single-blog.html"">Read More</a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row offspace-45"">
            <div class=""view-set-block"">
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    <div class=""event-blog-image"">
                        <img alt=""image"" class=""img-responsive"" src=""images/blog2.png"">
                    </div>
                </div>
                <div ");
            WriteLiteral(@"class=""col-md-6 col-sm-6 col-xs-12 side-in-image"">
                    <div class=""event-blog-details"">
                        <h4><a href=""single-blog.html"">Lorem ipsum dolor sit amet</a></h4>
                        <h5>Post By Admin <a><i aria-hidden=""true"" class=""fa fa-heart-o fa-lg""></i>Likes</a><a><i aria-hidden=""true"" class=""fa fa-comment-o fa-lg""></i>comments</a></h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc lorem nulla, ornare eu felis quis, efficitur posuere nulla. Aliquam ac luctus turpis, non faucibus sem. Fusce ornare turpis neque, eu commodo sapien porta sed. Nam ut ante turpis. Nam arcu odio, scelerisque a vehicula vitae, auctor sit amet lectus. </p>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc lorem nulla, ornare eu felis quis, efficitur posuere nulla. Aliquam ac luctus turpis, non faucibus sem. Fusce ornard hendrerit tortor vulputate id. Vestibulum mauris nibh, luctus non maximus vitae, porttitor");
            WriteLiteral(@" eget neque. Donec tristique nunc facilisis, dapibus libero ac</p>
                        <a class=""btn btn-default"" href=""single-blog.html"">Read More</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AuthMvc.Models.Chambre>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591