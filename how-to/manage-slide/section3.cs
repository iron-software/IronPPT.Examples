using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section3
    {
        public static void Run()
        {
            var document = new PresentationDocument();
            
            document.AddSlide();
            
            // Move slide by changing the Index property.
            document.Slides[0].Index = 1;
            
            document.Save("reorderSlide.pptx");
        }
    }
}