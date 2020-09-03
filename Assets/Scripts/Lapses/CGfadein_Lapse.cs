using UnityEngine;


namespace ZitroGamesTest {
    public class CGfadein_Lapse : MonoBehaviour
    {

        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        //////---------------------------------CANVAS-GROUP-FADE-IN---------------------------------////////
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        CanvasGroup cg;
        private float timer;
        private float speed = 1.8f;
        private void Loading_Parameters()
        {
            cg = GetComponent<CanvasGroup>();

        }

        private void Update_Canvas_Group_Fades_In_Progress()
        {
            timer += Time.deltaTime * speed;
            cg.alpha = timer;
            if (timer >= 1)
            {
                cg.alpha = 1;
                cg.interactable = true;
                cg.blocksRaycasts = true;
                Destroy(GetComponent<CGfadein_Lapse>());
            }
        }






        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        //////----------------------------------AWAKE/START/UPDATE----------------------------------////////
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        private void Awake()
        {
            Loading_Parameters();
        }

        private void Update()
        {
            Update_Canvas_Group_Fades_In_Progress();
        }

    }
}
