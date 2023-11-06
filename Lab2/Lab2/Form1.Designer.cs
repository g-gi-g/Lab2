namespace Lab2;

partial class UserView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        DocPathEntry = new TextBox();
        OutputEntry = new TextBox();
        groupBox1 = new GroupBox();
        DistributiveLocationEntry = new TextBox();
        TermsOfUsageEntry = new TextBox();
        DistributiveCheckBox = new CheckBox();
        TermsOfUsageCheckBox = new CheckBox();
        AuthorEntry = new TextBox();
        AuthorCheckBox = new CheckBox();
        VersionEntry = new TextBox();
        VersionCheckBox = new CheckBox();
        TypeCheckBox = new CheckBox();
        TypeEntry = new TextBox();
        AnnotationEntry = new TextBox();
        AnnotationCheckBox = new CheckBox();
        NameEntry = new TextBox();
        NameCheckBox = new CheckBox();
        groupBox2 = new GroupBox();
        LINQToXMLRadioBtn = new RadioButton();
        DOMRadioBtn = new RadioButton();
        SAXRadioBtn = new RadioButton();
        OpenDocBtn = new Button();
        FindBtn = new Button();
        ClearBtn = new Button();
        ToHTMLBtn = new Button();
        openFileDialog1 = new OpenFileDialog();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(36, 28);
        label1.Name = "label1";
        label1.Size = new Size(91, 15);
        label1.TabIndex = 0;
        label1.Text = "Шлях до файлу";
        // 
        // DocPathEntry
        // 
        DocPathEntry.Enabled = false;
        DocPathEntry.Location = new Point(36, 53);
        DocPathEntry.Name = "DocPathEntry";
        DocPathEntry.ReadOnly = true;
        DocPathEntry.Size = new Size(497, 23);
        DocPathEntry.TabIndex = 1;
        // 
        // OutputEntry
        // 
        OutputEntry.Enabled = false;
        OutputEntry.Location = new Point(579, 25);
        OutputEntry.Multiline = true;
        OutputEntry.Name = "OutputEntry";
        OutputEntry.ReadOnly = true;
        OutputEntry.Size = new Size(466, 510);
        OutputEntry.TabIndex = 2;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(DistributiveLocationEntry);
        groupBox1.Controls.Add(TermsOfUsageEntry);
        groupBox1.Controls.Add(DistributiveCheckBox);
        groupBox1.Controls.Add(TermsOfUsageCheckBox);
        groupBox1.Controls.Add(AuthorEntry);
        groupBox1.Controls.Add(AuthorCheckBox);
        groupBox1.Controls.Add(VersionEntry);
        groupBox1.Controls.Add(VersionCheckBox);
        groupBox1.Controls.Add(TypeCheckBox);
        groupBox1.Controls.Add(TypeEntry);
        groupBox1.Controls.Add(AnnotationEntry);
        groupBox1.Controls.Add(AnnotationCheckBox);
        groupBox1.Controls.Add(NameEntry);
        groupBox1.Controls.Add(NameCheckBox);
        groupBox1.Location = new Point(36, 82);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(497, 286);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "Параметри пошуку";
        // 
        // DistributiveLocationEntry
        // 
        DistributiveLocationEntry.Location = new Point(207, 242);
        DistributiveLocationEntry.Name = "DistributiveLocationEntry";
        DistributiveLocationEntry.Size = new Size(270, 23);
        DistributiveLocationEntry.TabIndex = 13;
        // 
        // TermsOfUsageEntry
        // 
        TermsOfUsageEntry.Location = new Point(207, 208);
        TermsOfUsageEntry.Name = "TermsOfUsageEntry";
        TermsOfUsageEntry.Size = new Size(270, 23);
        TermsOfUsageEntry.TabIndex = 12;
        // 
        // DistributiveCheckBox
        // 
        DistributiveCheckBox.AutoSize = true;
        DistributiveCheckBox.Location = new Point(8, 246);
        DistributiveCheckBox.Name = "DistributiveCheckBox";
        DistributiveCheckBox.Size = new Size(177, 19);
        DistributiveCheckBox.TabIndex = 11;
        DistributiveCheckBox.Text = "Місце запису дистрибутиву";
        DistributiveCheckBox.UseVisualStyleBackColor = true;
        // 
        // TermsOfUsageCheckBox
        // 
        TermsOfUsageCheckBox.AutoSize = true;
        TermsOfUsageCheckBox.Location = new Point(8, 212);
        TermsOfUsageCheckBox.Name = "TermsOfUsageCheckBox";
        TermsOfUsageCheckBox.Size = new Size(142, 19);
        TermsOfUsageCheckBox.TabIndex = 10;
        TermsOfUsageCheckBox.Text = "Умови використання";
        TermsOfUsageCheckBox.UseVisualStyleBackColor = true;
        // 
        // AuthorEntry
        // 
        AuthorEntry.Location = new Point(207, 170);
        AuthorEntry.Name = "AuthorEntry";
        AuthorEntry.Size = new Size(270, 23);
        AuthorEntry.TabIndex = 9;
        // 
        // AuthorCheckBox
        // 
        AuthorCheckBox.AutoSize = true;
        AuthorCheckBox.Location = new Point(8, 174);
        AuthorCheckBox.Name = "AuthorCheckBox";
        AuthorCheckBox.Size = new Size(59, 19);
        AuthorCheckBox.TabIndex = 8;
        AuthorCheckBox.Text = "Автор";
        AuthorCheckBox.UseVisualStyleBackColor = true;
        // 
        // VersionEntry
        // 
        VersionEntry.Location = new Point(207, 136);
        VersionEntry.Name = "VersionEntry";
        VersionEntry.Size = new Size(270, 23);
        VersionEntry.TabIndex = 7;
        // 
        // VersionCheckBox
        // 
        VersionCheckBox.AutoSize = true;
        VersionCheckBox.Location = new Point(8, 140);
        VersionCheckBox.Name = "VersionCheckBox";
        VersionCheckBox.Size = new Size(61, 19);
        VersionCheckBox.TabIndex = 6;
        VersionCheckBox.Text = "Версія";
        VersionCheckBox.UseVisualStyleBackColor = true;
        // 
        // TypeCheckBox
        // 
        TypeCheckBox.AutoSize = true;
        TypeCheckBox.Location = new Point(8, 104);
        TypeCheckBox.Name = "TypeCheckBox";
        TypeCheckBox.Size = new Size(46, 19);
        TypeCheckBox.TabIndex = 5;
        TypeCheckBox.Text = "Вид";
        TypeCheckBox.UseVisualStyleBackColor = true;
        // 
        // TypeEntry
        // 
        TypeEntry.Location = new Point(207, 100);
        TypeEntry.Name = "TypeEntry";
        TypeEntry.Size = new Size(270, 23);
        TypeEntry.TabIndex = 4;
        // 
        // AnnotationEntry
        // 
        AnnotationEntry.Location = new Point(207, 65);
        AnnotationEntry.Name = "AnnotationEntry";
        AnnotationEntry.Size = new Size(270, 23);
        AnnotationEntry.TabIndex = 3;
        // 
        // AnnotationCheckBox
        // 
        AnnotationCheckBox.AutoSize = true;
        AnnotationCheckBox.Location = new Point(8, 69);
        AnnotationCheckBox.Name = "AnnotationCheckBox";
        AnnotationCheckBox.Size = new Size(75, 19);
        AnnotationCheckBox.TabIndex = 2;
        AnnotationCheckBox.Text = "Анотація";
        AnnotationCheckBox.UseVisualStyleBackColor = true;
        // 
        // NameEntry
        // 
        NameEntry.Location = new Point(207, 28);
        NameEntry.Name = "NameEntry";
        NameEntry.Size = new Size(270, 23);
        NameEntry.TabIndex = 1;
        // 
        // NameCheckBox
        // 
        NameCheckBox.AutoSize = true;
        NameCheckBox.Location = new Point(8, 32);
        NameCheckBox.Name = "NameCheckBox";
        NameCheckBox.Size = new Size(58, 19);
        NameCheckBox.TabIndex = 0;
        NameCheckBox.Text = "Назва";
        NameCheckBox.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(LINQToXMLRadioBtn);
        groupBox2.Controls.Add(DOMRadioBtn);
        groupBox2.Controls.Add(SAXRadioBtn);
        groupBox2.Location = new Point(36, 383);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(497, 67);
        groupBox2.TabIndex = 4;
        groupBox2.TabStop = false;
        groupBox2.Text = "Спосіб зчитування";
        // 
        // LINQToXMLRadioBtn
        // 
        LINQToXMLRadioBtn.AutoSize = true;
        LINQToXMLRadioBtn.Location = new Point(384, 33);
        LINQToXMLRadioBtn.Name = "LINQToXMLRadioBtn";
        LINQToXMLRadioBtn.Size = new Size(93, 19);
        LINQToXMLRadioBtn.TabIndex = 2;
        LINQToXMLRadioBtn.Text = "LINQ to XML";
        LINQToXMLRadioBtn.UseVisualStyleBackColor = true;
        // 
        // DOMRadioBtn
        // 
        DOMRadioBtn.AutoSize = true;
        DOMRadioBtn.Location = new Point(207, 33);
        DOMRadioBtn.Name = "DOMRadioBtn";
        DOMRadioBtn.Size = new Size(53, 19);
        DOMRadioBtn.TabIndex = 1;
        DOMRadioBtn.Text = "DOM";
        DOMRadioBtn.UseVisualStyleBackColor = true;
        // 
        // SAXRadioBtn
        // 
        SAXRadioBtn.AutoSize = true;
        SAXRadioBtn.Checked = true;
        SAXRadioBtn.Location = new Point(23, 33);
        SAXRadioBtn.Name = "SAXRadioBtn";
        SAXRadioBtn.Size = new Size(46, 19);
        SAXRadioBtn.TabIndex = 0;
        SAXRadioBtn.TabStop = true;
        SAXRadioBtn.Text = "SAX";
        SAXRadioBtn.UseVisualStyleBackColor = true;
        // 
        // OpenDocBtn
        // 
        OpenDocBtn.Location = new Point(44, 489);
        OpenDocBtn.Name = "OpenDocBtn";
        OpenDocBtn.Size = new Size(88, 46);
        OpenDocBtn.TabIndex = 5;
        OpenDocBtn.Text = "Відкрити файл";
        OpenDocBtn.UseVisualStyleBackColor = true;
        OpenDocBtn.Click += OpenDocBtnClick;
        // 
        // FindBtn
        // 
        FindBtn.Location = new Point(170, 489);
        FindBtn.Name = "FindBtn";
        FindBtn.Size = new Size(83, 46);
        FindBtn.TabIndex = 6;
        FindBtn.Text = "Знайти";
        FindBtn.UseVisualStyleBackColor = true;
        FindBtn.Click += FindBtnClick;
        // 
        // ClearBtn
        // 
        ClearBtn.Location = new Point(289, 489);
        ClearBtn.Name = "ClearBtn";
        ClearBtn.Size = new Size(86, 46);
        ClearBtn.TabIndex = 7;
        ClearBtn.Text = "Очистити результати";
        ClearBtn.UseVisualStyleBackColor = true;
        ClearBtn.Click += ClearBtnClick;
        // 
        // ToHTMLBtn
        // 
        ToHTMLBtn.Location = new Point(408, 489);
        ToHTMLBtn.Name = "ToHTMLBtn";
        ToHTMLBtn.Size = new Size(92, 46);
        ToHTMLBtn.TabIndex = 8;
        ToHTMLBtn.Text = "Конвертувати в HTML";
        ToHTMLBtn.UseVisualStyleBackColor = true;
        ToHTMLBtn.Click += ToHTMLBtnClick;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // UserView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1074, 566);
        Controls.Add(ToHTMLBtn);
        Controls.Add(ClearBtn);
        Controls.Add(FindBtn);
        Controls.Add(OpenDocBtn);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(OutputEntry);
        Controls.Add(DocPathEntry);
        Controls.Add(label1);
        Name = "UserView";
        Text = "XML reader";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox DocPathEntry;
    private TextBox OutputEntry;
    private GroupBox groupBox1;
    private CheckBox NameCheckBox;
    private TextBox NameEntry;
    private TextBox AnnotationEntry;
    private CheckBox AnnotationCheckBox;
    private TextBox VersionEntry;
    private CheckBox VersionCheckBox;
    private CheckBox TypeCheckBox;
    private TextBox TypeEntry;
    private CheckBox DistributiveCheckBox;
    private CheckBox TermsOfUsageCheckBox;
    private TextBox AuthorEntry;
    private CheckBox AuthorCheckBox;
    private TextBox DistributiveLocationEntry;
    private TextBox TermsOfUsageEntry;
    private GroupBox groupBox2;
    private RadioButton SAXRadioBtn;
    private RadioButton LINQToXMLRadioBtn;
    private RadioButton DOMRadioBtn;
    private Button OpenDocBtn;
    private Button FindBtn;
    private Button ClearBtn;
    private Button ToHTMLBtn;
    private OpenFileDialog openFileDialog1;
}