![Nuget](https://img.shields.io/nuget/v/IronPPT?color=informational&label=latest)![Installs](https://img.shields.io/nuget/dt/IronPPT?color=informational&label=installs&logo=nuget)![Passed](https://img.shields.io/badge/build-%20%E2%9C%93%20522%20tests%20passed%20(0%20failed)%20-107C10?logo=visualstudio)![windows](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=windows)![macOS](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=apple)![linux](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=linux&logoColor=white)![docker](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=docker&logoColor=white)![aws](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=amazonaws)![microsoftazure](https://img.shields.io/badge/%E2%80%8E%20-%20%E2%9C%93-107C10?logo=microsoftazure)[![livechat](https://img.shields.io/badge/Live%20Chat:-24/5-purple?logo=googlechat&logoColor=white)](https://ironsoftware.com/csharp/ppt/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topshield#helpscout-support)

## IronPPT - C# Library for PowerPoint Management

[![IronPPT NuGet Trial Banner Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPPT-readme/nuget-trial-banner.png)](https://ironsoftware.com/csharp/ppt/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=topbanner#trial-license)

IronPPT is a comprehensive C# library designed for crafting and modifying PowerPoint presentations. Its powerful API supports the creation of slides and facilitates the embedding of text, images, shapes, and diverse multimedia components. This makes it an exceptional tool for developers who intend to streamline PowerPoint-related operations within .NET frameworks.

### Key Capabilities of IronPPT

  * Programmatic generation and alteration of PowerPoint slides.
  * Embedding and styling text, imagery, shapes, and multimedia.
  * Streamlining routine PowerPoint tasks within .NET frameworks.
  * Compatibility with .NET Framework 4.6.2 onwards and .NET 6.0 and beyond.
  * Intuitive API integration enhancing project fluidity.

Explore more on [our home page](https://ironsoftware.com/csharp/ppt/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist), including a plethora of [coding examples](https://ironsoftware.com/csharp/ppt/examples/add-text/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist) and a [comprehensive feature list](https://ironsoftware.com/csharp/ppt/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featureslist).

#### IronPPT Supports Various Platforms Including:

  * **.NET versions 9 through 5**, Core 2x & 3x, Standard 2 & 2.1, and Framework 4.6.2 onwards.
  * Environments such as Windows, macOS, Linux, plus containers like Docker, and Cloud platforms including Azure and AWS.

[![IronPPT Cross Platform Compatibility Support Image](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPPT-readme/cross-platform-compatibility.png)](https://ironsoftware.com/csharp/ppt/docs/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=crossplatformbanner)

All details regarding our [API documentation](https://ironsoftware.com/csharp/ppt/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs) and [licensing terms](https://ironsoftware.com/csharp/ppt/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#trial-license) are available on our site.

### How to Utilize IronPPT

Begin by installing the IronPPT NuGet package using this command in your package management console:

    PM> Install-Package IronPPT
    

    using IronPPT;
    
    var presentation = new PresentationDocument();
    
    // Create a new Slide
    Slide slide = new Slide();
    
    // Insert text into the slide
    slide.AddText("Sample Text Entry");
    
    // Incorporate the slide into the presentation
    presentation.AddSlide(slide);
    
    presentation.Save("NewSlidePresentation.pptx");
    

### Feature Overview

[![IronPPT Features](https://raw.githubusercontent.com/iron-software/iron-nuget-assets/main/IronPPT-readme/features-table.png)](https://ironsoftware.com/csharp/ppt/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=featuresbanner)

### Licensing & Support Availability

Visit [our official website](https://ironsoftware.com/csharp/ppt/) for extensive tutorials, example code, licensing details, and documentation.

Contact our support team via email: support@ironsoftware.com

### Documentation Resources

  * How-To Guides : [https://ironsoftware.com/csharp/ppt/how-to/](https://ironsoftware.com/csharp/ppt/how-to/html-file-to-pdf/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Code Samples : [https://ironsoftware.com/csharp/ppt/examples/](https://ironsoftware.com/csharp/ppt/examples/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * API Guide : [https://ironsoftware.com/csharp/ppt/object-reference/api/](https://ironsoftware.com/csharp/ppt/object-reference/api/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Tutorial Listings : [https://ironsoftware.com/csharp/ppt/tutorials/](https://ironsoftware.com/csharp/ppt/tutorials/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Licensing Details : [https://ironsoftware.com/csharp/ppt/licensing/](https://ironsoftware.com/csharp/ppt/licensing/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs)
  * Live Support Chat : [https://ironsoftware.com/csharp/ppt/#helpscout-support](https://ironsoftware.com/csharp/ppt/?utm_source=nuget&utm_medium=organic&utm_campaign=readme&utm_content=supportanddocs#helpscout-support)