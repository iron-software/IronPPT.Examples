using IronPPT;
using IronPPT.Models;
using IronPPT.Models.Styles;

// Create new PowerPoint presentation
var document = new PresentationDocument();

// Import image
Image image = new Image();
image.LoadFromFile("sample.png");

// Style the bullet point
var style = new ParagraphStyle()
{
    Bullet = new Bullet()
    {
        Picture = image,
        //BulletColor = Color.Blue,
        //FollowsDefaultTextSize = true
    },
};

var paragraph = new Paragraph();
paragraph.Style = style;
paragraph.AddText("Test Text");

document.Slides[0].AddParagraph(paragraph);

// Export PowerPoint presentation
document.Save("styledBullet.pptx");