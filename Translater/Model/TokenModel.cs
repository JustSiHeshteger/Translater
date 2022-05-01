using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Translater.Model
{
    internal class TokenModel
    {
        private string[] _executeResult;
        private string _token;
        private readonly string _commandGetToken = "$yandexPassportOauthToken = \"AQAAAAAs4nSBAATuweBUScGhBUi9hjvHfqSCZcg\"\n" +
                                          "$Body = @{ yandexPassportOauthToken = \"$yandexPassportOauthToken\" } | ConvertTo-Json -Compress\n" +
                                          "Invoke-RestMethod -Method 'POST' -Uri 'https://iam.api.cloud.yandex.net/iam/v1/tokens' -Body $Body -ContentType 'Application/json' | Select-Object -ExpandProperty iamToken\n";
        
        
        public string[] ExecuteResult
        {
            get => _executeResult;
            set => _executeResult = value;
        }
        public bool Successful { get; set; }
        public string Token
        {
            get => _token;
            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                    Successful = false;

                _token = value;
            }
        }


        /// <summary>
        /// Взятие токена с сервиса через powershell
        /// </summary>
        public void GetToken(IProgress<string> progress)
        {
            try
            {
                progress.Report("Получение токена");
                Successful = true;
                using (var process = Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell",
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }))
                {

                    using (var sw = new StreamWriter(process.StandardInput.BaseStream))
                    {
                        sw.Write(_commandGetToken);
                    }

                    process.WaitForExit();

                    string[] str = process.StandardOutput.ReadToEnd().Trim().Split('\n');
                    Token = str[str.Length - 2].TrimEnd('\r');
                }
            }
            catch (Exception ex)
            {
                Successful = false;
                progress.Report(ex.Message);
            }
        }

        /// <summary>
        /// Выполнение любой операции в powershell
        /// </summary>
        /// <param name="command">Команда для powershell</param>
        public void ExecuteCommand(string command)
        {
            try
            {
                Successful = true;
                using (var process = Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell",
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }))
                {
                    using (var sw = new StreamWriter(process.StandardInput.BaseStream))
                    {
                        sw.Write(command);
                    }

                    process.WaitForExit();

                    ExecuteResult = process.StandardOutput.ReadToEnd().Trim().Split('\n');
                }
            }
            catch (Exception ex)
            {
                Successful = false;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
