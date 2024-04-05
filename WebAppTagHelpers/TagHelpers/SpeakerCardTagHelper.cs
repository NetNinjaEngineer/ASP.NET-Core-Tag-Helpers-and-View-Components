using Microsoft.AspNetCore.Razor.TagHelpers;
using WebAppTagHelpers.Models;

namespace WebAppTagHelpers.TagHelpers
{
    [HtmlTargetElement(ParentTag = "speaker-track")]
    public class SpeakerCardTagHelper : TagHelper
    {
        public Speaker Speaker { get; set; } = null!;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            string content = $@"
                <div class='card mb-3' style='max-width: 18rem;'>
                        <img src='{Speaker.ImageUrl}' class='card-img-top' alt='Speaker 1'>
                    <div class='card-body'>
                        <h5 class='card-title'>{string.Concat(Speaker.FirstName, ' ', Speaker.LastName)}</h5>
                        <p class='card-text'>{Speaker.TrackName}, {Speaker.Company}</p>
                        <a href='#' class='btn btn-primary'>View Profile</a>
                    </div>
                </div>
            ";


            output.TagName = "div";
            output.Content.SetHtmlContent(content);

        }
    }
}
