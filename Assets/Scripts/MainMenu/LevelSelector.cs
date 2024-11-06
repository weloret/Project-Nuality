using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenLoadouts() 
    {
        SceneManager.LoadScene("Loadout Selection");
    }
}
