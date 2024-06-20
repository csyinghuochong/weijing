using UnityEngine;

namespace AllIn1VfxToolkit
{
    //This component sets a global time shader variable that will be used in the shader
    //For this to work please activate the "Use Custom Time" toggle in Advanced Configuration
    //This is useful for shaders that use time but you want to control the time from a script, specially to keep an effect running when the game is paused
    [ExecuteInEditMode]
    public class SetAllIn1VfxCustomGlobalTime : MonoBehaviour
    {
        private int globalTime;
        private Vector4 timeVector;

        private void Start()
        {
            globalTime = Shader.PropertyToID("globalCustomTime");
        }

        private void Update()
        {
            timeVector.x = Time.unscaledTime / 20f;
            timeVector.y = Time.unscaledTime;
            timeVector.z = Time.unscaledTime * 2f;
            timeVector.w = Time.unscaledTime * 3f;
            Shader.SetGlobalVector(globalTime, timeVector);
        }
    }
}