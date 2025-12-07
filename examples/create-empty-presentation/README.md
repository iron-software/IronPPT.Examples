***Based on <https://ironsoftware.com/examples/create-empty-presentation/>***

IronPPT provides you with seamless management to craft a new, empty presentation effortlessly. The process is intuitive and requires only a few lines of code. Below, we'll detail how to set up your blank PowerPoint file quickly and efficiently.


<div class="examples__featured-snippet examples__featured-snippet">
    <h2>Three Simple Steps to Create a Blank Presentation</h2>
    <ol>
        <li><code>using IronPPT;</code></li>
        <li><code>var presentation = new PresentationDocument();</code></li>
        <li><code>presentation.Save("output.pptx");</code></li>
    </ol>
</div>
```

## Code Discussion

The initial step to develop a blank presentation is to include the `IronPPT` namespace, which you can locate [here](https://www.nuget.org/packages/IronPPT).

Once the namespace is included, you construct a new `PresentationDocument` object and set this as your **presentation** variable. This variable represents your new, blank PowerPoint file.

Finally, employ the `Save` method from the `PresentationDocument` class to store your file as **output.pptx**. You can then utilize this presentation directly or enhance it by adding slides and content using the extensive features of IronPPT.

[Explore Managing Slides with IronPPT](https://ironsoftware.com/csharp/ppt/how-to/manage-slide/)