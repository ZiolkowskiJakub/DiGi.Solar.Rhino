## DiGi\.Solar\.ComputeSharp\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions'></a>

## GooShadingSolverOptions Class

Represents a Grasshopper\-compatible wrapper for shading solver options, enabling serialization and data flow within the Grasshopper environment\.

```csharp
public class GooShadingSolverOptions : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Solar.ComputeSharp.Classes.ShadingSolverOptions>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Solar\.ComputeSharp\.Classes\.ShadingSolverOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.computesharp.classes.shadingsolveroptions 'DiGi\.Solar\.ComputeSharp\.Classes\.ShadingSolverOptions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Solar\.ComputeSharp\.Classes\.ShadingSolverOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.computesharp.classes.shadingsolveroptions 'DiGi\.Solar\.ComputeSharp\.Classes\.ShadingSolverOptions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooShadingSolverOptions
### Constructors

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions.GooShadingSolverOptions()'></a>

## GooShadingSolverOptions\(\) Constructor

Initializes a new instance of the [GooShadingSolverOptions](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.GooShadingSolverOptions') class\.

```csharp
public GooShadingSolverOptions();
```

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions.GooShadingSolverOptions(DiGi.Solar.ComputeSharp.Classes.ShadingSolverOptions)'></a>

## GooShadingSolverOptions\(ShadingSolverOptions\) Constructor

Initializes a new instance of the [GooShadingSolverOptions](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.GooShadingSolverOptions') class with the specified shading solver options\.

```csharp
public GooShadingSolverOptions(DiGi.Solar.ComputeSharp.Classes.ShadingSolverOptions? shadingSolverOptions);
```
#### Parameters

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions.GooShadingSolverOptions(DiGi.Solar.ComputeSharp.Classes.ShadingSolverOptions).shadingSolverOptions'></a>

`shadingSolverOptions` [DiGi\.Solar\.ComputeSharp\.Classes\.ShadingSolverOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.computesharp.classes.shadingsolveroptions 'DiGi\.Solar\.ComputeSharp\.Classes\.ShadingSolverOptions')

The shading solver options to wrap\.
### Methods

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions.Duplicate()'></a>

## GooShadingSolverOptions\.Duplicate\(\) Method

Creates a duplicate of the current [GooShadingSolverOptions](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.GooShadingSolverOptions') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance that is a copy of the current object\.

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptionsParam'></a>

## GooShadingSolverOptionsParam Class

Represents a Grasshopper parameter component used to handle [GooShadingSolverOptions](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.GooShadingSolverOptions') data\.

```csharp
public class GooShadingSolverOptionsParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions, DiGi.Solar.ComputeSharp.Classes.ShadingSolverOptions>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooShadingSolverOptions](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptions 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.GooShadingSolverOptions')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Solar\.ComputeSharp\.Classes\.ShadingSolverOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.computesharp.classes.shadingsolveroptions 'DiGi\.Solar\.ComputeSharp\.Classes\.ShadingSolverOptions')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooShadingSolverOptionsParam
### Constructors

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptionsParam.GooShadingSolverOptionsParam()'></a>

## GooShadingSolverOptionsParam\(\) Constructor

Initializes a new instance of the [GooShadingSolverOptionsParam](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptionsParam 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.GooShadingSolverOptionsParam') class\.

```csharp
public GooShadingSolverOptionsParam();
```
### Properties

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptionsParam.ComponentGuid'></a>

## GooShadingSolverOptionsParam\.ComponentGuid Property

Gets the unique identifier for the [GooShadingSolverOptionsParam](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.GooShadingSolverOptionsParam 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.GooShadingSolverOptionsParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the DiGi\.Solar\.ComputeSharp\.Rhino Grasshopper plugin\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the preferred contact details for the author\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author or company that created the library\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets a short description describing the purpose of this GHA library\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets the bitmap icon representing this GHA library\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for this assembly\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the GHA library\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions'></a>

## ShadingSolverOptions Class

Represents a Grasshopper component that defines the options for the shading solver, 
such as time series data, solver type, and geometric tolerances\.

```csharp
public class ShadingSolverOptions : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ShadingSolverOptions
### Constructors

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions.ShadingSolverOptions()'></a>

## ShadingSolverOptions\(\) Constructor

Initializes a new instance of the [ShadingSolverOptions](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.ShadingSolverOptions') class\.

```csharp
public ShadingSolverOptions();
```
### Properties

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions.ComponentGuid'></a>

## ShadingSolverOptions\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions.Exposure'></a>

## ShadingSolverOptions\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions.Inputs'></a>

## ShadingSolverOptions\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions.Outputs'></a>

## ShadingSolverOptions\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions.SolveInstance(IGH_DataAccess)'></a>

## ShadingSolverOptions\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.ShadingSolverOptions.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading'></a>

## SolveShading Class

Represents a Grasshopper component that solves shading analysis for a specified shading model and solver options\.

```csharp
public class SolveShading : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → SolveShading
### Constructors

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading.SolveShading()'></a>

## SolveShading\(\) Constructor

Initializes a new instance of the [SolveShading](DiGi.Solar.ComputeSharp.Rhino.Classes.md#DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading 'DiGi\.Solar\.ComputeSharp\.Rhino\.Classes\.SolveShading') class\.

```csharp
public SolveShading();
```
### Properties

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading.ComponentGuid'></a>

## SolveShading\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading.Exposure'></a>

## SolveShading\.Exposure Property

Gets the exposure level of the component, which defines how it is displayed in the Grasshopper interface\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading.Inputs'></a>

## SolveShading\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading.Outputs'></a>

## SolveShading\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading.SolveInstance(IGH_DataAccess)'></a>

## SolveShading\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Solar.ComputeSharp.Rhino.Classes.SolveShading.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.