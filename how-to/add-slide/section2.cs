using IronPPT;
namespace IronPPT.Examples.HowTo.AddSlide
{
    public static class Section2
    {
        public static void Run()
        {
            // Create a new presentation document
            var document = new PresentationDocument();
            
            // Create a new slide object
            var slide = new Slide();
            
            // Add text to the slide
            slide.AddText("Hello World!");
            
            // Add the slide object to the document using the AddSlide method
            document.AddSlide(slide);
            
            // Save the presentation as a PPTX file
            document.Save("adding-slide-object.pptx");
        }
    }
}