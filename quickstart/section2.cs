using IronPPT;
namespace IronPPT.Examples.Overview.Quickstart
{
    public static class Section2
    {
        public static void Run()
        {
            // Create new PowerPoint presentation
            var document = new PresentationDocument();
            
            // Add empty slide
            document.AddSlide();
            
            // Add slide object
            Slide slide = new Slide();
            slide.AddText("Hello!");
            document.AddSlide(slide);
            
            // Export PowerPoint presentation
            document.Save("output.pptx");
        }
    }
}