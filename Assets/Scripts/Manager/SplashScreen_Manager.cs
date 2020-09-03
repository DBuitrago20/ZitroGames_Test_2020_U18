using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace ZitroGamesTest
{
    public class SplashScreen_Manager : MonoBehaviour
    {
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        //////------------------------------------SPLASH-SCREEN-------------------------------------////////
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        private Scrollbar loading_scrollbar;
        private Text loading_progress_text;
        private float loading_timer;
        private int loading_progress_int;
        private const float loading_limit_time = 5f;
        private bool splash_screen_is_loading;

        private void Loading_Splash_Screen_Parameters()
        {
            loading_scrollbar = transform.Find("Loading_Scrollbar").GetComponent<Scrollbar>();
            loading_progress_text = transform.Find("Loading_Progress_Text").GetComponent<Text>();

            splash_screen_is_loading = true;
        }

        private void Update_Fictional_Loading_Bar_Progress()
        {
            if(splash_screen_is_loading)
            {
                loading_timer += Time.deltaTime;

                loading_scrollbar.size = loading_timer / loading_limit_time;

                loading_progress_int = Mathf.FloorToInt((loading_timer / loading_limit_time) * 100);
                loading_progress_text.text = loading_progress_int.ToString() + "%";

                if (loading_timer >= loading_limit_time)
                {
                    splash_screen_is_loading = false;
                    //Loads Game Scene
                    SceneManager.LoadScene(1);

                }
            }

            else
            {
                return;
            }
            

        }





        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        //////----------------------------------AWAKE/START/UPDATE----------------------------------////////
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        private void Awake()
        {
            Loading_Splash_Screen_Parameters();
        }


        private void Update()
        {
            Update_Fictional_Loading_Bar_Progress();
        }


    }
}
