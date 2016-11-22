using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour
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
        if (other.tag == "bullet")
        {
            return;
        }
        //Debug.Log("YOU LOSE");
        PlayerManager._instance.SetGameOver();
    }
}
