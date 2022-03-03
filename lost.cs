using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class lost : MonoBehaviour
{
    public void reset()
    {
        SceneManager.LoadScene("Level01");

    }
    public void reset2()
    {
        SceneManager.LoadScene("Level02");
    }
}
