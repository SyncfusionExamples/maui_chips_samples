# Maui Chips samples
This section explains the steps required to create chips and arrange them in a layout for performing action. This section covers only the minimal features that you needed to know to get started with the chips.
## Adding .NET MAUI Chips reference
Syncfusion .NET MAUI components are available in nuget.org. To add Chips to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Core, and then install it.
## Adding the .NET MAUI Chips control
Step 1: Add the NuGet to the project

Step 2: Add the namespace as shown in the following code snippet

**[XAML]**

```
xmlns:chip="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
```

**[C#]**
```
using Syncfusion.Maui.Core;
```
# For SfChip
**[XAML]**

```
<ContentPage.Content>    
    <chip:SfChip x:Name="chips" />
</ContentPage.Content>
```

**[C#]**
```
SfChip chips = new SfChip(); 
Content = chips;
```

## For SfChipGroup
Initialize an empty [SfChipGroup] as shown in the following code snippet

**[XAML]**

```

<ContentPage.Content>
	<Grid>
             <chip:SfChipGroup/>
	</Grid>
</ContentPage.Content>
```

**[C#]**
```
	Grid grid = new Grid();
	SfChipGroup chipGroup = new SfChipGroup();
	grid.Children.Add(chipGroup);
	this.Content = grid;
```
## How to run this application?
To run this application, you need to first clone the maui_chips_samples and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.
## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
## License
Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
