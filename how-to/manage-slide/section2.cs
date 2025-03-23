using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section2
    {
        public static void Run()
        {
            var document = new PresentationDocument();
            
            document.AddSlide();
            
            // Remove slide
            document.Slides[0].Remove();
            
            document.Save("removeSlide.pptx");
        }
    }
}