using UnityEngine;
using TMPro;

public class DialoguePlayer : MonoBehaviour
{

    public Dialogueasset dialogueasset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;

    private int dialogueLineIndex;

    private void Start()
    {
        dialogueText.text = dialogueasset.dialogue[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            dialogueLineIndex += 1;

            if(dialogueLineIndex < dialogueasset.dialogue.Length)
            {
                dialogueText.text = dialogueasset.dialogue[dialogueLineIndex];
            }
            else
            {
                dialogueBox.gameObject.SetActive(false);
            }
        }
    }

}
