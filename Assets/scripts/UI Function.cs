using System;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class UIFunction : MonoBehaviour
{
    public AudioSource background;
    public AudioSource click;
    public Material day;
    public Material night;
    public Light sun;

    public AudioMixer gameMixer;

    public void switchScene(String SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void continueTheGame()
    {

        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void BackgroundSound(Boolean x)
    {
        if (x == true)
            background.Play();

        else
            background.Stop();
    }

    public void ButtonClickSound()
    {
        click.Play();
    }

    public void toDay()
    {
        RenderSettings.skybox = day;
        sun.intensity = 1.5f;
    }

    public void toNight()
    {
        RenderSettings.skybox = night;
        sun.intensity = 0.2f;
    }
    

    public void TurnOnMusic(Boolean x)
    {
        if (x == false)
            gameMixer.SetFloat("Music", -80); // mute

        else
            gameMixer.SetFloat("Music", 0); // default volum
    }

  
  

}
