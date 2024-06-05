using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsPanel;
    public Slider soundEffectsSlider;
    public Slider musicVolumeSlider;

    private void Start()
    {
        // Inicialmente oculta el panel de opciones
        optionsPanel.SetActive(false);
    }

    public void OpenOptions()
    {
        // Mostrar el panel de opciones
        optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        // Ocultar el panel de opciones
        optionsPanel.SetActive(false);
    }

    public void SetSoundEffectsVolume(float volume)
    {
        // Aquí puedes ajustar el volumen de los efectos sonoros
        Debug.Log("Sound Effects Volume: " + volume);
    }

    public void SetMusicVolume(float volume)
    {
        // Aquí puedes ajustar el volumen de la música
        Debug.Log("Music Volume: " + volume);
    }
}