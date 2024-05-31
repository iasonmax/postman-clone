using PostmanClone;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess api = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API ...";
        resultsText.Text = "";
        //Validate the API URl
        if (api.IsValidUrl(apiText.Text) == false)
        {
            systemStatus.Text = "Invalid Url";
            return;
        }

        try
        {
            resultsText.Text = await api.CallApiAsync(apiText.Text);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)  
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }

    }
}
