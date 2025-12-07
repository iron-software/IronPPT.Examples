using System.Drawing;
using IronPPT;
namespace IronPPT.Examples.Overview.Quickstart
{
    public static class Section2
    {
        public static void Run()
        {
            // This code demonstrates creating a new PowerPoint presentation, adding an image to it,
            // modifying the image's properties, and exporting the presentation.
            
            // Create a new PowerPoint presentation
            var document = new PresentationDocument();
            
            // Ensure there's at least one slide in the presentation
            // Create the first slide if it doesn't exist yet
            if (document.Slides.Count == 0)
            {
                document.Slides.Add();
            }
            
            // Initialize an Image object
            // Load an image from a file specified by the file path
            // Ensure that "sample.png" exists at the specified path
            Image image = new Image(); 
            image.LoadFromFile("sample.png");
            
            // Add the image to the first slide of the presentation
            var newImage = document.Slides[0].AddImage(image);
            
            // Edit the image's properties
            // Set the position of the image using X and Y coordinates
            newImage.Position = new Point(200, 200);
            
            // Set the rotation angle of the image in degrees
            newImage.Angle = 45;
            
            // Set a name for the image, which can be useful for identification
            newImage.Name = "new image";
            
            // Set the dimensions of the image
            newImage.Width = 150;
            newImage.Height = 150;
            
            // Export the PowerPoint presentation with the new image
            document.Save("addImage.pptx");
        }
    }
}