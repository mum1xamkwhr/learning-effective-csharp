using System;

namespace ch3_sec27_extension_methods
{
    public static class FooExtensions
    {
        public static void NextMarker(this IFoo thing)
        {
            thing.Marker += 1;
        }
    }
}
