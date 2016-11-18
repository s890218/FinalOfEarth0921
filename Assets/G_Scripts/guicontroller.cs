using UnityEngine;
using System.Collections;

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
