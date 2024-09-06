Shader "Sprites/Player" {
	Properties {
		_Brightness ("Brightness", Float) = 1
		[MaterialToggle] _BlackWhite ("Black and White", Float) = 0
		[MaterialToggle] _Invert ("Invert Colors", Float) = 0
		[MaterialToggle] _Fullbright ("Fullbright", Float) = 0
		_Pal_Cyan_0 ("Palette - Cyan 0", Vector) = (0,0,0,1)
		_Pal_Cyan_1 ("Palette - Cyan 1", Vector) = (0,0,0,1)
		_Pal_Cyan_2 ("Palette - Cyan 2", Vector) = (0,0,0,1)
		_Pal_Cyan_3 ("Palette - Cyan 3", Vector) = (0,0,0,1)
		_Pal_Cyan_4 ("Palette - Cyan 4", Vector) = (0,0,0,1)
		_Pal_Magenta_0 ("Palette - Magenta 0", Vector) = (0,0,0,1)
		_Pal_Magenta_1 ("Palette - Magenta 1", Vector) = (0,0,0,1)
		_Pal_Magenta_2 ("Palette - Magenta 2", Vector) = (0,0,0,1)
		_Pal_Magenta_3 ("Palette - Magenta 3", Vector) = (0,0,0,1)
		_Pal_Magenta_4 ("Palette - Magenta 4", Vector) = (0,0,0,1)
		_Pal_Yellow_0 ("Palette - Yellow 0", Vector) = (0,0,0,1)
		_Pal_Yellow_1 ("Palette - Yellow 1", Vector) = (0,0,0,1)
		_Pal_Yellow_2 ("Palette - Yellow 2", Vector) = (0,0,0,1)
		_Pal_Yellow_3 ("Palette - Yellow 3", Vector) = (0,0,0,1)
		_Pal_Yellow_4 ("Palette - Yellow 4", Vector) = (0,0,0,1)
		_Pal_Red_0 ("Palette - Red 0", Vector) = (0,0,0,1)
		_Pal_Red_1 ("Palette - Red 1", Vector) = (0,0,0,1)
		_Pal_Red_2 ("Palette - Red 2", Vector) = (0,0,0,1)
		_Pal_Green_0 ("Palette - Green 0", Vector) = (0,0,0,1)
		_Pal_Green_1 ("Palette - Green 1", Vector) = (0,0,0,1)
		_Pal_Green_2 ("Palette - Green 2", Vector) = (0,0,0,1)
		_Pal_Blue_0 ("Palette - Blue 0", Vector) = (0,0,0,1)
		_Pal_Blue_1 ("Palette - Blue 1", Vector) = (0,0,0,1)
		_Pal_Blue_2 ("Palette - Blue 2", Vector) = (0,0,0,1)
		_Pal_Black ("Palette - Black", Vector) = (0,0,0,1)
		_Pal_White ("Palette - White", Vector) = (1,1,1,1)
		_MainTex ("Texture", 2D) = "white" {}
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
}