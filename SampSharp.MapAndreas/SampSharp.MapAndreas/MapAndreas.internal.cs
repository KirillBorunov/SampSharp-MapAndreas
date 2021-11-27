using SampSharp.Core.Natives.NativeObjects;

namespace SampSharp.MapAndreas
{
    partial class MapAndreas
    {

        protected static MapAnreasInternal Internal;

        static MapAndreas()
        {
            Internal = NativeObjectProxyFactory.CreateInstance<MapAnreasInternal>();
        }

        public class MapAnreasInternal
        {
            [NativeMethod(Function = "MapAndreas_Init")]
            public virtual int Init(int mode, string path)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod(Function = "MapAndreas_FindZ_For2DCoord")]
            public virtual int FindZ_For2DCoord(float x, float y, out float z)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod(Function = "MapAndreas_FindAverageZ")]
            public virtual int FindAverageZ(float x, float y, out float z)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod(Function = "MapAndreas_Unload")]
            public virtual int Unload()
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod(Function = "MapAndreas_SetZ_For2DCoord")]
            public virtual int SetZ_For2DCoord(float x, float y, float z)
            {
                throw new NativeNotImplementedException();
            }

            [NativeMethod(Function = "MapAndreas_SaveCurrentHMap")]
            public virtual int SaveCurrentHMap(string path)
            {
                throw new NativeNotImplementedException();
            }
        }

    }
}
