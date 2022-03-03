using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void start1()
    {
        SceneManager.LoadScene("Level01");

    }
    public void start2()
    {
        SceneManager.LoadScene("Level02");
    }
}
