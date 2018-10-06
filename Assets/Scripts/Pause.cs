using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    public GameObject panel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pause"))
        {
            panel.SetActive(!panel.activeInHierarchy);
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            } else
            {
                Time.timeScale = 1;
            }

        }
	}

    public void SetScene(int index)
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(index);
    }
}
