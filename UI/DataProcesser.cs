using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;


namespace UI.DataProcesser
{
    public class DataProcesser
    {
        public List<string> Paths { get; set; }

        public void GetRowsFromDocx()
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
            string filePath = "";
            object fileName = filePath;
            // Define an object to pass to the API for missing parameters
            object missing = System.Type.Missing;
            doc = word.Documents.Open(ref fileName,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            string read = string.Empty;
            List<string> data = new List<string>();
            for (int i = 0; i < doc.Paragraphs.Count; i++)
            {
                string temp = doc.Paragraphs[i + 1].Range.Text.Trim();
                if (temp != string.Empty)
                    data.Add(temp);
            }
            ((Microsoft.Office.Interop.Word._Document)doc).Close();
            ((Microsoft.Office.Interop.Word._Application)word).Quit();
        }
    }
}
