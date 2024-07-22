#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R>
struct VirtFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};

// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween>
struct TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// UnityEngine.Color[]
struct ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834;
// System.Type[]
struct TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA;
// AllIn1VfxToolkit.All1VfxRandomTimeSeed
struct All1VfxRandomTimeSeed_tBA3108FD5DED576806EB7A92332E0F959A2525F2;
// AllIn1VfxToolkit.Scripts.AllIn1GraphicMaterialDuplicate
struct AllIn1GraphicMaterialDuplicate_t9EE1CA6AB67523669608892E39F054971BC2CB6D;
// AllIn1VfxToolkit.AllIn1LookAt
struct AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F;
// AllIn1VfxToolkit.AllIn1ParticleHelperComponent
struct AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665;
// AllIn1VfxToolkit.AllIn1ParticleHelperSO
struct AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0;
// AllIn1VfxToolkit.AllIn1VfxBounceAnimation
struct AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF;
// AllIn1VfxToolkit.AllIn1VfxComponent
struct AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F;
// AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter
struct AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43;
// AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty
struct AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D;
// AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture
struct AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19;
// System.Reflection.Binder
struct Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30;
// UnityEngine.Camera
struct Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C;
// UnityEngine.Canvas
struct Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA;
// UnityEngine.CanvasRenderer
struct CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E;
// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684;
// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319;
// UnityEngine.Gradient
struct Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2;
// UnityEngine.UI.Graphic
struct Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24;
// UnityEngine.Material
struct Material_t8927C00353A72755313F046D0CE85178AE8218EE;
// UnityEngine.MaterialPropertyBlock
struct MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0;
// System.Reflection.MemberFilter
struct MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81;
// UnityEngine.Mesh
struct Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A;
// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A;
// UnityEngine.RectTransform
struct RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072;
// UnityEngine.Renderer
struct Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C;
// UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A;
// AllIn1VfxToolkit.SetAllIn1VfxCustomGlobalTime
struct SetAllIn1VfxCustomGlobalTime_t88A8D3A9AF3C302E3FCFF781A03834E55ED18E30;
// UnityEngine.Shader
struct Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39;
// System.String
struct String_t;
// UnityEngine.Texture2D
struct Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF;
// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1;
// System.Type
struct Type_t;
// UnityEngine.Events.UnityAction
struct UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099;
// UnityEngine.UI.VertexHelper
struct VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.Camera/CameraCallback
struct CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D;

IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral0023D6A9F7F3B566DFB2EFA5BE5820D9509D681E;
IL2CPP_EXTERN_C String_t* _stringLiteral0299CC5F40C577F300BB29854CBAAD8B68ABF5A0;
IL2CPP_EXTERN_C String_t* _stringLiteral0401A6C1F7012C721901C937730CA854AED44F14;
IL2CPP_EXTERN_C String_t* _stringLiteral040793655BC228982AF83F2DE9C015C189306364;
IL2CPP_EXTERN_C String_t* _stringLiteral1340C6E5B2B210689A25CF2270555B16E1489106;
IL2CPP_EXTERN_C String_t* _stringLiteral14D479CBF77090A6D30F543484D1D50B87795337;
IL2CPP_EXTERN_C String_t* _stringLiteral158697E57921300501C71DFA8626FCAE1F8FD030;
IL2CPP_EXTERN_C String_t* _stringLiteral1647B084BF73860206F4BB01E3237ED88F61B4BA;
IL2CPP_EXTERN_C String_t* _stringLiteral185035D897E40E37CE218ED2FFA2B3FD8F8F8F22;
IL2CPP_EXTERN_C String_t* _stringLiteral1E1912CAB55AF7DEF1C5B72F955FFFBCB9884AB5;
IL2CPP_EXTERN_C String_t* _stringLiteral1E74A2EC3C4B69C55D0D1B56F81D53F03FC58D57;
IL2CPP_EXTERN_C String_t* _stringLiteral2043A81282FBC38D068F48CE6B02508288E7F859;
IL2CPP_EXTERN_C String_t* _stringLiteral2F3FA2011635BA3ADF04F3A6636CEA5D2D14EF88;
IL2CPP_EXTERN_C String_t* _stringLiteral34AD56288A03AA8D7B7BE17E549C5FB602F9E885;
IL2CPP_EXTERN_C String_t* _stringLiteral3C1DB6BCE7F7EC4956D0CD51C602C4B9D94DE193;
IL2CPP_EXTERN_C String_t* _stringLiteral3F868CB06E969FC20ED35E84ACC75C8E94BE5789;
IL2CPP_EXTERN_C String_t* _stringLiteral40728BBCE4EE91640605FACC63DB3CEC63B83B80;
IL2CPP_EXTERN_C String_t* _stringLiteral4696BEB1B4DD525F1293813D16EC3A02B2B12251;
IL2CPP_EXTERN_C String_t* _stringLiteral46AFF93E738AD334DF787721BD7F7D0089E5D7AC;
IL2CPP_EXTERN_C String_t* _stringLiteral4A68E99ECA06FD65FDFD5FCD7FECC5839F4C0DBC;
IL2CPP_EXTERN_C String_t* _stringLiteral4AA79340AA7669BF821B747B748410DB52DA3261;
IL2CPP_EXTERN_C String_t* _stringLiteral4B8146FB95E4F51B29DA41EB5F6D60F8FD0ECF21;
IL2CPP_EXTERN_C String_t* _stringLiteral50639CAD49418C7B223CC529395C0E2A3892501C;
IL2CPP_EXTERN_C String_t* _stringLiteral51C68DEA8F259A907A0498E34875D1BD0A6CED03;
IL2CPP_EXTERN_C String_t* _stringLiteral5398DC3D4FFCD34741F382F596A262B6FA2922AC;
IL2CPP_EXTERN_C String_t* _stringLiteral561612A9F818B42EF04003F9D6952E8EC5D027ED;
IL2CPP_EXTERN_C String_t* _stringLiteral5904389432FCA9BFEA539A8A22DDC0BD69F94F04;
IL2CPP_EXTERN_C String_t* _stringLiteral5A02191D32DC069B431D3E54FF28CEC7767178DB;
IL2CPP_EXTERN_C String_t* _stringLiteral5CE72404582BDAE77C15BF3F30FEFFD1A81D8F8C;
IL2CPP_EXTERN_C String_t* _stringLiteral5D5BF7644F6756216DBAE69270F57FE11BEAE972;
IL2CPP_EXTERN_C String_t* _stringLiteral5F61F506633DBCEB100F2CA993128F6DC6A9C618;
IL2CPP_EXTERN_C String_t* _stringLiteral638A6BF6390D12422CAC4910C95F16CFBCE6D50B;
IL2CPP_EXTERN_C String_t* _stringLiteral6677C73BF64E77B045EA94D2AA385D7540F0A39D;
IL2CPP_EXTERN_C String_t* _stringLiteral6757D44A85F13AA2863BDC7DCEF5E30BC21278BD;
IL2CPP_EXTERN_C String_t* _stringLiteral68CB89848359D7BCEA0995C8FB01DAA1D5DFDE28;
IL2CPP_EXTERN_C String_t* _stringLiteral6B20C68293E633F1FCCB3BBD64B19DD052F5ED87;
IL2CPP_EXTERN_C String_t* _stringLiteral7281FF2F619273B6F998E3D3DCA0CFAF23CCFAD2;
IL2CPP_EXTERN_C String_t* _stringLiteral72A7CAD40240F38905C2C0E1E50F4449AD82AEAB;
IL2CPP_EXTERN_C String_t* _stringLiteral757FDB668BCAADD3B45A3175E6AC8EBACA3EEB65;
IL2CPP_EXTERN_C String_t* _stringLiteral76264918B150B6FD44125E9CE7F711A3689B9700;
IL2CPP_EXTERN_C String_t* _stringLiteral79BCB0C2B8C16448AD04D20C4925CF363A67BAA9;
IL2CPP_EXTERN_C String_t* _stringLiteral7D2ED17259CF0DC4179D682E4471BF85B5574BBA;
IL2CPP_EXTERN_C String_t* _stringLiteral7DDFF290B24173A5DC1BC9BC22C9322BB36CFC10;
IL2CPP_EXTERN_C String_t* _stringLiteral872DCAB5572E264E9E4EA514D7E835229090D6BC;
IL2CPP_EXTERN_C String_t* _stringLiteral89115C0E93F9302CD0B8CD7BB21C410B6162644D;
IL2CPP_EXTERN_C String_t* _stringLiteral8DED3C670AB3C2E5A20C926F89F96926BE24AC79;
IL2CPP_EXTERN_C String_t* _stringLiteral92274FFFE307A7AA40F70ECBD38BB73705AC9E5B;
IL2CPP_EXTERN_C String_t* _stringLiteral94BD673B8551A4C6D6A807ED9D7A6C37D921072F;
IL2CPP_EXTERN_C String_t* _stringLiteral94F92EDABB0744C4E72E030B935FEC2580C8A614;
IL2CPP_EXTERN_C String_t* _stringLiteral954CC189A0FC8B78E623F527148C0981714376AC;
IL2CPP_EXTERN_C String_t* _stringLiteral975A5F46FC6E6D8BC7943A3A38CEA489C122E4F1;
IL2CPP_EXTERN_C String_t* _stringLiteral99117A43311619936587FBCABCC9B16B687AB302;
IL2CPP_EXTERN_C String_t* _stringLiteral9A5093C3D376CC1E1CC7EEF2F6A221406781623A;
IL2CPP_EXTERN_C String_t* _stringLiteral9ABAD8FF849D104EA8DB7481A66BB4B9FD7143A2;
IL2CPP_EXTERN_C String_t* _stringLiteral9CE902BD3933F71AD381D3042D88DF18342E37C4;
IL2CPP_EXTERN_C String_t* _stringLiteralA0F4CF9D3B8B4AD6A49A888401B14AE51DD52E16;
IL2CPP_EXTERN_C String_t* _stringLiteralA27C6266A902DDCC5C73F82BEBBBDF1C87CCFFFA;
IL2CPP_EXTERN_C String_t* _stringLiteralA66067A208E75497516342A152D58B32B1C89075;
IL2CPP_EXTERN_C String_t* _stringLiteralA7A626DEA2521BA48EA03C7C5828601203370D81;
IL2CPP_EXTERN_C String_t* _stringLiteralA87819C2031146742C1F5350BC509988DACBE9F9;
IL2CPP_EXTERN_C String_t* _stringLiteralAAE3A15202D762AC5E5D99D35460A3E2C88307E1;
IL2CPP_EXTERN_C String_t* _stringLiteralB1D928ABA3C2555CCA12F60991D28C7F5A0E200E;
IL2CPP_EXTERN_C String_t* _stringLiteralB8649C06FE9FBAB8E997CBD8796167F6283CAB2C;
IL2CPP_EXTERN_C String_t* _stringLiteralBCBD8C7003675066255066C8241D1DCB43737145;
IL2CPP_EXTERN_C String_t* _stringLiteralC1321093811095513C44D23E1503BACF248356F0;
IL2CPP_EXTERN_C String_t* _stringLiteralC3A9DE289B76C73BE63D02B5A01D7C45B656AD49;
IL2CPP_EXTERN_C String_t* _stringLiteralC76190ED0C48EB995A11E863941095B1AA26B582;
IL2CPP_EXTERN_C String_t* _stringLiteralC827CF6C30E43507B780232E56A8ECC3A42FD702;
IL2CPP_EXTERN_C String_t* _stringLiteralC879E94E49560F1B236BDF1611C5EC619EA5B93F;
IL2CPP_EXTERN_C String_t* _stringLiteralCBE96480BEB47650A1397787D142CB9736546564;
IL2CPP_EXTERN_C String_t* _stringLiteralCEE91F51A391C3F771D9B2463C388312AA8DA8CF;
IL2CPP_EXTERN_C String_t* _stringLiteralCF6B5D4AFB7B21CFD9A2454BF9D1139B1B749D14;
IL2CPP_EXTERN_C String_t* _stringLiteralD01835DFD9412FEB7AA45A9F2E69029F2B71B936;
IL2CPP_EXTERN_C String_t* _stringLiteralD34B357F606D69B3A243155329F7C26E9ED9B03B;
IL2CPP_EXTERN_C String_t* _stringLiteralD53DF615DBAF7AA486744EFFCF7D2AB271BC7058;
IL2CPP_EXTERN_C String_t* _stringLiteralD678A75C242A16DA78744D87F52BD6BA550F95C4;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralDC639E8CFF8B48439F2DC546D026EE8EAB89718B;
IL2CPP_EXTERN_C String_t* _stringLiteralE8B1F4E65A0B35AB6619D979A27DD1766DEB7039;
IL2CPP_EXTERN_C String_t* _stringLiteralEAE96BC7C4AF88268A19A75CCE8F01ABB5A77AB1;
IL2CPP_EXTERN_C String_t* _stringLiteralEFF7EFBB29A0F779F9CF65D30804B3D60468618E;
IL2CPP_EXTERN_C String_t* _stringLiteralF3D5ADFD704DD9FB58F49F6670F4DAA9E634657F;
IL2CPP_EXTERN_C String_t* _stringLiteralF4B62A69FCAFBA03A81C4FD2F7CF77104D7CB48D;
IL2CPP_EXTERN_C String_t* _stringLiteralF5D8EF422ABD0284BA3EEB3BF58FBA9313575F4E;
IL2CPP_EXTERN_C String_t* _stringLiteralFD3081C211F1405167EBF5BDD775516383D38F4F;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39_0_0_0_var;

struct ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t6C3629B5CD5D94ACA66306DB5BD84CCEABBE59A4 
{
public:

public:
};


// System.Object


// AllIn1VfxToolkit.AllIn1VfxNoiseCreator
struct AllIn1VfxNoiseCreator_t2DFADAF9A4F2DE6137727D3E603E2ED3A80C7006  : public RuntimeObject
{
public:

public:
};

struct Il2CppArrayBounds;

// System.Array


// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
public:

public:
};


// System.String
struct String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// System.Boolean
struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// UnityEngine.Color
struct Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 
{
public:
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;

public:
	inline static int32_t get_offset_of_r_0() { return static_cast<int32_t>(offsetof(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659, ___r_0)); }
	inline float get_r_0() const { return ___r_0; }
	inline float* get_address_of_r_0() { return &___r_0; }
	inline void set_r_0(float value)
	{
		___r_0 = value;
	}

	inline static int32_t get_offset_of_g_1() { return static_cast<int32_t>(offsetof(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659, ___g_1)); }
	inline float get_g_1() const { return ___g_1; }
	inline float* get_address_of_g_1() { return &___g_1; }
	inline void set_g_1(float value)
	{
		___g_1 = value;
	}

	inline static int32_t get_offset_of_b_2() { return static_cast<int32_t>(offsetof(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659, ___b_2)); }
	inline float get_b_2() const { return ___b_2; }
	inline float* get_address_of_b_2() { return &___b_2; }
	inline void set_b_2(float value)
	{
		___b_2 = value;
	}

	inline static int32_t get_offset_of_a_3() { return static_cast<int32_t>(offsetof(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659, ___a_3)); }
	inline float get_a_3() const { return ___a_3; }
	inline float* get_address_of_a_3() { return &___a_3; }
	inline void set_a_3(float value)
	{
		___a_3 = value;
	}
};


// System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.Int32
struct Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.IntPtr
struct IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Single
struct Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};


// UnityEngine.Vector2
struct Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 
{
public:
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}
};

struct Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields
{
public:
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___negativeInfinityVector_9;

public:
	inline static int32_t get_offset_of_zeroVector_2() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___zeroVector_2)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_zeroVector_2() const { return ___zeroVector_2; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_zeroVector_2() { return &___zeroVector_2; }
	inline void set_zeroVector_2(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___zeroVector_2 = value;
	}

	inline static int32_t get_offset_of_oneVector_3() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___oneVector_3)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_oneVector_3() const { return ___oneVector_3; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_oneVector_3() { return &___oneVector_3; }
	inline void set_oneVector_3(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___oneVector_3 = value;
	}

	inline static int32_t get_offset_of_upVector_4() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___upVector_4)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_upVector_4() const { return ___upVector_4; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_upVector_4() { return &___upVector_4; }
	inline void set_upVector_4(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___upVector_4 = value;
	}

	inline static int32_t get_offset_of_downVector_5() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___downVector_5)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_downVector_5() const { return ___downVector_5; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_downVector_5() { return &___downVector_5; }
	inline void set_downVector_5(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___downVector_5 = value;
	}

	inline static int32_t get_offset_of_leftVector_6() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___leftVector_6)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_leftVector_6() const { return ___leftVector_6; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_leftVector_6() { return &___leftVector_6; }
	inline void set_leftVector_6(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___leftVector_6 = value;
	}

	inline static int32_t get_offset_of_rightVector_7() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___rightVector_7)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_rightVector_7() const { return ___rightVector_7; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_rightVector_7() { return &___rightVector_7; }
	inline void set_rightVector_7(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___rightVector_7 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___positiveInfinityVector_8)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_positiveInfinityVector_8() const { return ___positiveInfinityVector_8; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_positiveInfinityVector_8() { return &___positiveInfinityVector_8; }
	inline void set_positiveInfinityVector_8(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___positiveInfinityVector_8 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_9() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___negativeInfinityVector_9)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_negativeInfinityVector_9() const { return ___negativeInfinityVector_9; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_negativeInfinityVector_9() { return &___negativeInfinityVector_9; }
	inline void set_negativeInfinityVector_9(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___negativeInfinityVector_9 = value;
	}
};


// UnityEngine.Vector3
struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;

public:
	inline static int32_t get_offset_of_x_2() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___x_2)); }
	inline float get_x_2() const { return ___x_2; }
	inline float* get_address_of_x_2() { return &___x_2; }
	inline void set_x_2(float value)
	{
		___x_2 = value;
	}

	inline static int32_t get_offset_of_y_3() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___y_3)); }
	inline float get_y_3() const { return ___y_3; }
	inline float* get_address_of_y_3() { return &___y_3; }
	inline void set_y_3(float value)
	{
		___y_3 = value;
	}

	inline static int32_t get_offset_of_z_4() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___z_4)); }
	inline float get_z_4() const { return ___z_4; }
	inline float* get_address_of_z_4() { return &___z_4; }
	inline void set_z_4(float value)
	{
		___z_4 = value;
	}
};

struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___negativeInfinityVector_14;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___zeroVector_5)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___oneVector_6)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_upVector_7() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___upVector_7)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_upVector_7() const { return ___upVector_7; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_upVector_7() { return &___upVector_7; }
	inline void set_upVector_7(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___upVector_7 = value;
	}

	inline static int32_t get_offset_of_downVector_8() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___downVector_8)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_downVector_8() const { return ___downVector_8; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_downVector_8() { return &___downVector_8; }
	inline void set_downVector_8(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___downVector_8 = value;
	}

	inline static int32_t get_offset_of_leftVector_9() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___leftVector_9)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_leftVector_9() const { return ___leftVector_9; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_leftVector_9() { return &___leftVector_9; }
	inline void set_leftVector_9(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___leftVector_9 = value;
	}

	inline static int32_t get_offset_of_rightVector_10() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___rightVector_10)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_rightVector_10() const { return ___rightVector_10; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_rightVector_10() { return &___rightVector_10; }
	inline void set_rightVector_10(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___rightVector_10 = value;
	}

	inline static int32_t get_offset_of_forwardVector_11() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___forwardVector_11)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_forwardVector_11() const { return ___forwardVector_11; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_forwardVector_11() { return &___forwardVector_11; }
	inline void set_forwardVector_11(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___forwardVector_11 = value;
	}

	inline static int32_t get_offset_of_backVector_12() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___backVector_12)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_backVector_12() const { return ___backVector_12; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_backVector_12() { return &___backVector_12; }
	inline void set_backVector_12(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___backVector_12 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___positiveInfinityVector_13)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_positiveInfinityVector_13() const { return ___positiveInfinityVector_13; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_positiveInfinityVector_13() { return &___positiveInfinityVector_13; }
	inline void set_positiveInfinityVector_13(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___positiveInfinityVector_13 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_14() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___negativeInfinityVector_14)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_negativeInfinityVector_14() const { return ___negativeInfinityVector_14; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_negativeInfinityVector_14() { return &___negativeInfinityVector_14; }
	inline void set_negativeInfinityVector_14(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___negativeInfinityVector_14 = value;
	}
};


// UnityEngine.Vector4
struct Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 
{
public:
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;

public:
	inline static int32_t get_offset_of_x_1() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___x_1)); }
	inline float get_x_1() const { return ___x_1; }
	inline float* get_address_of_x_1() { return &___x_1; }
	inline void set_x_1(float value)
	{
		___x_1 = value;
	}

	inline static int32_t get_offset_of_y_2() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___y_2)); }
	inline float get_y_2() const { return ___y_2; }
	inline float* get_address_of_y_2() { return &___y_2; }
	inline void set_y_2(float value)
	{
		___y_2 = value;
	}

	inline static int32_t get_offset_of_z_3() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___z_3)); }
	inline float get_z_3() const { return ___z_3; }
	inline float* get_address_of_z_3() { return &___z_3; }
	inline void set_z_3(float value)
	{
		___z_3 = value;
	}

	inline static int32_t get_offset_of_w_4() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___w_4)); }
	inline float get_w_4() const { return ___w_4; }
	inline float* get_address_of_w_4() { return &___w_4; }
	inline void set_w_4(float value)
	{
		___w_4 = value;
	}
};

struct Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields
{
public:
	// UnityEngine.Vector4 UnityEngine.Vector4::zeroVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___zeroVector_5;
	// UnityEngine.Vector4 UnityEngine.Vector4::oneVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___oneVector_6;
	// UnityEngine.Vector4 UnityEngine.Vector4::positiveInfinityVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___positiveInfinityVector_7;
	// UnityEngine.Vector4 UnityEngine.Vector4::negativeInfinityVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___negativeInfinityVector_8;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___zeroVector_5)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___oneVector_6)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_7() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___positiveInfinityVector_7)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_positiveInfinityVector_7() const { return ___positiveInfinityVector_7; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_positiveInfinityVector_7() { return &___positiveInfinityVector_7; }
	inline void set_positiveInfinityVector_7(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___positiveInfinityVector_7 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___negativeInfinityVector_8)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_negativeInfinityVector_8() const { return ___negativeInfinityVector_8; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_negativeInfinityVector_8() { return &___negativeInfinityVector_8; }
	inline void set_negativeInfinityVector_8(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___negativeInfinityVector_8 = value;
	}
};


// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// System.Reflection.BindingFlags
struct BindingFlags_tAAAB07D9AC588F0D55D844E51D7035E96DF94733 
{
public:
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(BindingFlags_tAAAB07D9AC588F0D55D844E51D7035E96DF94733, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.HideFlags
struct HideFlags_tDC64149E37544FF83B2B4222D3E9DC8188766A12 
{
public:
	// System.Int32 UnityEngine.HideFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(HideFlags_tDC64149E37544FF83B2B4222D3E9DC8188766A12, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.MaterialPropertyBlock
struct MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.MaterialPropertyBlock::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};


// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.ParticleSystemGradientMode
struct ParticleSystemGradientMode_tCF15644F35B8D166D1A9C073E758D24794895497 
{
public:
	// System.Int32 UnityEngine.ParticleSystemGradientMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ParticleSystemGradientMode_tCF15644F35B8D166D1A9C073E758D24794895497, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.RuntimeTypeHandle
struct RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 
{
public:
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9, ___value_0)); }
	inline intptr_t get_value_0() const { return ___value_0; }
	inline intptr_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(intptr_t value)
	{
		___value_0 = value;
	}
};


// AllIn1VfxToolkit.AllIn1LookAt/FaceDirection
struct FaceDirection_t27F0DF047693B6DD0D40CBE38FE57E7C24C34953 
{
public:
	// System.Int32 AllIn1VfxToolkit.AllIn1LookAt/FaceDirection::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FaceDirection_t27F0DF047693B6DD0D40CBE38FE57E7C24C34953, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// AllIn1VfxToolkit.AllIn1ParticleHelperComponent/EmissionShapes
struct EmissionShapes_t171312221D8A55AB10341C7D57AE93F4EA540C01 
{
public:
	// System.Int32 AllIn1VfxToolkit.AllIn1ParticleHelperComponent/EmissionShapes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(EmissionShapes_t171312221D8A55AB10341C7D57AE93F4EA540C01, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// AllIn1VfxToolkit.AllIn1ParticleHelperComponent/LifetimeSettings
struct LifetimeSettings_tCF09ED08E4F7B3992F703030BA576C6C5DB993EF 
{
public:
	// System.Int32 AllIn1VfxToolkit.AllIn1ParticleHelperComponent/LifetimeSettings::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LifetimeSettings_tCF09ED08E4F7B3992F703030BA576C6C5DB993EF, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// AllIn1VfxToolkit.AllIn1VfxComponent/AfterSetAction
struct AfterSetAction_tF5DF1A6F5F89875A36148772BFA9F85743F34A4C 
{
public:
	// System.Int32 AllIn1VfxToolkit.AllIn1VfxComponent/AfterSetAction::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AfterSetAction_tF5DF1A6F5F89875A36148772BFA9F85743F34A4C, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.Material
struct Material_t8927C00353A72755313F046D0CE85178AE8218EE  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};

// Native definition for P/Invoke marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A_marshaled_pinvoke : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A_marshaled_com : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com
{
};

// UnityEngine.Shader
struct Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.Texture
struct Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};

struct Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE_StaticFields
{
public:
	// System.Int32 UnityEngine.Texture::GenerateAllMips
	int32_t ___GenerateAllMips_4;

public:
	inline static int32_t get_offset_of_GenerateAllMips_4() { return static_cast<int32_t>(offsetof(Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE_StaticFields, ___GenerateAllMips_4)); }
	inline int32_t get_GenerateAllMips_4() const { return ___GenerateAllMips_4; }
	inline int32_t* get_address_of_GenerateAllMips_4() { return &___GenerateAllMips_4; }
	inline void set_GenerateAllMips_4(int32_t value)
	{
		___GenerateAllMips_4 = value;
	}
};


// System.Type
struct Type_t  : public MemberInfo_t
{
public:
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ____impl_9;

public:
	inline static int32_t get_offset_of__impl_9() { return static_cast<int32_t>(offsetof(Type_t, ____impl_9)); }
	inline RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  get__impl_9() const { return ____impl_9; }
	inline RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 * get_address_of__impl_9() { return &____impl_9; }
	inline void set__impl_9(RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  value)
	{
		____impl_9 = value;
	}
};

struct Type_t_StaticFields
{
public:
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterAttribute_0;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterName_1;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterNameIgnoreCase_2;
	// System.Object System.Type::Missing
	RuntimeObject * ___Missing_3;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_4;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* ___EmptyTypes_5;
	// System.Reflection.Binder System.Type::defaultBinder
	Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * ___defaultBinder_6;

public:
	inline static int32_t get_offset_of_FilterAttribute_0() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterAttribute_0)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterAttribute_0() const { return ___FilterAttribute_0; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterAttribute_0() { return &___FilterAttribute_0; }
	inline void set_FilterAttribute_0(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterAttribute_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterAttribute_0), (void*)value);
	}

