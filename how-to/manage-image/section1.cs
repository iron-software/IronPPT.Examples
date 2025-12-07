using IronPPT.Models;
using IronPPT;
namespace IronPPT.Examples.HowTo.ManageImage
{
    public static class Section1
    {
        public static void Run()
        {
            // Create a new presentation document
            var document = new PresentationDocument();
            
            // Create and load an image from file
            Image image = new Image();
            image.LoadFromFile("image.jpg");
            
            // Add image to the first slide (index 0)
            var newImage = document.AddImage(image, 0);
            
            // Rotate the image 180 degrees
            newImage.Angle = 180;
            
            // Save the presentation as a .pptx file
            document.Save("adding-image.pptx");
        }
    }
}