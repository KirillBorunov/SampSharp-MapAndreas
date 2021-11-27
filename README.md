# SampSharp-MapAndreas

[MapAndreas](https://github.com/philip1337/samp-plugin-mapandreas) plugin wrapper for [SampSharp](https://github.com/ikkentim/sampsharp).

## Instalation

- Add the MapAndreas plugin and the heightmaps files to your SAMP server.
- Install nuget package: https://www.nuget.org/packages/SampSharp.MapAndreas/1.0.0

## Example

Initialize MapAndreas and get a position.

```Csharp
protected override void OnInitialized(EventArgs e)
{
    base.OnInitialized(e);
    
    // Get the service (you can get it everywhere where you can access the GameMode instance)
    var mapAndreas = Services.GetService<IMapAndreas>();

    // Initialize (you need to do this only once, when the GameMode initialized)
    mapAndreas.Init(MapAndreasMode.Full, "scriptfiles\\SAfull.hmap");

    // Find a position
    var z = mapAndreas.FindAverageZ(new Vector2(20.001f, 25.006f));
    if (z != null)
    {
        // A position was found, saved in z.Value
    }
}
```
