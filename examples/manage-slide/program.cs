using IronPPT;
using IronPPT.Models;

var document = new PresentationDocument();

document.AddSlide();
document.AddSlide();

// Remove slide
document.Slides[0].Remove();

// Move slide by changing the Index property.
document.Slides[0].Index = 1;

// Hide slide
document.Slides[0].Show = false;

document.Save("manageSlide.pptx");