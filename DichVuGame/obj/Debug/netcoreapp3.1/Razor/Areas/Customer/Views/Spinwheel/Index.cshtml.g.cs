#pragma checksum "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e052ef3ec9f19304dda910126793560f9559c46b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Spinwheel_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Spinwheel/Index.cshtml")]
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
#line 1 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\_ViewImports.cshtml"
using DichVuGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\_ViewImports.cshtml"
using DichVuGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e052ef3ec9f19304dda910126793560f9559c46b", @"/Areas/Customer/Views/Spinwheel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"204fd248a0bee97b8bade4baa1b5f81207cd69f5", @"/Areas/Customer/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Spinwheel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DichVuGame.Models.ViewModels.SpinwheelViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reward", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rewardForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
  
    ViewData["Title"] = "SpinWheel";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e052ef3ec9f19304dda910126793560f9559c46b6047", async() => {
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\" href=\"\\spinwheel\\default.css\" type=\"text/css\" />\r\n    <script type=\"text/javascript\" src=\"\\spinwheel\\Winwheel.js\"></script>\r\n    <script type=\"text/javascript\" src=\"\\spinwheel\\TweenMax.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e052ef3ec9f19304dda910126793560f9559c46b6570", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e052ef3ec9f19304dda910126793560f9559c46b8373", async() => {
                WriteLiteral("\r\n    <div align=\"center\">\r\n        <h1>Vòng quay may mắn</h1>\r\n        <p>\r\n            Quà tặng hấp dẫn, trúng thưởng 100%\r\n        </p>\r\n        <p>\r\n            Giá: 50000 xu/lượt\r\n        </p>\r\n        <div class=\"text-danger\">");
#nullable restore
#line 23 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                            Write(Html.ValidationMessage("OutOfBalance"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
        <br />
        <div class=""modal fade"" id=""prizeModal"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h4 class=""modal-title"">Chúc mừng bạn đã trúng thưởng</h4>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                        </div>
                        <div class=""modal-body"">
                            <div class=""form-group"">
");
#nullable restore
#line 34 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                 if (Model.Coin > 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <label>Số coin: ");
#nullable restore
#line 36 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                               Write(Model.Coin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                    <input id=\"coin\" value=\"0\" hidden />\r\n");
#nullable restore
#line 38 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                 if (Model.Discount != null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div>Mã giảm giá: ");
#nullable restore
#line 41 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                                 Write(Model.Discount.Code);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    <div>Có giá trị giảm: ");
#nullable restore
#line 42 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                                     Write(Model.Discount.DiscountValue);

#line default
#line hidden
#nullable disable
                WriteLiteral(" %</div>\r\n                                    <input id=\"coin\" value=\"0\" hidden />\r\n");
#nullable restore
#line 44 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                 if (Model.Code != null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div>Tựa game: <span>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e052ef3ec9f19304dda910126793560f9559c46b12287", async() => {
#nullable restore
#line 47 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                                                                                                                    Write(Model.Code.Game.Gamename);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                                                                                         WriteLiteral(Model.Code.GameID);

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
                WriteLiteral("</span></div>\r\n                                    <div>Mã game: ");
