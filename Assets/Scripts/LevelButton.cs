using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour {
    public void LoadLevel(string level) {
        SceneManager.LoadScene(level);
    }
}