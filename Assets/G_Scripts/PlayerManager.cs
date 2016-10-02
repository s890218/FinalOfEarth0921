using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    private float m_Speed = 1;

    private bool m_isLeft = false;
    private bool m_isRight = false;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            m_isLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            m_isLeft = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            m_isRight = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            m_isRight = false;
        }


        SetMove();
    }

    private void SetMove()
    {
        if (m_isLeft)
        {
            gameObject.transform.position += new Vector3(-0.5f * m_Speed*Time.deltaTime, 0, 0);
        }
        if(m_isRight)
        {
            gameObject.transform.position += new Vector3(0.5f * m_Speed * Time.deltaTime, 0, 0);
        }
    }
}
