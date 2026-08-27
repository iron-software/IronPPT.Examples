using IronPPT;
namespace IronPPT.Examples.HowTo.ManageSlide
{
    public static class Section1
    {
        public static void Run()
        {
            new PresentationDocument().AddSlide().Slides[0].Remove();
        }
    }
}