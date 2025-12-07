using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section4
    {
        public static void Run()
        {
            // Create a new presentation document
            var document = new PresentationDocument();
            
            // Add a new slide to the presentation
            document.AddSlide();
            
            // Hide the first slide by setting its visibility to false
            document.Slides[0].Visible = false;
            
            // Save the presentation to a file named 'hideSlide.pptx'
            document.Save("hideSlide.pptx");
        }
    }
}