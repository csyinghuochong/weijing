

Shader "E3DEffect/C1/Blended" {
Properties {
	_Alpha ("Alpha", Range(0,1.0)) = 1.0
	_TintColor("Tint Color", Color) = (0.5,0.5,0.5,1)
	_MainTex ("Texture(RGBA)", 2D) = "white" {}
}

Category {
	Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" }
	Blend SrcAlpha OneMinusSrcAlpha
	AlphaTest Greater .01
	Cull Off Lighting Off ZWrite Off Fog { Color (0,0,0,0) }

	SubShader {
		Pass {

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// #pragma only_renderers glcore gles gles3 metal d3d9
			#pragma multi_compile_particles

			#include "UnityCG.cginc"

			sampler2D _MainTex;
			fixed4 _TintColor;

			struct appdata_t {
				float4 vertex : POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f {
				float4 vertex : POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			float4 _MainTex_ST;

			v2f vert (appdata_t v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				o.texcoord = TRANSFORM_TEX(v.texcoord,_MainTex);
				return o;
			}

			fixed _Alpha;

			fixed4 frag (v2f i) : COLOR
			{
				fixed4 co = 2.0f * i.color * _TintColor * tex2D(_MainTex, i.texcoord);
				co.a = co.a * _Alpha;
				return co;
			}
			ENDCG
		}
	}
}
}
