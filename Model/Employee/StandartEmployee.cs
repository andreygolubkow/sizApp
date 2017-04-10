namespace Model.Employee
{
    using System;

    using Model.Professions;

    public class StandartEmployee : IEmployee
    {
        private string _surname;
        private string _name;
        private string _middleName;
        private string _personnelNumber;
        private string _structuralUnit;
        private IProfession _profession;
        private DateTime _dateOfEmployment;
        private DateTime? _dateChangePosition;
        private Sex _sex;
        private double _growth;
        private string _clothingSize;
        private string _shoeSize;
        private string _headgearSize;
        private string _gasmaskSize;
        private string _respiratorSize;
        private string _gauntletsSize;
        private string _glovesSize;
        private int _id;

        #region Implementation of IEmployee

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Ошибка в идентификаторе.");
                }
                _id = value;
            }
        }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ( value.Length == 0 )
                {
                    throw new ArgumentException("Имя должно быть заполнено.");
                }
                _name = value;

            }
        }

        /// <summary>
        /// Отчество.
        /// </summary>
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
            }
        }

        /// <summary>
        /// Табельный номер.
        /// </summary>
        public string PersonnelNumber
        {
            get
            {
                return _personnelNumber;
            }
            set
            {
                _personnelNumber = value;
            }
        }

        /// <summary>
        /// Структурное подразделение.
        /// </summary>
        public string StructuralUnit
        {
            get
            {
                return _structuralUnit;
            }
            set
            {
                _structuralUnit = value;
            }
        }

        /// <summary>
        /// Профессия.
        /// </summary>
        public IProfession Profession
        {
            get
            {
                return _profession;
            }
            set
            {
                if ( value == null )
                {
                    throw new ArgumentException("Нужна профессия.");
                }
                _profession = value;
            }
        }

        /// <summary>
        /// Дата устройства на работу.
        /// </summary>
        public DateTime DateOfEmployment
        {
            get
            {
                return _dateOfEmployment;
            }
            set
            {
                _dateOfEmployment = value;
            }
        }

        /// <summary>
        /// Дата изменения должности.
        /// </summary>
        public DateTime? DateChangePosition
        {
            get
            {
                return _dateChangePosition;
            }
            set
            {
                _dateChangePosition = value;
            }
        }

        /// <summary>
        /// Пол.
        /// </summary>
        public Sex Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }

        /// <summary>
        /// Рост.
        /// </summary>
        public double Growth
        {
            get
            {
                return _growth;
            }
            set
            {
                _growth = value;
            }
        }

        /// <summary>
        /// Размер одежды.
        /// </summary>
        public string ClothingSize
        {
            get
            {
                return _clothingSize;
            }
            set
            {
                _clothingSize = value;
            }
        }

        /// <summary>
        /// Размер обуви.
        /// </summary>
        public string ShoeSize
        {
            get
            {
                return _shoeSize;
            }
            set
            {
                _shoeSize = value;
            }
        }

        /// <summary>
        /// Размер головного убора.
        /// </summary>
        public string HeadgearSize
        {
            get
            {
                return _headgearSize;
            }
            set
            {
                _headgearSize = value;
            }
        }

        /// <summary>
        /// Размер противогаза.
        /// </summary>
        public string GasmaskSize
        {
            get
            {
                return _gasmaskSize;
            }
            set
            {
                _gasmaskSize = value;
            }
        }

        /// <summary>
        /// Размер респиратора.
        /// </summary>
        public string RespiratorSize
        {
            get
            {
                return _respiratorSize;
            }
            set
            {
                _respiratorSize = value;
            }
        }

        /// <summary>
        /// Размер рукавиц.
        /// </summary>
        public string GauntletsSize
        {
            get
            {
                return _gauntletsSize;
            }
            set
            {
                _gauntletsSize = value;
            }
        }

        /// <summary>
        /// Размер перчаток.
        /// </summary>
        public string GlovesSize
        {
            get
            {
                return _glovesSize;
            }
            set
            {
                _glovesSize = value;
            }
        }

        #endregion
    }
}