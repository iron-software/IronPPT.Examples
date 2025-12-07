using IronPPT;
using IronPPT.Models;

// Create new PowerPoint presentation
var document = new PresentationDocument();

// Style paragraph
var style = new ParagraphStyle()
{
    NoBullet = true,
    RightToLeft = true,
    ContextualSpacing = true,
    Indent = 15.00,
    Alignment = TextAlignmentTypeValues.Center,
    LineSpacing = 10,
    SpaceAfter = 15,
    SpaceBefore = 15,
};

var paragraph = new Paragraph();
paragraph.Style = style;
paragraph.AddText("First paragraph.");

// Add paragraph
document.Slides[0].AddParagraph(paragraph);

// Export PowerPoint presentation
document.Save("styledParagraph.pptx");