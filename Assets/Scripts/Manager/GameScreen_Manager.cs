using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ZitroGamesTest {
    public class GameScreen_Manager : MonoBehaviour
    {

        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        //////-------------------------------------GAME-SCREEN--------------------------------------////////
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        private CanvasGroup main_panel_canvas_group;
        private Button game_1_button;
        private Button game_2_button;
        private Button game_3_button;
        private Button back_button;
        private Text utc_text;

        public GameObject game_1_prefab;
        public GameObject game_2_prefab;
        public GameObject game_3_prefab;
        private GameObject current_game_prefab;

        private void Loading_Game_Screen_Parameters()
        {
            main_panel_canvas_group = transform.Find("Main_Panel_Canvas_Group").GetComponent<CanvasGroup>();
            game_1_button = main_panel_canvas_group.gameObject.transform.Find("Game_1_Button").GetComponent<Button>();
            game_2_button = main_panel_canvas_group.gameObject.transform.Find("Game_2_Button").GetComponent<Button>();
            game_3_button = main_panel_canvas_group.gameObject.transform.Find("Game_3_Button").GetComponent<Button>();
            back_button = transform.Find("Back_Button").GetComponent<Button>();

            utc_text = main_panel_canvas_group.gameObject.transform.Find("Utc_Text").GetComponent<Text>();

            game_1_button.onClick.AddListener(() => { On_Game_Button_Pressed(1); });
            game_2_button.onClick.AddListener(() => { On_Game_Button_Pressed(2); });
            game_3_button.onClick.AddListener(() => { On_Game_Button_Pressed(3); });

            back_button.onClick.AddListener(() => { On_Back_Button_Pressed(); });
        }

        private void On_Game_Button_Pressed(int incoming_button_index)
        {
            if(incoming_button_index == 1)
            {
                if(game_1_prefab != null)
                {
                    current_game_prefab = Instantiate(game_1_prefab);
                    main_panel_canvas_group.gameObject.AddComponent<CGfadeout_Lapse>();
                    back_button.gameObject.AddComponent<CGfadein_Lapse>();
                }

                else
                {
                    Debug.LogError("Prefab 1 Not Found");
                    return;
                }
                
            }

            if (incoming_button_index == 2)
            {
                if (game_2_prefab != null)
                {
                    current_game_prefab = Instantiate(game_2_prefab);
                    main_panel_canvas_group.gameObject.AddComponent<CGfadeout_Lapse>();
                    back_button.gameObject.AddComponent<CGfadein_Lapse>();
                }

                else
                {
                    Debug.LogError("Prefab 2 Not Found");
                    return;
                }
            }

            if (incoming_button_index == 3)
            {
                if (game_3_prefab != null)
                {
                    current_game_prefab = Instantiate(game_3_prefab);
                    main_panel_canvas_group.gameObject.AddComponent<CGfadeout_Lapse>();
                    back_button.gameObject.AddComponent<CGfadein_Lapse>();
                }

                else
                {
                    Debug.LogError("Prefab 3 Not Found");
                    return;
                }
            }
        }

        private void On_Back_Button_Pressed()
        {
            if(current_game_prefab != null)
            {
                Destroy(current_game_prefab.gameObject);
                back_button.gameObject.AddComponent<CGfadeout_Lapse>();
                main_panel_canvas_group.gameObject.AddComponent<CGfadein_Lapse>();
            }
        }


        private void Update_Date_And_Time_Rest_Function()
        {
            utc_text.text = System.DateTime.UtcNow.ToString();
        }


        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        //////----------------------------------AWAKE/START/UPDATE----------------------------------////////
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        private void Awake()
        {
            Loading_Game_Screen_Parameters();
        }

        private void Update()
        {
            Update_Date_And_Time_Rest_Function();
        }

    }
}
