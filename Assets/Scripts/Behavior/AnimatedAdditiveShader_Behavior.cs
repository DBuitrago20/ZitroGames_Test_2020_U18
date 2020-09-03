using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ZitroGamesTest {
    public class AnimatedAdditiveShader_Behavior : MonoBehaviour
    {

        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        //////---------------------------------ADDITIVE-SHADER-BEHAVIOR--------------------------------////////
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        private Renderer this_renderer;
        private float offset_value_timer;
        private void Loading_Animated_Additive_Shader_Parameters()
        {
            this_renderer = GetComponent<Renderer>();
            offset_value_timer = -1;
        }

        private void Update_Animated_Shader_Progress()
        {
            offset_value_timer += Time.deltaTime;       
            this_renderer.material.mainTextureOffset = new Vector2(offset_value_timer, 0);

            //---Resets progress
            if (offset_value_timer >= 1)
            {
                offset_value_timer = -1;
            }
        }








        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        //////----------------------------------AWAKE/START/UPDATE----------------------------------////////
        //////<<<<<<<<<<<<<-------------------------------------------------------------->>>>>>>>>>>////////
        private void Awake()
        {
            Loading_Animated_Additive_Shader_Parameters();
        }



        private void Update()
        {
            Update_Animated_Shader_Progress();
        }
    }
}
