using IronPPT;
using IronPPT.Models;

// Create new PowerPoint presentation
var document = new PresentationDocument();

// Add text to paragraph
var paragraph = new Paragraph();
paragraph.AddText("First paragraph.");

// Add paragraph
document.Slides[0].AddParagraph(paragraph);

// Export PowerPoint presentation
document.Save("addParagraph.pptx");