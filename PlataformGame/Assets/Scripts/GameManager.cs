using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GUISkin layout;
    Hashtable fases = new Hashtable();
    GameObject spice;
	GameObject waterLife;
	GameObject shield;
	GameObject[] sardaukars;
    private bool shaihulud = false;

	void OnGUI ()
    {
	    GUI.skin = layout;

        searchBladesOfEmperor();

        if (SceneManager.GetActiveScene().name == "menu")
		{
			if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height/2, 120, 53), "Arrakis"))
			{
				Invoke("changeScene", 0.5f);
			}
		}

        if (SceneManager.GetActiveScene().name == "derrota" || SceneManager.GetActiveScene().name == "vitoria")
		{
			if(GUI.Button(new Rect(Screen.width / 2 - 260, Screen.height/2, 120, 53), "Caladan"))
			{
				Invoke("changeScene", 0.5f);
			}

            if (GUI.Button(new Rect(Screen.width / 2 + 160, Screen.height/2, 180, 53), "Salusa Secundus"))
			{
				Application.Quit();
			}
		}
	}

    public void perdeu(){
        Invoke("loadPerdeu", 3.5f);
    }

    public void loadPerdeu(){
        SceneManager.LoadScene("derrota");
    }

    public void venceu(){
        Invoke("loadVenceu", 1.5f);
    }

    public void loadVenceu(){
        SceneManager.LoadScene("vitoria");
    }

    private void restartGameManager(){
		Invoke("changeScene", 0.5f);
	}

    private void changeScene(){
        SceneManager.LoadScene(fases[SceneManager.GetActiveScene().name].ToString());
	}

    private void searchBladesOfEmperor(){
		sardaukars = GameObject.FindGameObjectsWithTag("enemy");
	}

    public void caleche(){
        shaihulud = true;
    }

    void Start()
    {
        fases.Add("menu", "fase1");
        fases.Add("derrota", "menu");
        fases.Add("vitoria", "menu");

        spice = GameObject.FindGameObjectWithTag("melange");
        shield = GameObject.FindGameObjectWithTag("shield");
		waterLife = GameObject.FindGameObjectWithTag("water");

        searchBladesOfEmperor();
    }

    void Update()
    {
        searchBladesOfEmperor();

        if(sardaukars.Length == 0 && shaihulud){
            shield.SendMessage("removeShield", 0.5f, SendMessageOptions.RequireReceiver);
        }
    }
}