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
// System.Reflection.AssemblyCompanyAttribute
struct AssemblyCompanyAttribute_t642AAB097D7DEAAB623BEBE4664327E9B01D1DE4;
// System.Reflection.AssemblyCopyrightAttribute
struct AssemblyCopyrightAttribute_tA6A09319EF50B48D962810032000DEE7B12904EC;
// System.Reflection.AssemblyDescriptionAttribute
struct AssemblyDescriptionAttribute_tF4460CCB289F6E2F71841792BBC7E6907DF612B3;
// System.Reflection.AssemblyFileVersionAttribute
struct AssemblyFileVersionAttribute_tCC1036D0566155DC5688D9230EF3C07D82A1896F;
// System.Reflection.AssemblyProductAttribute
struct AssemblyProductAttribute_t6BB0E0F76C752E14A4C26B4D1E230019068601CA;
// System.Reflection.AssemblyTitleAttribute
struct AssemblyTitleAttribute_tABB894D0792C7F307694CC796C8AE5D6A20382E7;
// System.Reflection.AssemblyTrademarkAttribute
struct AssemblyTrademarkAttribute_t0602679435F8EBECC5DDB55CFE3A7A4A4CA2B5E2;
// System.CLSCompliantAttribute
struct CLSCompliantAttribute_tA28EF6D4ADBD3C5C429DE9A70DD1E927C8906249;
// System.Runtime.CompilerServices.CompilationRelaxationsAttribute
struct CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF;
// System.Runtime.CompilerServices.CompilerGeneratedAttribute
struct CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C;
// System.Diagnostics.DebuggableAttribute
struct DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B;
// System.Reflection.DefaultMemberAttribute
struct DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5;
// System.FlagsAttribute
struct FlagsAttribute_t511C558FACEF1CC64702A8FAB67CAF3CBA65DF36;
// System.Runtime.InteropServices.GuidAttribute
struct GuidAttribute_tBB494B31270577CCD589ABBB159C18CDAE20D063;
// System.ParamArrayAttribute
struct ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F;
// System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
struct RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80;
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

// System.Reflection.AssemblyCompanyAttribute
struct AssemblyCompanyAttribute_t642AAB097D7DEAAB623BEBE4664327E9B01D1DE4  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.AssemblyCompanyAttribute::m_company
	String_t* ___m_company_0;

public:
	inline static int32_t get_offset_of_m_company_0() { return static_cast<int32_t>(offsetof(AssemblyCompanyAttribute_t642AAB097D7DEAAB623BEBE4664327E9B01D1DE4, ___m_company_0)); }
	inline String_t* get_m_company_0() const { return ___m_company_0; }
	inline String_t** get_address_of_m_company_0() { return &___m_company_0; }
	inline void set_m_company_0(String_t* value)
	{
		___m_company_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_company_0), (void*)value);
	}
};


// System.Reflection.AssemblyCopyrightAttribute
struct AssemblyCopyrightAttribute_tA6A09319EF50B48D962810032000DEE7B12904EC  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.AssemblyCopyrightAttribute::m_copyright
	String_t* ___m_copyright_0;

public:
	inline static int32_t get_offset_of_m_copyright_0() { return static_cast<int32_t>(offsetof(AssemblyCopyrightAttribute_tA6A09319EF50B48D962810032000DEE7B12904EC, ___m_copyright_0)); }
	inline String_t* get_m_copyright_0() const { return ___m_copyright_0; }
	inline String_t** get_address_of_m_copyright_0() { return &___m_copyright_0; }
	inline void set_m_copyright_0(String_t* value)
	{
		___m_copyright_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_copyright_0), (void*)value);
	}
};


// System.Reflection.AssemblyDescriptionAttribute
struct AssemblyDescriptionAttribute_tF4460CCB289F6E2F71841792BBC7E6907DF612B3  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.AssemblyDescriptionAttribute::m_description
	String_t* ___m_description_0;

public:
	inline static int32_t get_offset_of_m_description_0() { return static_cast<int32_t>(offsetof(AssemblyDescriptionAttribute_tF4460CCB289F6E2F71841792BBC7E6907DF612B3, ___m_description_0)); }
	inline String_t* get_m_description_0() const { return ___m_description_0; }
	inline String_t** get_address_of_m_description_0() { return &___m_description_0; }
	inline void set_m_description_0(String_t* value)
	{
		___m_description_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_description_0), (void*)value);
	}
};


