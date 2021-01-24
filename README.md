# MaintenanceRevitAPI
Sample Maintain Revit plugins for multiple versions.

Many Thanks  <a href="https://github.com/ksobon/archilab">ksobon</a> has guide for do that,you can donate for her.

Project is a example for Maintain muti version revit addin about revit 2020 and revit 2018, we can use it same problem with version other.

How to use it ? 

Step 1: 

Add PropertyGroup To {filename}.csproj contain dll <a href="https://github.com/chuongmep/MaintenanceRevitAPI/blob/b990ab1e76e359ff5c0497d33c7204bdec2147ed/Demo.csproj#L18-L33">see detail</a>  
``` csproj
<PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{8F2BB60A-09BC-41EC-A013-2AE8BE5BCEC9}</ProjectGuid>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Demo</RootNamespace>
    <AssemblyName>$(AssemblyName)</AssemblyName>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2015'">v4.5.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2016'">v4.5.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2017'">v4.5.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2018'">v4.5.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2019'">v4.7.1</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2020'">v4.7.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2021'">v4.8</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <TargetFrameworkProfile />
    <NuGetPackageImportStamp>
    </NuGetPackageImportStamp>
  </PropertyGroup>
```

Step 2 : 

Edit Reference include in {filename}.csproj with Condition Configuration for other version <a href="https://github.com/chuongmep/MaintenanceRevitAPI/blob/b990ab1e76e359ff5c0497d33c7204bdec2147ed/Demo.csproj#L43-L58">see detail</a> 

``` csproj
<Reference Include="RevitAPI" Condition="'$(Configuration)' == '2015'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2015\RevitAPI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPIUI" Condition="'$(Configuration)' == '2015'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2015\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPI" Condition="'$(Configuration)' == '2016'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2016\RevitAPI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPIUI" Condition="'$(Configuration)' == '2016'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2016\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPI" Condition="'$(Configuration)' == '2017'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2017\RevitAPI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPIUI" Condition="'$(Configuration)' == '2017'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2017\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPI" Condition="'$(Configuration)' == '2018'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2018\RevitAPI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPIUI" Condition="'$(Configuration)' == '2018'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2018\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPI" Condition="'$(Configuration)' == '2019'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2019\RevitAPI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPIUI" Condition="'$(Configuration)' == '2019'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2019\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
</Reference>
Reference Include="RevitAPI" Condition="'$(Configuration)' == '2020'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2020\RevitAPI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPIUI" Condition="'$(Configuration)' == '2020'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2020\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
Reference Include="RevitAPI" Condition="'$(Configuration)' == '2021'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2021\RevitAPI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPIUI" Condition="'$(Configuration)' == '2021'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2021\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
</Reference>
Reference Include="RevitAPI" Condition="'$(Configuration)' == '2022'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2022\RevitAPI.dll</HintPath>
      <Private>False</Private>
</Reference>
<Reference Include="RevitAPIUI" Condition="'$(Configuration)' == '2019'">
      <HintPath>..\..\..\..\..\..\..\Program Files\Autodesk\Revit 2022\RevitAPIUI.dll</HintPath>
      <Private>False</Private>
</Reference>
```

Step 3 : Try Rebuild Solution or check by see Reference has automatic change when click with a other Configuration.

Step 4 : Use it to pull more branch to managerment and push/pull request from master, it will a branch with version newsest.

