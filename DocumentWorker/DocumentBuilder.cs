using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using DocumentFormat.OpenXml.Office2010.Excel;

using Model.Project;

using TemplateEngine.Docx;

namespace DocumentWorker
{
    public class DocumentBuilder
    {
        public static Content BuildBlank(IssueRecord record, Information Information)
        {
            
            var content = new Content(new FieldContent("Header","Бланк"),
                                            new FieldContent("CompanyShortName",Information.OrganizaionShortName),
                                            new FieldContent("CompanyHeadPosition",Information.LeaderPosition),
                                            new FieldContent("CompanyHeadName", Information.LeaderFullName));

            var professionCounter = 0;
            var lastProfession = "";
            var table = new TableContent("IssueTable");
            foreach (Resource res in record.Resources)
            {
                if ( lastProfession!=res.Profession.Name )
                {
                    professionCounter++;
                    table.AddRow(new FieldContent("IssueNum", Convert.ToString(professionCounter)),
                                 new FieldContent("issueProfession", res.Profession.Name),
                                 new FieldContent("issueSizName", res.Equipment.Name),
                                 new FieldContent("issueSizCount", res.Count),
                                 new FieldContent("issueSizPeriod", res.Equipment.TermOfUse),
                                 new FieldContent("IssueOrder", res.Profession.OrderText));
                    lastProfession = res.Profession.Name;
                }
                else
                {
                    table.AddRow(new FieldContent("IssueNum", ""),
                                 new FieldContent("issueProfession", ""),
                                 new FieldContent("issueSizName", res.Equipment.Name),
                                 new FieldContent("issueSizCount", res.Count),
                                 new FieldContent("issueSizPeriod", res.Equipment.TermOfUse),
                                 new FieldContent("IssueOrder", ""));
                }
            }
            content.Tables.Add(table);
            return content;
        }

        public static void WriteDocument(Content values, string documentFileName)
        {
            using (TemplateProcessor outputDocument = new TemplateProcessor(documentFileName)
                    .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(values);
                outputDocument.SaveChanges();
            }
        }

        public static void PrepareDocument(string templateFileName, string newDocumentFileName)
        {
            File.Copy(templateFileName, newDocumentFileName, true);
        }


    }
}
