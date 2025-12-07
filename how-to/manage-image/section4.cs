using IronPPT;
namespace IronPPT.Examples.HowTo.ManageImage
{
    public static class Section4
    {
        public static void Run()
        {
            // Create a new presentation
            var document = new PresentationDocument("real_sample.pptx");
            
            // Remove the first image found in the first slide
            document.Slides[1].Images[0].Remove();
            
            // Save the updated presentation
            document.Save("removed-image.pptx");
        }
    }
}