	inline static int32_t get_offset_of_FilterName_1() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterName_1)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterName_1() const { return ___FilterName_1; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterName_1() { return &___FilterName_1; }
	inline void set_FilterName_1(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterName_1), (void*)value);
	}

	inline static int32_t get_offset_of_FilterNameIgnoreCase_2() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterNameIgnoreCase_2)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterNameIgnoreCase_2() const { return ___FilterNameIgnoreCase_2; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterNameIgnoreCase_2() { return &___FilterNameIgnoreCase_2; }
	inline void set_FilterNameIgnoreCase_2(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterNameIgnoreCase_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterNameIgnoreCase_2), (void*)value);
	}

	inline static int32_t get_offset_of_Missing_3() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Missing_3)); }
	inline RuntimeObject * get_Missing_3() const { return ___Missing_3; }
	inline RuntimeObject ** get_address_of_Missing_3() { return &___Missing_3; }
	inline void set_Missing_3(RuntimeObject * value)
	{
		___Missing_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Missing_3), (void*)value);
	}

	inline static int32_t get_offset_of_Delimiter_4() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Delimiter_4)); }
	inline Il2CppChar get_Delimiter_4() const { return ___Delimiter_4; }
	inline Il2CppChar* get_address_of_Delimiter_4() { return &___Delimiter_4; }
	inline void set_Delimiter_4(Il2CppChar value)
	{
		___Delimiter_4 = value;
	}

	inline static int32_t get_offset_of_EmptyTypes_5() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___EmptyTypes_5)); }
	inline TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* get_EmptyTypes_5() const { return ___EmptyTypes_5; }
	inline TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755** get_address_of_EmptyTypes_5() { return &___EmptyTypes_5; }
	inline void set_EmptyTypes_5(TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* value)
	{
		___EmptyTypes_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___EmptyTypes_5), (void*)value);
	}

	inline static int32_t get_offset_of_defaultBinder_6() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___defaultBinder_6)); }
	inline Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * get_defaultBinder_6() const { return ___defaultBinder_6; }
	inline Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 ** get_address_of_defaultBinder_6() { return &___defaultBinder_6; }
	inline void set_defaultBinder_6(Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * value)
	{
		___defaultBinder_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___defaultBinder_6), (void*)value);
	}
};


// UnityEngine.ParticleSystem/MinMaxGradient
struct MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7 
{
public:
	// UnityEngine.ParticleSystemGradientMode UnityEngine.ParticleSystem/MinMaxGradient::m_Mode
	int32_t ___m_Mode_0;
	// UnityEngine.Gradient UnityEngine.ParticleSystem/MinMaxGradient::m_GradientMin
	Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * ___m_GradientMin_1;
	// UnityEngine.Gradient UnityEngine.ParticleSystem/MinMaxGradient::m_GradientMax
	Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * ___m_GradientMax_2;
	// UnityEngine.Color UnityEngine.ParticleSystem/MinMaxGradient::m_ColorMin
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_ColorMin_3;
	// UnityEngine.Color UnityEngine.ParticleSystem/MinMaxGradient::m_ColorMax
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_ColorMax_4;

public:
	inline static int32_t get_offset_of_m_Mode_0() { return static_cast<int32_t>(offsetof(MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7, ___m_Mode_0)); }
	inline int32_t get_m_Mode_0() const { return ___m_Mode_0; }
	inline int32_t* get_address_of_m_Mode_0() { return &___m_Mode_0; }
	inline void set_m_Mode_0(int32_t value)
	{
		___m_Mode_0 = value;
	}

	inline static int32_t get_offset_of_m_GradientMin_1() { return static_cast<int32_t>(offsetof(MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7, ___m_GradientMin_1)); }
	inline Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * get_m_GradientMin_1() const { return ___m_GradientMin_1; }
	inline Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 ** get_address_of_m_GradientMin_1() { return &___m_GradientMin_1; }
	inline void set_m_GradientMin_1(Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * value)
	{
		___m_GradientMin_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_GradientMin_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_GradientMax_2() { return static_cast<int32_t>(offsetof(MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7, ___m_GradientMax_2)); }
	inline Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * get_m_GradientMax_2() const { return ___m_GradientMax_2; }
	inline Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 ** get_address_of_m_GradientMax_2() { return &___m_GradientMax_2; }
	inline void set_m_GradientMax_2(Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * value)
	{
		___m_GradientMax_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_GradientMax_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_ColorMin_3() { return static_cast<int32_t>(offsetof(MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7, ___m_ColorMin_3)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_ColorMin_3() const { return ___m_ColorMin_3; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_ColorMin_3() { return &___m_ColorMin_3; }
	inline void set_m_ColorMin_3(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_ColorMin_3 = value;
	}

	inline static int32_t get_offset_of_m_ColorMax_4() { return static_cast<int32_t>(offsetof(MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7, ___m_ColorMax_4)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_ColorMax_4() const { return ___m_ColorMax_4; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_ColorMax_4() { return &___m_ColorMax_4; }
	inline void set_m_ColorMax_4(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_ColorMax_4 = value;
	}
};


// AllIn1VfxToolkit.AllIn1ParticleHelperSO
struct AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0  : public ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A
{
public:
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperSO::matchDurationToLifetime
	bool ___matchDurationToLifetime_4;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperSO::randomRotation
	bool ___randomRotation_5;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperSO::minLifetime
	float ___minLifetime_6;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperSO::maxLifetime
	float ___maxLifetime_7;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperSO::minSpeed
	float ___minSpeed_8;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperSO::maxSpeed
	float ___maxSpeed_9;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperSO::minSize
	float ___minSize_10;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperSO::maxSize
	float ___maxSize_11;
	// UnityEngine.ParticleSystem/MinMaxGradient AllIn1VfxToolkit.AllIn1ParticleHelperSO::startColor
	MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7  ___startColor_12;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperSO::isBurst
	bool ___isBurst_13;
	// System.Int32 AllIn1VfxToolkit.AllIn1ParticleHelperSO::minNumberOfParticles
	int32_t ___minNumberOfParticles_14;
	// System.Int32 AllIn1VfxToolkit.AllIn1ParticleHelperSO::maxNumberOfParticles
	int32_t ___maxNumberOfParticles_15;
	// AllIn1VfxToolkit.AllIn1ParticleHelperComponent/EmissionShapes AllIn1VfxToolkit.AllIn1ParticleHelperSO::currEmissionShape
	int32_t ___currEmissionShape_16;
	// AllIn1VfxToolkit.AllIn1ParticleHelperComponent/LifetimeSettings AllIn1VfxToolkit.AllIn1ParticleHelperSO::colorLifetime
	int32_t ___colorLifetime_17;
	// AllIn1VfxToolkit.AllIn1ParticleHelperComponent/LifetimeSettings AllIn1VfxToolkit.AllIn1ParticleHelperSO::sizeLifetime
	int32_t ___sizeLifetime_18;

public:
	inline static int32_t get_offset_of_matchDurationToLifetime_4() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___matchDurationToLifetime_4)); }
	inline bool get_matchDurationToLifetime_4() const { return ___matchDurationToLifetime_4; }
	inline bool* get_address_of_matchDurationToLifetime_4() { return &___matchDurationToLifetime_4; }
	inline void set_matchDurationToLifetime_4(bool value)
	{
		___matchDurationToLifetime_4 = value;
	}

	inline static int32_t get_offset_of_randomRotation_5() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___randomRotation_5)); }
	inline bool get_randomRotation_5() const { return ___randomRotation_5; }
	inline bool* get_address_of_randomRotation_5() { return &___randomRotation_5; }
	inline void set_randomRotation_5(bool value)
	{
		___randomRotation_5 = value;
	}

	inline static int32_t get_offset_of_minLifetime_6() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___minLifetime_6)); }
	inline float get_minLifetime_6() const { return ___minLifetime_6; }
	inline float* get_address_of_minLifetime_6() { return &___minLifetime_6; }
	inline void set_minLifetime_6(float value)
	{
		___minLifetime_6 = value;
	}

	inline static int32_t get_offset_of_maxLifetime_7() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___maxLifetime_7)); }
	inline float get_maxLifetime_7() const { return ___maxLifetime_7; }
	inline float* get_address_of_maxLifetime_7() { return &___maxLifetime_7; }
	inline void set_maxLifetime_7(float value)
	{
		___maxLifetime_7 = value;
	}

	inline static int32_t get_offset_of_minSpeed_8() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___minSpeed_8)); }
	inline float get_minSpeed_8() const { return ___minSpeed_8; }
	inline float* get_address_of_minSpeed_8() { return &___minSpeed_8; }
	inline void set_minSpeed_8(float value)
	{
		___minSpeed_8 = value;
	}

	inline static int32_t get_offset_of_maxSpeed_9() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___maxSpeed_9)); }
	inline float get_maxSpeed_9() const { return ___maxSpeed_9; }
	inline float* get_address_of_maxSpeed_9() { return &___maxSpeed_9; }
	inline void set_maxSpeed_9(float value)
	{
		___maxSpeed_9 = value;
	}

	inline static int32_t get_offset_of_minSize_10() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___minSize_10)); }
	inline float get_minSize_10() const { return ___minSize_10; }
	inline float* get_address_of_minSize_10() { return &___minSize_10; }
	inline void set_minSize_10(float value)
	{
		___minSize_10 = value;
	}

	inline static int32_t get_offset_of_maxSize_11() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___maxSize_11)); }
	inline float get_maxSize_11() const { return ___maxSize_11; }
	inline float* get_address_of_maxSize_11() { return &___maxSize_11; }
	inline void set_maxSize_11(float value)
	{
		___maxSize_11 = value;
	}

	inline static int32_t get_offset_of_startColor_12() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___startColor_12)); }
	inline MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7  get_startColor_12() const { return ___startColor_12; }
	inline MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7 * get_address_of_startColor_12() { return &___startColor_12; }
	inline void set_startColor_12(MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7  value)
	{
		___startColor_12 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___startColor_12))->___m_GradientMin_1), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___startColor_12))->___m_GradientMax_2), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_isBurst_13() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___isBurst_13)); }
	inline bool get_isBurst_13() const { return ___isBurst_13; }
	inline bool* get_address_of_isBurst_13() { return &___isBurst_13; }
	inline void set_isBurst_13(bool value)
	{
		___isBurst_13 = value;
	}

	inline static int32_t get_offset_of_minNumberOfParticles_14() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___minNumberOfParticles_14)); }
	inline int32_t get_minNumberOfParticles_14() const { return ___minNumberOfParticles_14; }
	inline int32_t* get_address_of_minNumberOfParticles_14() { return &___minNumberOfParticles_14; }
	inline void set_minNumberOfParticles_14(int32_t value)
	{
		___minNumberOfParticles_14 = value;
	}

	inline static int32_t get_offset_of_maxNumberOfParticles_15() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___maxNumberOfParticles_15)); }
	inline int32_t get_maxNumberOfParticles_15() const { return ___maxNumberOfParticles_15; }
	inline int32_t* get_address_of_maxNumberOfParticles_15() { return &___maxNumberOfParticles_15; }
	inline void set_maxNumberOfParticles_15(int32_t value)
	{
		___maxNumberOfParticles_15 = value;
	}

	inline static int32_t get_offset_of_currEmissionShape_16() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___currEmissionShape_16)); }
	inline int32_t get_currEmissionShape_16() const { return ___currEmissionShape_16; }
	inline int32_t* get_address_of_currEmissionShape_16() { return &___currEmissionShape_16; }
	inline void set_currEmissionShape_16(int32_t value)
	{
		___currEmissionShape_16 = value;
	}

	inline static int32_t get_offset_of_colorLifetime_17() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___colorLifetime_17)); }
	inline int32_t get_colorLifetime_17() const { return ___colorLifetime_17; }
	inline int32_t* get_address_of_colorLifetime_17() { return &___colorLifetime_17; }
	inline void set_colorLifetime_17(int32_t value)
	{
		___colorLifetime_17 = value;
	}

	inline static int32_t get_offset_of_sizeLifetime_18() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0, ___sizeLifetime_18)); }
	inline int32_t get_sizeLifetime_18() const { return ___sizeLifetime_18; }
	inline int32_t* get_address_of_sizeLifetime_18() { return &___sizeLifetime_18; }
	inline void set_sizeLifetime_18(int32_t value)
	{
		___sizeLifetime_18 = value;
	}
};


// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// UnityEngine.Renderer
struct Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// UnityEngine.Texture2D
struct Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF  : public Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE
{
public:

public:
};


// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// UnityEngine.Camera
struct Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};

struct Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C_StaticFields
{
public:
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreCull
	CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * ___onPreCull_4;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreRender
	CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * ___onPreRender_5;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPostRender
	CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * ___onPostRender_6;

public:
	inline static int32_t get_offset_of_onPreCull_4() { return static_cast<int32_t>(offsetof(Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C_StaticFields, ___onPreCull_4)); }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * get_onPreCull_4() const { return ___onPreCull_4; }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D ** get_address_of_onPreCull_4() { return &___onPreCull_4; }
	inline void set_onPreCull_4(CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * value)
	{
		___onPreCull_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPreCull_4), (void*)value);
	}

	inline static int32_t get_offset_of_onPreRender_5() { return static_cast<int32_t>(offsetof(Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C_StaticFields, ___onPreRender_5)); }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * get_onPreRender_5() const { return ___onPreRender_5; }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D ** get_address_of_onPreRender_5() { return &___onPreRender_5; }
	inline void set_onPreRender_5(CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * value)
	{
		___onPreRender_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPreRender_5), (void*)value);
	}

	inline static int32_t get_offset_of_onPostRender_6() { return static_cast<int32_t>(offsetof(Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C_StaticFields, ___onPostRender_6)); }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * get_onPostRender_6() const { return ___onPostRender_6; }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D ** get_address_of_onPostRender_6() { return &___onPostRender_6; }
	inline void set_onPostRender_6(CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * value)
	{
		___onPostRender_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPostRender_6), (void*)value);
	}
};


// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};


// AllIn1VfxToolkit.All1VfxRandomTimeSeed
struct All1VfxRandomTimeSeed_tBA3108FD5DED576806EB7A92332E0F959A2525F2  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single AllIn1VfxToolkit.All1VfxRandomTimeSeed::minSeedValue
	float ___minSeedValue_4;
	// System.Single AllIn1VfxToolkit.All1VfxRandomTimeSeed::maxSeedValue
	float ___maxSeedValue_5;

public:
	inline static int32_t get_offset_of_minSeedValue_4() { return static_cast<int32_t>(offsetof(All1VfxRandomTimeSeed_tBA3108FD5DED576806EB7A92332E0F959A2525F2, ___minSeedValue_4)); }
	inline float get_minSeedValue_4() const { return ___minSeedValue_4; }
	inline float* get_address_of_minSeedValue_4() { return &___minSeedValue_4; }
	inline void set_minSeedValue_4(float value)
	{
		___minSeedValue_4 = value;
	}

	inline static int32_t get_offset_of_maxSeedValue_5() { return static_cast<int32_t>(offsetof(All1VfxRandomTimeSeed_tBA3108FD5DED576806EB7A92332E0F959A2525F2, ___maxSeedValue_5)); }
	inline float get_maxSeedValue_5() const { return ___maxSeedValue_5; }
	inline float* get_address_of_maxSeedValue_5() { return &___maxSeedValue_5; }
	inline void set_maxSeedValue_5(float value)
	{
		___maxSeedValue_5 = value;
	}
};


// AllIn1VfxToolkit.Scripts.AllIn1GraphicMaterialDuplicate
struct AllIn1GraphicMaterialDuplicate_t9EE1CA6AB67523669608892E39F054971BC2CB6D  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:

public:
};


// AllIn1VfxToolkit.AllIn1LookAt
struct AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Boolean AllIn1VfxToolkit.AllIn1LookAt::updateEveryFrame
	bool ___updateEveryFrame_4;
	// System.Boolean AllIn1VfxToolkit.AllIn1LookAt::targetIsMainCamera
	bool ___targetIsMainCamera_5;
	// UnityEngine.Transform AllIn1VfxToolkit.AllIn1LookAt::target
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___target_6;
	// AllIn1VfxToolkit.AllIn1LookAt/FaceDirection AllIn1VfxToolkit.AllIn1LookAt::faceDirection
	int32_t ___faceDirection_7;
	// System.Boolean AllIn1VfxToolkit.AllIn1LookAt::negateDirection
	bool ___negateDirection_8;

public:
	inline static int32_t get_offset_of_updateEveryFrame_4() { return static_cast<int32_t>(offsetof(AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F, ___updateEveryFrame_4)); }
	inline bool get_updateEveryFrame_4() const { return ___updateEveryFrame_4; }
	inline bool* get_address_of_updateEveryFrame_4() { return &___updateEveryFrame_4; }
	inline void set_updateEveryFrame_4(bool value)
	{
		___updateEveryFrame_4 = value;
	}

	inline static int32_t get_offset_of_targetIsMainCamera_5() { return static_cast<int32_t>(offsetof(AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F, ___targetIsMainCamera_5)); }
	inline bool get_targetIsMainCamera_5() const { return ___targetIsMainCamera_5; }
	inline bool* get_address_of_targetIsMainCamera_5() { return &___targetIsMainCamera_5; }
	inline void set_targetIsMainCamera_5(bool value)
	{
		___targetIsMainCamera_5 = value;
	}

	inline static int32_t get_offset_of_target_6() { return static_cast<int32_t>(offsetof(AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F, ___target_6)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_target_6() const { return ___target_6; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_target_6() { return &___target_6; }
	inline void set_target_6(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___target_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_6), (void*)value);
	}

	inline static int32_t get_offset_of_faceDirection_7() { return static_cast<int32_t>(offsetof(AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F, ___faceDirection_7)); }
	inline int32_t get_faceDirection_7() const { return ___faceDirection_7; }
	inline int32_t* get_address_of_faceDirection_7() { return &___faceDirection_7; }
	inline void set_faceDirection_7(int32_t value)
	{
		___faceDirection_7 = value;
	}

	inline static int32_t get_offset_of_negateDirection_8() { return static_cast<int32_t>(offsetof(AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F, ___negateDirection_8)); }
	inline bool get_negateDirection_8() const { return ___negateDirection_8; }
	inline bool* get_address_of_negateDirection_8() { return &___negateDirection_8; }
	inline void set_negateDirection_8(bool value)
	{
		___negateDirection_8 = value;
	}
};


// AllIn1VfxToolkit.AllIn1ParticleHelperComponent
struct AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::hierarchyHelpers
	bool ___hierarchyHelpers_4;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::generalOptions
	bool ___generalOptions_5;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::shapeOptions
	bool ___shapeOptions_6;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::emissionOptions
	bool ___emissionOptions_7;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::overLifetimeOptions
	bool ___overLifetimeOptions_8;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::colorChangeOption
	bool ___colorChangeOption_9;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::particleHelperPresets
	bool ___particleHelperPresets_10;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::particleSystemPresets
	bool ___particleSystemPresets_11;
	// System.Int32 AllIn1VfxToolkit.AllIn1ParticleHelperComponent::numberOfCopies
	int32_t ___numberOfCopies_12;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::applyEverythingOnChange
	bool ___applyEverythingOnChange_13;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::matchDurationToLifetime
	bool ___matchDurationToLifetime_14;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::randomRotation
	bool ___randomRotation_15;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperComponent::minLifetime
	float ___minLifetime_16;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperComponent::maxLifetime
	float ___maxLifetime_17;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperComponent::minSpeed
	float ___minSpeed_18;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperComponent::maxSpeed
	float ___maxSpeed_19;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperComponent::minSize
	float ___minSize_20;
	// System.Single AllIn1VfxToolkit.AllIn1ParticleHelperComponent::maxSize
	float ___maxSize_21;
	// UnityEngine.ParticleSystem/MinMaxGradient AllIn1VfxToolkit.AllIn1ParticleHelperComponent::startColor
	MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7  ___startColor_22;
	// System.Boolean AllIn1VfxToolkit.AllIn1ParticleHelperComponent::isBurst
	bool ___isBurst_23;
	// System.Int32 AllIn1VfxToolkit.AllIn1ParticleHelperComponent::minNumberOfParticles
	int32_t ___minNumberOfParticles_24;
	// System.Int32 AllIn1VfxToolkit.AllIn1ParticleHelperComponent::maxNumberOfParticles
	int32_t ___maxNumberOfParticles_25;
	// AllIn1VfxToolkit.AllIn1ParticleHelperComponent/EmissionShapes AllIn1VfxToolkit.AllIn1ParticleHelperComponent::currEmissionShape
	int32_t ___currEmissionShape_26;
	// AllIn1VfxToolkit.AllIn1ParticleHelperComponent/LifetimeSettings AllIn1VfxToolkit.AllIn1ParticleHelperComponent::colorLifetime
	int32_t ___colorLifetime_27;
	// AllIn1VfxToolkit.AllIn1ParticleHelperComponent/LifetimeSettings AllIn1VfxToolkit.AllIn1ParticleHelperComponent::sizeLifetime
	int32_t ___sizeLifetime_28;

public:
	inline static int32_t get_offset_of_hierarchyHelpers_4() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___hierarchyHelpers_4)); }
	inline bool get_hierarchyHelpers_4() const { return ___hierarchyHelpers_4; }
	inline bool* get_address_of_hierarchyHelpers_4() { return &___hierarchyHelpers_4; }
	inline void set_hierarchyHelpers_4(bool value)
	{
		___hierarchyHelpers_4 = value;
	}

	inline static int32_t get_offset_of_generalOptions_5() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___generalOptions_5)); }
	inline bool get_generalOptions_5() const { return ___generalOptions_5; }
	inline bool* get_address_of_generalOptions_5() { return &___generalOptions_5; }
	inline void set_generalOptions_5(bool value)
	{
		___generalOptions_5 = value;
	}

	inline static int32_t get_offset_of_shapeOptions_6() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___shapeOptions_6)); }
	inline bool get_shapeOptions_6() const { return ___shapeOptions_6; }
	inline bool* get_address_of_shapeOptions_6() { return &___shapeOptions_6; }
	inline void set_shapeOptions_6(bool value)
	{
		___shapeOptions_6 = value;
	}

	inline static int32_t get_offset_of_emissionOptions_7() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___emissionOptions_7)); }
	inline bool get_emissionOptions_7() const { return ___emissionOptions_7; }
	inline bool* get_address_of_emissionOptions_7() { return &___emissionOptions_7; }
	inline void set_emissionOptions_7(bool value)
	{
		___emissionOptions_7 = value;
	}

	inline static int32_t get_offset_of_overLifetimeOptions_8() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___overLifetimeOptions_8)); }
	inline bool get_overLifetimeOptions_8() const { return ___overLifetimeOptions_8; }
	inline bool* get_address_of_overLifetimeOptions_8() { return &___overLifetimeOptions_8; }
	inline void set_overLifetimeOptions_8(bool value)
	{
		___overLifetimeOptions_8 = value;
	}

	inline static int32_t get_offset_of_colorChangeOption_9() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___colorChangeOption_9)); }
	inline bool get_colorChangeOption_9() const { return ___colorChangeOption_9; }
	inline bool* get_address_of_colorChangeOption_9() { return &___colorChangeOption_9; }
	inline void set_colorChangeOption_9(bool value)
	{
		___colorChangeOption_9 = value;
	}

	inline static int32_t get_offset_of_particleHelperPresets_10() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___particleHelperPresets_10)); }
	inline bool get_particleHelperPresets_10() const { return ___particleHelperPresets_10; }
	inline bool* get_address_of_particleHelperPresets_10() { return &___particleHelperPresets_10; }
	inline void set_particleHelperPresets_10(bool value)
	{
		___particleHelperPresets_10 = value;
	}

	inline static int32_t get_offset_of_particleSystemPresets_11() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___particleSystemPresets_11)); }
	inline bool get_particleSystemPresets_11() const { return ___particleSystemPresets_11; }
	inline bool* get_address_of_particleSystemPresets_11() { return &___particleSystemPresets_11; }
	inline void set_particleSystemPresets_11(bool value)
	{
		___particleSystemPresets_11 = value;
	}

	inline static int32_t get_offset_of_numberOfCopies_12() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___numberOfCopies_12)); }
	inline int32_t get_numberOfCopies_12() const { return ___numberOfCopies_12; }
	inline int32_t* get_address_of_numberOfCopies_12() { return &___numberOfCopies_12; }
	inline void set_numberOfCopies_12(int32_t value)
	{
		___numberOfCopies_12 = value;
	}

	inline static int32_t get_offset_of_applyEverythingOnChange_13() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___applyEverythingOnChange_13)); }
	inline bool get_applyEverythingOnChange_13() const { return ___applyEverythingOnChange_13; }
	inline bool* get_address_of_applyEverythingOnChange_13() { return &___applyEverythingOnChange_13; }
	inline void set_applyEverythingOnChange_13(bool value)
	{
		___applyEverythingOnChange_13 = value;
	}

	inline static int32_t get_offset_of_matchDurationToLifetime_14() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___matchDurationToLifetime_14)); }
	inline bool get_matchDurationToLifetime_14() const { return ___matchDurationToLifetime_14; }
	inline bool* get_address_of_matchDurationToLifetime_14() { return &___matchDurationToLifetime_14; }
	inline void set_matchDurationToLifetime_14(bool value)
	{
		___matchDurationToLifetime_14 = value;
	}

	inline static int32_t get_offset_of_randomRotation_15() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___randomRotation_15)); }
	inline bool get_randomRotation_15() const { return ___randomRotation_15; }
	inline bool* get_address_of_randomRotation_15() { return &___randomRotation_15; }
	inline void set_randomRotation_15(bool value)
	{
		___randomRotation_15 = value;
	}

	inline static int32_t get_offset_of_minLifetime_16() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___minLifetime_16)); }
	inline float get_minLifetime_16() const { return ___minLifetime_16; }
	inline float* get_address_of_minLifetime_16() { return &___minLifetime_16; }
	inline void set_minLifetime_16(float value)
	{
		___minLifetime_16 = value;
	}

	inline static int32_t get_offset_of_maxLifetime_17() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___maxLifetime_17)); }
	inline float get_maxLifetime_17() const { return ___maxLifetime_17; }
	inline float* get_address_of_maxLifetime_17() { return &___maxLifetime_17; }
	inline void set_maxLifetime_17(float value)
	{
		___maxLifetime_17 = value;
	}

	inline static int32_t get_offset_of_minSpeed_18() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___minSpeed_18)); }
	inline float get_minSpeed_18() const { return ___minSpeed_18; }
	inline float* get_address_of_minSpeed_18() { return &___minSpeed_18; }
	inline void set_minSpeed_18(float value)
	{
		___minSpeed_18 = value;
	}

	inline static int32_t get_offset_of_maxSpeed_19() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___maxSpeed_19)); }
	inline float get_maxSpeed_19() const { return ___maxSpeed_19; }
	inline float* get_address_of_maxSpeed_19() { return &___maxSpeed_19; }
	inline void set_maxSpeed_19(float value)
	{
		___maxSpeed_19 = value;
	}

	inline static int32_t get_offset_of_minSize_20() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___minSize_20)); }
	inline float get_minSize_20() const { return ___minSize_20; }
	inline float* get_address_of_minSize_20() { return &___minSize_20; }
	inline void set_minSize_20(float value)
	{
		___minSize_20 = value;
	}

	inline static int32_t get_offset_of_maxSize_21() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___maxSize_21)); }
	inline float get_maxSize_21() const { return ___maxSize_21; }
	inline float* get_address_of_maxSize_21() { return &___maxSize_21; }
	inline void set_maxSize_21(float value)
	{
		___maxSize_21 = value;
	}

	inline static int32_t get_offset_of_startColor_22() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___startColor_22)); }
	inline MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7  get_startColor_22() const { return ___startColor_22; }
	inline MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7 * get_address_of_startColor_22() { return &___startColor_22; }
	inline void set_startColor_22(MinMaxGradient_tF4530B26F29D9635D670A33B9EE581EAC48C12B7  value)
	{
		___startColor_22 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___startColor_22))->___m_GradientMin_1), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___startColor_22))->___m_GradientMax_2), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_isBurst_23() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___isBurst_23)); }
	inline bool get_isBurst_23() const { return ___isBurst_23; }
	inline bool* get_address_of_isBurst_23() { return &___isBurst_23; }
	inline void set_isBurst_23(bool value)
	{
		___isBurst_23 = value;
	}

	inline static int32_t get_offset_of_minNumberOfParticles_24() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___minNumberOfParticles_24)); }
	inline int32_t get_minNumberOfParticles_24() const { return ___minNumberOfParticles_24; }
	inline int32_t* get_address_of_minNumberOfParticles_24() { return &___minNumberOfParticles_24; }
	inline void set_minNumberOfParticles_24(int32_t value)
	{
		___minNumberOfParticles_24 = value;
	}

	inline static int32_t get_offset_of_maxNumberOfParticles_25() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___maxNumberOfParticles_25)); }
	inline int32_t get_maxNumberOfParticles_25() const { return ___maxNumberOfParticles_25; }
	inline int32_t* get_address_of_maxNumberOfParticles_25() { return &___maxNumberOfParticles_25; }
	inline void set_maxNumberOfParticles_25(int32_t value)
	{
		___maxNumberOfParticles_25 = value;
	}

	inline static int32_t get_offset_of_currEmissionShape_26() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___currEmissionShape_26)); }
	inline int32_t get_currEmissionShape_26() const { return ___currEmissionShape_26; }
	inline int32_t* get_address_of_currEmissionShape_26() { return &___currEmissionShape_26; }
	inline void set_currEmissionShape_26(int32_t value)
	{
		___currEmissionShape_26 = value;
	}

	inline static int32_t get_offset_of_colorLifetime_27() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___colorLifetime_27)); }
	inline int32_t get_colorLifetime_27() const { return ___colorLifetime_27; }
	inline int32_t* get_address_of_colorLifetime_27() { return &___colorLifetime_27; }
	inline void set_colorLifetime_27(int32_t value)
	{
		___colorLifetime_27 = value;
	}

	inline static int32_t get_offset_of_sizeLifetime_28() { return static_cast<int32_t>(offsetof(AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665, ___sizeLifetime_28)); }
	inline int32_t get_sizeLifetime_28() const { return ___sizeLifetime_28; }
	inline int32_t* get_address_of_sizeLifetime_28() { return &___sizeLifetime_28; }
	inline void set_sizeLifetime_28(int32_t value)
	{
		___sizeLifetime_28 = value;
	}
};


