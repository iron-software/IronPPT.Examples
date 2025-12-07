using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section2
    {
        public static void Run()
        {
            // Ensure you have the necessary using directives for any external libraries or namespaces.
            using IronPPT;
            
            // Instantiate a new PresentationDocument object.
            var document = new PresentationDocument();
            
            // Add three slides to the presentation.
            // The AddSlide method creates a new slide and adds it to the list of slides in the document.
            document.AddSlide();  // Add first slide
            document.AddSlide();  // Add second slide
            document.AddSlide();  // Add third slide
            
            // Save the presentation to a file named "addSlides.pptx".
            // The Save method takes a file path as an argument and writes the current state of the presentation to this file.
            document.Save("addSlides.pptx");
        }
    }
}