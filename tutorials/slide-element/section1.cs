using IronPPT;
namespace IronPPT.Examples.Tutorial.SlideElement
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Add slide element instantly
            var doc = new IronPPT.PresentationDocument();
            var text = doc.Slides.Count > 0 ? doc.Slides[0].AddText("Quick Option") : doc.Slides.Add(new IronPPT.Models.Slide()).AddText("Quick Option");
            doc.Save("quick.pptx");
        }
    }
}