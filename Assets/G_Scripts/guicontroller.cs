using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class guicontroller : MonoBehaviour
{
    public Animator mainmenuani;
    public Animator achimenuani;

    void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    public void startgame()
    {
        mainmenuani.SetBool("mainmenu", true);
        StartCoroutine(loadgame());
    }
    IEnumerator loadgame()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Loading");
    }

    public void achimenu()
    {
        achimenuani.SetBool("achimenu", true);
        mainmenuani.SetBool("mainmenu", true);
    }

    public void achiback()
    {
        achimenuani.SetBool("achimenu", false);
        mainmenuani.SetBool("mainmenu", false);
    }
}
