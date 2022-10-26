using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasSript : MonoBehaviour
{
  
    void Start()
    {
         GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
   public void restart()
    {
        SceneManager.LoadScene("first");
}
 
    
}
