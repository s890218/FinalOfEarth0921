using UnityEngine;
using System.Collections;

public class TStaticV : MonoBehaviour
{

    public static float m_TotalSpeed = 1;
    public static bool m_GameStart = false;
    public static int m_NowIndex = 0;   //目前第幾個關卡
    public static int m_NowRockRank = 5;    //目前出石頭的機率

    public static float m_KillScore = 0;

    public void Awake()
    {
        //初始化
        m_TotalSpeed = 1;
        m_NowIndex = 0;
        m_NowRockRank = 5;
        m_KillScore = 0;
    }
}
