using System;
using System.IO;

using Microsoft.Office.Interop.Word;

using Model.Employee;
using Model.Equipments;
using Model.Project;

using TemplateEngine.Docx;

namespace DocumentWorker
{
    public class DocumentBuilder
    {
        /// <summary>
        /// Построение бланка.
        /// </summary>
        /// <param name="record"></param>
        /// <param name="information"></param>
        /// <returns></returns>
        public static Content BuildBlank(IssueRecord record, Information information)
        {
            
            var content = new Content(new FieldContent("Header","Бланк"),
                                            new FieldContent("CompanyShortName",information.OrganizaionShortName),
                                            new FieldContent("CompanyHeadPosition",information.LeaderPosition),
                                            new FieldContent("CompanyHeadName", information.LeaderFullName));

            var professionCounter = 0;
            var lastProfession = "";
            var table = new TableContent("IssueTable");
            foreach (Resource res in record.Resources)
            {
                if (res.Profession != null && lastProfession !=res.Profession.Name )
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

        /// <summary>
        /// Построение положения.
        /// </summary>
        /// <param name="information"></param>
        /// <returns></returns>
        public static Content BuildProvision(Information information)
        {

            var content = new Content(new FieldContent("Header", "Положение"),
                                      new FieldContent("CompanyShortName", information.OrganizaionShortName),
                                      new FieldContent("HeadPosition", information.LeaderPosition),
                                      new FieldContent("CompanyFullName", information.OrganizationFullName),
                                      new FieldContent("HeadName", information.LeaderFullName));
            return content;
        }

        public static Content BuildOrder(Information information)
        {

            var content = new Content(new FieldContent("CompanyShortName", information.OrganizaionShortName),
                                      new FieldContent("HeadPeopleThis", information.LeaderFullName == information.HeadPerson ? "собой" : information.HeadPerson),
                                      new FieldContent("HeadPosition", information.LeaderPosition),
                                      new FieldContent("CompanyFullName", information.OrganizationFullName),
                                      new FieldContent("CompanyCity",information.City),
                                      new FieldContent("HeadName", information.LeaderFullName));
            return content;
        }

        public static Content BuildPersonalCard(IEmployee employee, Information information)
        {
            var content = new Content(
                new FieldContent("Surname",employee.Surname),
                new FieldContent("Name", employee.Name),
                new FieldContent("MiddleName",employee.MiddleName),
                new FieldContent("PersonnelNumber", employee.PersonnelNumber),
                new FieldContent("StructuralUnit",employee.StructuralUnit),
                new FieldContent("Profession",employee.Profession.Name),
                new FieldContent("DateOfEmployment",employee.DateOfEmployment.ToShortDateString()),
                new FieldContent("DateChangePosition",employee.DateChangePosition.HasValue ? employee.DateChangePosition.Value.ToShortDateString() : "-"),
                new FieldContent("Sex", employee.Sex == Sex.Male ? "Муж" : "Жен"),
                new FieldContent("Growth",Convert.ToString(employee.Growth)),
                new FieldContent("ClothingSize",employee.ClothingSize),
                new FieldContent("ShoeSize", employee.ShoeSize),
                new FieldContent("GasmaskSize",employee.GasmaskSize),
                new FieldContent("RespiratorSize",employee.RespiratorSize),
                new FieldContent("GauntletsSize", employee.GauntletsSize),
                new FieldContent("GlovesSize", employee.GlovesSize),
                new FieldContent("OrganizationShortName",information.OrganizaionShortName)
                );

            var equipmentsTable = new TableContent("EquipmentsTable");
            var issueTable = new TableContent("IssueTable");

            var counter = 0;
            foreach (IEquipment equipment in employee.Profession.Equipments)
            {
                counter++;
                equipmentsTable.AddRow(
                    new FieldContent("Num",Convert.ToString(counter)),
                    new FieldContent("EqName",equipment.Name),
                    new FieldContent("OrderText",employee.Profession.OrderText),
                    new FieldContent("Units",equipment.Units),
                    new FieldContent("CountString",equipment.CountString)
                    );
                issueTable.AddRow(new FieldContent("IsName", equipment.Name));
            }

            content.Tables.Add(equipmentsTable);
            content.Tables.Add(issueTable);

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
