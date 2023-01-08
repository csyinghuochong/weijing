#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>



// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Runtime.CompilerServices.CompilationRelaxationsAttribute
struct CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF;
// System.Runtime.CompilerServices.CompilerGeneratedAttribute
struct CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C;
// System.Diagnostics.DebuggableAttribute
struct DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B;
// System.Runtime.CompilerServices.InternalsVisibleToAttribute
struct InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C;
// System.ParamArrayAttribute
struct ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F;
// System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
struct RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80;
// UnityEngine.SerializeField
struct SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25;
// System.String
struct String_t;



IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.Attribute
struct Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71  : public RuntimeObject
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


// System.Runtime.CompilerServices.CompilationRelaxationsAttribute
struct CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Int32 System.Runtime.CompilerServices.CompilationRelaxationsAttribute::m_relaxations
	int32_t ___m_relaxations_0;

public:
	inline static int32_t get_offset_of_m_relaxations_0() { return static_cast<int32_t>(offsetof(CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF, ___m_relaxations_0)); }
	inline int32_t get_m_relaxations_0() const { return ___m_relaxations_0; }
	inline int32_t* get_address_of_m_relaxations_0() { return &___m_relaxations_0; }
	inline void set_m_relaxations_0(int32_t value)
	{
		___m_relaxations_0 = value;
	}
};


// System.Runtime.CompilerServices.CompilerGeneratedAttribute
struct CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
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

// System.Runtime.CompilerServices.InternalsVisibleToAttribute
struct InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Runtime.CompilerServices.InternalsVisibleToAttribute::_assemblyName
	String_t* ____assemblyName_0;
	// System.Boolean System.Runtime.CompilerServices.InternalsVisibleToAttribute::_allInternalsVisible
	bool ____allInternalsVisible_1;

public:
	inline static int32_t get_offset_of__assemblyName_0() { return static_cast<int32_t>(offsetof(InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C, ____assemblyName_0)); }
	inline String_t* get__assemblyName_0() const { return ____assemblyName_0; }
	inline String_t** get_address_of__assemblyName_0() { return &____assemblyName_0; }
	inline void set__assemblyName_0(String_t* value)
	{
		____assemblyName_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____assemblyName_0), (void*)value);
	}

	inline static int32_t get_offset_of__allInternalsVisible_1() { return static_cast<int32_t>(offsetof(InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C, ____allInternalsVisible_1)); }
	inline bool get__allInternalsVisible_1() const { return ____allInternalsVisible_1; }
	inline bool* get_address_of__allInternalsVisible_1() { return &____allInternalsVisible_1; }
	inline void set__allInternalsVisible_1(bool value)
	{
		____allInternalsVisible_1 = value;
	}
};


// System.ParamArrayAttribute
struct ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
struct RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Boolean System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::m_wrapNonExceptionThrows
	bool ___m_wrapNonExceptionThrows_0;

public:
	inline static int32_t get_offset_of_m_wrapNonExceptionThrows_0() { return static_cast<int32_t>(offsetof(RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80, ___m_wrapNonExceptionThrows_0)); }
	inline bool get_m_wrapNonExceptionThrows_0() const { return ___m_wrapNonExceptionThrows_0; }
	inline bool* get_address_of_m_wrapNonExceptionThrows_0() { return &___m_wrapNonExceptionThrows_0; }
	inline void set_m_wrapNonExceptionThrows_0(bool value)
	{
		___m_wrapNonExceptionThrows_0 = value;
	}
};


// UnityEngine.SerializeField
struct SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
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


