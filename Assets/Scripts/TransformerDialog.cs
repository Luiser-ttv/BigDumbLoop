using UnityEngine;
using TMPro;

public class TransformerDialog : MonoBehaviour
{
    public string[] dialogLines;
    public TMP_Text dialogText;
    public GameObject dialogBox;

    private void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ShowDialog();
            }
        }
    }

    private void ShowDialog()
    {
        dialogBox.SetActive(true);

        for (int i = 0; i < dialogLines.Length; i++)
        {
            dialogText.text = dialogLines[i];
        }
    }

}
