using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Model
{
    public class CharacterModel
    {
        private string _name;
        private string _surname;

        private string _characterFirst;
        private string _characterSecond;
        private string _characterThird;
        private string _characterFourth;
        private string _characterFifth;
        private string _characterSixth;

        private string _talantsForEducation;
        private string _motivation;
        private string _perfomance;

        private string _interests;

        private string _allLife;
        private string _lifeWork;

        private string _placeInClass;
        private string _styleInClass;

        private string _teacherAttitude;
        private string _reaction;

        private string _status;
        private string _climat;
        private string _parenting;

        public string Name 
        { 
            get
            {
                if (string.IsNullOrWhiteSpace(_name))
                    return "";

                return _name;
            } 
            set => _name = value; 
        }
        public string Surname 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_surname))
                    return "";

                return _surname;
            }
            set => _surname = value; 
        }

        #region характеристики
        public string CharacterFirst 
        { 
            get => _characterFirst; 
            set => _characterFirst = value; 
        }
        public string CharacterSecond 
        {
            get => _characterSecond;
            set => _characterSecond = value;
        }
        public string CharacterThird
        { 
            get => _characterThird; 
            set => _characterThird = value;
        }
        public string CharacterFourth
        { 
            get => _characterFourth; 
            set => _characterFourth = value; 
        }
        public string CharacterFifth 
        { 
            get => _characterFifth; 
            set => _characterFifth = value; 
        }
        public string CharacterSixth 
        { 
            get => _characterSixth; 
            set => _characterSixth = value;
        }
        #endregion

        public string TalantsForEducation 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_talantsForEducation))
                    return "";

                return $"Способности к обучению {_talantsForEducation}";
            } 
            set => _talantsForEducation = value; 
        }
        public string Motivation 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_motivation))
                    return "";

                return $"мотивация к обучению {_motivation}";
            }
            set => _motivation = value; 
        }
        public string Perfomance 
        {
            get => _perfomance; 
            set => _perfomance = value; 
        }

        public string Interests
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_interests))
                    return "";
                return $"Увлекается {_interests}";
            }
            set => _interests = value; 
        }

        public string AllLife 
        {
            get
            {
                if (_allLife == "не участвует")
                    return "В общественных делах участвовать отказывается.";

                return $"Принимает {_allLife} в общественной жизни.";
            }
            set => _allLife = value; 
        }
        public string LifeWork 
        { 
            get
            {
                if (_lifeWork == "берется охотно")
                    return "Любую работу ученик всегда выполняет охотно.";

                return "Чаще всего старается уклониться от любой работы.";
            }
            set => _lifeWork = value;
        }

        public string PlaceInClass
        {
            get
            {
                if (_placeInClass == "лидер")
                    return "Является лидером класса.";

                if(_placeInClass == "популярный")
                    return "Является популярным членом коллектива.";

                if (_placeInClass == "приятный")
                    return "В классе ребята относятся к нему с симпатией.";

                if (_placeInClass == "непопулярный")
                    return "В коллективе популярностью не пользуется.";

                if (_placeInClass == "изолированный")
                    return "В коллективе ни с кем не общается.";

                return "В коллективе ни кто не хочет с ним общаться.";
            }
            set => _placeInClass = value;
        }
        public string StyleInClass 
        {
            get
            {
                if (_styleInClass == "доброжелательный")
                    return "Со сверстниками поддерживает спокойно-доброжелательные отношения.";

                if (_styleInClass == "агрессивный")
                    return "Со сверстниками ведет себя агрессивно.";

                return "Стиль отношений со сверстниками неустойчивый.";
            }
            set => _styleInClass = value;
        }

        public string TeacherAttitude
        {
            get 
            {
                if (_teacherAttitude == "вежлив")
                    return "С учителями вежлив.";

                if (_teacherAttitude == "бывает груб")
                    return "В общении с учителями бывает груб.";

                return "Постоянно грубит учителям.";
            } 
            set => _teacherAttitude = value; 
        }
        public string Reaction 
        {
            get 
            {
                if (_reaction == "спокойная")
                    return "На замечания учителей реагирует спокойно.";

                if (_reaction == "непредсказуемая")
                    return "Реакция на замечания учителей непредсказуемая.";

                if (_reaction == "агрессивная")
                    return "На замечания учителей реагирует агрессивно.";

                return "Замечания учителей выслушивает спокойно, но ни каких выводов для себя не делает.";
            } 
            set => _reaction = value; 
        }

        public string Status 
        {
            get 
            {
                if (_status == "полная")
                    return "Ученик воспитывается в полной семье.";

                if (_status == "неполная")
                    return "Ученик воспитывается в неполной семье.";

                return "Ученик проживает с опекуном.";
            }
            set => _status = value;
        }
        public string Climat 
        {
            get 
            {
                if (_climat == "положительный")
                    return "Отношения в семье хорошие. Общая атмосфера взаимоотношений в семье дружелюбная, атмосфера согласия и понимания.";

                if (_climat == "неустойчивый")
                    return "Психологический климат в семье неустойчивый.";

                return "Психологический климат, особенности взаимоотношений между членами семьи неблагоприятные, имеют место конфликты в семье.";
            }
            set => _climat = value; 
        }
        public string Parenting 
        {
            get 
            {
                if (_parenting == "демократическое")
                    return "Воспитание в семье демократическое. Учитываются интересы ребенка; воспитывается в нем дисциплинированность, самостоятельность, инициативность.";

                if (_parenting == "авторитарное")
                    return "Воспитание в семье авторитарное. Требуется от ребенка беспрекословное подчинение, жесткий контроль всех сфер его жизни.";

                if (_parenting == "гиперопека")
                    return "В воспитании ребенка преобладает гиперопека. О ребенке чрезмерно заботятся, ограждают его от любых трудностей и забот, при этом присутствует чрезмерный контроль.";

                return "Воспитание в семье либерально-попустительское. Безразличное отношение и отсутствие какого-либо контроля. Ребенок предоставлен сам себе.";
            } 
            set => _parenting = value;
        }

        public string GetCharacter()
        {
            string character = $"За время обучения {Surname} {Name} проявил себя {CharacterFirst}, {CharacterSecond}, " +
                               $"{CharacterThird}, {CharacterFourth}, {CharacterFifth}, {CharacterSixth} учеником.\r\n" + 
                               $"{TalantsForEducation}, {Motivation}, {Perfomance}.\r\n" +
                               $"{Interests}" +
                               $"{AllLife} {LifeWork} {PlaceInClass} {StyleInClass} {TeacherAttitude} {Reaction}\r\n" +
                               $"{Status} {Climat} {Parenting}";
            return character;
        }
    }
}
