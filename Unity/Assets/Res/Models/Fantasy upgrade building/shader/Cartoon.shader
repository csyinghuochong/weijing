Shader "Custom/minitoon" {
	Properties {
		_MainTex ("Albedo (RGB)", 2D) = "white" {}

	}
	SubShader {
		Tags { "RenderType"="Opaque" }

		cull front		
		//1st pass		
		CGPROGRAM
		#pragma surface surf Nolight vertex:vert noambient

		void vert(inout appdata_full v){
		v.vertex.xyz=v.vertex.xyz+v.normal.xyz*0.02;
		}

		struct Input {
		float4 color:COLOR;
		};

		void surf (Input IN, inout SurfaceOutput o) {
		}
		float4 LightingNolight (SurfaceOutput s, float3 lightDir, float atten){
			return float4(0,0,0,1);
		}
				
		ENDCG

		cull back
		//2nd pass
		CGPROGRAM
		#pragma surface surf Toon 

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}

		float4 LightingToon (SurfaceOutput s, float3 lightDir, float atten){

		float ndotl = dot(s.Normal,lightDir)*0.5+0.5;

		ndotl=ndotl*4;
		ndotl=ceil(ndotl)/3;

		float4 final;
		final.rgb=s.Albedo*ndotl*_LightColor0.rgb;
		final.a=s.Alpha;
		return final;
		}
		ENDCG
			
	} 
	FallBack "Diffuse"
}