// System.Reflection.AssemblyFileVersionAttribute
struct AssemblyFileVersionAttribute_tCC1036D0566155DC5688D9230EF3C07D82A1896F  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.AssemblyFileVersionAttribute::_version
	String_t* ____version_0;

public:
	inline static int32_t get_offset_of__version_0() { return static_cast<int32_t>(offsetof(AssemblyFileVersionAttribute_tCC1036D0566155DC5688D9230EF3C07D82A1896F, ____version_0)); }
	inline String_t* get__version_0() const { return ____version_0; }
	inline String_t** get_address_of__version_0() { return &____version_0; }
	inline void set__version_0(String_t* value)
	{
		____version_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____version_0), (void*)value);
	}
};


// System.Reflection.AssemblyProductAttribute
struct AssemblyProductAttribute_t6BB0E0F76C752E14A4C26B4D1E230019068601CA  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.AssemblyProductAttribute::m_product
	String_t* ___m_product_0;

public:
	inline static int32_t get_offset_of_m_product_0() { return static_cast<int32_t>(offsetof(AssemblyProductAttribute_t6BB0E0F76C752E14A4C26B4D1E230019068601CA, ___m_product_0)); }
	inline String_t* get_m_product_0() const { return ___m_product_0; }
	inline String_t** get_address_of_m_product_0() { return &___m_product_0; }
	inline void set_m_product_0(String_t* value)
	{
		___m_product_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_product_0), (void*)value);
	}
};


// System.Reflection.AssemblyTitleAttribute
struct AssemblyTitleAttribute_tABB894D0792C7F307694CC796C8AE5D6A20382E7  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.AssemblyTitleAttribute::m_title
	String_t* ___m_title_0;

public:
	inline static int32_t get_offset_of_m_title_0() { return static_cast<int32_t>(offsetof(AssemblyTitleAttribute_tABB894D0792C7F307694CC796C8AE5D6A20382E7, ___m_title_0)); }
	inline String_t* get_m_title_0() const { return ___m_title_0; }
	inline String_t** get_address_of_m_title_0() { return &___m_title_0; }
	inline void set_m_title_0(String_t* value)
	{
		___m_title_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_title_0), (void*)value);
	}
};


// System.Reflection.AssemblyTrademarkAttribute
struct AssemblyTrademarkAttribute_t0602679435F8EBECC5DDB55CFE3A7A4A4CA2B5E2  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.AssemblyTrademarkAttribute::m_trademark
	String_t* ___m_trademark_0;

public:
	inline static int32_t get_offset_of_m_trademark_0() { return static_cast<int32_t>(offsetof(AssemblyTrademarkAttribute_t0602679435F8EBECC5DDB55CFE3A7A4A4CA2B5E2, ___m_trademark_0)); }
	inline String_t* get_m_trademark_0() const { return ___m_trademark_0; }
	inline String_t** get_address_of_m_trademark_0() { return &___m_trademark_0; }
	inline void set_m_trademark_0(String_t* value)
	{
		___m_trademark_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_trademark_0), (void*)value);
	}
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


// System.CLSCompliantAttribute
struct CLSCompliantAttribute_tA28EF6D4ADBD3C5C429DE9A70DD1E927C8906249  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Boolean System.CLSCompliantAttribute::m_compliant
	bool ___m_compliant_0;

public:
	inline static int32_t get_offset_of_m_compliant_0() { return static_cast<int32_t>(offsetof(CLSCompliantAttribute_tA28EF6D4ADBD3C5C429DE9A70DD1E927C8906249, ___m_compliant_0)); }
	inline bool get_m_compliant_0() const { return ___m_compliant_0; }
	inline bool* get_address_of_m_compliant_0() { return &___m_compliant_0; }
	inline void set_m_compliant_0(bool value)
	{
		___m_compliant_0 = value;
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


// System.Reflection.DefaultMemberAttribute
struct DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Reflection.DefaultMemberAttribute::m_memberName
	String_t* ___m_memberName_0;

public:
	inline static int32_t get_offset_of_m_memberName_0() { return static_cast<int32_t>(offsetof(DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5, ___m_memberName_0)); }
	inline String_t* get_m_memberName_0() const { return ___m_memberName_0; }
	inline String_t** get_address_of_m_memberName_0() { return &___m_memberName_0; }
	inline void set_m_memberName_0(String_t* value)
	{
		___m_memberName_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_memberName_0), (void*)value);
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

