using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelpers.TagHelpers
{
    [HtmlTargetElement("speaker-track")]
    public class SpeakerTrack : TagHelper
    {
        public string? TrackName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            string preContent = $@"
                <h2>{TrackName}</h2>
                <div class='row'>
            ";

            string postContent = $@"
                </div>
            ";

            output.TagName = "div";
            output.Attributes.SetAttribute("class", "track");
            output.PreContent.SetHtmlContent(preContent);
            output.PostContent.SetHtmlContent(postContent);

        }
    }
}
