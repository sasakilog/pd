using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour {

    public GameObject canvas;
    public GameObject ItemPanelPrefab;

    GameObject ip;

	// Use this for initialization
	void Start () {
        Debug.Log("start");
        ip = Instantiate(ItemPanelPrefab) as GameObject;
        ip.transform.SetParent(canvas.transform, false);
       // ip.transform.position = new Vector3(0,0,0);

    }

    // Update is called once per frame
    void Update () {
        ip.transform.position.y--;
     }
}
