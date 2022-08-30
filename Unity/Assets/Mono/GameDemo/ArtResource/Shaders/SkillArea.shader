// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "SkillArea" {
	Properties {
	    _Color ("Main Color", Color) = (1,1,1,1)
		//_MainTex ("Base (RGBA)", 2D) = "white" {}
		_AlphaTexLM ("Trans (A)", 2D) = "white" {}
		_Angle("Angle",Range(0,6.29)) = 0
	}
	SubShader 
	{
	   Tags
		{
			"Queue" = "Transparent"
			"IgnoreProjector" = "True"
			"RenderType" = "Transparent"
		}
	    Pass
	    {
		    Cull Off
			Lighting Off
			ZWrite Off

			Fog { Mode Off }
			Blend SrcAlpha OneMinusSrcAlpha

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag			
			#pragma fragmentoption ARB_precision_hint_fastest 
			#include "UnityCG.cginc"
			
			//sampler2D _MainTex;
			sampler2D _AlphaTexLM;
			float _Angle;
			half4 _Color;
			struct appdata
			{
			    float4 vertex:POSITION;
			    float2 uv:TEXCOORD0;
			};
			
			struct v2f
			{
			    float4 pos:SV_POSITION;
			    float2 uv:TEXCOORD0;
			};
			
			v2f vert(appdata i)
			{
			    v2f o;
			    //o.pos = UnityObjectToClipPos(i.vertex);
			    o.pos = UnityObjectToClipPos(i.vertex);
				o.uv = i.uv;
			    return o;
			}
			
			fixed4 frag(v2f i):SV_Target
			{
			   float d1 = dot(float2(0,-1),normalize(i.uv-float2(0.5,0.5)))-_Angle;
			   clip(d1);
			   
			   fixed4 color = _Color;//tex2D(_MainTex,i.uv);
			   color.a = tex2D(_AlphaTexLM, i.uv);
			   
			   return color;
			}
			ENDCG
		}
	} 
	FallBack "Diffuse"
}
