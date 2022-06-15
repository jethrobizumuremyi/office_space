using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCustomizer : MonoBehaviour
{
    [SerializeField] Color[] allColors;
    public void SetColor(int colorIndex)
    {
        PlayerController.localPlayer.SetColor(allColors[colorIndex]);
    }
    public void NextScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}