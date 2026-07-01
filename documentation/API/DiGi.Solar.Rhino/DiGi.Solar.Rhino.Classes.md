#### [DiGi\.Solar\.Rhino](index.md 'index')

## DiGi\.Solar\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.Solar.Rhino.Classes.GooShadingElement'></a>

## GooShadingElement Class

Represents a Grasshopper Goo wrapper for an [DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')\.

```csharp
public class GooShadingElement : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Solar.Interfaces.IShadingElement>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooShadingElement
### Constructors

<a name='DiGi.Solar.Rhino.Classes.GooShadingElement.GooShadingElement()'></a>

## GooShadingElement\(\) Constructor

Initializes a new instance of the [GooShadingElement](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingElement 'DiGi\.Solar\.Rhino\.Classes\.GooShadingElement') class\.

```csharp
public GooShadingElement();
```

<a name='DiGi.Solar.Rhino.Classes.GooShadingElement.GooShadingElement(DiGi.Solar.Interfaces.IShadingElement)'></a>

## GooShadingElement\(IShadingElement\) Constructor

Initializes a new instance of the [GooShadingElement](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingElement 'DiGi\.Solar\.Rhino\.Classes\.GooShadingElement') class with the specified shading element\.

```csharp
public GooShadingElement(DiGi.Solar.Interfaces.IShadingElement? shadingElement);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Classes.GooShadingElement.GooShadingElement(DiGi.Solar.Interfaces.IShadingElement).shadingElement'></a>

`shadingElement` [DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')

The shading element to wrap\.
### Properties

<a name='DiGi.Solar.Rhino.Classes.GooShadingElement.Geometries'></a>

## GooShadingElement\.Geometries Property

Gets the geometries associated with the shading element\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.Rhino.Classes.GooShadingElement.Duplicate()'></a>

## GooShadingElement\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [GooShadingElement](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingElement 'DiGi\.Solar\.Rhino\.Classes\.GooShadingElement') instance containing the same value\.

<a name='DiGi.Solar.Rhino.Classes.GooShadingElementParam'></a>

## GooShadingElementParam Class

Represents a Grasshopper parameter for handling [GooShadingElement](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingElement 'DiGi\.Solar\.Rhino\.Classes\.GooShadingElement') objects\.

```csharp
public class GooShadingElementParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Solar.Rhino.Classes.GooShadingElement, DiGi.Solar.Interfaces.IShadingElement>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooShadingElement](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingElement 'DiGi\.Solar\.Rhino\.Classes\.GooShadingElement')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooShadingElement](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingElement 'DiGi\.Solar\.Rhino\.Classes\.GooShadingElement')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooShadingElement](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingElement 'DiGi\.Solar\.Rhino\.Classes\.GooShadingElement')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Solar\.Interfaces\.IShadingElement](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingelement 'DiGi\.Solar\.Interfaces\.IShadingElement')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooShadingElementParam
### Properties

<a name='DiGi.Solar.Rhino.Classes.GooShadingElementParam.ComponentGuid'></a>

## GooShadingElementParam\.ComponentGuid Property

Gets the unique identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.GooShadingModel'></a>

## GooShadingModel Class

Represents a Grasshopper\-compatible wrapper for a shading model, enabling serialization and baking within the Rhino/Grasshopper environment\.

```csharp
public class GooShadingModel : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Solar.Classes.ShadingModel>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooShadingModel
### Constructors

<a name='DiGi.Solar.Rhino.Classes.GooShadingModel.GooShadingModel()'></a>

## GooShadingModel\(\) Constructor

Initializes a new instance of the [GooShadingModel](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingModel 'DiGi\.Solar\.Rhino\.Classes\.GooShadingModel') class\.

```csharp
public GooShadingModel();
```

<a name='DiGi.Solar.Rhino.Classes.GooShadingModel.GooShadingModel(DiGi.Solar.Classes.ShadingModel)'></a>

## GooShadingModel\(ShadingModel\) Constructor

Initializes a new instance of the [GooShadingModel](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingModel 'DiGi\.Solar\.Rhino\.Classes\.GooShadingModel') class with the specified shading model\.

```csharp
public GooShadingModel(DiGi.Solar.Classes.ShadingModel? shadingModel);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Classes.GooShadingModel.GooShadingModel(DiGi.Solar.Classes.ShadingModel).shadingModel'></a>

`shadingModel` [DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')

The shading model to be wrapped\.
### Properties

<a name='DiGi.Solar.Rhino.Classes.GooShadingModel.Geometries'></a>

## GooShadingModel\.Geometries Property

Gets the collection of geometries associated with the current shading model\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.Rhino.Classes.GooShadingModel.Duplicate()'></a>

## GooShadingModel\.Duplicate\(\) Method

Creates a duplicate of the current shading model wrapper\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [GooShadingModel](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingModel 'DiGi\.Solar\.Rhino\.Classes\.GooShadingModel') instance containing a copy of the original value\.

<a name='DiGi.Solar.Rhino.Classes.GooShadingModelParam'></a>

## GooShadingModelParam Class

Represents the Grasshopper parameter type used to handle and pass [GooShadingModel](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingModel 'DiGi\.Solar\.Rhino\.Classes\.GooShadingModel') objects between components\.

```csharp
public class GooShadingModelParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Solar.Rhino.Classes.GooShadingModel, DiGi.Solar.Classes.ShadingModel>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooShadingModel](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingModel 'DiGi\.Solar\.Rhino\.Classes\.GooShadingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooShadingModel](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingModel 'DiGi\.Solar\.Rhino\.Classes\.GooShadingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooShadingModel](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingModel 'DiGi\.Solar\.Rhino\.Classes\.GooShadingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Solar\.Classes\.ShadingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.classes.shadingmodel 'DiGi\.Solar\.Classes\.ShadingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooShadingModelParam
### Properties

<a name='DiGi.Solar.Rhino.Classes.GooShadingModelParam.ComponentGuid'></a>

## GooShadingModelParam\.ComponentGuid Property

Gets the unique identifier for the shading model component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.GooShadingSolverResult'></a>

## GooShadingSolverResult Class

Represents a Grasshopper\-compatible wrapper for shading solver results, enabling serialization and baking of the resulting geometry\.

```csharp
public class GooShadingSolverResult : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Solar.Interfaces.IShadingSolverResult>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooShadingSolverResult
### Constructors

<a name='DiGi.Solar.Rhino.Classes.GooShadingSolverResult.GooShadingSolverResult()'></a>

## GooShadingSolverResult\(\) Constructor

Initializes a new instance of the [GooShadingSolverResult](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingSolverResult 'DiGi\.Solar\.Rhino\.Classes\.GooShadingSolverResult') class\.

```csharp
public GooShadingSolverResult();
```

<a name='DiGi.Solar.Rhino.Classes.GooShadingSolverResult.GooShadingSolverResult(DiGi.Solar.Interfaces.IShadingSolverResult)'></a>

## GooShadingSolverResult\(IShadingSolverResult\) Constructor

Initializes a new instance of the [GooShadingSolverResult](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingSolverResult 'DiGi\.Solar\.Rhino\.Classes\.GooShadingSolverResult') class with the specified shading solver result\.

```csharp
public GooShadingSolverResult(DiGi.Solar.Interfaces.IShadingSolverResult? shadingSolverResult);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Classes.GooShadingSolverResult.GooShadingSolverResult(DiGi.Solar.Interfaces.IShadingSolverResult).shadingSolverResult'></a>

`shadingSolverResult` [DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')

The shading solver result to be wrapped\.
### Properties

<a name='DiGi.Solar.Rhino.Classes.GooShadingSolverResult.Geometries'></a>

## GooShadingSolverResult\.Geometries Property

Gets the collection of geometries associated with the shading solver result\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.Rhino.Classes.GooShadingSolverResult.Duplicate()'></a>

## GooShadingSolverResult\.Duplicate\(\) Method

Creates a duplicate of the current shading solver result wrapper\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance representing the duplicated object\.

<a name='DiGi.Solar.Rhino.Classes.GooShadingSolverResultParam'></a>

## GooShadingSolverResultParam Class

Represents the Grasshopper parameter type used to handle [GooShadingSolverResult](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingSolverResult 'DiGi\.Solar\.Rhino\.Classes\.GooShadingSolverResult') objects within a component\.

```csharp
public class GooShadingSolverResultParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Solar.Rhino.Classes.GooShadingSolverResult, DiGi.Solar.Interfaces.IShadingSolverResult>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooShadingSolverResult](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingSolverResult 'DiGi\.Solar\.Rhino\.Classes\.GooShadingSolverResult')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooShadingSolverResult](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingSolverResult 'DiGi\.Solar\.Rhino\.Classes\.GooShadingSolverResult')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooShadingSolverResult](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.GooShadingSolverResult 'DiGi\.Solar\.Rhino\.Classes\.GooShadingSolverResult')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Solar\.Interfaces\.IShadingSolverResult](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.interfaces.ishadingsolverresult 'DiGi\.Solar\.Interfaces\.IShadingSolverResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooShadingSolverResultParam
### Properties

<a name='DiGi.Solar.Rhino.Classes.GooShadingSolverResultParam.ComponentGuid'></a>

## GooShadingSolverResultParam\.ComponentGuid Property

Gets the unique identifier for the shading solver result parameter component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the DiGi Solar Rhino plugin, inheriting from [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo')\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Solar.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the preferred contact details for the author\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Solar.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author or company\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Solar.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets a short string describing the purpose of this GHA library\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Solar.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets a 24x24 pixel bitmap to represent this GHA library\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.Solar.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for this assembly\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the GHA library\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Solar.Rhino.Classes.ShadingElement'></a>

## ShadingElement Class

Represents a Grasshopper component that creates a shading element based on a polygonal face\.

```csharp
public class ShadingElement : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ShadingElement
### Constructors

<a name='DiGi.Solar.Rhino.Classes.ShadingElement.ShadingElement()'></a>

## ShadingElement\(\) Constructor

Initializes a new instance of the [ShadingElement](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.ShadingElement 'DiGi\.Solar\.Rhino\.Classes\.ShadingElement') class\.

```csharp
public ShadingElement();
```
### Properties

<a name='DiGi.Solar.Rhino.Classes.ShadingElement.ComponentGuid'></a>

## ShadingElement\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.ShadingElement.Exposure'></a>

## ShadingElement\.Exposure Property

Gets the exposure level of the component, determining how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Solar.Rhino.Classes.ShadingElement.Inputs'></a>

## ShadingElement\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Solar.Rhino.Classes.ShadingElement.Outputs'></a>

## ShadingElement\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.Rhino.Classes.ShadingElement.SolveInstance(IGH_DataAccess)'></a>

## ShadingElement\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Classes.ShadingElement.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Solar.Rhino.Classes.ShadingFactor'></a>

## ShadingFactor Class

Represents a Grasshopper component that calculates the shading factor for a specific shading element at a given time using a specified shading model\.

```csharp
public class ShadingFactor : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ShadingFactor
### Constructors

<a name='DiGi.Solar.Rhino.Classes.ShadingFactor.ShadingFactor()'></a>

## ShadingFactor\(\) Constructor

Initializes a new instance of the [ShadingFactor](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.ShadingFactor 'DiGi\.Solar\.Rhino\.Classes\.ShadingFactor') class\.

```csharp
public ShadingFactor();
```
### Properties

<a name='DiGi.Solar.Rhino.Classes.ShadingFactor.ComponentGuid'></a>

## ShadingFactor\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.ShadingFactor.Exposure'></a>

## ShadingFactor\.Exposure Property

Gets the exposure of the component, which determines how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Solar.Rhino.Classes.ShadingFactor.Inputs'></a>

## ShadingFactor\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Solar.Rhino.Classes.ShadingFactor.Outputs'></a>

## ShadingFactor\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.Rhino.Classes.ShadingFactor.SolveInstance(IGH_DataAccess)'></a>

## ShadingFactor\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Classes.ShadingFactor.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Solar.Rhino.Classes.ShadingModel'></a>

## ShadingModel Class

Represents a Grasshopper component that creates and manages a solar shading model based on UTC coordinates and shading elements\.

```csharp
public class ShadingModel : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ShadingModel
### Constructors

<a name='DiGi.Solar.Rhino.Classes.ShadingModel.ShadingModel()'></a>

## ShadingModel\(\) Constructor

Initializes a new instance of the [ShadingModel](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.ShadingModel 'DiGi\.Solar\.Rhino\.Classes\.ShadingModel') class\.

```csharp
public ShadingModel();
```
### Properties

<a name='DiGi.Solar.Rhino.Classes.ShadingModel.ComponentGuid'></a>

## ShadingModel\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.ShadingModel.Exposure'></a>

## ShadingModel\.Exposure Property

Gets the exposure level of the component, determining how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Solar.Rhino.Classes.ShadingModel.Inputs'></a>

## ShadingModel\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Solar.Rhino.Classes.ShadingModel.Outputs'></a>

## ShadingModel\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.Rhino.Classes.ShadingModel.SolveInstance(IGH_DataAccess)'></a>

## ShadingModel\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Classes.ShadingModel.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverResults'></a>

## ShadingSolverResults Class

A Grasshopper component that retrieves shading solver results based on a specified shading model and optional parameters such as time, element, and solver type\.

```csharp
public class ShadingSolverResults : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ShadingSolverResults
### Constructors

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverResults.ShadingSolverResults()'></a>

## ShadingSolverResults\(\) Constructor

Initializes a new instance of the [ShadingSolverResults](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.ShadingSolverResults 'DiGi\.Solar\.Rhino\.Classes\.ShadingSolverResults') class\.

```csharp
public ShadingSolverResults();
```
### Properties

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverResults.ComponentGuid'></a>

## ShadingSolverResults\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverResults.Exposure'></a>

## ShadingSolverResults\.Exposure Property

Gets the exposure level of the component, which determines how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverResults.Inputs'></a>

## ShadingSolverResults\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverResults.Outputs'></a>

## ShadingSolverResults\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverResults.SolveInstance(IGH_DataAccess)'></a>

## ShadingSolverResults\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverResults.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverType'></a>

## ShadingSolverType Class

Represents a component used to select the shading solver type for solar analysis calculations\.

```csharp
public class ShadingSolverType : DiGi.Rhino.Core.Classes.EnumComponent<DiGi.Solar.Enums.ShadingSolverType>
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.EnumComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.enumcomponent-1 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\`1')[DiGi\.Solar\.Enums\.ShadingSolverType](https://learn.microsoft.com/en-us/dotnet/api/digi.solar.enums.shadingsolvertype 'DiGi\.Solar\.Enums\.ShadingSolverType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.enumcomponent-1 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\`1') → ShadingSolverType
### Constructors

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverType.ShadingSolverType()'></a>

## ShadingSolverType\(\) Constructor

Initializes a new instance of the [ShadingSolverType](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.ShadingSolverType 'DiGi\.Solar\.Rhino\.Classes\.ShadingSolverType') class\.

```csharp
public ShadingSolverType();
```
### Properties

<a name='DiGi.Solar.Rhino.Classes.ShadingSolverType.ComponentGuid'></a>

## ShadingSolverType\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.SunDirection'></a>

## SunDirection Class

Represents a Grasshopper component that calculates the sun direction based on geographic coordinates, UTC offset, and a specific date and time\.

```csharp
public class SunDirection : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → SunDirection
### Constructors

<a name='DiGi.Solar.Rhino.Classes.SunDirection.SunDirection()'></a>

## SunDirection\(\) Constructor

Initializes a new instance of the [SunDirection](DiGi.Solar.Rhino.Classes.md#DiGi.Solar.Rhino.Classes.SunDirection 'DiGi\.Solar\.Rhino\.Classes\.SunDirection') class\.

```csharp
public SunDirection();
```
### Properties

<a name='DiGi.Solar.Rhino.Classes.SunDirection.ComponentGuid'></a>

## SunDirection\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Solar.Rhino.Classes.SunDirection.Exposure'></a>

## SunDirection\.Exposure Property

Gets the exposure level of the component, which determines its visibility and behavior on the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Solar.Rhino.Classes.SunDirection.Inputs'></a>

## SunDirection\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Solar.Rhino.Classes.SunDirection.Outputs'></a>

## SunDirection\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Solar.Rhino.Classes.SunDirection.SolveInstance(IGH_DataAccess)'></a>

## SunDirection\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Solar.Rhino.Classes.SunDirection.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.