using IronPPT.Enums;
using IronPPT;
namespace IronPPT.Examples.HowTo.ManageImage
{
    public static class Section2
    {
        public static void Run()
        {
            // Load an existing presentation document
            var document = new PresentationDocument("existing-presentation.pptx");
            
            // Create and load an image from file
            IronPPT.Models.Image image = new IronPPT.Models.Image();
            image.LoadFromFile("image.jpg");
            
            // Add image to the second slide (index 1)
            var newImage = document.AddImage(image, 1);
            
            // Modify image properties
            newImage.Angle = 45; // Rotate the image 45 degrees
            newImage.FrameShape = ShapeType.RoundRectangle; // Set the frame shape to Rounded Rectangle
            // Position is an ElementPosition of DocUnits
            newImage.Position = new IronPPT.Models.ElementPosition
            {
                X = new IronPPT.Models.DocUnit { Point = 180 },
                Y = new IronPPT.Models.DocUnit { Point = 180 }
            };
            newImage.Width = 300; // Set the width to 300 points
            newImage.Height = 300; // Set the height to 300 points
            
            // Save the modified presentation as a new .pptx file
            document.Save("modifying-image-properties.pptx");
        }
    }
}