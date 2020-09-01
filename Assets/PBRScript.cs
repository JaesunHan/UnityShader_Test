using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Material 의 값을 참조하는 방법을 알려주기 위한 테스트 코드
/// </summary>
public class PBRScript : MonoBehaviour
{
    /// <summary>
    /// 이 렌더러는 Mesh Renderer 컴포넌트를 참조한다.
    /// </summary>
    public Renderer RD;
    public Material MT;
    public Texture2D T2D;
    public Texture2DArray T2DArray;
    public Texture3D T3D;
    public Cubemap cubemap;

    // Start is called before the first frame update
    void Start()
    {
        RD.material.SetFloat("_Vector1", 1);
        //RD.material.SetInt("_Vector1", 0);
        RD.material.SetVector("_Vector2", new Vector2(0, 1));
        RD.material.SetVector("_Vector3", new Vector3(0, 1, 2));
        RD.material.SetVector("_Vector4", new Vector4(0, 1, 2, 3));
        RD.material.SetColor("_Color", new Color(1, 1, 1, 1));
        RD.material.SetTexture("_Texture2D", T2D);
        RD.material.SetTexture("_Textur2DArray", T2DArray);
        RD.material.SetTexture("_Texture3D", T3D);
        RD.material.SetTexture("_Cubemap", cubemap);
        RD.material.SetInt("_Boolean", 1);

        // ->Material 을 변경할 경우, 이 Material 을 사용하는 모든 오브젝트에도 적용되기 때문에 
        //안전성을 위해 위의 코드와 같이 Renderer 를 변경하도록 한다.
        MT.SetFloat("_Vector1", 1); 
    }
}
