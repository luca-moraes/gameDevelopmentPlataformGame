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
    private GUIStyle guiStylePts = new GUIStyle();


    private void setPtsStyle(){
		guiStylePts.fontSize = 22;
		guiStylePts.normal.textColor = new Color(237.0f/255.0f, 145.0f/255.0f, 33.0f/255.0f, 1.0f);

		Texture2D debugTex = new Texture2D(1,1);
	  	debugTex.SetPixel(0,0, new Color(31.0f/255.0f, 21.0f/255.0f, 14.0f/255.0f, 0.98f));
	  	debugTex.Apply();

		guiStylePts.normal.background = debugTex;
	}

    void showPlacar(){
		GUI.Label(new Rect(22, Screen.height-2 - 22, 305, 22), SceneManager.GetActiveScene().name + ": Life: " + FremenManager.leto.jessica + " || Spice: " + FremenManager.leto.spice, guiStylePts);
	}

	void OnGUI ()
    {
	    GUI.skin = layout;

        searchBladesOfEmperor();

        if (SceneManager.GetActiveScene().name == "menu")
		{
			if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height/2, 190, 53), "Arrakis (Play Game)"))
			{
				Invoke("changeScene", 0.5f);
			}
		} 
        else if (SceneManager.GetActiveScene().name == "derrota" || SceneManager.GetActiveScene().name == "vitoria")
		{
			if(GUI.Button(new Rect(Screen.width / 2 - 360, Screen.height/2, 180, 53), "Caladan (Menu)"))
			{
				restartGameManager();
			}

            if (GUI.Button(new Rect(Screen.width / 2 + 160, Screen.height/2, 290, 53), "Salusa Secundus (Close Game)"))
			{
				Application.Quit();
			}
		}else{
            showPlacar();

            if(GUI.Button(new Rect(Screen.width - 150, Screen.height - 26, 140, 22), "Restart Fase"))
			{
                Invoke("changeScene", 1.0f);
                // reloadSceneCheckpoint();	
			}
        }
	}

    public void perdeu(){
        if(SceneManager.GetActiveScene().name == "fase10"){
            Invoke("loadPerdeu", 1.5f);
        }else{
            Invoke("reloadSceneCheckpoint", 2.5f);
        }
    }

    private void reloadSceneCheckpoint(){
        FremenManager.resetFase();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void loadPerdeu(){
        SceneManager.LoadScene("derrota");
    }

    public void venceu(){
        if(SceneManager.GetActiveScene().name == "fase10"){
            Invoke("loadVenceu", 1.5f);
        }else{
            Invoke("changeScene", 1.0f);
        }
    }

    public bool faseComplete(){
        return shaihulud && sardaukars.Length == 0;
    }

    public bool morto(){
        return (FremenManager.leto.jessica - 1) == 0;
    }

    public void ferido(){
        FremenManager.leto.jessica -= 1;
    }

    public void prescienciaDeCura(){
        FremenManager.leto.spice += 1;
        FremenManager.leto.jessica += 1;
    }

    public void loadVenceu(){
        SceneManager.LoadScene("vitoria");
    }

    private void restartGameManager(){
        FremenManager.resetAll();
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
        fases.Add("fase1", "fase2");
        fases.Add("fase2", "fase3");
        fases.Add("fase3", "fase4");
        fases.Add("fase4", "fase5");
        fases.Add("fase5", "fase6");
        fases.Add("fase6", "fase7");
        fases.Add("fase7", "fase8");
        fases.Add("fase8", "fase9");
        fases.Add("fase9", "fase10");

        spice = GameObject.FindGameObjectWithTag("melange");
        shield = GameObject.FindGameObjectWithTag("shield");
		waterLife = GameObject.FindGameObjectWithTag("water");

        setPtsStyle();
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