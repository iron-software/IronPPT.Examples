using IronPPT;
namespace IronPPT.Examples.Overview.Quickstart
{
    public static class Section1
    {
        public static void Run()
        {
            // This code demonstrates the creation of a PowerPoint presentation and saving it as a file.
            
            // Create a new PowerPoint presentation document
            var document = new PresentationDocument();
            
            // Create a new slide object
            var slide = new Slide();
            
            // Add text content to the slide
            slide.AddText("Hello!");
            
            // Add the newly created slide with text to the document
            document.AddSlide(slide);
            
            // Export the PowerPoint presentation to a file named "output.pptx"
            document.Save("output.pptx");
        }
    }
}