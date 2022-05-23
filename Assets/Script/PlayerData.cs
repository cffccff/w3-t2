[System.Serializable]

public class PlayerData 
{
    public float sound, music;
    public int graphic, language;
    public PlayerData()
    {

    }
    public PlayerData(float sound, float music, int graphic, int language)
    {
        this.sound = sound;
        this.music = music;
        this.graphic = graphic;
        this.language = language;
    }
    //public float GetSound()
    //{
    //    return this.sound;
    //}
    //public void SetSound(float value)
    //{
    //    this.sound = value;
    //}

    //public float GetMusic()
    //{
    //    return this.music;
    //}
    //public void SetMusic(float value)
    //{
    //    this.music = value;
    //}

    //public float GetGraphic()
    //{
    //    return this.graphic;
    //}
    //public void SetGraphic(int value)
    //{
    //    this.graphic = value;
    //}

    //public float GetLanguage()
    //{
    //    return this.language;
    //}
    //public void SetLanguage(int value)
    //{
    //    this.language = value;
    //}
    public override string ToString()
    {
        return base.ToString() + ": " + sound.ToString() + ", " +music.ToString() + ", " + graphic.ToString() + ": " + language.ToString();
    }
}
