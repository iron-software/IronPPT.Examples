using IronPPT;
namespace IronPPT.Examples.Tutorial.SlideElement
{
    public static class Section1
    {
        public static void Run()
        {
            var doc = new IronPPT.PresentationDocument();
            // List<Slide>.Add returns void, so a new slide comes from AddSlide,
            // which hands the Slide back.
            var slide = doc.Slides.Count > 0 ? doc.Slides[0] : doc.AddSlide();
            var text = slide.AddText("Quick Option");
            doc.Save("quick.pptx");
        }
    }
}