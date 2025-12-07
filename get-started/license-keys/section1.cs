using IronPPT;
namespace IronPPT.Examples.GettingStarted.LicenseKeys
{
    public static class Section1
    {
        public static void Run()
        {
            // This code snippet checks whether the IronPPT license key has been successfully applied.
            // It retrieves the license status using the IronPPT library's License class.
            
            // Declaration and initialization of a boolean variable to store the license status
            bool licensed = IronPPT.License.IsLicensed;
            
            // It is assumed that the IronPPT library is correctly referenced,
            // and that the license information has been set prior to this check.
            // This boolean will be true if the license is applied correctly; otherwise, it will be false.
            
            // The code below demonstrates how you might use this information in a larger application.
            if (licensed)
            {
                Console.WriteLine("The IronPPT license has been successfully applied.");
            }
            else
            {
                Console.WriteLine("The IronPPT license is not applied. Please verify the license details.");
            }
        }
    }
}