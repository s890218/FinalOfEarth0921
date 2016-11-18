using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cabinetcontroller : MonoBehaviour {

    public Transform selectedItem, selectedSlot, originalSlot;

    public GameObject slotPrefab, itemPrefab;
    public Vector2 invetorySize = new Vector2(18, 1);
    public float slotSize;
    public Vector2 windowSize;

    public bool canDragItem = false;
    // Use this for initialization
    
    void Start ()
    {
        _achi();
        transform.position = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}
    
    
    public void _achi()
    { 
        
        foreach (Transform t in this.transform)
        {
            Destroy(t.gameObject);
        }
        for (int x = 1; x <= invetorySize.x; x++)
        {
            for (int y = 1; y <= invetorySize.y; y++)
            {
                GameObject slot = Instantiate(slotPrefab) as GameObject;
                slot.transform.SetParent(this.transform);
                slot.name = "Slot_" + x + "_" + y;
                slot.GetComponent<RectTransform>().anchoredPosition = new Vector3(windowSize.x / (invetorySize.x + 1) * x, windowSize.y / (invetorySize.y + 1) * -y, 0);

                if ((x + (y - 1) * 18) <= achievementDB.achievementlist.Count)
                {
                    GameObject item = Instantiate(itemPrefab) as GameObject;
                    item.transform.SetParent(slot.transform);
                    item.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
                    achievement a = item.GetComponent<achievement>();

                    a.name = achievementDB.achievementlist[(x + (y - 1) * 4) - 1].name;
                    a.type = achievementDB.achievementlist[(x + (y - 1) * 4) - 1].type;
                    a.sprite = achievementDB.achievementlist[(x + (y - 1) * 4) - 1].sprite;

                    item.name = a.name;
                    item.GetComponent<Image>().sprite = a.sprite;
                }

            }
        }
        
    }
}
