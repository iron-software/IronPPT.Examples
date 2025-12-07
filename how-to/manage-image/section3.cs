using IronPPT.Models;
using IronPPT;
namespace IronPPT.Examples.HowTo.ManageImage
{
    public static class Section3
    {
        public static void Run()
        {
            // Load an existing presentation
            var document = new PresentationDocument("sample.pptx");
            
            // Load the replacement image
            Image replaceImage = new Image();
            replaceImage.LoadFromFile("sample.png");
            
            // Replace the first image found in the first slide
            document.Slides[0].Images[0].Replace(replaceImage);
            
            // Save changes (overwriting the original file)
            document.Save("sample.pptx");
        }
    }
}