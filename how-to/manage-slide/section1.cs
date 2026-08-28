using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section1
    {
        public static void Run()
        {
            var document = new PresentationDocument();
            document.AddSlide();

            // Slides is a List<Slide> on the document; Slide itself has no Remove
            document.Slides.RemoveAt(0);
        }
    }
}