using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace _06.EXCELlent_Knowledge
{
    public class EXCELlent_Knowledge
    {
        public static void Main()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWoorkbook = xlApp.Workbooks.Open(@"C:\Users\Kostadin\"+
            @"Desktop\C#Projects\1.ProgrFund - May 2017\22. Classes-and-Files-More-Exercises\"+
            @"06.  EXCELlent Knowledge\bin\Debug\sample_table.xlsx");

            Excel._Worksheet xlWorksheet = xlWoorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            var cellValueList = new List<string>();

            for (int i = 1; i <= rowCount; i++)
            {

                for (int j = 1; j <= colCount; j++)
                {             

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "|");

                        var cellValue = xlRange.Cells[i, j].Value2.ToString();
                        cellValueList.Add(cellValue);

                        if (j == 1 && i != 1)
                        {
                            Console.WriteLine();
                        }
                    }
                   
                }
            }

            Console.WriteLine();

            //write the values to the output.txt
            var outputText = string.Join("|", cellValueList);
            File.WriteAllText("output.txt", outputText + "|");

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process
            //from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWoorkbook.Close();
            Marshal.ReleaseComObject(xlWoorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
