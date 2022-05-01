using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translater.Model;

namespace Translater.View
{
    public partial class MainForm : Form
    {
        #region Инициализация 

        private Label _infoLabel;
        private TokenModel _tokenModel;
        public MainForm()
        {
            InitializeComponent();
            AddControls();
            CheckConnection();
        }

        private void AddControls()
        {
            panel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.DarkGray,
            };

            _infoLabel = new Label()
            {
                Font = new Font(FontFamily.GenericSansSerif, 10.0f, FontStyle.Regular),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.BottomLeft,
                ForeColor = Color.Black,
            };

            panel.Controls.Add(_infoLabel);
            this.Controls.Add(panel);
            panel.BringToFront();
        }

        private async void CheckConnection()
        {
            LanguagesCB.SelectedIndex = 0;
            _infoLabel.Text = "";
            var progress = new Progress<string>(s => _infoLabel.Text += s);
            bool res = true;

            await Task.Run(() =>
            {
                if (!ConnectToInternet(progress))
                    res = false;
            });

            if (!res)
                return;

            _tokenModel = new TokenModel();

            await Task.Run(() => 
            {
                _tokenModel.GetToken(progress);
            });

            if (_tokenModel.Successful)
                panel.Visible = false;
        }

        private bool ConnectToInternet(IProgress<string> progress, int timeout_per_host_millis = 3000)
        {
            bool network_available = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

            if (network_available)
            {
                progress.Report("Проверка подключения к интернету\n");
                Ping p = new Ping();
                try
                {
                    PingReply r = p.Send("www.google.com", timeout_per_host_millis);

                    if (r.Status == IPStatus.Success)
                        return true;
                }
                catch 
                {
                    progress.Report("Нет подключения к интернету\n");
                    return false;
                }
            }

            progress.Report("Нет подключения к интернету\n");
            return false;
        }

        #endregion

        private async void TranslateText(object sender, EventArgs e)
        {
            if (OriginalTB.Text.Length < 10 || OriginalTB.Text.Length > 10000)
            {
                MessageBox.Show($"Невозможно перевести текст данной длины {OriginalTB.Text.Length}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TranslateModel ts = new TranslateModel(_tokenModel.Token);
                var language = CheckLanguage();

                await Task.Run(() =>
                {
                    ts.GetTranslate(OriginalTB.Text, language);
                });

                TranslateTB.Text = "";
                foreach (Translation translation in ts.Result.Translations)
                {
                    TranslateTB.Text += translation.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string CheckLanguage()
        { 
            var buffer = Regex.Replace(LanguagesCB.SelectedItem.ToString(), "[ ]+", " ").Trim().Split(' ');
            return buffer[1];
        }

        private void CheckBoxClick(object sender, EventArgs e)
        {

        }

        private void GenerateCharacter(object sender, EventArgs e)
        {
            var model = new CharacterModel();
            var character = new CharacterParam(model, Convert.ToBoolean(trackBar1.Value));
            character.ShowDialog();
            OriginalTB.Text = model.GetCharacter();
        }
    }
}
