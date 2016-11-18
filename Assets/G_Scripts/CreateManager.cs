using UnityEngine;
using System.Collections;

public class CreateManager : MonoBehaviour
{

    public static CreateManager _instance = null;

    public GameObject[] m_ArrayCloneObj = null;

    public void Awake()
    {
        _instance = this;
    }

    //TStaticV.m_NowIndex



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateNext()
    {
        if (m_ArrayCloneObj == null || m_ArrayCloneObj.Length == 0)
        {
            return;
        }



    }

}
