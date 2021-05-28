using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;


namespace UI.DataProcesser
{
    public class DocumetProcesser
    {
        public List<string> Paths { get; set; }

        public void GetRowsFromDocx()
        {
            foreach (var path in Paths)
            {
                var word = new Microsoft.Office.Interop.Word.Application();
                object objPath = path;
                // Define an object to pass to the API for missing parameters
                var missing = Type.Missing;
                var doc = word.Documents.Open(ref objPath,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing);

                var read = string.Empty;
                var data = new List<string>();
                for (int i = 0; i < doc.Paragraphs.Count; i++)
                {
                    var temp = doc.Paragraphs[i + 1].Range.Text.Trim();
                    if (temp != string.Empty)
                        data.Add(temp);
                }
                ((Microsoft.Office.Interop.Word._Document)doc).Close();
                ((Microsoft.Office.Interop.Word._Application)word).Quit();
            }
            
        }
    }
}
