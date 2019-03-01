// Unity built-in shader source. Copyright (c) 2016 Unity Technologies. MIT license (see license.txt)

// Simplified Bumped shader. Differences from regular Bumped one:
// - no Main Color
// - Normalmap uses Tiling/Offset of the Base texture
// - fully supports only 1 directional light. Other lights can affect it, but it will be per-vertex/SH.

Shader "GOE/Bumped Spec No Normal" {
Properties {
    _MainTex ("Base (RGB)", 2D) = "white" {}
    //[NoScaleOffset] _BumpMap ("Normalmap", 2D) = "bump" {}
_SpecColor("Specular Color", Color) = (1,1,1,1)
_SpecPower("Specular Power", Range(0,1)) = 0.05
_SpecGloss("Specular Gloss", Range(0,2)) = 1
}

SubShader {
    Tags { "RenderType"="Opaque" }
    LOD 250

CGPROGRAM
#pragma surface surf BlinnPhong 

sampler2D _MainTex;
//sampler2D _BumpMap;
fixed _SpecPower;
fixed _SpecGloss;

struct Input {
    float2 uv_MainTex;
};

void surf (Input IN, inout SurfaceOutput o) {
    fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
    o.Albedo = c.rgb;
    o.Alpha = c.a;
	o.Specular = _SpecPower;
	o.Gloss = _SpecGloss;
    //o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_MainTex));
}
ENDCG
}

FallBack "Mobile/Diffuse"
}
