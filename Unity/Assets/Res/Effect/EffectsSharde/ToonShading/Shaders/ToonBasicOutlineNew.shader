Shader "Toon/BasicOutlineNew"
{
    Properties
    {
        _Type("Type",int) = 0 // 0正常 1高亮 2半透明

        _MainTex("main tex",2D) = ""{}
        _Factor("factor",Range(0,0.1)) = 0.01//描边粗细因子
        _OutLineColor("outline color",Color) = (0,0,0,1)//描边颜色
        _Color ("Main Tint", Color) = (1,1,1,0.1)

        _Color1 ("Color1",Color) = (1,1,1,1)
        _TargetColor ("目标颜色",Color) = (1,1,1,1)
        _BumpMap ("BumpMap",2D) = "bump" {}
        _BumpScale ("BumpScale",float) = 1.0
        _Specular ("SpecularColor",Color) = (1,1,1,1)
        _Gloss ("Gloss",Range(0,1000)) = 20

        _Alpha ("Alpha", Range(0, 1)) = 0.1
    }
    SubShader
    {
        Pass
        {
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
                float4 vertex :POSITION;
                float4 uv:TEXCOORD0;
                float4 TtoW0 : TEXCOORD1;
                float4 TtoW1 : TEXCOORD2;
                float4 TtoW2 : TEXCOORD3;
            };

            int _Type;

            sampler2D _MainTex;

            fixed4 _Color1;
            fixed4 _TargetColor;
            float4 _MainTex_ST;
            sampler2D _BumpMap;
            float4 _BumpMap_ST;
            float _BumpScale;
            fixed4 _Specular;
            float _Gloss;

            fixed _Alpha;

            struct Input
            {
                float2 uv_MainTex;
            };

            void surf(Input IN, inout SurfaceOutput o)
            {
                if (_Type == 2)
                {
                    half4 c = tex2D(_MainTex, IN.uv_MainTex);
                    o.Albedo = _Color1.rgb * c.rgb;
                    o.Alpha = _Alpha;
                }
            }

            v2f vert(a2v v)
            {
                v2f o;
                if (_Type == 0) // 网上说最好不要在Shader中加条件语句，影响性能，但是没有找到其他有效的方法了
                {
                    o.vertex = UnityObjectToClipPos(v.vertex);
                    o.uv = v.uv;
                    return o;
                }
                else if (_Type == 1)
                {
                    o.vertex = UnityObjectToClipPos(v.vertex);
                    o.uv.xy = TRANSFORM_TEX(v.uv.xy, _MainTex);
                    o.uv.zw = TRANSFORM_TEX(v.uv.zw, _BumpMap);
                    float3 worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
                    float3 worldNormal = UnityObjectToWorldNormal(v.normal);
                    float3 worldTangent = UnityObjectToWorldDir(v.tangent.xyz);
                    float3 worldBiNormal = cross(worldNormal, worldTangent) * v.tangent.w;
                    o.TtoW0 = float4(worldTangent.x, worldBiNormal.x, worldNormal.x, worldPos.x);
                    o.TtoW1 = float4(worldTangent.y, worldBiNormal.y, worldNormal.y, worldPos.y);
                    o.TtoW2 = float4(worldTangent.z, worldBiNormal.z, worldNormal.z, worldPos.z);
                    return o;
                }
                else
                {
                    o.vertex = UnityObjectToClipPos(v.vertex);
                    o.uv = v.uv;
                    return o;
                }
            }

            half4 frag(v2f i) :COLOR
            {
                half4 c;
                if (_Type == 0)
                {
                    //return half4(1,1,1,1);
                    c = tex2D(_MainTex, i.uv);
                    return c;
                }
                else if (_Type = 1)
                {
                    float3 worldPos = float3(i.TtoW0.w, i.TtoW1.w, i.TtoW2.w);
                    fixed3 lightDir = normalize(UnityWorldSpaceLightDir(worldPos));
                    fixed3 viewDir = normalize(UnityWorldSpaceViewDir(worldPos));
                    fixed3 halfDir = normalize(viewDir + lightDir);

                    fixed3 bump = UnpackNormal(tex2D(_BumpMap, i.uv.zw));
                    bump.xy *= _BumpScale;
                    bump.z = sqrt(1.0 - saturate(dot(bump.xy, bump.xy)));
                    // 将法线从切线空间转换到世界空间
                    bump = normalize(half3(dot(i.TtoW0.xyz, bump), dot(i.TtoW1.xyz, bump), dot(i.TtoW2.xyz, bump)));

                    UNITY_LIGHT_ATTENUATION(atten, i, worldPos);

                    fixed3 texColor = tex2D(_MainTex, i.uv).rgb;
                    fixed3 albedo = texColor * _Color1.rgb;
                    fixed3 highLight = albedo;
                    //解决方案：不在漫反射部分处理，而是直接增加一个新的变量加在ambient旁边（相当于一个强环境光）
                    //并且，用max（）函数控制颜色分量不要小于0导致显得很蓝色。

                    highLight = lerp(highLight, _TargetColor, 0.50);

                    fixed3 ambient = UNITY_LIGHTMODEL_AMBIENT.xyz * albedo;
                    fixed3 diffuse = _LightColor0.rgb * albedo * saturate(dot(bump, lightDir));
                    fixed3 specular = _LightColor0.rgb * pow(saturate(dot(bump, halfDir)), _Gloss) * _Specular.rgb;

                    c = fixed4(ambient + highLight + (diffuse + specular) * atten, 1.0);
                    return c;
                }
                else
                {
                    return c;
                }
            }
            ENDCG
        }
    }
}