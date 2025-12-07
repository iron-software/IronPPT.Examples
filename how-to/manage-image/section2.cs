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
            Image image = new Image();
            image.LoadFromFile("image.jpg");
            
            // Add image to the second slide (index 1)
            var newImage = document.AddImage(image, 1);
            
            // Modify image properties
            newImage.Angle = 45; // Rotate the image 45 degrees
            newImage.FrameShape = ShapeType.RoundRectangle; // Set the frame shape to Rounded Rectangle
            newImage.Position = (180, 180); // Set the position to coordinates (180, 180)
            newImage.Width = 300; // Set the width to 300 points
            newImage.Height = 300; // Set the height to 300 points
            
            // Save the modified presentation as a new .pptx file
            document.Save("modifying-image-properties.pptx");
        }
    }
}