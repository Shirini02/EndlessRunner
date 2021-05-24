using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject Gameoverpanel;
    // Start is called before the first frame update
    public void Restart()
    {
        //canvas.gameObject.SetActive(false);
        SceneManager.LoadScene(0);

    }

}