// AllIn1VfxToolkit.AllIn1VfxBounceAnimation
struct AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.Vector3 AllIn1VfxToolkit.AllIn1VfxBounceAnimation::targetOffset
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___targetOffset_4;
	// System.Single AllIn1VfxToolkit.AllIn1VfxBounceAnimation::speed
	float ___speed_5;
	// UnityEngine.Vector3 AllIn1VfxToolkit.AllIn1VfxBounceAnimation::startPosition
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___startPosition_6;
	// UnityEngine.Vector3 AllIn1VfxToolkit.AllIn1VfxBounceAnimation::animationMovementVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___animationMovementVector_7;

public:
	inline static int32_t get_offset_of_targetOffset_4() { return static_cast<int32_t>(offsetof(AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF, ___targetOffset_4)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_targetOffset_4() const { return ___targetOffset_4; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_targetOffset_4() { return &___targetOffset_4; }
	inline void set_targetOffset_4(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___targetOffset_4 = value;
	}

	inline static int32_t get_offset_of_speed_5() { return static_cast<int32_t>(offsetof(AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF, ___speed_5)); }
	inline float get_speed_5() const { return ___speed_5; }
	inline float* get_address_of_speed_5() { return &___speed_5; }
	inline void set_speed_5(float value)
	{
		___speed_5 = value;
	}

	inline static int32_t get_offset_of_startPosition_6() { return static_cast<int32_t>(offsetof(AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF, ___startPosition_6)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_startPosition_6() const { return ___startPosition_6; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_startPosition_6() { return &___startPosition_6; }
	inline void set_startPosition_6(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___startPosition_6 = value;
	}

	inline static int32_t get_offset_of_animationMovementVector_7() { return static_cast<int32_t>(offsetof(AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF, ___animationMovementVector_7)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_animationMovementVector_7() const { return ___animationMovementVector_7; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_animationMovementVector_7() { return &___animationMovementVector_7; }
	inline void set_animationMovementVector_7(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___animationMovementVector_7 = value;
	}
};


// AllIn1VfxToolkit.AllIn1VfxComponent
struct AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.Material AllIn1VfxToolkit.AllIn1VfxComponent::currMaterial
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___currMaterial_4;
	// UnityEngine.Material AllIn1VfxToolkit.AllIn1VfxComponent::prevMaterial
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___prevMaterial_5;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::matAssigned
	bool ___matAssigned_6;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::destroyed
	bool ___destroyed_7;

public:
	inline static int32_t get_offset_of_currMaterial_4() { return static_cast<int32_t>(offsetof(AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F, ___currMaterial_4)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_currMaterial_4() const { return ___currMaterial_4; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_currMaterial_4() { return &___currMaterial_4; }
	inline void set_currMaterial_4(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___currMaterial_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currMaterial_4), (void*)value);
	}

	inline static int32_t get_offset_of_prevMaterial_5() { return static_cast<int32_t>(offsetof(AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F, ___prevMaterial_5)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_prevMaterial_5() const { return ___prevMaterial_5; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_prevMaterial_5() { return &___prevMaterial_5; }
	inline void set_prevMaterial_5(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___prevMaterial_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___prevMaterial_5), (void*)value);
	}

	inline static int32_t get_offset_of_matAssigned_6() { return static_cast<int32_t>(offsetof(AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F, ___matAssigned_6)); }
	inline bool get_matAssigned_6() const { return ___matAssigned_6; }
	inline bool* get_address_of_matAssigned_6() { return &___matAssigned_6; }
	inline void set_matAssigned_6(bool value)
	{
		___matAssigned_6 = value;
	}

	inline static int32_t get_offset_of_destroyed_7() { return static_cast<int32_t>(offsetof(AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F, ___destroyed_7)); }
	inline bool get_destroyed_7() const { return ___destroyed_7; }
	inline bool* get_address_of_destroyed_7() { return &___destroyed_7; }
	inline void set_destroyed_7(bool value)
	{
		___destroyed_7 = value;
	}
};


// AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter
struct AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::setOnAwake
	bool ___setOnAwake_4;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::setOnUpdate
	bool ___setOnUpdate_5;
	// UnityEngine.Transform AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::target
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___target_6;
	// System.Int32 AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::lightDirId
	int32_t ___lightDirId_7;

public:
	inline static int32_t get_offset_of_setOnAwake_4() { return static_cast<int32_t>(offsetof(AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43, ___setOnAwake_4)); }
	inline bool get_setOnAwake_4() const { return ___setOnAwake_4; }
	inline bool* get_address_of_setOnAwake_4() { return &___setOnAwake_4; }
	inline void set_setOnAwake_4(bool value)
	{
		___setOnAwake_4 = value;
	}

	inline static int32_t get_offset_of_setOnUpdate_5() { return static_cast<int32_t>(offsetof(AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43, ___setOnUpdate_5)); }
	inline bool get_setOnUpdate_5() const { return ___setOnUpdate_5; }
	inline bool* get_address_of_setOnUpdate_5() { return &___setOnUpdate_5; }
	inline void set_setOnUpdate_5(bool value)
	{
		___setOnUpdate_5 = value;
	}

	inline static int32_t get_offset_of_target_6() { return static_cast<int32_t>(offsetof(AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43, ___target_6)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_target_6() const { return ___target_6; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_target_6() { return &___target_6; }
	inline void set_target_6(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___target_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_6), (void*)value);
	}

	inline static int32_t get_offset_of_lightDirId_7() { return static_cast<int32_t>(offsetof(AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43, ___lightDirId_7)); }
	inline int32_t get_lightDirId_7() const { return ___lightDirId_7; }
	inline int32_t* get_address_of_lightDirId_7() { return &___lightDirId_7; }
	inline void set_lightDirId_7(int32_t value)
	{
		___lightDirId_7 = value;
	}
};


// AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty
struct AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.String AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::numericPropertyName
	String_t* ___numericPropertyName_4;
	// System.Single AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::scrollSpeed
	float ___scrollSpeed_5;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::backAndForth
	bool ___backAndForth_6;
	// System.Single AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::maxValue
	float ___maxValue_7;
	// System.Single AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::iniValue
	float ___iniValue_8;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::goingUp
	bool ___goingUp_9;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::applyModulo
	bool ___applyModulo_10;
	// System.Single AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::modulo
	float ___modulo_11;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::stopAtValue
	bool ___stopAtValue_12;
	// System.Single AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::stopValue
	float ___stopValue_13;
	// UnityEngine.Material AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::mat
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___mat_14;
	// UnityEngine.Material AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::originalMat
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___originalMat_15;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::restoreMaterialOnDisable
	bool ___restoreMaterialOnDisable_16;
	// System.Int32 AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::propertyShaderID
	int32_t ___propertyShaderID_17;
	// System.Single AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::currValue
	float ___currValue_18;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::isValid
	bool ___isValid_19;

public:
	inline static int32_t get_offset_of_numericPropertyName_4() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___numericPropertyName_4)); }
	inline String_t* get_numericPropertyName_4() const { return ___numericPropertyName_4; }
	inline String_t** get_address_of_numericPropertyName_4() { return &___numericPropertyName_4; }
	inline void set_numericPropertyName_4(String_t* value)
	{
		___numericPropertyName_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___numericPropertyName_4), (void*)value);
	}

	inline static int32_t get_offset_of_scrollSpeed_5() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___scrollSpeed_5)); }
	inline float get_scrollSpeed_5() const { return ___scrollSpeed_5; }
	inline float* get_address_of_scrollSpeed_5() { return &___scrollSpeed_5; }
	inline void set_scrollSpeed_5(float value)
	{
		___scrollSpeed_5 = value;
	}

	inline static int32_t get_offset_of_backAndForth_6() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___backAndForth_6)); }
	inline bool get_backAndForth_6() const { return ___backAndForth_6; }
	inline bool* get_address_of_backAndForth_6() { return &___backAndForth_6; }
	inline void set_backAndForth_6(bool value)
	{
		___backAndForth_6 = value;
	}

	inline static int32_t get_offset_of_maxValue_7() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___maxValue_7)); }
	inline float get_maxValue_7() const { return ___maxValue_7; }
	inline float* get_address_of_maxValue_7() { return &___maxValue_7; }
	inline void set_maxValue_7(float value)
	{
		___maxValue_7 = value;
	}

	inline static int32_t get_offset_of_iniValue_8() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___iniValue_8)); }
	inline float get_iniValue_8() const { return ___iniValue_8; }
	inline float* get_address_of_iniValue_8() { return &___iniValue_8; }
	inline void set_iniValue_8(float value)
	{
		___iniValue_8 = value;
	}

	inline static int32_t get_offset_of_goingUp_9() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___goingUp_9)); }
	inline bool get_goingUp_9() const { return ___goingUp_9; }
	inline bool* get_address_of_goingUp_9() { return &___goingUp_9; }
	inline void set_goingUp_9(bool value)
	{
		___goingUp_9 = value;
	}

	inline static int32_t get_offset_of_applyModulo_10() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___applyModulo_10)); }
	inline bool get_applyModulo_10() const { return ___applyModulo_10; }
	inline bool* get_address_of_applyModulo_10() { return &___applyModulo_10; }
	inline void set_applyModulo_10(bool value)
	{
		___applyModulo_10 = value;
	}

	inline static int32_t get_offset_of_modulo_11() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___modulo_11)); }
	inline float get_modulo_11() const { return ___modulo_11; }
	inline float* get_address_of_modulo_11() { return &___modulo_11; }
	inline void set_modulo_11(float value)
	{
		___modulo_11 = value;
	}

	inline static int32_t get_offset_of_stopAtValue_12() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___stopAtValue_12)); }
	inline bool get_stopAtValue_12() const { return ___stopAtValue_12; }
	inline bool* get_address_of_stopAtValue_12() { return &___stopAtValue_12; }
	inline void set_stopAtValue_12(bool value)
	{
		___stopAtValue_12 = value;
	}

	inline static int32_t get_offset_of_stopValue_13() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___stopValue_13)); }
	inline float get_stopValue_13() const { return ___stopValue_13; }
	inline float* get_address_of_stopValue_13() { return &___stopValue_13; }
	inline void set_stopValue_13(float value)
	{
		___stopValue_13 = value;
	}

	inline static int32_t get_offset_of_mat_14() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___mat_14)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_mat_14() const { return ___mat_14; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_mat_14() { return &___mat_14; }
	inline void set_mat_14(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___mat_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mat_14), (void*)value);
	}

	inline static int32_t get_offset_of_originalMat_15() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___originalMat_15)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_originalMat_15() const { return ___originalMat_15; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_originalMat_15() { return &___originalMat_15; }
	inline void set_originalMat_15(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___originalMat_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___originalMat_15), (void*)value);
	}

	inline static int32_t get_offset_of_restoreMaterialOnDisable_16() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___restoreMaterialOnDisable_16)); }
	inline bool get_restoreMaterialOnDisable_16() const { return ___restoreMaterialOnDisable_16; }
	inline bool* get_address_of_restoreMaterialOnDisable_16() { return &___restoreMaterialOnDisable_16; }
	inline void set_restoreMaterialOnDisable_16(bool value)
	{
		___restoreMaterialOnDisable_16 = value;
	}

	inline static int32_t get_offset_of_propertyShaderID_17() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___propertyShaderID_17)); }
	inline int32_t get_propertyShaderID_17() const { return ___propertyShaderID_17; }
	inline int32_t* get_address_of_propertyShaderID_17() { return &___propertyShaderID_17; }
	inline void set_propertyShaderID_17(int32_t value)
	{
		___propertyShaderID_17 = value;
	}

	inline static int32_t get_offset_of_currValue_18() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___currValue_18)); }
	inline float get_currValue_18() const { return ___currValue_18; }
	inline float* get_address_of_currValue_18() { return &___currValue_18; }
	inline void set_currValue_18(float value)
	{
		___currValue_18 = value;
	}

	inline static int32_t get_offset_of_isValid_19() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D, ___isValid_19)); }
	inline bool get_isValid_19() const { return ___isValid_19; }
	inline bool* get_address_of_isValid_19() { return &___isValid_19; }
	inline void set_isValid_19(bool value)
	{
		___isValid_19 = value;
	}
};


// AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture
struct AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.String AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::texturePropertyName
	String_t* ___texturePropertyName_4;
	// UnityEngine.Vector2 AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::scrollSpeed
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___scrollSpeed_5;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::textureOffset
	bool ___textureOffset_6;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::backAndForth
	bool ___backAndForth_7;
	// UnityEngine.Vector2 AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::maxValue
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___maxValue_8;
	// UnityEngine.Vector2 AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::iniValue
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___iniValue_9;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::goingUpX
	bool ___goingUpX_10;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::goingUpY
	bool ___goingUpY_11;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::applyModulo
	bool ___applyModulo_12;
	// UnityEngine.Vector2 AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::modulo
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___modulo_13;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::stopAtValue
	bool ___stopAtValue_14;
	// UnityEngine.Vector2 AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::stopValue
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___stopValue_15;
	// UnityEngine.Material AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::mat
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___mat_16;
	// UnityEngine.Material AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::originalMat
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___originalMat_17;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::restoreMaterialOnDisable
	bool ___restoreMaterialOnDisable_18;
	// System.Int32 AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::propertyShaderID
	int32_t ___propertyShaderID_19;
	// UnityEngine.Vector2 AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::currValue
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___currValue_20;
	// System.Boolean AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::isValid
	bool ___isValid_21;

public:
	inline static int32_t get_offset_of_texturePropertyName_4() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___texturePropertyName_4)); }
	inline String_t* get_texturePropertyName_4() const { return ___texturePropertyName_4; }
	inline String_t** get_address_of_texturePropertyName_4() { return &___texturePropertyName_4; }
	inline void set_texturePropertyName_4(String_t* value)
	{
		___texturePropertyName_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___texturePropertyName_4), (void*)value);
	}

	inline static int32_t get_offset_of_scrollSpeed_5() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___scrollSpeed_5)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_scrollSpeed_5() const { return ___scrollSpeed_5; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_scrollSpeed_5() { return &___scrollSpeed_5; }
	inline void set_scrollSpeed_5(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___scrollSpeed_5 = value;
	}

	inline static int32_t get_offset_of_textureOffset_6() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___textureOffset_6)); }
	inline bool get_textureOffset_6() const { return ___textureOffset_6; }
	inline bool* get_address_of_textureOffset_6() { return &___textureOffset_6; }
	inline void set_textureOffset_6(bool value)
	{
		___textureOffset_6 = value;
	}

	inline static int32_t get_offset_of_backAndForth_7() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___backAndForth_7)); }
	inline bool get_backAndForth_7() const { return ___backAndForth_7; }
	inline bool* get_address_of_backAndForth_7() { return &___backAndForth_7; }
	inline void set_backAndForth_7(bool value)
	{
		___backAndForth_7 = value;
	}

	inline static int32_t get_offset_of_maxValue_8() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___maxValue_8)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_maxValue_8() const { return ___maxValue_8; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_maxValue_8() { return &___maxValue_8; }
	inline void set_maxValue_8(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___maxValue_8 = value;
	}

	inline static int32_t get_offset_of_iniValue_9() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___iniValue_9)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_iniValue_9() const { return ___iniValue_9; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_iniValue_9() { return &___iniValue_9; }
	inline void set_iniValue_9(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___iniValue_9 = value;
	}

	inline static int32_t get_offset_of_goingUpX_10() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___goingUpX_10)); }
	inline bool get_goingUpX_10() const { return ___goingUpX_10; }
	inline bool* get_address_of_goingUpX_10() { return &___goingUpX_10; }
	inline void set_goingUpX_10(bool value)
	{
		___goingUpX_10 = value;
	}

	inline static int32_t get_offset_of_goingUpY_11() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___goingUpY_11)); }
	inline bool get_goingUpY_11() const { return ___goingUpY_11; }
	inline bool* get_address_of_goingUpY_11() { return &___goingUpY_11; }
	inline void set_goingUpY_11(bool value)
	{
		___goingUpY_11 = value;
	}

	inline static int32_t get_offset_of_applyModulo_12() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___applyModulo_12)); }
	inline bool get_applyModulo_12() const { return ___applyModulo_12; }
	inline bool* get_address_of_applyModulo_12() { return &___applyModulo_12; }
	inline void set_applyModulo_12(bool value)
	{
		___applyModulo_12 = value;
	}

	inline static int32_t get_offset_of_modulo_13() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___modulo_13)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_modulo_13() const { return ___modulo_13; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_modulo_13() { return &___modulo_13; }
	inline void set_modulo_13(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___modulo_13 = value;
	}

	inline static int32_t get_offset_of_stopAtValue_14() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___stopAtValue_14)); }
	inline bool get_stopAtValue_14() const { return ___stopAtValue_14; }
	inline bool* get_address_of_stopAtValue_14() { return &___stopAtValue_14; }
	inline void set_stopAtValue_14(bool value)
	{
		___stopAtValue_14 = value;
	}

	inline static int32_t get_offset_of_stopValue_15() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___stopValue_15)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_stopValue_15() const { return ___stopValue_15; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_stopValue_15() { return &___stopValue_15; }
	inline void set_stopValue_15(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___stopValue_15 = value;
	}

	inline static int32_t get_offset_of_mat_16() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___mat_16)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_mat_16() const { return ___mat_16; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_mat_16() { return &___mat_16; }
	inline void set_mat_16(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___mat_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mat_16), (void*)value);
	}

	inline static int32_t get_offset_of_originalMat_17() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___originalMat_17)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_originalMat_17() const { return ___originalMat_17; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_originalMat_17() { return &___originalMat_17; }
	inline void set_originalMat_17(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___originalMat_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___originalMat_17), (void*)value);
	}

	inline static int32_t get_offset_of_restoreMaterialOnDisable_18() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___restoreMaterialOnDisable_18)); }
	inline bool get_restoreMaterialOnDisable_18() const { return ___restoreMaterialOnDisable_18; }
	inline bool* get_address_of_restoreMaterialOnDisable_18() { return &___restoreMaterialOnDisable_18; }
	inline void set_restoreMaterialOnDisable_18(bool value)
	{
		___restoreMaterialOnDisable_18 = value;
	}

	inline static int32_t get_offset_of_propertyShaderID_19() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___propertyShaderID_19)); }
	inline int32_t get_propertyShaderID_19() const { return ___propertyShaderID_19; }
	inline int32_t* get_address_of_propertyShaderID_19() { return &___propertyShaderID_19; }
	inline void set_propertyShaderID_19(int32_t value)
	{
		___propertyShaderID_19 = value;
	}

	inline static int32_t get_offset_of_currValue_20() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___currValue_20)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_currValue_20() const { return ___currValue_20; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_currValue_20() { return &___currValue_20; }
	inline void set_currValue_20(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___currValue_20 = value;
	}

	inline static int32_t get_offset_of_isValid_21() { return static_cast<int32_t>(offsetof(AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19, ___isValid_21)); }
	inline bool get_isValid_21() const { return ___isValid_21; }
	inline bool* get_address_of_isValid_21() { return &___isValid_21; }
	inline void set_isValid_21(bool value)
	{
		___isValid_21 = value;
	}
};


// AllIn1VfxToolkit.SetAllIn1VfxCustomGlobalTime
struct SetAllIn1VfxCustomGlobalTime_t88A8D3A9AF3C302E3FCFF781A03834E55ED18E30  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Int32 AllIn1VfxToolkit.SetAllIn1VfxCustomGlobalTime::globalTime
	int32_t ___globalTime_4;
	// UnityEngine.Vector4 AllIn1VfxToolkit.SetAllIn1VfxCustomGlobalTime::timeVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___timeVector_5;

public:
	inline static int32_t get_offset_of_globalTime_4() { return static_cast<int32_t>(offsetof(SetAllIn1VfxCustomGlobalTime_t88A8D3A9AF3C302E3FCFF781A03834E55ED18E30, ___globalTime_4)); }
	inline int32_t get_globalTime_4() const { return ___globalTime_4; }
	inline int32_t* get_address_of_globalTime_4() { return &___globalTime_4; }
	inline void set_globalTime_4(int32_t value)
	{
		___globalTime_4 = value;
	}

	inline static int32_t get_offset_of_timeVector_5() { return static_cast<int32_t>(offsetof(SetAllIn1VfxCustomGlobalTime_t88A8D3A9AF3C302E3FCFF781A03834E55ED18E30, ___timeVector_5)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_timeVector_5() const { return ___timeVector_5; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_timeVector_5() { return &___timeVector_5; }
	inline void set_timeVector_5(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___timeVector_5 = value;
	}
};


// UnityEngine.EventSystems.UIBehaviour
struct UIBehaviour_tD1C6E2D542222546D68510ECE74036EFBC3C3B0E  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:

public:
};


// UnityEngine.UI.Graphic
struct Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24  : public UIBehaviour_tD1C6E2D542222546D68510ECE74036EFBC3C3B0E
{
public:
	// UnityEngine.Material UnityEngine.UI.Graphic::m_Material
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___m_Material_6;
	// UnityEngine.Color UnityEngine.UI.Graphic::m_Color
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_Color_7;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipLayoutUpdate
	bool ___m_SkipLayoutUpdate_8;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipMaterialUpdate
	bool ___m_SkipMaterialUpdate_9;
	// System.Boolean UnityEngine.UI.Graphic::m_RaycastTarget
	bool ___m_RaycastTarget_10;
	// UnityEngine.Vector4 UnityEngine.UI.Graphic::m_RaycastPadding
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___m_RaycastPadding_11;
	// UnityEngine.RectTransform UnityEngine.UI.Graphic::m_RectTransform
	RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___m_RectTransform_12;
	// UnityEngine.CanvasRenderer UnityEngine.UI.Graphic::m_CanvasRenderer
	CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E * ___m_CanvasRenderer_13;
	// UnityEngine.Canvas UnityEngine.UI.Graphic::m_Canvas
	Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA * ___m_Canvas_14;
	// System.Boolean UnityEngine.UI.Graphic::m_VertsDirty
	bool ___m_VertsDirty_15;
	// System.Boolean UnityEngine.UI.Graphic::m_MaterialDirty
	bool ___m_MaterialDirty_16;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyLayoutCallback
	UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * ___m_OnDirtyLayoutCallback_17;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyVertsCallback
	UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * ___m_OnDirtyVertsCallback_18;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyMaterialCallback
	UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * ___m_OnDirtyMaterialCallback_19;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::m_CachedMesh
	Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___m_CachedMesh_22;
	// UnityEngine.Vector2[] UnityEngine.UI.Graphic::m_CachedUvs
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___m_CachedUvs_23;
	// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween> UnityEngine.UI.Graphic::m_ColorTweenRunner
	TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3 * ___m_ColorTweenRunner_24;
	// System.Boolean UnityEngine.UI.Graphic::<useLegacyMeshGeneration>k__BackingField
	bool ___U3CuseLegacyMeshGenerationU3Ek__BackingField_25;

public:
	inline static int32_t get_offset_of_m_Material_6() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_Material_6)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_m_Material_6() const { return ___m_Material_6; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_m_Material_6() { return &___m_Material_6; }
	inline void set_m_Material_6(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___m_Material_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Material_6), (void*)value);
	}

	inline static int32_t get_offset_of_m_Color_7() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_Color_7)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_Color_7() const { return ___m_Color_7; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_Color_7() { return &___m_Color_7; }
	inline void set_m_Color_7(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_Color_7 = value;
	}

	inline static int32_t get_offset_of_m_SkipLayoutUpdate_8() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_SkipLayoutUpdate_8)); }
	inline bool get_m_SkipLayoutUpdate_8() const { return ___m_SkipLayoutUpdate_8; }
	inline bool* get_address_of_m_SkipLayoutUpdate_8() { return &___m_SkipLayoutUpdate_8; }
	inline void set_m_SkipLayoutUpdate_8(bool value)
	{
		___m_SkipLayoutUpdate_8 = value;
	}

	inline static int32_t get_offset_of_m_SkipMaterialUpdate_9() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_SkipMaterialUpdate_9)); }
	inline bool get_m_SkipMaterialUpdate_9() const { return ___m_SkipMaterialUpdate_9; }
	inline bool* get_address_of_m_SkipMaterialUpdate_9() { return &___m_SkipMaterialUpdate_9; }
	inline void set_m_SkipMaterialUpdate_9(bool value)
	{
		___m_SkipMaterialUpdate_9 = value;
	}

	inline static int32_t get_offset_of_m_RaycastTarget_10() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_RaycastTarget_10)); }
	inline bool get_m_RaycastTarget_10() const { return ___m_RaycastTarget_10; }
	inline bool* get_address_of_m_RaycastTarget_10() { return &___m_RaycastTarget_10; }
	inline void set_m_RaycastTarget_10(bool value)
	{
		___m_RaycastTarget_10 = value;
	}

	inline static int32_t get_offset_of_m_RaycastPadding_11() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_RaycastPadding_11)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_m_RaycastPadding_11() const { return ___m_RaycastPadding_11; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_m_RaycastPadding_11() { return &___m_RaycastPadding_11; }
	inline void set_m_RaycastPadding_11(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___m_RaycastPadding_11 = value;
	}

	inline static int32_t get_offset_of_m_RectTransform_12() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_RectTransform_12)); }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * get_m_RectTransform_12() const { return ___m_RectTransform_12; }
	inline RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 ** get_address_of_m_RectTransform_12() { return &___m_RectTransform_12; }
	inline void set_m_RectTransform_12(RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * value)
	{
		___m_RectTransform_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_RectTransform_12), (void*)value);
	}

	inline static int32_t get_offset_of_m_CanvasRenderer_13() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_CanvasRenderer_13)); }
	inline CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E * get_m_CanvasRenderer_13() const { return ___m_CanvasRenderer_13; }
	inline CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E ** get_address_of_m_CanvasRenderer_13() { return &___m_CanvasRenderer_13; }
	inline void set_m_CanvasRenderer_13(CanvasRenderer_tCF8ABE659F7C3A6ED0D99A988D0BDFB651310F0E * value)
	{
		___m_CanvasRenderer_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CanvasRenderer_13), (void*)value);
	}

	inline static int32_t get_offset_of_m_Canvas_14() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_Canvas_14)); }
	inline Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA * get_m_Canvas_14() const { return ___m_Canvas_14; }
	inline Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA ** get_address_of_m_Canvas_14() { return &___m_Canvas_14; }
	inline void set_m_Canvas_14(Canvas_t2B7E56B7BDC287962E092755372E214ACB6393EA * value)
	{
		___m_Canvas_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Canvas_14), (void*)value);
	}

	inline static int32_t get_offset_of_m_VertsDirty_15() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_VertsDirty_15)); }
	inline bool get_m_VertsDirty_15() const { return ___m_VertsDirty_15; }
	inline bool* get_address_of_m_VertsDirty_15() { return &___m_VertsDirty_15; }
	inline void set_m_VertsDirty_15(bool value)
	{
		___m_VertsDirty_15 = value;
	}

	inline static int32_t get_offset_of_m_MaterialDirty_16() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_MaterialDirty_16)); }
	inline bool get_m_MaterialDirty_16() const { return ___m_MaterialDirty_16; }
	inline bool* get_address_of_m_MaterialDirty_16() { return &___m_MaterialDirty_16; }
	inline void set_m_MaterialDirty_16(bool value)
	{
		___m_MaterialDirty_16 = value;
	}

	inline static int32_t get_offset_of_m_OnDirtyLayoutCallback_17() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_OnDirtyLayoutCallback_17)); }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * get_m_OnDirtyLayoutCallback_17() const { return ___m_OnDirtyLayoutCallback_17; }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 ** get_address_of_m_OnDirtyLayoutCallback_17() { return &___m_OnDirtyLayoutCallback_17; }
	inline void set_m_OnDirtyLayoutCallback_17(UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * value)
	{
		___m_OnDirtyLayoutCallback_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnDirtyLayoutCallback_17), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnDirtyVertsCallback_18() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_OnDirtyVertsCallback_18)); }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * get_m_OnDirtyVertsCallback_18() const { return ___m_OnDirtyVertsCallback_18; }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 ** get_address_of_m_OnDirtyVertsCallback_18() { return &___m_OnDirtyVertsCallback_18; }
	inline void set_m_OnDirtyVertsCallback_18(UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * value)
	{
		___m_OnDirtyVertsCallback_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnDirtyVertsCallback_18), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnDirtyMaterialCallback_19() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_OnDirtyMaterialCallback_19)); }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * get_m_OnDirtyMaterialCallback_19() const { return ___m_OnDirtyMaterialCallback_19; }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 ** get_address_of_m_OnDirtyMaterialCallback_19() { return &___m_OnDirtyMaterialCallback_19; }
	inline void set_m_OnDirtyMaterialCallback_19(UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * value)
	{
		___m_OnDirtyMaterialCallback_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnDirtyMaterialCallback_19), (void*)value);
	}

	inline static int32_t get_offset_of_m_CachedMesh_22() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_CachedMesh_22)); }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * get_m_CachedMesh_22() const { return ___m_CachedMesh_22; }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 ** get_address_of_m_CachedMesh_22() { return &___m_CachedMesh_22; }
	inline void set_m_CachedMesh_22(Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * value)
	{
		___m_CachedMesh_22 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CachedMesh_22), (void*)value);
	}

	inline static int32_t get_offset_of_m_CachedUvs_23() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_CachedUvs_23)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_m_CachedUvs_23() const { return ___m_CachedUvs_23; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_m_CachedUvs_23() { return &___m_CachedUvs_23; }
	inline void set_m_CachedUvs_23(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___m_CachedUvs_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CachedUvs_23), (void*)value);
	}

	inline static int32_t get_offset_of_m_ColorTweenRunner_24() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___m_ColorTweenRunner_24)); }
	inline TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3 * get_m_ColorTweenRunner_24() const { return ___m_ColorTweenRunner_24; }
	inline TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3 ** get_address_of_m_ColorTweenRunner_24() { return &___m_ColorTweenRunner_24; }
	inline void set_m_ColorTweenRunner_24(TweenRunner_1_tD84B9953874682FCC36990AF2C54D748293908F3 * value)
	{
		___m_ColorTweenRunner_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ColorTweenRunner_24), (void*)value);
	}

	inline static int32_t get_offset_of_U3CuseLegacyMeshGenerationU3Ek__BackingField_25() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24, ___U3CuseLegacyMeshGenerationU3Ek__BackingField_25)); }
	inline bool get_U3CuseLegacyMeshGenerationU3Ek__BackingField_25() const { return ___U3CuseLegacyMeshGenerationU3Ek__BackingField_25; }
	inline bool* get_address_of_U3CuseLegacyMeshGenerationU3Ek__BackingField_25() { return &___U3CuseLegacyMeshGenerationU3Ek__BackingField_25; }
	inline void set_U3CuseLegacyMeshGenerationU3Ek__BackingField_25(bool value)
	{
		___U3CuseLegacyMeshGenerationU3Ek__BackingField_25 = value;
	}
};

