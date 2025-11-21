// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Toon/BasicWater" {
	Properties {
		_Color ("Main Color", Color) = (.5,.5,.5,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_ToonShade ("ToonShader Cubemap(RGB)", CUBE) = "" { }
		// 新增：水流速度参数（可在Inspector面板调整）
		_FlowSpeed ("Flow Speed (X/Y方向速度)", Vector) = (1, 0.5, 0, 0)
	}


	SubShader {
		Tags { "RenderType"="Opaque" }
		Pass {
			Name "BASE"
			Cull Off
			
			CGPROGRAM

			#pragma multi_compile_instancing
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_fog

			#include "UnityCG.cginc"

			sampler2D _MainTex;
			samplerCUBE _ToonShade;
			float4 _MainTex_ST;
			float4 _Color;
			// 新增：声明水流速度变量
			float4 _FlowSpeed;

			struct appdata {
				float4 vertex : POSITION;
				float2 texcoord : TEXCOORD0;
				float3 normal : NORMAL;
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};
			
			struct v2f {
				float4 pos : SV_POSITION;
				float2 texcoord : TEXCOORD0;
				float3 cubenormal : TEXCOORD1;
				UNITY_FOG_COORDS(2)
				UNITY_VERTEX_INPUT_INSTANCE_ID
			};

			v2f vert (appdata v)
			{
				v2f o;
				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_TRANSFER_INSTANCE_ID(v, o);

				o.pos = UnityObjectToClipPos (v.vertex);
				
				// 核心修改：纹理坐标 += 随时间变化的偏移（用_Time.y表示时间）
				float2 flowOffset = _FlowSpeed.xy * _Time.y;
				o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex) + flowOffset;
				
				o.cubenormal = mul (UNITY_MATRIX_MV, float4(v.normal,0));
				UNITY_TRANSFER_FOG(o,o.pos);
				return o;
			}

			fixed4 frag (v2f i) : SV_Target
			{
				UNITY_SETUP_INSTANCE_ID(i);
				fixed4 col = _Color * tex2D(_MainTex, i.texcoord);
				fixed4 cube = texCUBE(_ToonShade, i.cubenormal);
				fixed4 c = fixed4(2.0f * cube.rgb * col.rgb, col.a);
				UNITY_APPLY_FOG(i.fogCoord, c);
				return c;
			}
			ENDCG			
		}
	} 

	Fallback "VertexLit"
}