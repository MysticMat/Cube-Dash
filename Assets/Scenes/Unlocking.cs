using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocking : MonoBehaviour
{
    public int levelToUnlock;
    int numberOfUnlockedLevels;
    public GameObject SucessCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            SucessCanvas.SetActive(true);

            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");

            if(numberOfUnlockedLevels <= levelToUnlock) {

                PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
            }
        }
    }
    public void DeltaTimePaused()
    {
        Time.timeScale = 0f;
    }
    public void DeltaTimeResume()
    {
        Time.timeScale = 1f;
    }
}