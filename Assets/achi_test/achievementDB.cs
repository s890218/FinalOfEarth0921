using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class achievementDB : MonoBehaviour {

    public static achievementDB _instance;

    public Sprite[] sprites;
    
    public static List<achievement> allachievement = new List<achievement>();
    public static List<achievement> achievementlist = new List<achievement>();
    
    void Awake ()
    {
        _instance = this;
        
        achievement a00 = gameObject.AddComponent<achievement>();
        a00.name = "Rock1";
        a00.type = achievement.Type.type_a;
        a00.sprite = sprites[0];

        achievement a01 = gameObject.AddComponent<achievement>();
        a01.name = "Rock2";
        a01.type = achievement.Type.type_b;
        a01.sprite = sprites[1];

        achievement a02 = gameObject.AddComponent<achievement>();
        a02.name = "Rock3";
        a02.type = achievement.Type.type_c;
        a02.sprite = sprites[2];
        
        achievement a03 = gameObject.AddComponent<achievement>();
        a03.name = "Rock4";
        a03.type = achievement.Type.type_d;
        a03.sprite = sprites[3];

        achievement a04 = gameObject.AddComponent<achievement>();
        a04.name = "Rock5";
        a04.type = achievement.Type.type_e;
        a04.sprite = sprites[4];
        

        if (PlayerPrefs.GetInt("rock01") != 0)
        {
            allachievement.Add(a00);
        }
        if (PlayerPrefs.GetInt("rock02") != 0)
        {
            allachievement.Add(a01);
        }
        if (PlayerPrefs.GetInt("rock03") != 0)
        {
            allachievement.Add(a02);
        }
        if (PlayerPrefs.GetInt("rock04") != 0)
        {
            allachievement.Add(a03);
        }
        if (PlayerPrefs.GetInt("rock05") != 0)
        {
            allachievement.Add(a04);
        }
        sortallachi();
    }
    public void addachievement(achievement achi)
    {
        allachievement.Add(achi);
        sortallachi();
    }
    
    public void sortallachi()
    {
        achievementlist.Clear();
        foreach(achievement aa in allachievement)
        {
            achievementlist.Add(aa);
        }
    }
}
