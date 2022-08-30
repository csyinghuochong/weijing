// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Line" {
	Properties {
		_Factor("_Factor",float) = 100
		_Color("Color",Color) = (0,1,0,1)
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
			
			int _Factor;
			float _Scale;
			float4 _Color;
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
			
			fixed4 frag(v2f i):COLOR
			{
			   int l =_Scale  * i.uv.x*10000;
			   
			   clip(l%(_Factor)-0.5*_Factor);
			   return _Color;
			}
			ENDCG
		}
	} 
	FallBack "Diffuse"
}
