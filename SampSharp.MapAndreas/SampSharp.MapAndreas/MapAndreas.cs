using SampSharp.GameMode;
using SampSharp.MapAndreas.Definitions;
using System;

[assembly: SampSharpExtension(typeof(SampSharp.MapAndreas.MapAndreas))]

namespace SampSharp.MapAndreas
{

    public partial class MapAndreas : Extension, IMapAndreas
    {

        public void Init(MapAndreasMode mode, string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
            if (Internal.Init((int)mode, path) != 1) throw new Exception("Failed to initialize. Ensure that the file exists and the process has access to it.");
        }

        public void MapAndreas_Unload()
        {
            if (Internal.Unload() != 1) throw new Exception("Failed to unload.");
        }


        public float? FindAverageZ(Vector2 coord)
        {
            if(Internal.FindAverageZ(coord.X, coord.Y, out var z) != 1) return null;
            return z;
        }

        public float? FindZ_For2DCoord(Vector2 coord)
        {
            if (Internal.FindZ_For2DCoord(coord.X, coord.Y, out var z) != 1) return null;
            return z;
        }


        public void SetZ_For2DCoord(Vector3 coord)
        {
            if (Internal.SetZ_For2DCoord(coord.X, coord.Y, coord.Z) != 1) throw new Exception("Failed to set the height at the specified coordinates.");
        }

        public void SaveCurrentHMap(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
            if(Internal.SaveCurrentHMap(path) != 1) throw new Exception("Failed to save. Ensure that the process has write access to the file.");
        }

        #region Implementation of IService

        /// <summary>
        ///     Gets the game mode.
        /// </summary>
        public BaseMode GameMode { get; private set; }

        #endregion

        #region Overrides of Extension

        /// <summary>
        ///     Loads services provided by this extensions.
        /// </summary>
        /// <param name="gameMode">The game mode.</param>
        public override void LoadServices(BaseMode gameMode)
        {
            GameMode = gameMode;
            gameMode.Services.AddService<IMapAndreas>(this);

            base.LoadServices(gameMode);
        }

        #endregion

    }
}
