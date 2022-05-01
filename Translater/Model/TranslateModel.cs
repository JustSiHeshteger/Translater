using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace Translater.Model
{
    internal class TranslateModel
    {
        private string _token;
        private string _originalMessage;
        private string _targetLanguage;
        private Rootobject _result;

        public string Token
        {
            get
            {
                if (_token == null || string.IsNullOrWhiteSpace(_token))
                    throw new Exception("Нет токена для авторизации");

                return _token;
            }
            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Был передан неверный токен авторизации");

                _token = value;
            }
        }
        public string OriginalMessage
        {
            get 
            {
                if (_originalMessage == null || string.IsNullOrWhiteSpace(_originalMessage))
                    throw new Exception("Нет сообщения для перевода");

                return _originalMessage;
            }
            set 
            {
                if (_originalMessage == null || string.IsNullOrWhiteSpace(_originalMessage))
                    throw new Exception("Нет сообщения для перевода");

                _originalMessage = value;
            } 
        }
        public string TargetLanguage
        {
            get
            {
                if (_targetLanguage == null || string.IsNullOrWhiteSpace(_targetLanguage))
                    throw new Exception("Не выбран язык, на который нужно перевести");

                return _targetLanguage;
            }
            set => _targetLanguage = value;
        }
        public Rootobject Result 
        { 
            get
            {
                if (_result == null)
                    throw new Exception("Невозможно перевести текст");
                
                return _result;
            }
            private set => _result = value;
        }

        public TranslateModel(string token)
        {
            this.Token = token;
        }

        public void GetTranslate(string message, string targetLanguage)
        {
            var json = new JavaScriptSerializer().Serialize(new //Параметры http запроса в форсате json
            {
                targetLanguageCode = targetLanguage,
                texts = message,
                folderId = Properties.Settings.Default.Folder,
            });

            var request = new WebRequestForTranslate() //Создание экземпляра класса с указанием его свойств
            {
                Token = this.Token,
                URL = Properties.Settings.Default.URL,
                JSON = json,
                Method = "POST"
            };

            try
            {
                Result = new JavaScriptSerializer().Deserialize<Rootobject>(request.GetRequest());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void GetTranslate()
        {
            var json = new JavaScriptSerializer().Serialize(new //Параметры http запроса в формате json
            {
                targetLanguageCode = this._targetLanguage,
                texts = this._originalMessage,
                folderId = Properties.Settings.Default.Folder,
            });

            var request = new WebRequestForTranslate() //Создание экземпляра класса с указанием его свойств
            {
                Token = this.Token,
                URL = Properties.Settings.Default.URL,
                JSON = json,
                Method = "POST"
            };

            try
            {
                Result = new JavaScriptSerializer().Deserialize<Rootobject>(request.GetRequest());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
