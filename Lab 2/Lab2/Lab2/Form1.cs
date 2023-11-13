namespace Lab2;

public partial class UserView : Form
{
    private UserController userController;

    public UserView()
    {
        InitializeComponent();

        userController = new UserController();

        FormClosing += AcceptClose;

        NameÑomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        AnnotationÑomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        TypeÑomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        VersionÑomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        AuthorÑomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        TermsOfUsageÑomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        DistributiveLocationÑomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private void OpenDocBtnClick(object sender, EventArgs e)
    {
        try
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Â³äêğèòè ôàéë";

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    InputXMLPathEntry.Text = openFileDialog.FileName;

                    NameÑomboBox.Items.Clear();
                    AnnotationÑomboBox.Items.Clear();
                    TypeÑomboBox.Items.Clear();
                    VersionÑomboBox.Items.Clear();
                    AuthorÑomboBox.Items.Clear();
                    TermsOfUsageÑomboBox.Items.Clear();
                    DistributiveLocationÑomboBox.Items.Clear();

                    NameÑomboBox.Text = "";
                    AnnotationÑomboBox.Text = "";
                    TypeÑomboBox.Text = "";
                    VersionÑomboBox.Text = "";
                    AuthorÑomboBox.Text = "";
                    TermsOfUsageÑomboBox.Text = "";
                    DistributiveLocationÑomboBox.Text = "";

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

            uniqueAttributesValues = userController.SearchUniqueAttributesValues(InputXMLPathEntry.Text);

            NameÑomboBox.Items.AddRange(uniqueAttributesValues["Name"].ToArray());
            AnnotationÑomboBox.Items.AddRange(uniqueAttributesValues["Annotation"].ToArray());
            TypeÑomboBox.Items.AddRange(uniqueAttributesValues["Type"].ToArray());
            VersionÑomboBox.Items.AddRange(uniqueAttributesValues["Version"].ToArray());
            AuthorÑomboBox.Items.AddRange(uniqueAttributesValues["Author"].ToArray());
            TermsOfUsageÑomboBox.Items.AddRange(uniqueAttributesValues["TermsOfUsage"].ToArray());
            DistributiveLocationÑomboBox.Items.AddRange(uniqueAttributesValues["DistributiveLocation"].ToArray());
        }

        catch (Exception ex)
        {
            InputXMLPathEntry.Text = "";

            MessageBox.Show(string.Format("Ñòàëàñÿ ïîìèëêà ç÷èòóâàííÿ: {0}", ex.Message), 
                "Ïîïåğåäæåííÿ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void FindBtnClick(object sender, EventArgs e)
    {
        if (InputXMLPathEntry.Text == "")
        {
            MessageBox.Show("Âè íå âêàçàëè äîêóìåíò, ÿêèé òğåáà ç÷èòàòè", 
                "Ïîïåğåäæåííÿ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return;
        }

        string result = userController.FindInfo(QueryParametersInitializer(), ChooseAlgorithm());

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
                openFileDialog.Title = "Â³äêğèòè ôàéë";

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK && InputXMLPathEntry.Text != "")
                {
                    userController.TransformToHTML(InputXMLPathEntry.Text, openFileDialog.FileName);
                }

                else
                {
                    MessageBox.Show("Âè âêàçàëè íåâ³ğíèé øëÿõ äëÿ çàïèñó àáî íå îáğàëè äîêóìåíò äëÿ êîíâåğòàö³¿",
                        "Ïîïåğåäæåííÿ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        catch (Exception ex)
        {
            MessageBox.Show(string.Format("Ñòàëàñÿ ïîìèëêà êîíâåğòàö³¿: {0}", ex.Message), 
                "Ïîïåğåäæåííÿ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void ShowResult(string result)
    {
        OutputEntry.Text = result;
    }

    private void AcceptClose(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("×è ä³éñíî âè õî÷åòå çàâåğøèòè ğîáîòó ç ïğîãğàìîş?",
            "Ï³äòâåğäæåííÿ âèõîäó", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private SearchParameters QueryParametersInitializer()
    {
        SearchParameters searchParameters = new SearchParameters();

        searchParameters.InputXMLPath = InputXMLPathEntry.Text;

        if (NameCheckBox.Checked == true)
        {
            searchParameters.Name = NameÑomboBox.Text;
        }

        if (AnnotationCheckBox.Checked == true)
        {
            searchParameters.Annotation = AnnotationÑomboBox.Text;
        }

        if (TypeCheckBox.Checked == true)
        {
            searchParameters.Type = TypeÑomboBox.Text;
        }

        if (VersionCheckBox.Checked == true)
        {
            searchParameters.Version = VersionÑomboBox.Text;
        }

        if (AuthorCheckBox.Checked == true)
        {
            searchParameters.Author = AuthorÑomboBox.Text;
        }

        if (TermsOfUsageCheckBox.Checked == true)
        {
            searchParameters.TermsOfUsage = TermsOfUsageÑomboBox.Text;
        }

        if (DistributiveCheckBox.Checked == true)
        {
            searchParameters.DistributiveLocation = DistributiveLocationÑomboBox.Text;
        }

        return searchParameters;
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