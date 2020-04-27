using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace DLLTestSampleCSharp
{
    class Program
    {
        [DllImport("Project.dll")]
        public static extern void readBoards([In,Out] int [] arr,[In,Out]int []indices,[In,Out]int []solultion,int n1);

        [DllImport("Project.dll")]
        public static extern void readingProcess();
        [DllImport("Project.dll")]
        public static extern void copyToArray();
        [DllImport("Project.dll")]
        public static extern void loadIndeces();
        [DllImport("Project.dll")]
        public static extern void saveBoard([In, Out] int[] arr, [In, Out]int[] solultion, [In, Out]int[] indices);
        [DllImport("Project.dll")]
        public static extern void moveArrToBuffer();
        [DllImport("Project.dll")]
        public static extern void writingProcess();
        [DllImport("Project.dll")]
        public static extern int RandomBoard();
        [DllImport("Project.dll")]
        public static extern int check([In, Out] int[] arrBoard, [In, Out]int[] arrSol,int index , int val);
        [DllImport("Project.dll")]
        public static extern int getrightCount();
        [DllImport("Project.dll")]
        public static extern int getwrongCount();
        [DllImport("Project.dll")]
        public static extern int getstepsToFinish();
        [DllImport("Project.dll")]
        public static extern int solve([In, Out] int[] arrBoard, [In, Out]int[] arrSol, [In, Out]int[] indcies, int index);
        [DllImport("Project.dll")]
        public static extern void clearboard([In, Out] int[] arrBoard, [In, Out]int[] arrSol);
        [DllImport("Project.dll")]
        public static extern void clearReport();
        
        [DllImport("Project.dll")]
        public static extern void startTimer();

        [DllImport("Project.dll")]
        public static extern void stopTimer();

        [DllImport("Project.dll")]
        public static extern void updateTime();

        [DllImport("Project.dll")]
        public static extern int getMins();

        [DllImport("Project.dll")]
        public static extern int getS();

        [DllImport("Project.dll")]
        public static extern void savereport();

        [DllImport("Project.dll")]
        public static extern void loadreport();

               
        [DllImport("Project.dll")]
        public static extern int plotloaded([In, Out] int[] arrBoard, [In, Out]int[] arrSol, [In, Out]int[] indcies, int index);


        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
           
        }
    }
}
