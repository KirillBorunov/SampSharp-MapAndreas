using SampSharp.GameMode;
using SampSharp.MapAndreas.Definitions;

namespace SampSharp.MapAndreas
{
    public interface IMapAndreas : IService
    {
        void Init(MapAndreasMode mode, string path);
        void MapAndreas_Unload();

        float? FindZ_For2DCoord(Vector2 coord);
        float? FindAverageZ(Vector2 coord);

        void SetZ_For2DCoord(Vector3 coord);
        void SaveCurrentHMap(string path);
    }
}
