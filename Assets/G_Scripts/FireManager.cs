using UnityEngine;
using System.Collections;

public class FireManager : MonoBehaviour {

    public GameObject m_CloneBullet = null;
    private float m_TimeCD = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
#if UNITY_EDITOR
        if (Input.GetKey(KeyCode.Space))
        {
            MakeBullet();
        }
#else
        if (Input.touchCount > 0)
        {
            MakeBullet();
            //Instantiate(m_CloneBullet,gameObject.transform.position, m_CloneBullet.transform.rotation);
        }
#endif

    }

    private void MakeBullet ()
	{
		MathAttLV ();
		if (m_TimeCD < Time.time) {
			m_TimeCD = Time.time + 0.25f;
			if (TStaticV.m_AttLv > 1) 
			{
				SetManyBullet ();
			}
			else
			{
				Instantiate(m_CloneBullet, gameObject.transform.position, m_CloneBullet.transform.rotation);
			}
            //Instantiate(m_CloneBullet, gameObject.transform.position, m_CloneBullet.transform.rotation);
        }
    }

    private void MathAttLV ()
	{
		int _math = 3;
		int _add = 1;
		if (TStaticV.m_KillCount < 16) 
		{
			_math = 5;
			_add =1;
		}
		else if(TStaticV.m_KillCount < 52) 
		{
			_math = 10;
			_add =3;
		}
		else if(TStaticV.m_KillCount < 130) 
		{
			_math = 16;
			_add = 5;
		}
		else 
		{
			_math = 30;
			_add = 9;
		}
		TStaticV.m_AttLv = (TStaticV.m_KillCount / _math) + _add;
		if(TStaticV.m_AttLv>20)
		{
			TStaticV.m_AttLv = 20;
		}
	}

    private void SetManyBullet ()
	{
		float _rotate = -120;
		if (TStaticV.m_AttLv < 5) 
		{
			_rotate = -60;
		}
		else if(TStaticV.m_AttLv < 8) 
		{
			_rotate = -100;
		}
		else if(TStaticV.m_AttLv < 11) 
		{
			_rotate = -120;
		}
		else if (TStaticV.m_AttLv < 14) 
		{
			_rotate = -150;
		}
		else
		{
			_rotate = -165;
		}

		for (int i = 0; i < TStaticV.m_AttLv; i++) 
		{
			
			float math_rotate = _rotate/(TStaticV.m_AttLv-1);
			GameObject c_o = Instantiate(m_CloneBullet, gameObject.transform.position, m_CloneBullet.transform.rotation) as GameObject;
			c_o.transform.Rotate(0,0,_rotate/2-math_rotate*i);
		}
	}
}
