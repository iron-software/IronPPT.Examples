using IronPPT;
using IronPPT.Models;

// Create new PowerPoint presentation
var document = new PresentationDocument();

// Add image
Image image = new Image();
image.LoadFromFile("sample.png");
var newImage = document.AddImage(image, 0);

// Edit image's properties
newImage.Position = (200, 200);
newImage.Angle = 45;
newImage.Name = "new image";
newImage.Width = 150;
newImage.Height = 150;

// Export PowerPoint presentation
document.Save("addImage.pptx");