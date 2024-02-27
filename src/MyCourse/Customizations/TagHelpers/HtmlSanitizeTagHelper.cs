using Ganss.Xss;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace MyCourse.Customizations.TagHelpers
{
    [HtmlTargetElement(Attributes = "html-sanitize")]
    public class HtmlSanitizeTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //ottengo il contenuto del Tag
            TagHelperContent tagHelperContent = await output.GetChildContentAsync(NullHtmlEncoder.Default);
            string content = tagHelperContent.GetContent(NullHtmlEncoder.Default);

            var sanitizer = new HtmlSanitizer();
            content = sanitizer.Sanitize(content);

            //remimposto il contenuto del Tag
            output.Content.SetHtmlContent(content);

        }
    }
}
