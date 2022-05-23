using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingScript : MonoBehaviour
{
    PlayerData playerData;
    // Start is called before the first frame update
    private float music, sound;
    private int graphic, language;
    public Slider musicSlider, soundSlider;
    public Dropdown graphicDropdown, languageDropdown;
    private void Awake()
    {
        
        SetUpSliderAndDropDown();
        LoadPlayerData();

    }
    void Start()
    {
        

        DisplayPlayerDataSetting();
    }

    // Update is called once per frame
    void Update()
    {
        playerData.music = musicSlider.value;
        playerData.sound = soundSlider.value;
        playerData.graphic = graphicDropdown.value;
        playerData.language = languageDropdown.value;
        SavePlayerData();
    }
    public void SavePlayerData()
    {
        SaveManager.Save(playerData);
    }
    public void SetUpSliderAndDropDown()
    {
        musicSlider = GameObject.Find("MusicSlider").GetComponent<Slider>();
        soundSlider = GameObject.Find("SoundSlider").GetComponent<Slider>();
        musicSlider.maxValue = 100;
        musicSlider.minValue = 0;
        soundSlider.maxValue = 100;
        soundSlider.minValue = 0;          
        graphicDropdown = GameObject.Find("GraphicDropdown").GetComponent<Dropdown>();
        languageDropdown = GameObject.Find("LanguageDropdown").GetComponent<Dropdown>();
    }
    public void LoadPlayerData()
    {
        playerData = SaveManager.Load();
        if (playerData == null)
        {
            playerData = new PlayerData(100, 100, 0, 0);
            SaveManager.Save(playerData);
        }
       
    }
    public void DisplayPlayerDataSetting()
    {
        musicSlider.value = playerData.music;
        soundSlider.value = playerData.sound;
        graphicDropdown.value = playerData.graphic;
        languageDropdown.value = playerData.language;
    }
}
