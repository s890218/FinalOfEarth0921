using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loadtext : MonoBehaviour
{

    private float letterPause = 0.1f;
    
    [SerializeField]
    private AudioClip typeSound;
    [SerializeField]
    private Text txtDisplay;
    private string words;
    private string text = "Welcome to summerRift!!\naaaaaaaaaaaaaaaaaaaaaaaaaa";


    public IEnumerator display(string displayStr)
    {
        words = displayStr;
        text = "";
        yield return new WaitForSeconds(2f);
        StartCoroutine(TypeText());
    }

    void Start()
    {
        StartCoroutine(display(text));
    }
    
    private IEnumerator TypeText()
    {
        foreach (var word in words)
        {
            txtDisplay.text += word;
            yield return new WaitForSeconds(letterPause);
        }

    }
}