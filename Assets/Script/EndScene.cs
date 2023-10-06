using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour//when player tag object collides with gameobject go to the scene
{
    public string SceneName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}