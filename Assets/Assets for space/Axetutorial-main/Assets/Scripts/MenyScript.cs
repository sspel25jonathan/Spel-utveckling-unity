using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
public class MenyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Maingame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Setting()
    {
         SceneManager.LoadSceneAsync(2);
    }
}
