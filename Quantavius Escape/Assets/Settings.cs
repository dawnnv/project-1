using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public string sceneSettings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Testing
    // Added another comment
    // Added a third comment
    void Update()
    {
        
    }

    public void settingsScene()
    {
        SceneManager.LoadScene(sceneSettings);
    }
}
