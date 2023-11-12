namespace Lab2;

public partial class UserView : Form
{
    private UserController controller;

    public UserView()
    {
        InitializeComponent();

        controller = new UserController();

        this.FormClosing += AcceptClose;

        Name�omboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        Annotation�omboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        Type�omboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        Version�omboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        Author�omboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        TermsOfUsage�omboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        DistributiveLocation�omboBox.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private void OpenDocBtnClick(object sender, EventArgs e)
    {
        try
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "³������ ����";

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    DocPathEntry.Text = openFileDialog.FileName;

                    Name�omboBox.Items.Clear();
                    Annotation�omboBox.Items.Clear();
                    Type�omboBox.Items.Clear();
                    Version�omboBox.Items.Clear();
                    Author�omboBox.Items.Clear();
                    TermsOfUsage�omboBox.Items.Clear();
                    DistributiveLocation�omboBox.Items.Clear();

                    Name�omboBox.Text = "";
                    Annotation�omboBox.Text = "";
                    Type�omboBox.Text = "";
                    Version�omboBox.Text = "";
                    Author�omboBox.Text = "";
                    TermsOfUsage�omboBox.Text = "";
                    DistributiveLocation�omboBox.Text = "";

                    NameCheckBox.Checked = false;
                    AnnotationCheckBox.Checked = false;
                    TypeCheckBox.Checked = false;
                    VersionCheckBox.Checked = false;
                    AuthorCheckBox.Checked = false;
                    TermsOfUsageCheckBox.Checked = false;
                    DistributiveCheckBox.Checked = false;

                    OutputEntry.Text = "";
                }
            }

            Dictionary<string, HashSet<string>> uniqueAttributesValues = new Dictionary<string, HashSet<string>>()
            {
                { "Name", new HashSet<string>() },
                { "Annotation", new HashSet<string>() },
                { "Type", new HashSet<string>() },
                { "Version", new HashSet<string>() },
                { "Author", new HashSet<string>() },
                { "TermsOfUsage", new HashSet<string>() },
                { "DistributiveLocation", new HashSet<string>() }
            };

            uniqueAttributesValues = controller.SearchUniqueAttributesValues(DocPathEntry.Text);

            Name�omboBox.Items.AddRange(uniqueAttributesValues["Name"].ToArray());
            Annotation�omboBox.Items.AddRange(uniqueAttributesValues["Annotation"].ToArray());
            Type�omboBox.Items.AddRange(uniqueAttributesValues["Type"].ToArray());
            Version�omboBox.Items.AddRange(uniqueAttributesValues["Version"].ToArray());
            Author�omboBox.Items.AddRange(uniqueAttributesValues["Author"].ToArray());
            TermsOfUsage�omboBox.Items.AddRange(uniqueAttributesValues["TermsOfUsage"].ToArray());
            DistributiveLocation�omboBox.Items.AddRange(uniqueAttributesValues["DistributiveLocation"].ToArray());
        }
        catch (Exception ex)
        {
            DocPathEntry.Text = "";

            MessageBox.Show(string.Format("������� ������� ����������: {0}", ex.Message), "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void FindBtnClick(object sender, EventArgs e)
    {
        if (DocPathEntry.Text == "")
        {
            MessageBox.Show("�� �� ������� ��������, ���� ����� �������", "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return;
        }

        string result = controller.FindInfo(DocPathEntry.Text, SoftwareQueryInitializer(), ChooseAlgorithm());

        ShowResult(result);
    }

    private void ClearBtnClick(object sender, EventArgs e)
    {
        OutputEntry.Text = "";
    }

    private void ToHTMLBtnClick(object sender, EventArgs e)
    {
        try
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "³������ ����";

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK && DocPathEntry.Text != "")
                {
                    controller.TransformToHTML(DocPathEntry.Text, openFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("�� ������� ������� ���� ��� ������ ��� �� ������ �������� ��� �����������",
                        "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(string.Format("������� ������� �����������: {0}", ex.Message), "������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void ShowResult(string result)
    {
        OutputEntry.Text = result;
    }

    private void AcceptClose(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("�� ����� �� ������ ��������� ������ � ���������?",
            "ϳ����������� ������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private Software SoftwareQueryInitializer()
    {
        Software software = new Software();

        if (NameCheckBox.Checked == true)
        {
            software.Name = Name�omboBox.Text;
        }

        if (AnnotationCheckBox.Checked == true)
        {
            software.Annotation = Annotation�omboBox.Text;
        }

        if (TypeCheckBox.Checked == true)
        {
            software.Type = Type�omboBox.Text;
        }

        if (VersionCheckBox.Checked == true)
        {
            software.Version = Version�omboBox.Text;
        }

        if (AuthorCheckBox.Checked == true)
        {
            software.Author = Author�omboBox.Text;
        }

        if (TermsOfUsageCheckBox.Checked == true)
        {
            software.TermsOfUsage = TermsOfUsage�omboBox.Text;
        }

        if (DistributiveCheckBox.Checked == true)
        {
            software.DistributiveLocation = DistributiveLocation�omboBox.Text;
        }

        return software;
    }

    private string ChooseAlgorithm()
    {
        string algorithm;

        if (SAXRadioBtn.Checked == true)
        {
            algorithm = "SAX";
        }
        else if (DOMRadioBtn.Checked == true)
        {
            algorithm = "DOM";
        }
        else
        {
            algorithm = "LINQ";
        }

        return algorithm;
    }
}