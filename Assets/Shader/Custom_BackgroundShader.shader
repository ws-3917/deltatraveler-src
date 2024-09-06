Shader "Custom/BackgroundShader" {
	Properties {
		_MainTex ("Main Texture", 2D) = "white" {}
		_RampTex ("Color Gradient Texture", 2D) = "white" {}
		_ColorShift ("Color Shift", Float) = 1
		_Speed ("Speed", Range(1, 100)) = 1
		_Amplitude ("Amplitude", Float) = 1
		_Frequency ("Frequency", Float) = 1
		_Scale ("Scale", Float) = 1
		_Alpha ("Alpha", Float) = 1
		_LineWidth ("Line Width", Float) = 4
		_DistortionType ("Distortion Type", Float) = 1
		in_PatternRand ("Pattern rand", Float) = 1
		_BlendModeSrc ("Blend Mode Source", Float) = 0
		_BlendModeDst ("Blend Mode Destination", Float) = 0
		[HideInInspector] _Max ("Max color", Float) = 0
		[HideInInspector] _Min ("Min color", Float) = 256
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
}