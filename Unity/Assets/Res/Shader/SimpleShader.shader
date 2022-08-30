Shader "Custom/SimpleShader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }
    SubShader
        {
            Tags { "RenderType" = "Opaque" }
            LOD 200


            Pass
            {
                 CGPROGRAM
                



                 ENDCG

            }

    }
    FallBack "Diffuse"
}
