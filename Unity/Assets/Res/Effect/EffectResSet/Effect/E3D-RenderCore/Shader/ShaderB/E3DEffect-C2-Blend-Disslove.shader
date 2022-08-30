// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// 溶解特效shader

Shader "E3DEffect/C1/Blend-Disslove"
{
	Properties
	{
		_TintColor("Color&Alpha", Color) = (1,1,1,1)
		_MainTex ("Texture", 2D) = "white" {}
		_MaskTex("Mask", 2D) = "black"{}
		_MaskScale("Mask Scale", float) = 1
	}
	SubShader
	{
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
		LOD 100

		Pass
		{
		    Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            Cull Off
            
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				float4 vertexColor : COLOR;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float2 uv1: TEXCOORD1;
				float4 vertex : SV_POSITION;
				float4 vertexColor : COLOR;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			sampler2D _MaskTex;
			float4 _MaskTex_ST;
			
			fixed _MaskScale;
			fixed4 _TintColor;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.uv1 = TRANSFORM_TEX(v.uv, _MaskTex);
				o.vertexColor = v.vertexColor;
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 mask = tex2D(_MaskTex, i.uv1);
				clip(_MaskScale * i.vertexColor.a - mask.r * mask.a );
				
				fixed4 col = tex2D(_MainTex, i.uv);
				
				return col * _TintColor * fixed4(i.vertexColor.rgb, 1);
			}
			ENDCG
		}
	}
}
