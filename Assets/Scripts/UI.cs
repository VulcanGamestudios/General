using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetScene (int index)
    {
        SceneManager.LoadSceneAsync(index);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
