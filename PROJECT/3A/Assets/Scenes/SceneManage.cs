using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    private int timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;
        if (timer >= 200) Player_Info.ended = false;
    }

    public void Button_LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
