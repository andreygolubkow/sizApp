using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class SizListBlankDocument : IDisposable
    {
        private Microsoft.Office.Interop.Word.Application _wordApp;
        private Microsoft.Office.Interop.Word.Document _document;
        private object _missing;

        public SizListBlankDocument()
        {
            _wordApp = new Microsoft.Office.Interop.Word.Application();
            _missing = System.Reflection.Missing.Value;
            _document = _wordApp.Documents.Add(ref _missing, ref _missing, ref _missing, ref _missing);
            WriteHeader();
        }

        private void WriteHeader()
        {
            //Добавление текста со стилем Заголовок 1
            Microsoft.Office.Interop.Word.Paragraph para1 = _document.Content.Paragraphs.Add(ref _missing);
            object styleHeading1 = "Заголовок 1";
            para1.Range.set_Style(styleHeading1);
            para1.Range.Text = "Бланк выдачи СИЗ";
            para1.Range.InsertParagraphAfter();
            _wordApp.Visible = true;
        }

        private void SaveDocument()
        {
            object filename = @"d:\temp1.docx";
            _document.SaveAs(ref filename);
            //Закрытие текущего документа
            _document.Close(ref _missing, ref _missing, ref _missing);
            _document = null;
            //Закрытие приложения Word
            _wordApp.Quit(ref _missing, ref _missing, ref _missing);
            _wordApp = null;
        }

    #region IDisposable

        /// <summary>Выполняет определяемые приложением задачи, связанные с высвобождением или сбросом неуправляемых ресурсов.</summary>
        public void Dispose()
        {
            _wordApp.Quit(ref _missing, ref _missing, ref _missing);
            _wordApp = null;
        }

        #endregion
    }
}
