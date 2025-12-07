using IronPPT.Models;
using IronPPT;
namespace IronPPT.Examples.HowTo.ManageImage
{
    public static class Section5
    {
        public static void Run()
        {
            // Load an existing presentation
            var document = new PresentationDocument("real_sample.pptx");
            
            // Remove all images from every slide
            for (int s = 0; s < document.Slides.Count; s++)       // Loop through all slides
            {
                var slide = document.Slides[s];                   // Get the current slide
            
                for (int i = slide.Images.Count - 1; i >= 0; i--) // Loop backward through images on this slide
                {
                    slide.Images[i].Remove();                     // Remove each image
                }
            }
            
            // Save the updated presentation
            document.Save("removed-images.pptx");
        }
    }
}