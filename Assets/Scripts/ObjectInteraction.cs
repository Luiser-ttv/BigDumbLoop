using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ObjectInteraction : MonoBehaviour
{
    public List<string> dialogueLines;
    public List<string> dialogueLinesTransform;
    public List<string> dialogueLinesWitch;
    public List<string> dialogueLinesVendor;
    public List<string> dialogueLinesAngry;
    public List<string> dialogueLinesDelDone;
    public List<string> dialogueLinesDoc;

    public float interactionRadius = 2.0f;

    public bool showDialogue = false;
    public bool showDialogueTransform = false;
    public bool showDialogueWitch = false;
    public bool showDialogueVendor = false;
    public bool showDialogueAngry = false;
    public bool showDialogueDelDone = false;
    public bool showDialogueDoc = false;

    public bool dialogueFinished = false;
    public TMP_Text dialogueText;
    public GameObject dialogueFrame;

    private int currentLineIndex = 0;
    private CharacterMovement characterMovement;

    public GameObject Medina;
    void Start()
    {
        characterMovement = GetComponent<CharacterMovement>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, interactionRadius);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.CompareTag("Interactable"))
                {
                    showDialogue = true;
                    characterMovement.enabled = false;
                    break;
                }
                else if (collider.gameObject.CompareTag("TransformDone"))
                {
                    showDialogueTransform = true;
                    characterMovement.enabled = false;
                    break;
                }
                else if (collider.gameObject.CompareTag("Hunted"))
                {
                    showDialogueWitch = true;
                    characterMovement.enabled = false;
                    break;
                }
                else if (collider.gameObject.CompareTag("Vendor"))
                {
                    showDialogueVendor = true;
                    characterMovement.enabled = false;
                    break;
                }
                else if (collider.gameObject.CompareTag("Angry"))
                {
                    showDialogueAngry = true;
                    characterMovement.enabled = false;
                    break;
                }
                else if (collider.gameObject.CompareTag("DeleterDone"))
                {
                    showDialogueDelDone = true;
                    characterMovement.enabled = false;
                    break;
                }
                else if (collider.gameObject.CompareTag("Doctor"))
                {
                    showDialogueDoc = true;
                    characterMovement.enabled = false;
                    break;
                }
            }
        }

        if (showDialogue)
        {
            dialogueText.gameObject.SetActive(true);
            dialogueFrame.gameObject.SetActive(true);

            if (currentLineIndex < dialogueLines.Count)
            {
                dialogueText.text = dialogueLines[currentLineIndex];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    currentLineIndex++;
                }
            }
            else
            {
                dialogueFinished = true;
                showDialogue = false;
                characterMovement.enabled = true;
                dialogueText.gameObject.SetActive(false);
                dialogueFrame.gameObject.SetActive(false);
                currentLineIndex = 0;
            }
        }
        else if (showDialogueTransform)
        {
            dialogueText.gameObject.SetActive(true);
            dialogueFrame.gameObject.SetActive(true);

            if (currentLineIndex < dialogueLinesTransform.Count)
            {
                dialogueText.text = dialogueLinesTransform[currentLineIndex];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    currentLineIndex++;
                }
            }
            else
            {
                dialogueFinished = true;
                showDialogueTransform = false;
                characterMovement.enabled = true;
                dialogueText.gameObject.SetActive(false);
                dialogueFrame.gameObject.SetActive(false);
                currentLineIndex = 0;
            }
        }
        else if (showDialogueWitch)
        {
            dialogueText.gameObject.SetActive(true);
            dialogueFrame.gameObject.SetActive(true);

            if (currentLineIndex < dialogueLinesWitch.Count)
            {
                dialogueText.text = dialogueLinesWitch[currentLineIndex];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    currentLineIndex++;
                }
            }
            else
            {
                dialogueFinished = true;
                showDialogueWitch = false;
                characterMovement.enabled = true;
                dialogueText.gameObject.SetActive(false);
                dialogueFrame.gameObject.SetActive(false);
                currentLineIndex = 0;
            }
        }
        else if (showDialogueVendor)
        {
            dialogueText.gameObject.SetActive(true);
            dialogueFrame.gameObject.SetActive(true);

            if (currentLineIndex < dialogueLinesVendor.Count)
            {
                dialogueText.text = dialogueLinesVendor[currentLineIndex];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    currentLineIndex++;
                }
            }
            else
            {
                dialogueFinished = true;
                showDialogueVendor = false;
                characterMovement.enabled = true;
                dialogueText.gameObject.SetActive(false);
                dialogueFrame.gameObject.SetActive(false);
                currentLineIndex = 0;
            }
        }
        else if (showDialogueAngry)
        {
            dialogueText.gameObject.SetActive(true);
            dialogueFrame.gameObject.SetActive(true);

            if (currentLineIndex < dialogueLinesAngry.Count)
            {
                dialogueText.text = dialogueLinesAngry[currentLineIndex];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    currentLineIndex++;
                }
            }
            else
            {
                dialogueFinished = true;
                showDialogueAngry = false;
                characterMovement.enabled = true;
                dialogueText.gameObject.SetActive(false);
                dialogueFrame.gameObject.SetActive(false);
                currentLineIndex = 0;
            }
        }
        else if (showDialogueDelDone)
        {
            dialogueText.gameObject.SetActive(true);
            dialogueFrame.gameObject.SetActive(true);

            if (currentLineIndex < dialogueLinesDelDone.Count)
            {
                dialogueText.text = dialogueLinesDelDone[currentLineIndex];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    currentLineIndex++;
                }
            }
            else
            {
                dialogueFinished = true;
                showDialogueDelDone = false;
                characterMovement.enabled = true;
                dialogueText.gameObject.SetActive(false);
                dialogueFrame.gameObject.SetActive(false);
                currentLineIndex = 0;
            }
        }
        else if (showDialogueDoc)
        {
            dialogueText.gameObject.SetActive(true);
            dialogueFrame.gameObject.SetActive(true);

            if (currentLineIndex < dialogueLinesDoc.Count)
            {
                dialogueText.text = dialogueLinesDoc[currentLineIndex];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    currentLineIndex++;
                    
                }
                if (currentLineIndex > 5)
                {
                    Medina.SetActive(true);
                }
            }
            else
            {
                dialogueFinished = true;
                showDialogueDoc = false;
                characterMovement.enabled = true;
                dialogueText.gameObject.SetActive(false);
                dialogueFrame.gameObject.SetActive(false);
                Medina.SetActive(false);
                currentLineIndex = 0;
                SceneManager.LoadScene(0);
            }
        }


    }
}
