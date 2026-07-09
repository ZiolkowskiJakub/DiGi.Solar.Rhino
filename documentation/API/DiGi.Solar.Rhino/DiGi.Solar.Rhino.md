#### [DiGi\.Solar\.Rhino](DiGi.Solar.Rhino.Overview.md 'DiGi\.Solar\.Rhino\.Overview')

## DiGi\.Solar\.Rhino Namespace
### Classes

<a name='DiGi.Solar.Rhino.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.Solar.Rhino.Inspect.Area(thisDiGi.Solar.Interfaces.IShadingSolverResult)'></a>

## Inspect\.Area\(this IShadingSolverResult\) Method

Extracts the area from a shading solver result as a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') object\.

```csharp
public static GH_Number? Area(this DiGi.Solar.Interfaces.IShadingSolverResult? shadingSolverResult);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Inspect.Area(thisDiGi.Solar.Interfaces.IShadingSolverResult).shadingSolverResult'></a>

`shadingSolverResult` [DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')

The shading solver result to extract the area from\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') instance representing the area, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Solar.Rhino.Inspect.DateTime(thisDiGi.Solar.Interfaces.IShadingSolverResult)'></a>

## Inspect\.DateTime\(this IShadingSolverResult\) Method

Extracts the date and time from a shading solver result as a Grasshopper [Grasshopper\.Kernel\.Types\.GH\_Time](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_time 'Grasshopper\.Kernel\.Types\.GH\_Time') object\.

```csharp
public static GH_Time? DateTime(this DiGi.Solar.Interfaces.IShadingSolverResult? shadingSolverResult);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Inspect.DateTime(thisDiGi.Solar.Interfaces.IShadingSolverResult).shadingSolverResult'></a>

`shadingSolverResult` [DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')

The shading solver result to extract the date and time from\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Time](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_time 'Grasshopper\.Kernel\.Types\.GH\_Time')  
A [Grasshopper\.Kernel\.Types\.GH\_Time](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_time 'Grasshopper\.Kernel\.Types\.GH\_Time') instance representing the date and time, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Solar.Rhino.Inspect.PolygonalFace3D(thisDiGi.Solar.Interfaces.IShadingElement)'></a>

## Inspect\.PolygonalFace3D\(this IShadingElement\) Method

Retrieves the polygonal face geometry of the specified shading element as a Goo wrapper\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooPolygonalFace3D? PolygonalFace3D(this DiGi.Solar.Interfaces.IShadingElement? shadingElement);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Inspect.PolygonalFace3D(thisDiGi.Solar.Interfaces.IShadingElement).shadingElement'></a>

`shadingElement` [DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')

The shading element to inspect\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopolygonalface3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopolygonalface3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') containing the polygonal face, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Solar.Rhino.Inspect.PolygonalFace3Ds(thisDiGi.Solar.Classes.GeometricalShadingSolverResult)'></a>

## Inspect\.PolygonalFace3Ds\(this GeometricalShadingSolverResult\) Method

Extracts the collection of polygonal faces from the geometrical shading solver result, converting them to [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopolygonalface3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') instances\.

```csharp
public static System.Collections.IEnumerable? PolygonalFace3Ds(this DiGi.Solar.Classes.GeometricalShadingSolverResult? geometricalShadingSolverResult);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Inspect.PolygonalFace3Ds(thisDiGi.Solar.Classes.GeometricalShadingSolverResult).geometricalShadingSolverResult'></a>

`geometricalShadingSolverResult` [DiGi\.Solar\.Classes\.GeometricalShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.geometricalshadingsolverresult 'DiGi\.Solar\.Classes\.GeometricalShadingSolverResult')

The geometrical shading solver result containing the data to extract\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goopolygonalface3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooPolygonalFace3D') objects if the input is not null; otherwise, null\.

<a name='DiGi.Solar.Rhino.Inspect.Reference(thisDiGi.Solar.Interfaces.IShadingElement)'></a>

## Inspect\.Reference\(this IShadingElement\) Method

Retrieves the reference identifier of the specified shading element as a Grasshopper string\.

```csharp
public static GH_String? Reference(this DiGi.Solar.Interfaces.IShadingElement? shadingElement);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Inspect.Reference(thisDiGi.Solar.Interfaces.IShadingElement).shadingElement'></a>

`shadingElement` [DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')

The shading element to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the reference, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.

<a name='DiGi.Solar.Rhino.Inspect.ShadingElements(thisDiGi.Solar.Classes.ShadingModel)'></a>

## Inspect\.ShadingElements\(this ShadingModel\) Method

Retrieves the shading elements from a shading model and converts them into Goo\-compatible shading elements\.

```csharp
public static System.Collections.IEnumerable? ShadingElements(this DiGi.Solar.Classes.ShadingModel? shadingModel);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Inspect.ShadingElements(thisDiGi.Solar.Classes.ShadingModel).shadingModel'></a>

`shadingModel` [DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')

The shading model instance to extract elements from\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of converted shading elements, or null if the input shading model is null or contains no elements\.

<a name='DiGi.Solar.Rhino.Inspect.ShadingOnly(thisDiGi.Solar.Interfaces.IShadingElement)'></a>

## Inspect\.ShadingOnly\(this IShadingElement\) Method

Retrieves whether the specified shading element is for shading only as a Grasshopper boolean\.

```csharp
public static GH_Boolean? ShadingOnly(this DiGi.Solar.Interfaces.IShadingElement? shadingElement);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Inspect.ShadingOnly(thisDiGi.Solar.Interfaces.IShadingElement).shadingElement'></a>

`shadingElement` [DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')

The shading element to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Boolean](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_boolean 'Grasshopper\.Kernel\.Types\.GH\_Boolean')  
A [Grasshopper\.Kernel\.Types\.GH\_Boolean](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_boolean 'Grasshopper\.Kernel\.Types\.GH\_Boolean') indicating if it's shading only, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the input is null\.