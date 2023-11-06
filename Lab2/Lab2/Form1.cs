namespace Lab2;

public partial class UserView : Form
{
    UserController controller;

    public UserView()
    {
        InitializeComponent();

        controller = new UserController();
    }

    private void OpenDocBtnClick(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Title = "Відкрити файл";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                DocPathEntry.Text = openFileDialog.FileName;
            }
        }

        string result = controller.FindInfo(ParametersInitializer(), ChooseAlgorithm());

        ShowResult(result);
    }

    private void FindBtnClick(object sender, EventArgs e)
    {
        if (DocPathEntry.Text is null)
        {
            MessageBox.Show("Ви не вказали документ, який треба зчитати", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return;
        }

        string result = controller.FindInfo(ParametersInitializer(), ChooseAlgorithm());

        ShowResult(result);
    }

    private void ClearBtnClick(object sender, EventArgs e)
    {
        OutputEntry.Text = "";
    }

    private void ToHTMLBtnClick(object sender, EventArgs e)
    {
        //Дописати
    }

    private void ShowResult(string result)
    { 
        OutputEntry.Text = result;
    }

    private Parameters ParametersInitializer()
    {
        Parameters parametres = new Parameters();

        parametres.DocPath = DocPathEntry.Text;

        if (NameCheckBox.Checked == true)
        {
            parametres.Name = NameEntry.Text;
        }

        if (AnnotationCheckBox.Checked == true)
        {
            parametres.Annotation = AnnotationEntry.Text;
        }

        if (TypeCheckBox.Checked == true)
        {
            parametres.Type = TypeEntry.Text;
        }

        if (VersionCheckBox.Checked == true)
        {
            parametres.Version = VersionEntry.Text;
        }

        if (AuthorCheckBox.Checked == true)
        {
            parametres.Author = AuthorEntry.Text;
        }

        if (TermsOfUsageCheckBox.Checked == true)
        {
            parametres.TermsOfUsage = TermsOfUsageEntry.Text;
        }

        if (DistributiveCheckBox.Checked == true)
        { 
            parametres.DistributiveLocation = DistributiveLocationEntry.Text;
        }

        return parametres;
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
            algorithm = "LINQ to XML";
        }

        return algorithm;
    }
}