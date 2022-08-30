// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Toon/BasicOutlineImgTou" 
{
    Properties
    {
        _MainTex("main tex",2D) = ""{}
        _Factor("factor",Range(0,0.1)) = 0.01//描边粗细因子
        _OutLineColor("outline color",Color) = (0,0,0,1)//描边颜色
		//_Color ("Main Tint", Color) = (1,1,1,1)
        _AlphaScale("Alpha Scale",Range(0,1)) = 1
    }
 
    SubShader 
    {
        Tags{"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent"}
        Pass
		{
			ZWrite On
			ColorMask 0
		}

        Pass
        {
            Cull Back //剔除后面
            Blend SrcAlpha OneMinusSrcAlpha
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            struct v2f
            {
                float4 vertex :POSITION;
                float4 uv:TEXCOORD0;
            };
 
            sampler2D _MainTex;
            fixed _AlphaScale;
            //fixed4 _Color;
 
            v2f vert(appdata_full v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.texcoord;
                return o;
            }
 
            half4 frag(v2f IN) :COLOR
            {
                //return half4(1,1,1,1);
                half4 c = tex2D(_MainTex,IN.uv);
                c.a = c.a*_AlphaScale;
                return c;
            }
            ENDCG
        }
        Pass
        {
            Cull Front //剔除前面
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            struct v2f
            {
                float4 vertex :POSITION;
            };
 
            float _Factor;
            half4 _OutLineColor;
 
            v2f vert(appdata_full v)
            {
                v2f o;
                //v.vertex.xyz += v.normal * _Factor;
                //o.vertex = mul(UNITY_MATRIX_MVP,v.vertex);
 
                //变换到视坐标空间下，再对顶点沿法线方向进行扩展
                float4 view_vertex = mul(UNITY_MATRIX_MV,v.vertex);
                float3 view_normal = mul((float3x3)UNITY_MATRIX_IT_MV,v.normal);
                view_vertex.xyz += normalize(view_normal) * _Factor; //记得normalize
                o.vertex = mul(UNITY_MATRIX_P,view_vertex);
				//fixed4 texColor = tex2D(_MainTex, i.uv);
                return o;
            }
 
            half4 frag(v2f IN):COLOR
            {
                //return half4(0,0,0,1);
                return _OutLineColor;
            }


            ENDCG
        }
 
        
        
    } 
    FallBack "Diffuse"
}
