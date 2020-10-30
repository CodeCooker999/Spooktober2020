using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public LevelLoader levelLoader;

    public void Play()
    {
        SceneManager.LoadScene("LevelSelection");
        Debug.Log("Play");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credits");
        Debug.Log("Credits");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void Level1()
    {
        levelLoader.LoadLevel(3);
    }

    public void Level2()
    {

    }

    public void Level3()
    {

    }

    public void Level4()
    {

    }

    public void Level5()
    {

    }

    public void Level6()
    {

    }

}
