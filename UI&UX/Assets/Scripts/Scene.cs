using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void LoadUIandUXAssignmentScene()
    {
        // Load the "UIandUXAssignment" scene
        SceneManager.LoadScene("Game");
    }

    public void LoadLostScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Load the "Lost" scene
        SceneManager.LoadScene(currentSceneIndex);
    }
   
}
