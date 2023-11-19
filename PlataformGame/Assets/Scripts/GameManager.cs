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

            if(SceneManager.GetActiveScene().name == "vitoria"){
                GUI.Label(new Rect(22, Screen.height-6 - 22, 180, 24)," -=- Vitória -=- ", guiStylePts);
            }else{
                GUI.Label(new Rect(22, Screen.height-6 - 22, 180, 24)," -=- Derrota -=- ", guiStylePts);
            }
		}
        else if(videosCenas())
        {
            if(GUI.Button(new Rect(Screen.width - 90, Screen.height - 26, 80, 22), "Pular"))
			{
                Invoke("changeScene", 0.5f);
			}
        }
        else
        {
            showPlacar();

            if(GUI.Button(new Rect(Screen.width - 150, Screen.height - 26, 140, 22), "Restart Fase"))
			{
                reloadSceneCheckpoint();	
                // Invoke("changeScene", 1.0f);
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

    private bool videosCenas(){
		if(SceneManager.GetActiveScene().name == "abertura"
        || SceneManager.GetActiveScene().name == "intro"
        || SceneManager.GetActiveScene().name == "end"
        || SceneManager.GetActiveScene().name == "video1"
        || SceneManager.GetActiveScene().name == "video2"
        || SceneManager.GetActiveScene().name == "video3"
        || SceneManager.GetActiveScene().name == "video4"
        || SceneManager.GetActiveScene().name == "video5"
        || SceneManager.GetActiveScene().name == "video6"
        || SceneManager.GetActiveScene().name == "video7"
        || SceneManager.GetActiveScene().name == "video8"
        || SceneManager.GetActiveScene().name == "video9")
        {
			return true;
        }
		else
		{
			return false;
		}
	}

    void Start()
    {
        fases.Add("abertura", "menu");
        fases.Add("menu", "intro");
        fases.Add("derrota", "end");
        fases.Add("vitoria", "end");
        fases.Add("end", "menu");
        fases.Add("intro", "fase1");
        fases.Add("fase1", "video1");
        fases.Add("video1", "fase2");
        fases.Add("fase2", "video2");
        fases.Add("video2", "fase3");
        fases.Add("fase3", "video3");
        fases.Add("video3", "fase4");
        fases.Add("fase4", "video4");
        fases.Add("video4", "fase5");
        fases.Add("fase5", "video5");
        fases.Add("video5", "fase6");
        fases.Add("fase6", "video6");
        fases.Add("video6", "fase7");
        fases.Add("fase7", "video7");
        fases.Add("video7", "fase8");
        fases.Add("fase8", "video8");
        fases.Add("video8", "fase9");
        fases.Add("fase9", "video9");
        fases.Add("video9", "fase10");

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