#nullable restore
#line 48 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                             Write(Model.Code.Gamecode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    <input id=\"coin\" value=\"0\" hidden />\r\n");
#nullable restore
#line 50 "C:\Users\Thanh\Desktop\Webgame\DichVuGame\Areas\Customer\Views\Spinwheel\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Xác nhận"">
                        </div>
                </div>
            </div>
        </div>
        <br />
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e052ef3ec9f19304dda910126793560f9559c46b16143", async() => {
                    WriteLiteral(@"
            <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                <tr>
                    <td>
                        <div class=""power_controls"">
                            <br />
                            <br />
                            <table class=""power"" cellpadding=""10"" cellspacing=""0"">
                                <tr>
                                    <th align=""center"">Power</th>
                                </tr>
                                <tr>
                                    <td width=""78"" align=""center"" id=""pw3"" onClick=""powerSelected(3);"">High</td>
                                </tr>
                                <tr>
                                    <td align=""center"" id=""pw2"" onClick=""powerSelected(2);"">Med</td>
                                </tr>
                                <tr>
                                    <td align=""center"" id=""pw1"" onClick=""powerSelected(1);"">Low</td>
                                </tr>
       ");
                    WriteLiteral(@"                     </table>
                            <br />
                            <img id=""spin_button"" src=""\spinwheel\spin_off.png"" alt=""Spin"" onClick=""startSpin();"" />
                            <br /><br />
                            &nbsp;&nbsp;<a href=""#"" onClick=""resetWheel(); return false;"">Play Again</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(reset)
                        </div>
                    </td>
                    <td width=""438"" height=""582"" class=""the_wheel"" align=""center"" valign=""center"">
                        <canvas id=""canvas"" width=""434"" height=""434"">
                            <p style=""{color: white}"" align=""center"">Sorry, your browser doesn't support canvas. Please try another.</p>
                        </canvas>
                    </td>
                </tr>
            </table>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>
    <script>
        // Create new wheel object specifying the parameters at creation time.
        let theWheel = new Winwheel({
            'numSegments': 8,     // Specify number of segments.
            'outerRadius': 212,   // Set outer radius so wheel fits inside the background.
            'textFontSize': 28,    // Set font size as desired.
            'segments':        // Define segments including colour and text.
                [
                    { 'fillStyle': '#eae56f', 'text': '?' },
                    { 'fillStyle': '#89f26e', 'text': '?' },
                    { 'fillStyle': '#7de6ef', 'text': '?' },
                    { 'fillStyle': '#e7706f', 'text': '?' },
                    { 'fillStyle': '#eae56f', 'text': '?' },
                    { 'fillStyle': '#89f26e', 'text': '?' },
                    { 'fillStyle': '#7de6ef', 'text': '?' },
                    { 'fillStyle': '#e7706f', 'text': '?' }
                ],
            'animation':           // Spec");
                WriteLiteral(@"ify the animation to use.
            {
                'type': 'spinToStop',
                'duration': 15,
                'spins': 8,
                'callbackFinished': alertPrize,
                'callbackSound': playSound,   // Function to call when the tick sound is to be triggered.
                'soundTrigger': 'pin'        // Specify pins are to trigger the sound, the other option is 'segment'.
            },
            'pins':
            {
                'number': 16   // Number of pins. They space evenly around the wheel.
            }
        });

        // -----------------------------------------------------------------
        // This function is called when the segment under the prize pointer changes
        // we can play a small tick sound here like you would expect on real prizewheels.
        // -----------------------------------------------------------------
        let audio = new Audio('tick.mp3');  // Create audio object and load tick.mp3 file.

        fun");
                WriteLiteral(@"ction playSound() {
            // Stop and rewind the sound if it already happens to be playing.
            audio.pause();
            audio.currentTime = 0;

            // Play the sound.
            audio.play();
        }

        // -------------------------------------------------------
        // Called when the spin animation has finished by the callback feature of the wheel because I specified callback in the parameters
        // note the indicated segment is passed in as a parmeter as 99% of the time you will want to know this to inform the user of their prize.
        // -------------------------------------------------------
        // Phần này là bắt event kết quả
        function alertPrize(indicatedSegment) {
            // Do basic alert of the segment text.
            // You would probably want to do something more interesting with this information.
            document.getElementById(""rewardForm"").submit();
        }

        // =======================================");
                WriteLiteral(@"================================================================================
        // Code below for the power controls etc which is entirely optional. You can spin the wheel simply by
        // calling theWheel.startAnimation();
        // =======================================================================================================================
        let wheelPower = 0;
        let wheelSpinning = false;

        // -------------------------------------------------------
        // Function to handle the onClick on the power buttons.
        // -------------------------------------------------------
        function powerSelected(powerLevel) {
            // Ensure that power can't be changed while wheel is spinning.
            if (wheelSpinning == false) {
                // Reset all to grey incase this is not the first time the user has selected the power.
                document.getElementById('pw1').className = """";
                document.getElementById('pw2').cla");
                WriteLiteral(@"ssName = """";
                document.getElementById('pw3').className = """";

                // Now light up all cells below-and-including the one selected by changing the class.
                if (powerLevel >= 1) {
                    document.getElementById('pw1').className = ""pw1"";
                }

                if (powerLevel >= 2) {
                    document.getElementById('pw2').className = ""pw2"";
                }

                if (powerLevel >= 3) {
                    document.getElementById('pw3').className = ""pw3"";
                }

                // Set wheelPower var used when spin button is clicked.
                wheelPower = powerLevel;

                // Light up the spin button by changing it's source image and adding a clickable class to it.
                document.getElementById('spin_button').src = ""\\spinwheel\\spin_on.png"";
                document.getElementById('spin_button').className = ""clickable"";
            }
        }

        // -------");
                WriteLiteral(@"------------------------------------------------
        // Click handler for spin button.
        // -------------------------------------------------------
        function startSpin() {
            // Ensure that spinning can't be clicked again while already running.
            if (wheelSpinning == false) {
                // Based on the power level selected adjust the number of spins for the wheel, the more times is has
                // to rotate with the duration of the animation the quicker the wheel spins.
                if (wheelPower == 1) {
                    theWheel.animation.spins = 3;
                } else if (wheelPower == 2) {
                    theWheel.animation.spins = 8;
                } else if (wheelPower == 3) {
                    theWheel.animation.spins = 15;
                }

                // Disable the spin button so can't click again while wheel is spinning.
                document.getElementById('spin_button').src = ""\\spinwheel\\spin_off.png"";
   ");
                WriteLiteral(@"             document.getElementById('spin_button').className = """";

                // Begin the spin animation by calling startAnimation on the wheel object.
                theWheel.startAnimation();

                // Set to true so that power can't be changed and spin button re-enabled during
                // the current animation. The user will have to reset before spinning again.
                wheelSpinning = true;
            }
        }

        // -------------------------------------------------------
        // Function for reset button.
        // -------------------------------------------------------
        function resetWheel() {
            theWheel.stopAnimation(false);  // Stop the animation, false as param so does not call callback function.
            theWheel.rotationAngle = 0;     // Re-set the wheel angle to 0 degrees.
            theWheel.draw();                // Call draw to render changes to the wheel.

            document.getElementById('pw1').className ");
                WriteLiteral(@"= """";  // Remove all colours from the power level indicators.
            document.getElementById('pw2').className = """";
            document.getElementById('pw3').className = """";

            wheelSpinning = false;          // Reset to false to power buttons and spin can be clicked again.
        }


    </script>
    <script type=""text/javascript"">
        $(window).on('load', function () {
            var coin = this.document.getElementById(""coin"").value;
            this.console.log(coin);
            if (coin != '') {
                $('#prizeModal').modal('show');
            }
        });
    </script>
");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DichVuGame.Models.ViewModels.SpinwheelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
