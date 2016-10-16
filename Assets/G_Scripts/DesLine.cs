using UnityEngine;
using System.Collections;

public class DesLine : MonoBehaviour
{

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
        if (other != null)
        {
            Destroy(other.gameObject);
        }
    }
}
