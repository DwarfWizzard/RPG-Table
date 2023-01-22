using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_roll : MonoBehaviour
{
    public static bool DiceIsOpened = false;
    public GameObject diceMenuUI;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) || DiceIsOpened && Input.GetKeyDown(KeyCode.Escape))
	{
		if (DiceIsOpened)
			Resume();
		else
			Pause();
	}
    }

    public void Resume()
    {
	diceMenuUI.SetActive(false);
	Time.timeScale = 1f;
	DiceIsOpened = false;
    }

    void Pause()
    {
	diceMenuUI.SetActive(true);
	Time.timeScale = 0f;
	DiceIsOpened = true;
    }

    public void RollD4()
    {
	int value = Random.Range(1, 5);
	Debug.Log(value);
    }

    public void RollD6()
    {
	int value = Random.Range(1, 7);
	Debug.Log(value);
    }

    public void RollD8()
    {
	int value = Random.Range(1, 9);
	Debug.Log(value);
    }
 
    public void RollD10()
    {
	int value = Random.Range(1, 11);
	Debug.Log(value);
    }

    public void DollD12()
    {
	int value = Random.Range(1, 13);
	Debug.Log(value);
    }

    public void RollD20()
    {
	int value = Random.Range(1, 21);
	Debug.Log(value);
    }
}
