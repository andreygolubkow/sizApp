using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using DocumentFormat.OpenXml.Office2010.Excel;

using TemplateEngine.Docx;

namespace DocumentWorker
{
    public class SizListBlankDocument : IDisposable
    {

        public SizListBlankDocument()
        {
            var templateDocFileInfo = new FileInfo("SizListBlankDocument.dotx");



            var valuesToFill = new Content(
                                           new TableContent("IssueTable")
                                                   .AddRow(
                                                           new FieldContent("IssueNum", "1"),
                                                           new FieldContent("issueProfession", "Разработчик"),
                                                           new FieldContent("issueSizName", "Разработчик"),
                                                           new FieldContent("issueSizCount", "Разработчик"),
                                                           new FieldContent("issueSizPeriod", "Разработчик"),
                                                           new FieldContent("IssueOrder", "Разработчик")
                                                           )
                                                   .AddRow(
                                                           new FieldContent("IssueNum", ""),
                                                           new FieldContent("issueProfession", ""),
                                                           new FieldContent("issueSizName", "1"),
                                                           new FieldContent("issueSizCount", "1"),
                                                           new FieldContent("issueSizPeriod", "1"),
                                                           new FieldContent("IssueOrder", ""))
                                                   .AddRow(
                                                           new FieldContent("IssueNum", "2"),
                                                           new FieldContent("issueProfession", "1221"),
                                                           new FieldContent("issueSizName", "d"),
                                                           new FieldContent("issueSizCount", "d"),
                                                           new FieldContent("issueSizPeriod", "dd"),
                                                           new FieldContent("IssueOrder", "dd"))
                                          );

            using (var outputDocument = new TemplateProcessor("SizListBlankDocument.docx")
                    .SetRemoveContentControls(false))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }

        }

        private void WriteHeader()
        {
            var recordTable = new TableContent("recordTable");
            var recordNum = new FieldContent("recordNum", "1");
            var recordProfession = new FieldContent("recordProfession", "Плотник");
            var sizTable = new TableContent("sizTable");
            var sizName = new FieldContent("sizName", "Шапка");
            var sizCount = new FieldContent("sizCount", "10");
            var sizPeriod = new FieldContent("sizPeriod", "30");
            var recordOrder = new FieldContent("recordOrder", "JJG 1/2");
            sizTable.AddRow(sizName, sizCount, sizPeriod);
            recordTable.AddRow(recordNum, recordProfession, recordOrder);
            recordTable.AddRow(recordNum, recordProfession, recordOrder); recordTable.AddRow(recordNum, recordProfession, recordOrder);
            var valuesToFill = new Content(recordTable);
        }

        private void SaveDocument()
        {
            var MyTable = new TableContent("MyTable");
            var Nym = new FieldContent("Num", "Num");
            var mySubTable = new TableContent("MySubTable");
            var sa = new FieldContent("SA", "s1");
            var sb = new FieldContent("SB", "s2");

            mySubTable.AddRow(sa, sb);
            MyTable.AddRow(Nym, mySubTable);
        }

    #region IDisposable

        /// <summary>Выполняет определяемые приложением задачи, связанные с высвобождением или сбросом неуправляемых ресурсов.</summary>
        public void Dispose()
        {
            
        }

        #endregion
    }
}
