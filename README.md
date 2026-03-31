# Getting Started with UWP Sunburst Chart (SfSunburstChart)

This sample demonstrates how to create and configure a UWP Sunburst Chart using the Syncfusion `SfSunburstChart` control. It covers populating the chart with data, adding a header, legend, and data labels.

## Requirements to run the demo

- Visual Studio 2019 or later
- Windows 10 SDK
- Syncfusion UWP controls (Syncfusion.SfSunburstChart.UWP)

## How to run the sample

1. Open the solution file `GettingStarted.slnx` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Build and run the application.

---

## Getting Started Steps

### 1. Adding Assembly Reference

1. Open the **Add Reference** window from your project.
2. Choose **Assemblies > Extensions > Syncfusion Controls for UWP XAML**.
3. Select **Syncfusion.SfSunburstChart.UWP** and click **OK**.

Alternatively, install the NuGet package:

```
Install-Package Syncfusion.SfSunburstChart.UWP
```

---

### 2. Adding the Namespace

Add the following namespace in your `MainPage.xaml`:

```xml
xmlns:sunburst="using:Syncfusion.UI.Xaml.SunburstChart"
```

---

### 3. Initialize View Model

Define the **Model** class to represent each data item:

```csharp
public class Model
{
    public string Country { get; set; }
    public string JobDescription { get; set; }
    public string JobGroup { get; set; }
    public string JobRole { get; set; }
    public double EmployeesCount { get; set; }
}
```

Create the **ViewModel** class with an `ObservableCollection<Model>` populated with employee data:

```csharp
public class ViewModel
{
    public ObservableCollection<Model> Data { get; set; }

    public ViewModel()
    {
        Data = new ObservableCollection<Model>();
        Data.Add(new Model { Country = "America", JobDescription = "Sales", EmployeesCount = 70 });
        Data.Add(new Model { Country = "America", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 35 });
        Data.Add(new Model { Country = "America", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 105 });
        Data.Add(new Model { Country = "America", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 40 });
        Data.Add(new Model { Country = "America", JobDescription = "Management", EmployeesCount = 40 });
        Data.Add(new Model { Country = "America", JobDescription = "Accounts", EmployeesCount = 60 });
        Data.Add(new Model { Country = "India", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 25 });
        Data.Add(new Model { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 155 });
        Data.Add(new Model { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 60 });
        Data.Add(new Model { Country = "Germany", JobDescription = "Sales", JobGroup = "Executive", EmployeesCount = 30 });
        Data.Add(new Model { Country = "Germany", JobDescription = "Sales", JobGroup = "Analyst", EmployeesCount = 40 });
        Data.Add(new Model { Country = "UK", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 100 });
        Data.Add(new Model { Country = "UK", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 30 });
        Data.Add(new Model { Country = "UK", JobDescription = "HR Executives", EmployeesCount = 60 });
        Data.Add(new Model { Country = "UK", JobDescription = "Marketing", EmployeesCount = 40 });
    }
}
```

Set the `ViewModel` as the `DataContext` in `MainPage.xaml`:

```xml
<Page.DataContext>
    <local:ViewModel />
</Page.DataContext>
```

---

### 4. Populate Sunburst Chart with Data

Bind the `Data` property of the `ViewModel` to the `ItemsSource` property of `SfSunburstChart`. Add `SunburstHierarchicalLevel` entries to the `Levels` collection. Each level is formed based on the `GroupMemberPath` property, and each arc segment size is calculated using `ValueMemberPath`.

```xml
<sunburst:SfSunburstChart ItemsSource="{Binding Data}"
                          ValueMemberPath="EmployeesCount">
    <sunburst:SfSunburstChart.Levels>
        <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
        <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
        <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
        <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
    </sunburst:SfSunburstChart.Levels>
</sunburst:SfSunburstChart>
```

---

### 5. Add Header

Add a header to the Sunburst chart to provide quick information about the data being plotted. Use the `Header` property as shown below:

```xml
<sunburst:SfSunburstChart.Header>
    <TextBlock Text="Employees Count" FontSize="22" Margin="10"
               HorizontalAlignment="Center" VerticalAlignment="Center" />
</sunburst:SfSunburstChart.Header>
```

---

### 6. Add Legend

Enable the legend using the `Legend` property:

```xml
<sunburst:SfSunburstChart.Legend>
    <sunburst:SunburstLegend DockPosition="Left"/>
</sunburst:SfSunburstChart.Legend>
```

---

### 7. Add Data Labels

Add data labels to improve the readability of the Sunburst chart using the `DataLabelInfo` property:

```xml
<sunburst:SfSunburstChart.DataLabelInfo>
    <sunburst:SunburstDataLabelInfo Foreground="White" FontFamily="Cambria" />
</sunburst:SfSunburstChart.DataLabelInfo>
```

---

### 8. Complete XAML

The following is the complete `MainPage.xaml` with all the above configurations applied:

```xml
<Page
    x:Class="GettingStarted.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:GettingStarted"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:sunburst="using:Syncfusion.UI.Xaml.SunburstChart"
    mc:Ignorable="d">

    <Page.DataContext>
        <local:ViewModel />
    </Page.DataContext>

    <Grid>
        <sunburst:SfSunburstChart ItemsSource="{Binding Data}"
                                  Palette="LightCandy"
                                  ValueMemberPath="EmployeesCount">
            <sunburst:SfSunburstChart.Header>
                <TextBlock Text="Employees Count" FontSize="22" Margin="10"
                           HorizontalAlignment="Center" VerticalAlignment="Center" />
            </sunburst:SfSunburstChart.Header>

            <sunburst:SfSunburstChart.Legend>
                <sunburst:SunburstLegend DockPosition="Left"/>
            </sunburst:SfSunburstChart.Legend>

            <sunburst:SfSunburstChart.Levels>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
            </sunburst:SfSunburstChart.Levels>

            <sunburst:SfSunburstChart.DataLabelInfo>
                <sunburst:SunburstDataLabelInfo Foreground="White" FontFamily="Cambria" />
            </sunburst:SfSunburstChart.DataLabelInfo>
        </sunburst:SfSunburstChart>
    </Grid>
</Page>
```
<img width="1919" height="1000" alt="image" src="https://github.com/user-attachments/assets/76016527-0b8a-4d73-af9c-35d049811f92" />

---

## Reference

- [Syncfusion UWP Sunburst Chart Documentation](https://help.syncfusion.com/uwp/sunburst-chart/getting-started)