// System.FlagsAttribute
struct FlagsAttribute_t511C558FACEF1CC64702A8FAB67CAF3CBA65DF36  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.Runtime.InteropServices.GuidAttribute
struct GuidAttribute_tBB494B31270577CCD589ABBB159C18CDAE20D063  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Runtime.InteropServices.GuidAttribute::_val
	String_t* ____val_0;

public:
	inline static int32_t get_offset_of__val_0() { return static_cast<int32_t>(offsetof(GuidAttribute_tBB494B31270577CCD589ABBB159C18CDAE20D063, ____val_0)); }
	inline String_t* get__val_0() const { return ____val_0; }
	inline String_t** get_address_of__val_0() { return &____val_0; }
	inline void set__val_0(String_t* value)
	{
		____val_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____val_0), (void*)value);
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



// System.Void System.CLSCompliantAttribute::.ctor(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CLSCompliantAttribute__ctor_m340EDA4DA5E45506AD631FE84241ADFB6B3F0270 (CLSCompliantAttribute_tA28EF6D4ADBD3C5C429DE9A70DD1E927C8906249 * __this, bool ___isCompliant0, const RuntimeMethod* method);
// System.Void System.Runtime.InteropServices.GuidAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GuidAttribute__ctor_mCCEF3938DF601B23B5791CEE8F7AF05C98B6AFEA (GuidAttribute_tBB494B31270577CCD589ABBB159C18CDAE20D063 * __this, String_t* ___guid0, const RuntimeMethod* method);
// System.Void System.Reflection.AssemblyTrademarkAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AssemblyTrademarkAttribute__ctor_m6FBD5AAE48F00120043AD8BECF2586896CFB6C02 (AssemblyTrademarkAttribute_t0602679435F8EBECC5DDB55CFE3A7A4A4CA2B5E2 * __this, String_t* ___trademark0, const RuntimeMethod* method);
// System.Void System.Reflection.AssemblyCopyrightAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AssemblyCopyrightAttribute__ctor_mB0B5F5C1A7A8B172289CC694E2711F07A37CE3F3 (AssemblyCopyrightAttribute_tA6A09319EF50B48D962810032000DEE7B12904EC * __this, String_t* ___copyright0, const RuntimeMethod* method);
// System.Void System.Reflection.AssemblyProductAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AssemblyProductAttribute__ctor_m26DF1EBC1C86E7DA4786C66B44123899BE8DBCB8 (AssemblyProductAttribute_t6BB0E0F76C752E14A4C26B4D1E230019068601CA * __this, String_t* ___product0, const RuntimeMethod* method);
// System.Void System.Reflection.AssemblyCompanyAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AssemblyCompanyAttribute__ctor_m435C9FEC405646617645636E67860598A0C46FF0 (AssemblyCompanyAttribute_t642AAB097D7DEAAB623BEBE4664327E9B01D1DE4 * __this, String_t* ___company0, const RuntimeMethod* method);
// System.Void System.Reflection.AssemblyDescriptionAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AssemblyDescriptionAttribute__ctor_m3A0BD500FF352A67235FBA499FBA58EFF15B1F25 (AssemblyDescriptionAttribute_tF4460CCB289F6E2F71841792BBC7E6907DF612B3 * __this, String_t* ___description0, const RuntimeMethod* method);
// System.Void System.Reflection.AssemblyTitleAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AssemblyTitleAttribute__ctor_mE239F206B3B369C48AE1F3B4211688778FE99E8D (AssemblyTitleAttribute_tABB894D0792C7F307694CC796C8AE5D6A20382E7 * __this, String_t* ___title0, const RuntimeMethod* method);
// System.Void System.Diagnostics.DebuggableAttribute::.ctor(System.Diagnostics.DebuggableAttribute/DebuggingModes)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DebuggableAttribute__ctor_m7FF445C8435494A4847123A668D889E692E55550 (DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B * __this, int32_t ___modes0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute__ctor_m551DDF1438CE97A984571949723F30F44CF7317C (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::set_WrapNonExceptionThrows(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, bool ___value0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompilationRelaxationsAttribute__ctor_mAC3079EBC4EEAB474EED8208EF95DB39C922333B (CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF * __this, int32_t ___relaxations0, const RuntimeMethod* method);
// System.Void System.Reflection.AssemblyFileVersionAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AssemblyFileVersionAttribute__ctor_mF855AEBC51CB72F4FF913499256741AE57B0F13D (AssemblyFileVersionAttribute_tCC1036D0566155DC5688D9230EF3C07D82A1896F * __this, String_t* ___version0, const RuntimeMethod* method);
// System.Void System.Reflection.DefaultMemberAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7 (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * __this, String_t* ___memberName0, const RuntimeMethod* method);
// System.Void System.FlagsAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FlagsAttribute__ctor_mE8DCBA1BE0E6B0424FEF5E5F249733CF6A0E1229 (FlagsAttribute_t511C558FACEF1CC64702A8FAB67CAF3CBA65DF36 * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35 (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * __this, const RuntimeMethod* method);
// System.Void System.ParamArrayAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719 (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * __this, const RuntimeMethod* method);
static void zxing_unity_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CLSCompliantAttribute_tA28EF6D4ADBD3C5C429DE9A70DD1E927C8906249 * tmp = (CLSCompliantAttribute_tA28EF6D4ADBD3C5C429DE9A70DD1E927C8906249 *)cache->attributes[0];
		CLSCompliantAttribute__ctor_m340EDA4DA5E45506AD631FE84241ADFB6B3F0270(tmp, true, NULL);
	}
	{
		GuidAttribute_tBB494B31270577CCD589ABBB159C18CDAE20D063 * tmp = (GuidAttribute_tBB494B31270577CCD589ABBB159C18CDAE20D063 *)cache->attributes[1];
		GuidAttribute__ctor_mCCEF3938DF601B23B5791CEE8F7AF05C98B6AFEA(tmp, il2cpp_codegen_string_new_wrapper("\x45\x43\x45\x33\x41\x42\x37\x34\x2D\x39\x44\x44\x31\x2D\x34\x43\x46\x42\x2D\x39\x44\x34\x38\x2D\x46\x43\x42\x46\x42\x33\x30\x45\x30\x36\x44\x36"), NULL);
	}
	{
		AssemblyTrademarkAttribute_t0602679435F8EBECC5DDB55CFE3A7A4A4CA2B5E2 * tmp = (AssemblyTrademarkAttribute_t0602679435F8EBECC5DDB55CFE3A7A4A4CA2B5E2 *)cache->attributes[2];
		AssemblyTrademarkAttribute__ctor_m6FBD5AAE48F00120043AD8BECF2586896CFB6C02(tmp, il2cpp_codegen_string_new_wrapper(""), NULL);
	}
	{
		AssemblyCopyrightAttribute_tA6A09319EF50B48D962810032000DEE7B12904EC * tmp = (AssemblyCopyrightAttribute_tA6A09319EF50B48D962810032000DEE7B12904EC *)cache->attributes[3];
		AssemblyCopyrightAttribute__ctor_mB0B5F5C1A7A8B172289CC694E2711F07A37CE3F3(tmp, il2cpp_codegen_string_new_wrapper("\x43\x6F\x70\x79\x72\x69\x67\x68\x74\x20\xC2\xA9\x20\x32\x30\x31\x32"), NULL);
	}
	{
		AssemblyProductAttribute_t6BB0E0F76C752E14A4C26B4D1E230019068601CA * tmp = (AssemblyProductAttribute_t6BB0E0F76C752E14A4C26B4D1E230019068601CA *)cache->attributes[4];
		AssemblyProductAttribute__ctor_m26DF1EBC1C86E7DA4786C66B44123899BE8DBCB8(tmp, il2cpp_codegen_string_new_wrapper("\x5A\x58\x69\x6E\x67\x2E\x4E\x65\x74"), NULL);
	}
	{
		AssemblyCompanyAttribute_t642AAB097D7DEAAB623BEBE4664327E9B01D1DE4 * tmp = (AssemblyCompanyAttribute_t642AAB097D7DEAAB623BEBE4664327E9B01D1DE4 *)cache->attributes[5];
		AssemblyCompanyAttribute__ctor_m435C9FEC405646617645636E67860598A0C46FF0(tmp, il2cpp_codegen_string_new_wrapper("\x5A\x58\x69\x6E\x67\x2E\x4E\x65\x74\x20\x44\x65\x76\x65\x6C\x6F\x70\x6D\x65\x6E\x74"), NULL);
	}
	{
		AssemblyDescriptionAttribute_tF4460CCB289F6E2F71841792BBC7E6907DF612B3 * tmp = (AssemblyDescriptionAttribute_tF4460CCB289F6E2F71841792BBC7E6907DF612B3 *)cache->attributes[6];
		AssemblyDescriptionAttribute__ctor_m3A0BD500FF352A67235FBA499FBA58EFF15B1F25(tmp, il2cpp_codegen_string_new_wrapper("\x70\x6F\x72\x74\x20\x6F\x66\x20\x74\x68\x65\x20\x6A\x61\x76\x61\x20\x62\x61\x73\x65\x64\x20\x62\x61\x72\x63\x6F\x64\x65\x20\x73\x63\x61\x6E\x6E\x69\x6E\x67\x20\x6C\x69\x62\x72\x61\x72\x79\x20\x66\x6F\x72\x20\x2E\x6E\x65\x74\x20\x28\x6A\x61\x76\x61\x20\x7A\x78\x69\x6E\x67\x20\x32\x39\x2E\x30\x37\x2E\x32\x30\x31\x39\x20\x32\x31\x3A\x33\x30\x3A\x33\x35\x29"), NULL);
	}
	{
		AssemblyTitleAttribute_tABB894D0792C7F307694CC796C8AE5D6A20382E7 * tmp = (AssemblyTitleAttribute_tABB894D0792C7F307694CC796C8AE5D6A20382E7 *)cache->attributes[7];
		AssemblyTitleAttribute__ctor_mE239F206B3B369C48AE1F3B4211688778FE99E8D(tmp, il2cpp_codegen_string_new_wrapper("\x7A\x78\x69\x6E\x67\x2E\x6E\x65\x74\x20\x66\x6F\x72\x20\x2E\x6E\x65\x74\x20\x33\x2E\x35\x20\x61\x6E\x64\x20\x75\x6E\x69\x74\x79\x20\x28\x77\x2F\x6F\x20\x53\x79\x73\x74\x65\x6D\x2E\x44\x72\x61\x77\x69\x6E\x67\x29"), NULL);
	}
	{
		DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B * tmp = (DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B *)cache->attributes[8];
		DebuggableAttribute__ctor_m7FF445C8435494A4847123A668D889E692E55550(tmp, 2LL, NULL);
	}
	{
		RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * tmp = (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 *)cache->attributes[9];
		RuntimeCompatibilityAttribute__ctor_m551DDF1438CE97A984571949723F30F44CF7317C(tmp, NULL);
		RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline(tmp, true, NULL);
	}
	{
		CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF * tmp = (CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF *)cache->attributes[10];
		CompilationRelaxationsAttribute__ctor_mAC3079EBC4EEAB474EED8208EF95DB39C922333B(tmp, 8LL, NULL);
	}
	{
		AssemblyFileVersionAttribute_tCC1036D0566155DC5688D9230EF3C07D82A1896F * tmp = (AssemblyFileVersionAttribute_tCC1036D0566155DC5688D9230EF3C07D82A1896F *)cache->attributes[11];
		AssemblyFileVersionAttribute__ctor_mF855AEBC51CB72F4FF913499256741AE57B0F13D(tmp, il2cpp_codegen_string_new_wrapper("\x30\x2E\x31\x36\x2E\x35\x2E\x30"), NULL);
	}
}
static void DigitContainer_t67BCA9FC3E44AC0D7DC486704701B2171F8546E8_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * tmp = (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 *)cache->attributes[0];
		DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7(tmp, il2cpp_codegen_string_new_wrapper("\x49\x74\x65\x6D"), NULL);
	}
}
static void DigitContainer_tE6C3DF6764570ADB5B141B781C8E6B082937C72B_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * tmp = (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 *)cache->attributes[0];
		DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7(tmp, il2cpp_codegen_string_new_wrapper("\x49\x74\x65\x6D"), NULL);
	}
}
static void BarcodeFormat_t5AFA4F950DB66E034CDFC8CF56C6670C1D412F7D_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		FlagsAttribute_t511C558FACEF1CC64702A8FAB67CAF3CBA65DF36 * tmp = (FlagsAttribute_t511C558FACEF1CC64702A8FAB67CAF3CBA65DF36 *)cache->attributes[0];
		FlagsAttribute__ctor_mE8DCBA1BE0E6B0424FEF5E5F249733CF6A0E1229(tmp, NULL);
	}
}
static void U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_U3CNameU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_U3CBitsU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_Mode_get_Name_m254DB4AF0AE2E7F7CB8C27B856F77728958E2EBF(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_Mode_set_Name_m171C6F5602DD918F567CE4E2871E63EBDA373CBD(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_Mode_get_Bits_m862C6734C8A7FD7150A3E6E6D8E1CB56AE3BBF98(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_Mode_set_Bits_mF76AA95A18B5918BE37278EEA511C712EAE9EEEA(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void Version_t9AF3E3BD621992BBFF04EB7D6BCD53FBB601D52F_CustomAttributesCacheGenerator_Version__ctor_mFB5C82DE40AD742C6D1110009A99C1FCC23E3251____ecBlocks2(CustomAttributesCache* cache)
{
	{
		ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * tmp = (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F *)cache->attributes[0];
		ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719(tmp, NULL);
	}
}
static void ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804_CustomAttributesCacheGenerator_ECBlocks__ctor_m78E82884D5FFE2503D5F061A28170FD1E64F2616____ecBlocks1(CustomAttributesCache* cache)
{
	{
		ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * tmp = (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F *)cache->attributes[0];
		ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719(tmp, NULL);
	}
}
static void ByteMatrix_t8D22CAA186E1C3FB3351ABE9919A2B375FDC1F42_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * tmp = (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 *)cache->attributes[0];
		DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7(tmp, il2cpp_codegen_string_new_wrapper("\x49\x74\x65\x6D"), NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CModeU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CECLevelU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CVersionU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CMaskPatternU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CMatrixU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_Mode_mBEC98A8373C6DD0C7FFA89F8E72BF14056E336C3(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_Mode_m659CC3B277B8C30468773ED5739B8D6919DEA33C(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_ECLevel_m5D7E13FACF6B83591A15CB55E28C8532D086F170(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_ECLevel_m891ECD8170EDC5DE441D0B32ACE652B0323D4084(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_Version_mB0C5D15FBB06570158B92B46B235B1A52D3F822B(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_Version_m5030AD31BD08F45A56C1609FB7C07ABD8F3AF208(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_MaskPattern_m8DEA01AD260D244AB4DC79DF4C0541FAD4A24592(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_MaskPattern_m49DE1C684CD26E8D4FB351851B7E1498213A6C11(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_Matrix_m9D0E5D44C7634224F3F60446CDEC8738A5F13B65(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_Matrix_m1954129C9CDC53600FE63BE9E84A0C689AA6E701(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void BarcodeRow_tE1FC66273258E773DC64CBD8CBDE15ABDE4D202F_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * tmp = (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 *)cache->attributes[0];
		DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7(tmp, il2cpp_codegen_string_new_wrapper("\x49\x74\x65\x6D"), NULL);
	}
}
static void EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA_CustomAttributesCacheGenerator_U3CFnc1CodewordIsWrittenU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA_CustomAttributesCacheGenerator_EncoderContext_get_Fnc1CodewordIsWritten_m4556DEA4ADBF6D6CFE96B8A40ABA429E614E9C72(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA_CustomAttributesCacheGenerator_EncoderContext_set_Fnc1CodewordIsWritten_m17479EC8428B84A989FE880BB36AD1380CA2F5DA(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void BitArray_t25D86E8652740A6E8BF8F8CDC1688B5D60A1189E_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * tmp = (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 *)cache->attributes[0];
		DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7(tmp, il2cpp_codegen_string_new_wrapper("\x49\x74\x65\x6D"), NULL);
	}
}
static void BitMatrix_tC9594F9C14467BBA63B070D9DE9DF3679CAF10B6_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 * tmp = (DefaultMemberAttribute_t8C9B3330DEA69EE364962477FF14FD2CFE30D4B5 *)cache->attributes[0];
		DefaultMemberAttribute__ctor_mA025B6F5B3A9292696E01108027840C8DFF7F4D7(tmp, il2cpp_codegen_string_new_wrapper("\x49\x74\x65\x6D"), NULL);
	}
}
static void ECI_t04E4F29E5DFB2AB0310DB47F227A97F4DCDF1D2B_CustomAttributesCacheGenerator_U3CValueU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ECI_t04E4F29E5DFB2AB0310DB47F227A97F4DCDF1D2B_CustomAttributesCacheGenerator_ECI_get_Value_m70B23F9E121A21D0984B2CA727E790360271E592(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void ECI_t04E4F29E5DFB2AB0310DB47F227A97F4DCDF1D2B_CustomAttributesCacheGenerator_ECI_set_Value_m799946B7D1D724FA38115B3135AC20ED66A05189(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CisCompactU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CSizeU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CLayersU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CCodeWordsU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CMatrixU3Ek__BackingField(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_isCompact_mACF2243F06D3580C98AFAE0A5BF5588D60D191EF(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_Size_mAF8D793BDBF5BF6B93B8C1C5972F0C35D9F73F5F(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_Layers_mE0BB348DC17A2F753FC05521EF3097AA5D206243(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_CodeWords_mBF311E8C39A201484AE8722C35DDFF1AFF388D9C(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_get_Matrix_mFB20B9A0529AF189C53F49046F25682B56D4CE04(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_Matrix_m17092C0D4CC0367931267F7EA36AB1DFC207E0CA(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
static void U3CPrivateImplementationDetailsU3E_tA6E10D800241C344AD5168E6F5CC68ABF01394AF_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C * tmp = (CompilerGeneratedAttribute_t39106AB982658D7A94C27DEF3C48DB2F5F7CD75C *)cache->attributes[0];
		CompilerGeneratedAttribute__ctor_m9DC3E4E2DA76FE93948D44199213E2E924DCBE35(tmp, NULL);
	}
}
IL2CPP_EXTERN_C const CustomAttributesCacheGenerator g_zxing_unity_AttributeGenerators[];
const CustomAttributesCacheGenerator g_zxing_unity_AttributeGenerators[50] = 
{
	DigitContainer_t67BCA9FC3E44AC0D7DC486704701B2171F8546E8_CustomAttributesCacheGenerator,
	DigitContainer_tE6C3DF6764570ADB5B141B781C8E6B082937C72B_CustomAttributesCacheGenerator,
	BarcodeFormat_t5AFA4F950DB66E034CDFC8CF56C6670C1D412F7D_CustomAttributesCacheGenerator,
	U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_CustomAttributesCacheGenerator,
	ByteMatrix_t8D22CAA186E1C3FB3351ABE9919A2B375FDC1F42_CustomAttributesCacheGenerator,
	BarcodeRow_tE1FC66273258E773DC64CBD8CBDE15ABDE4D202F_CustomAttributesCacheGenerator,
	BitArray_t25D86E8652740A6E8BF8F8CDC1688B5D60A1189E_CustomAttributesCacheGenerator,
	BitMatrix_tC9594F9C14467BBA63B070D9DE9DF3679CAF10B6_CustomAttributesCacheGenerator,
	U3CPrivateImplementationDetailsU3E_tA6E10D800241C344AD5168E6F5CC68ABF01394AF_CustomAttributesCacheGenerator,
	Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_U3CNameU3Ek__BackingField,
	Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_U3CBitsU3Ek__BackingField,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CModeU3Ek__BackingField,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CECLevelU3Ek__BackingField,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CVersionU3Ek__BackingField,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CMaskPatternU3Ek__BackingField,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_U3CMatrixU3Ek__BackingField,
	EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA_CustomAttributesCacheGenerator_U3CFnc1CodewordIsWrittenU3Ek__BackingField,
	ECI_t04E4F29E5DFB2AB0310DB47F227A97F4DCDF1D2B_CustomAttributesCacheGenerator_U3CValueU3Ek__BackingField,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CisCompactU3Ek__BackingField,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CSizeU3Ek__BackingField,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CLayersU3Ek__BackingField,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CCodeWordsU3Ek__BackingField,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_U3CMatrixU3Ek__BackingField,
	Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_Mode_get_Name_m254DB4AF0AE2E7F7CB8C27B856F77728958E2EBF,
	Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_Mode_set_Name_m171C6F5602DD918F567CE4E2871E63EBDA373CBD,
	Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_Mode_get_Bits_m862C6734C8A7FD7150A3E6E6D8E1CB56AE3BBF98,
	Mode_t2EDA55A45942E32E31AD226C669CC716B582CE0A_CustomAttributesCacheGenerator_Mode_set_Bits_mF76AA95A18B5918BE37278EEA511C712EAE9EEEA,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_Mode_mBEC98A8373C6DD0C7FFA89F8E72BF14056E336C3,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_Mode_m659CC3B277B8C30468773ED5739B8D6919DEA33C,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_ECLevel_m5D7E13FACF6B83591A15CB55E28C8532D086F170,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_ECLevel_m891ECD8170EDC5DE441D0B32ACE652B0323D4084,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_Version_mB0C5D15FBB06570158B92B46B235B1A52D3F822B,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_Version_m5030AD31BD08F45A56C1609FB7C07ABD8F3AF208,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_MaskPattern_m8DEA01AD260D244AB4DC79DF4C0541FAD4A24592,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_MaskPattern_m49DE1C684CD26E8D4FB351851B7E1498213A6C11,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_get_Matrix_m9D0E5D44C7634224F3F60446CDEC8738A5F13B65,
	QRCode_tF001D5C2F3A2250BA7E967E760A055710F294BEE_CustomAttributesCacheGenerator_QRCode_set_Matrix_m1954129C9CDC53600FE63BE9E84A0C689AA6E701,
	EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA_CustomAttributesCacheGenerator_EncoderContext_get_Fnc1CodewordIsWritten_m4556DEA4ADBF6D6CFE96B8A40ABA429E614E9C72,
	EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA_CustomAttributesCacheGenerator_EncoderContext_set_Fnc1CodewordIsWritten_m17479EC8428B84A989FE880BB36AD1380CA2F5DA,
	ECI_t04E4F29E5DFB2AB0310DB47F227A97F4DCDF1D2B_CustomAttributesCacheGenerator_ECI_get_Value_m70B23F9E121A21D0984B2CA727E790360271E592,
	ECI_t04E4F29E5DFB2AB0310DB47F227A97F4DCDF1D2B_CustomAttributesCacheGenerator_ECI_set_Value_m799946B7D1D724FA38115B3135AC20ED66A05189,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_isCompact_mACF2243F06D3580C98AFAE0A5BF5588D60D191EF,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_Size_mAF8D793BDBF5BF6B93B8C1C5972F0C35D9F73F5F,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_Layers_mE0BB348DC17A2F753FC05521EF3097AA5D206243,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_CodeWords_mBF311E8C39A201484AE8722C35DDFF1AFF388D9C,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_get_Matrix_mFB20B9A0529AF189C53F49046F25682B56D4CE04,
	AztecCode_tF249FB817F4815A59771AD8D5DB5EAFAE332AB4B_CustomAttributesCacheGenerator_AztecCode_set_Matrix_m17092C0D4CC0367931267F7EA36AB1DFC207E0CA,
	Version_t9AF3E3BD621992BBFF04EB7D6BCD53FBB601D52F_CustomAttributesCacheGenerator_Version__ctor_mFB5C82DE40AD742C6D1110009A99C1FCC23E3251____ecBlocks2,
	ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804_CustomAttributesCacheGenerator_ECBlocks__ctor_m78E82884D5FFE2503D5F061A28170FD1E64F2616____ecBlocks1,
	zxing_unity_CustomAttributesCacheGenerator,
};
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___value0;
		__this->set_m_wrapNonExceptionThrows_0(L_0);
		return;
	}
}
