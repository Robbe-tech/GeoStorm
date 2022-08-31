using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public TMP_Text masterLabel, musicLabel, sfxLabel;
    public Slider masterSlider, musicSlider, sfxSlider;

    public void Awake()
    {
        float vol;
        audioMixer.GetFloat("MasterVol", out vol);
        masterSlider.value = vol;
        audioMixer.GetFloat("MusicVol", out vol);
        musicSlider.value = vol;
        audioMixer.GetFloat("SFXVol", out vol);
        sfxSlider.value = vol;

        masterLabel.text = Mathf.RoundToInt(masterSlider.value + 80).ToString();
        musicLabel.text = Mathf.RoundToInt(musicSlider.value + 80).ToString();
        sfxLabel.text = Mathf.RoundToInt(sfxSlider.value + 80).ToString();
    }
    public void SetMasterVol()
    {
        masterLabel.text = Mathf.RoundToInt(masterSlider.value + 80).ToString();

        audioMixer.SetFloat("MasterVol", masterSlider.value);

        PlayerPrefs.SetFloat("MasterVol", masterSlider.value);
    }

    public void SetMusicVol()
    {
        musicLabel.text = Mathf.RoundToInt(musicSlider.value + 80).ToString();

        audioMixer.SetFloat("MusicVol", musicSlider.value);

        PlayerPrefs.SetFloat("MusicVol", musicSlider.value);
    }

    public void SetSFXVol()
    {
        sfxLabel.text = Mathf.RoundToInt(sfxSlider.value + 80).ToString();

        audioMixer.SetFloat("SFXVol", sfxSlider.value);

        PlayerPrefs.SetFloat("SFXVol", sfxSlider.value);
    }

    public void Back()
    {
        Time.timeScale = 1;

        GameObject.Find("Destroy").SetActive(true);
        GameObject.Find("Don't Destroy/Player").SetActive(true);
        GameObject.Find("Don't Destroy/Canvas/Pause Button").SetActive(true);
        GameObject.Find("Don't Destroy/Canvas/Options Menu Variant").SetActive(false);
    }

    public void GoMenu()
    {
        Time.timeScale = 1;

        GameObject.Find("Don't Destroy/Canvas/Options Menu Variant").SetActive(false);
        Destroy(GameObject.Find("Don't Destroy"));                  //Destroy hud and player

        SceneManager.LoadScene(0);
    }
}
