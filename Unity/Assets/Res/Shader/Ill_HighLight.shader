Shader "Custom/Ill_HighLight"
{
	Properties
	{
		_Color ("Color",Color) = (1,1,1,1)
		_TargetColor ("目标颜色",Color) = (1,1,1,1)
		_MainTex ("Texture", 2D) = "white" {}
		_BumpMap ("BumpMap",2D) = "bump" {}
		_BumpScale ("BumpScale",float) = 1.0
		_Specular ("SpecularColor",Color) = (1,1,1,1)
		_Gloss ("Gloss",Range(0,1000)) = 20
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }

		Pass
		{
			Tags{"LightMode" = "ForwardBase"}
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "Lighting.cginc"
			#include "UnityCG.cginc"
			#include "AutoLight.cginc"

			struct a2v
			{
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float4 tangent : TANGENT;
				float4 uv : TEXCOORD0;
			};

			struct v2f
			{
				float4 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
				float4 TtoW0 : TEXCOORD1;
				float4 TtoW1 : TEXCOORD2;
				float4 TtoW2 : TEXCOORD3;
			};

			fixed4 _Color;
			fixed4 _TargetColor;
			sampler2D _MainTex;
			float4 _MainTex_ST;
			sampler2D _BumpMap;
			float4 _BumpMap_ST;
			float _BumpScale;
			fixed4 _Specular;
			float _Gloss;
			
			v2f vert (a2v v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.uv.xy = TRANSFORM_TEX(v.uv.xy, _MainTex);
				o.uv.zw = TRANSFORM_TEX(v.uv.zw, _BumpMap);
				float3 worldPos = mul(unity_ObjectToWorld,v.vertex).xyz;
				float3 worldNormal = UnityObjectToWorldNormal(v.normal);
				float3 worldTangent = UnityObjectToWorldDir(v.tangent.xyz);
				float3 worldBiNormal = cross(worldNormal,worldTangent) * v.tangent.w;
				o.TtoW0 = float4(worldTangent.x,worldBiNormal.x,worldNormal.x,worldPos.x);
				o.TtoW1 = float4(worldTangent.y,worldBiNormal.y,worldNormal.y,worldPos.y);
				o.TtoW2 = float4(worldTangent.z,worldBiNormal.z,worldNormal.z,worldPos.z);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				float3 worldPos = float3(i.TtoW0.w,i.TtoW1.w,i.TtoW2.w);
				fixed3 lightDir = normalize(UnityWorldSpaceLightDir(worldPos));
				fixed3 viewDir = normalize(UnityWorldSpaceViewDir(worldPos));
				fixed3 halfDir = normalize(viewDir + lightDir);

				fixed3 bump = UnpackNormal(tex2D(_BumpMap, i.uv.zw));
				bump.xy *= _BumpScale;
				bump.z = sqrt(1.0 - saturate(dot(bump.xy, bump.xy)));
				// 将法线从切线空间转换到世界空间
				bump = normalize(half3(dot(i.TtoW0.xyz, bump), dot(i.TtoW1.xyz, bump), dot(i.TtoW2.xyz, bump)));
				
				UNITY_LIGHT_ATTENUATION(atten,i,worldPos);

				fixed3 texColor = tex2D(_MainTex,i.uv).rgb;
				fixed3 albedo = texColor * _Color.rgb;
				fixed3 highLight = albedo;
				//解决方案：不在漫反射部分处理，而是直接增加一个新的变量加在ambient旁边（相当于一个强环境光）
				//并且，用max（）函数控制颜色分量不要小于0导致显得很蓝色。

				highLight = _TargetColor; //lerp(highLight,_TargetColor,saturate(sin(_Time.w)));
			
				fixed3 ambient = UNITY_LIGHTMODEL_AMBIENT.xyz * albedo;
				fixed3 diffuse = _LightColor0.rgb * albedo * saturate(dot(bump,lightDir));
				fixed3 specular = _LightColor0.rgb * pow(saturate(dot(bump,halfDir)),_Gloss) * _Specular.rgb;
				
				fixed4 color = fixed4(ambient + highLight +(diffuse + specular) * atten,1.0);			
				return color;
			}
			ENDCG
		}
	}
}