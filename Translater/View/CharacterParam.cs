using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translater.Model;

namespace Translater.View
{
    public partial class CharacterParam : Form
    {
        private CharacterModel _characterModel;
        private bool _goodCharacter;
        public CharacterParam(CharacterModel cm, bool good)
        {
            InitializeComponent();
            this._characterModel = cm;
            this._goodCharacter = good;
        }

        private void CharacterParam_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (_goodCharacter)
                {
                    if (control is ComboBox)
                    {
                        var cb = (ComboBox)control;
                        cb.SelectedIndex = 0;
                    }
                }
                else
                {
                    if (control is ComboBox)
                    {
                        var cb = (ComboBox)control;
                        cb.SelectedIndex = cb.Items.Count - 1;
                    }
                }
            }
        }

        private void GenerateChar_Click(object sender, EventArgs e)
        {
            _characterModel.Name = NameTB.Text;
            _characterModel.Surname = SurnameTB.Text;

            _characterModel.CharacterFirst = comboBox1.Text;
            _characterModel.CharacterSecond = comboBox2.Text;
            _characterModel.CharacterThird = comboBox3.Text;
            _characterModel.CharacterFourth = comboBox5.Text;
            _characterModel.CharacterFifth = comboBox6.Text;
            _characterModel.CharacterSixth = comboBox7.Text;

            _characterModel.TalantsForEducation = comboBox9.Text;
            _characterModel.Motivation = comboBox10.Text;
            _characterModel.Perfomance = comboBox11.Text;

            _characterModel.Interests = InterestsTB.Text;

            _characterModel.AllLife = comboBox12.Text;
            _characterModel.LifeWork = comboBox13.Text;

            _characterModel.PlaceInClass = comboBox14.Text;
            _characterModel.StyleInClass = comboBox15.Text;

            _characterModel.TeacherAttitude = comboBox20.Text;
            _characterModel.Reaction = comboBox19.Text;

            _characterModel.Status = comboBox18.Text;
            _characterModel.Climat = comboBox17.Text;
            _characterModel.Parenting = comboBox16.Text;

            this.Close();
        }
    }
}
