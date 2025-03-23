using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section4
    {
        public static void Run()
        {
            var document = new PresentationDocument();
            
            document.AddSlide();
            
            // Hide slide
            document.Slides[0].Show = false;
            
            document.Save("hideSlide.pptx");
        }
    }
}