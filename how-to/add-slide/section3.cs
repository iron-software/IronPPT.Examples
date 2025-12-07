using IronPPT;
namespace IronPPT.Examples.HowTo.AddSlide
{
    public static class Section3
    {
        public static void Run()
        {
            // Loading an existing PPTX file
            var document = new PresentationDocument("adding-slide-object.pptx");
            
            // Add 3 new slides to the presentation
            for (i = 0; i < 3; i++) {
                document.AddSlide()
            }
            
            // Export the file
            document.Save("addSlides.pptx");
        }
    }
}