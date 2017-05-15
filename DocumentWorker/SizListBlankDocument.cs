using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using TemplateEngine.Docx;

namespace DocumentWorker
{
    public class SizListBlankDocument : IDisposable
    {

        public SizListBlankDocument()
        {
            var templateDocFileInfo = new FileInfo("SizListBlankDocument.dotx");

            var repeatBlock = new TableContent("SizTable");
            var sizNum = new FieldContent("SizNum","1");
            var sizProfessionName = new FieldContent("SizProfessionName", "Профессия");
            var sizList = new RepeatContent("SizList");
            var sizName = new FieldContent("SizName", "Название СИЗ");
            var sizCount = new FieldContent("SizCount","10");
            var sizPeriod = new FieldContent("SizPeriod", "10");
            sizList.AddItem(sizName, sizCount, sizPeriod);
            var sizOrder = new FieldContent("SizOrder","Приказ ОО1");
            repeatBlock.AddRow(sizNum);
            repeatBlock.AddRow(sizProfessionName);
            repeatBlock.AddRow(sizList);
            repeatBlock.AddRow(sizOrder);
            var valuesToFill = new Content(repeatBlock);
            using (var outputDocument = new TemplateProcessor("SizListBlankDocument.docx")
                    .SetRemoveContentControls(false))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }

        }

        private void WriteHeader()
        {
            
        }

        private void SaveDocument()
        {
            
        }

    #region IDisposable

        /// <summary>Выполняет определяемые приложением задачи, связанные с высвобождением или сбросом неуправляемых ресурсов.</summary>
        public void Dispose()
        {
            
        }

        #endregion
    }
}
