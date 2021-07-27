using System;

namespace ch3_sec27_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var t = new MyType();
            t.UpdateMarker();
            Console.WriteLine(t.Marker.ToString());

            var t2 = new MyType2();
            t2.UpdateMarker();
            Console.WriteLine(t2.Marker.ToString());
        }

        class MyType : IFoo
        {
            public int Marker { get; set; }
            public void UpdateMarker() => this.NextMarker();
        }

        class MyType2 : IFoo
        {
            public int Marker { get; set; }
            public void NextMarker() => Marker += 5;
            public void UpdateMarker() => this.NextMarker();
        }
    }
}
