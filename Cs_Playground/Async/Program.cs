using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cs_Playground.Inheritance;
using Cs_Playground.Async;
using Cs_Playground.DesignPattern;

namespace Cs_Playground
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //var jsonTask = GetJsonAsync();
            //int i = jsonTask.Result;
            //Console.WriteLine(jsonTask.Result);


            //custom async experiment

            //var task = Task.Run(async () => await ReturnIntAsync());
            //TestCustomAsync().Wait();
            //var task = TestCustomAsync();
            //Console.WriteLine("after result");
            //Console.WriteLine(task.Result);
            //AlgorithmA a = new AlgorithmA();
            //a.FinishOneTask();
            //AlgorithmAsyncInstance a = new AlgorithmAsyncInstance();
            //a.FinishOneTask();
            //new Jeep(new ManualShift()).Print();
            //new BMW(new AutomaticShift()).Print();

            //adapter pattern
            //new V1Player().Play("mp3", "name");
            //new V2Player().Play("mp3", "name");

            //Criterion pattern
            List<Clothes> clothesList = new List<Clothes>(); 

            clothesList.Add(new Clothes("topping", "white", "male"));
            clothesList.Add(new Clothes("topping", "black", "male"));
            clothesList.Add(new Clothes("topping", "blue", "female"));
            clothesList.Add(new Clothes("dress", "white", "female"));
            clothesList.Add(new Clothes("dress", "black", "female"));
            clothesList.Add(new Clothes("dress", "blue", "female"));

            ClothesCriterion male = new MaleClothesCriterion();

            ClothesCriterion topping = new ToppingClothesCriterion();
            ClothesCriterion maleAndTopping = new AndCriterion(male, topping);


           
            printCothes(male.chooseClothes(clothesList));

            printCothes(topping.chooseClothes(clothesList));

            printCothes(maleAndTopping.chooseClothes(clothesList));
                       

        }

        #region Await order test
        private static async Task LoadMesh()
        {
            await LoadCustomHeadsFromOBN();
            Console.WriteLine("continue ClearHeadConstructionBlendshape");
        }

        private static async Task LoadCustomHeadsFromOBN()
        {
            await LoadMeshesFromOBN();
        }


        private static async Task LoadMeshesFromOBN()
        {
            //Thread.Sleep(5000);
            await Task.Run(() =>
            {
                //Heacy calculation
                Thread.Sleep(6000);
            });
            Console.WriteLine("calculation finishes!");
        }
        #endregion

        #region Task
        /// <summary>
        ///  Task can return value, but Thread cannot
        /// </summary>
        public static void Test()
        {
            Console.WriteLine("Before call task");
            var strRes = Task.Run<string>(() => { return GetReturnResult(); });

            //This will block
            Console.WriteLine(strRes.Result);


            Console.WriteLine("After call task");

            Thread.Sleep(6000);
        }
        static string GetReturnResult()
        {
            Console.WriteLine("About to sleep");
            Thread.Sleep(5000);
            Console.WriteLine("Sleep finish");
            return "this is return";
        }
        #endregion

        #region Deadlock
        public static void TestDeadlock()
        {
            // Start the delay.
            var delayTask = DelayAsync();
            // Wait for the delay to complete.
            delayTask.Wait();
        }

        private static async Task DelayAsync()
        {
            await Task.Delay(1000);
        }

        // My "library" method.
        public static async Task<int> GetJsonAsync()
        {
            var jsonString = await ReturnIntAsync();
            return jsonString;
        }

        public static async Task<int> ReturnIntAsync()
        {
            int i = 0;
            await Task.Delay(2000);
            return i;
        }

        #endregion

        #region Custom async
        private static async Task<int> TestCustomAsync() {
            int result = await new Func<int>(() => 0);
            return result;
            
        }
        #endregion

        public static void printCothes(List<Clothes> clothesList) {
   
        foreach (Clothes clothes in clothesList) {
                Console.WriteLine("Clothes : [ ClothesColor : " + clothes.ClothesColor + ", ClothesGender : " + clothes.ClothesGender + ", ClothesType : " + clothes.ClothesType + " ]");
        }
        }  

    }

}

