using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemList : MonoBehaviour {

    public GameObject canvas;
    public GameObject ItemPanelPrefab;

    GameObject[] ip;
    int list_items;

    // Use this for initialization
    void Start () {
        Debug.Log("start");

        list_items = 10;
        ip = new GameObject[list_items];

        canvas.transform.position = new Vector3(0, 0, 0);   // canvas reset

        for(int i=0;i<list_items;i++)
        {
            ip[i] = Instantiate(ItemPanelPrefab) as GameObject;
            ip[i].transform.SetParent(canvas.transform, false);
            ip[i].transform.position = new Vector3(0, 192-(i*64), 0);

            GameObject tb = ip[i].transform.FindChild("ItemTextBig").gameObject;
            tb.GetComponent<Text>().text = "北海道コンサドーレ札幌";

            GameObject ts = ip[i].transform.FindChild("ItemTextSmall").gameObject;
            ts.GetComponent<Text>().text = "Hokkaido Consadole Sapporo";

            Sprite ii_sprite = Resources.Load<Sprite>("test/test0");
            GameObject ii = ip[i].transform.FindChild("ItemImage").gameObject;
            ii.GetComponent<Image>().sprite = ii_sprite;

            float red   =   1.0f;
            float green =   1.0f;
            float blue  =   0.0f;
            float alpha =   0.5f;
            ip[i].GetComponent<Image>().color = new Color(red, green, blue, alpha);

        }
        /*
                ip[0] = Instantiate(ItemPanelPrefab) as GameObject;
                ip[0].transform.SetParent(canvas.transform, false);
                ip[0].transform.position = new Vector3(0,0,0);
                Debug.Log(ip[0].transform.position);
                Debug.Log(canvas.transform.position);
        */
    }

    // Update is called once per frame
    void Update () {
     }
}
