
namespace Translater.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.OriginalTB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.TranslateBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TranslateTB = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LanguagesCB = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveToPdfBtn = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panel2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1012, 558);
            this.panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 558);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel7);
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Size = new System.Drawing.Size(1012, 458);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.OriginalTB);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel5.Size = new System.Drawing.Size(499, 400);
            this.panel5.TabIndex = 1;
            // 
            // OriginalTB
            // 
            this.OriginalTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginalTB.Location = new System.Drawing.Point(10, 5);
            this.OriginalTB.Multiline = true;
            this.OriginalTB.Name = "OriginalTB";
            this.OriginalTB.Size = new System.Drawing.Size(479, 390);
            this.OriginalTB.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GenerateBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 58);
            this.panel4.TabIndex = 0;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(10, 10);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(163, 36);
            this.GenerateBtn.TabIndex = 5;
            this.GenerateBtn.Text = "Сгенерировать характеристику";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateCharacter);
            // 
            // TranslateBtn
            // 
            this.TranslateBtn.Location = new System.Drawing.Point(10, 10);
            this.TranslateBtn.Name = "TranslateBtn";
            this.TranslateBtn.Size = new System.Drawing.Size(163, 36);
            this.TranslateBtn.TabIndex = 5;
            this.TranslateBtn.Text = "Перевести на выбранный язык";
            this.TranslateBtn.UseVisualStyleBackColor = true;
            this.TranslateBtn.Click += new System.EventHandler(this.TranslateText);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TranslateTB);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel7.Size = new System.Drawing.Size(509, 400);
            this.panel7.TabIndex = 1;
            // 
            // TranslateTB
            // 
            this.TranslateTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TranslateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslateTB.Location = new System.Drawing.Point(10, 5);
            this.TranslateTB.Multiline = true;
            this.TranslateTB.Name = "TranslateTB";
            this.TranslateTB.Size = new System.Drawing.Size(489, 390);
            this.TranslateTB.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.SaveToPdfBtn);
            this.panel6.Controls.Add(this.TranslateBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 400);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(509, 58);
            this.panel6.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LanguagesCB);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(710, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выбор языка";
            // 
            // LanguagesCB
            // 
            this.LanguagesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguagesCB.FormattingEnabled = true;
            this.LanguagesCB.Items.AddRange(new object[] {
            "азербайджанский\t     az",
            "албанский                       sq",
            "амхарский                      am",
            "английский                     en",
            "арабский\t                        ar",
            "армянский                      hy",
            "африкаанс                       af",
            "баскский\t                        eu",
            "башкирский                   ba",
            "белорусский                   be",
            "бенгальский                    bn",
            "бирманский                    my",
            "болгарский                     bg",
            "боснийский                     bs",
            "валлийский                     cy",
            "венгерский                      hu",
            "вьетнамский                   vi",
            "гаитянский                      ht",
            "галисийский                   gl",
            "голландский                   nl",
            "горномарийскийm        rj",
            "греческий                        el",
            "грузинский                      ka",
            "гуджарати                       gu",
            "датский\t                        da",
            "иврит\t                       he",
            "идиш\t                        yi",
            "индонезийский              id",
            "ирландский                    ga",
            "итальянский                   it",
            "исландский                     is",
            "испанский                      es",
            "казахский                       kk",
            "каннада                           kn",
            "каталанский                   ca",
            "киргизский                     ky",
            "китайский                       zh",
            "корейский                     ko",
            "коса\t                       xh",
            "кхмерский                     km",
            "лаосский                        lo",
            "латынь                            la",
            "латышский                     lv",
            "литовский                     lt",
            "люксембургский          lb",
            "малагасийский            mg",
            "малайский                    ms",
            "малаялам                      ml",
            "мальтийский                mt",
            "македонский                mk",
            "маори                             mi",
            "маратхи                         mr",
            "монгольский                mn",
            "немецкий                       de",
            "непальский                   ne",
            "норвежский                  no",
            "панджаби                      pa",
            "папьяментоp                ap",
            "персидский                   fa",
            "польский                       pl",
            "португальский             pt",
            "румынский                    ro",
            "русский                         ru",
            "себуанскийc                 eb",
            "сербский                       sr",
            "сингальский                 si",
            "словацкий                     sk",
            "словенский                   sl",
            "суахили\t                     sw",
            "сунданский                   su",
            "таджикский                   tg",
            "тайский                         th",
            "тагальский                    tl",
            "тамильский                   ta",
            "татарский                     tt",
            "телугу                            te",
            "турецкий\t                     tr",
            "удмуртский                udm",
            "узбекский                     uz",
            "украинский                  uk",
            "урду                                ur",
            "финский                        fi",
            "французский                fr",
            "хинди\t                     hi",
            "хорватский                   hr",
            "чешский                       cs",
            "шведский\t                     sv",
            "шотландский               gd",
            "эстонский                     et",
            "эсперанто                     eo",
            "яванский\t                     jv",
            "японский                     ja"});
            this.LanguagesCB.Location = new System.Drawing.Point(626, 37);
            this.LanguagesCB.Name = "LanguagesCB";
            this.LanguagesCB.Size = new System.Drawing.Size(295, 23);
            this.LanguagesCB.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 15, 10, 5);
            this.panel3.Size = new System.Drawing.Size(505, 100);
            this.panel3.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(10, 15);
            this.trackBar1.Maximum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(485, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Плохо";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Хорошо";
            // 
            // SaveToPdfBtn
            // 
            this.SaveToPdfBtn.Location = new System.Drawing.Point(179, 10);
            this.SaveToPdfBtn.Name = "SaveToPdfBtn";
            this.SaveToPdfBtn.Size = new System.Drawing.Size(163, 36);
            this.SaveToPdfBtn.TabIndex = 5;
            this.SaveToPdfBtn.Text = "Сохранить в pdf";
            this.SaveToPdfBtn.UseVisualStyleBackColor = true;
            this.SaveToPdfBtn.Click += new System.EventHandler(this.SetPdf);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 558);
            this.Controls.Add(this.panel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LanguagesCB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox OriginalTB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button TranslateBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TranslateTB;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button SaveToPdfBtn;
    }
}