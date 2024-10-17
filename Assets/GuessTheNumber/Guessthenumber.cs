using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class Guessthenumber : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        messageText.text = "Hello World !";
        ResetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text))
        {
            messageText.text = "Please enter a valid number.";
            numberInput.text = "";
            return;
        }

        if (int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "Victory !";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "Lower...";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Greater...";
            }
            else
            {
                messageText.text = "Please enter a valid number.";
            }
            numberInput.text = "";
        }
    }
    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Genarated number: " + randomNumber);
        messageText.text = "Guess the number...";
    }
}