struct Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields
{
public:
	// UnityEngine.Material UnityEngine.UI.Graphic::s_DefaultUI
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___s_DefaultUI_4;
	// UnityEngine.Texture2D UnityEngine.UI.Graphic::s_WhiteTexture
	Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * ___s_WhiteTexture_5;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::s_Mesh
	Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___s_Mesh_20;
	// UnityEngine.UI.VertexHelper UnityEngine.UI.Graphic::s_VertexHelper
	VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55 * ___s_VertexHelper_21;

public:
	inline static int32_t get_offset_of_s_DefaultUI_4() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields, ___s_DefaultUI_4)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get_s_DefaultUI_4() const { return ___s_DefaultUI_4; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of_s_DefaultUI_4() { return &___s_DefaultUI_4; }
	inline void set_s_DefaultUI_4(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		___s_DefaultUI_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_DefaultUI_4), (void*)value);
	}

	inline static int32_t get_offset_of_s_WhiteTexture_5() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields, ___s_WhiteTexture_5)); }
	inline Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * get_s_WhiteTexture_5() const { return ___s_WhiteTexture_5; }
	inline Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF ** get_address_of_s_WhiteTexture_5() { return &___s_WhiteTexture_5; }
	inline void set_s_WhiteTexture_5(Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * value)
	{
		___s_WhiteTexture_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_WhiteTexture_5), (void*)value);
	}

	inline static int32_t get_offset_of_s_Mesh_20() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields, ___s_Mesh_20)); }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * get_s_Mesh_20() const { return ___s_Mesh_20; }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 ** get_address_of_s_Mesh_20() { return &___s_Mesh_20; }
	inline void set_s_Mesh_20(Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * value)
	{
		___s_Mesh_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Mesh_20), (void*)value);
	}

	inline static int32_t get_offset_of_s_VertexHelper_21() { return static_cast<int32_t>(offsetof(Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_StaticFields, ___s_VertexHelper_21)); }
	inline VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55 * get_s_VertexHelper_21() const { return ___s_VertexHelper_21; }
	inline VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55 ** get_address_of_s_VertexHelper_21() { return &___s_VertexHelper_21; }
	inline void set_s_VertexHelper_21(VertexHelper_tDE8B67D3B076061C4F8DF325B0D63ED2E5367E55 * value)
	{
		___s_VertexHelper_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_VertexHelper_21), (void*)value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// UnityEngine.Color[]
struct ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  m_Items[1];

public:
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		m_Items[index] = value;
	}
};


// !!0 UnityEngine.Component::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);

