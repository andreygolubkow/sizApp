namespace Model.Employee
{
    using System;

    using Professions;

    public interface IEmployee
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        string Surname { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        string MiddleName { get; set; }

        /// <summary>
        /// Табельный номер.
        /// </summary>
        string PersonnelNumber { get; set; }

        /// <summary>
        /// Структурное подразделение.
        /// </summary>
        string StructuralUnit { get; set; }

        /// <summary>
        /// Профессия.
        /// </summary>
        IProfession Profession { get; set; }

        /// <summary>
        /// Дата устройства на работу.
        /// </summary>
        DateTime DateOfEmployment { get; set; }

        /// <summary>
        /// Дата изменения должности.
        /// </summary>
        DateTime? DateChangePosition { get; set; }

        /// <summary>
        /// Пол.
        /// </summary>
        Sex Sex { get; set; }

        /// <summary>
        /// Рост.
        /// </summary>
        double Growth { get; set; }

        /// <summary>
        /// Размер одежды.
        /// </summary>
        string ClothingSize { get; set; }

        /// <summary>
        /// Размер обуви.
        /// </summary>
        string ShoeSize { get; set; }

        /// <summary>
        /// Размер головного убора.
        /// </summary>
        string HeadgearSize { get; set; }

        /// <summary>
        /// Размер противогаза.
        /// </summary>
        string GasmaskSize { get; set; }

        /// <summary>
        /// Размер респиратора.
        /// </summary>
        string RespiratorSize { get; set; }

        /// <summary>
        /// Размер рукавиц.
        /// </summary>
        string GauntletsSize { get; set; }

        /// <summary>
        /// Размер перчаток.
        /// </summary>
        string GlovesSize { get; set; }

    }
}