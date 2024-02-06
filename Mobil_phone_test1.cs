using UnityEngine;
using UnityEngine.UI;

public class LoginTest : MonoBehaviour
{
    public InputField emailInputField;
    public InputField passwordInputField;
    public Button loginButton;

    void Start()
    {
        // Attach listeners to phone buttons
        loginButton.onClick.AddListener(AttemptLogin);
    }

    void AttemptLogin()
    {
        string enteredEmail = emailInputField.text;
        string enteredPassword = passwordInputField.text;

        // Validate the email format 
        if (IsValidEmail(enteredEmail))
        {
            // Perform login logic to verify success 
            bool loginSuccessful = VerifyCredentials(enteredEmail, enteredPassword);

            if (loginSuccessful)
            {
                Debug.Log("Login successful! Navigating to home screen.");
                // Implement navigation to home screen (or SIT/UAT-
            // specific)
            }
            else
            {
                Debug.LogError("Login failed. Invalid credentials.");
                // Handle error message display
            }
        }
        else
        {
            Debug.LogError("Invalid email format. Please enter a valid email address.");
            // Handle error message display
        }
    }

    bool IsValidEmail(string email)
    {
        // Implement your email validation logic here
        // (e.g., using regular expressions or other methods)
        return true; // Placeholder; replace with actual validation
    }

    bool VerifyCredentials(string email, string password)
    {
        // Implement your credential verification logic here
        // (e.g., check against a database or authentication service)
        return true; // Placeholder; replace with actual verification
    }
}
public class MobileAppTester : MonoBehaviour
{
    public Button colorButton;
    public Button notificationButton;
    public InputField textInputField;
    public Text toastText;
    public Button speedTestButton; // Reference to the "Speed Test" button
    public Button backButton; // Reference to the "Back" button

    private bool colorChangeVerified = false;
    private bool notificationReceived = false;
    private bool textEntered = false;
    private bool speedTestOnline = false;

    void Start()
    {
        // Attach listeners to buttons
        colorButton.onClick.AddListener(ChangeButtonColor);
        notificationButton.onClick.AddListener(VerifyNotification);
        textInputField.onEndEdit.AddListener(CaptureText);
        speedTestButton.onClick.AddListener(RunSpeedTest);
        backButton.onClick.AddListener(NavigateBack);
    }

    void ChangeButtonColor()
    {
        // Change the button's color when clicked
        Color newColor = Color.red;
        // E.g. using red as an example. You can set any desired color
        colorButton.GetComponent<Image>().color = newColor;
        colorChangeVerified = true; // Positive verification
    }

    void VerifyNotification()
    {
        // Implement notification verification logic here
        // (outside of Unity, using platform-specific APIs)
        // For negative verification:
        if (/* Check if notification is not received */) 
        {
            Debug.LogError("Negative verification: Notification not received!");
        }
        else
        {
            notificationReceived = true; // Positive verification
        }
    }

    void CaptureText(string newText)
    {
        if (string.IsNullOrEmpty(newText))
        {
            Debug.LogError("Negative verification: No text entered!");
        }
        else
        {
            textEntered = true; // Positive verification
        }
    }

    void ShowToast(string message)
    {
        toastText.text = message;
        // Implement logic to display the toast (e.g., fade in/out)
    }

    void RunSpeedTest()
    {
        // Assume you navigate to the speed testing screen
        // and capture upload/download speeds
        float uploadSpeed = 10.5f; // Example of upload speed in Mbps
        float downloadSpeed = 25.3f; // Example of download speed in Mbps

        // For negative verification:
        if (/* Check if phone is not online */) 
        {
            Debug.LogError("Negative verification: Phone is not online!");
        }
        else
        {
            Debug.Log($"Speed test results: Upload = {uploadSpeed} Mbps, Download = {downloadSpeed} Mbps");
            speedTestOnline = true; // Positive verification
        }
    }

    void NavigateBack()
    {
        // Implement logic to navigate back to the Home screen
        // (you'll need to adapt this based on your app's navigation system)
        Debug.Log("Navigating back to Home screen.");
    }
}
