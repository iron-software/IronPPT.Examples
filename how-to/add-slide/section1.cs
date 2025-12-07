using IronPPT;
namespace IronPPT.Examples.HowTo.AddSlide
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate a new PresentationDocument object.
            var document = new PresentationDocument();
            
            // Add a slide to the presentation.
            document.AddSlide();
            
            // Export the presentation to a PPTX file.
            document.Save("addSlides.pptx");
        }
    }
}