using UnityEngine;
using System.Collections;

public class DesLine : MonoBehaviour
{
    public bool m_isBack = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (m_isBack == true)
        {
            if (other != null)
            {
                Destroy(other.gameObject);
            }
        }
        else
        {
            if (other != null&& other.tag=="bullet")
            {
                Destroy(other.gameObject);
            }
        }
    }
}
