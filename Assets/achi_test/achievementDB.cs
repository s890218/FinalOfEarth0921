using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class achievementDB : MonoBehaviour {

    public static achievementDB _instance;

    public Sprite[] sprites;

    public static List<achievement> allachievement = new List<achievement>();
    public static List<achievement> achievementlist = new List<achievement>();
    
    // Use this for initialization
    void Awake ()
    {
        _instance = this;
        
        achievement a00 = gameObject.AddComponent<achievement>();
        a00.name = "111";
        a00.type = achievement.Type.type_a;
        a00.sprite = sprites[0];
        //allachievement.Add(a00);

        achievement a01 = gameObject.AddComponent<achievement>();
        a01.name = "222";
        a01.type = achievement.Type.type_b;
        a01.sprite = sprites[1];
        //allachievement.Add(a01);

        achievement a02 = gameObject.AddComponent<achievement>();
        a02.name = "333";
        a02.type = achievement.Type.type_c;
        a02.sprite = sprites[2];
        allachievement.Add(a02);
        /*
        achievement a03 = gameObject.AddComponent<achievement>();
        a03.name = "444";
        a03.type = achievement.Type.type_b;
        a03.sprite = sprites[3];
        allachievement.Add(a03);

        achievement a04 = gameObject.AddComponent<achievement>();
        a04.name = "555";
        a04.type = achievement.Type.type_b;
        a04.sprite = sprites[4];
        allachievement.Add(a04);
        */
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
