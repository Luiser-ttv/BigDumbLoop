using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxAppearance : MonoBehaviour
{
    public float showDistance = 5.0f;
    public GameObject textBox;
    public TextMeshProUGUI text;
    private Transform player;
    private GameObject textGO;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        textGO = GameObject.FindGameObjectWithTag("QuickText");
        textBox.SetActive(false);
        textGO.SetActive(false);
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance < showDistance)
        {
            textBox.SetActive(true);
            textGO.SetActive(true);
            text.text = "Hola puta";
        }
        else
        {
            textGO.SetActive(false);
            textBox.SetActive(false);
            text.text = "";
        }
    }
}
