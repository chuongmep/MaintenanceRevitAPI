# MaintenanceRevitAPI
Sample Maintain Revit plugins for multiple versions.

Many Thanks  <a href="https://github.com/ksobon/archilab">ksobon</a> has guide for do that,you can donate for her.

Project is a example for Maintain muti version revit addin about revit 2020 and revit 2018, we can use it same problem with version other.
How to use it ? 
Step 1: 
Add PropertyGroup To {filename}.csproj contain dll re
``` csproj
<PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{8F2BB60A-09BC-41EC-A013-2AE8BE5BCEC9}</ProjectGuid>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>HOK.MissionControl</RootNamespace>
    <AssemblyName>HOK.MissionControl</AssemblyName>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2015'">v4.5.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2016'">v4.5.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2017'">v4.5.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2018'">v4.5.2</TargetFrameworkVersion>
    <TargetFrameworkVersion Condition="'$(Configuration)' == '2019'">v4.7.1</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <TargetFrameworkProfile />
    <NuGetPackageImportStamp>
    </NuGetPackageImportStamp>
  </PropertyGroup>
```
Step 2 : 
Edit Reference include in {filename}.csproj with Condition Configuration for other version
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
```
Step 3 : Try Rebuild Solution or check by see Reference has automatic change when click with a other Configuration.

