using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_SetToOrigin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateAppearance()
    {
        GameObject.Find("Player").GetComponentInChildren<Player_Appearance>().UpdateAppearance();
    }
}
