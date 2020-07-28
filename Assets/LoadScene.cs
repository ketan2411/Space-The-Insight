using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour

{
    public void change()
    
{
        
UnityEngine.SceneManagement.SceneManager.LoadScene("scene2",LoadSceneMode.Single);
    
}
}
