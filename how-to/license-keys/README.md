# Integrating License Keys with IronPPT

***Based on <https://ironsoftware.com/how-to/license-keys/>***


## Acquiring a License Key

To ensure full functionality without any limitations or watermarks in your live deployment, securing an IronPPT license key is essential.

You can [purchase a license here](https://ironsoftware.com/csharp/ppt/licensing/) or obtain a [free 30-day trial key here](https://ironsoftware.com/csharp/ppt/licensing/).

--------------------------------------------------------------------------------

## Step 1: Obtain the Latest IronPPT Version

## Step 2: Insert Your License Key

### Code Implementation for License Setup

Incorporate the following code at the beginning of your application to initialize the license before utilizing IronPPT.

```csharp
IronPPT.License.LicenseKey = "IRONPPT.MYLICENSE.KEY.1EF01";
```

### Using an `appsettings.json` for .NET Core Applications

To manage the license key across your entire .NET Core application:

- Create an `appsettings.json` at the root of your project.
- Integrate a `IronPPT.LicenseKey` entry in your JSON configuration file with the license key as its value.
- Adjust the file properties to _Copy to Output Directory: Copy always_.

_File: `appsettings.json`_

```json
{
    "IronPPT.LicenseKey": "IronPPT.MYLICENSE.KEY.1EF01"
}
```

--------------------------------------------------------------------------------

## Step 3: Confirm Your License Key

### Check the Applied License Key

Use the code below to validate if the license key is properly implemented.

```csharp
// Confirming License Key Application
bool licensed = IronPPT.License.IsLicensed;
```

### Confirm License Key Validity

To verify your license or trial key's authenticity, the following approach is suggested:

```csharp
// THIS CODE SNIPPET IS NOT AVAILABLE!
```

If the result is **True**, your key is valid and you're ready to proceed with IronPPT. If **False**, the key is not valid.

--------------------------------------------------------------------------------

## Step 4: Kickoff Your Project with IronPPT

To effectively start using IronPPT, please follow our detailed guide on [Getting Started with IronPPT](https://ironsoftware.com/csharp/ppt/docs/). This guide provides step-by-step instructions and examples to familiarize you with the basics of IronPPT.

--------------------------------------------------------------------------------

## Support and Queries

For deploying IronPPT in your live projects, a paid or trial key is required, accessible by [purchasing a license](https://ironsoftware.com/csharp/ppt/licensing/) or via [this link](trial-license) for a trial. Explore comprehensive code samples, tutorials, licensing information, and detailed documentation in the [IronPPT section](https://ironsoftware.com/csharp/ppt/) of our website.

For further assistance, contact <support@ironsoftware.com>.