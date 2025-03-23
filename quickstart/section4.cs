using IronPPT;
namespace IronPPT.Examples.Overview.Quickstart
{
    public static class Section4
    {
        public static void Run()
        {
            // Create new PowerPoint presentation
            var document = new PresentationDocument();
            
            // Add image
            Image image = new Image();
            image.LoadFromFile("sample.png");
            var newImage = document.Slides[0].AddImage(image);
            
            // Edit image's properties
            newImage.Position = (200, 200);
            newImage.Angle = 45;
            newImage.Name = "new image";
            newImage.Width = 150;
            newImage.Height = 150;
            
            // Export PowerPoint presentation
            document.Save("addImage.pptx");
        }
    }
}