// System.Void UnityEngine.MaterialPropertyBlock::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MaterialPropertyBlock__ctor_m8EB29E415C68427B841A0C68A902A8368B9228E8 (MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Random::Range(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2 (float ___minInclusive0, float ___maxInclusive1, const RuntimeMethod* method);
// System.Void UnityEngine.MaterialPropertyBlock::SetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MaterialPropertyBlock_SetFloat_m5AADD8A9BFF5C1DD5A93BF028A2F001681221942 (MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0 * __this, String_t* ___name0, float ___value1, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<UnityEngine.Renderer>()
inline Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Void UnityEngine.Renderer::SetPropertyBlock(UnityEngine.MaterialPropertyBlock)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Renderer_SetPropertyBlock_m3F0E4E98D8274A1396AEBA8456AFA4036DCA7B7A (Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * __this, MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0 * ___properties0, const RuntimeMethod* method);
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED (MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<UnityEngine.UI.Graphic>()
inline Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Void UnityEngine.Material::.ctor(UnityEngine.Material)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material__ctor_mD0C3D9CFAFE0FB858D864092467387D7FA178245 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___source0, const RuntimeMethod* method);
// UnityEngine.Camera UnityEngine.Camera::get_main()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * Camera_get_main_mC337C621B91591CEF89504C97EF64D717C12871C (const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.Component::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Object::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___obj0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1LookAt::LookAtCompute()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1LookAt_LookAtCompute_mFD63205452D0C6D03C1B5074CC6A16AE05E74ECD (AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::op_Subtraction(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Subtraction_m2725C96965D5C0B1F9715797E51762B13A5FED58_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_normalized()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_get_normalized_m2FA6DF38F97BDA4CCBDAE12B9FE913A241DAC8D5 (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::op_UnaryNegation(UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_UnaryNegation_m362EA356F4CADEDB39F965A0DBDED6EA890925F7_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_forward(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_forward_mAE46B156F55F2F90AB495B17F7C20BF59A5D7D4D (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_up(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_up_m3D2B71DA51EA167C367FD275B7B28241C565F127 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_right(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_right_m2BD2600E354493BDBFCBA5A888C4B5B970E25EE1 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.ScriptableObject::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScriptableObject__ctor_m8DAE6CDCFA34E16F2543B02CC3669669FF203063 (ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_time()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844 (const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, float ___d1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_up()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_get_up_m38AECA68388D446CFADDD022B0B867293044EA50 (const RuntimeMethod* method);
// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::SetMaterial(AllIn1VfxToolkit.AllIn1VfxComponent/AfterSetAction,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AllIn1VfxComponent_SetMaterial_m3D27CEA9242D386912A203C4D39B8025D5637903 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, int32_t ___action0, String_t* ___shaderName1, const RuntimeMethod* method);
// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::FetchCurrentMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AllIn1VfxComponent_FetchCurrentMaterial_m885E353DC41A32ABCC5F0FFB4E60BD1E837EE15F (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method);
// UnityEngine.Shader UnityEngine.Material::get_shader()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * Material_get_shader_mEB85A8B8CA57235C464C2CC255E77A4EFF7A6097 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, const RuntimeMethod* method);
// System.Boolean System.String::Contains(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_Contains_mA26BDCCE8F191E8965EB8EEFC18BB4D0F85A075A (String_t* __this, String_t* ___value0, const RuntimeMethod* method);
// System.String System.String::Replace(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_m98184150DC4E2FBDF13E723BF5B7353D9602AC4D (String_t* __this, String_t* ___oldValue0, String_t* ___newValue1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// UnityEngine.Material UnityEngine.Renderer::get_sharedMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Material_t8927C00353A72755313F046D0CE85178AE8218EE * Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC (Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::MissingRenderer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_MissingRenderer_mF7493A4E6DCECC02BE4E58FF50812DBCBF113168 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method);
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E (RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ___handle0, const RuntimeMethod* method);
// UnityEngine.Object UnityEngine.Resources::Load(System.String,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * Resources_Load_m6E8E5EA02A03F3AFC8FD2D775263DBBC64BF205C (String_t* ___path0, Type_t * ___systemTypeInstance1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Application::get_isPlaying()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Application_get_isPlaying_m7BB718D8E58B807184491F64AFF0649517E56567 (const RuntimeMethod* method);
// System.Boolean UnityEngine.Application::get_isEditor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Application_get_isEditor_m7367DDB72F13E4846E8EB76FFAAACA84840BE921 (const RuntimeMethod* method);
// System.Void UnityEngine.Material::.ctor(UnityEngine.Shader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * ___shader0, const RuntimeMethod* method);
// System.Void UnityEngine.Renderer::set_sharedMaterial(UnityEngine.Material)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Renderer_set_sharedMaterial_m1E66766F93E95F692C3C9C2C09AFD795B156678B (Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * __this, Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Object::set_hideFlags(UnityEngine.HideFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_hideFlags_m7DE229AF60B92F0C68819F77FEB27D775E66F3AC (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::DoAfterSetAction(AllIn1VfxToolkit.AllIn1VfxComponent/AfterSetAction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_DoAfterSetAction_m217395F8482ADF520175C064B9B52775A6B52D09 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, int32_t ___action0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::SetSceneDirty()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_SetSceneDirty_m634F7661D8BE028F64392B8977C5B4E12C11B4F7 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::ClearAllKeywords()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_ClearAllKeywords_m3A14ABD5E4F5355EBB040EA398A44EDB560FEE23 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Material::CopyPropertiesFromMaterial(UnityEngine.Material)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_CopyPropertiesFromMaterial_m5A6DE308328EAB762EF5BE3253B728C8078773CF (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___mat0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::ResetAllProperties(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_ResetAllProperties_m4213382EC2C7B58B5AF75AE7884FA08F9ABD850B (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___shaderName0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::CleanMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_CleanMaterial_mC2A22C06FDB3714F36A5987A0D46657CC36E9C33 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::MakeNewMaterial(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_MakeNewMaterial_mF79917FE346F452A88B52EAAD19CB21FA61378D3 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___shaderName0, bool ___notifyWhenDone1, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::SetKeyword(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___keyword0, bool ___state1, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::FindCurrMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_FindCurrMaterial_mD55ED8C69FFED0CACBE6B41EDF1023E3A679BAF8 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Material::DisableKeyword(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_DisableKeyword_mD43BE3ED8D792B7242F5487ADC074DF2A5A1BD18 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, String_t* ___keyword0, const RuntimeMethod* method);
// System.Void UnityEngine.Material::EnableKeyword(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_EnableKeyword_mBD03896F11814C3EF67F73A414DC66D5B577171D (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, String_t* ___keyword0, const RuntimeMethod* method);
// UnityEngine.Shader UnityEngine.Shader::Find(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * Shader_Find_m596EC6EBDCA8C9D5D86E2410A319928C1E8E6B5A (String_t* ___name0, const RuntimeMethod* method);
// System.String System.Int32::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411 (int32_t* __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// System.Boolean System.IO.File::Exists(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool File_Exists_mDAEBF2732BC830270FD98346F069B04E97BB1D5B (String_t* ___path0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::SaveMaterialWithOtherName(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_SaveMaterialWithOtherName_m3AFF42A73EFD79F9E786523CCCE279440D28F005 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___path0, int32_t ___i1, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::DoSaving(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_DoSaving_m1B8F3CF6A479EA0D48F82F598BFAA258A21A0C65 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___fileName0, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::SetGlobalFakeLightDir()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter_SetGlobalFakeLightDir_m8A68B5C8DC56823C5DB77D8EE000C3648639F2E9 (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Shader::PropertyToID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Shader_PropertyToID_m8C1BEBBAC0CC3015B142AF0FA856495D5D239F5F (String_t* ___name0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Transform::get_forward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Transform_get_forward_mD850B9ECF892009E3485408DC0D375165B7BF053 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// UnityEngine.Vector4 UnityEngine.Vector4::op_Implicit(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Implicit_mDCFA56E9D34979E1E2BFE6C2D61F1768D934A8EB (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___v0, const RuntimeMethod* method);
// System.Void UnityEngine.Shader::SetGlobalVector(System.Int32,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Shader_SetGlobalVector_m241FC10C437094156CA0C6CC299A3F09404CE1F3 (int32_t ___nameID0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Random::InitState(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Random_InitState_m9030E6387803E8EBAD0A5B0150254A89F8286A9C (int32_t ___seed0, const RuntimeMethod* method);
// UnityEngine.Color AllIn1VfxToolkit.AllIn1VfxNoiseCreator::CalculatePerlinColor(System.Int32,System.Int32,System.Single,System.Single,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  AllIn1VfxNoiseCreator_CalculatePerlinColor_m6169C2262BEC02E6147CD1569605005DA8D7BE83 (int32_t ___x0, int32_t ___y1, float ___scale2, float ___offset3, int32_t ___width4, int32_t ___height5, const RuntimeMethod* method);
// System.Void UnityEngine.Texture2D::SetPixel(System.Int32,System.Int32,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixel_m78878905E58C5DE9BCFED8D9262D025789E22F92 (Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * __this, int32_t ___x0, int32_t ___y1, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___color2, const RuntimeMethod* method);
// System.Void UnityEngine.Texture2D::Apply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_Apply_m3BB3975288119BA62ED9BE4243F7767EC2F88CA0 (Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Texture2D::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D__ctor_m7D64AB4C55A01F2EE57483FD9EF826607DF9E4B4 (Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * __this, int32_t ___width0, int32_t ___height1, const RuntimeMethod* method);
// UnityEngine.Color[] UnityEngine.Texture2D::GetPixels()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* Texture2D_GetPixels_m702E1E59DE60A5A11197DA3F6474F9E6716D9699 (Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Texture2D::SetPixels(UnityEngine.Color[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixels_m5FBA81041D65F8641C3107195D390EE65467FB4F (Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * __this, ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* ___colors0, const RuntimeMethod* method);
// UnityEngine.Color AllIn1VfxToolkit.AllIn1VfxNoiseCreator::PerlinBorderless(System.Int32,System.Int32,System.Single,System.Single,System.Int32,System.Int32,UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  AllIn1VfxNoiseCreator_PerlinBorderless_m1D51AB4CA3E41D16520E0CBCA9EF6572B79C2945 (int32_t ___x0, int32_t ___y1, float ___scale2, float ___offset3, int32_t ___width4, int32_t ___height5, Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * ___previousPerlin6, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::PerlinNoise(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519 (float ___x0, float ___y1, const RuntimeMethod* method);
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5 (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * __this, float ___r0, float ___g1, float ___b2, float ___a3, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::Max(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775 (float ___a0, float ___b1, const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.Texture2D::GetPixel(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  Texture2D_GetPixel_m50474A401DE4CB3B567F1695546DF1D2C610A022 (Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * __this, int32_t ___x0, int32_t ___y1, const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.Color::Lerp(UnityEngine.Color,UnityEngine.Color,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  Color_Lerp_mC986D7F29103536908D76BD8FC59AA11DC33C197 (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___a0, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___b1, float ___t2, const RuntimeMethod* method);
// UnityEngine.Material UnityEngine.Renderer::get_material()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Material_t8927C00353A72755313F046D0CE85178AE8218EE * Renderer_get_material_mE6B01125502D08EE0D6DFE2EAEC064AD9BB31804 (Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * __this, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::DestroyComponentAndLogError(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderProperty_DestroyComponentAndLogError_m231A4CA6AA3EBEA08563EB49E17D6837CEFB1D6C (AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D * __this, String_t* ___logError0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Material::HasProperty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Material_HasProperty_mB6F155CD45C688DA232B56BD1A74474C224BE37E (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, String_t* ___name0, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78 (String_t* ___str00, String_t* ___str11, String_t* ___str22, String_t* ___str33, const RuntimeMethod* method);
// System.Single UnityEngine.Material::GetFloat(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Material_GetFloat_m508B992651DD512ECB2A51336C9A4E87AED82D27 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, int32_t ___nameID0, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_deltaTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290 (const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::FlipGoingUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderProperty_FlipGoingUp_m1944D5CE97AD4D3A046FE80A4E8ABFA9AE8E5C20 (AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Material::SetFloat(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetFloat_mAC7DC962B356565CF6743E358C7A19D0322EA060 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, int32_t ___nameID0, float ___value1, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::DestroyComponentAndLogError(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderTexture_DestroyComponentAndLogError_mD828DDA85F26B992A873F05CE6AE4FB5C54BFD93 (AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19 * __this, String_t* ___logError0, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Material::GetTextureOffset(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Material_GetTextureOffset_m47FBA39C48B10DEAF3431284315C558BF642A2C6 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, String_t* ___name0, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Material::GetTextureScale(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Material_GetTextureScale_mEE8950B66B5B60BDB92D41A6902E41AA1EDDEBE7 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, String_t* ___name0, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Vector2::op_Multiply(UnityEngine.Vector2,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_op_Multiply_mC7A7802352867555020A90205EBABA56EE5E36CB_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___a0, float ___d1, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Vector2::op_Addition(UnityEngine.Vector2,UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___a0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___b1, const RuntimeMethod* method);
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::FlipGoingUp(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderTexture_FlipGoingUp_m5266F3FB872E3720455F0B2FD8BC1ACAD60FD749 (AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19 * __this, bool ___isXComponent0, const RuntimeMethod* method);
// System.Void UnityEngine.Material::SetTextureOffset(System.Int32,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetTextureOffset_mDEE0C861BD2FC8D38924087590BE8FD123195A78 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, int32_t ___nameID0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Material::SetTextureScale(System.Int32,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetTextureScale_m9F02CF20C15805224119E8A1AE57B1B064CB72C1 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, int32_t ___nameID0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value1, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Vector2::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828 (const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Vector2::get_one()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_get_one_m9B2AFD26404B6DD0F520D19FC7F79371C5C18B42 (const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_unscaledTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_unscaledTime_m85A3479E3D78D05FEDEEFEF36944AC5EF9B31258 (const RuntimeMethod* method);
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method);
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * __this, float ___x0, float ___y1, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.All1VfxRandomTimeSeed::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1VfxRandomTimeSeed_Start_mBE68B468F9F1CEC4931E43029ACFBDB82D7C2C75 (All1VfxRandomTimeSeed_tBA3108FD5DED576806EB7A92332E0F959A2525F2 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCF6B5D4AFB7B21CFD9A2454BF9D1139B1B749D14);
		s_Il2CppMethodInitialized = true;
	}
	MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0 * V_0 = NULL;
	{
		// MaterialPropertyBlock properties = new MaterialPropertyBlock();
		MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0 * L_0 = (MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0 *)il2cpp_codegen_object_new(MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0_il2cpp_TypeInfo_var);
		MaterialPropertyBlock__ctor_m8EB29E415C68427B841A0C68A902A8368B9228E8(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		// properties.SetFloat("_TimingSeed", Random.Range(minSeedValue, maxSeedValue));
		MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0 * L_1 = V_0;
		float L_2 = __this->get_minSeedValue_4();
		float L_3 = __this->get_maxSeedValue_5();
		float L_4;
		L_4 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2(L_2, L_3, /*hidden argument*/NULL);
		NullCheck(L_1);
		MaterialPropertyBlock_SetFloat_m5AADD8A9BFF5C1DD5A93BF028A2F001681221942(L_1, _stringLiteralCF6B5D4AFB7B21CFD9A2454BF9D1139B1B749D14, L_4, /*hidden argument*/NULL);
		// GetComponent<Renderer>().SetPropertyBlock(properties);
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_5;
		L_5 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		MaterialPropertyBlock_t6C45FC5DE951DA662BBB7A55EEB3DEF33C5431A0 * L_6 = V_0;
		NullCheck(L_5);
		Renderer_SetPropertyBlock_m3F0E4E98D8274A1396AEBA8456AFA4036DCA7B7A(L_5, L_6, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.All1VfxRandomTimeSeed::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void All1VfxRandomTimeSeed__ctor_m07A6B2AEB62A5C13A44CE8E0180623D1A6EE6100 (All1VfxRandomTimeSeed_tBA3108FD5DED576806EB7A92332E0F959A2525F2 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private float maxSeedValue = 100f;
		__this->set_maxSeedValue_5((100.0f));
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.Scripts.AllIn1GraphicMaterialDuplicate::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1GraphicMaterialDuplicate_Awake_mE053AB593FC877DFBC347B80593A78D731409619 (AllIn1GraphicMaterialDuplicate_t9EE1CA6AB67523669608892E39F054971BC2CB6D * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Graphic graphic = GetComponent<Graphic>();
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_0;
		L_0 = Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1(__this, /*hidden argument*/Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		// graphic.material = new Material(graphic.material);
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_1 = L_0;
		NullCheck(L_1);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_2;
		L_2 = VirtFuncInvoker0< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(32 /* UnityEngine.Material UnityEngine.UI.Graphic::get_material() */, L_1);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_3 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD0C3D9CFAFE0FB858D864092467387D7FA178245(L_3, L_2, /*hidden argument*/NULL);
		NullCheck(L_1);
		VirtActionInvoker1< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(33 /* System.Void UnityEngine.UI.Graphic::set_material(UnityEngine.Material) */, L_1, L_3);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.Scripts.AllIn1GraphicMaterialDuplicate::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1GraphicMaterialDuplicate__ctor_mC0D3766A2E64FB8E6DEAD502387377C5E09CD4A9 (AllIn1GraphicMaterialDuplicate_t9EE1CA6AB67523669608892E39F054971BC2CB6D * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.AllIn1LookAt::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1LookAt_Start_mA36E040296B077890965407CF60152B1E5DFA964 (AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6B20C68293E633F1FCCB3BBD64B19DD052F5ED87);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral872DCAB5572E264E9E4EA514D7E835229090D6BC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9A5093C3D376CC1E1CC7EEF2F6A221406781623A);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(targetIsMainCamera)
		bool L_0 = __this->get_targetIsMainCamera_5();
		if (!L_0)
		{
			goto IL_0054;
		}
	}
	{
		// if(!(Camera.main is null)) target = Camera.main.transform;
		Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * L_1;
		L_1 = Camera_get_main_mC337C621B91591CEF89504C97EF64D717C12871C(/*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_001f;
		}
	}
	{
		// if(!(Camera.main is null)) target = Camera.main.transform;
		Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * L_2;
		L_2 = Camera_get_main_mC337C621B91591CEF89504C97EF64D717C12871C(/*hidden argument*/NULL);
		NullCheck(L_2);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_3;
		L_3 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(L_2, /*hidden argument*/NULL);
		__this->set_target_6(L_3);
	}

IL_001f:
	{
		// if(target == null)
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_4 = __this->get_target_6();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_5;
		L_5 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_4, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_0087;
		}
	}
	{
		// Debug.LogError("No main camera was found, AllIn1LookAt component of " + gameObject.name + " will now be destroyed. Please double check your setup");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_6;
		L_6 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_6);
		String_t* L_7;
		L_7 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_6, /*hidden argument*/NULL);
		String_t* L_8;
		L_8 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(_stringLiteral6B20C68293E633F1FCCB3BBD64B19DD052F5ED87, L_7, _stringLiteral9A5093C3D376CC1E1CC7EEF2F6A221406781623A, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_8, /*hidden argument*/NULL);
		// Destroy(this);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(__this, /*hidden argument*/NULL);
		// }
		goto IL_0087;
	}

IL_0054:
	{
		// if(target == null)
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_9 = __this->get_target_6();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_10;
		L_10 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_9, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_10)
		{
			goto IL_0087;
		}
	}
	{
		// Debug.LogError("No target was assigned, AllIn1LookAt component of " + gameObject.name + " will now be destroyed. Please double check your setup");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_11;
		L_11 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_11);
		String_t* L_12;
		L_12 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_11, /*hidden argument*/NULL);
		String_t* L_13;
		L_13 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(_stringLiteral872DCAB5572E264E9E4EA514D7E835229090D6BC, L_12, _stringLiteral9A5093C3D376CC1E1CC7EEF2F6A221406781623A, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_13, /*hidden argument*/NULL);
		// Destroy(this);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(__this, /*hidden argument*/NULL);
	}

IL_0087:
	{
		// if(!updateEveryFrame) LookAtCompute();
		bool L_14 = __this->get_updateEveryFrame_4();
		if (L_14)
		{
			goto IL_0095;
		}
	}
	{
		// if(!updateEveryFrame) LookAtCompute();
		AllIn1LookAt_LookAtCompute_mFD63205452D0C6D03C1B5074CC6A16AE05E74ECD(__this, /*hidden argument*/NULL);
	}

IL_0095:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1LookAt::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1LookAt_Update_m71860A272FBEB545D1F7D92946B1B4CF2BDB3755 (AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F * __this, const RuntimeMethod* method)
{
	{
		// if(updateEveryFrame) LookAtCompute();
		bool L_0 = __this->get_updateEveryFrame_4();
		if (!L_0)
		{
			goto IL_000e;
		}
	}
	{
		// if(updateEveryFrame) LookAtCompute();
		AllIn1LookAt_LookAtCompute_mFD63205452D0C6D03C1B5074CC6A16AE05E74ECD(__this, /*hidden argument*/NULL);
	}

IL_000e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1LookAt::LookAtCompute()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1LookAt_LookAtCompute_mFD63205452D0C6D03C1B5074CC6A16AE05E74ECD (AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_1;
	memset((&V_1), 0, sizeof(V_1));
	int32_t V_2 = 0;
	{
		// Vector3 lookAtVector = (target.position - transform.position).normalized;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0 = __this->get_target_6();
		NullCheck(L_0);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1;
		L_1 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_0, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_2;
		L_2 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_2);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_3;
		L_3 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_2, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4;
		L_4 = Vector3_op_Subtraction_m2725C96965D5C0B1F9715797E51762B13A5FED58_inline(L_1, L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_5;
		L_5 = Vector3_get_normalized_m2FA6DF38F97BDA4CCBDAE12B9FE913A241DAC8D5((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_1), /*hidden argument*/NULL);
		V_0 = L_5;
		// if(negateDirection) lookAtVector = -lookAtVector;
		bool L_6 = __this->get_negateDirection_8();
		if (!L_6)
		{
			goto IL_0033;
		}
	}
	{
		// if(negateDirection) lookAtVector = -lookAtVector;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_7 = V_0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_8;
		L_8 = Vector3_op_UnaryNegation_m362EA356F4CADEDB39F965A0DBDED6EA890925F7_inline(L_7, /*hidden argument*/NULL);
		V_0 = L_8;
	}

IL_0033:
	{
		// switch(faceDirection)
		int32_t L_9 = __this->get_faceDirection_7();
		V_2 = L_9;
		int32_t L_10 = V_2;
		switch (L_10)
		{
			case 0:
			{
				goto IL_004d;
			}
			case 1:
			{
				goto IL_005a;
			}
			case 2:
			{
				goto IL_0067;
			}
		}
	}
	{
		return;
	}

IL_004d:
	{
		// transform.forward = lookAtVector;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_11;
		L_11 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_12 = V_0;
		NullCheck(L_11);
		Transform_set_forward_mAE46B156F55F2F90AB495B17F7C20BF59A5D7D4D(L_11, L_12, /*hidden argument*/NULL);
		// break;
		return;
	}

IL_005a:
	{
		// transform.up = lookAtVector;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_13;
		L_13 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_14 = V_0;
		NullCheck(L_13);
		Transform_set_up_m3D2B71DA51EA167C367FD275B7B28241C565F127(L_13, L_14, /*hidden argument*/NULL);
		// break;
		return;
	}

IL_0067:
	{
		// transform.right = lookAtVector;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_15;
		L_15 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_16 = V_0;
		NullCheck(L_15);
		Transform_set_right_m2BD2600E354493BDBFCBA5A888C4B5B970E25EE1(L_15, L_16, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1LookAt::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1LookAt__ctor_m1C398F71459E9707302C904D6988A340691158B7 (AllIn1LookAt_t2FDA6EDF490BF08EE1F4F94016B095C4CC089D9F * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.AllIn1ParticleHelperComponent::SetSceneDirty()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1ParticleHelperComponent_SetSceneDirty_m2A5404374B583B0BC7D352044645119DF6A54926 (AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665 * __this, const RuntimeMethod* method)
{
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1ParticleHelperComponent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1ParticleHelperComponent__ctor_mFC4D777FCBA5FD237B842968B88A60E86727DD7C (AllIn1ParticleHelperComponent_tF22E9BF0B0088DFAD29DB24A04632AD5BDEE4665 * __this, const RuntimeMethod* method)
{
	{
		// public int numberOfCopies = 1;
		__this->set_numberOfCopies_12(1);
		// public bool applyEverythingOnChange = true;
		__this->set_applyEverythingOnChange_13((bool)1);
		// public float minLifetime = 5f, maxLifetime = 5f;
		__this->set_minLifetime_16((5.0f));
		// public float minLifetime = 5f, maxLifetime = 5f;
		__this->set_maxLifetime_17((5.0f));
		// public float minSpeed = 5f, maxSpeed = 5f;
		__this->set_minSpeed_18((5.0f));
		// public float minSpeed = 5f, maxSpeed = 5f;
		__this->set_maxSpeed_19((5.0f));
		// public float minSize = 1f, maxSize = 1f;
		__this->set_minSize_20((1.0f));
		// public float minSize = 1f, maxSize = 1f;
		__this->set_maxSize_21((1.0f));
		// public int minNumberOfParticles = 10, maxNumberOfParticles = 10;
		__this->set_minNumberOfParticles_24(((int32_t)10));
		// public int minNumberOfParticles = 10, maxNumberOfParticles = 10;
		__this->set_maxNumberOfParticles_25(((int32_t)10));
		// public LifetimeSettings colorLifetime = LifetimeSettings.None;
		__this->set_colorLifetime_27(2);
		// public LifetimeSettings sizeLifetime = LifetimeSettings.None;
		__this->set_sizeLifetime_28(2);
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.AllIn1ParticleHelperSO::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1ParticleHelperSO__ctor_m18C0E2BEEEB87B234925D08A2A5BC197472AECE1 (AllIn1ParticleHelperSO_tBBB48DE1378CC2C173DB04690157F8EE327F76E0 * __this, const RuntimeMethod* method)
{
	{
		// public float minLifetime = 5f, maxLifetime = 5f;
		__this->set_minLifetime_6((5.0f));
		// public float minLifetime = 5f, maxLifetime = 5f;
		__this->set_maxLifetime_7((5.0f));
		// public float minSpeed = 5f, maxSpeed = 5f;
		__this->set_minSpeed_8((5.0f));
		// public float minSpeed = 5f, maxSpeed = 5f;
		__this->set_maxSpeed_9((5.0f));
		// public float minSize = 1f, maxSize = 1f;
		__this->set_minSize_10((1.0f));
		// public float minSize = 1f, maxSize = 1f;
		__this->set_maxSize_11((1.0f));
		// public int minNumberOfParticles = 10, maxNumberOfParticles = 10;
		__this->set_minNumberOfParticles_14(((int32_t)10));
		// public int minNumberOfParticles = 10, maxNumberOfParticles = 10;
		__this->set_maxNumberOfParticles_15(((int32_t)10));
		// public AllIn1ParticleHelperComponent.LifetimeSettings colorLifetime = AllIn1ParticleHelperComponent.LifetimeSettings.Descendent;
		__this->set_colorLifetime_17(1);
		ScriptableObject__ctor_m8DAE6CDCFA34E16F2543B02CC3669669FF203063(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.AllIn1VfxBounceAnimation::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxBounceAnimation_Start_mDAEB4BCE98C346ACD8AC264B834640662888474E (AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF * __this, const RuntimeMethod* method)
{
	{
		// startPosition = transform.position;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0;
		L_0 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1;
		L_1 = Transform_get_position_m40A8A9895568D56FFC687B57F30E8D53CB5EA341(L_0, /*hidden argument*/NULL);
		__this->set_startPosition_6(L_1);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxBounceAnimation::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxBounceAnimation_Update_mF713E95099CCFBB67191E654B3C2BD0A34FC585D (AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF * __this, const RuntimeMethod* method)
{
	{
		// animationMovementVector = targetOffset * ((Mathf.Sin(Time.time * speed) + 1f) / 2f);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = __this->get_targetOffset_4();
		float L_1;
		L_1 = Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844(/*hidden argument*/NULL);
		float L_2 = __this->get_speed_5();
		float L_3;
		L_3 = sinf(((float)il2cpp_codegen_multiply((float)L_1, (float)L_2)));
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4;
		L_4 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_0, ((float)((float)((float)il2cpp_codegen_add((float)L_3, (float)(1.0f)))/(float)(2.0f))), /*hidden argument*/NULL);
		__this->set_animationMovementVector_7(L_4);
		// transform.position = startPosition + animationMovementVector;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_5;
		L_5 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6 = __this->get_startPosition_6();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_7 = __this->get_animationMovementVector_7();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_8;
		L_8 = Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline(L_6, L_7, /*hidden argument*/NULL);
		NullCheck(L_5);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_5, L_8, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxBounceAnimation::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxBounceAnimation__ctor_mFA57F27BA8A2A801732D12C909A18E0DDFA1D041 (AllIn1VfxBounceAnimation_tEFFC4126D8E7C86D7A893BF578AA9F2B863679EF * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private Vector3 targetOffset = Vector3.up;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0;
		L_0 = Vector3_get_up_m38AECA68388D446CFADDD022B0B867293044EA50(/*hidden argument*/NULL);
		__this->set_targetOffset_4(L_0);
		// [SerializeField] private float speed = 1f;
		__this->set_speed_5((1.0f));
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::MakeNewMaterial(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_MakeNewMaterial_mF79917FE346F452A88B52EAAD19CB21FA61378D3 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___shaderName0, bool ___notifyWhenDone1, const RuntimeMethod* method)
{
	{
		// bool operationSuccessful = SetMaterial(AfterSetAction.Clear, shaderName);
		String_t* L_0 = ___shaderName0;
		bool L_1;
		L_1 = AllIn1VfxComponent_SetMaterial_m3D27CEA9242D386912A203C4D39B8025D5637903(__this, 0, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::MakeCopy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AllIn1VfxComponent_MakeCopy_m95AAD5EAF719ECC7C92318E319FB687E41187658 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9CE902BD3933F71AD381D3042D88DF18342E37C4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		// if(currMaterial == null)
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_0 = __this->get_currMaterial_4();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0018;
		}
	}
	{
		// if(FetchCurrentMaterial()) return false;
		bool L_2;
		L_2 = AllIn1VfxComponent_FetchCurrentMaterial_m885E353DC41A32ABCC5F0FFB4E60BD1E837EE15F(__this, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_0018;
		}
	}
	{
		// if(FetchCurrentMaterial()) return false;
		return (bool)0;
	}

IL_0018:
	{
		// string shaderName = currMaterial.shader.name;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_3 = __this->get_currMaterial_4();
		NullCheck(L_3);
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_4;
		L_4 = Material_get_shader_mEB85A8B8CA57235C464C2CC255E77A4EFF7A6097(L_3, /*hidden argument*/NULL);
		NullCheck(L_4);
		String_t* L_5;
		L_5 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_4, /*hidden argument*/NULL);
		V_0 = L_5;
		// if(shaderName.Contains("AllIn1Vfx/")) shaderName = shaderName.Replace("AllIn1Vfx/", "");
		String_t* L_6 = V_0;
		NullCheck(L_6);
		bool L_7;
		L_7 = String_Contains_mA26BDCCE8F191E8965EB8EEFC18BB4D0F85A075A(L_6, _stringLiteral9CE902BD3933F71AD381D3042D88DF18342E37C4, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0047;
		}
	}
	{
		// if(shaderName.Contains("AllIn1Vfx/")) shaderName = shaderName.Replace("AllIn1Vfx/", "");
		String_t* L_8 = V_0;
		NullCheck(L_8);
		String_t* L_9;
		L_9 = String_Replace_m98184150DC4E2FBDF13E723BF5B7353D9602AC4D(L_8, _stringLiteral9CE902BD3933F71AD381D3042D88DF18342E37C4, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, /*hidden argument*/NULL);
		V_0 = L_9;
	}

IL_0047:
	{
		// SetMaterial(AfterSetAction.CopyMaterial, shaderName);
		String_t* L_10 = V_0;
		bool L_11;
		L_11 = AllIn1VfxComponent_SetMaterial_m3D27CEA9242D386912A203C4D39B8025D5637903(__this, 1, L_10, /*hidden argument*/NULL);
		// return true;
		return (bool)1;
	}
}
// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::FetchCurrentMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AllIn1VfxComponent_FetchCurrentMaterial_m885E353DC41A32ABCC5F0FFB4E60BD1E837EE15F (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * V_1 = NULL;
	Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * V_2 = NULL;
	{
		// bool rendererExists = false;
		V_0 = (bool)0;
		// Renderer sr = GetComponent<Renderer>();
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_0;
		L_0 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		V_1 = L_0;
		// if(sr != null)
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_1 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_1, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_0022;
		}
	}
	{
		// rendererExists = true;
		V_0 = (bool)1;
		// currMaterial = sr.sharedMaterial;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_3 = V_1;
		NullCheck(L_3);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_4;
		L_4 = Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC(L_3, /*hidden argument*/NULL);
		__this->set_currMaterial_4(L_4);
		// }
		goto IL_0040;
	}

IL_0022:
	{
		// Graphic img = GetComponent<Graphic>();
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_5;
		L_5 = Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1(__this, /*hidden argument*/Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		V_2 = L_5;
		// if(img != null)
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_6 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_6, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0040;
		}
	}
	{
		// rendererExists = true;
		V_0 = (bool)1;
		// currMaterial = img.material;
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_8 = V_2;
		NullCheck(L_8);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_9;
		L_9 = VirtFuncInvoker0< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(32 /* UnityEngine.Material UnityEngine.UI.Graphic::get_material() */, L_8);
		__this->set_currMaterial_4(L_9);
	}

IL_0040:
	{
		// if(!rendererExists)
		bool L_10 = V_0;
		if (L_10)
		{
			goto IL_004b;
		}
	}
	{
		// MissingRenderer();
		AllIn1VfxComponent_MissingRenderer_mF7493A4E6DCECC02BE4E58FF50812DBCBF113168(__this, /*hidden argument*/NULL);
		// return true;
		return (bool)1;
	}

IL_004b:
	{
		// return false;
		return (bool)0;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::ResetAllProperties(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_ResetAllProperties_m4213382EC2C7B58B5AF75AE7884FA08F9ABD850B (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___shaderName0, const RuntimeMethod* method)
{
	{
		// SetMaterial(AfterSetAction.Reset, shaderName);
		String_t* L_0 = ___shaderName0;
		bool L_1;
		L_1 = AllIn1VfxComponent_SetMaterial_m3D27CEA9242D386912A203C4D39B8025D5637903(__this, 2, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::SetMaterial(AllIn1VfxToolkit.AllIn1VfxComponent/AfterSetAction,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AllIn1VfxComponent_SetMaterial_m3D27CEA9242D386912A203C4D39B8025D5637903 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, int32_t ___action0, String_t* ___shaderName1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * V_0 = NULL;
	bool V_1 = false;
	Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * V_2 = NULL;
	{
		// Shader allIn1VfxShader = Resources.Load(shaderName, typeof(Shader)) as Shader;
		String_t* L_0 = ___shaderName1;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_1 = { reinterpret_cast<intptr_t> (Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_2;
		L_2 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E(L_1, /*hidden argument*/NULL);
		Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * L_3;
		L_3 = Resources_Load_m6E8E5EA02A03F3AFC8FD2D775263DBBC64BF205C(L_0, L_2, /*hidden argument*/NULL);
		V_0 = ((Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 *)IsInstSealed((RuntimeObject*)L_3, Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39_il2cpp_TypeInfo_var));
		// if(!Application.isPlaying && Application.isEditor && allIn1VfxShader != null)
		bool L_4;
		L_4 = Application_get_isPlaying_m7BB718D8E58B807184491F64AFF0649517E56567(/*hidden argument*/NULL);
		if (L_4)
		{
			goto IL_0104;
		}
	}
	{
		bool L_5;
		L_5 = Application_get_isEditor_m7367DDB72F13E4846E8EB76FFAAACA84840BE921(/*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_0104;
		}
	}
	{
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_6 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_6, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0104;
		}
	}
	{
		// bool rendererExists = false;
		V_1 = (bool)0;
		// Renderer sr = GetComponent<Renderer>();
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_8;
		L_8 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		// if(sr != null)
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_9;
		L_9 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_8, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_9)
		{
			goto IL_009c;
		}
	}
	{
		// rendererExists = true;
		V_1 = (bool)1;
		// prevMaterial = new Material(GetComponent<Renderer>().sharedMaterial);
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_10;
		L_10 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		NullCheck(L_10);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_11;
		L_11 = Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC(L_10, /*hidden argument*/NULL);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_12 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD0C3D9CFAFE0FB858D864092467387D7FA178245(L_12, L_11, /*hidden argument*/NULL);
		__this->set_prevMaterial_5(L_12);
		// currMaterial = new Material(allIn1VfxShader);
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_13 = V_0;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_14 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E(L_14, L_13, /*hidden argument*/NULL);
		__this->set_currMaterial_4(L_14);
		// GetComponent<Renderer>().sharedMaterial = currMaterial;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_15;
		L_15 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_16 = __this->get_currMaterial_4();
		NullCheck(L_15);
		Renderer_set_sharedMaterial_m1E66766F93E95F692C3C9C2C09AFD795B156678B(L_15, L_16, /*hidden argument*/NULL);
		// GetComponent<Renderer>().sharedMaterial.hideFlags = HideFlags.None;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_17;
		L_17 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		NullCheck(L_17);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_18;
		L_18 = Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC(L_17, /*hidden argument*/NULL);
		NullCheck(L_18);
		Object_set_hideFlags_m7DE229AF60B92F0C68819F77FEB27D775E66F3AC(L_18, 0, /*hidden argument*/NULL);
		// matAssigned = true;
		__this->set_matAssigned_6((bool)1);
		// DoAfterSetAction(action);
		int32_t L_19 = ___action0;
		AllIn1VfxComponent_DoAfterSetAction_m217395F8482ADF520175C064B9B52775A6B52D09(__this, L_19, /*hidden argument*/NULL);
		// }
		goto IL_00f1;
	}

IL_009c:
	{
		// Graphic img = GetComponent<Graphic>();
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_20;
		L_20 = Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1(__this, /*hidden argument*/Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		V_2 = L_20;
		// if(img != null)
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_21 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_22;
		L_22 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_21, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_22)
		{
			goto IL_00f1;
		}
	}
	{
		// rendererExists = true;
		V_1 = (bool)1;
		// prevMaterial = new Material(img.material);
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_23 = V_2;
		NullCheck(L_23);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_24;
		L_24 = VirtFuncInvoker0< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(32 /* UnityEngine.Material UnityEngine.UI.Graphic::get_material() */, L_23);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_25 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD0C3D9CFAFE0FB858D864092467387D7FA178245(L_25, L_24, /*hidden argument*/NULL);
		__this->set_prevMaterial_5(L_25);
		// currMaterial = new Material(allIn1VfxShader);
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_26 = V_0;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_27 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E(L_27, L_26, /*hidden argument*/NULL);
		__this->set_currMaterial_4(L_27);
		// img.material = currMaterial;
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_28 = V_2;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_29 = __this->get_currMaterial_4();
		NullCheck(L_28);
		VirtActionInvoker1< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(33 /* System.Void UnityEngine.UI.Graphic::set_material(UnityEngine.Material) */, L_28, L_29);
		// img.material.hideFlags = HideFlags.None;
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_30 = V_2;
		NullCheck(L_30);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_31;
		L_31 = VirtFuncInvoker0< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(32 /* UnityEngine.Material UnityEngine.UI.Graphic::get_material() */, L_30);
		NullCheck(L_31);
		Object_set_hideFlags_m7DE229AF60B92F0C68819F77FEB27D775E66F3AC(L_31, 0, /*hidden argument*/NULL);
		// matAssigned = true;
		__this->set_matAssigned_6((bool)1);
		// DoAfterSetAction(action);
		int32_t L_32 = ___action0;
		AllIn1VfxComponent_DoAfterSetAction_m217395F8482ADF520175C064B9B52775A6B52D09(__this, L_32, /*hidden argument*/NULL);
	}

IL_00f1:
	{
		// if(!rendererExists) MissingRenderer();
		bool L_33 = V_1;
		if (L_33)
		{
			goto IL_00fc;
		}
	}
	{
		// if(!rendererExists) MissingRenderer();
		AllIn1VfxComponent_MissingRenderer_mF7493A4E6DCECC02BE4E58FF50812DBCBF113168(__this, /*hidden argument*/NULL);
		goto IL_0102;
	}

IL_00fc:
	{
		// else SetSceneDirty();
		AllIn1VfxComponent_SetSceneDirty_m634F7661D8BE028F64392B8977C5B4E12C11B4F7(__this, /*hidden argument*/NULL);
	}

IL_0102:
	{
		// return rendererExists;
		bool L_34 = V_1;
		return L_34;
	}

IL_0104:
	{
		// else if(allIn1VfxShader == null)
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_35 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_36;
		L_36 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_35, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		// return false;
		return (bool)0;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::DoAfterSetAction(AllIn1VfxToolkit.AllIn1VfxComponent/AfterSetAction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_DoAfterSetAction_m217395F8482ADF520175C064B9B52775A6B52D09 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, int32_t ___action0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___action0;
		if (!L_0)
		{
			goto IL_0008;
		}
	}
	{
		int32_t L_1 = ___action0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_000f;
		}
	}
	{
		return;
	}

IL_0008:
	{
		// ClearAllKeywords();
		AllIn1VfxComponent_ClearAllKeywords_m3A14ABD5E4F5355EBB040EA398A44EDB560FEE23(__this, /*hidden argument*/NULL);
		// break;
		return;
	}

IL_000f:
	{
		// currMaterial.CopyPropertiesFromMaterial(prevMaterial);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_2 = __this->get_currMaterial_4();
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_3 = __this->get_prevMaterial_5();
		NullCheck(L_2);
		Material_CopyPropertiesFromMaterial_m5A6DE308328EAB762EF5BE3253B728C8078773CF(L_2, L_3, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::TryCreateNew()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AllIn1VfxComponent_TryCreateNew_m3F3E450A19D23CBF0BBD2C19D3E9B1AA0E930460 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC76190ED0C48EB995A11E863941095B1AA26B582);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCEE91F51A391C3F771D9B2463C388312AA8DA8CF);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * V_1 = NULL;
	Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * V_2 = NULL;
	{
		// bool rendererExists = false;
		V_0 = (bool)0;
		// Renderer sr = GetComponent<Renderer>();
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_0;
		L_0 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		V_1 = L_0;
		// if(sr != null)
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_1 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_1, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_006e;
		}
	}
	{
		// rendererExists = true;
		V_0 = (bool)1;
		// if(sr != null && sr.sharedMaterial != null && sr.sharedMaterial.shader.name.Contains("Vfx"))
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_3 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_3, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_005a;
		}
	}
	{
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_5 = V_1;
		NullCheck(L_5);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_6;
		L_6 = Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC(L_5, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_6, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_005a;
		}
	}
	{
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_8 = V_1;
		NullCheck(L_8);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_9;
		L_9 = Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC(L_8, /*hidden argument*/NULL);
		NullCheck(L_9);
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_10;
		L_10 = Material_get_shader_mEB85A8B8CA57235C464C2CC255E77A4EFF7A6097(L_9, /*hidden argument*/NULL);
		NullCheck(L_10);
		String_t* L_11;
		L_11 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_10, /*hidden argument*/NULL);
		NullCheck(L_11);
		bool L_12;
		L_12 = String_Contains_mA26BDCCE8F191E8965EB8EEFC18BB4D0F85A075A(L_11, _stringLiteralC76190ED0C48EB995A11E863941095B1AA26B582, /*hidden argument*/NULL);
		if (!L_12)
		{
			goto IL_005a;
		}
	}
	{
		// ResetAllProperties("AllIn1Vfx");
		AllIn1VfxComponent_ResetAllProperties_m4213382EC2C7B58B5AF75AE7884FA08F9ABD850B(__this, _stringLiteralCEE91F51A391C3F771D9B2463C388312AA8DA8CF, /*hidden argument*/NULL);
		// ClearAllKeywords();
		AllIn1VfxComponent_ClearAllKeywords_m3A14ABD5E4F5355EBB040EA398A44EDB560FEE23(__this, /*hidden argument*/NULL);
		// }
		goto IL_00bb;
	}

IL_005a:
	{
		// CleanMaterial();
		AllIn1VfxComponent_CleanMaterial_mC2A22C06FDB3714F36A5987A0D46657CC36E9C33(__this, /*hidden argument*/NULL);
		// MakeNewMaterial("AllIn1Vfx");
		AllIn1VfxComponent_MakeNewMaterial_mF79917FE346F452A88B52EAAD19CB21FA61378D3(__this, _stringLiteralCEE91F51A391C3F771D9B2463C388312AA8DA8CF, (bool)0, /*hidden argument*/NULL);
		// }
		goto IL_00bb;
	}

IL_006e:
	{
		// Graphic img = GetComponent<Graphic>();
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_13;
		L_13 = Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1(__this, /*hidden argument*/Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		V_2 = L_13;
		// if(img != null)
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_14 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_15;
		L_15 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_14, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_15)
		{
			goto IL_00bb;
		}
	}
	{
		// rendererExists = true;
		V_0 = (bool)1;
		// if(img.material.shader.name.Contains("Vfx"))
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_16 = V_2;
		NullCheck(L_16);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_17;
		L_17 = VirtFuncInvoker0< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(32 /* UnityEngine.Material UnityEngine.UI.Graphic::get_material() */, L_16);
		NullCheck(L_17);
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_18;
		L_18 = Material_get_shader_mEB85A8B8CA57235C464C2CC255E77A4EFF7A6097(L_17, /*hidden argument*/NULL);
		NullCheck(L_18);
		String_t* L_19;
		L_19 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_18, /*hidden argument*/NULL);
		NullCheck(L_19);
		bool L_20;
		L_20 = String_Contains_mA26BDCCE8F191E8965EB8EEFC18BB4D0F85A075A(L_19, _stringLiteralC76190ED0C48EB995A11E863941095B1AA26B582, /*hidden argument*/NULL);
		if (!L_20)
		{
			goto IL_00af;
		}
	}
	{
		// ResetAllProperties("AllIn1Vfx");
		AllIn1VfxComponent_ResetAllProperties_m4213382EC2C7B58B5AF75AE7884FA08F9ABD850B(__this, _stringLiteralCEE91F51A391C3F771D9B2463C388312AA8DA8CF, /*hidden argument*/NULL);
		// ClearAllKeywords();
		AllIn1VfxComponent_ClearAllKeywords_m3A14ABD5E4F5355EBB040EA398A44EDB560FEE23(__this, /*hidden argument*/NULL);
		// }
		goto IL_00bb;
	}

IL_00af:
	{
		// else MakeNewMaterial("AllIn1Vfx");
		AllIn1VfxComponent_MakeNewMaterial_mF79917FE346F452A88B52EAAD19CB21FA61378D3(__this, _stringLiteralCEE91F51A391C3F771D9B2463C388312AA8DA8CF, (bool)0, /*hidden argument*/NULL);
	}

IL_00bb:
	{
		// if(!rendererExists)
		bool L_21 = V_0;
		if (L_21)
		{
			goto IL_00c4;
		}
	}
	{
		// MissingRenderer();
		AllIn1VfxComponent_MissingRenderer_mF7493A4E6DCECC02BE4E58FF50812DBCBF113168(__this, /*hidden argument*/NULL);
	}

IL_00c4:
	{
		// SetSceneDirty();
		AllIn1VfxComponent_SetSceneDirty_m634F7661D8BE028F64392B8977C5B4E12C11B4F7(__this, /*hidden argument*/NULL);
		// return rendererExists;
		bool L_22 = V_0;
		return L_22;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::ClearAllKeywords()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_ClearAllKeywords_m3A14ABD5E4F5355EBB040EA398A44EDB560FEE23 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0023D6A9F7F3B566DFB2EFA5BE5820D9509D681E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0299CC5F40C577F300BB29854CBAAD8B68ABF5A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0401A6C1F7012C721901C937730CA854AED44F14);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral040793655BC228982AF83F2DE9C015C189306364);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1340C6E5B2B210689A25CF2270555B16E1489106);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral14D479CBF77090A6D30F543484D1D50B87795337);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral158697E57921300501C71DFA8626FCAE1F8FD030);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral185035D897E40E37CE218ED2FFA2B3FD8F8F8F22);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1E1912CAB55AF7DEF1C5B72F955FFFBCB9884AB5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1E74A2EC3C4B69C55D0D1B56F81D53F03FC58D57);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2F3FA2011635BA3ADF04F3A6636CEA5D2D14EF88);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral34AD56288A03AA8D7B7BE17E549C5FB602F9E885);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3C1DB6BCE7F7EC4956D0CD51C602C4B9D94DE193);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3F868CB06E969FC20ED35E84ACC75C8E94BE5789);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral40728BBCE4EE91640605FACC63DB3CEC63B83B80);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4696BEB1B4DD525F1293813D16EC3A02B2B12251);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4A68E99ECA06FD65FDFD5FCD7FECC5839F4C0DBC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4AA79340AA7669BF821B747B748410DB52DA3261);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral51C68DEA8F259A907A0498E34875D1BD0A6CED03);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5398DC3D4FFCD34741F382F596A262B6FA2922AC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral561612A9F818B42EF04003F9D6952E8EC5D027ED);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5904389432FCA9BFEA539A8A22DDC0BD69F94F04);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5A02191D32DC069B431D3E54FF28CEC7767178DB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5CE72404582BDAE77C15BF3F30FEFFD1A81D8F8C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5D5BF7644F6756216DBAE69270F57FE11BEAE972);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5F61F506633DBCEB100F2CA993128F6DC6A9C618);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral638A6BF6390D12422CAC4910C95F16CFBCE6D50B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6677C73BF64E77B045EA94D2AA385D7540F0A39D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6757D44A85F13AA2863BDC7DCEF5E30BC21278BD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7281FF2F619273B6F998E3D3DCA0CFAF23CCFAD2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral72A7CAD40240F38905C2C0E1E50F4449AD82AEAB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral757FDB668BCAADD3B45A3175E6AC8EBACA3EEB65);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral76264918B150B6FD44125E9CE7F711A3689B9700);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral79BCB0C2B8C16448AD04D20C4925CF363A67BAA9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7D2ED17259CF0DC4179D682E4471BF85B5574BBA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DDFF290B24173A5DC1BC9BC22C9322BB36CFC10);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral89115C0E93F9302CD0B8CD7BB21C410B6162644D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8DED3C670AB3C2E5A20C926F89F96926BE24AC79);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral92274FFFE307A7AA40F70ECBD38BB73705AC9E5B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral94BD673B8551A4C6D6A807ED9D7A6C37D921072F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral94F92EDABB0744C4E72E030B935FEC2580C8A614);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral954CC189A0FC8B78E623F527148C0981714376AC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral99117A43311619936587FBCABCC9B16B687AB302);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9ABAD8FF849D104EA8DB7481A66BB4B9FD7143A2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA27C6266A902DDCC5C73F82BEBBBDF1C87CCFFFA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA66067A208E75497516342A152D58B32B1C89075);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA87819C2031146742C1F5350BC509988DACBE9F9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralAAE3A15202D762AC5E5D99D35460A3E2C88307E1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB1D928ABA3C2555CCA12F60991D28C7F5A0E200E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB8649C06FE9FBAB8E997CBD8796167F6283CAB2C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBCBD8C7003675066255066C8241D1DCB43737145);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC1321093811095513C44D23E1503BACF248356F0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC3A9DE289B76C73BE63D02B5A01D7C45B656AD49);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC879E94E49560F1B236BDF1611C5EC619EA5B93F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCBE96480BEB47650A1397787D142CB9736546564);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD01835DFD9412FEB7AA45A9F2E69029F2B71B936);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD34B357F606D69B3A243155329F7C26E9ED9B03B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD678A75C242A16DA78744D87F52BD6BA550F95C4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDC639E8CFF8B48439F2DC546D026EE8EAB89718B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE8B1F4E65A0B35AB6619D979A27DD1766DEB7039);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEFF7EFBB29A0F779F9CF65D30804B3D60468618E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF4B62A69FCAFBA03A81C4FD2F7CF77104D7CB48D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFD3081C211F1405167EBF5BDD775516383D38F4F);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SetKeyword("FOG_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral34AD56288A03AA8D7B7BE17E549C5FB602F9E885, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SCREENDISTORTION_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral72A7CAD40240F38905C2C0E1E50F4449AD82AEAB, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("DISTORTUSECOL_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral1340C6E5B2B210689A25CF2270555B16E1489106, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("DISTORTONLYBACK_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralC879E94E49560F1B236BDF1611C5EC619EA5B93F, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE1SCREENUV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral2F3FA2011635BA3ADF04F3A6636CEA5D2D14EF88, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE2SCREENUV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral185035D897E40E37CE218ED2FFA2B3FD8F8F8F22, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE3SCREENUV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral5D5BF7644F6756216DBAE69270F57FE11BEAE972, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPEDEBUG_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral0401A6C1F7012C721901C937730CA854AED44F14, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE1CONTRAST_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral5CE72404582BDAE77C15BF3F30FEFFD1A81D8F8C, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE1DISTORT_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral94F92EDABB0744C4E72E030B935FEC2580C8A614, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE1ROTATE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral76264918B150B6FD44125E9CE7F711A3689B9700, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE1SHAPECOLOR_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral040793655BC228982AF83F2DE9C015C189306364, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE2_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralCBE96480BEB47650A1397787D142CB9736546564, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE2CONTRAST_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral4AA79340AA7669BF821B747B748410DB52DA3261, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE2DISTORT_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral14D479CBF77090A6D30F543484D1D50B87795337, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE2ROTATE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral8DED3C670AB3C2E5A20C926F89F96926BE24AC79, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE2SHAPECOLOR_");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral94BD673B8551A4C6D6A807ED9D7A6C37D921072F, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE3_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral7DDFF290B24173A5DC1BC9BC22C9322BB36CFC10, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE3CONTRAST_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralF4B62A69FCAFBA03A81C4FD2F7CF77104D7CB48D, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE3DISTORT_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral51C68DEA8F259A907A0498E34875D1BD0A6CED03, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE3ROTATE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralDC639E8CFF8B48439F2DC546D026EE8EAB89718B, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE3SHAPECOLOR_");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralA27C6266A902DDCC5C73F82BEBBBDF1C87CCFFFA, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("GLOW_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralA87819C2031146742C1F5350BC509988DACBE9F9, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("GLOWTEX_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralB8649C06FE9FBAB8E997CBD8796167F6283CAB2C, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SOFTPART_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralB1D928ABA3C2555CCA12F60991D28C7F5A0E200E, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("DEPTHGLOW_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralD01835DFD9412FEB7AA45A9F2E69029F2B71B936, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("MASK_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral954CC189A0FC8B78E623F527148C0981714376AC, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("COLORRAMP_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral9ABAD8FF849D104EA8DB7481A66BB4B9FD7143A2, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("COLORRAMPGRAD_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral89115C0E93F9302CD0B8CD7BB21C410B6162644D, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("COLORGRADING_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralFD3081C211F1405167EBF5BDD775516383D38F4F, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("HSV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral158697E57921300501C71DFA8626FCAE1F8FD030, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("BLUR_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral4696BEB1B4DD525F1293813D16EC3A02B2B12251, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("BLURISHD_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral0023D6A9F7F3B566DFB2EFA5BE5820D9509D681E, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("POSTERIZE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral99117A43311619936587FBCABCC9B16B687AB302, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("FADE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral1E74A2EC3C4B69C55D0D1B56F81D53F03FC58D57, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("FADEBURN_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral6757D44A85F13AA2863BDC7DCEF5E30BC21278BD, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("PIXELATE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral5398DC3D4FFCD34741F382F596A262B6FA2922AC, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("DISTORT_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralE8B1F4E65A0B35AB6619D979A27DD1766DEB7039, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAKEUV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralBCBD8C7003675066255066C8241D1DCB43737145, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("WAVEUV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral7281FF2F619273B6F998E3D3DCA0CFAF23CCFAD2, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("ROUNDWAVEUV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral6677C73BF64E77B045EA94D2AA385D7540F0A39D, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("TWISTUV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral0299CC5F40C577F300BB29854CBAAD8B68ABF5A0, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("DOODLE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral4A68E99ECA06FD65FDFD5FCD7FECC5839F4C0DBC, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("OFFSETSTREAM_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral757FDB668BCAADD3B45A3175E6AC8EBACA3EEB65, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("TEXTURESCROLL_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral638A6BF6390D12422CAC4910C95F16CFBCE6D50B, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("VERTOFFSET_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralA66067A208E75497516342A152D58B32B1C89075, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("RIM_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral92274FFFE307A7AA40F70ECBD38BB73705AC9E5B, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("BACKFACETINT_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral3C1DB6BCE7F7EC4956D0CD51C602C4B9D94DE193, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("POLARUV_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral3F868CB06E969FC20ED35E84ACC75C8E94BE5789, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("POLARUVDISTORT_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral7D2ED17259CF0DC4179D682E4471BF85B5574BBA, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPE1MASK_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral5A02191D32DC069B431D3E54FF28CEC7767178DB, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("TRAILWIDTH_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral5F61F506633DBCEB100F2CA993128F6DC6A9C618, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("LIGHTANDSHADOW_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralD34B357F606D69B3A243155329F7C26E9ED9B03B, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPETEXOFFSET_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral5904389432FCA9BFEA539A8A22DDC0BD69F94F04, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("SHAPEWEIGHTS_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral561612A9F818B42EF04003F9D6952E8EC5D027ED, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("ALPHACUTOFF_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralD678A75C242A16DA78744D87F52BD6BA550F95C4, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("ALPHASMOOTHSTEP_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralAAE3A15202D762AC5E5D99D35460A3E2C88307E1, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("ALPHAFADE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral79BCB0C2B8C16448AD04D20C4925CF363A67BAA9, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("ALPHAFADEUSESHAPE1_");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral40728BBCE4EE91640605FACC63DB3CEC63B83B80, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("ALPHAFADEUSEREDCHAN");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralEFF7EFBB29A0F779F9CF65D30804B3D60468618E, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("ALPHAFADETRANSPAREN");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralC3A9DE289B76C73BE63D02B5A01D7C45B656AD49, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("ALPHAFADEINPUTSTREA");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteral1E1912CAB55AF7DEF1C5B72F955FFFBCB9884AB5, (bool)0, /*hidden argument*/NULL);
		// SetKeyword("CAMDISTFADE_ON");
		AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748(__this, _stringLiteralC1321093811095513C44D23E1503BACF248356F0, (bool)0, /*hidden argument*/NULL);
		// SetSceneDirty();
		AllIn1VfxComponent_SetSceneDirty_m634F7661D8BE028F64392B8977C5B4E12C11B4F7(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::SetKeyword(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_SetKeyword_mB1671D11E961CA16C71A93BE5DE549EC58065748 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___keyword0, bool ___state1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(destroyed) return;
		bool L_0 = __this->get_destroyed_7();
		if (!L_0)
		{
			goto IL_0009;
		}
	}
	{
		// if(destroyed) return;
		return;
	}

IL_0009:
	{
		// if(currMaterial == null)
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_1 = __this->get_currMaterial_4();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_1, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_0032;
		}
	}
	{
		// FindCurrMaterial();
		AllIn1VfxComponent_FindCurrMaterial_mD55ED8C69FFED0CACBE6B41EDF1023E3A679BAF8(__this, /*hidden argument*/NULL);
		// if(currMaterial == null)
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_3 = __this->get_currMaterial_4();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_4;
		L_4 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_3, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_0032;
		}
	}
	{
		// MissingRenderer();
		AllIn1VfxComponent_MissingRenderer_mF7493A4E6DCECC02BE4E58FF50812DBCBF113168(__this, /*hidden argument*/NULL);
		// return;
		return;
	}

IL_0032:
	{
		// if(!state) currMaterial.DisableKeyword(keyword);
		bool L_5 = ___state1;
		if (L_5)
		{
			goto IL_0042;
		}
	}
	{
		// if(!state) currMaterial.DisableKeyword(keyword);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_6 = __this->get_currMaterial_4();
		String_t* L_7 = ___keyword0;
		NullCheck(L_6);
		Material_DisableKeyword_mD43BE3ED8D792B7242F5487ADC074DF2A5A1BD18(L_6, L_7, /*hidden argument*/NULL);
		return;
	}

IL_0042:
	{
		// else currMaterial.EnableKeyword(keyword);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_8 = __this->get_currMaterial_4();
		String_t* L_9 = ___keyword0;
		NullCheck(L_8);
		Material_EnableKeyword_mBD03896F11814C3EF67F73A414DC66D5B577171D(L_8, L_9, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::FindCurrMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_FindCurrMaterial_mD55ED8C69FFED0CACBE6B41EDF1023E3A679BAF8 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * V_0 = NULL;
	{
		// Renderer sr = GetComponent<Renderer>();
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_0;
		L_0 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		// if(sr != null)
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		// currMaterial = GetComponent<Renderer>().sharedMaterial;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_2;
		L_2 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		NullCheck(L_2);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_3;
		L_3 = Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC(L_2, /*hidden argument*/NULL);
		__this->set_currMaterial_4(L_3);
		// matAssigned = true;
		__this->set_matAssigned_6((bool)1);
		// }
		return;
	}

IL_0027:
	{
		// Graphic img = GetComponent<Graphic>();
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_4;
		L_4 = Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1(__this, /*hidden argument*/Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		V_0 = L_4;
		// if(img != null)
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_5 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_6;
		L_6 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_5, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_6)
		{
			goto IL_004a;
		}
	}
	{
		// currMaterial = img.material;
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_7 = V_0;
		NullCheck(L_7);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_8;
		L_8 = VirtFuncInvoker0< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(32 /* UnityEngine.Material UnityEngine.UI.Graphic::get_material() */, L_7);
		__this->set_currMaterial_4(L_8);
		// matAssigned = true;
		__this->set_matAssigned_6((bool)1);
	}

IL_004a:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::CleanMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_CleanMaterial_mC2A22C06FDB3714F36A5987A0D46657CC36E9C33 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral975A5F46FC6E6D8BC7943A3A38CEA489C122E4F1);
		s_Il2CppMethodInitialized = true;
	}
	Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * V_0 = NULL;
	Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * V_1 = NULL;
	{
		// Renderer sr = GetComponent<Renderer>();
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_0;
		L_0 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		V_0 = L_0;
		// if(sr != null)
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_1 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_1, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_002e;
		}
	}
	{
		// sr.sharedMaterial = new Material(Shader.Find("Sprites/Default"));
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_3 = V_0;
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_4;
		L_4 = Shader_Find_m596EC6EBDCA8C9D5D86E2410A319928C1E8E6B5A(_stringLiteral975A5F46FC6E6D8BC7943A3A38CEA489C122E4F1, /*hidden argument*/NULL);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_5 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E(L_5, L_4, /*hidden argument*/NULL);
		NullCheck(L_3);
		Renderer_set_sharedMaterial_m1E66766F93E95F692C3C9C2C09AFD795B156678B(L_3, L_5, /*hidden argument*/NULL);
		// matAssigned = false;
		__this->set_matAssigned_6((bool)0);
		// }
		goto IL_005a;
	}

IL_002e:
	{
		// Graphic img = GetComponent<Graphic>();
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_6;
		L_6 = Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1(__this, /*hidden argument*/Component_GetComponent_TisGraphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24_mC2B96FBBFDBEB7FC16A23436F3C7A3C2740CAAA1_RuntimeMethod_var);
		V_1 = L_6;
		// if(img != null)
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_7 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_8;
		L_8 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_7, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_8)
		{
			goto IL_005a;
		}
	}
	{
		// img.material = new Material(Shader.Find("Sprites/Default"));
		Graphic_tF07D777035055CF93BA5F46F77ED5EDFEFF9AE24 * L_9 = V_1;
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_10;
		L_10 = Shader_Find_m596EC6EBDCA8C9D5D86E2410A319928C1E8E6B5A(_stringLiteral975A5F46FC6E6D8BC7943A3A38CEA489C122E4F1, /*hidden argument*/NULL);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_11 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E(L_11, L_10, /*hidden argument*/NULL);
		NullCheck(L_9);
		VirtActionInvoker1< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(33 /* System.Void UnityEngine.UI.Graphic::set_material(UnityEngine.Material) */, L_9, L_11);
		// matAssigned = false;
		__this->set_matAssigned_6((bool)0);
	}

IL_005a:
	{
		// SetSceneDirty();
		AllIn1VfxComponent_SetSceneDirty_m634F7661D8BE028F64392B8977C5B4E12C11B4F7(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Boolean AllIn1VfxToolkit.AllIn1VfxComponent::SaveMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AllIn1VfxComponent_SaveMaterial_m9B5E30D648D4C6D44B7E5FC52B339F86A092E092 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	{
		// return false;
		return (bool)0;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::SaveMaterialWithOtherName(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_SaveMaterialWithOtherName_m3AFF42A73EFD79F9E786523CCCE279440D28F005 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___path0, int32_t ___i1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral50639CAD49418C7B223CC529395C0E2A3892501C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA0F4CF9D3B8B4AD6A49A888401B14AE51DD52E16);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	String_t* V_1 = NULL;
	{
		// int number = i;
		int32_t L_0 = ___i1;
		V_0 = L_0;
		// string newPath = path + "_" + number.ToString();
		String_t* L_1 = ___path0;
		String_t* L_2;
		L_2 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_0), /*hidden argument*/NULL);
		String_t* L_3;
		L_3 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_1, _stringLiteral50639CAD49418C7B223CC529395C0E2A3892501C, L_2, /*hidden argument*/NULL);
		// string fullPath = newPath + ".mat";
		String_t* L_4;
		L_4 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_3, _stringLiteralA0F4CF9D3B8B4AD6A49A888401B14AE51DD52E16, /*hidden argument*/NULL);
		V_1 = L_4;
		// if(System.IO.File.Exists(fullPath))
		String_t* L_5 = V_1;
		bool L_6;
		L_6 = File_Exists_mDAEBF2732BC830270FD98346F069B04E97BB1D5B(L_5, /*hidden argument*/NULL);
		if (!L_6)
		{
			goto IL_0034;
		}
	}
	{
		// number++;
		int32_t L_7 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_7, (int32_t)1));
		// SaveMaterialWithOtherName(path, number);
		String_t* L_8 = ___path0;
		int32_t L_9 = V_0;
		AllIn1VfxComponent_SaveMaterialWithOtherName_m3AFF42A73EFD79F9E786523CCCE279440D28F005(__this, L_8, L_9, /*hidden argument*/NULL);
		// }
		return;
	}

IL_0034:
	{
		// DoSaving(fullPath);
		String_t* L_10 = V_1;
		AllIn1VfxComponent_DoSaving_m1B8F3CF6A479EA0D48F82F598BFAA258A21A0C65(__this, L_10, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::DoSaving(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_DoSaving_m1B8F3CF6A479EA0D48F82F598BFAA258A21A0C65 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, String_t* ___fileName0, const RuntimeMethod* method)
{
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::SetSceneDirty()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_SetSceneDirty_m634F7661D8BE028F64392B8977C5B4E12C11B4F7 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::MissingRenderer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent_MissingRenderer_mF7493A4E6DCECC02BE4E58FF50812DBCBF113168 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxComponent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxComponent__ctor_m2BDF3FB88DDD322B8300FD7E4EB59BA011728603 (AllIn1VfxComponent_tE7EA7CED2C30B78A54070B26CE6CC8955F4C6D1F * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter_Awake_m83662ECD9776E956E7A080593557FFBFCECD3EBF (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, const RuntimeMethod* method)
{
	{
		// if(setOnAwake) SetGlobalFakeLightDir();
		bool L_0 = __this->get_setOnAwake_4();
		if (!L_0)
		{
			goto IL_000e;
		}
	}
	{
		// if(setOnAwake) SetGlobalFakeLightDir();
		AllIn1VfxFakeLightDirSetter_SetGlobalFakeLightDir_m8A68B5C8DC56823C5DB77D8EE000C3648639F2E9(__this, /*hidden argument*/NULL);
	}

IL_000e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter_Update_m6D77B45BB0460A84B60E1FA651DF8AE483965BED (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, const RuntimeMethod* method)
{
	{
		// if(setOnUpdate) SetGlobalFakeLightDir();
		bool L_0 = __this->get_setOnUpdate_5();
		if (!L_0)
		{
			goto IL_000e;
		}
	}
	{
		// if(setOnUpdate) SetGlobalFakeLightDir();
		AllIn1VfxFakeLightDirSetter_SetGlobalFakeLightDir_m8A68B5C8DC56823C5DB77D8EE000C3648639F2E9(__this, /*hidden argument*/NULL);
	}

IL_000e:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::OnValidate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter_OnValidate_mC136D09C1D09589C8DB370FEF019EFF4C9CCDCEB (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, const RuntimeMethod* method)
{
	{
		// SetGlobalFakeLightDir();
		AllIn1VfxFakeLightDirSetter_SetGlobalFakeLightDir_m8A68B5C8DC56823C5DB77D8EE000C3648639F2E9(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::SetGlobalFakeLightDir()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter_SetGlobalFakeLightDir_m8A68B5C8DC56823C5DB77D8EE000C3648639F2E9 (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC827CF6C30E43507B780232E56A8ECC3A42FD702);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// if(lightDirId == 0) lightDirId = Shader.PropertyToID("_All1VfxLightDir");
		int32_t L_0 = __this->get_lightDirId_7();
		if (L_0)
		{
			goto IL_0018;
		}
	}
	{
		// if(lightDirId == 0) lightDirId = Shader.PropertyToID("_All1VfxLightDir");
		int32_t L_1;
		L_1 = Shader_PropertyToID_m8C1BEBBAC0CC3015B142AF0FA856495D5D239F5F(_stringLiteralC827CF6C30E43507B780232E56A8ECC3A42FD702, /*hidden argument*/NULL);
		__this->set_lightDirId_7(L_1);
	}

IL_0018:
	{
		// if(target == null) target = transform;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_2 = __this->get_target_6();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_2, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0032;
		}
	}
	{
		// if(target == null) target = transform;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_4;
		L_4 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		__this->set_target_6(L_4);
	}

IL_0032:
	{
		// Shader.SetGlobalVector(lightDirId, target.forward.normalized);
		int32_t L_5 = __this->get_lightDirId_7();
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_6 = __this->get_target_6();
		NullCheck(L_6);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_7;
		L_7 = Transform_get_forward_mD850B9ECF892009E3485408DC0D375165B7BF053(L_6, /*hidden argument*/NULL);
		V_0 = L_7;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_8;
		L_8 = Vector3_get_normalized_m2FA6DF38F97BDA4CCBDAE12B9FE913A241DAC8D5((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_9;
		L_9 = Vector4_op_Implicit_mDCFA56E9D34979E1E2BFE6C2D61F1768D934A8EB(L_8, /*hidden argument*/NULL);
		Shader_SetGlobalVector_m241FC10C437094156CA0C6CC299A3F09404CE1F3(L_5, L_9, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::SetNewFakeLightDir(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter_SetNewFakeLightDir_mA835099B5AB07FA09AAE6E9F7239611F563A8782 (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___newFakeLightDir0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC827CF6C30E43507B780232E56A8ECC3A42FD702);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(lightDirId == 0) lightDirId = Shader.PropertyToID("_All1VfxLightDir");
		int32_t L_0 = __this->get_lightDirId_7();
		if (L_0)
		{
			goto IL_0018;
		}
	}
	{
		// if(lightDirId == 0) lightDirId = Shader.PropertyToID("_All1VfxLightDir");
		int32_t L_1;
		L_1 = Shader_PropertyToID_m8C1BEBBAC0CC3015B142AF0FA856495D5D239F5F(_stringLiteralC827CF6C30E43507B780232E56A8ECC3A42FD702, /*hidden argument*/NULL);
		__this->set_lightDirId_7(L_1);
	}

IL_0018:
	{
		// Shader.SetGlobalVector(lightDirId, newFakeLightDir.normalized);
		int32_t L_2 = __this->get_lightDirId_7();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_3;
		L_3 = Vector3_get_normalized_m2FA6DF38F97BDA4CCBDAE12B9FE913A241DAC8D5((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&___newFakeLightDir0), /*hidden argument*/NULL);
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4;
		L_4 = Vector4_op_Implicit_mDCFA56E9D34979E1E2BFE6C2D61F1768D934A8EB(L_3, /*hidden argument*/NULL);
		Shader_SetGlobalVector_m241FC10C437094156CA0C6CC299A3F09404CE1F3(L_2, L_4, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::SetNewTarget(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter_SetNewTarget_mE77009F3C4C807E229BF8A6B78BB553D159FAAA1 (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___newTarget0, const RuntimeMethod* method)
{
	{
		// target = newTarget;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0 = ___newTarget0;
		__this->set_target_6(L_0);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::SetOnUpdateBool(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter_SetOnUpdateBool_m430845ABA1FD693DBDB4AD7B7B4A811F042F2CC5 (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, bool ___newSetOnUpdateValue0, const RuntimeMethod* method)
{
	{
		// setOnUpdate = newSetOnUpdateValue;
		bool L_0 = ___newSetOnUpdateValue0;
		__this->set_setOnUpdate_5(L_0);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxFakeLightDirSetter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxFakeLightDirSetter__ctor_mA4CCF031719C8388205BDA5F18A074F7ED3ECF81 (AllIn1VfxFakeLightDirSetter_tF51438557B33C8F32F3D0A51C8B37BFD3AD1FB43 * __this, const RuntimeMethod* method)
{
	{
		// [SerializeField] private bool setOnAwake = true;
		__this->set_setOnAwake_4((bool)1);
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Texture2D AllIn1VfxToolkit.AllIn1VfxNoiseCreator::PerlinNoise(UnityEngine.Texture2D,System.Single,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * AllIn1VfxNoiseCreator_PerlinNoise_m74B2888A29494F2E54473D4BF81C24FB562C7CC2 (Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * ___tex0, float ___scale1, int32_t ___randomSeed2, bool ___tileable3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	float V_2 = 0.0f;
	Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * V_3 = NULL;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	{
		// int texWidth = tex.width;
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_0 = ___tex0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_0);
		V_0 = L_1;
		// int texHeight = tex.height;
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_2 = ___tex0;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = VirtFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_2);
		V_1 = L_3;
		// Random.InitState(randomSeed);
		int32_t L_4 = ___randomSeed2;
		Random_InitState_m9030E6387803E8EBAD0A5B0150254A89F8286A9C(L_4, /*hidden argument*/NULL);
		// float randomOffset = Random.Range(-100f, 100f);
		float L_5;
		L_5 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2((-100.0f), (100.0f), /*hidden argument*/NULL);
		V_2 = L_5;
		// for(int i = 0; i < texHeight; i++)
		V_4 = 0;
		goto IL_0056;
	}

IL_0029:
	{
		// for(int j = 0; j < texWidth; j++)
		V_5 = 0;
		goto IL_004b;
	}

IL_002e:
	{
		// tex.SetPixel(j, i, CalculatePerlinColor(j, i, scale, randomOffset, texWidth, texHeight));
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_6 = ___tex0;
		int32_t L_7 = V_5;
		int32_t L_8 = V_4;
		int32_t L_9 = V_5;
		int32_t L_10 = V_4;
		float L_11 = ___scale1;
		float L_12 = V_2;
		int32_t L_13 = V_0;
		int32_t L_14 = V_1;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_15;
		L_15 = AllIn1VfxNoiseCreator_CalculatePerlinColor_m6169C2262BEC02E6147CD1569605005DA8D7BE83(L_9, L_10, L_11, L_12, L_13, L_14, /*hidden argument*/NULL);
		NullCheck(L_6);
		Texture2D_SetPixel_m78878905E58C5DE9BCFED8D9262D025789E22F92(L_6, L_7, L_8, L_15, /*hidden argument*/NULL);
		// for(int j = 0; j < texWidth; j++)
		int32_t L_16 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add((int32_t)L_16, (int32_t)1));
	}

IL_004b:
	{
		// for(int j = 0; j < texWidth; j++)
		int32_t L_17 = V_5;
		int32_t L_18 = V_0;
		if ((((int32_t)L_17) < ((int32_t)L_18)))
		{
			goto IL_002e;
		}
	}
	{
		// for(int i = 0; i < texHeight; i++)
		int32_t L_19 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add((int32_t)L_19, (int32_t)1));
	}

IL_0056:
	{
		// for(int i = 0; i < texHeight; i++)
		int32_t L_20 = V_4;
		int32_t L_21 = V_1;
		if ((((int32_t)L_20) < ((int32_t)L_21)))
		{
			goto IL_0029;
		}
	}
	{
		// tex.Apply();
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_22 = ___tex0;
		NullCheck(L_22);
		Texture2D_Apply_m3BB3975288119BA62ED9BE4243F7767EC2F88CA0(L_22, /*hidden argument*/NULL);
		// Texture2D finalPerlin = new Texture2D(texHeight, texWidth);
		int32_t L_23 = V_1;
		int32_t L_24 = V_0;
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_25 = (Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF *)il2cpp_codegen_object_new(Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF_il2cpp_TypeInfo_var);
		Texture2D__ctor_m7D64AB4C55A01F2EE57483FD9EF826607DF9E4B4(L_25, L_23, L_24, /*hidden argument*/NULL);
		V_3 = L_25;
		// finalPerlin.SetPixels(tex.GetPixels());
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_26 = V_3;
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_27 = ___tex0;
		NullCheck(L_27);
		ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* L_28;
		L_28 = Texture2D_GetPixels_m702E1E59DE60A5A11197DA3F6474F9E6716D9699(L_27, /*hidden argument*/NULL);
		NullCheck(L_26);
		Texture2D_SetPixels_m5FBA81041D65F8641C3107195D390EE65467FB4F(L_26, L_28, /*hidden argument*/NULL);
		// if(tileable)
		bool L_29 = ___tileable3;
		if (!L_29)
		{
			goto IL_00b0;
		}
	}
	{
		// for(int i = 0; i < texHeight; i++)
		V_6 = 0;
		goto IL_00ab;
	}

IL_007d:
	{
		// for(int j = 0; j < texWidth; j++)
		V_7 = 0;
		goto IL_00a0;
	}

IL_0082:
	{
		// finalPerlin.SetPixel(j, i, PerlinBorderless(j, i, scale, randomOffset, texWidth, texHeight, tex));
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_30 = V_3;
		int32_t L_31 = V_7;
		int32_t L_32 = V_6;
		int32_t L_33 = V_7;
		int32_t L_34 = V_6;
		float L_35 = ___scale1;
		float L_36 = V_2;
		int32_t L_37 = V_0;
		int32_t L_38 = V_1;
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_39 = ___tex0;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_40;
		L_40 = AllIn1VfxNoiseCreator_PerlinBorderless_m1D51AB4CA3E41D16520E0CBCA9EF6572B79C2945(L_33, L_34, L_35, L_36, L_37, L_38, L_39, /*hidden argument*/NULL);
		NullCheck(L_30);
		Texture2D_SetPixel_m78878905E58C5DE9BCFED8D9262D025789E22F92(L_30, L_31, L_32, L_40, /*hidden argument*/NULL);
		// for(int j = 0; j < texWidth; j++)
		int32_t L_41 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add((int32_t)L_41, (int32_t)1));
	}

IL_00a0:
	{
		// for(int j = 0; j < texWidth; j++)
		int32_t L_42 = V_7;
		int32_t L_43 = V_0;
		if ((((int32_t)L_42) < ((int32_t)L_43)))
		{
			goto IL_0082;
		}
	}
	{
		// for(int i = 0; i < texHeight; i++)
		int32_t L_44 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add((int32_t)L_44, (int32_t)1));
	}

IL_00ab:
	{
		// for(int i = 0; i < texHeight; i++)
		int32_t L_45 = V_6;
		int32_t L_46 = V_1;
		if ((((int32_t)L_45) < ((int32_t)L_46)))
		{
			goto IL_007d;
		}
	}

IL_00b0:
	{
		// finalPerlin.Apply();
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_47 = V_3;
		NullCheck(L_47);
		Texture2D_Apply_m3BB3975288119BA62ED9BE4243F7767EC2F88CA0(L_47, /*hidden argument*/NULL);
		// return finalPerlin;
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_48 = V_3;
		return L_48;
	}
}
// UnityEngine.Color AllIn1VfxToolkit.AllIn1VfxNoiseCreator::CalculatePerlinColor(System.Int32,System.Int32,System.Single,System.Single,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  AllIn1VfxNoiseCreator_CalculatePerlinColor_m6169C2262BEC02E6147CD1569605005DA8D7BE83 (int32_t ___x0, int32_t ___y1, float ___scale2, float ___offset3, int32_t ___width4, int32_t ___height5, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		// float xCoord = (x + offset) / width * scale;
		int32_t L_0 = ___x0;
		float L_1 = ___offset3;
		int32_t L_2 = ___width4;
		float L_3 = ___scale2;
		// float yCoord = (y + offset) / height * scale;
		int32_t L_4 = ___y1;
		float L_5 = ___offset3;
		int32_t L_6 = ___height5;
		float L_7 = ___scale2;
		V_0 = ((float)il2cpp_codegen_multiply((float)((float)((float)((float)il2cpp_codegen_add((float)((float)((float)L_4)), (float)L_5))/(float)((float)((float)L_6)))), (float)L_7));
		// float perlin = Mathf.PerlinNoise(xCoord, yCoord);
		float L_8 = V_0;
		float L_9;
		L_9 = Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519(((float)il2cpp_codegen_multiply((float)((float)((float)((float)il2cpp_codegen_add((float)((float)((float)L_0)), (float)L_1))/(float)((float)((float)L_2)))), (float)L_3)), L_8, /*hidden argument*/NULL);
		// return new Color(perlin, perlin, perlin, 1);
		float L_10 = L_9;
		float L_11 = L_10;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_12;
		memset((&L_12), 0, sizeof(L_12));
		Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5((&L_12), L_10, L_11, L_11, (1.0f), /*hidden argument*/NULL);
		return L_12;
	}
}
// UnityEngine.Color AllIn1VfxToolkit.AllIn1VfxNoiseCreator::PerlinBorderless(System.Int32,System.Int32,System.Single,System.Single,System.Int32,System.Int32,UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  AllIn1VfxNoiseCreator_PerlinBorderless_m1D51AB4CA3E41D16520E0CBCA9EF6572B79C2945 (int32_t ___x0, int32_t ___y1, float ___scale2, float ___offset3, int32_t ___width4, int32_t ___height5, Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * ___previousPerlin6, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	float V_4 = 0.0f;
	float V_5 = 0.0f;
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  V_6;
	memset((&V_6), 0, sizeof(V_6));
	float V_7 = 0.0f;
	{
		// int iniX = x;
		int32_t L_0 = ___x0;
		V_0 = L_0;
		// int iniY = y;
		int32_t L_1 = ___y1;
		V_1 = L_1;
		// float u = (float)x / width;
		int32_t L_2 = ___x0;
		int32_t L_3 = ___width4;
		V_2 = ((float)((float)((float)((float)L_2))/(float)((float)((float)L_3))));
		// float v = (float)y / height;
		int32_t L_4 = ___y1;
		int32_t L_5 = ___height5;
		V_3 = ((float)((float)((float)((float)L_4))/(float)((float)((float)L_5))));
		// if(u > 0.5f) x = width - x;
		float L_6 = V_2;
		if ((!(((float)L_6) > ((float)(0.5f)))))
		{
			goto IL_0020;
		}
	}
	{
		// if(u > 0.5f) x = width - x;
		int32_t L_7 = ___width4;
		int32_t L_8 = ___x0;
		___x0 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_7, (int32_t)L_8));
	}

IL_0020:
	{
		// if(v > 0.5f) y = height - y;
		float L_9 = V_3;
		if ((!(((float)L_9) > ((float)(0.5f)))))
		{
			goto IL_002e;
		}
	}
	{
		// if(v > 0.5f) y = height - y;
		int32_t L_10 = ___height5;
		int32_t L_11 = ___y1;
		___y1 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_10, (int32_t)L_11));
	}

IL_002e:
	{
		// offset += 23.43f;
		float L_12 = ___offset3;
		___offset3 = ((float)il2cpp_codegen_add((float)L_12, (float)(23.4300003f)));
		// float xCoord = (x + offset) / width * scale;
		int32_t L_13 = ___x0;
		float L_14 = ___offset3;
		int32_t L_15 = ___width4;
		float L_16 = ___scale2;
		// float yCoord = (y + offset) / height * scale;
		int32_t L_17 = ___y1;
		float L_18 = ___offset3;
		int32_t L_19 = ___height5;
		float L_20 = ___scale2;
		V_4 = ((float)il2cpp_codegen_multiply((float)((float)((float)((float)il2cpp_codegen_add((float)((float)((float)L_17)), (float)L_18))/(float)((float)((float)L_19)))), (float)L_20));
		// float perlin = Mathf.PerlinNoise(xCoord, yCoord);
		float L_21 = V_4;
		float L_22;
		L_22 = Mathf_PerlinNoise_mBCF172821FEB8FAD7E7CF7F7982018846E702519(((float)il2cpp_codegen_multiply((float)((float)((float)((float)il2cpp_codegen_add((float)((float)((float)L_13)), (float)L_14))/(float)((float)((float)L_15)))), (float)L_16)), L_21, /*hidden argument*/NULL);
		V_5 = L_22;
		// Color newPerlin = new Color(perlin, perlin, perlin, 1);
		float L_23 = V_5;
		float L_24 = V_5;
		float L_25 = V_5;
		Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5((Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)(&V_6), L_23, L_24, L_25, (1.0f), /*hidden argument*/NULL);
		// float edge = Mathf.Max(u, v);
		float L_26 = V_2;
		float L_27 = V_3;
		float L_28;
		L_28 = Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775(L_26, L_27, /*hidden argument*/NULL);
		V_7 = L_28;
		// edge = Mathf.Max(edge, Mathf.Max(1f - u, 1f - v));
		float L_29 = V_7;
		float L_30 = V_2;
		float L_31 = V_3;
		float L_32;
		L_32 = Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775(((float)il2cpp_codegen_subtract((float)(1.0f), (float)L_30)), ((float)il2cpp_codegen_subtract((float)(1.0f), (float)L_31)), /*hidden argument*/NULL);
		float L_33;
		L_33 = Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775(L_29, L_32, /*hidden argument*/NULL);
		V_7 = L_33;
		// edge = Mathf.Pow(edge, 10f);
		float L_34 = V_7;
		float L_35;
		L_35 = powf(L_34, (10.0f));
		V_7 = L_35;
		// return Color.Lerp(previousPerlin.GetPixel(iniX, iniY), newPerlin, edge);
		Texture2D_t9B604D0D8E28032123641A7E7338FA872E2698BF * L_36 = ___previousPerlin6;
		int32_t L_37 = V_0;
		int32_t L_38 = V_1;
		NullCheck(L_36);
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_39;
		L_39 = Texture2D_GetPixel_m50474A401DE4CB3B567F1695546DF1D2C610A022(L_36, L_37, L_38, /*hidden argument*/NULL);
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_40 = V_6;
		float L_41 = V_7;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_42;
		L_42 = Color_Lerp_mC986D7F29103536908D76BD8FC59AA11DC33C197(L_39, L_40, L_41, /*hidden argument*/NULL);
		return L_42;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderProperty_Start_m673ADDCF51887322CC41A36B2F6B1D76ED83A3CD (AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2043A81282FBC38D068F48CE6B02508288E7F859);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA7A626DEA2521BA48EA03C7C5828601203370D81);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEAE96BC7C4AF88268A19A75CCE8F01ABB5A77AB1);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(mat == null) mat = GetComponent<Renderer>().material;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_0 = __this->get_mat_14();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0021;
		}
	}
	{
		// if(mat == null) mat = GetComponent<Renderer>().material;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_2;
		L_2 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		NullCheck(L_2);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_3;
		L_3 = Renderer_get_material_mE6B01125502D08EE0D6DFE2EAEC064AD9BB31804(L_2, /*hidden argument*/NULL);
		__this->set_mat_14(L_3);
		goto IL_0039;
	}

IL_0021:
	{
		// originalMat = new Material(mat);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_4 = __this->get_mat_14();
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_5 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD0C3D9CFAFE0FB858D864092467387D7FA178245(L_5, L_4, /*hidden argument*/NULL);
		__this->set_originalMat_15(L_5);
		// restoreMaterialOnDisable = true;
		__this->set_restoreMaterialOnDisable_16((bool)1);
	}

IL_0039:
	{
		// if (mat == null) DestroyComponentAndLogError(gameObject.name + " has no valid Material, deleting AllIn1VfxScrollShaderProperty component");
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_6 = __this->get_mat_14();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_6, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0063;
		}
	}
	{
		// if (mat == null) DestroyComponentAndLogError(gameObject.name + " has no valid Material, deleting AllIn1VfxScrollShaderProperty component");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_8;
		L_8 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_8);
		String_t* L_9;
		L_9 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_8, /*hidden argument*/NULL);
		String_t* L_10;
		L_10 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_9, _stringLiteralEAE96BC7C4AF88268A19A75CCE8F01ABB5A77AB1, /*hidden argument*/NULL);
		AllIn1VfxScrollShaderProperty_DestroyComponentAndLogError_m231A4CA6AA3EBEA08563EB49E17D6837CEFB1D6C(__this, L_10, /*hidden argument*/NULL);
		return;
	}

IL_0063:
	{
		// if (mat.HasProperty(numericPropertyName)) propertyShaderID = Shader.PropertyToID(numericPropertyName);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_11 = __this->get_mat_14();
		String_t* L_12 = __this->get_numericPropertyName_4();
		NullCheck(L_11);
		bool L_13;
		L_13 = Material_HasProperty_mB6F155CD45C688DA232B56BD1A74474C224BE37E(L_11, L_12, /*hidden argument*/NULL);
		if (!L_13)
		{
			goto IL_0089;
		}
	}
	{
		// if (mat.HasProperty(numericPropertyName)) propertyShaderID = Shader.PropertyToID(numericPropertyName);
		String_t* L_14 = __this->get_numericPropertyName_4();
		int32_t L_15;
		L_15 = Shader_PropertyToID_m8C1BEBBAC0CC3015B142AF0FA856495D5D239F5F(L_14, /*hidden argument*/NULL);
		__this->set_propertyShaderID_17(L_15);
		goto IL_00af;
	}

IL_0089:
	{
		// else DestroyComponentAndLogError(gameObject.name + "'s Material doesn't have a " + numericPropertyName + " property");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_16;
		L_16 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_16);
		String_t* L_17;
		L_17 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_16, /*hidden argument*/NULL);
		String_t* L_18 = __this->get_numericPropertyName_4();
		String_t* L_19;
		L_19 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_17, _stringLiteralA7A626DEA2521BA48EA03C7C5828601203370D81, L_18, _stringLiteral2043A81282FBC38D068F48CE6B02508288E7F859, /*hidden argument*/NULL);
		AllIn1VfxScrollShaderProperty_DestroyComponentAndLogError_m231A4CA6AA3EBEA08563EB49E17D6837CEFB1D6C(__this, L_19, /*hidden argument*/NULL);
	}

IL_00af:
	{
		// currValue = mat.GetFloat(propertyShaderID);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_20 = __this->get_mat_14();
		int32_t L_21 = __this->get_propertyShaderID_17();
		NullCheck(L_20);
		float L_22;
		L_22 = Material_GetFloat_m508B992651DD512ECB2A51336C9A4E87AED82D27(L_20, L_21, /*hidden argument*/NULL);
		__this->set_currValue_18(L_22);
		// if(backAndForth || stopAtValue)
		bool L_23 = __this->get_backAndForth_6();
		if (L_23)
		{
			goto IL_00d6;
		}
	}
	{
		bool L_24 = __this->get_stopAtValue_12();
		if (!L_24)
		{
			goto IL_0144;
		}
	}

IL_00d6:
	{
		// iniValue = currValue;
		float L_25 = __this->get_currValue_18();
		__this->set_iniValue_8(L_25);
		// goingUp = iniValue < maxValue;
		float L_26 = __this->get_iniValue_8();
		float L_27 = __this->get_maxValue_7();
		__this->set_goingUp_9((bool)((((float)L_26) < ((float)L_27))? 1 : 0));
		// if(!goingUp && scrollSpeed > 0) scrollSpeed *= -1f;
		bool L_28 = __this->get_goingUp_9();
		if (L_28)
		{
			goto IL_011d;
		}
	}
	{
		float L_29 = __this->get_scrollSpeed_5();
		if ((!(((float)L_29) > ((float)(0.0f)))))
		{
			goto IL_011d;
		}
	}
	{
		// if(!goingUp && scrollSpeed > 0) scrollSpeed *= -1f;
		float L_30 = __this->get_scrollSpeed_5();
		__this->set_scrollSpeed_5(((float)il2cpp_codegen_multiply((float)L_30, (float)(-1.0f))));
	}

IL_011d:
	{
		// if(goingUp && scrollSpeed < 0) scrollSpeed *= -1f;
		bool L_31 = __this->get_goingUp_9();
		if (!L_31)
		{
			goto IL_0144;
		}
	}
	{
		float L_32 = __this->get_scrollSpeed_5();
		if ((!(((float)L_32) < ((float)(0.0f)))))
		{
			goto IL_0144;
		}
	}
	{
		// if(goingUp && scrollSpeed < 0) scrollSpeed *= -1f;
		float L_33 = __this->get_scrollSpeed_5();
		__this->set_scrollSpeed_5(((float)il2cpp_codegen_multiply((float)L_33, (float)(-1.0f))));
	}

IL_0144:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderProperty_Update_mB7B481A8F254D070B8A55DB80629A9F68B90608F (AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral68CB89848359D7BCEA0995C8FB01DAA1D5DFDE28);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF5D8EF422ABD0284BA3EEB3BF58FBA9313575F4E);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(mat == null)
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_0 = __this->get_mat_14();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_003d;
		}
	}
	{
		// if(isValid)
		bool L_2 = __this->get_isValid_19();
		if (!L_2)
		{
			goto IL_003c;
		}
	}
	{
		// Debug.LogError("The object " + gameObject.name + " has no Material and you are trying to access it. Please take a look");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_3;
		L_3 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		String_t* L_4;
		L_4 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_3, /*hidden argument*/NULL);
		String_t* L_5;
		L_5 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(_stringLiteralF5D8EF422ABD0284BA3EEB3BF58FBA9313575F4E, L_4, _stringLiteral68CB89848359D7BCEA0995C8FB01DAA1D5DFDE28, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_5, /*hidden argument*/NULL);
		// isValid = false;
		__this->set_isValid_19((bool)0);
	}

IL_003c:
	{
		// return;
		return;
	}

IL_003d:
	{
		// currValue += scrollSpeed * Time.deltaTime;
		float L_6 = __this->get_currValue_18();
		float L_7 = __this->get_scrollSpeed_5();
		float L_8;
		L_8 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		__this->set_currValue_18(((float)il2cpp_codegen_add((float)L_6, (float)((float)il2cpp_codegen_multiply((float)L_7, (float)L_8)))));
		// if(backAndForth)
		bool L_9 = __this->get_backAndForth_6();
		if (!L_9)
		{
			goto IL_0098;
		}
	}
	{
		// if(goingUp && currValue >= maxValue) FlipGoingUp();
		bool L_10 = __this->get_goingUp_9();
		if (!L_10)
		{
			goto IL_007c;
		}
	}
	{
		float L_11 = __this->get_currValue_18();
		float L_12 = __this->get_maxValue_7();
		if ((!(((float)L_11) >= ((float)L_12))))
		{
			goto IL_007c;
		}
	}
	{
		// if(goingUp && currValue >= maxValue) FlipGoingUp();
		AllIn1VfxScrollShaderProperty_FlipGoingUp_m1944D5CE97AD4D3A046FE80A4E8ABFA9AE8E5C20(__this, /*hidden argument*/NULL);
		goto IL_0098;
	}

IL_007c:
	{
		// else if(!goingUp && currValue <= iniValue) FlipGoingUp();
		bool L_13 = __this->get_goingUp_9();
		if (L_13)
		{
			goto IL_0098;
		}
	}
	{
		float L_14 = __this->get_currValue_18();
		float L_15 = __this->get_iniValue_8();
		if ((!(((float)L_14) <= ((float)L_15))))
		{
			goto IL_0098;
		}
	}
	{
		// else if(!goingUp && currValue <= iniValue) FlipGoingUp();
		AllIn1VfxScrollShaderProperty_FlipGoingUp_m1944D5CE97AD4D3A046FE80A4E8ABFA9AE8E5C20(__this, /*hidden argument*/NULL);
	}

IL_0098:
	{
		// if (applyModulo) currValue %= modulo;
		bool L_16 = __this->get_applyModulo_10();
		if (!L_16)
		{
			goto IL_00b3;
		}
	}
	{
		// if (applyModulo) currValue %= modulo;
		float L_17 = __this->get_currValue_18();
		float L_18 = __this->get_modulo_11();
		__this->set_currValue_18((fmodf(L_17, L_18)));
	}

IL_00b3:
	{
		// if(stopAtValue)
		bool L_19 = __this->get_stopAtValue_12();
		if (!L_19)
		{
			goto IL_00ff;
		}
	}
	{
		// if(goingUp && currValue >= stopValue) scrollSpeed = 0f;
		bool L_20 = __this->get_goingUp_9();
		if (!L_20)
		{
			goto IL_00de;
		}
	}
	{
		float L_21 = __this->get_currValue_18();
		float L_22 = __this->get_stopValue_13();
		if ((!(((float)L_21) >= ((float)L_22))))
		{
			goto IL_00de;
		}
	}
	{
		// if(goingUp && currValue >= stopValue) scrollSpeed = 0f;
		__this->set_scrollSpeed_5((0.0f));
		goto IL_00ff;
	}

IL_00de:
	{
		// else if(!goingUp && currValue <= stopValue) scrollSpeed = 0f;
		bool L_23 = __this->get_goingUp_9();
		if (L_23)
		{
			goto IL_00ff;
		}
	}
	{
		float L_24 = __this->get_currValue_18();
		float L_25 = __this->get_stopValue_13();
		if ((!(((float)L_24) <= ((float)L_25))))
		{
			goto IL_00ff;
		}
	}
	{
		// else if(!goingUp && currValue <= stopValue) scrollSpeed = 0f;
		__this->set_scrollSpeed_5((0.0f));
	}

IL_00ff:
	{
		// mat.SetFloat(propertyShaderID, currValue);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_26 = __this->get_mat_14();
		int32_t L_27 = __this->get_propertyShaderID_17();
		float L_28 = __this->get_currValue_18();
		NullCheck(L_26);
		Material_SetFloat_mAC7DC962B356565CF6743E358C7A19D0322EA060(L_26, L_27, L_28, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::FlipGoingUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderProperty_FlipGoingUp_m1944D5CE97AD4D3A046FE80A4E8ABFA9AE8E5C20 (AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D * __this, const RuntimeMethod* method)
{
	{
		// goingUp = !goingUp;
		bool L_0 = __this->get_goingUp_9();
		__this->set_goingUp_9((bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0));
		// scrollSpeed *= -1f;
		float L_1 = __this->get_scrollSpeed_5();
		__this->set_scrollSpeed_5(((float)il2cpp_codegen_multiply((float)L_1, (float)(-1.0f))));
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::DestroyComponentAndLogError(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderProperty_DestroyComponentAndLogError_m231A4CA6AA3EBEA08563EB49E17D6837CEFB1D6C (AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D * __this, String_t* ___logError0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Debug.LogError(logError);
		String_t* L_0 = ___logError0;
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_0, /*hidden argument*/NULL);
		// Destroy(this);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::OnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderProperty_OnDisable_mB8DF26429864457C49976D97528941ABA9524B2F (AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D * __this, const RuntimeMethod* method)
{
	{
		// if(restoreMaterialOnDisable) mat.CopyPropertiesFromMaterial(originalMat);
		bool L_0 = __this->get_restoreMaterialOnDisable_16();
		if (!L_0)
		{
			goto IL_0019;
		}
	}
	{
		// if(restoreMaterialOnDisable) mat.CopyPropertiesFromMaterial(originalMat);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_1 = __this->get_mat_14();
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_2 = __this->get_originalMat_15();
		NullCheck(L_1);
		Material_CopyPropertiesFromMaterial_m5A6DE308328EAB762EF5BE3253B728C8078773CF(L_1, L_2, /*hidden argument*/NULL);
	}

IL_0019:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderProperty::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderProperty__ctor_mEBCECDEBB17463B4726ACBD2733901D04D5B0CE4 (AllIn1VfxScrollShaderProperty_t22A824277AB036AE9D6C308958E24C17EF36990D * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD53DF615DBAF7AA486744EFFCF7D2AB271BC7058);
		s_Il2CppMethodInitialized = true;
	}
	{
		// [SerializeField] private string numericPropertyName = "_HsvShift";
		__this->set_numericPropertyName_4(_stringLiteralD53DF615DBAF7AA486744EFFCF7D2AB271BC7058);
		// [SerializeField] private float maxValue = 1f;
		__this->set_maxValue_7((1.0f));
		// [SerializeField] private float modulo = 360f;
		__this->set_modulo_11((360.0f));
		// private bool isValid = true;
		__this->set_isValid_19((bool)1);
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderTexture_Start_mDB473D98699D0A9F3B0C097D126FA1FB6350FD81 (AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1647B084BF73860206F4BB01E3237ED88F61B4BA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral46AFF93E738AD334DF787721BD7F7D0089E5D7AC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA7A626DEA2521BA48EA03C7C5828601203370D81);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(mat == null) mat = GetComponent<Renderer>().material;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_0 = __this->get_mat_16();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0021;
		}
	}
	{
		// if(mat == null) mat = GetComponent<Renderer>().material;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_2;
		L_2 = Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019(__this, /*hidden argument*/Component_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_m436E5B0F17DDEF3CC61F77DEA82B1A92668AF019_RuntimeMethod_var);
		NullCheck(L_2);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_3;
		L_3 = Renderer_get_material_mE6B01125502D08EE0D6DFE2EAEC064AD9BB31804(L_2, /*hidden argument*/NULL);
		__this->set_mat_16(L_3);
		goto IL_0039;
	}

IL_0021:
	{
		// originalMat = new Material(mat);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_4 = __this->get_mat_16();
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_5 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD0C3D9CFAFE0FB858D864092467387D7FA178245(L_5, L_4, /*hidden argument*/NULL);
		__this->set_originalMat_17(L_5);
		// restoreMaterialOnDisable = true;
		__this->set_restoreMaterialOnDisable_18((bool)1);
	}

IL_0039:
	{
		// if (mat == null) DestroyComponentAndLogError(gameObject.name + " has no valid Material, deleting AllIn1VfxScrollShaderTexture component");
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_6 = __this->get_mat_16();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_6, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0063;
		}
	}
	{
		// if (mat == null) DestroyComponentAndLogError(gameObject.name + " has no valid Material, deleting AllIn1VfxScrollShaderTexture component");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_8;
		L_8 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_8);
		String_t* L_9;
		L_9 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_8, /*hidden argument*/NULL);
		String_t* L_10;
		L_10 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_9, _stringLiteral1647B084BF73860206F4BB01E3237ED88F61B4BA, /*hidden argument*/NULL);
		AllIn1VfxScrollShaderTexture_DestroyComponentAndLogError_mD828DDA85F26B992A873F05CE6AE4FB5C54BFD93(__this, L_10, /*hidden argument*/NULL);
		return;
	}

IL_0063:
	{
		// if (mat.HasProperty(texturePropertyName)) propertyShaderID = Shader.PropertyToID(texturePropertyName);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_11 = __this->get_mat_16();
		String_t* L_12 = __this->get_texturePropertyName_4();
		NullCheck(L_11);
		bool L_13;
		L_13 = Material_HasProperty_mB6F155CD45C688DA232B56BD1A74474C224BE37E(L_11, L_12, /*hidden argument*/NULL);
		if (!L_13)
		{
			goto IL_0089;
		}
	}
	{
		// if (mat.HasProperty(texturePropertyName)) propertyShaderID = Shader.PropertyToID(texturePropertyName);
		String_t* L_14 = __this->get_texturePropertyName_4();
		int32_t L_15;
		L_15 = Shader_PropertyToID_m8C1BEBBAC0CC3015B142AF0FA856495D5D239F5F(L_14, /*hidden argument*/NULL);
		__this->set_propertyShaderID_19(L_15);
		goto IL_00af;
	}

IL_0089:
	{
		// else DestroyComponentAndLogError(gameObject.name + "'s Material doesn't have a " + texturePropertyName + " texture property");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_16;
		L_16 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_16);
		String_t* L_17;
		L_17 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_16, /*hidden argument*/NULL);
		String_t* L_18 = __this->get_texturePropertyName_4();
		String_t* L_19;
		L_19 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_17, _stringLiteralA7A626DEA2521BA48EA03C7C5828601203370D81, L_18, _stringLiteral46AFF93E738AD334DF787721BD7F7D0089E5D7AC, /*hidden argument*/NULL);
		AllIn1VfxScrollShaderTexture_DestroyComponentAndLogError_mD828DDA85F26B992A873F05CE6AE4FB5C54BFD93(__this, L_19, /*hidden argument*/NULL);
	}

IL_00af:
	{
		// if(textureOffset) currValue = mat.GetTextureOffset(texturePropertyName);
		bool L_20 = __this->get_textureOffset_6();
		if (!L_20)
		{
			goto IL_00d0;
		}
	}
	{
		// if(textureOffset) currValue = mat.GetTextureOffset(texturePropertyName);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_21 = __this->get_mat_16();
		String_t* L_22 = __this->get_texturePropertyName_4();
		NullCheck(L_21);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_23;
		L_23 = Material_GetTextureOffset_m47FBA39C48B10DEAF3431284315C558BF642A2C6(L_21, L_22, /*hidden argument*/NULL);
		__this->set_currValue_20(L_23);
		goto IL_00e7;
	}

IL_00d0:
	{
		// else currValue = mat.GetTextureScale(texturePropertyName);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_24 = __this->get_mat_16();
		String_t* L_25 = __this->get_texturePropertyName_4();
		NullCheck(L_24);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_26;
		L_26 = Material_GetTextureScale_mEE8950B66B5B60BDB92D41A6902E41AA1EDDEBE7(L_24, L_25, /*hidden argument*/NULL);
		__this->set_currValue_20(L_26);
	}

IL_00e7:
	{
		// if(backAndForth || stopAtValue)
		bool L_27 = __this->get_backAndForth_7();
		if (L_27)
		{
			goto IL_00fa;
		}
	}
	{
		bool L_28 = __this->get_stopAtValue_14();
		if (!L_28)
		{
			goto IL_0202;
		}
	}

IL_00fa:
	{
		// iniValue = currValue;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_29 = __this->get_currValue_20();
		__this->set_iniValue_9(L_29);
		// goingUpX = iniValue.x < maxValue.x;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_30 = __this->get_address_of_iniValue_9();
		float L_31 = L_30->get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_32 = __this->get_address_of_maxValue_8();
		float L_33 = L_32->get_x_0();
		__this->set_goingUpX_10((bool)((((float)L_31) < ((float)L_33))? 1 : 0));
		// if(!goingUpX && scrollSpeed.x > 0) scrollSpeed *= -1f;
		bool L_34 = __this->get_goingUpX_10();
		if (L_34)
		{
			goto IL_0154;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_35 = __this->get_address_of_scrollSpeed_5();
		float L_36 = L_35->get_x_0();
		if ((!(((float)L_36) > ((float)(0.0f)))))
		{
			goto IL_0154;
		}
	}
	{
		// if(!goingUpX && scrollSpeed.x > 0) scrollSpeed *= -1f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_37 = __this->get_scrollSpeed_5();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_38;
		L_38 = Vector2_op_Multiply_mC7A7802352867555020A90205EBABA56EE5E36CB_inline(L_37, (-1.0f), /*hidden argument*/NULL);
		__this->set_scrollSpeed_5(L_38);
	}

IL_0154:
	{
		// if(goingUpX && scrollSpeed.x < 0) scrollSpeed *= -1f;
		bool L_39 = __this->get_goingUpX_10();
		if (!L_39)
		{
			goto IL_0184;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_40 = __this->get_address_of_scrollSpeed_5();
		float L_41 = L_40->get_x_0();
		if ((!(((float)L_41) < ((float)(0.0f)))))
		{
			goto IL_0184;
		}
	}
	{
		// if(goingUpX && scrollSpeed.x < 0) scrollSpeed *= -1f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_42 = __this->get_scrollSpeed_5();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_43;
		L_43 = Vector2_op_Multiply_mC7A7802352867555020A90205EBABA56EE5E36CB_inline(L_42, (-1.0f), /*hidden argument*/NULL);
		__this->set_scrollSpeed_5(L_43);
	}

IL_0184:
	{
		// goingUpY = iniValue.y < maxValue.y;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_44 = __this->get_address_of_iniValue_9();
		float L_45 = L_44->get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_46 = __this->get_address_of_maxValue_8();
		float L_47 = L_46->get_y_1();
		__this->set_goingUpY_11((bool)((((float)L_45) < ((float)L_47))? 1 : 0));
		// if(!goingUpY && scrollSpeed.y > 0) scrollSpeed *= -1f;
		bool L_48 = __this->get_goingUpY_11();
		if (L_48)
		{
			goto IL_01d2;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_49 = __this->get_address_of_scrollSpeed_5();
		float L_50 = L_49->get_y_1();
		if ((!(((float)L_50) > ((float)(0.0f)))))
		{
			goto IL_01d2;
		}
	}
	{
		// if(!goingUpY && scrollSpeed.y > 0) scrollSpeed *= -1f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_51 = __this->get_scrollSpeed_5();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_52;
		L_52 = Vector2_op_Multiply_mC7A7802352867555020A90205EBABA56EE5E36CB_inline(L_51, (-1.0f), /*hidden argument*/NULL);
		__this->set_scrollSpeed_5(L_52);
	}

IL_01d2:
	{
		// if(goingUpY && scrollSpeed.y < 0) scrollSpeed *= -1f;
		bool L_53 = __this->get_goingUpY_11();
		if (!L_53)
		{
			goto IL_0202;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_54 = __this->get_address_of_scrollSpeed_5();
		float L_55 = L_54->get_y_1();
		if ((!(((float)L_55) < ((float)(0.0f)))))
		{
			goto IL_0202;
		}
	}
	{
		// if(goingUpY && scrollSpeed.y < 0) scrollSpeed *= -1f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_56 = __this->get_scrollSpeed_5();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_57;
		L_57 = Vector2_op_Multiply_mC7A7802352867555020A90205EBABA56EE5E36CB_inline(L_56, (-1.0f), /*hidden argument*/NULL);
		__this->set_scrollSpeed_5(L_57);
	}

IL_0202:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderTexture_Update_m6B09D5D1BC37B5DD4DD75E28AEECED9DF33F83C2 (AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral68CB89848359D7BCEA0995C8FB01DAA1D5DFDE28);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF5D8EF422ABD0284BA3EEB3BF58FBA9313575F4E);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(mat == null)
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_0 = __this->get_mat_16();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_003d;
		}
	}
	{
		// if(isValid)
		bool L_2 = __this->get_isValid_21();
		if (!L_2)
		{
			goto IL_003c;
		}
	}
	{
		// Debug.LogError("The object " + gameObject.name + " has no Material and you are trying to access it. Please take a look");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_3;
		L_3 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		String_t* L_4;
		L_4 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_3, /*hidden argument*/NULL);
		String_t* L_5;
		L_5 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(_stringLiteralF5D8EF422ABD0284BA3EEB3BF58FBA9313575F4E, L_4, _stringLiteral68CB89848359D7BCEA0995C8FB01DAA1D5DFDE28, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_5, /*hidden argument*/NULL);
		// isValid = false;
		__this->set_isValid_21((bool)0);
	}

IL_003c:
	{
		// return;
		return;
	}

IL_003d:
	{
		// currValue += scrollSpeed * Time.deltaTime;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_6 = __this->get_currValue_20();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_7 = __this->get_scrollSpeed_5();
		float L_8;
		L_8 = Time_get_deltaTime_mCC15F147DA67F38C74CE408FB5D7FF4A87DA2290(/*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_9;
		L_9 = Vector2_op_Multiply_mC7A7802352867555020A90205EBABA56EE5E36CB_inline(L_7, L_8, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_10;
		L_10 = Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline(L_6, L_9, /*hidden argument*/NULL);
		__this->set_currValue_20(L_10);
		// if(backAndForth)
		bool L_11 = __this->get_backAndForth_7();
		if (!L_11)
		{
			goto IL_0109;
		}
	}
	{
		// if(goingUpX && currValue.x >= maxValue.x) FlipGoingUp(true);
		bool L_12 = __this->get_goingUpX_10();
		if (!L_12)
		{
			goto IL_0092;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_13 = __this->get_address_of_currValue_20();
		float L_14 = L_13->get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_15 = __this->get_address_of_maxValue_8();
		float L_16 = L_15->get_x_0();
		if ((!(((float)L_14) >= ((float)L_16))))
		{
			goto IL_0092;
		}
	}
	{
		// if(goingUpX && currValue.x >= maxValue.x) FlipGoingUp(true);
		AllIn1VfxScrollShaderTexture_FlipGoingUp_m5266F3FB872E3720455F0B2FD8BC1ACAD60FD749(__this, (bool)1, /*hidden argument*/NULL);
		goto IL_00b9;
	}

IL_0092:
	{
		// else if(!goingUpX && currValue.x <= iniValue.x) FlipGoingUp(true);
		bool L_17 = __this->get_goingUpX_10();
		if (L_17)
		{
			goto IL_00b9;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_18 = __this->get_address_of_currValue_20();
		float L_19 = L_18->get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_20 = __this->get_address_of_iniValue_9();
		float L_21 = L_20->get_x_0();
		if ((!(((float)L_19) <= ((float)L_21))))
		{
			goto IL_00b9;
		}
	}
	{
		// else if(!goingUpX && currValue.x <= iniValue.x) FlipGoingUp(true);
		AllIn1VfxScrollShaderTexture_FlipGoingUp_m5266F3FB872E3720455F0B2FD8BC1ACAD60FD749(__this, (bool)1, /*hidden argument*/NULL);
	}

IL_00b9:
	{
		// if(goingUpY && currValue.y >= maxValue.y) FlipGoingUp(false);
		bool L_22 = __this->get_goingUpY_11();
		if (!L_22)
		{
			goto IL_00e2;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_23 = __this->get_address_of_currValue_20();
		float L_24 = L_23->get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_25 = __this->get_address_of_maxValue_8();
		float L_26 = L_25->get_y_1();
		if ((!(((float)L_24) >= ((float)L_26))))
		{
			goto IL_00e2;
		}
	}
	{
		// if(goingUpY && currValue.y >= maxValue.y) FlipGoingUp(false);
		AllIn1VfxScrollShaderTexture_FlipGoingUp_m5266F3FB872E3720455F0B2FD8BC1ACAD60FD749(__this, (bool)0, /*hidden argument*/NULL);
		goto IL_0109;
	}

IL_00e2:
	{
		// else if(!goingUpY && currValue.y <= iniValue.y) FlipGoingUp(false);
		bool L_27 = __this->get_goingUpY_11();
		if (L_27)
		{
			goto IL_0109;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_28 = __this->get_address_of_currValue_20();
		float L_29 = L_28->get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_30 = __this->get_address_of_iniValue_9();
		float L_31 = L_30->get_y_1();
		if ((!(((float)L_29) <= ((float)L_31))))
		{
			goto IL_0109;
		}
	}
	{
		// else if(!goingUpY && currValue.y <= iniValue.y) FlipGoingUp(false);
		AllIn1VfxScrollShaderTexture_FlipGoingUp_m5266F3FB872E3720455F0B2FD8BC1ACAD60FD749(__this, (bool)0, /*hidden argument*/NULL);
	}

IL_0109:
	{
		// if(applyModulo)
		bool L_32 = __this->get_applyModulo_12();
		if (!L_32)
		{
			goto IL_0145;
		}
	}
	{
		// currValue.x %= modulo.x;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_33 = __this->get_address_of_currValue_20();
		float* L_34 = L_33->get_address_of_x_0();
		float* L_35 = L_34;
		float L_36 = *((float*)L_35);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_37 = __this->get_address_of_modulo_13();
		float L_38 = L_37->get_x_0();
		*((float*)L_35) = (float)(fmodf(L_36, L_38));
		// currValue.y %= modulo.y;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_39 = __this->get_address_of_currValue_20();
		float* L_40 = L_39->get_address_of_y_1();
		float* L_41 = L_40;
		float L_42 = *((float*)L_41);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_43 = __this->get_address_of_modulo_13();
		float L_44 = L_43->get_y_1();
		*((float*)L_41) = (float)(fmodf(L_42, L_44));
	}

IL_0145:
	{
		// if(stopAtValue)
		bool L_45 = __this->get_stopAtValue_14();
		if (!L_45)
		{
			goto IL_0214;
		}
	}
	{
		// if(goingUpX && currValue.x >= stopValue.x) scrollSpeed.x = 0f;
		bool L_46 = __this->get_goingUpX_10();
		if (!L_46)
		{
			goto IL_0182;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_47 = __this->get_address_of_currValue_20();
		float L_48 = L_47->get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_49 = __this->get_address_of_stopValue_15();
		float L_50 = L_49->get_x_0();
		if ((!(((float)L_48) >= ((float)L_50))))
		{
			goto IL_0182;
		}
	}
	{
		// if(goingUpX && currValue.x >= stopValue.x) scrollSpeed.x = 0f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_51 = __this->get_address_of_scrollSpeed_5();
		L_51->set_x_0((0.0f));
		goto IL_01b2;
	}

IL_0182:
	{
		// else if(!goingUpX && currValue.x <= stopValue.x) scrollSpeed.x = 0f;
		bool L_52 = __this->get_goingUpX_10();
		if (L_52)
		{
			goto IL_01b2;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_53 = __this->get_address_of_currValue_20();
		float L_54 = L_53->get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_55 = __this->get_address_of_stopValue_15();
		float L_56 = L_55->get_x_0();
		if ((!(((float)L_54) <= ((float)L_56))))
		{
			goto IL_01b2;
		}
	}
	{
		// else if(!goingUpX && currValue.x <= stopValue.x) scrollSpeed.x = 0f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_57 = __this->get_address_of_scrollSpeed_5();
		L_57->set_x_0((0.0f));
	}

IL_01b2:
	{
		// if(goingUpY && currValue.y >= stopValue.y) scrollSpeed.y = 0f;
		bool L_58 = __this->get_goingUpY_11();
		if (!L_58)
		{
			goto IL_01e4;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_59 = __this->get_address_of_currValue_20();
		float L_60 = L_59->get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_61 = __this->get_address_of_stopValue_15();
		float L_62 = L_61->get_y_1();
		if ((!(((float)L_60) >= ((float)L_62))))
		{
			goto IL_01e4;
		}
	}
	{
		// if(goingUpY && currValue.y >= stopValue.y) scrollSpeed.y = 0f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_63 = __this->get_address_of_scrollSpeed_5();
		L_63->set_y_1((0.0f));
		goto IL_0214;
	}

IL_01e4:
	{
		// else if(!goingUpY && currValue.y <= stopValue.y) scrollSpeed.y = 0f;
		bool L_64 = __this->get_goingUpY_11();
		if (L_64)
		{
			goto IL_0214;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_65 = __this->get_address_of_currValue_20();
		float L_66 = L_65->get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_67 = __this->get_address_of_stopValue_15();
		float L_68 = L_67->get_y_1();
		if ((!(((float)L_66) <= ((float)L_68))))
		{
			goto IL_0214;
		}
	}
	{
		// else if(!goingUpY && currValue.y <= stopValue.y) scrollSpeed.y = 0f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_69 = __this->get_address_of_scrollSpeed_5();
		L_69->set_y_1((0.0f));
	}

IL_0214:
	{
		// if(textureOffset) mat.SetTextureOffset(propertyShaderID, currValue);
		bool L_70 = __this->get_textureOffset_6();
		if (!L_70)
		{
			goto IL_0234;
		}
	}
	{
		// if(textureOffset) mat.SetTextureOffset(propertyShaderID, currValue);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_71 = __this->get_mat_16();
		int32_t L_72 = __this->get_propertyShaderID_19();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_73 = __this->get_currValue_20();
		NullCheck(L_71);
		Material_SetTextureOffset_mDEE0C861BD2FC8D38924087590BE8FD123195A78(L_71, L_72, L_73, /*hidden argument*/NULL);
		return;
	}

IL_0234:
	{
		// else mat.SetTextureScale(propertyShaderID, currValue);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_74 = __this->get_mat_16();
		int32_t L_75 = __this->get_propertyShaderID_19();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_76 = __this->get_currValue_20();
		NullCheck(L_74);
		Material_SetTextureScale_m9F02CF20C15805224119E8A1AE57B1B064CB72C1(L_74, L_75, L_76, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::FlipGoingUp(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderTexture_FlipGoingUp_m5266F3FB872E3720455F0B2FD8BC1ACAD60FD749 (AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19 * __this, bool ___isXComponent0, const RuntimeMethod* method)
{
	{
		// if(isXComponent)
		bool L_0 = ___isXComponent0;
		if (!L_0)
		{
			goto IL_0027;
		}
	}
	{
		// goingUpX = !goingUpX;
		bool L_1 = __this->get_goingUpX_10();
		__this->set_goingUpX_10((bool)((((int32_t)L_1) == ((int32_t)0))? 1 : 0));
		// scrollSpeed.x *= -1f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_2 = __this->get_address_of_scrollSpeed_5();
		float* L_3 = L_2->get_address_of_x_0();
		float* L_4 = L_3;
		float L_5 = *((float*)L_4);
		*((float*)L_4) = (float)((float)il2cpp_codegen_multiply((float)L_5, (float)(-1.0f)));
		// }
		return;
	}

IL_0027:
	{
		// goingUpY = !goingUpY;
		bool L_6 = __this->get_goingUpY_11();
		__this->set_goingUpY_11((bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0));
		// scrollSpeed.y *= -1f;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_7 = __this->get_address_of_scrollSpeed_5();
		float* L_8 = L_7->get_address_of_y_1();
		float* L_9 = L_8;
		float L_10 = *((float*)L_9);
		*((float*)L_9) = (float)((float)il2cpp_codegen_multiply((float)L_10, (float)(-1.0f)));
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::DestroyComponentAndLogError(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderTexture_DestroyComponentAndLogError_mD828DDA85F26B992A873F05CE6AE4FB5C54BFD93 (AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19 * __this, String_t* ___logError0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Debug.LogError(logError);
		String_t* L_0 = ___logError0;
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_0, /*hidden argument*/NULL);
		// Destroy(this);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::OnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderTexture_OnDisable_mDBDB8E890F5A7EAB0A5F5EB4DFD8B26B84C2E79B (AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19 * __this, const RuntimeMethod* method)
{
	{
		// if(restoreMaterialOnDisable) mat.CopyPropertiesFromMaterial(originalMat);
		bool L_0 = __this->get_restoreMaterialOnDisable_18();
		if (!L_0)
		{
			goto IL_0019;
		}
	}
	{
		// if(restoreMaterialOnDisable) mat.CopyPropertiesFromMaterial(originalMat);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_1 = __this->get_mat_16();
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_2 = __this->get_originalMat_17();
		NullCheck(L_1);
		Material_CopyPropertiesFromMaterial_m5A6DE308328EAB762EF5BE3253B728C8078773CF(L_1, L_2, /*hidden argument*/NULL);
	}

IL_0019:
	{
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.AllIn1VfxScrollShaderTexture::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AllIn1VfxScrollShaderTexture__ctor_m64AC1BD5E1CA7ECC47F948A8B783FB5AA29DC6DD (AllIn1VfxScrollShaderTexture_tF85C5C716A91312A395E47961A6878AC10D09F19 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4B8146FB95E4F51B29DA41EB5F6D60F8FD0ECF21);
		s_Il2CppMethodInitialized = true;
	}
	{
		// [SerializeField] private string texturePropertyName = "_MainTex";
		__this->set_texturePropertyName_4(_stringLiteral4B8146FB95E4F51B29DA41EB5F6D60F8FD0ECF21);
		// [SerializeField] private Vector2 scrollSpeed = Vector2.zero;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0;
		L_0 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		__this->set_scrollSpeed_5(L_0);
		// private bool textureOffset = true;
		__this->set_textureOffset_6((bool)1);
		// [SerializeField] private Vector2 maxValue = Vector2.one;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1;
		L_1 = Vector2_get_one_m9B2AFD26404B6DD0F520D19FC7F79371C5C18B42(/*hidden argument*/NULL);
		__this->set_maxValue_8(L_1);
		// private Vector2 iniValue = Vector2.zero;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2;
		L_2 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		__this->set_iniValue_9(L_2);
		// [SerializeField] private Vector2 modulo = Vector2.one;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_3;
		L_3 = Vector2_get_one_m9B2AFD26404B6DD0F520D19FC7F79371C5C18B42(/*hidden argument*/NULL);
		__this->set_modulo_13(L_3);
		// [SerializeField] private Vector2 stopValue = Vector2.zero;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4;
		L_4 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		__this->set_stopValue_15(L_4);
		// private Vector2 currValue = Vector2.zero;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_5;
		L_5 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		__this->set_currValue_20(L_5);
		// private bool isValid = true;
		__this->set_isValid_21((bool)1);
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AllIn1VfxToolkit.SetAllIn1VfxCustomGlobalTime::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SetAllIn1VfxCustomGlobalTime_Start_mBA44270C109D4432821EE1CB04464C5788F117A7 (SetAllIn1VfxCustomGlobalTime_t88A8D3A9AF3C302E3FCFF781A03834E55ED18E30 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF3D5ADFD704DD9FB58F49F6670F4DAA9E634657F);
		s_Il2CppMethodInitialized = true;
	}
	{
		// globalTime = Shader.PropertyToID("globalCustomTime");
		int32_t L_0;
		L_0 = Shader_PropertyToID_m8C1BEBBAC0CC3015B142AF0FA856495D5D239F5F(_stringLiteralF3D5ADFD704DD9FB58F49F6670F4DAA9E634657F, /*hidden argument*/NULL);
		__this->set_globalTime_4(L_0);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.SetAllIn1VfxCustomGlobalTime::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SetAllIn1VfxCustomGlobalTime_Update_m2D9D1468E607C67DA5E496EEF1C9847790FC92BF (SetAllIn1VfxCustomGlobalTime_t88A8D3A9AF3C302E3FCFF781A03834E55ED18E30 * __this, const RuntimeMethod* method)
{
	{
		// timeVector.x = Time.unscaledTime / 20f;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * L_0 = __this->get_address_of_timeVector_5();
		float L_1;
		L_1 = Time_get_unscaledTime_m85A3479E3D78D05FEDEEFEF36944AC5EF9B31258(/*hidden argument*/NULL);
		L_0->set_x_1(((float)((float)L_1/(float)(20.0f))));
		// timeVector.y = Time.unscaledTime;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * L_2 = __this->get_address_of_timeVector_5();
		float L_3;
		L_3 = Time_get_unscaledTime_m85A3479E3D78D05FEDEEFEF36944AC5EF9B31258(/*hidden argument*/NULL);
		L_2->set_y_2(L_3);
		// timeVector.z = Time.unscaledTime * 2f;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * L_4 = __this->get_address_of_timeVector_5();
		float L_5;
		L_5 = Time_get_unscaledTime_m85A3479E3D78D05FEDEEFEF36944AC5EF9B31258(/*hidden argument*/NULL);
		L_4->set_z_3(((float)il2cpp_codegen_multiply((float)L_5, (float)(2.0f))));
		// timeVector.w = Time.unscaledTime * 3f;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * L_6 = __this->get_address_of_timeVector_5();
		float L_7;
		L_7 = Time_get_unscaledTime_m85A3479E3D78D05FEDEEFEF36944AC5EF9B31258(/*hidden argument*/NULL);
		L_6->set_w_4(((float)il2cpp_codegen_multiply((float)L_7, (float)(3.0f))));
		// Shader.SetGlobalVector(globalTime, timeVector);
		int32_t L_8 = __this->get_globalTime_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_9 = __this->get_timeVector_5();
		Shader_SetGlobalVector_m241FC10C437094156CA0C6CC299A3F09404CE1F3(L_8, L_9, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AllIn1VfxToolkit.SetAllIn1VfxCustomGlobalTime::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SetAllIn1VfxCustomGlobalTime__ctor_m422D0D9B39982C38F44030D6CD450850806099AA (SetAllIn1VfxCustomGlobalTime_t88A8D3A9AF3C302E3FCFF781A03834E55ED18E30 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Subtraction_m2725C96965D5C0B1F9715797E51762B13A5FED58_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___a0;
		float L_1 = L_0.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2 = ___b1;
		float L_3 = L_2.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4 = ___a0;
		float L_5 = L_4.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6 = ___b1;
		float L_7 = L_6.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_8 = ___a0;
		float L_9 = L_8.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_10 = ___b1;
		float L_11 = L_10.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_12), ((float)il2cpp_codegen_subtract((float)L_1, (float)L_3)), ((float)il2cpp_codegen_subtract((float)L_5, (float)L_7)), ((float)il2cpp_codegen_subtract((float)L_9, (float)L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_UnaryNegation_m362EA356F4CADEDB39F965A0DBDED6EA890925F7_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___a0;
		float L_1 = L_0.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2 = ___a0;
		float L_3 = L_2.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4 = ___a0;
		float L_5 = L_4.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6;
		memset((&L_6), 0, sizeof(L_6));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_6), ((-L_1)), ((-L_3)), ((-L_5)), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_001e;
	}

IL_001e:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_7 = V_0;
		return L_7;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___a0;
		float L_1 = L_0.get_x_2();
		float L_2 = ___d1;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_3 = ___a0;
		float L_4 = L_3.get_y_3();
		float L_5 = ___d1;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6 = ___a0;
		float L_7 = L_6.get_z_4();
		float L_8 = ___d1;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_9), ((float)il2cpp_codegen_multiply((float)L_1, (float)L_2)), ((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)), ((float)il2cpp_codegen_multiply((float)L_7, (float)L_8)), /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0021;
	}

IL_0021:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_10 = V_0;
		return L_10;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___a0;
		float L_1 = L_0.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2 = ___b1;
		float L_3 = L_2.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4 = ___a0;
		float L_5 = L_4.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6 = ___b1;
		float L_7 = L_6.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_8 = ___a0;
		float L_9 = L_8.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_10 = ___b1;
		float L_11 = L_10.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_12), ((float)il2cpp_codegen_add((float)L_1, (float)L_3)), ((float)il2cpp_codegen_add((float)L_5, (float)L_7)), ((float)il2cpp_codegen_add((float)L_9, (float)L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_13 = V_0;
		return L_13;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_op_Multiply_mC7A7802352867555020A90205EBABA56EE5E36CB_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0 = ___a0;
		float L_1 = L_0.get_x_0();
		float L_2 = ___d1;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_3 = ___a0;
		float L_4 = L_3.get_y_1();
		float L_5 = ___d1;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_6;
		memset((&L_6), 0, sizeof(L_6));
		Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline((&L_6), ((float)il2cpp_codegen_multiply((float)L_1, (float)L_2)), ((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_0019;
	}

IL_0019:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_7 = V_0;
		return L_7;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___a0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___b1, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0 = ___a0;
		float L_1 = L_0.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2 = ___b1;
		float L_3 = L_2.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4 = ___a0;
		float L_5 = L_4.get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_6 = ___b1;
		float L_7 = L_6.get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline((&L_8), ((float)il2cpp_codegen_add((float)L_1, (float)L_3)), ((float)il2cpp_codegen_add((float)L_5, (float)L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0023;
	}

IL_0023:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_9 = V_0;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_2(L_0);
		float L_1 = ___y1;
		__this->set_y_3(L_1);
		float L_2 = ___z2;
		__this->set_z_4(L_2);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * __this, float ___x0, float ___y1, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_0(L_0);
		float L_1 = ___y1;
		__this->set_y_1(L_1);
		return;
	}
}