// System.Diagnostics.DebuggableAttribute/DebuggingModes
struct DebuggingModes_t279D5B9C012ABA935887CB73C5A63A1F46AF08A8 
{
public:
	// System.Int32 System.Diagnostics.DebuggableAttribute/DebuggingModes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DebuggingModes_t279D5B9C012ABA935887CB73C5A63A1F46AF08A8, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Diagnostics.DebuggableAttribute
struct DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Diagnostics.DebuggableAttribute/DebuggingModes System.Diagnostics.DebuggableAttribute::m_debuggingModes
	int32_t ___m_debuggingModes_0;

public:
	inline static int32_t get_offset_of_m_debuggingModes_0() { return static_cast<int32_t>(offsetof(DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B, ___m_debuggingModes_0)); }
	inline int32_t get_m_debuggingModes_0() const { return ___m_debuggingModes_0; }
	inline int32_t* get_address_of_m_debuggingModes_0() { return &___m_debuggingModes_0; }
	inline void set_m_debuggingModes_0(int32_t value)
	{
		___m_debuggingModes_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif



// System.Void System.Runtime.CompilerServices.InternalsVisibleToAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InternalsVisibleToAttribute__ctor_m420071A75DCEEC72356490C64B4B0B9270DA32B9 (InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C * __this, String_t* ___assemblyName0, const RuntimeMethod* method);
// System.Void System.Diagnostics.DebuggableAttribute::.ctor(System.Diagnostics.DebuggableAttribute/DebuggingModes)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DebuggableAttribute__ctor_m7FF445C8435494A4847123A668D889E692E55550 (DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B * __this, int32_t ___modes0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute__ctor_m551DDF1438CE97A984571949723F30F44CF7317C (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::set_WrapNonExceptionThrows(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, bool ___value0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompilationRelaxationsAttribute__ctor_mAC3079EBC4EEAB474EED8208EF95DB39C922333B (CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF * __this, int32_t ___relaxations0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35 (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * __this, const RuntimeMethod* method);
// System.Void System.ParamArrayAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719 (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * __this, const RuntimeMethod* method);
// System.Void UnityEngine.SerializeField::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3 (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * __this, const RuntimeMethod* method);
static void UnityEngine_Purchasing_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C * tmp = (InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C *)cache->attributes[0];
		InternalsVisibleToAttribute__ctor_m420071A75DCEEC72356490C64B4B0B9270DA32B9(tmp, il2cpp_codegen_string_new_wrapper("\x44\x79\x6E\x61\x6D\x69\x63\x50\x72\x6F\x78\x79\x47\x65\x6E\x41\x73\x73\x65\x6D\x62\x6C\x79\x32"), NULL);
	}
	{
		InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C * tmp = (InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C *)cache->attributes[1];
		InternalsVisibleToAttribute__ctor_m420071A75DCEEC72356490C64B4B0B9270DA32B9(tmp, il2cpp_codegen_string_new_wrapper("\x55\x6E\x69\x74\x79\x45\x6E\x67\x69\x6E\x65\x2E\x50\x75\x72\x63\x68\x61\x73\x69\x6E\x67\x2E\x53\x74\x6F\x72\x65\x73"), NULL);
	}
	{
		InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C * tmp = (InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C *)cache->attributes[2];
		InternalsVisibleToAttribute__ctor_m420071A75DCEEC72356490C64B4B0B9270DA32B9(tmp, il2cpp_codegen_string_new_wrapper("\x55\x6E\x69\x74\x79\x45\x64\x69\x74\x6F\x72\x2E\x50\x75\x72\x63\x68\x61\x73\x69\x6E\x67"), NULL);
	}
	{
		DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B * tmp = (DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B *)cache->attributes[3];
		DebuggableAttribute__ctor_m7FF445C8435494A4847123A668D889E692E55550(tmp, 2LL, NULL);
	}
	{
		RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * tmp = (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 *)cache->attributes[4];
		RuntimeCompatibilityAttribute__ctor_m551DDF1438CE97A984571949723F30F44CF7317C(tmp, NULL);
		RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline(tmp, true, NULL);
	}
	{
		CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF * tmp = (CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF *)cache->attributes[5];
		CompilationRelaxationsAttribute__ctor_mAC3079EBC4EEAB474EED8208EF95DB39C922333B(tmp, 8LL, NULL);
	}
	{
		InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C * tmp = (InternalsVisibleToAttribute_t1D9772A02892BAC440952F880A43C257E6C3E68C *)cache->attributes[6];
		InternalsVisibleToAttribute__ctor_m420071A75DCEEC72356490C64B4B0B9270DA32B9(tmp, il2cpp_codegen_string_new_wrapper("\x55\x6E\x69\x74\x79\x45\x6E\x67\x69\x6E\x65\x2E\x50\x75\x72\x63\x68\x61\x73\x69\x6E\x67\x2E\x52\x75\x6E\x74\x69\x6D\x65\x54\x65\x73\x74\x73"), NULL);
	}
}
static void ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_CustomAttributesCacheGenerator_U3CuseCatalogProviderU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_CustomAttributesCacheGenerator_ConfigurationBuilder_get_useCatalogProvider_mD19652692295CEAC3B86595FA8C3C4A4BBABF664(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_CustomAttributesCacheGenerator_ConfigurationBuilder_Instance_m8A8AC35B507C6934A818FCDB5DF6BE15952FEEB1____rest1(CustomAttributesCache* cache)
{
	{
		ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * tmp = (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F *)cache->attributes[0];
		ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719(tmp, NULL);
	}
}
static void PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D_CustomAttributesCacheGenerator_m_Type(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D_CustomAttributesCacheGenerator_m_Subtype(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D_CustomAttributesCacheGenerator_m_Quantity(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D_CustomAttributesCacheGenerator_m_Data(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CdefinitionU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CmetadataU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CavailableToPurchaseU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CtransactionIDU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CreceiptU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_definition_m17632BA5F56BA30A07498B0EB5C0D1D7142D521F(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_metadata_m47CFE30071CD7DFC334749332B8C7869D08C18A4(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_availableToPurchase_mBAB83F4E1E276628EA5948A67C2F79F31A003CBF(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_availableToPurchase_m7C4954A4C675BE7DBC041D8928D4E66AEBBBE28C(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_receipt_mEB9707DA0BF7F2D19DF9A0B2512B416FF89CB8C7(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_U3CidU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_U3CstoreSpecificIdU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_U3CtypeU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_U3CenabledU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_set_id_m51E9751372680165426BF38F704AF156EDC8F409(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_set_storeSpecificId_m8B517A5FFCCDE7F6D966D01755E6ED85D7E08383(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_get_type_m54E16B91196F7553460DEFE3701E9867F126AB42(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_set_type_mD99FAB9E2A75B43223D3FC6CD94D2227F08685B7(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_get_enabled_mB14409410443F6717CAE07758FD27EDC5BE88A19(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_set_enabled_m9D94A78B81CE41EAAC26428D76679DC52BC8D638(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3ClocalizedPriceStringU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3ClocalizedTitleU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3ClocalizedDescriptionU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3CisoCurrencyCodeU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3ClocalizedPriceU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_localizedPriceString_mA5D6DDFDCF8F4B157E3AC23559650C89ED863914(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_localizedPriceString_m3114E4D67F5A17BC187DBB9D3A067C0569A69702(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_localizedTitle_m2DCBF60B7674A4E25E4D14D00EC66F40C0157D31(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_localizedTitle_mA0D1F59CA6B369ED045226948723B583CD49E78A(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_localizedDescription_mB3B820DBB41F1EEC2B9E2C9B588CDC7050818FDF(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_localizedDescription_m1B74BFD9B930EF7A3174C3C8738EE404D1399152(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_isoCurrencyCode_mF120AB3BE16D7412714ADCB4A3A309994AD14448(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_isoCurrencyCode_m4E5A20FB8601E9A651FBA18BBB5F5ACD426DA768(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_localizedPrice_mCD6B8DDFB4A322CD82A44ECFB0D098F195493F9D(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_localizedPrice_mF41BFD302AE1C9F21AEBD893D4337C362C50DB88(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_CustomAttributesCacheGenerator_U3CpurchasedProductU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_CustomAttributesCacheGenerator_PurchaseEventArgs_get_purchasedProduct_m82395AF6B8EB5A4747C638287821893F2D31D355(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_CustomAttributesCacheGenerator_PurchaseEventArgs_set_purchasedProduct_mDBEFD23C5488F6EC6F2EE719925D31A090AC35CC(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_CustomAttributesCacheGenerator_U3CstoreNameU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_CustomAttributesCacheGenerator_PurchasingFactory__ctor_mE6065911A080C31F248EA2A3871EC24EF7BB71E5____remainingModules1(CustomAttributesCache* cache)
{
	{
		ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * tmp = (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F *)cache->attributes[0];
		ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719(tmp, NULL);
	}
}
static void PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_CustomAttributesCacheGenerator_PurchasingFactory_get_storeName_mFFC419BA561609F0C7FFA02C3C7FC5DCD0E51453(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_CustomAttributesCacheGenerator_PurchasingFactory_set_storeName_mF4007CD7F5CD1373507429D6E6BA9D5A4800AC7D(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_U3CuseTransactionLogU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_U3CproductsU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_PurchasingManager_get_useTransactionLog_mB8E7472617FCBD4BA5C910F4D5D5FFB6A0A6BADF(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_PurchasingManager_set_useTransactionLog_mB13861C43C5625F0F4EA38327A6056EE9EF273DA(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_PurchasingManager_set_products_m302D5E4CFC91CE9E1162063F0F260DC63EB026AD(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_U3CstoreSpecificIdU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_U3CmetadataU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_U3CreceiptU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_U3CtransactionIdU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_get_storeSpecificId_m805EE28C57C25664093C7F5C2FB24EAADFEAFB09(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_set_storeSpecificId_mA913B1D4F5C2DB7009A530F0B3550EF57F20FD44(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_get_metadata_m3638B035BE86738C71F776D7313827080557986B(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_set_metadata_mDD9C2B807FD047A7C91EDA3996931E5D9E886703(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_get_receipt_m0D6C6B53F56F62B89399A156E392AF9AE1D53CC7(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_set_receipt_m68F0A2BE12715CD2FFD606E6455796D4EA254101(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_get_transactionId_m88319BAE8BD3CC3E1D65E19370EE3EB9379BE93F(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_set_transactionId_m5C0C2615AAB10FD93A69683CDEDC072F44CCA752(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_U3CproductIdU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_U3CreasonU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_U3CmessageU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_get_productId_mDAE0C9E1F3A0144CF7A6728EDAC287009F483057(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_set_productId_mE295E5962FBA98CCB477B4B0572CC6FC3A766B6D(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_get_reason_m0EF61510E8851D12EA86FF0376DC4B99A7415E0F(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_set_reason_mDEA2EF43F275FBDED54C8727D03F749E898E22FE(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_get_message_mF5E354CE7F8BAEF0BE525EC30608A54F4607E504(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_set_message_mD2A75514074F67A7CEC79A18D061F444F5BCCAC1(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
IL2CPP_EXTERN_C const CustomAttributesCacheGenerator g_UnityEngine_Purchasing_AttributeGenerators[];
const CustomAttributesCacheGenerator g_UnityEngine_Purchasing_AttributeGenerators[89] = 
{
	U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_CustomAttributesCacheGenerator,
	U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038_CustomAttributesCacheGenerator,
	U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_CustomAttributesCacheGenerator,
	U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089_CustomAttributesCacheGenerator,
	U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF_CustomAttributesCacheGenerator,
	ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_CustomAttributesCacheGenerator_U3CuseCatalogProviderU3Ek__BackingField,
	PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D_CustomAttributesCacheGenerator_m_Type,
	PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D_CustomAttributesCacheGenerator_m_Subtype,
	PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D_CustomAttributesCacheGenerator_m_Quantity,
	PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D_CustomAttributesCacheGenerator_m_Data,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CdefinitionU3Ek__BackingField,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CmetadataU3Ek__BackingField,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CavailableToPurchaseU3Ek__BackingField,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CtransactionIDU3Ek__BackingField,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_U3CreceiptU3Ek__BackingField,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_U3CidU3Ek__BackingField,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_U3CstoreSpecificIdU3Ek__BackingField,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_U3CtypeU3Ek__BackingField,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_U3CenabledU3Ek__BackingField,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3ClocalizedPriceStringU3Ek__BackingField,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3ClocalizedTitleU3Ek__BackingField,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3ClocalizedDescriptionU3Ek__BackingField,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3CisoCurrencyCodeU3Ek__BackingField,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_U3ClocalizedPriceU3Ek__BackingField,
	PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_CustomAttributesCacheGenerator_U3CpurchasedProductU3Ek__BackingField,
	PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_CustomAttributesCacheGenerator_U3CstoreNameU3Ek__BackingField,
	PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_U3CuseTransactionLogU3Ek__BackingField,
	PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_U3CproductsU3Ek__BackingField,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_U3CstoreSpecificIdU3Ek__BackingField,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_U3CmetadataU3Ek__BackingField,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_U3CreceiptU3Ek__BackingField,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_U3CtransactionIdU3Ek__BackingField,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_U3CproductIdU3Ek__BackingField,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_U3CreasonU3Ek__BackingField,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_U3CmessageU3Ek__BackingField,
	ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_CustomAttributesCacheGenerator_ConfigurationBuilder_get_useCatalogProvider_mD19652692295CEAC3B86595FA8C3C4A4BBABF664,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_definition_m17632BA5F56BA30A07498B0EB5C0D1D7142D521F,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_metadata_m47CFE30071CD7DFC334749332B8C7869D08C18A4,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_availableToPurchase_mBAB83F4E1E276628EA5948A67C2F79F31A003CBF,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_availableToPurchase_m7C4954A4C675BE7DBC041D8928D4E66AEBBBE28C,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_get_receipt_mEB9707DA0BF7F2D19DF9A0B2512B416FF89CB8C7,
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_CustomAttributesCacheGenerator_Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_set_id_m51E9751372680165426BF38F704AF156EDC8F409,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_set_storeSpecificId_m8B517A5FFCCDE7F6D966D01755E6ED85D7E08383,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_get_type_m54E16B91196F7553460DEFE3701E9867F126AB42,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_set_type_mD99FAB9E2A75B43223D3FC6CD94D2227F08685B7,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_get_enabled_mB14409410443F6717CAE07758FD27EDC5BE88A19,
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_CustomAttributesCacheGenerator_ProductDefinition_set_enabled_m9D94A78B81CE41EAAC26428D76679DC52BC8D638,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_localizedPriceString_mA5D6DDFDCF8F4B157E3AC23559650C89ED863914,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_localizedPriceString_m3114E4D67F5A17BC187DBB9D3A067C0569A69702,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_localizedTitle_m2DCBF60B7674A4E25E4D14D00EC66F40C0157D31,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_localizedTitle_mA0D1F59CA6B369ED045226948723B583CD49E78A,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_localizedDescription_mB3B820DBB41F1EEC2B9E2C9B588CDC7050818FDF,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_localizedDescription_m1B74BFD9B930EF7A3174C3C8738EE404D1399152,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_isoCurrencyCode_mF120AB3BE16D7412714ADCB4A3A309994AD14448,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_isoCurrencyCode_m4E5A20FB8601E9A651FBA18BBB5F5ACD426DA768,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_get_localizedPrice_mCD6B8DDFB4A322CD82A44ECFB0D098F195493F9D,
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_CustomAttributesCacheGenerator_ProductMetadata_set_localizedPrice_mF41BFD302AE1C9F21AEBD893D4337C362C50DB88,
	PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_CustomAttributesCacheGenerator_PurchaseEventArgs_get_purchasedProduct_m82395AF6B8EB5A4747C638287821893F2D31D355,
	PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_CustomAttributesCacheGenerator_PurchaseEventArgs_set_purchasedProduct_mDBEFD23C5488F6EC6F2EE719925D31A090AC35CC,
	PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_CustomAttributesCacheGenerator_PurchasingFactory_get_storeName_mFFC419BA561609F0C7FFA02C3C7FC5DCD0E51453,
	PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_CustomAttributesCacheGenerator_PurchasingFactory_set_storeName_mF4007CD7F5CD1373507429D6E6BA9D5A4800AC7D,
	PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_PurchasingManager_get_useTransactionLog_mB8E7472617FCBD4BA5C910F4D5D5FFB6A0A6BADF,
	PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_PurchasingManager_set_useTransactionLog_mB13861C43C5625F0F4EA38327A6056EE9EF273DA,
	PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203,
	PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_CustomAttributesCacheGenerator_PurchasingManager_set_products_m302D5E4CFC91CE9E1162063F0F260DC63EB026AD,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_get_storeSpecificId_m805EE28C57C25664093C7F5C2FB24EAADFEAFB09,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_set_storeSpecificId_mA913B1D4F5C2DB7009A530F0B3550EF57F20FD44,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_get_metadata_m3638B035BE86738C71F776D7313827080557986B,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_set_metadata_mDD9C2B807FD047A7C91EDA3996931E5D9E886703,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_get_receipt_m0D6C6B53F56F62B89399A156E392AF9AE1D53CC7,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_set_receipt_m68F0A2BE12715CD2FFD606E6455796D4EA254101,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_get_transactionId_m88319BAE8BD3CC3E1D65E19370EE3EB9379BE93F,
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75_CustomAttributesCacheGenerator_ProductDescription_set_transactionId_m5C0C2615AAB10FD93A69683CDEDC072F44CCA752,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_get_productId_mDAE0C9E1F3A0144CF7A6728EDAC287009F483057,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_set_productId_mE295E5962FBA98CCB477B4B0572CC6FC3A766B6D,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_get_reason_m0EF61510E8851D12EA86FF0376DC4B99A7415E0F,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_set_reason_mDEA2EF43F275FBDED54C8727D03F749E898E22FE,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_get_message_mF5E354CE7F8BAEF0BE525EC30608A54F4607E504,
	PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8_CustomAttributesCacheGenerator_PurchaseFailureDescription_set_message_mD2A75514074F67A7CEC79A18D061F444F5BCCAC1,
	ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_CustomAttributesCacheGenerator_ConfigurationBuilder_Instance_m8A8AC35B507C6934A818FCDB5DF6BE15952FEEB1____rest1,
	PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_CustomAttributesCacheGenerator_PurchasingFactory__ctor_mE6065911A080C31F248EA2A3871EC24EF7BB71E5____remainingModules1,
	UnityEngine_Purchasing_CustomAttributesCacheGenerator,
};
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___value0;
		__this->set_m_wrapNonExceptionThrows_0(L_0);
		return;
	}
}
