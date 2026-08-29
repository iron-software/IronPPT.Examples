using System.Drawing;
using IronPPT;
namespace IronPPT.Examples.Tutorial.SlideElement
{
    public static class Section4
    {
        public static void Run()
        {
            // This script demonstrates the creation of a PowerPoint presentation using the IronPPT library.
            // An image is added to the presentation, its properties are modified, and then the presentation is saved.
            
            // Create a new PowerPoint presentation
            var document = new PresentationDocument();
            
            // Create a new Image object and load an image file.
            var image = new IronPPT.Models.Image();
            image.LoadFromFile("sample.png");
            
            // Add the image to the first slide (index 0) of the presentation.
            var newImage = document.AddImage(image, 0);
            
            // Set the properties of the added image.
            // Position is an ElementPosition holding X and Y as DocUnits.
            newImage.Position = new IronPPT.Models.ElementPosition
            {
                X = new IronPPT.Models.DocUnit { Point = 200 },
                Y = new IronPPT.Models.DocUnit { Point = 200 }
            };
            newImage.Angle = 45; // Set the rotation angle of the image
            newImage.Name = "new image"; // Assign a descriptive name to the image
            newImage.Width = 150; // Set the width of the image in pixels
            newImage.Height = 150; // Set the height of the image in pixels
            
            // Export the PowerPoint presentation to a file named "addImage.pptx"
            document.Save("addImage.pptx");
        }
    }
}