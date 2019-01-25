using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cs_Playground
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("before first task!");
            LoadMesh();
                              Console.WriteLine("after first task!");
            Thread.Sleep(7000);
        }

        private static async Task LoadMesh() {
            await LoadCustomHeadsFromOBN();
            Console.WriteLine("continue ClearHeadConstructionBlendshape");
        }

        private static async Task LoadCustomHeadsFromOBN() {
            await LoadMeshesFromOBN();
        }


        private static async Task LoadMeshesFromOBN() {
            //Thread.Sleep(5000);
            await Task.Run(() =>
            {
                //Heacy calculation
                Thread.Sleep(6000);
            });
            Console.WriteLine("calculation finishes!");
        }



    }
}
