using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public static bool Activar = false;
	public static bool Enemigo = false;

    [Range(1,100000)]
    public float TimerStart = 100000;
    [Range(1, 100000)]
    public float CurrentTime;
    [HideInInspector]
    public bool TimeStops = false;
    [Header("Texto")]
    public Text TimeText;

	public GameObject panel;
	public GameObject texpn;
	public GameObject texpn2;

    void Start(){
        CurrentTime = TimerStart;
		TimeStops = false;
		panel.SetActive(false);
		texpn.SetActive(false);
		texpn2.SetActive(false);
    }

    private void OnEnable(){
        SetTimeUi();
    }

	void Update () {
        if (CurrentTime >= 0 && TimeStops == false) {
            CurrentTime -= Time.deltaTime;
        }else{
			TimeStops = true;
        }
        SetTimeUi();
    }
    void SetTimeUi(){
        TimeText.text = CurrentTime.ToString("F0");
		if (Activar == true) {
			panel.SetActive (true);
			texpn.SetActive (true);
			TimeStops = false;
            TimeText.text = "##";

        } else if (Activar==false && (Enemigo == true || CurrentTime < 0)) {
			panel.SetActive(true);
			texpn2.SetActive(true);
			TimeStops = true;
		} else {
			panel.SetActive (false);
            texpn.SetActive(false);
            texpn2.SetActive (false);
			TimeStops = false;
			TimerStart = 100000;
		}

    }
   
}
 