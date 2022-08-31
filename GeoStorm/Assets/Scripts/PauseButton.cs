using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public void Pause()
    {
        Time.timeScale = 0;

        GameObject.Find("Destroy").SetActive(false);
        GameObject.Find("Don't Destroy/Player").SetActive(false);
        GameObject.Find("Don't Destroy/Canvas/Pause Button").SetActive(false);
        GameObject.Find("Don't Destroy/Canvas/Options Menu Variant").SetActive(true);
    }
}
