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
        float now_Speed = 1.5f * m_Speed * Time.deltaTime * TStaticV.m_TotalSpeed;
        if (m_isLeft&&transform.position.x>-2.1f)
        {
            gameObject.transform.position += new Vector3(-now_Speed, 0, 0);
        }
        if(m_isRight && transform.position.x < 2.1f)
        {
            gameObject.transform.position += new Vector3(now_Speed, 0, 0);
        }
    }

    public float GetSpeed()
    {
        return m_Speed;
    }

    public void SetSpeed(float _speed)
    {
        m_Speed = _speed;
    }
}
