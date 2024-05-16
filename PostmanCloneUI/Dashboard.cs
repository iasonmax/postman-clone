namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        //Validate the API URl
        try
        {
            systemStatus.Text = "Calling API ...";
            //Sample Code - Replace with the Api Call
            await Task.Delay(2000);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)  
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }

    }
}
