using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section3
    {
        public static void Run()
        {
            var document = new PresentationDocument();
            
            // Adding a new slide to the document.
            document.AddSlide();
            
            // To reorder slides, we must remove the slide from its current position 
            // and then insert it back at the desired position. 
            
            // Capture the slide to be moved. 
            // Assuming we want to move the first slide in this case.
            var slideToMove = document.Slides[0];
            
            // Remove the slide from its current position.
            document.Slides.Remove(slideToMove);
            
            // Add the slide back at the desired index (for example, index 1).
            // Ensure the desired index is valid and within the range of the current slides.
            if (document.Slides.Count >= 1) // Check if there is at least one slide to insert into.
            {
                document.Slides.Insert(1, slideToMove);
            }
            
            // Save the presentation with the reordered slide.
            // Ensure a valid file path and name are provided.
            document.Save("reorderSlide.pptx");
        }
    }
}