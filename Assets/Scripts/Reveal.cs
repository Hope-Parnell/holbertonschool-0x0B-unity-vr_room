//Shady
using UnityEngine;

[ExecuteInEditMode]
public class Reveal : MonoBehaviour
{
    [SerializeField] Material Mat;
    [SerializeField] Light SpotLight;

	void Update ()
    {
        if (SpotLight.isActiveAndEnabled){
            Mat.SetVector("MyLightPosition",  SpotLight.transform.position);
            Mat.SetVector("MyLightDirection", -SpotLight.transform.forward );
            Mat.SetFloat("MyLightAngle", SpotLight.spotAngle         );
        } else {
            Mat.SetVector("MyLightPosition",  new Vector4(0,0,0,0));
            Mat.SetVector("MyLightDirection", new Vector4(0,0,1,0) );
            Mat.SetFloat("MyLightAngle", 45         );
        }
    }//Update() end
}//class end
