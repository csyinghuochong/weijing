Shader "Custom/Toon_Character_Common"
{

	Properties
	{
		[Enum(UnityEngine.Rendering.CullMode)] _Cull("Cull mode", Float) = 2
		[Header(ToonColor)]
		_Color("Main Color", Color) = (0.5, 0.5, 0.5, 1)
		_HColor("Highlight Color", Color) = (0.785,0.785,0.785,1.0)
		_SColor("Shadow Color", Color) = (0.195,0.195,0.195,1.0)
		_Threshold("Ramp Threshold", Range(0,1)) = 0.5
		_Smooth("Ramp Smoothing", Range(0.01,1)) = 0.1
		[Header(Textures)]
		_MainTex("Base (RGB)", 2D) = "white" {}

		[Header(SetupOption)]
		[Toggle] _DamageOnOff("Damage On/Off", Float) = 0
		_Amount("Height Adjustment", Range(0, 0.5)) = 0
		_DamageColor("DamageColor", Color) = (0, 0, 0, 1)
		_DamagePower("DamagePower", Range(0, 10)) = 10

		[Header(Dissolve)]
		_DissTexture("Dissolve Texture", 2D) = "black" {}
		_DissolveColor("Dissolve Color", Color) = (0,1, 0,1)
		_FXPower("Dissolve Power", Float) = 2.0
		_FXRange("Dissolve Range" ,Range(0, 1)) = 0
		_Dissolve("Dissolve", Range(0, 1)) = 0

		[Header(Mask)]
		_MaskTex("Mask MaskTex (RGBA)", 2D) = "black" {}
		_RColor("Mask R channel", Color) = (0.5,0.5,0.5,1)
		_GColor("Mask G channel", Color) = (0.5,0.5,0.5,1)
		_BColor("Mask B channel", Color) = (0.5,0.5,0.5,1)
	}

		SubShader
		{
			Tags { "RenderType" = "Opaque" }
			Cull[_Cull]
			LOD 200

			CGPROGRAM
			#pragma surface surf ToonRamp addshadow vertex:vert
			#pragma target 3.0
			#pragma shader_feature DISSOVLE_ON DISSOVLE_OFF
			#pragma shader_feature MASK_ON MASK_OFF

			uniform sampler2D _MainTex, _EffectTex;
			uniform sampler2D _DissTexture;
			uniform sampler2D _MaskTex;
			uniform half4 _Color, _HColor, _SColor, _DamageColor, _RColor, _GColor, _BColor, _DissolveColor;
			uniform half  _DamagePower, _DamageOnOff, _FXPower, _FXRange, _Dissolve, _Amount, _Threshold, _Smooth;


			inline half4 LightingToonRamp(SurfaceOutput s, half3 lightDir, half3 viewDir, half atten) {
				#ifndef USING_DIRECTIONAL_LIGHT
				lightDir = normalize(lightDir);
				#endif

				half nld = max(0, dot(s.Normal, lightDir) * 0.5 + 0.5);
				half3 ramp = smoothstep(_Threshold - _Smooth * 0.5, _Threshold + _Smooth * 0.5, nld);

				half4 c;
				_SColor = lerp(_HColor, _SColor, _SColor.a);
				ramp = lerp(_SColor.rgb, _HColor.rgb, ramp);
				c.rgb = s.Albedo * _LightColor0.rgb * ramp;
				c.a = s.Alpha;
				return c;
			}

			struct Input {
				half2 uv_MainTex;
				float2 uv_DissTexture;
				float2 uv_MaskTex;
				float3 viewDir;
				float3 normal;
			};


			void vert(inout appdata_full v) {
				
				v.vertex.xyz += v.normal * _Amount * _DamageOnOff;
			}


			void surf(Input IN, inout SurfaceOutput o) {

				half rim = 1.0 - saturate(dot(normalize(IN.viewDir), o.Normal));
				rim = pow(rim,_DamagePower);
				half4 basecol = tex2D(_MainTex, IN.uv_MainTex) * _Color;

			#ifdef DISSOVLE_ON
				half noise = 1 - tex2D(_DissTexture, IN.uv_DissTexture).r;
				half dissolve = noise - _Dissolve * 1.01;

				clip(dissolve);
				half dissolvedBorder = _FXPower * saturate(_Dissolve * 10) * _FXRange;

				if (dissolve < dissolvedBorder) {
					half cp = saturate(dissolve / dissolvedBorder);
					half bp = 1 - cp;
					basecol = (basecol * cp) + (_DissolveColor * bp);
				}
			#endif
			#ifdef MASK_ON
				half4 maskcol = tex2D(_MaskTex, IN.uv_MaskTex);

				float3 newcol;

				if (maskcol.r > 0)
				{
					float3 graycol = dot(basecol.rgb,float3(0.3,0.59,0.11));
					newcol = graycol * 2 * _RColor.rgb;
					basecol.rgb = lerp(basecol,newcol,maskcol.r);
				}

				if (maskcol.g > 0)
				{
					newcol = basecol * 2 * _GColor.rgb;
					basecol.rgb = lerp(basecol,newcol,maskcol.g);
				}
				if (maskcol.b > 0)
				{
					newcol = basecol * 2 * _BColor.rgb;
					basecol.rgb = lerp(basecol,newcol,maskcol.b);
				}
			#endif
					o.Albedo = basecol;
					o.Emission = rim * _DamageColor * _DamageOnOff;
					o.Alpha = basecol.a;
				}
			ENDCG
			}
			Fallback "Diffuse"
			CustomEditor "TogglesInspector"
}