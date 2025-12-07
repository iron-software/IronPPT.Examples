using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Start Managing Slides in One Line
            new PresentationDocument().AddSlide().Slides[0].Remove();
        }
    }
}