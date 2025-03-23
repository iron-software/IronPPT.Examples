using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section1
    {
        public static void Run()
        {
            var document = new PresentationDocument();
            
            // Add slides
            document.AddSlide();
            document.AddSlide();
            document.AddSlide();
            
            document.Save("addSlides.pptx");
        }
    }
}