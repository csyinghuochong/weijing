#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <stdint.h>
#include <limits>

#include "vm/CachedCCWBase.h"
#include "utils/New.h"

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

// System.Collections.Generic.Dictionary`2<System.UInt32,ILRuntime.Mono.Cecil.MethodDefinition>
struct Dictionary_2_t52EA9BB831C4BA05C9AF6DF686BC07A684EF158C;
// System.Collections.Generic.Dictionary`2<System.UInt32,ILRuntime.Mono.Cecil.TypeDefinition>
struct Dictionary_2_tC5F3A10C0B687CD64E3ECD8F8C09270B46068F95;
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.UInt32[]
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF;
// ILRuntime.Mono.Cecil.Pdb.IMetaDataEmit
struct IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81;
// ILRuntime.Mono.Cecil.Pdb.IMetaDataImport
struct IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7;
// ILRuntime.Mono.Cecil.ModuleDefinition
struct ModuleDefinition_t4BB5213C4FF57912461435EF1F3BB5A8BB0127F8;
// ILRuntime.Mono.Cecil.Pdb.ModuleMetadata
struct ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4;
// System.Security.Cryptography.RandomNumberGenerator
struct RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;

IL2CPP_EXTERN_C RuntimeClass* ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Il2CppComObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var;
struct Guid_t ;
struct IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81;
struct IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7;

struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// ILRuntime.Mono.Cecil.Pdb.ModuleMetadata
struct ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4  : public RuntimeObject
{
public:
	// ILRuntime.Mono.Cecil.ModuleDefinition ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::module
	ModuleDefinition_t4BB5213C4FF57912461435EF1F3BB5A8BB0127F8 * ___module_0;
	// System.Collections.Generic.Dictionary`2<System.UInt32,ILRuntime.Mono.Cecil.TypeDefinition> ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::types
	Dictionary_2_tC5F3A10C0B687CD64E3ECD8F8C09270B46068F95 * ___types_1;
	// System.Collections.Generic.Dictionary`2<System.UInt32,ILRuntime.Mono.Cecil.MethodDefinition> ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::methods
	Dictionary_2_t52EA9BB831C4BA05C9AF6DF686BC07A684EF158C * ___methods_2;

public:
	inline static int32_t get_offset_of_module_0() { return static_cast<int32_t>(offsetof(ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4, ___module_0)); }
	inline ModuleDefinition_t4BB5213C4FF57912461435EF1F3BB5A8BB0127F8 * get_module_0() const { return ___module_0; }
	inline ModuleDefinition_t4BB5213C4FF57912461435EF1F3BB5A8BB0127F8 ** get_address_of_module_0() { return &___module_0; }
	inline void set_module_0(ModuleDefinition_t4BB5213C4FF57912461435EF1F3BB5A8BB0127F8 * value)
	{
		___module_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___module_0), (void*)value);
	}

	inline static int32_t get_offset_of_types_1() { return static_cast<int32_t>(offsetof(ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4, ___types_1)); }
	inline Dictionary_2_tC5F3A10C0B687CD64E3ECD8F8C09270B46068F95 * get_types_1() const { return ___types_1; }
	inline Dictionary_2_tC5F3A10C0B687CD64E3ECD8F8C09270B46068F95 ** get_address_of_types_1() { return &___types_1; }
	inline void set_types_1(Dictionary_2_tC5F3A10C0B687CD64E3ECD8F8C09270B46068F95 * value)
	{
		___types_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___types_1), (void*)value);
	}

	inline static int32_t get_offset_of_methods_2() { return static_cast<int32_t>(offsetof(ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4, ___methods_2)); }
	inline Dictionary_2_t52EA9BB831C4BA05C9AF6DF686BC07A684EF158C * get_methods_2() const { return ___methods_2; }
	inline Dictionary_2_t52EA9BB831C4BA05C9AF6DF686BC07A684EF158C ** get_address_of_methods_2() { return &___methods_2; }
	inline void set_methods_2(Dictionary_2_t52EA9BB831C4BA05C9AF6DF686BC07A684EF158C * value)
	{
		___methods_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___methods_2), (void*)value);
	}
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


// System.Text.StringBuilder
struct StringBuilder_t  : public RuntimeObject
{
public:
	// System.Char[] System.Text.StringBuilder::m_ChunkChars
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___m_ChunkChars_0;
	// System.Text.StringBuilder System.Text.StringBuilder::m_ChunkPrevious
	StringBuilder_t * ___m_ChunkPrevious_1;
	// System.Int32 System.Text.StringBuilder::m_ChunkLength
	int32_t ___m_ChunkLength_2;
	// System.Int32 System.Text.StringBuilder::m_ChunkOffset
	int32_t ___m_ChunkOffset_3;
	// System.Int32 System.Text.StringBuilder::m_MaxCapacity
	int32_t ___m_MaxCapacity_4;

public:
	inline static int32_t get_offset_of_m_ChunkChars_0() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkChars_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_m_ChunkChars_0() const { return ___m_ChunkChars_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_m_ChunkChars_0() { return &___m_ChunkChars_0; }
	inline void set_m_ChunkChars_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___m_ChunkChars_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ChunkChars_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_ChunkPrevious_1() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkPrevious_1)); }
	inline StringBuilder_t * get_m_ChunkPrevious_1() const { return ___m_ChunkPrevious_1; }
	inline StringBuilder_t ** get_address_of_m_ChunkPrevious_1() { return &___m_ChunkPrevious_1; }
	inline void set_m_ChunkPrevious_1(StringBuilder_t * value)
	{
		___m_ChunkPrevious_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ChunkPrevious_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_ChunkLength_2() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkLength_2)); }
	inline int32_t get_m_ChunkLength_2() const { return ___m_ChunkLength_2; }
	inline int32_t* get_address_of_m_ChunkLength_2() { return &___m_ChunkLength_2; }
	inline void set_m_ChunkLength_2(int32_t value)
	{
		___m_ChunkLength_2 = value;
	}

	inline static int32_t get_offset_of_m_ChunkOffset_3() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkOffset_3)); }
	inline int32_t get_m_ChunkOffset_3() const { return ___m_ChunkOffset_3; }
	inline int32_t* get_address_of_m_ChunkOffset_3() { return &___m_ChunkOffset_3; }
	inline void set_m_ChunkOffset_3(int32_t value)
	{
		___m_ChunkOffset_3 = value;
	}

	inline static int32_t get_offset_of_m_MaxCapacity_4() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_MaxCapacity_4)); }
	inline int32_t get_m_MaxCapacity_4() const { return ___m_MaxCapacity_4; }
	inline int32_t* get_address_of_m_MaxCapacity_4() { return &___m_MaxCapacity_4; }
	inline void set_m_MaxCapacity_4(int32_t value)
	{
		___m_MaxCapacity_4 = value;
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

// System.Byte
struct Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056 
{
public:
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056, ___m_value_0)); }
	inline uint8_t get_m_value_0() const { return ___m_value_0; }
	inline uint8_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint8_t value)
	{
		___m_value_0 = value;
	}
};


// System.Guid
struct Guid_t 
{
public:
	// System.Int32 System.Guid::_a
	int32_t ____a_1;
	// System.Int16 System.Guid::_b
	int16_t ____b_2;
	// System.Int16 System.Guid::_c
	int16_t ____c_3;
	// System.Byte System.Guid::_d
	uint8_t ____d_4;
	// System.Byte System.Guid::_e
	uint8_t ____e_5;
	// System.Byte System.Guid::_f
	uint8_t ____f_6;
	// System.Byte System.Guid::_g
	uint8_t ____g_7;
	// System.Byte System.Guid::_h
	uint8_t ____h_8;
	// System.Byte System.Guid::_i
	uint8_t ____i_9;
	// System.Byte System.Guid::_j
	uint8_t ____j_10;
	// System.Byte System.Guid::_k
	uint8_t ____k_11;

public:
	inline static int32_t get_offset_of__a_1() { return static_cast<int32_t>(offsetof(Guid_t, ____a_1)); }
	inline int32_t get__a_1() const { return ____a_1; }
	inline int32_t* get_address_of__a_1() { return &____a_1; }
	inline void set__a_1(int32_t value)
	{
		____a_1 = value;
	}

	inline static int32_t get_offset_of__b_2() { return static_cast<int32_t>(offsetof(Guid_t, ____b_2)); }
	inline int16_t get__b_2() const { return ____b_2; }
	inline int16_t* get_address_of__b_2() { return &____b_2; }
	inline void set__b_2(int16_t value)
	{
		____b_2 = value;
	}

	inline static int32_t get_offset_of__c_3() { return static_cast<int32_t>(offsetof(Guid_t, ____c_3)); }
	inline int16_t get__c_3() const { return ____c_3; }
	inline int16_t* get_address_of__c_3() { return &____c_3; }
	inline void set__c_3(int16_t value)
	{
		____c_3 = value;
	}

	inline static int32_t get_offset_of__d_4() { return static_cast<int32_t>(offsetof(Guid_t, ____d_4)); }
	inline uint8_t get__d_4() const { return ____d_4; }
	inline uint8_t* get_address_of__d_4() { return &____d_4; }
	inline void set__d_4(uint8_t value)
	{
		____d_4 = value;
	}

	inline static int32_t get_offset_of__e_5() { return static_cast<int32_t>(offsetof(Guid_t, ____e_5)); }
	inline uint8_t get__e_5() const { return ____e_5; }
	inline uint8_t* get_address_of__e_5() { return &____e_5; }
	inline void set__e_5(uint8_t value)
	{
		____e_5 = value;
	}

	inline static int32_t get_offset_of__f_6() { return static_cast<int32_t>(offsetof(Guid_t, ____f_6)); }
	inline uint8_t get__f_6() const { return ____f_6; }
	inline uint8_t* get_address_of__f_6() { return &____f_6; }
	inline void set__f_6(uint8_t value)
	{
		____f_6 = value;
	}

	inline static int32_t get_offset_of__g_7() { return static_cast<int32_t>(offsetof(Guid_t, ____g_7)); }
	inline uint8_t get__g_7() const { return ____g_7; }
	inline uint8_t* get_address_of__g_7() { return &____g_7; }
	inline void set__g_7(uint8_t value)
	{
		____g_7 = value;
	}

	inline static int32_t get_offset_of__h_8() { return static_cast<int32_t>(offsetof(Guid_t, ____h_8)); }
	inline uint8_t get__h_8() const { return ____h_8; }
	inline uint8_t* get_address_of__h_8() { return &____h_8; }
	inline void set__h_8(uint8_t value)
	{
		____h_8 = value;
	}

	inline static int32_t get_offset_of__i_9() { return static_cast<int32_t>(offsetof(Guid_t, ____i_9)); }
	inline uint8_t get__i_9() const { return ____i_9; }
	inline uint8_t* get_address_of__i_9() { return &____i_9; }
	inline void set__i_9(uint8_t value)
	{
		____i_9 = value;
	}

	inline static int32_t get_offset_of__j_10() { return static_cast<int32_t>(offsetof(Guid_t, ____j_10)); }
	inline uint8_t get__j_10() const { return ____j_10; }
	inline uint8_t* get_address_of__j_10() { return &____j_10; }
	inline void set__j_10(uint8_t value)
	{
		____j_10 = value;
	}

	inline static int32_t get_offset_of__k_11() { return static_cast<int32_t>(offsetof(Guid_t, ____k_11)); }
	inline uint8_t get__k_11() const { return ____k_11; }
	inline uint8_t* get_address_of__k_11() { return &____k_11; }
	inline void set__k_11(uint8_t value)
	{
		____k_11 = value;
	}
};

struct Guid_t_StaticFields
{
public:
	// System.Guid System.Guid::Empty
	Guid_t  ___Empty_0;
	// System.Object System.Guid::_rngAccess
	RuntimeObject * ____rngAccess_12;
	// System.Security.Cryptography.RandomNumberGenerator System.Guid::_rng
	RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * ____rng_13;
	// System.Security.Cryptography.RandomNumberGenerator System.Guid::_fastRng
	RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * ____fastRng_14;

public:
	inline static int32_t get_offset_of_Empty_0() { return static_cast<int32_t>(offsetof(Guid_t_StaticFields, ___Empty_0)); }
	inline Guid_t  get_Empty_0() const { return ___Empty_0; }
	inline Guid_t * get_address_of_Empty_0() { return &___Empty_0; }
	inline void set_Empty_0(Guid_t  value)
	{
		___Empty_0 = value;
	}

	inline static int32_t get_offset_of__rngAccess_12() { return static_cast<int32_t>(offsetof(Guid_t_StaticFields, ____rngAccess_12)); }
	inline RuntimeObject * get__rngAccess_12() const { return ____rngAccess_12; }
	inline RuntimeObject ** get_address_of__rngAccess_12() { return &____rngAccess_12; }
	inline void set__rngAccess_12(RuntimeObject * value)
	{
		____rngAccess_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____rngAccess_12), (void*)value);
	}

	inline static int32_t get_offset_of__rng_13() { return static_cast<int32_t>(offsetof(Guid_t_StaticFields, ____rng_13)); }
	inline RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * get__rng_13() const { return ____rng_13; }
	inline RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 ** get_address_of__rng_13() { return &____rng_13; }
	inline void set__rng_13(RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * value)
	{
		____rng_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____rng_13), (void*)value);
	}

	inline static int32_t get_offset_of__fastRng_14() { return static_cast<int32_t>(offsetof(Guid_t_StaticFields, ____fastRng_14)); }
	inline RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * get__fastRng_14() const { return ____fastRng_14; }
	inline RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 ** get_address_of__fastRng_14() { return &____fastRng_14; }
	inline void set__fastRng_14(RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * value)
	{
		____fastRng_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____fastRng_14), (void*)value);
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


// System.UInt32
struct UInt32_tE60352A06233E4E69DD198BCC67142159F686B15 
{
public:
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(UInt32_tE60352A06233E4E69DD198BCC67142159F686B15, ___m_value_0)); }
	inline uint32_t get_m_value_0() const { return ___m_value_0; }
	inline uint32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint32_t value)
	{
		___m_value_0 = value;
	}
};

// ILRuntime.Mono.Cecil.Pdb.IMetaDataEmit
struct NOVTABLE IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81 : Il2CppIUnknown
{
	static const Il2CppGuid IID;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetModuleProps_m428F107DD93C43F24692851DCE795029214AC7D7(Il2CppChar* ___szName0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_Save_mE804F7EB997C4BA45116B13978B826562B3A3160(Il2CppChar* ___szFile0, uint32_t ___dwSaveFlags1) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SaveToStream_mA4F0168C0937FC1BD10C3CCC5FB55D08A1B7948E(intptr_t ___pIStream0, uint32_t ___dwSaveFlags1) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_GetSaveSize_m9EAF6C68D7D1FB9A02FBAB691D8993417D7E8FD9(uint32_t ___fSave0, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineTypeDef_m1E9503C46F7FE9DADF02D002B78507832B3F001F(intptr_t ___szTypeDef0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineNestedType_m1081E742FCEBE00911B37FE450EEB669FCC6B52B(intptr_t ___szTypeDef0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3, uint32_t ___tdEncloser4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetHandler_m76C1ABE93FE23BD2C0C7F9DAB84B136CE1521DAC(Il2CppIUnknown* ___pUnk0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineMethod_m138F65EF24164975244105C1B01C6F43530170EC(uint32_t ___td0, intptr_t ___zName1, uint32_t ___dwMethodFlags2, intptr_t ___pvSigBlob3, uint32_t ___cbSigBlob4, uint32_t ___ulCodeRVA5, uint32_t ___dwImplFlags6, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineMethodImpl_m1B726C0B328A7F8DEF172E117BEA79580C2C8C18(uint32_t ___td0, uint32_t ___tkBody1, uint32_t ___tkDecl2) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineTypeRefByName_mA68949DEA4480E31AD1B16547D0B21E57DF1CDAB(uint32_t ___tkResolutionScope0, intptr_t ___szName1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineImportType_mD9606074271F9BFF8F4D9FDB1FDEBE500B750FB9(intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7* ___pImport3, uint32_t ___tdImport4, intptr_t ___pAssemEmit5, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineMemberRef_m9C8B0A3499696D414E0086770333B70296371526(uint32_t ___tkImport0, Il2CppChar* ___szName1, intptr_t ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineImportMember_m682F2EB868F35476443237FB3EE545EBD7E7F99C(intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7* ___pImport3, uint32_t ___mbMember4, intptr_t ___pAssemEmit5, uint32_t ___tkParent6, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineEvent_mB27FBA2466EA3F062D3EDF55C7792A711797C806(uint32_t ___td0, Il2CppChar* ___szEvent1, uint32_t ___dwEventFlags2, uint32_t ___tkEventType3, uint32_t ___mdAddOn4, uint32_t ___mdRemoveOn5, uint32_t ___mdFire6, intptr_t ___rmdOtherMethods7, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetClassLayout_mCE406E506288289DFAF0C4A60FA1E32D2478FD5F(uint32_t ___td0, uint32_t ___dwPackSize1, intptr_t ___rFieldOffsets2, uint32_t ___ulClassSize3) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DeleteClassLayout_m3111901F8556D501BA8F6105EB791711A7EA0435(uint32_t ___td0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetFieldMarshal_m8715001313B08A0CD7B65B945BB773E28A84C33D(uint32_t ___tk0, intptr_t ___pvNativeType1, uint32_t ___cbNativeType2) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DeleteFieldMarshal_mF1E0735A8DDD78C83EF09A825B1EFD7EEDEDE4BF(uint32_t ___tk0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefinePermissionSet_mB926BF1FEE17B8CD923D9ACB3753A56026607DEE(uint32_t ___tk0, uint32_t ___dwAction1, intptr_t ___pvPermission2, uint32_t ___cbPermission3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetRVA_m9417D98488FEE6C27219E323397D5B0DF78D4A38(uint32_t ___md0, uint32_t ___ulRVA1) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_GetTokenFromSig_m98824B863F407334D1D6BE6D4BFAE32CE3A78AC0(intptr_t ___pvSig0, uint32_t ___cbSig1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineModuleRef_m081E203DECD2774837D61D91EF90E326A4A9BD13(Il2CppChar* ___szName0, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetParent_m41DA57DBB32F270EA762F970DC9B4E23530F09CF(uint32_t ___mr0, uint32_t ___tk1) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_GetTokenFromTypeSpec_m0BEB2E3908A459EAFAE24144C3C247C934227EA5(intptr_t ___pvSig0, uint32_t ___cbSig1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SaveToMemory_mD5E2C921263CCE12558E4046236B755687752B33(intptr_t ___pbData0, uint32_t ___cbData1) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineUserString_mFA00B99748AC537A0C72680759F069B30FBA4713(Il2CppChar* ___szString0, uint32_t ___cchString1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DeleteToken_m1A5FC35889E72217493CD0DF6B81AACDCE5290B0(uint32_t ___tkObj0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetMethodProps_m7AEAB98EE8F0FDD88100A7C3AEE3A34EF2103335(uint32_t ___md0, uint32_t ___dwMethodFlags1, uint32_t ___ulCodeRVA2, uint32_t ___dwImplFlags3) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetTypeDefProps_m651FBA9111E878682FAAED80EBB31BF2649F4F7F(uint32_t ___td0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetEventProps_m47F86B05E39617565C1C21455135E8D148D60247(uint32_t ___ev0, uint32_t ___dwEventFlags1, uint32_t ___tkEventType2, uint32_t ___mdAddOn3, uint32_t ___mdRemoveOn4, uint32_t ___mdFire5, intptr_t ___rmdOtherMethods6) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetPermissionSetProps_m9A4DAF6B694FD6564D8F0E8D8051E6704612E33C(uint32_t ___tk0, uint32_t ___dwAction1, intptr_t ___pvPermission2, uint32_t ___cbPermission3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefinePinvokeMap_m133544D3BD05A2CF74FE28E43459298889D6AA1C(uint32_t ___tk0, uint32_t ___dwMappingFlags1, Il2CppChar* ___szImportName2, uint32_t ___mrImportDLL3) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetPinvokeMap_m41C7DACC086059BB3B6E66035C1D157E82868A78(uint32_t ___tk0, uint32_t ___dwMappingFlags1, Il2CppChar* ___szImportName2, uint32_t ___mrImportDLL3) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DeletePinvokeMap_mD545E014B9EBBD62902440F02C5B0D80CC806D4F(uint32_t ___tk0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineCustomAttribute_m6928A7D4D651E3AA223D564697F71D59D5507899(uint32_t ___tkObj0, uint32_t ___tkType1, intptr_t ___pCustomAttribute2, uint32_t ___cbCustomAttribute3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetCustomAttributeValue_m1B99B1307C7719FE2A17385931591794FCAEF86B(uint32_t ___pcv0, intptr_t ___pCustomAttribute1, uint32_t ___cbCustomAttribute2) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineField_mE7573B0EA971B63D86CADBE52CE01271F34E6BB9(uint32_t ___td0, Il2CppChar* ___szName1, uint32_t ___dwFieldFlags2, intptr_t ___pvSigBlob3, uint32_t ___cbSigBlob4, uint32_t ___dwCPlusTypeFlag5, intptr_t ___pValue6, uint32_t ___cchValue7, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineProperty_m06217EABD6C998235CE3C500452141592B7B0F1E(uint32_t ___td0, Il2CppChar* ___szProperty1, uint32_t ___dwPropFlags2, intptr_t ___pvSig3, uint32_t ___cbSig4, uint32_t ___dwCPlusTypeFlag5, intptr_t ___pValue6, uint32_t ___cchValue7, uint32_t ___mdSetter8, uint32_t ___mdGetter9, intptr_t ___rmdOtherMethods10, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineParam_mC511409D41C02E8C9E3B520189690B3EDE9B04DD(uint32_t ___md0, uint32_t ___ulParamSeq1, Il2CppChar* ___szName2, uint32_t ___dwParamFlags3, uint32_t ___dwCPlusTypeFlag4, intptr_t ___pValue5, uint32_t ___cchValue6, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetFieldProps_mE1C1B2F8EDFA27D7BFCF5770B38AB7AF098ACCB6(uint32_t ___fd0, uint32_t ___dwFieldFlags1, uint32_t ___dwCPlusTypeFlag2, intptr_t ___pValue3, uint32_t ___cchValue4) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetPropertyProps_mE8CEE168666047461BB5FF74C439736E10227E2B(uint32_t ___pr0, uint32_t ___dwPropFlags1, uint32_t ___dwCPlusTypeFlag2, intptr_t ___pValue3, uint32_t ___cchValue4, uint32_t ___mdSetter5, uint32_t ___mdGetter6, intptr_t ___rmdOtherMethods7) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetParamProps_m70DEAFEAEBA7B0AAB9BB35219A2F811BB7242AE7(uint32_t ___pd0, Il2CppChar* ___szName1, uint32_t ___dwParamFlags2, uint32_t ___dwCPlusTypeFlag3, intptr_t ___pValue4, uint32_t ___cchValue5) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineSecurityAttributeSet_m87EC2148918CC382B03D11135C857821CE7C159B(uint32_t ___tkObj0, intptr_t ___rSecAttrs1, uint32_t ___cSecAttrs2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_ApplyEditAndContinue_mFE4B9FDEA9B174AA4FDDD212BD2B1FE70596F323(Il2CppIUnknown* ___pImport0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_TranslateSigWithScope_m5D54B1DA1CE22BB4D509A9BE2E00A042528B37CB(intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7* ___import3, intptr_t ___pbSigBlob4, uint32_t ___cbSigBlob5, intptr_t ___pAssemEmit6, IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81* ___emit7, intptr_t ___pvTranslatedSig8, uint32_t ___cbTranslatedSigMax9, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetMethodImplFlags_mDFC9FA3484E420DCB33F9A40920870E1CF72595D(uint32_t ___md0, uint32_t ___dwImplFlags1) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetFieldRVA_m81749123FD373FAFBAFF29BB0D14E61157ACB726(uint32_t ___fd0, uint32_t ___ulRVA1) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_Merge_mBE4C155C791000950970868AF71A82B7D9122AF8(IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7* ___pImport0, intptr_t ___pHostMapToken1, Il2CppIUnknown* ___pHandler2) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_MergeEnd_m9C370016EE3CEFD6707BA868DC17D672FEC8801B() = 0;
};
// ILRuntime.Mono.Cecil.Pdb.IMetaDataImport
struct NOVTABLE IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7 : Il2CppIUnknown
{
	static const Il2CppGuid IID;
	virtual void STDCALL IMetaDataImport_CloseEnum_m0D3899A02EBD1119C75C586BB2E5CE9AE08D0EC8(uint32_t ___hEnum0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_CountEnum_m37E1477ACB8395D410EBAB42D50008B234921D4B(uint32_t ___hEnum0, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_ResetEnum_mCE5B33001D1295A5DAE35818695B096DCD62EA22(uint32_t ___hEnum0, uint32_t ___ulPos1) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumTypeDefs_m62882BB551D53AF5ACFA42A37B3D84FE3B84C79C(uint32_t* ___phEnum0, uint32_t* ___rTypeDefs1, uint32_t ___cMax2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumInterfaceImpls_m41A161BCB8D5307ACD83A9BE015BC2F62638B074(uint32_t* ___phEnum0, uint32_t ___td1, uint32_t* ___rImpls2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumTypeRefs_m18602762DD0D6B88E10410692887720E68BCBE87(uint32_t* ___phEnum0, uint32_t* ___rTypeRefs1, uint32_t ___cMax2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindTypeDefByName_mAD3D7DCC51EA3C9ACBCC521B19E3C4FC9DFFA6E3(Il2CppChar* ___szTypeDef0, uint32_t ___tkEnclosingClass1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetScopeProps_mCF342F004A59F0470CE8F1D3053BF2B314B8A47C(Il2CppChar* ___szName0, uint32_t ___cchName1, uint32_t* ___pchName2, Guid_t * comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetModuleFromScope_mB2863368EC2DAEBEFB6F18C4101CE1CF2428F7B6(uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetTypeDefProps_m0FC61C17845D7B0F3D246EA3A9761DF7242B4841(uint32_t ___td0, intptr_t ___szTypeDef1, uint32_t ___cchTypeDef2, uint32_t* ___pchTypeDef3, intptr_t ___pdwTypeDefFlags4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetInterfaceImplProps_mBA89E086C4A57EC2FA4636FFEF3BAF718F099AB1(uint32_t ___iiImpl0, uint32_t* ___pClass1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetTypeRefProps_m2DE7BDB4F1182C8E4BBEA10C17CA35D7B7DF1FFF(uint32_t ___tr0, uint32_t* ___ptkResolutionScope1, Il2CppChar* ___szName2, uint32_t ___cchName3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_ResolveTypeRef_mF54A03D1DA37718E8D9466658E3C120444327B26(uint32_t ___tr0, Guid_t * ___riid1, Il2CppIUnknown** ___ppIScope2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMembers_m5F86EBABC40A31C3175EF2B198A0357B6311FA91(uint32_t* ___phEnum0, uint32_t ___cl1, uint32_t* ___rMembers2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMembersWithName_mDCECC10F43355C7C77939D444671605C439BBCD8(uint32_t* ___phEnum0, uint32_t ___cl1, Il2CppChar* ___szName2, uint32_t* ___rMembers3, uint32_t ___cMax4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMethods_m06CDF2E78EE9A971361D3933E30CAA41ACC9C325(uint32_t* ___phEnum0, uint32_t ___cl1, intptr_t ___rMethods2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMethodsWithName_m5B854D69051794DA621F5D4F5FE57DC093840775(uint32_t* ___phEnum0, uint32_t ___cl1, Il2CppChar* ___szName2, uint32_t* ___rMethods3, uint32_t ___cMax4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumFields_m18BE7FB7A04CD714EF75E06A0D8AA36AFA748E1B(uint32_t* ___phEnum0, uint32_t ___cl1, intptr_t ___rFields2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumFieldsWithName_mAD5EB669862041BBF8FCBEDD223FA3AA82D42CA3(uint32_t* ___phEnum0, uint32_t ___cl1, Il2CppChar* ___szName2, uint32_t* ___rFields3, uint32_t ___cMax4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumParams_mEDC99F5BD113EC8177A2373416D4F893D472C444(uint32_t* ___phEnum0, uint32_t ___mb1, uint32_t* ___rParams2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMemberRefs_m905F617215EA7A7DD2959DDFAEBA4C15A90E3A84(uint32_t* ___phEnum0, uint32_t ___tkParent1, uint32_t* ___rMemberRefs2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMethodImpls_m800A1948CC075DDEB1DE3786D850B9CF4953050B(uint32_t* ___phEnum0, uint32_t ___td1, uint32_t* ___rMethodBody2, uint32_t* ___rMethodDecl3, uint32_t ___cMax4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumPermissionSets_m727E46DB7B44650D4D8CE41E2029B41D14A86C60(uint32_t* ___phEnum0, uint32_t ___tk1, uint32_t ___dwActions2, uint32_t* ___rPermission3, uint32_t ___cMax4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindMember_mE9F0C70F729DDEAE81316F5BD1C0B17881F80FA4(uint32_t ___td0, Il2CppChar* ___szName1, uint8_t* ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindMethod_m6AF98FF569DFC46F7ECFFB8C765220F8B5D14B24(uint32_t ___td0, Il2CppChar* ___szName1, uint8_t* ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindField_m77B747283B807A87097278A782D89E4BEDA46F83(uint32_t ___td0, Il2CppChar* ___szName1, uint8_t* ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindMemberRef_mDE2D5D9046FE8F93D56D7FB9F07AAC0F57158A61(uint32_t ___td0, Il2CppChar* ___szName1, uint8_t* ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetMethodProps_m0EEE904D2726334706A46B153CF4ED8237459545(uint32_t ___mb0, uint32_t* ___pClass1, intptr_t ___szMethod2, uint32_t ___cchMethod3, uint32_t* ___pchMethod4, intptr_t ___pdwAttr5, intptr_t ___ppvSigBlob6, intptr_t ___pcbSigBlob7, intptr_t ___pulCodeRVA8, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetMemberRefProps_mC729344ED3793124DE09E054B8A4AFE5FB43A99A(uint32_t ___mr0, uint32_t* ___ptk1, Il2CppChar* ___szMember2, uint32_t ___cchMember3, uint32_t* ___pchMember4, intptr_t* ___ppvSigBlob5, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumProperties_mB3F0FA0C172162EDA52F69116ED33F39FAA2AB3A(uint32_t* ___phEnum0, uint32_t ___td1, intptr_t ___rProperties2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumEvents_m4F3C3598CC8870251FB3A67E2A9B7A307B0573F8(uint32_t* ___phEnum0, uint32_t ___td1, intptr_t ___rEvents2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetEventProps_m02B3704478EAA77E28D3678A89AAFB57E20103F7(uint32_t ___ev0, uint32_t* ___pClass1, Il2CppChar* ___szEvent2, uint32_t ___cchEvent3, uint32_t* ___pchEvent4, uint32_t* ___pdwEventFlags5, uint32_t* ___ptkEventType6, uint32_t* ___pmdAddOn7, uint32_t* ___pmdRemoveOn8, uint32_t* ___pmdFire9, uint32_t* ___rmdOtherMethod10, uint32_t ___cMax11, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMethodSemantics_m71E1754D988748DE5DBF9D733882B6DD98BCEF12(uint32_t* ___phEnum0, uint32_t ___mb1, uint32_t* ___rEventProp2, uint32_t ___cMax3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetMethodSemantics_m7ABA0DDD69F65EF75BD832EB59555B32307A38B6(uint32_t ___mb0, uint32_t ___tkEventProp1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetClassLayout_mC391249E3D98647813541985752110CF4C439DED(uint32_t ___td0, uint32_t* ___pdwPackSize1, intptr_t ___rFieldOffset2, uint32_t ___cMax3, uint32_t* ___pcFieldOffset4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetFieldMarshal_m62629228ED1BB8B7D1CF5317282448ECFCAE31A7(uint32_t ___tk0, intptr_t* ___ppvNativeType1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetRVA_m4647E38E555A210A7461C04AB7FC283849FD189C(uint32_t ___tk0, uint32_t* ___pulCodeRVA1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetPermissionSetProps_m018DAB22B9D1CCB215F154D91EF8475EC6FE4CD4(uint32_t ___pm0, uint32_t* ___pdwAction1, intptr_t* ___ppvPermission2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetSigFromToken_mBD0DA8637DAD16A7D580974308D79271BBF2684D(uint32_t ___mdSig0, intptr_t* ___ppvSig1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetModuleRefProps_m445C934778C1A42B7BFF280FAD4A58EC8EC04CDA(uint32_t ___mur0, Il2CppChar* ___szName1, uint32_t ___cchName2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumModuleRefs_m5B0A23EAF222BF4E7ED0F872834D8DFCA7072789(uint32_t* ___phEnum0, uint32_t* ___rModuleRefs1, uint32_t ___cmax2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetTypeSpecFromToken_m1F40421B7A42A57CDA582A2D522E6AEF637E779B(uint32_t ___typespec0, intptr_t* ___ppvSig1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetNameFromToken_m289B25EB1B7624F1FC64DDF38E8D766CAA8541EF(uint32_t ___tk0, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumUnresolvedMethods_m6058184C16C96FB4E9565DDAB73D60AB593F8588(uint32_t* ___phEnum0, uint32_t* ___rMethods1, uint32_t ___cMax2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetUserString_m22012E5672CA55A8454DD445D1CFE1827DF1057F(uint32_t ___stk0, Il2CppChar* ___szString1, uint32_t ___cchString2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetPinvokeMap_mE04F476E7C2FA053AFF4A6F04C74F7277CB3AB45(uint32_t ___tk0, uint32_t* ___pdwMappingFlags1, Il2CppChar* ___szImportName2, uint32_t ___cchImportName3, uint32_t* ___pchImportName4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumSignatures_m246D5B341E047B261839C3F62E7E7FADB7B304CE(uint32_t* ___phEnum0, uint32_t* ___rSignatures1, uint32_t ___cmax2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumTypeSpecs_m6805F3817D44166430557EF435823FA9777E5124(uint32_t* ___phEnum0, uint32_t* ___rTypeSpecs1, uint32_t ___cmax2, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumUserStrings_m0D1AD6AE471157B06FE36CE06479BD072D7BDAEA(uint32_t* ___phEnum0, uint32_t* ___rStrings1, uint32_t ___cmax2, uint32_t* comReturnValue) = 0;
	virtual int32_t STDCALL IMetaDataImport_GetParamForMethodIndex_m0866D89C6A7811AA5FBF95C77E47EA545AD671C5(uint32_t ___md0, uint32_t ___ulParamSeq1, uint32_t* ___pParam2) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumCustomAttributes_m10B90051E4924683EB1E52401A6D62468F7F59E7(uint32_t* ___phEnum0, uint32_t ___tk1, uint32_t ___tkType2, uint32_t* ___rCustomAttributes3, uint32_t ___cMax4, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetCustomAttributeProps_mFF95E6D34E2918C6685E0933F0E6D12D4B4D6574(uint32_t ___cv0, uint32_t* ___ptkObj1, uint32_t* ___ptkType2, intptr_t* ___ppBlob3, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindTypeRef_m54B8F48FAA1C69DC41806DC8BC67171223F98AF4(uint32_t ___tkResolutionScope0, Il2CppChar* ___szName1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetMemberProps_m7259BD39CD2495DEA85F9C9E0A9FD33D5364CD77(uint32_t ___mb0, uint32_t* ___pClass1, Il2CppChar* ___szMember2, uint32_t ___cchMember3, uint32_t* ___pchMember4, uint32_t* ___pdwAttr5, intptr_t* ___ppvSigBlob6, uint32_t* ___pcbSigBlob7, uint32_t* ___pulCodeRVA8, uint32_t* ___pdwImplFlags9, uint32_t* ___pdwCPlusTypeFlag10, intptr_t* ___ppValue11, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetFieldProps_m441C445751C7F8E017A151210928A85699B7A005(uint32_t ___mb0, uint32_t* ___pClass1, Il2CppChar* ___szField2, uint32_t ___cchField3, uint32_t* ___pchField4, uint32_t* ___pdwAttr5, intptr_t* ___ppvSigBlob6, uint32_t* ___pcbSigBlob7, uint32_t* ___pdwCPlusTypeFlag8, intptr_t* ___ppValue9, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetPropertyProps_mC69AE779B863D2C29BEF95D642D874D23FB958D4(uint32_t ___prop0, uint32_t* ___pClass1, Il2CppChar* ___szProperty2, uint32_t ___cchProperty3, uint32_t* ___pchProperty4, uint32_t* ___pdwPropFlags5, intptr_t* ___ppvSig6, uint32_t* ___pbSig7, uint32_t* ___pdwCPlusTypeFlag8, intptr_t* ___ppDefaultValue9, uint32_t* ___pcchDefaultValue10, uint32_t* ___pmdSetter11, uint32_t* ___pmdGetter12, uint32_t* ___rmdOtherMethod13, uint32_t ___cMax14, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetParamProps_m773A908558B1CE55CEE9802D07FCC8799BE0A68C(uint32_t ___tk0, uint32_t* ___pmd1, uint32_t* ___pulSequence2, Il2CppChar* ___szName3, uint32_t ___cchName4, uint32_t* ___pchName5, uint32_t* ___pdwAttr6, uint32_t* ___pdwCPlusTypeFlag7, intptr_t* ___ppValue8, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetCustomAttributeByName_m710CB7275785D45AEEBD8126989C7A9453D01036(uint32_t ___tkObj0, Il2CppChar* ___szName1, intptr_t* ___ppData2, uint32_t* comReturnValue) = 0;
	virtual int32_t STDCALL IMetaDataImport_IsValidToken_mB8D5951A62860491308B8F6D7180E7BC870577A6(uint32_t ___tk0) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetNestedClassProps_mD60FBB2009AE8304B3FB867015517B7A98BDEF24(uint32_t ___tdNestedClass0, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetNativeCallConvFromSig_mBF646865461848854B8743022A6B04AD9A167C5D(intptr_t ___pvSig0, uint32_t ___cbSig1, uint32_t* comReturnValue) = 0;
	virtual il2cpp_hresult_t STDCALL IMetaDataImport_IsGlobal_m4D7BF9FD4B1A8A95F4E13BDCAC80F10232E6878E(uint32_t ___pd0, int32_t* comReturnValue) = 0;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.UInt32[]
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) uint32_t m_Items[1];

public:
	inline uint32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint32_t value)
	{
		m_Items[index] = value;
	}
};
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) uint8_t m_Items[1];

public:
	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};



// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetModuleProps(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetModuleProps_m870FEA9B534889361342B79CD67229BE4F9368F8 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, String_t* ___szName0, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::Save(System.String,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_Save_m7B76D32D3485D76F4600D2277D427B02D5FA4A7F (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, String_t* ___szFile0, uint32_t ___dwSaveFlags1, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SaveToStream(System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SaveToStream_m79CD379CBE755B50D9C39513812570F3272336B1 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___pIStream0, uint32_t ___dwSaveFlags1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetSaveSize(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetSaveSize_mA5145C0B78B32AD618A86E32E170C04ED1CDC3F6 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___fSave0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineTypeDef(System.IntPtr,System.UInt32,System.UInt32,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineTypeDef_mE72337D3C7B048E4F5EE6B69CBA1B2BA53F2B4EE (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___szTypeDef0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineNestedType(System.IntPtr,System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineNestedType_mDBDA737A99A2487B67D82F9D291924192014A114 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___szTypeDef0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3, uint32_t ___tdEncloser4, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetHandler(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetHandler_m78B5A574B9EA32CB0FDE81697388D16D880BBE2D (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, RuntimeObject * ___pUnk0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineMethod(System.UInt32,System.IntPtr,System.UInt32,System.IntPtr,System.UInt32,System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineMethod_mD0F607CF7D28B1ED1E76361660A8FB1483F72753 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, intptr_t ___zName1, uint32_t ___dwMethodFlags2, intptr_t ___pvSigBlob3, uint32_t ___cbSigBlob4, uint32_t ___ulCodeRVA5, uint32_t ___dwImplFlags6, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineMethodImpl(System.UInt32,System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_DefineMethodImpl_m3F8848FFA1DABBDA540E70E8C44EC4C508ACAA43 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, uint32_t ___tkBody1, uint32_t ___tkDecl2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineTypeRefByName(System.UInt32,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineTypeRefByName_m94444FA2ED4B161FFC37F405DBB2246B841A684A (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tkResolutionScope0, intptr_t ___szName1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineImportType(System.IntPtr,System.IntPtr,System.UInt32,ILRuntime.Mono.Cecil.Pdb.IMetaDataImport,System.UInt32,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineImportType_m34E4E97230EF346815013547FA94B3EAF760ECAD (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, RuntimeObject* ___pImport3, uint32_t ___tdImport4, intptr_t ___pAssemEmit5, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineMemberRef(System.UInt32,System.String,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineMemberRef_m13EDBACB40BBAA8F42AC09E7836F32B800B321A9 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tkImport0, String_t* ___szName1, intptr_t ___pvSigBlob2, uint32_t ___cbSigBlob3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineImportMember(System.IntPtr,System.IntPtr,System.UInt32,ILRuntime.Mono.Cecil.Pdb.IMetaDataImport,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineImportMember_m3EF589A409CC15380957787BC9573270F0EA6260 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, RuntimeObject* ___pImport3, uint32_t ___mbMember4, intptr_t ___pAssemEmit5, uint32_t ___tkParent6, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineEvent(System.UInt32,System.String,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineEvent_m8F4712CBCC0E73E810697239925D0A6A10FB1FBB (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, String_t* ___szEvent1, uint32_t ___dwEventFlags2, uint32_t ___tkEventType3, uint32_t ___mdAddOn4, uint32_t ___mdRemoveOn5, uint32_t ___mdFire6, intptr_t ___rmdOtherMethods7, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetClassLayout(System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetClassLayout_m30FA07A7155FC1808B0720CE29F3982354ABD75B (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, uint32_t ___dwPackSize1, intptr_t ___rFieldOffsets2, uint32_t ___ulClassSize3, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DeleteClassLayout(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_DeleteClassLayout_m9C2AE6BC79A4BCB2C9E2227CE9D0985146319FFB (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetFieldMarshal(System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetFieldMarshal_m968CB7A034027B55726C6CF3C850335E525C1A39 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, intptr_t ___pvNativeType1, uint32_t ___cbNativeType2, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DeleteFieldMarshal(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_DeleteFieldMarshal_m45DE3FECD27D95A2CDB1B9A70742E336DBC4357E (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefinePermissionSet(System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefinePermissionSet_mE1EAB4DB94DD2858BC998DA1CEA96F309BEFDE15 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, uint32_t ___dwAction1, intptr_t ___pvPermission2, uint32_t ___cbPermission3, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetRVA(System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetRVA_mF01957F751E47441DDCA4784711414BB8F17D305 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___md0, uint32_t ___ulRVA1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetTokenFromSig(System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetTokenFromSig_m25395E14E0205692BB6187CD90F80B16E4A70D25 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___pvSig0, uint32_t ___cbSig1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineModuleRef(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineModuleRef_m2C460770FD7BB935957317F75AB2A6319C8A6C45 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, String_t* ___szName0, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetParent(System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetParent_m2BB1AD64ADD3309283EA0A6404BFA4D3295DC14E (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___mr0, uint32_t ___tk1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetTokenFromTypeSpec(System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetTokenFromTypeSpec_mE976A60FF4C84D79241D41565AD376173B7D0272 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___pvSig0, uint32_t ___cbSig1, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SaveToMemory(System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SaveToMemory_m5773A6C50874211BFB2E524425030789B4BC4511 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___pbData0, uint32_t ___cbData1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineUserString(System.String,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineUserString_mD9A65DB4130CF23ECC3450DE10824910B5163B32 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, String_t* ___szString0, uint32_t ___cchString1, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DeleteToken(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_DeleteToken_mD3C05450007569AF36C578F99567291664297DD7 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tkObj0, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetMethodProps(System.UInt32,System.UInt32,System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetMethodProps_m15E04550854D6BA7B4A5C914487696A26217BB7F (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___md0, uint32_t ___dwMethodFlags1, uint32_t ___ulCodeRVA2, uint32_t ___dwImplFlags3, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetTypeDefProps(System.UInt32,System.UInt32,System.UInt32,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetTypeDefProps_mB9670FC0501B2AD0144C17C8AF3BB1706BC35524 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetEventProps(System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetEventProps_mF71560311A26433B9FFD74D11CDBC018AC70D742 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___ev0, uint32_t ___dwEventFlags1, uint32_t ___tkEventType2, uint32_t ___mdAddOn3, uint32_t ___mdRemoveOn4, uint32_t ___mdFire5, intptr_t ___rmdOtherMethods6, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetPermissionSetProps(System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_SetPermissionSetProps_m32E974759BD5761D535D37751D85C79A0111F413 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, uint32_t ___dwAction1, intptr_t ___pvPermission2, uint32_t ___cbPermission3, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefinePinvokeMap(System.UInt32,System.UInt32,System.String,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_DefinePinvokeMap_mE683CFA75A1AB0D26D4E8E96C0A83EFFDD850FC8 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, uint32_t ___dwMappingFlags1, String_t* ___szImportName2, uint32_t ___mrImportDLL3, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetPinvokeMap(System.UInt32,System.UInt32,System.String,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetPinvokeMap_m3386070EFA7CFDE274FC469ACC76DFAFE6A3646D (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, uint32_t ___dwMappingFlags1, String_t* ___szImportName2, uint32_t ___mrImportDLL3, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DeletePinvokeMap(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_DeletePinvokeMap_mC3B131971008DDCE2FD6519CA6B596CF9C954AAC (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineCustomAttribute(System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineCustomAttribute_m605064E11CD706E49828A3B5DE24F8B70D8CE9D5 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tkObj0, uint32_t ___tkType1, intptr_t ___pCustomAttribute2, uint32_t ___cbCustomAttribute3, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetCustomAttributeValue(System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetCustomAttributeValue_m8CF08AE14DCF0CECA0AF53E9344972A0F2E222C0 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___pcv0, intptr_t ___pCustomAttribute1, uint32_t ___cbCustomAttribute2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineField(System.UInt32,System.String,System.UInt32,System.IntPtr,System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineField_mC61224F500012207B6B985E51038E5EBE6AFDEB9 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, String_t* ___szName1, uint32_t ___dwFieldFlags2, intptr_t ___pvSigBlob3, uint32_t ___cbSigBlob4, uint32_t ___dwCPlusTypeFlag5, intptr_t ___pValue6, uint32_t ___cchValue7, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineProperty(System.UInt32,System.String,System.UInt32,System.IntPtr,System.UInt32,System.UInt32,System.IntPtr,System.UInt32,System.UInt32,System.UInt32,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineProperty_mF3B5872C7A0C0269EA9ABBCF8201252B10B013FE (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, String_t* ___szProperty1, uint32_t ___dwPropFlags2, intptr_t ___pvSig3, uint32_t ___cbSig4, uint32_t ___dwCPlusTypeFlag5, intptr_t ___pValue6, uint32_t ___cchValue7, uint32_t ___mdSetter8, uint32_t ___mdGetter9, intptr_t ___rmdOtherMethods10, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineParam(System.UInt32,System.UInt32,System.String,System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineParam_mBD4E938DED73F9FFFE94B13510FA1B16CA1E8ECD (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___md0, uint32_t ___ulParamSeq1, String_t* ___szName2, uint32_t ___dwParamFlags3, uint32_t ___dwCPlusTypeFlag4, intptr_t ___pValue5, uint32_t ___cchValue6, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetFieldProps(System.UInt32,System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetFieldProps_mA986916733F4C60A1A2F30EEBC39D6B05771610F (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___fd0, uint32_t ___dwFieldFlags1, uint32_t ___dwCPlusTypeFlag2, intptr_t ___pValue3, uint32_t ___cchValue4, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetPropertyProps(System.UInt32,System.UInt32,System.UInt32,System.IntPtr,System.UInt32,System.UInt32,System.UInt32,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetPropertyProps_mA7133E794F5C0F6EAEAC2C49FBE08611846EA1EB (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___pr0, uint32_t ___dwPropFlags1, uint32_t ___dwCPlusTypeFlag2, intptr_t ___pValue3, uint32_t ___cchValue4, uint32_t ___mdSetter5, uint32_t ___mdGetter6, intptr_t ___rmdOtherMethods7, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetParamProps(System.UInt32,System.String,System.UInt32,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetParamProps_m4C1C501A1260402E0C90CB87B6DD1D90790BED0F (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___pd0, String_t* ___szName1, uint32_t ___dwParamFlags2, uint32_t ___dwCPlusTypeFlag3, intptr_t ___pValue4, uint32_t ___cchValue5, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::DefineSecurityAttributeSet(System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_DefineSecurityAttributeSet_m524C06ED98FD33ABEFB602E4FD8C6800BC693CF9 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tkObj0, intptr_t ___rSecAttrs1, uint32_t ___cSecAttrs2, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::ApplyEditAndContinue(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_ApplyEditAndContinue_mC7ED2E1CC1DA2D730B69A79FBE17A0C0F5D6C391 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, RuntimeObject * ___pImport0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::TranslateSigWithScope(System.IntPtr,System.IntPtr,System.UInt32,ILRuntime.Mono.Cecil.Pdb.IMetaDataImport,System.IntPtr,System.UInt32,System.IntPtr,ILRuntime.Mono.Cecil.Pdb.IMetaDataEmit,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_TranslateSigWithScope_mEAC6C9F621D2DE5CE64BD9DBBC660C0A136D8A82 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, RuntimeObject* ___import3, intptr_t ___pbSigBlob4, uint32_t ___cbSigBlob5, intptr_t ___pAssemEmit6, RuntimeObject* ___emit7, intptr_t ___pvTranslatedSig8, uint32_t ___cbTranslatedSigMax9, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetMethodImplFlags(System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetMethodImplFlags_m84296E755B28FA88225692EB2DBB03C70C64D2FA (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___md0, uint32_t ___dwImplFlags1, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::SetFieldRVA(System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_SetFieldRVA_mEA445E624F4738E74E833839BB76663CB3140FFE (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___fd0, uint32_t ___ulRVA1, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::Merge(ILRuntime.Mono.Cecil.Pdb.IMetaDataImport,System.IntPtr,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_Merge_m608D3180C648DA67F7D67D4F86CDB549ADC2A8C5 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, RuntimeObject* ___pImport0, intptr_t ___pHostMapToken1, RuntimeObject * ___pHandler2, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::MergeEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_MergeEnd_m4C0B630B3BA7ABAB1E1C6E0F6293F0C84410F64C (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::CloseEnum(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_CloseEnum_mAE0F83C4DA54B0ABC6A310498DC61C12467633F5 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___hEnum0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::CountEnum(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_CountEnum_m0A508E9DF87C43C3E530BD6AB555C0C83A37F0B0 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___hEnum0, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::ResetEnum(System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleMetadata_ResetEnum_mA615369B0432CE053B4453500AFB182EC714C721 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___hEnum0, uint32_t ___ulPos1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumTypeDefs(System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumTypeDefs_m8FFA21F10D64CDDF4A22BBFE076A477319391E6D (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rTypeDefs1, uint32_t ___cMax2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumInterfaceImpls(System.UInt32&,System.UInt32,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumInterfaceImpls_m5333F1974961AC64F477B07C37A40F2CF1DAA079 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___td1, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rImpls2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumTypeRefs(System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumTypeRefs_mB6787E85B157251D6FA49B6FBBBBDF344917664E (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rTypeRefs1, uint32_t ___cMax2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::FindTypeDefByName(System.String,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_FindTypeDefByName_m7071A9946B8B2908E0F21F4760DDFA3EDCBD4E84 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, String_t* ___szTypeDef0, uint32_t ___tkEnclosingClass1, const RuntimeMethod* method);
// System.Guid ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetScopeProps(System.Text.StringBuilder,System.UInt32,System.UInt32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Guid_t  ModuleMetadata_GetScopeProps_mB6FA1BD8309D6F7C491640ACA926B1A4DF0FBD7D (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, StringBuilder_t * ___szName0, uint32_t ___cchName1, uint32_t* ___pchName2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetModuleFromScope()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetModuleFromScope_mED04B885FB81C0DD9247680D2F55B7ABCC3F27DB (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetTypeDefProps(System.UInt32,System.IntPtr,System.UInt32,System.UInt32&,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetTypeDefProps_m2E31E25570780B4CB2AEF8393323614EF5A9CC2D (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, intptr_t ___szTypeDef1, uint32_t ___cchTypeDef2, uint32_t* ___pchTypeDef3, intptr_t ___pdwTypeDefFlags4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetInterfaceImplProps(System.UInt32,System.UInt32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetInterfaceImplProps_mCA08097B943A72EBC23076BE7F088EA15CBA5FE4 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___iiImpl0, uint32_t* ___pClass1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetTypeRefProps(System.UInt32,System.UInt32&,System.Text.StringBuilder,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetTypeRefProps_mB404A11734BBE6CB73C4459617D25F19074BCFC7 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tr0, uint32_t* ___ptkResolutionScope1, StringBuilder_t * ___szName2, uint32_t ___cchName3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::ResolveTypeRef(System.UInt32,System.Guid&,System.Object&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_ResolveTypeRef_m37D7C1593B3761050A6D739FA843E255DEFEF832 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tr0, Guid_t * ___riid1, RuntimeObject ** ___ppIScope2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumMembers(System.UInt32&,System.UInt32,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumMembers_mC9D20D710AAE1B913D5FC4E078782AFDF9550212 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___cl1, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rMembers2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumMembersWithName(System.UInt32&,System.UInt32,System.String,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumMembersWithName_m7E8BD472B75CBEE4D4EC9DA7BC384B0F33EC26BF (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___cl1, String_t* ___szName2, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rMembers3, uint32_t ___cMax4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumMethods(System.UInt32&,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumMethods_m2848C10413D5C928BBBECCBE674F76CACFFCF51C (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___cl1, intptr_t ___rMethods2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumMethodsWithName(System.UInt32&,System.UInt32,System.String,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumMethodsWithName_m311550F2826F9BDD3969CAB1CFAC0E6E443F2DDA (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___cl1, String_t* ___szName2, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rMethods3, uint32_t ___cMax4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumFields(System.UInt32&,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumFields_m1DD5BFB0B72B7C4C70E28162C4D3EA75B09FA02F (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___cl1, intptr_t ___rFields2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumFieldsWithName(System.UInt32&,System.UInt32,System.String,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumFieldsWithName_m3BE4537A1A16D480F07182EAF8505CA3065DECD7 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___cl1, String_t* ___szName2, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rFields3, uint32_t ___cMax4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumParams(System.UInt32&,System.UInt32,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumParams_m6FD844BDC288B5223FDDB11BAA9E7993F81834A5 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___mb1, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rParams2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumMemberRefs(System.UInt32&,System.UInt32,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumMemberRefs_mC2E4668CE3080BCBEA41CADAED02A8784597D50C (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___tkParent1, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rMemberRefs2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumMethodImpls(System.UInt32&,System.UInt32,System.UInt32[],System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumMethodImpls_m5C6AA29DD2F112CF1498D95E7A6492AAD0E568AF (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___td1, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rMethodBody2, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rMethodDecl3, uint32_t ___cMax4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumPermissionSets(System.UInt32&,System.UInt32,System.UInt32,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumPermissionSets_mB788C5B0A7A87E19E01E038D6E18316A116C026B (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___tk1, uint32_t ___dwActions2, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rPermission3, uint32_t ___cMax4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::FindMember(System.UInt32,System.String,System.Byte[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_FindMember_m7EE5DE82287A447A19BF07DBF0228D0965BBD651 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, String_t* ___szName1, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___pvSigBlob2, uint32_t ___cbSigBlob3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::FindMethod(System.UInt32,System.String,System.Byte[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_FindMethod_m42BA0F0753BE955FEEA70A9063DCADCAF414CCB5 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, String_t* ___szName1, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___pvSigBlob2, uint32_t ___cbSigBlob3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::FindField(System.UInt32,System.String,System.Byte[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_FindField_m262F1EADB15B0641679BFEB654D7983AD475E6AB (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, String_t* ___szName1, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___pvSigBlob2, uint32_t ___cbSigBlob3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::FindMemberRef(System.UInt32,System.String,System.Byte[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_FindMemberRef_m9EA0475BAE1ECDA7D66FE084440C8F2C1855882A (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, String_t* ___szName1, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___pvSigBlob2, uint32_t ___cbSigBlob3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetMethodProps(System.UInt32,System.UInt32&,System.IntPtr,System.UInt32,System.UInt32&,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetMethodProps_m1B9C01E6A414B3B59574B17EBC70269C8A0EE32D (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___mb0, uint32_t* ___pClass1, intptr_t ___szMethod2, uint32_t ___cchMethod3, uint32_t* ___pchMethod4, intptr_t ___pdwAttr5, intptr_t ___ppvSigBlob6, intptr_t ___pcbSigBlob7, intptr_t ___pulCodeRVA8, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetMemberRefProps(System.UInt32,System.UInt32&,System.Text.StringBuilder,System.UInt32,System.UInt32&,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetMemberRefProps_m0B9EADE008049B508D0B3DC42A5F1A680EE0F418 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___mr0, uint32_t* ___ptk1, StringBuilder_t * ___szMember2, uint32_t ___cchMember3, uint32_t* ___pchMember4, intptr_t* ___ppvSigBlob5, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumProperties(System.UInt32&,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumProperties_m4533A4E3DC32A299E3442C3C23550F15E0E63ECB (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___td1, intptr_t ___rProperties2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumEvents(System.UInt32&,System.UInt32,System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumEvents_m72853A2A4076EF0C1CBCB5EFE7112C2ABD409F46 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___td1, intptr_t ___rEvents2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetEventProps(System.UInt32,System.UInt32&,System.Text.StringBuilder,System.UInt32,System.UInt32&,System.UInt32&,System.UInt32&,System.UInt32&,System.UInt32&,System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetEventProps_m7EE8742E0C84697A628149D120AFB39507736E64 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___ev0, uint32_t* ___pClass1, StringBuilder_t * ___szEvent2, uint32_t ___cchEvent3, uint32_t* ___pchEvent4, uint32_t* ___pdwEventFlags5, uint32_t* ___ptkEventType6, uint32_t* ___pmdAddOn7, uint32_t* ___pmdRemoveOn8, uint32_t* ___pmdFire9, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rmdOtherMethod10, uint32_t ___cMax11, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumMethodSemantics(System.UInt32&,System.UInt32,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumMethodSemantics_m0075FA77EA86AEE37C2320AEC3F6B08C2B2EF369 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___mb1, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rEventProp2, uint32_t ___cMax3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetMethodSemantics(System.UInt32,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetMethodSemantics_m5EB0DAE3D613E598F5BD65B5923B288406D295BE (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___mb0, uint32_t ___tkEventProp1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetClassLayout(System.UInt32,System.UInt32&,System.IntPtr,System.UInt32,System.UInt32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetClassLayout_m44CB2662596C044D35F9A67ADB11E7BA603E946E (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___td0, uint32_t* ___pdwPackSize1, intptr_t ___rFieldOffset2, uint32_t ___cMax3, uint32_t* ___pcFieldOffset4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetFieldMarshal(System.UInt32,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetFieldMarshal_m6980FDCD3F5FCADCCD4E97DE4414715F5B53241C (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, intptr_t* ___ppvNativeType1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetRVA(System.UInt32,System.UInt32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetRVA_m0313555D282013CD3845A94ADD5F73870BC26BA6 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, uint32_t* ___pulCodeRVA1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetPermissionSetProps(System.UInt32,System.UInt32&,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetPermissionSetProps_m127B73D4B8B41DA6ADBF6EA9B7E6A2203B7D3D74 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___pm0, uint32_t* ___pdwAction1, intptr_t* ___ppvPermission2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetSigFromToken(System.UInt32,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetSigFromToken_m62E448B153354512306218FE76725E51942C7BE9 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___mdSig0, intptr_t* ___ppvSig1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetModuleRefProps(System.UInt32,System.Text.StringBuilder,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetModuleRefProps_m77439DCF75B06ECB0C86B7779238FDBB40313FAA (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___mur0, StringBuilder_t * ___szName1, uint32_t ___cchName2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumModuleRefs(System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumModuleRefs_m0C671A8EB7E6C3E7FD5D212CF9EAD5DDD10EA515 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rModuleRefs1, uint32_t ___cmax2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetTypeSpecFromToken(System.UInt32,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetTypeSpecFromToken_mA395F51D033FA6F1474D7A6213D644182AC211DE (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___typespec0, intptr_t* ___ppvSig1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetNameFromToken(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetNameFromToken_mCD993F06BF8B99F870C096AC36465E518D3989B4 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumUnresolvedMethods(System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumUnresolvedMethods_m12DAE83A0F52FCA1C455D84341EE100A55323D2A (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rMethods1, uint32_t ___cMax2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetUserString(System.UInt32,System.Text.StringBuilder,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetUserString_m2453D2B0AA690CD31F24F234AA8C0A24DEC968A2 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___stk0, StringBuilder_t * ___szString1, uint32_t ___cchString2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetPinvokeMap(System.UInt32,System.UInt32&,System.Text.StringBuilder,System.UInt32,System.UInt32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetPinvokeMap_m725351EBD64769D5300EA6DF6B033DBF67A4AD59 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, uint32_t* ___pdwMappingFlags1, StringBuilder_t * ___szImportName2, uint32_t ___cchImportName3, uint32_t* ___pchImportName4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumSignatures(System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumSignatures_mAE082EBB1598FB73907D7ED931DB308999219F3E (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rSignatures1, uint32_t ___cmax2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumTypeSpecs(System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumTypeSpecs_m41FD0143EC73DCD8748B1C650D6B74E7B2D069B1 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rTypeSpecs1, uint32_t ___cmax2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumUserStrings(System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumUserStrings_m4FDD59E6AED5C1A4BD3F05A4638F30D40C9FDAA6 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rStrings1, uint32_t ___cmax2, const RuntimeMethod* method);
// System.Int32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetParamForMethodIndex(System.UInt32,System.UInt32,System.UInt32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ModuleMetadata_GetParamForMethodIndex_m3DB063D699D066EB05D40B8AEB238E64847B6D5B (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___md0, uint32_t ___ulParamSeq1, uint32_t* ___pParam2, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::EnumCustomAttributes(System.UInt32&,System.UInt32,System.UInt32,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_EnumCustomAttributes_mAF72A119C72785CADFF9E930FC1D1CB37CCEE564 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t* ___phEnum0, uint32_t ___tk1, uint32_t ___tkType2, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rCustomAttributes3, uint32_t ___cMax4, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetCustomAttributeProps(System.UInt32,System.UInt32&,System.UInt32&,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetCustomAttributeProps_m8CBCB5AACCA35D02602F75B4D4CFAD923DFDF6BE (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___cv0, uint32_t* ___ptkObj1, uint32_t* ___ptkType2, intptr_t* ___ppBlob3, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::FindTypeRef(System.UInt32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_FindTypeRef_m23708968A3C6272E43649656C855D07082D8B4B8 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tkResolutionScope0, String_t* ___szName1, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetMemberProps(System.UInt32,System.UInt32&,System.Text.StringBuilder,System.UInt32,System.UInt32&,System.UInt32&,System.IntPtr&,System.UInt32&,System.UInt32&,System.UInt32&,System.UInt32&,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetMemberProps_mF9FEDD1237317F6118B41C9FC86174A946DDA6F2 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___mb0, uint32_t* ___pClass1, StringBuilder_t * ___szMember2, uint32_t ___cchMember3, uint32_t* ___pchMember4, uint32_t* ___pdwAttr5, intptr_t* ___ppvSigBlob6, uint32_t* ___pcbSigBlob7, uint32_t* ___pulCodeRVA8, uint32_t* ___pdwImplFlags9, uint32_t* ___pdwCPlusTypeFlag10, intptr_t* ___ppValue11, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetFieldProps(System.UInt32,System.UInt32&,System.Text.StringBuilder,System.UInt32,System.UInt32&,System.UInt32&,System.IntPtr&,System.UInt32&,System.UInt32&,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetFieldProps_m064369EFBC50B28BBC7305E5FD3DF94300016607 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___mb0, uint32_t* ___pClass1, StringBuilder_t * ___szField2, uint32_t ___cchField3, uint32_t* ___pchField4, uint32_t* ___pdwAttr5, intptr_t* ___ppvSigBlob6, uint32_t* ___pcbSigBlob7, uint32_t* ___pdwCPlusTypeFlag8, intptr_t* ___ppValue9, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetPropertyProps(System.UInt32,System.UInt32&,System.Text.StringBuilder,System.UInt32,System.UInt32&,System.UInt32&,System.IntPtr&,System.UInt32&,System.UInt32&,System.IntPtr&,System.UInt32&,System.UInt32&,System.UInt32&,System.UInt32[],System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetPropertyProps_m5548B4DBAD3B1D537A8F0F96FD24F921113FAD9D (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___prop0, uint32_t* ___pClass1, StringBuilder_t * ___szProperty2, uint32_t ___cchProperty3, uint32_t* ___pchProperty4, uint32_t* ___pdwPropFlags5, intptr_t* ___ppvSig6, uint32_t* ___pbSig7, uint32_t* ___pdwCPlusTypeFlag8, intptr_t* ___ppDefaultValue9, uint32_t* ___pcchDefaultValue10, uint32_t* ___pmdSetter11, uint32_t* ___pmdGetter12, UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___rmdOtherMethod13, uint32_t ___cMax14, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetParamProps(System.UInt32,System.UInt32&,System.UInt32&,System.Text.StringBuilder,System.UInt32,System.UInt32&,System.UInt32&,System.UInt32&,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetParamProps_m34DA97A53F54A1A49319A974547D05859277DFB7 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, uint32_t* ___pmd1, uint32_t* ___pulSequence2, StringBuilder_t * ___szName3, uint32_t ___cchName4, uint32_t* ___pchName5, uint32_t* ___pdwAttr6, uint32_t* ___pdwCPlusTypeFlag7, intptr_t* ___ppValue8, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetCustomAttributeByName(System.UInt32,System.String,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetCustomAttributeByName_mD7458B3E94547946BE2826674EFF43C7E9E07B44 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tkObj0, String_t* ___szName1, intptr_t* ___ppData2, const RuntimeMethod* method);
// System.Boolean ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::IsValidToken(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ModuleMetadata_IsValidToken_m4C93614019DBD3A23C337D57D9069A40790AA9B3 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tk0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetNestedClassProps(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetNestedClassProps_m2D55A3CEA1473A7B5981D2FE7E02A2F9C1B6AD28 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___tdNestedClass0, const RuntimeMethod* method);
// System.UInt32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::GetNativeCallConvFromSig(System.IntPtr,System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t ModuleMetadata_GetNativeCallConvFromSig_m608382D7524F23E3412E06AD0CFC45C72307A890 (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, intptr_t ___pvSig0, uint32_t ___cbSig1, const RuntimeMethod* method);
// System.Int32 ILRuntime.Mono.Cecil.Pdb.ModuleMetadata::IsGlobal(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ModuleMetadata_IsGlobal_m860D06D448CAE8596A5AC159ECAB3C5F093C5F8B (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __this, uint32_t ___pd0, const RuntimeMethod* method);

// COM Callable Wrapper for ILRuntime.Mono.Cecil.Pdb.ModuleMetadata
struct ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4_ComCallableWrapper IL2CPP_FINAL : il2cpp::vm::CachedCCWBase<ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4_ComCallableWrapper>, IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81, IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7
{
	inline ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4_ComCallableWrapper(RuntimeObject* obj) : il2cpp::vm::CachedCCWBase<ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4_ComCallableWrapper>(obj) {}

	virtual il2cpp_hresult_t STDCALL QueryInterface(const Il2CppGuid& iid, void** object) IL2CPP_OVERRIDE
	{
		if (::memcmp(&iid, &Il2CppIUnknown::IID, sizeof(Il2CppGuid)) == 0
		 || ::memcmp(&iid, &Il2CppIInspectable::IID, sizeof(Il2CppGuid)) == 0
		 || ::memcmp(&iid, &Il2CppIAgileObject::IID, sizeof(Il2CppGuid)) == 0)
		{
			*object = GetIdentity();
			AddRefImpl();
			return IL2CPP_S_OK;
		}

		if (::memcmp(&iid, &Il2CppIManagedObjectHolder::IID, sizeof(Il2CppGuid)) == 0)
		{
			*object = static_cast<Il2CppIManagedObjectHolder*>(this);
			AddRefImpl();
			return IL2CPP_S_OK;
		}

		if (::memcmp(&iid, &IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81::IID, sizeof(Il2CppGuid)) == 0)
		{
			*object = static_cast<IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81*>(this);
			AddRefImpl();
			return IL2CPP_S_OK;
		}

		if (::memcmp(&iid, &IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7::IID, sizeof(Il2CppGuid)) == 0)
		{
			*object = static_cast<IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7*>(this);
			AddRefImpl();
			return IL2CPP_S_OK;
		}

		if (::memcmp(&iid, &Il2CppIMarshal::IID, sizeof(Il2CppGuid)) == 0)
		{
			*object = static_cast<Il2CppIMarshal*>(this);
			AddRefImpl();
			return IL2CPP_S_OK;
		}

		if (::memcmp(&iid, &Il2CppIWeakReferenceSource::IID, sizeof(Il2CppGuid)) == 0)
		{
			*object = static_cast<Il2CppIWeakReferenceSource*>(this);
			AddRefImpl();
			return IL2CPP_S_OK;
		}

		*object = NULL;
		return IL2CPP_E_NOINTERFACE;
	}

	virtual uint32_t STDCALL AddRef() IL2CPP_OVERRIDE
	{
		return AddRefImpl();
	}

	virtual uint32_t STDCALL Release() IL2CPP_OVERRIDE
	{
		return ReleaseImpl();
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetModuleProps_m428F107DD93C43F24692851DCE795029214AC7D7(Il2CppChar* ___szName0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName0' to managed representation
		String_t* ____szName0_unmarshaled = NULL;
		____szName0_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName0);

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetModuleProps_m870FEA9B534889361342B79CD67229BE4F9368F8(__thisValue, ____szName0_unmarshaled, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_Save_mE804F7EB997C4BA45116B13978B826562B3A3160(Il2CppChar* ___szFile0, uint32_t ___dwSaveFlags1) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szFile0' to managed representation
		String_t* ____szFile0_unmarshaled = NULL;
		____szFile0_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szFile0);

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_Save_m7B76D32D3485D76F4600D2277D427B02D5FA4A7F(__thisValue, ____szFile0_unmarshaled, ___dwSaveFlags1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SaveToStream_mA4F0168C0937FC1BD10C3CCC5FB55D08A1B7948E(intptr_t ___pIStream0, uint32_t ___dwSaveFlags1) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SaveToStream_m79CD379CBE755B50D9C39513812570F3272336B1(__thisValue, ___pIStream0, ___dwSaveFlags1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_GetSaveSize_m9EAF6C68D7D1FB9A02FBAB691D8993417D7E8FD9(uint32_t ___fSave0, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetSaveSize_mA5145C0B78B32AD618A86E32E170C04ED1CDC3F6(__thisValue, ___fSave0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineTypeDef_m1E9503C46F7FE9DADF02D002B78507832B3F001F(intptr_t ___szTypeDef0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineTypeDef_mE72337D3C7B048E4F5EE6B69CBA1B2BA53F2B4EE(__thisValue, ___szTypeDef0, ___dwTypeDefFlags1, ___tkExtends2, ___rtkImplements3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineNestedType_m1081E742FCEBE00911B37FE450EEB669FCC6B52B(intptr_t ___szTypeDef0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3, uint32_t ___tdEncloser4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineNestedType_mDBDA737A99A2487B67D82F9D291924192014A114(__thisValue, ___szTypeDef0, ___dwTypeDefFlags1, ___tkExtends2, ___rtkImplements3, ___tdEncloser4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetHandler_m76C1ABE93FE23BD2C0C7F9DAB84B136CE1521DAC(Il2CppIUnknown* ___pUnk0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Il2CppComObject_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pUnk0' to managed representation
		RuntimeObject * ____pUnk0_unmarshaled = NULL;
		if (___pUnk0 != NULL)
		{
			____pUnk0_unmarshaled = il2cpp_codegen_com_get_or_create_rcw_from_iunknown<RuntimeObject>(___pUnk0, Il2CppComObject_il2cpp_TypeInfo_var);

			if (il2cpp_codegen_is_import_or_windows_runtime(____pUnk0_unmarshaled))
			{
				il2cpp_codegen_com_cache_queried_interface(static_cast<Il2CppComObject*>(____pUnk0_unmarshaled), Il2CppIUnknown::IID, ___pUnk0);
			}
		}
		else
		{
			____pUnk0_unmarshaled = NULL;
		}

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetHandler_m78B5A574B9EA32CB0FDE81697388D16D880BBE2D(__thisValue, ____pUnk0_unmarshaled, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineMethod_m138F65EF24164975244105C1B01C6F43530170EC(uint32_t ___td0, intptr_t ___zName1, uint32_t ___dwMethodFlags2, intptr_t ___pvSigBlob3, uint32_t ___cbSigBlob4, uint32_t ___ulCodeRVA5, uint32_t ___dwImplFlags6, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineMethod_mD0F607CF7D28B1ED1E76361660A8FB1483F72753(__thisValue, ___td0, ___zName1, ___dwMethodFlags2, ___pvSigBlob3, ___cbSigBlob4, ___ulCodeRVA5, ___dwImplFlags6, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineMethodImpl_m1B726C0B328A7F8DEF172E117BEA79580C2C8C18(uint32_t ___td0, uint32_t ___tkBody1, uint32_t ___tkDecl2) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_DefineMethodImpl_m3F8848FFA1DABBDA540E70E8C44EC4C508ACAA43(__thisValue, ___td0, ___tkBody1, ___tkDecl2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineTypeRefByName_mA68949DEA4480E31AD1B16547D0B21E57DF1CDAB(uint32_t ___tkResolutionScope0, intptr_t ___szName1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineTypeRefByName_m94444FA2ED4B161FFC37F405DBB2246B841A684A(__thisValue, ___tkResolutionScope0, ___szName1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineImportType_mD9606074271F9BFF8F4D9FDB1FDEBE500B750FB9(intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7* ___pImport3, uint32_t ___tdImport4, intptr_t ___pAssemEmit5, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Il2CppComObject_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pImport3' to managed representation
		RuntimeObject* ____pImport3_unmarshaled = NULL;
		if (___pImport3 != NULL)
		{
			____pImport3_unmarshaled = il2cpp_codegen_com_get_or_create_rcw_from_iunknown<RuntimeObject>(___pImport3, Il2CppComObject_il2cpp_TypeInfo_var);

			if (il2cpp_codegen_is_import_or_windows_runtime(____pImport3_unmarshaled))
			{
				il2cpp_codegen_com_cache_queried_interface(static_cast<Il2CppComObject*>(____pImport3_unmarshaled), IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7::IID, ___pImport3);
			}
		}
		else
		{
			____pImport3_unmarshaled = NULL;
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineImportType_m34E4E97230EF346815013547FA94B3EAF760ECAD(__thisValue, ___pAssemImport0, ___pbHashValue1, ___cbHashValue2, ____pImport3_unmarshaled, ___tdImport4, ___pAssemEmit5, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineMemberRef_m9C8B0A3499696D414E0086770333B70296371526(uint32_t ___tkImport0, Il2CppChar* ___szName1, intptr_t ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineMemberRef_m13EDBACB40BBAA8F42AC09E7836F32B800B321A9(__thisValue, ___tkImport0, ____szName1_unmarshaled, ___pvSigBlob2, ___cbSigBlob3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineImportMember_m682F2EB868F35476443237FB3EE545EBD7E7F99C(intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7* ___pImport3, uint32_t ___mbMember4, intptr_t ___pAssemEmit5, uint32_t ___tkParent6, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Il2CppComObject_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pImport3' to managed representation
		RuntimeObject* ____pImport3_unmarshaled = NULL;
		if (___pImport3 != NULL)
		{
			____pImport3_unmarshaled = il2cpp_codegen_com_get_or_create_rcw_from_iunknown<RuntimeObject>(___pImport3, Il2CppComObject_il2cpp_TypeInfo_var);

			if (il2cpp_codegen_is_import_or_windows_runtime(____pImport3_unmarshaled))
			{
				il2cpp_codegen_com_cache_queried_interface(static_cast<Il2CppComObject*>(____pImport3_unmarshaled), IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7::IID, ___pImport3);
			}
		}
		else
		{
			____pImport3_unmarshaled = NULL;
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineImportMember_m3EF589A409CC15380957787BC9573270F0EA6260(__thisValue, ___pAssemImport0, ___pbHashValue1, ___cbHashValue2, ____pImport3_unmarshaled, ___mbMember4, ___pAssemEmit5, ___tkParent6, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineEvent_mB27FBA2466EA3F062D3EDF55C7792A711797C806(uint32_t ___td0, Il2CppChar* ___szEvent1, uint32_t ___dwEventFlags2, uint32_t ___tkEventType3, uint32_t ___mdAddOn4, uint32_t ___mdRemoveOn5, uint32_t ___mdFire6, intptr_t ___rmdOtherMethods7, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szEvent1' to managed representation
		String_t* ____szEvent1_unmarshaled = NULL;
		____szEvent1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szEvent1);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineEvent_m8F4712CBCC0E73E810697239925D0A6A10FB1FBB(__thisValue, ___td0, ____szEvent1_unmarshaled, ___dwEventFlags2, ___tkEventType3, ___mdAddOn4, ___mdRemoveOn5, ___mdFire6, ___rmdOtherMethods7, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetClassLayout_mCE406E506288289DFAF0C4A60FA1E32D2478FD5F(uint32_t ___td0, uint32_t ___dwPackSize1, intptr_t ___rFieldOffsets2, uint32_t ___ulClassSize3) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetClassLayout_m30FA07A7155FC1808B0720CE29F3982354ABD75B(__thisValue, ___td0, ___dwPackSize1, ___rFieldOffsets2, ___ulClassSize3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DeleteClassLayout_m3111901F8556D501BA8F6105EB791711A7EA0435(uint32_t ___td0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_DeleteClassLayout_m9C2AE6BC79A4BCB2C9E2227CE9D0985146319FFB(__thisValue, ___td0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetFieldMarshal_m8715001313B08A0CD7B65B945BB773E28A84C33D(uint32_t ___tk0, intptr_t ___pvNativeType1, uint32_t ___cbNativeType2) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetFieldMarshal_m968CB7A034027B55726C6CF3C850335E525C1A39(__thisValue, ___tk0, ___pvNativeType1, ___cbNativeType2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DeleteFieldMarshal_mF1E0735A8DDD78C83EF09A825B1EFD7EEDEDE4BF(uint32_t ___tk0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_DeleteFieldMarshal_m45DE3FECD27D95A2CDB1B9A70742E336DBC4357E(__thisValue, ___tk0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefinePermissionSet_mB926BF1FEE17B8CD923D9ACB3753A56026607DEE(uint32_t ___tk0, uint32_t ___dwAction1, intptr_t ___pvPermission2, uint32_t ___cbPermission3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefinePermissionSet_mE1EAB4DB94DD2858BC998DA1CEA96F309BEFDE15(__thisValue, ___tk0, ___dwAction1, ___pvPermission2, ___cbPermission3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetRVA_m9417D98488FEE6C27219E323397D5B0DF78D4A38(uint32_t ___md0, uint32_t ___ulRVA1) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetRVA_mF01957F751E47441DDCA4784711414BB8F17D305(__thisValue, ___md0, ___ulRVA1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_GetTokenFromSig_m98824B863F407334D1D6BE6D4BFAE32CE3A78AC0(intptr_t ___pvSig0, uint32_t ___cbSig1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetTokenFromSig_m25395E14E0205692BB6187CD90F80B16E4A70D25(__thisValue, ___pvSig0, ___cbSig1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineModuleRef_m081E203DECD2774837D61D91EF90E326A4A9BD13(Il2CppChar* ___szName0, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName0' to managed representation
		String_t* ____szName0_unmarshaled = NULL;
		____szName0_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName0);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineModuleRef_m2C460770FD7BB935957317F75AB2A6319C8A6C45(__thisValue, ____szName0_unmarshaled, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetParent_m41DA57DBB32F270EA762F970DC9B4E23530F09CF(uint32_t ___mr0, uint32_t ___tk1) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetParent_m2BB1AD64ADD3309283EA0A6404BFA4D3295DC14E(__thisValue, ___mr0, ___tk1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_GetTokenFromTypeSpec_m0BEB2E3908A459EAFAE24144C3C247C934227EA5(intptr_t ___pvSig0, uint32_t ___cbSig1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetTokenFromTypeSpec_mE976A60FF4C84D79241D41565AD376173B7D0272(__thisValue, ___pvSig0, ___cbSig1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SaveToMemory_mD5E2C921263CCE12558E4046236B755687752B33(intptr_t ___pbData0, uint32_t ___cbData1) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SaveToMemory_m5773A6C50874211BFB2E524425030789B4BC4511(__thisValue, ___pbData0, ___cbData1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineUserString_mFA00B99748AC537A0C72680759F069B30FBA4713(Il2CppChar* ___szString0, uint32_t ___cchString1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szString0' to managed representation
		String_t* ____szString0_unmarshaled = NULL;
		____szString0_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szString0);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineUserString_mD9A65DB4130CF23ECC3450DE10824910B5163B32(__thisValue, ____szString0_unmarshaled, ___cchString1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DeleteToken_m1A5FC35889E72217493CD0DF6B81AACDCE5290B0(uint32_t ___tkObj0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_DeleteToken_mD3C05450007569AF36C578F99567291664297DD7(__thisValue, ___tkObj0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetMethodProps_m7AEAB98EE8F0FDD88100A7C3AEE3A34EF2103335(uint32_t ___md0, uint32_t ___dwMethodFlags1, uint32_t ___ulCodeRVA2, uint32_t ___dwImplFlags3) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetMethodProps_m15E04550854D6BA7B4A5C914487696A26217BB7F(__thisValue, ___md0, ___dwMethodFlags1, ___ulCodeRVA2, ___dwImplFlags3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetTypeDefProps_m651FBA9111E878682FAAED80EBB31BF2649F4F7F(uint32_t ___td0, uint32_t ___dwTypeDefFlags1, uint32_t ___tkExtends2, intptr_t ___rtkImplements3) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetTypeDefProps_mB9670FC0501B2AD0144C17C8AF3BB1706BC35524(__thisValue, ___td0, ___dwTypeDefFlags1, ___tkExtends2, ___rtkImplements3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetEventProps_m47F86B05E39617565C1C21455135E8D148D60247(uint32_t ___ev0, uint32_t ___dwEventFlags1, uint32_t ___tkEventType2, uint32_t ___mdAddOn3, uint32_t ___mdRemoveOn4, uint32_t ___mdFire5, intptr_t ___rmdOtherMethods6) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetEventProps_mF71560311A26433B9FFD74D11CDBC018AC70D742(__thisValue, ___ev0, ___dwEventFlags1, ___tkEventType2, ___mdAddOn3, ___mdRemoveOn4, ___mdFire5, ___rmdOtherMethods6, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetPermissionSetProps_m9A4DAF6B694FD6564D8F0E8D8051E6704612E33C(uint32_t ___tk0, uint32_t ___dwAction1, intptr_t ___pvPermission2, uint32_t ___cbPermission3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_SetPermissionSetProps_m32E974759BD5761D535D37751D85C79A0111F413(__thisValue, ___tk0, ___dwAction1, ___pvPermission2, ___cbPermission3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefinePinvokeMap_m133544D3BD05A2CF74FE28E43459298889D6AA1C(uint32_t ___tk0, uint32_t ___dwMappingFlags1, Il2CppChar* ___szImportName2, uint32_t ___mrImportDLL3) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szImportName2' to managed representation
		String_t* ____szImportName2_unmarshaled = NULL;
		____szImportName2_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szImportName2);

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_DefinePinvokeMap_mE683CFA75A1AB0D26D4E8E96C0A83EFFDD850FC8(__thisValue, ___tk0, ___dwMappingFlags1, ____szImportName2_unmarshaled, ___mrImportDLL3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetPinvokeMap_m41C7DACC086059BB3B6E66035C1D157E82868A78(uint32_t ___tk0, uint32_t ___dwMappingFlags1, Il2CppChar* ___szImportName2, uint32_t ___mrImportDLL3) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szImportName2' to managed representation
		String_t* ____szImportName2_unmarshaled = NULL;
		____szImportName2_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szImportName2);

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetPinvokeMap_m3386070EFA7CFDE274FC469ACC76DFAFE6A3646D(__thisValue, ___tk0, ___dwMappingFlags1, ____szImportName2_unmarshaled, ___mrImportDLL3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DeletePinvokeMap_mD545E014B9EBBD62902440F02C5B0D80CC806D4F(uint32_t ___tk0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_DeletePinvokeMap_mC3B131971008DDCE2FD6519CA6B596CF9C954AAC(__thisValue, ___tk0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineCustomAttribute_m6928A7D4D651E3AA223D564697F71D59D5507899(uint32_t ___tkObj0, uint32_t ___tkType1, intptr_t ___pCustomAttribute2, uint32_t ___cbCustomAttribute3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineCustomAttribute_m605064E11CD706E49828A3B5DE24F8B70D8CE9D5(__thisValue, ___tkObj0, ___tkType1, ___pCustomAttribute2, ___cbCustomAttribute3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetCustomAttributeValue_m1B99B1307C7719FE2A17385931591794FCAEF86B(uint32_t ___pcv0, intptr_t ___pCustomAttribute1, uint32_t ___cbCustomAttribute2) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetCustomAttributeValue_m8CF08AE14DCF0CECA0AF53E9344972A0F2E222C0(__thisValue, ___pcv0, ___pCustomAttribute1, ___cbCustomAttribute2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineField_mE7573B0EA971B63D86CADBE52CE01271F34E6BB9(uint32_t ___td0, Il2CppChar* ___szName1, uint32_t ___dwFieldFlags2, intptr_t ___pvSigBlob3, uint32_t ___cbSigBlob4, uint32_t ___dwCPlusTypeFlag5, intptr_t ___pValue6, uint32_t ___cchValue7, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineField_mC61224F500012207B6B985E51038E5EBE6AFDEB9(__thisValue, ___td0, ____szName1_unmarshaled, ___dwFieldFlags2, ___pvSigBlob3, ___cbSigBlob4, ___dwCPlusTypeFlag5, ___pValue6, ___cchValue7, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineProperty_m06217EABD6C998235CE3C500452141592B7B0F1E(uint32_t ___td0, Il2CppChar* ___szProperty1, uint32_t ___dwPropFlags2, intptr_t ___pvSig3, uint32_t ___cbSig4, uint32_t ___dwCPlusTypeFlag5, intptr_t ___pValue6, uint32_t ___cchValue7, uint32_t ___mdSetter8, uint32_t ___mdGetter9, intptr_t ___rmdOtherMethods10, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szProperty1' to managed representation
		String_t* ____szProperty1_unmarshaled = NULL;
		____szProperty1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szProperty1);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineProperty_mF3B5872C7A0C0269EA9ABBCF8201252B10B013FE(__thisValue, ___td0, ____szProperty1_unmarshaled, ___dwPropFlags2, ___pvSig3, ___cbSig4, ___dwCPlusTypeFlag5, ___pValue6, ___cchValue7, ___mdSetter8, ___mdGetter9, ___rmdOtherMethods10, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineParam_mC511409D41C02E8C9E3B520189690B3EDE9B04DD(uint32_t ___md0, uint32_t ___ulParamSeq1, Il2CppChar* ___szName2, uint32_t ___dwParamFlags3, uint32_t ___dwCPlusTypeFlag4, intptr_t ___pValue5, uint32_t ___cchValue6, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName2' to managed representation
		String_t* ____szName2_unmarshaled = NULL;
		____szName2_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName2);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineParam_mBD4E938DED73F9FFFE94B13510FA1B16CA1E8ECD(__thisValue, ___md0, ___ulParamSeq1, ____szName2_unmarshaled, ___dwParamFlags3, ___dwCPlusTypeFlag4, ___pValue5, ___cchValue6, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetFieldProps_mE1C1B2F8EDFA27D7BFCF5770B38AB7AF098ACCB6(uint32_t ___fd0, uint32_t ___dwFieldFlags1, uint32_t ___dwCPlusTypeFlag2, intptr_t ___pValue3, uint32_t ___cchValue4) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetFieldProps_mA986916733F4C60A1A2F30EEBC39D6B05771610F(__thisValue, ___fd0, ___dwFieldFlags1, ___dwCPlusTypeFlag2, ___pValue3, ___cchValue4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetPropertyProps_mE8CEE168666047461BB5FF74C439736E10227E2B(uint32_t ___pr0, uint32_t ___dwPropFlags1, uint32_t ___dwCPlusTypeFlag2, intptr_t ___pValue3, uint32_t ___cchValue4, uint32_t ___mdSetter5, uint32_t ___mdGetter6, intptr_t ___rmdOtherMethods7) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetPropertyProps_mA7133E794F5C0F6EAEAC2C49FBE08611846EA1EB(__thisValue, ___pr0, ___dwPropFlags1, ___dwCPlusTypeFlag2, ___pValue3, ___cchValue4, ___mdSetter5, ___mdGetter6, ___rmdOtherMethods7, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetParamProps_m70DEAFEAEBA7B0AAB9BB35219A2F811BB7242AE7(uint32_t ___pd0, Il2CppChar* ___szName1, uint32_t ___dwParamFlags2, uint32_t ___dwCPlusTypeFlag3, intptr_t ___pValue4, uint32_t ___cchValue5) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetParamProps_m4C1C501A1260402E0C90CB87B6DD1D90790BED0F(__thisValue, ___pd0, ____szName1_unmarshaled, ___dwParamFlags2, ___dwCPlusTypeFlag3, ___pValue4, ___cchValue5, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_DefineSecurityAttributeSet_m87EC2148918CC382B03D11135C857821CE7C159B(uint32_t ___tkObj0, intptr_t ___rSecAttrs1, uint32_t ___cSecAttrs2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_DefineSecurityAttributeSet_m524C06ED98FD33ABEFB602E4FD8C6800BC693CF9(__thisValue, ___tkObj0, ___rSecAttrs1, ___cSecAttrs2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_ApplyEditAndContinue_mFE4B9FDEA9B174AA4FDDD212BD2B1FE70596F323(Il2CppIUnknown* ___pImport0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Il2CppComObject_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pImport0' to managed representation
		RuntimeObject * ____pImport0_unmarshaled = NULL;
		if (___pImport0 != NULL)
		{
			____pImport0_unmarshaled = il2cpp_codegen_com_get_or_create_rcw_from_iunknown<RuntimeObject>(___pImport0, Il2CppComObject_il2cpp_TypeInfo_var);

			if (il2cpp_codegen_is_import_or_windows_runtime(____pImport0_unmarshaled))
			{
				il2cpp_codegen_com_cache_queried_interface(static_cast<Il2CppComObject*>(____pImport0_unmarshaled), Il2CppIUnknown::IID, ___pImport0);
			}
		}
		else
		{
			____pImport0_unmarshaled = NULL;
		}

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_ApplyEditAndContinue_mC7ED2E1CC1DA2D730B69A79FBE17A0C0F5D6C391(__thisValue, ____pImport0_unmarshaled, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_TranslateSigWithScope_m5D54B1DA1CE22BB4D509A9BE2E00A042528B37CB(intptr_t ___pAssemImport0, intptr_t ___pbHashValue1, uint32_t ___cbHashValue2, IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7* ___import3, intptr_t ___pbSigBlob4, uint32_t ___cbSigBlob5, intptr_t ___pAssemEmit6, IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81* ___emit7, intptr_t ___pvTranslatedSig8, uint32_t ___cbTranslatedSigMax9, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Il2CppComObject_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___import3' to managed representation
		RuntimeObject* ____import3_unmarshaled = NULL;
		if (___import3 != NULL)
		{
			____import3_unmarshaled = il2cpp_codegen_com_get_or_create_rcw_from_iunknown<RuntimeObject>(___import3, Il2CppComObject_il2cpp_TypeInfo_var);

			if (il2cpp_codegen_is_import_or_windows_runtime(____import3_unmarshaled))
			{
				il2cpp_codegen_com_cache_queried_interface(static_cast<Il2CppComObject*>(____import3_unmarshaled), IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7::IID, ___import3);
			}
		}
		else
		{
			____import3_unmarshaled = NULL;
		}

		// Marshaling of parameter '___emit7' to managed representation
		RuntimeObject* ____emit7_unmarshaled = NULL;
		if (___emit7 != NULL)
		{
			____emit7_unmarshaled = il2cpp_codegen_com_get_or_create_rcw_from_iunknown<RuntimeObject>(___emit7, Il2CppComObject_il2cpp_TypeInfo_var);

			if (il2cpp_codegen_is_import_or_windows_runtime(____emit7_unmarshaled))
			{
				il2cpp_codegen_com_cache_queried_interface(static_cast<Il2CppComObject*>(____emit7_unmarshaled), IMetaDataEmit_tBC3A20171CE781FF1D9449EBC2250AAFB65C3C81::IID, ___emit7);
			}
		}
		else
		{
			____emit7_unmarshaled = NULL;
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_TranslateSigWithScope_mEAC6C9F621D2DE5CE64BD9DBBC660C0A136D8A82(__thisValue, ___pAssemImport0, ___pbHashValue1, ___cbHashValue2, ____import3_unmarshaled, ___pbSigBlob4, ___cbSigBlob5, ___pAssemEmit6, ____emit7_unmarshaled, ___pvTranslatedSig8, ___cbTranslatedSigMax9, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetMethodImplFlags_mDFC9FA3484E420DCB33F9A40920870E1CF72595D(uint32_t ___md0, uint32_t ___dwImplFlags1) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetMethodImplFlags_m84296E755B28FA88225692EB2DBB03C70C64D2FA(__thisValue, ___md0, ___dwImplFlags1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_SetFieldRVA_m81749123FD373FAFBAFF29BB0D14E61157ACB726(uint32_t ___fd0, uint32_t ___ulRVA1) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_SetFieldRVA_mEA445E624F4738E74E833839BB76663CB3140FFE(__thisValue, ___fd0, ___ulRVA1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_Merge_mBE4C155C791000950970868AF71A82B7D9122AF8(IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7* ___pImport0, intptr_t ___pHostMapToken1, Il2CppIUnknown* ___pHandler2) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Il2CppComObject_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pImport0' to managed representation
		RuntimeObject* ____pImport0_unmarshaled = NULL;
		if (___pImport0 != NULL)
		{
			____pImport0_unmarshaled = il2cpp_codegen_com_get_or_create_rcw_from_iunknown<RuntimeObject>(___pImport0, Il2CppComObject_il2cpp_TypeInfo_var);

			if (il2cpp_codegen_is_import_or_windows_runtime(____pImport0_unmarshaled))
			{
				il2cpp_codegen_com_cache_queried_interface(static_cast<Il2CppComObject*>(____pImport0_unmarshaled), IMetaDataImport_t13408107DE601C48192B2DA2B3BD4234193CD1B7::IID, ___pImport0);
			}
		}
		else
		{
			____pImport0_unmarshaled = NULL;
		}

		// Marshaling of parameter '___pHandler2' to managed representation
		RuntimeObject * ____pHandler2_unmarshaled = NULL;
		if (___pHandler2 != NULL)
		{
			____pHandler2_unmarshaled = il2cpp_codegen_com_get_or_create_rcw_from_iunknown<RuntimeObject>(___pHandler2, Il2CppComObject_il2cpp_TypeInfo_var);

			if (il2cpp_codegen_is_import_or_windows_runtime(____pHandler2_unmarshaled))
			{
				il2cpp_codegen_com_cache_queried_interface(static_cast<Il2CppComObject*>(____pHandler2_unmarshaled), Il2CppIUnknown::IID, ___pHandler2);
			}
		}
		else
		{
			____pHandler2_unmarshaled = NULL;
		}

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_Merge_m608D3180C648DA67F7D67D4F86CDB549ADC2A8C5(__thisValue, ____pImport0_unmarshaled, ___pHostMapToken1, ____pHandler2_unmarshaled, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataEmit_MergeEnd_m9C370016EE3CEFD6707BA868DC17D672FEC8801B() IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_MergeEnd_m4C0B630B3BA7ABAB1E1C6E0F6293F0C84410F64C(__thisValue, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual void STDCALL IMetaDataImport_CloseEnum_m0D3899A02EBD1119C75C586BB2E5CE9AE08D0EC8(uint32_t ___hEnum0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_CloseEnum_mAE0F83C4DA54B0ABC6A310498DC61C12467633F5(__thisValue, ___hEnum0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
		}

	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_CountEnum_m37E1477ACB8395D410EBAB42D50008B234921D4B(uint32_t ___hEnum0, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_CountEnum_m0A508E9DF87C43C3E530BD6AB555C0C83A37F0B0(__thisValue, ___hEnum0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_ResetEnum_mCE5B33001D1295A5DAE35818695B096DCD62EA22(uint32_t ___hEnum0, uint32_t ___ulPos1) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			ModuleMetadata_ResetEnum_mA615369B0432CE053B4453500AFB182EC714C721(__thisValue, ___hEnum0, ___ulPos1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumTypeDefs_m62882BB551D53AF5ACFA42A37B3D84FE3B84C79C(uint32_t* ___phEnum0, uint32_t* ___rTypeDefs1, uint32_t ___cMax2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rTypeDefs1' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rTypeDefs1_unmarshaled = NULL;
		if (___rTypeDefs1 != NULL)
		{
			____rTypeDefs1_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax2)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax2)); i++)
			{
				(____rTypeDefs1_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rTypeDefs1)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumTypeDefs_m8FFA21F10D64CDDF4A22BBFE076A477319391E6D(__thisValue, ___phEnum0, ____rTypeDefs1_unmarshaled, ___cMax2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumInterfaceImpls_m41A161BCB8D5307ACD83A9BE015BC2F62638B074(uint32_t* ___phEnum0, uint32_t ___td1, uint32_t* ___rImpls2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rImpls2' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rImpls2_unmarshaled = NULL;
		if (___rImpls2 != NULL)
		{
			____rImpls2_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax3)); i++)
			{
				(____rImpls2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rImpls2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumInterfaceImpls_m5333F1974961AC64F477B07C37A40F2CF1DAA079(__thisValue, ___phEnum0, ___td1, ____rImpls2_unmarshaled, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumTypeRefs_m18602762DD0D6B88E10410692887720E68BCBE87(uint32_t* ___phEnum0, uint32_t* ___rTypeRefs1, uint32_t ___cMax2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rTypeRefs1' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rTypeRefs1_unmarshaled = NULL;
		if (___rTypeRefs1 != NULL)
		{
			____rTypeRefs1_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax2)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax2)); i++)
			{
				(____rTypeRefs1_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rTypeRefs1)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumTypeRefs_mB6787E85B157251D6FA49B6FBBBBDF344917664E(__thisValue, ___phEnum0, ____rTypeRefs1_unmarshaled, ___cMax2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindTypeDefByName_mAD3D7DCC51EA3C9ACBCC521B19E3C4FC9DFFA6E3(Il2CppChar* ___szTypeDef0, uint32_t ___tkEnclosingClass1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szTypeDef0' to managed representation
		String_t* ____szTypeDef0_unmarshaled = NULL;
		____szTypeDef0_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szTypeDef0);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_FindTypeDefByName_m7071A9946B8B2908E0F21F4760DDFA3EDCBD4E84(__thisValue, ____szTypeDef0_unmarshaled, ___tkEnclosingClass1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetScopeProps_mCF342F004A59F0470CE8F1D3053BF2B314B8A47C(Il2CppChar* ___szName0, uint32_t ___cchName1, uint32_t* ___pchName2, Guid_t * comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName0' to managed representation
		StringBuilder_t * ____szName0_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szName0_unmarshaled, ___szName0);

		// Marshaling of parameter '___pchName2' to managed representation
		uint32_t ____pchName2_empty = 0;

		// Managed method invocation
		Guid_t  returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetScopeProps_mB6FA1BD8309D6F7C491640ACA926B1A4DF0FBD7D(__thisValue, ____szName0_unmarshaled, ___cchName1, (&____pchName2_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pchName2' back from managed representation
		*___pchName2 = ____pchName2_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetModuleFromScope_mB2863368EC2DAEBEFB6F18C4101CE1CF2428F7B6(uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetModuleFromScope_mED04B885FB81C0DD9247680D2F55B7ABCC3F27DB(__thisValue, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetTypeDefProps_m0FC61C17845D7B0F3D246EA3A9761DF7242B4841(uint32_t ___td0, intptr_t ___szTypeDef1, uint32_t ___cchTypeDef2, uint32_t* ___pchTypeDef3, intptr_t ___pdwTypeDefFlags4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pchTypeDef3' to managed representation
		uint32_t ____pchTypeDef3_empty = 0;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetTypeDefProps_m2E31E25570780B4CB2AEF8393323614EF5A9CC2D(__thisValue, ___td0, ___szTypeDef1, ___cchTypeDef2, (&____pchTypeDef3_empty), ___pdwTypeDefFlags4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pchTypeDef3' back from managed representation
		*___pchTypeDef3 = ____pchTypeDef3_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetInterfaceImplProps_mBA89E086C4A57EC2FA4636FFEF3BAF718F099AB1(uint32_t ___iiImpl0, uint32_t* ___pClass1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pClass1' to managed representation
		uint32_t ____pClass1_empty = 0;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetInterfaceImplProps_mCA08097B943A72EBC23076BE7F088EA15CBA5FE4(__thisValue, ___iiImpl0, (&____pClass1_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pClass1' back from managed representation
		*___pClass1 = ____pClass1_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetTypeRefProps_m2DE7BDB4F1182C8E4BBEA10C17CA35D7B7DF1FFF(uint32_t ___tr0, uint32_t* ___ptkResolutionScope1, Il2CppChar* ___szName2, uint32_t ___cchName3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___ptkResolutionScope1' to managed representation
		uint32_t ____ptkResolutionScope1_empty = 0;

		// Marshaling of parameter '___szName2' to managed representation
		StringBuilder_t * ____szName2_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szName2_unmarshaled, ___szName2);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetTypeRefProps_mB404A11734BBE6CB73C4459617D25F19074BCFC7(__thisValue, ___tr0, (&____ptkResolutionScope1_empty), ____szName2_unmarshaled, ___cchName3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___ptkResolutionScope1' back from managed representation
		*___ptkResolutionScope1 = ____ptkResolutionScope1_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_ResolveTypeRef_mF54A03D1DA37718E8D9466658E3C120444327B26(uint32_t ___tr0, Guid_t * ___riid1, Il2CppIUnknown** ___ppIScope2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___ppIScope2' to managed representation
		RuntimeObject * ____ppIScope2_empty = NULL;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_ResolveTypeRef_m37D7C1593B3761050A6D739FA843E255DEFEF832(__thisValue, ___tr0, ___riid1, (&____ppIScope2_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___ppIScope2' back from managed representation
		if (____ppIScope2_empty != NULL)
		{
			if (il2cpp_codegen_is_import_or_windows_runtime(____ppIScope2_empty))
			{
				*___ppIScope2 = il2cpp_codegen_com_query_interface<Il2CppIUnknown>(static_cast<Il2CppComObject*>(____ppIScope2_empty));
				(*___ppIScope2)->AddRef();
			}
			else
			{
				*___ppIScope2 = il2cpp_codegen_com_get_or_create_ccw<Il2CppIUnknown>(____ppIScope2_empty);
			}
		}
		else
		{
			*___ppIScope2 = NULL;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMembers_m5F86EBABC40A31C3175EF2B198A0357B6311FA91(uint32_t* ___phEnum0, uint32_t ___cl1, uint32_t* ___rMembers2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rMembers2' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rMembers2_unmarshaled = NULL;
		if (___rMembers2 != NULL)
		{
			____rMembers2_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax3)); i++)
			{
				(____rMembers2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rMembers2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumMembers_mC9D20D710AAE1B913D5FC4E078782AFDF9550212(__thisValue, ___phEnum0, ___cl1, ____rMembers2_unmarshaled, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMembersWithName_mDCECC10F43355C7C77939D444671605C439BBCD8(uint32_t* ___phEnum0, uint32_t ___cl1, Il2CppChar* ___szName2, uint32_t* ___rMembers3, uint32_t ___cMax4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName2' to managed representation
		String_t* ____szName2_unmarshaled = NULL;
		____szName2_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName2);

		// Marshaling of parameter '___rMembers3' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rMembers3_unmarshaled = NULL;
		if (___rMembers3 != NULL)
		{
			____rMembers3_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax4)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax4)); i++)
			{
				(____rMembers3_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rMembers3)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumMembersWithName_m7E8BD472B75CBEE4D4EC9DA7BC384B0F33EC26BF(__thisValue, ___phEnum0, ___cl1, ____szName2_unmarshaled, ____rMembers3_unmarshaled, ___cMax4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMethods_m06CDF2E78EE9A971361D3933E30CAA41ACC9C325(uint32_t* ___phEnum0, uint32_t ___cl1, intptr_t ___rMethods2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumMethods_m2848C10413D5C928BBBECCBE674F76CACFFCF51C(__thisValue, ___phEnum0, ___cl1, ___rMethods2, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMethodsWithName_m5B854D69051794DA621F5D4F5FE57DC093840775(uint32_t* ___phEnum0, uint32_t ___cl1, Il2CppChar* ___szName2, uint32_t* ___rMethods3, uint32_t ___cMax4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName2' to managed representation
		String_t* ____szName2_unmarshaled = NULL;
		____szName2_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName2);

		// Marshaling of parameter '___rMethods3' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rMethods3_unmarshaled = NULL;
		if (___rMethods3 != NULL)
		{
			____rMethods3_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax4)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax4)); i++)
			{
				(____rMethods3_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rMethods3)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumMethodsWithName_m311550F2826F9BDD3969CAB1CFAC0E6E443F2DDA(__thisValue, ___phEnum0, ___cl1, ____szName2_unmarshaled, ____rMethods3_unmarshaled, ___cMax4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumFields_m18BE7FB7A04CD714EF75E06A0D8AA36AFA748E1B(uint32_t* ___phEnum0, uint32_t ___cl1, intptr_t ___rFields2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumFields_m1DD5BFB0B72B7C4C70E28162C4D3EA75B09FA02F(__thisValue, ___phEnum0, ___cl1, ___rFields2, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumFieldsWithName_mAD5EB669862041BBF8FCBEDD223FA3AA82D42CA3(uint32_t* ___phEnum0, uint32_t ___cl1, Il2CppChar* ___szName2, uint32_t* ___rFields3, uint32_t ___cMax4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName2' to managed representation
		String_t* ____szName2_unmarshaled = NULL;
		____szName2_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName2);

		// Marshaling of parameter '___rFields3' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rFields3_unmarshaled = NULL;
		if (___rFields3 != NULL)
		{
			____rFields3_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax4)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax4)); i++)
			{
				(____rFields3_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rFields3)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumFieldsWithName_m3BE4537A1A16D480F07182EAF8505CA3065DECD7(__thisValue, ___phEnum0, ___cl1, ____szName2_unmarshaled, ____rFields3_unmarshaled, ___cMax4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumParams_mEDC99F5BD113EC8177A2373416D4F893D472C444(uint32_t* ___phEnum0, uint32_t ___mb1, uint32_t* ___rParams2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rParams2' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rParams2_unmarshaled = NULL;
		if (___rParams2 != NULL)
		{
			____rParams2_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax3)); i++)
			{
				(____rParams2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rParams2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumParams_m6FD844BDC288B5223FDDB11BAA9E7993F81834A5(__thisValue, ___phEnum0, ___mb1, ____rParams2_unmarshaled, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMemberRefs_m905F617215EA7A7DD2959DDFAEBA4C15A90E3A84(uint32_t* ___phEnum0, uint32_t ___tkParent1, uint32_t* ___rMemberRefs2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rMemberRefs2' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rMemberRefs2_unmarshaled = NULL;
		if (___rMemberRefs2 != NULL)
		{
			____rMemberRefs2_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax3)); i++)
			{
				(____rMemberRefs2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rMemberRefs2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumMemberRefs_mC2E4668CE3080BCBEA41CADAED02A8784597D50C(__thisValue, ___phEnum0, ___tkParent1, ____rMemberRefs2_unmarshaled, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMethodImpls_m800A1948CC075DDEB1DE3786D850B9CF4953050B(uint32_t* ___phEnum0, uint32_t ___td1, uint32_t* ___rMethodBody2, uint32_t* ___rMethodDecl3, uint32_t ___cMax4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rMethodBody2' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rMethodBody2_unmarshaled = NULL;
		if (___rMethodBody2 != NULL)
		{
			____rMethodBody2_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax4)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax4)); i++)
			{
				(____rMethodBody2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rMethodBody2)[i]);
			}
		}

		// Marshaling of parameter '___rMethodDecl3' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rMethodDecl3_unmarshaled = NULL;
		if (___rMethodDecl3 != NULL)
		{
			____rMethodDecl3_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax4)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax4)); i++)
			{
				(____rMethodDecl3_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rMethodDecl3)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumMethodImpls_m5C6AA29DD2F112CF1498D95E7A6492AAD0E568AF(__thisValue, ___phEnum0, ___td1, ____rMethodBody2_unmarshaled, ____rMethodDecl3_unmarshaled, ___cMax4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumPermissionSets_m727E46DB7B44650D4D8CE41E2029B41D14A86C60(uint32_t* ___phEnum0, uint32_t ___tk1, uint32_t ___dwActions2, uint32_t* ___rPermission3, uint32_t ___cMax4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rPermission3' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rPermission3_unmarshaled = NULL;
		if (___rPermission3 != NULL)
		{
			____rPermission3_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax4)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax4)); i++)
			{
				(____rPermission3_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rPermission3)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumPermissionSets_mB788C5B0A7A87E19E01E038D6E18316A116C026B(__thisValue, ___phEnum0, ___tk1, ___dwActions2, ____rPermission3_unmarshaled, ___cMax4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindMember_mE9F0C70F729DDEAE81316F5BD1C0B17881F80FA4(uint32_t ___td0, Il2CppChar* ___szName1, uint8_t* ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Marshaling of parameter '___pvSigBlob2' to managed representation
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____pvSigBlob2_unmarshaled = NULL;
		if (___pvSigBlob2 != NULL)
		{
			____pvSigBlob2_unmarshaled = reinterpret_cast<ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*>((ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, static_cast<int32_t>(___cbSigBlob3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cbSigBlob3)); i++)
			{
				(____pvSigBlob2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___pvSigBlob2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_FindMember_m7EE5DE82287A447A19BF07DBF0228D0965BBD651(__thisValue, ___td0, ____szName1_unmarshaled, ____pvSigBlob2_unmarshaled, ___cbSigBlob3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindMethod_m6AF98FF569DFC46F7ECFFB8C765220F8B5D14B24(uint32_t ___td0, Il2CppChar* ___szName1, uint8_t* ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Marshaling of parameter '___pvSigBlob2' to managed representation
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____pvSigBlob2_unmarshaled = NULL;
		if (___pvSigBlob2 != NULL)
		{
			____pvSigBlob2_unmarshaled = reinterpret_cast<ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*>((ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, static_cast<int32_t>(___cbSigBlob3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cbSigBlob3)); i++)
			{
				(____pvSigBlob2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___pvSigBlob2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_FindMethod_m42BA0F0753BE955FEEA70A9063DCADCAF414CCB5(__thisValue, ___td0, ____szName1_unmarshaled, ____pvSigBlob2_unmarshaled, ___cbSigBlob3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindField_m77B747283B807A87097278A782D89E4BEDA46F83(uint32_t ___td0, Il2CppChar* ___szName1, uint8_t* ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Marshaling of parameter '___pvSigBlob2' to managed representation
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____pvSigBlob2_unmarshaled = NULL;
		if (___pvSigBlob2 != NULL)
		{
			____pvSigBlob2_unmarshaled = reinterpret_cast<ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*>((ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, static_cast<int32_t>(___cbSigBlob3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cbSigBlob3)); i++)
			{
				(____pvSigBlob2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___pvSigBlob2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_FindField_m262F1EADB15B0641679BFEB654D7983AD475E6AB(__thisValue, ___td0, ____szName1_unmarshaled, ____pvSigBlob2_unmarshaled, ___cbSigBlob3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindMemberRef_mDE2D5D9046FE8F93D56D7FB9F07AAC0F57158A61(uint32_t ___td0, Il2CppChar* ___szName1, uint8_t* ___pvSigBlob2, uint32_t ___cbSigBlob3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Marshaling of parameter '___pvSigBlob2' to managed representation
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____pvSigBlob2_unmarshaled = NULL;
		if (___pvSigBlob2 != NULL)
		{
			____pvSigBlob2_unmarshaled = reinterpret_cast<ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*>((ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, static_cast<int32_t>(___cbSigBlob3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cbSigBlob3)); i++)
			{
				(____pvSigBlob2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___pvSigBlob2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_FindMemberRef_m9EA0475BAE1ECDA7D66FE084440C8F2C1855882A(__thisValue, ___td0, ____szName1_unmarshaled, ____pvSigBlob2_unmarshaled, ___cbSigBlob3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetMethodProps_m0EEE904D2726334706A46B153CF4ED8237459545(uint32_t ___mb0, uint32_t* ___pClass1, intptr_t ___szMethod2, uint32_t ___cchMethod3, uint32_t* ___pchMethod4, intptr_t ___pdwAttr5, intptr_t ___ppvSigBlob6, intptr_t ___pcbSigBlob7, intptr_t ___pulCodeRVA8, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pClass1' to managed representation
		uint32_t ____pClass1_empty = 0;

		// Marshaling of parameter '___pchMethod4' to managed representation
		uint32_t ____pchMethod4_empty = 0;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetMethodProps_m1B9C01E6A414B3B59574B17EBC70269C8A0EE32D(__thisValue, ___mb0, (&____pClass1_empty), ___szMethod2, ___cchMethod3, (&____pchMethod4_empty), ___pdwAttr5, ___ppvSigBlob6, ___pcbSigBlob7, ___pulCodeRVA8, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pClass1' back from managed representation
		*___pClass1 = ____pClass1_empty;

		// Marshaling of parameter '___pchMethod4' back from managed representation
		*___pchMethod4 = ____pchMethod4_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetMemberRefProps_mC729344ED3793124DE09E054B8A4AFE5FB43A99A(uint32_t ___mr0, uint32_t* ___ptk1, Il2CppChar* ___szMember2, uint32_t ___cchMember3, uint32_t* ___pchMember4, intptr_t* ___ppvSigBlob5, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szMember2' to managed representation
		StringBuilder_t * ____szMember2_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szMember2_unmarshaled, ___szMember2);

		// Marshaling of parameter '___pchMember4' to managed representation
		uint32_t ____pchMember4_empty = 0;

		// Marshaling of parameter '___ppvSigBlob5' to managed representation
		intptr_t ____ppvSigBlob5_empty;
		memset((&____ppvSigBlob5_empty), 0, sizeof(____ppvSigBlob5_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetMemberRefProps_m0B9EADE008049B508D0B3DC42A5F1A680EE0F418(__thisValue, ___mr0, ___ptk1, ____szMember2_unmarshaled, ___cchMember3, (&____pchMember4_empty), (&____ppvSigBlob5_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pchMember4' back from managed representation
		*___pchMember4 = ____pchMember4_empty;

		// Marshaling of parameter '___ppvSigBlob5' back from managed representation
		*___ppvSigBlob5 = ____ppvSigBlob5_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumProperties_mB3F0FA0C172162EDA52F69116ED33F39FAA2AB3A(uint32_t* ___phEnum0, uint32_t ___td1, intptr_t ___rProperties2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumProperties_m4533A4E3DC32A299E3442C3C23550F15E0E63ECB(__thisValue, ___phEnum0, ___td1, ___rProperties2, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumEvents_m4F3C3598CC8870251FB3A67E2A9B7A307B0573F8(uint32_t* ___phEnum0, uint32_t ___td1, intptr_t ___rEvents2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumEvents_m72853A2A4076EF0C1CBCB5EFE7112C2ABD409F46(__thisValue, ___phEnum0, ___td1, ___rEvents2, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetEventProps_m02B3704478EAA77E28D3678A89AAFB57E20103F7(uint32_t ___ev0, uint32_t* ___pClass1, Il2CppChar* ___szEvent2, uint32_t ___cchEvent3, uint32_t* ___pchEvent4, uint32_t* ___pdwEventFlags5, uint32_t* ___ptkEventType6, uint32_t* ___pmdAddOn7, uint32_t* ___pmdRemoveOn8, uint32_t* ___pmdFire9, uint32_t* ___rmdOtherMethod10, uint32_t ___cMax11, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pClass1' to managed representation
		uint32_t ____pClass1_empty = 0;

		// Marshaling of parameter '___szEvent2' to managed representation
		StringBuilder_t * ____szEvent2_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szEvent2_unmarshaled, ___szEvent2);

		// Marshaling of parameter '___pchEvent4' to managed representation
		uint32_t ____pchEvent4_empty = 0;

		// Marshaling of parameter '___pdwEventFlags5' to managed representation
		uint32_t ____pdwEventFlags5_empty = 0;

		// Marshaling of parameter '___ptkEventType6' to managed representation
		uint32_t ____ptkEventType6_empty = 0;

		// Marshaling of parameter '___pmdAddOn7' to managed representation
		uint32_t ____pmdAddOn7_empty = 0;

		// Marshaling of parameter '___pmdRemoveOn8' to managed representation
		uint32_t ____pmdRemoveOn8_empty = 0;

		// Marshaling of parameter '___pmdFire9' to managed representation
		uint32_t ____pmdFire9_empty = 0;

		// Marshaling of parameter '___rmdOtherMethod10' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rmdOtherMethod10_unmarshaled = NULL;
		if (___rmdOtherMethod10 != NULL)
		{
			____rmdOtherMethod10_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax11)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax11)); i++)
			{
				(____rmdOtherMethod10_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rmdOtherMethod10)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetEventProps_m7EE8742E0C84697A628149D120AFB39507736E64(__thisValue, ___ev0, (&____pClass1_empty), ____szEvent2_unmarshaled, ___cchEvent3, (&____pchEvent4_empty), (&____pdwEventFlags5_empty), (&____ptkEventType6_empty), (&____pmdAddOn7_empty), (&____pmdRemoveOn8_empty), (&____pmdFire9_empty), ____rmdOtherMethod10_unmarshaled, ___cMax11, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pClass1' back from managed representation
		*___pClass1 = ____pClass1_empty;

		// Marshaling of parameter '___pchEvent4' back from managed representation
		*___pchEvent4 = ____pchEvent4_empty;

		// Marshaling of parameter '___pdwEventFlags5' back from managed representation
		*___pdwEventFlags5 = ____pdwEventFlags5_empty;

		// Marshaling of parameter '___ptkEventType6' back from managed representation
		*___ptkEventType6 = ____ptkEventType6_empty;

		// Marshaling of parameter '___pmdAddOn7' back from managed representation
		*___pmdAddOn7 = ____pmdAddOn7_empty;

		// Marshaling of parameter '___pmdRemoveOn8' back from managed representation
		*___pmdRemoveOn8 = ____pmdRemoveOn8_empty;

		// Marshaling of parameter '___pmdFire9' back from managed representation
		*___pmdFire9 = ____pmdFire9_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumMethodSemantics_m71E1754D988748DE5DBF9D733882B6DD98BCEF12(uint32_t* ___phEnum0, uint32_t ___mb1, uint32_t* ___rEventProp2, uint32_t ___cMax3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rEventProp2' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rEventProp2_unmarshaled = NULL;
		if (___rEventProp2 != NULL)
		{
			____rEventProp2_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax3)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax3)); i++)
			{
				(____rEventProp2_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rEventProp2)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumMethodSemantics_m0075FA77EA86AEE37C2320AEC3F6B08C2B2EF369(__thisValue, ___phEnum0, ___mb1, ____rEventProp2_unmarshaled, ___cMax3, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetMethodSemantics_m7ABA0DDD69F65EF75BD832EB59555B32307A38B6(uint32_t ___mb0, uint32_t ___tkEventProp1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetMethodSemantics_m5EB0DAE3D613E598F5BD65B5923B288406D295BE(__thisValue, ___mb0, ___tkEventProp1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetClassLayout_mC391249E3D98647813541985752110CF4C439DED(uint32_t ___td0, uint32_t* ___pdwPackSize1, intptr_t ___rFieldOffset2, uint32_t ___cMax3, uint32_t* ___pcFieldOffset4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pdwPackSize1' to managed representation
		uint32_t ____pdwPackSize1_empty = 0;

		// Marshaling of parameter '___pcFieldOffset4' to managed representation
		uint32_t ____pcFieldOffset4_empty = 0;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetClassLayout_m44CB2662596C044D35F9A67ADB11E7BA603E946E(__thisValue, ___td0, (&____pdwPackSize1_empty), ___rFieldOffset2, ___cMax3, (&____pcFieldOffset4_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pdwPackSize1' back from managed representation
		*___pdwPackSize1 = ____pdwPackSize1_empty;

		// Marshaling of parameter '___pcFieldOffset4' back from managed representation
		*___pcFieldOffset4 = ____pcFieldOffset4_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetFieldMarshal_m62629228ED1BB8B7D1CF5317282448ECFCAE31A7(uint32_t ___tk0, intptr_t* ___ppvNativeType1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___ppvNativeType1' to managed representation
		intptr_t ____ppvNativeType1_empty;
		memset((&____ppvNativeType1_empty), 0, sizeof(____ppvNativeType1_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetFieldMarshal_m6980FDCD3F5FCADCCD4E97DE4414715F5B53241C(__thisValue, ___tk0, (&____ppvNativeType1_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___ppvNativeType1' back from managed representation
		*___ppvNativeType1 = ____ppvNativeType1_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetRVA_m4647E38E555A210A7461C04AB7FC283849FD189C(uint32_t ___tk0, uint32_t* ___pulCodeRVA1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pulCodeRVA1' to managed representation
		uint32_t ____pulCodeRVA1_empty = 0;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetRVA_m0313555D282013CD3845A94ADD5F73870BC26BA6(__thisValue, ___tk0, (&____pulCodeRVA1_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pulCodeRVA1' back from managed representation
		*___pulCodeRVA1 = ____pulCodeRVA1_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetPermissionSetProps_m018DAB22B9D1CCB215F154D91EF8475EC6FE4CD4(uint32_t ___pm0, uint32_t* ___pdwAction1, intptr_t* ___ppvPermission2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pdwAction1' to managed representation
		uint32_t ____pdwAction1_empty = 0;

		// Marshaling of parameter '___ppvPermission2' to managed representation
		intptr_t ____ppvPermission2_empty;
		memset((&____ppvPermission2_empty), 0, sizeof(____ppvPermission2_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetPermissionSetProps_m127B73D4B8B41DA6ADBF6EA9B7E6A2203B7D3D74(__thisValue, ___pm0, (&____pdwAction1_empty), (&____ppvPermission2_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pdwAction1' back from managed representation
		*___pdwAction1 = ____pdwAction1_empty;

		// Marshaling of parameter '___ppvPermission2' back from managed representation
		*___ppvPermission2 = ____ppvPermission2_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetSigFromToken_mBD0DA8637DAD16A7D580974308D79271BBF2684D(uint32_t ___mdSig0, intptr_t* ___ppvSig1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___ppvSig1' to managed representation
		intptr_t ____ppvSig1_empty;
		memset((&____ppvSig1_empty), 0, sizeof(____ppvSig1_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetSigFromToken_m62E448B153354512306218FE76725E51942C7BE9(__thisValue, ___mdSig0, (&____ppvSig1_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___ppvSig1' back from managed representation
		*___ppvSig1 = ____ppvSig1_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetModuleRefProps_m445C934778C1A42B7BFF280FAD4A58EC8EC04CDA(uint32_t ___mur0, Il2CppChar* ___szName1, uint32_t ___cchName2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		StringBuilder_t * ____szName1_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szName1_unmarshaled, ___szName1);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetModuleRefProps_m77439DCF75B06ECB0C86B7779238FDBB40313FAA(__thisValue, ___mur0, ____szName1_unmarshaled, ___cchName2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumModuleRefs_m5B0A23EAF222BF4E7ED0F872834D8DFCA7072789(uint32_t* ___phEnum0, uint32_t* ___rModuleRefs1, uint32_t ___cmax2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rModuleRefs1' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rModuleRefs1_unmarshaled = NULL;
		if (___rModuleRefs1 != NULL)
		{
			____rModuleRefs1_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cmax2)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cmax2)); i++)
			{
				(____rModuleRefs1_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rModuleRefs1)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumModuleRefs_m0C671A8EB7E6C3E7FD5D212CF9EAD5DDD10EA515(__thisValue, ___phEnum0, ____rModuleRefs1_unmarshaled, ___cmax2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetTypeSpecFromToken_m1F40421B7A42A57CDA582A2D522E6AEF637E779B(uint32_t ___typespec0, intptr_t* ___ppvSig1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___ppvSig1' to managed representation
		intptr_t ____ppvSig1_empty;
		memset((&____ppvSig1_empty), 0, sizeof(____ppvSig1_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetTypeSpecFromToken_mA395F51D033FA6F1474D7A6213D644182AC211DE(__thisValue, ___typespec0, (&____ppvSig1_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___ppvSig1' back from managed representation
		*___ppvSig1 = ____ppvSig1_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetNameFromToken_m289B25EB1B7624F1FC64DDF38E8D766CAA8541EF(uint32_t ___tk0, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetNameFromToken_mCD993F06BF8B99F870C096AC36465E518D3989B4(__thisValue, ___tk0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumUnresolvedMethods_m6058184C16C96FB4E9565DDAB73D60AB593F8588(uint32_t* ___phEnum0, uint32_t* ___rMethods1, uint32_t ___cMax2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rMethods1' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rMethods1_unmarshaled = NULL;
		if (___rMethods1 != NULL)
		{
			____rMethods1_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax2)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax2)); i++)
			{
				(____rMethods1_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rMethods1)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumUnresolvedMethods_m12DAE83A0F52FCA1C455D84341EE100A55323D2A(__thisValue, ___phEnum0, ____rMethods1_unmarshaled, ___cMax2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetUserString_m22012E5672CA55A8454DD445D1CFE1827DF1057F(uint32_t ___stk0, Il2CppChar* ___szString1, uint32_t ___cchString2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szString1' to managed representation
		StringBuilder_t * ____szString1_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szString1_unmarshaled, ___szString1);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetUserString_m2453D2B0AA690CD31F24F234AA8C0A24DEC968A2(__thisValue, ___stk0, ____szString1_unmarshaled, ___cchString2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetPinvokeMap_mE04F476E7C2FA053AFF4A6F04C74F7277CB3AB45(uint32_t ___tk0, uint32_t* ___pdwMappingFlags1, Il2CppChar* ___szImportName2, uint32_t ___cchImportName3, uint32_t* ___pchImportName4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pdwMappingFlags1' to managed representation
		uint32_t ____pdwMappingFlags1_empty = 0;

		// Marshaling of parameter '___szImportName2' to managed representation
		StringBuilder_t * ____szImportName2_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szImportName2_unmarshaled, ___szImportName2);

		// Marshaling of parameter '___pchImportName4' to managed representation
		uint32_t ____pchImportName4_empty = 0;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetPinvokeMap_m725351EBD64769D5300EA6DF6B033DBF67A4AD59(__thisValue, ___tk0, (&____pdwMappingFlags1_empty), ____szImportName2_unmarshaled, ___cchImportName3, (&____pchImportName4_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pdwMappingFlags1' back from managed representation
		*___pdwMappingFlags1 = ____pdwMappingFlags1_empty;

		// Marshaling of parameter '___pchImportName4' back from managed representation
		*___pchImportName4 = ____pchImportName4_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumSignatures_m246D5B341E047B261839C3F62E7E7FADB7B304CE(uint32_t* ___phEnum0, uint32_t* ___rSignatures1, uint32_t ___cmax2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rSignatures1' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rSignatures1_unmarshaled = NULL;
		if (___rSignatures1 != NULL)
		{
			____rSignatures1_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cmax2)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cmax2)); i++)
			{
				(____rSignatures1_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rSignatures1)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumSignatures_mAE082EBB1598FB73907D7ED931DB308999219F3E(__thisValue, ___phEnum0, ____rSignatures1_unmarshaled, ___cmax2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumTypeSpecs_m6805F3817D44166430557EF435823FA9777E5124(uint32_t* ___phEnum0, uint32_t* ___rTypeSpecs1, uint32_t ___cmax2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rTypeSpecs1' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rTypeSpecs1_unmarshaled = NULL;
		if (___rTypeSpecs1 != NULL)
		{
			____rTypeSpecs1_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cmax2)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cmax2)); i++)
			{
				(____rTypeSpecs1_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rTypeSpecs1)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumTypeSpecs_m41FD0143EC73DCD8748B1C650D6B74E7B2D069B1(__thisValue, ___phEnum0, ____rTypeSpecs1_unmarshaled, ___cmax2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumUserStrings_m0D1AD6AE471157B06FE36CE06479BD072D7BDAEA(uint32_t* ___phEnum0, uint32_t* ___rStrings1, uint32_t ___cmax2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rStrings1' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rStrings1_unmarshaled = NULL;
		if (___rStrings1 != NULL)
		{
			____rStrings1_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cmax2)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cmax2)); i++)
			{
				(____rStrings1_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rStrings1)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumUserStrings_m4FDD59E6AED5C1A4BD3F05A4638F30D40C9FDAA6(__thisValue, ___phEnum0, ____rStrings1_unmarshaled, ___cmax2, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual int32_t STDCALL IMetaDataImport_GetParamForMethodIndex_m0866D89C6A7811AA5FBF95C77E47EA545AD671C5(uint32_t ___md0, uint32_t ___ulParamSeq1, uint32_t* ___pParam2) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pParam2' to managed representation
		uint32_t ____pParam2_empty = 0;

		// Managed method invocation
		int32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetParamForMethodIndex_m3DB063D699D066EB05D40B8AEB238E64847B6D5B(__thisValue, ___md0, ___ulParamSeq1, (&____pParam2_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return static_cast<int32_t>(ex.ex->hresult);
		}

		// Marshaling of parameter '___pParam2' back from managed representation
		*___pParam2 = ____pParam2_empty;

		return returnValue;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_EnumCustomAttributes_m10B90051E4924683EB1E52401A6D62468F7F59E7(uint32_t* ___phEnum0, uint32_t ___tk1, uint32_t ___tkType2, uint32_t* ___rCustomAttributes3, uint32_t ___cMax4, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___rCustomAttributes3' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rCustomAttributes3_unmarshaled = NULL;
		if (___rCustomAttributes3 != NULL)
		{
			____rCustomAttributes3_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax4)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax4)); i++)
			{
				(____rCustomAttributes3_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rCustomAttributes3)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_EnumCustomAttributes_mAF72A119C72785CADFF9E930FC1D1CB37CCEE564(__thisValue, ___phEnum0, ___tk1, ___tkType2, ____rCustomAttributes3_unmarshaled, ___cMax4, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetCustomAttributeProps_mFF95E6D34E2918C6685E0933F0E6D12D4B4D6574(uint32_t ___cv0, uint32_t* ___ptkObj1, uint32_t* ___ptkType2, intptr_t* ___ppBlob3, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___ptkObj1' to managed representation
		uint32_t ____ptkObj1_empty = 0;

		// Marshaling of parameter '___ptkType2' to managed representation
		uint32_t ____ptkType2_empty = 0;

		// Marshaling of parameter '___ppBlob3' to managed representation
		intptr_t ____ppBlob3_empty;
		memset((&____ppBlob3_empty), 0, sizeof(____ppBlob3_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetCustomAttributeProps_m8CBCB5AACCA35D02602F75B4D4CFAD923DFDF6BE(__thisValue, ___cv0, (&____ptkObj1_empty), (&____ptkType2_empty), (&____ppBlob3_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___ptkObj1' back from managed representation
		*___ptkObj1 = ____ptkObj1_empty;

		// Marshaling of parameter '___ptkType2' back from managed representation
		*___ptkType2 = ____ptkType2_empty;

		// Marshaling of parameter '___ppBlob3' back from managed representation
		*___ppBlob3 = ____ppBlob3_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_FindTypeRef_m54B8F48FAA1C69DC41806DC8BC67171223F98AF4(uint32_t ___tkResolutionScope0, Il2CppChar* ___szName1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_FindTypeRef_m23708968A3C6272E43649656C855D07082D8B4B8(__thisValue, ___tkResolutionScope0, ____szName1_unmarshaled, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetMemberProps_m7259BD39CD2495DEA85F9C9E0A9FD33D5364CD77(uint32_t ___mb0, uint32_t* ___pClass1, Il2CppChar* ___szMember2, uint32_t ___cchMember3, uint32_t* ___pchMember4, uint32_t* ___pdwAttr5, intptr_t* ___ppvSigBlob6, uint32_t* ___pcbSigBlob7, uint32_t* ___pulCodeRVA8, uint32_t* ___pdwImplFlags9, uint32_t* ___pdwCPlusTypeFlag10, intptr_t* ___ppValue11, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pClass1' to managed representation
		uint32_t ____pClass1_empty = 0;

		// Marshaling of parameter '___szMember2' to managed representation
		StringBuilder_t * ____szMember2_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szMember2_unmarshaled, ___szMember2);

		// Marshaling of parameter '___pchMember4' to managed representation
		uint32_t ____pchMember4_empty = 0;

		// Marshaling of parameter '___pdwAttr5' to managed representation
		uint32_t ____pdwAttr5_empty = 0;

		// Marshaling of parameter '___ppvSigBlob6' to managed representation
		intptr_t ____ppvSigBlob6_empty;
		memset((&____ppvSigBlob6_empty), 0, sizeof(____ppvSigBlob6_empty));

		// Marshaling of parameter '___pcbSigBlob7' to managed representation
		uint32_t ____pcbSigBlob7_empty = 0;

		// Marshaling of parameter '___pulCodeRVA8' to managed representation
		uint32_t ____pulCodeRVA8_empty = 0;

		// Marshaling of parameter '___pdwImplFlags9' to managed representation
		uint32_t ____pdwImplFlags9_empty = 0;

		// Marshaling of parameter '___pdwCPlusTypeFlag10' to managed representation
		uint32_t ____pdwCPlusTypeFlag10_empty = 0;

		// Marshaling of parameter '___ppValue11' to managed representation
		intptr_t ____ppValue11_empty;
		memset((&____ppValue11_empty), 0, sizeof(____ppValue11_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetMemberProps_mF9FEDD1237317F6118B41C9FC86174A946DDA6F2(__thisValue, ___mb0, (&____pClass1_empty), ____szMember2_unmarshaled, ___cchMember3, (&____pchMember4_empty), (&____pdwAttr5_empty), (&____ppvSigBlob6_empty), (&____pcbSigBlob7_empty), (&____pulCodeRVA8_empty), (&____pdwImplFlags9_empty), (&____pdwCPlusTypeFlag10_empty), (&____ppValue11_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pClass1' back from managed representation
		*___pClass1 = ____pClass1_empty;

		// Marshaling of parameter '___pchMember4' back from managed representation
		*___pchMember4 = ____pchMember4_empty;

		// Marshaling of parameter '___pdwAttr5' back from managed representation
		*___pdwAttr5 = ____pdwAttr5_empty;

		// Marshaling of parameter '___ppvSigBlob6' back from managed representation
		*___ppvSigBlob6 = ____ppvSigBlob6_empty;

		// Marshaling of parameter '___pcbSigBlob7' back from managed representation
		*___pcbSigBlob7 = ____pcbSigBlob7_empty;

		// Marshaling of parameter '___pulCodeRVA8' back from managed representation
		*___pulCodeRVA8 = ____pulCodeRVA8_empty;

		// Marshaling of parameter '___pdwImplFlags9' back from managed representation
		*___pdwImplFlags9 = ____pdwImplFlags9_empty;

		// Marshaling of parameter '___pdwCPlusTypeFlag10' back from managed representation
		*___pdwCPlusTypeFlag10 = ____pdwCPlusTypeFlag10_empty;

		// Marshaling of parameter '___ppValue11' back from managed representation
		*___ppValue11 = ____ppValue11_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetFieldProps_m441C445751C7F8E017A151210928A85699B7A005(uint32_t ___mb0, uint32_t* ___pClass1, Il2CppChar* ___szField2, uint32_t ___cchField3, uint32_t* ___pchField4, uint32_t* ___pdwAttr5, intptr_t* ___ppvSigBlob6, uint32_t* ___pcbSigBlob7, uint32_t* ___pdwCPlusTypeFlag8, intptr_t* ___ppValue9, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pClass1' to managed representation
		uint32_t ____pClass1_empty = 0;

		// Marshaling of parameter '___szField2' to managed representation
		StringBuilder_t * ____szField2_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szField2_unmarshaled, ___szField2);

		// Marshaling of parameter '___pchField4' to managed representation
		uint32_t ____pchField4_empty = 0;

		// Marshaling of parameter '___pdwAttr5' to managed representation
		uint32_t ____pdwAttr5_empty = 0;

		// Marshaling of parameter '___ppvSigBlob6' to managed representation
		intptr_t ____ppvSigBlob6_empty;
		memset((&____ppvSigBlob6_empty), 0, sizeof(____ppvSigBlob6_empty));

		// Marshaling of parameter '___pcbSigBlob7' to managed representation
		uint32_t ____pcbSigBlob7_empty = 0;

		// Marshaling of parameter '___pdwCPlusTypeFlag8' to managed representation
		uint32_t ____pdwCPlusTypeFlag8_empty = 0;

		// Marshaling of parameter '___ppValue9' to managed representation
		intptr_t ____ppValue9_empty;
		memset((&____ppValue9_empty), 0, sizeof(____ppValue9_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetFieldProps_m064369EFBC50B28BBC7305E5FD3DF94300016607(__thisValue, ___mb0, (&____pClass1_empty), ____szField2_unmarshaled, ___cchField3, (&____pchField4_empty), (&____pdwAttr5_empty), (&____ppvSigBlob6_empty), (&____pcbSigBlob7_empty), (&____pdwCPlusTypeFlag8_empty), (&____ppValue9_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pClass1' back from managed representation
		*___pClass1 = ____pClass1_empty;

		// Marshaling of parameter '___pchField4' back from managed representation
		*___pchField4 = ____pchField4_empty;

		// Marshaling of parameter '___pdwAttr5' back from managed representation
		*___pdwAttr5 = ____pdwAttr5_empty;

		// Marshaling of parameter '___ppvSigBlob6' back from managed representation
		*___ppvSigBlob6 = ____ppvSigBlob6_empty;

		// Marshaling of parameter '___pcbSigBlob7' back from managed representation
		*___pcbSigBlob7 = ____pcbSigBlob7_empty;

		// Marshaling of parameter '___pdwCPlusTypeFlag8' back from managed representation
		*___pdwCPlusTypeFlag8 = ____pdwCPlusTypeFlag8_empty;

		// Marshaling of parameter '___ppValue9' back from managed representation
		*___ppValue9 = ____ppValue9_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetPropertyProps_mC69AE779B863D2C29BEF95D642D874D23FB958D4(uint32_t ___prop0, uint32_t* ___pClass1, Il2CppChar* ___szProperty2, uint32_t ___cchProperty3, uint32_t* ___pchProperty4, uint32_t* ___pdwPropFlags5, intptr_t* ___ppvSig6, uint32_t* ___pbSig7, uint32_t* ___pdwCPlusTypeFlag8, intptr_t* ___ppDefaultValue9, uint32_t* ___pcchDefaultValue10, uint32_t* ___pmdSetter11, uint32_t* ___pmdGetter12, uint32_t* ___rmdOtherMethod13, uint32_t ___cMax14, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pClass1' to managed representation
		uint32_t ____pClass1_empty = 0;

		// Marshaling of parameter '___szProperty2' to managed representation
		StringBuilder_t * ____szProperty2_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szProperty2_unmarshaled, ___szProperty2);

		// Marshaling of parameter '___pchProperty4' to managed representation
		uint32_t ____pchProperty4_empty = 0;

		// Marshaling of parameter '___pdwPropFlags5' to managed representation
		uint32_t ____pdwPropFlags5_empty = 0;

		// Marshaling of parameter '___ppvSig6' to managed representation
		intptr_t ____ppvSig6_empty;
		memset((&____ppvSig6_empty), 0, sizeof(____ppvSig6_empty));

		// Marshaling of parameter '___pbSig7' to managed representation
		uint32_t ____pbSig7_empty = 0;

		// Marshaling of parameter '___pdwCPlusTypeFlag8' to managed representation
		uint32_t ____pdwCPlusTypeFlag8_empty = 0;

		// Marshaling of parameter '___ppDefaultValue9' to managed representation
		intptr_t ____ppDefaultValue9_empty;
		memset((&____ppDefaultValue9_empty), 0, sizeof(____ppDefaultValue9_empty));

		// Marshaling of parameter '___pcchDefaultValue10' to managed representation
		uint32_t ____pcchDefaultValue10_empty = 0;

		// Marshaling of parameter '___pmdSetter11' to managed representation
		uint32_t ____pmdSetter11_empty = 0;

		// Marshaling of parameter '___pmdGetter12' to managed representation
		uint32_t ____pmdGetter12_empty = 0;

		// Marshaling of parameter '___rmdOtherMethod13' to managed representation
		UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ____rmdOtherMethod13_unmarshaled = NULL;
		if (___rmdOtherMethod13 != NULL)
		{
			____rmdOtherMethod13_unmarshaled = reinterpret_cast<UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*>((UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF*)SZArrayNew(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF_il2cpp_TypeInfo_var, static_cast<int32_t>(___cMax14)));
			for (int32_t i = 0; i < ARRAY_LENGTH_AS_INT32(static_cast<int32_t>(___cMax14)); i++)
			{
				(____rmdOtherMethod13_unmarshaled)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(i), (___rmdOtherMethod13)[i]);
			}
		}

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetPropertyProps_m5548B4DBAD3B1D537A8F0F96FD24F921113FAD9D(__thisValue, ___prop0, (&____pClass1_empty), ____szProperty2_unmarshaled, ___cchProperty3, (&____pchProperty4_empty), (&____pdwPropFlags5_empty), (&____ppvSig6_empty), (&____pbSig7_empty), (&____pdwCPlusTypeFlag8_empty), (&____ppDefaultValue9_empty), (&____pcchDefaultValue10_empty), (&____pmdSetter11_empty), (&____pmdGetter12_empty), ____rmdOtherMethod13_unmarshaled, ___cMax14, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pClass1' back from managed representation
		*___pClass1 = ____pClass1_empty;

		// Marshaling of parameter '___pchProperty4' back from managed representation
		*___pchProperty4 = ____pchProperty4_empty;

		// Marshaling of parameter '___pdwPropFlags5' back from managed representation
		*___pdwPropFlags5 = ____pdwPropFlags5_empty;

		// Marshaling of parameter '___ppvSig6' back from managed representation
		*___ppvSig6 = ____ppvSig6_empty;

		// Marshaling of parameter '___pbSig7' back from managed representation
		*___pbSig7 = ____pbSig7_empty;

		// Marshaling of parameter '___pdwCPlusTypeFlag8' back from managed representation
		*___pdwCPlusTypeFlag8 = ____pdwCPlusTypeFlag8_empty;

		// Marshaling of parameter '___ppDefaultValue9' back from managed representation
		*___ppDefaultValue9 = ____ppDefaultValue9_empty;

		// Marshaling of parameter '___pcchDefaultValue10' back from managed representation
		*___pcchDefaultValue10 = ____pcchDefaultValue10_empty;

		// Marshaling of parameter '___pmdSetter11' back from managed representation
		*___pmdSetter11 = ____pmdSetter11_empty;

		// Marshaling of parameter '___pmdGetter12' back from managed representation
		*___pmdGetter12 = ____pmdGetter12_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetParamProps_m773A908558B1CE55CEE9802D07FCC8799BE0A68C(uint32_t ___tk0, uint32_t* ___pmd1, uint32_t* ___pulSequence2, Il2CppChar* ___szName3, uint32_t ___cchName4, uint32_t* ___pchName5, uint32_t* ___pdwAttr6, uint32_t* ___pdwCPlusTypeFlag7, intptr_t* ___ppValue8, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___pmd1' to managed representation
		uint32_t ____pmd1_empty = 0;

		// Marshaling of parameter '___pulSequence2' to managed representation
		uint32_t ____pulSequence2_empty = 0;

		// Marshaling of parameter '___szName3' to managed representation
		StringBuilder_t * ____szName3_unmarshaled = NULL;
		il2cpp_codegen_marshal_wstring_builder_result(____szName3_unmarshaled, ___szName3);

		// Marshaling of parameter '___pchName5' to managed representation
		uint32_t ____pchName5_empty = 0;

		// Marshaling of parameter '___pdwAttr6' to managed representation
		uint32_t ____pdwAttr6_empty = 0;

		// Marshaling of parameter '___pdwCPlusTypeFlag7' to managed representation
		uint32_t ____pdwCPlusTypeFlag7_empty = 0;

		// Marshaling of parameter '___ppValue8' to managed representation
		intptr_t ____ppValue8_empty;
		memset((&____ppValue8_empty), 0, sizeof(____ppValue8_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetParamProps_m34DA97A53F54A1A49319A974547D05859277DFB7(__thisValue, ___tk0, (&____pmd1_empty), (&____pulSequence2_empty), ____szName3_unmarshaled, ___cchName4, (&____pchName5_empty), (&____pdwAttr6_empty), (&____pdwCPlusTypeFlag7_empty), (&____ppValue8_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___pmd1' back from managed representation
		*___pmd1 = ____pmd1_empty;

		// Marshaling of parameter '___pulSequence2' back from managed representation
		*___pulSequence2 = ____pulSequence2_empty;

		// Marshaling of parameter '___pchName5' back from managed representation
		*___pchName5 = ____pchName5_empty;

		// Marshaling of parameter '___pdwAttr6' back from managed representation
		*___pdwAttr6 = ____pdwAttr6_empty;

		// Marshaling of parameter '___pdwCPlusTypeFlag7' back from managed representation
		*___pdwCPlusTypeFlag7 = ____pdwCPlusTypeFlag7_empty;

		// Marshaling of parameter '___ppValue8' back from managed representation
		*___ppValue8 = ____ppValue8_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetCustomAttributeByName_m710CB7275785D45AEEBD8126989C7A9453D01036(uint32_t ___tkObj0, Il2CppChar* ___szName1, intptr_t* ___ppData2, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Marshaling of parameter '___szName1' to managed representation
		String_t* ____szName1_unmarshaled = NULL;
		____szName1_unmarshaled = il2cpp_codegen_marshal_bstring_result(___szName1);

		// Marshaling of parameter '___ppData2' to managed representation
		intptr_t ____ppData2_empty;
		memset((&____ppData2_empty), 0, sizeof(____ppData2_empty));

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetCustomAttributeByName_mD7458B3E94547946BE2826674EFF43C7E9E07B44(__thisValue, ___tkObj0, ____szName1_unmarshaled, (&____ppData2_empty), NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		// Marshaling of parameter '___ppData2' back from managed representation
		*___ppData2 = ____ppData2_empty;

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual int32_t STDCALL IMetaDataImport_IsValidToken_mB8D5951A62860491308B8F6D7180E7BC870577A6(uint32_t ___tk0) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		bool returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_IsValidToken_m4C93614019DBD3A23C337D57D9069A40790AA9B3(__thisValue, ___tk0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return static_cast<int32_t>(0);
		}

		return static_cast<int32_t>(returnValue);
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetNestedClassProps_mD60FBB2009AE8304B3FB867015517B7A98BDEF24(uint32_t ___tdNestedClass0, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetNestedClassProps_m2D55A3CEA1473A7B5981D2FE7E02A2F9C1B6AD28(__thisValue, ___tdNestedClass0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_GetNativeCallConvFromSig_mBF646865461848854B8743022A6B04AD9A167C5D(intptr_t ___pvSig0, uint32_t ___cbSig1, uint32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		uint32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_GetNativeCallConvFromSig_m608382D7524F23E3412E06AD0CFC45C72307A890(__thisValue, ___pvSig0, ___cbSig1, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}

	virtual il2cpp_hresult_t STDCALL IMetaDataImport_IsGlobal_m4D7BF9FD4B1A8A95F4E13BDCAC80F10232E6878E(uint32_t ___pd0, int32_t* comReturnValue) IL2CPP_OVERRIDE
	{
		static bool s_Il2CppMethodInitialized;
		if (!s_Il2CppMethodInitialized)
		{
			il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
			s_Il2CppMethodInitialized = true;
		}
		il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

		// Managed method invocation
		int32_t returnValue;
		try
		{
			ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 * __thisValue = (ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4 *)GetManagedObjectInline();
			returnValue = ModuleMetadata_IsGlobal_m860D06D448CAE8596A5AC159ECAB3C5F093C5F8B(__thisValue, ___pd0, NULL);
		}
		catch (const Il2CppExceptionWrapper& ex)
		{
			memset(comReturnValue, 0, sizeof(*comReturnValue));
			String_t* exceptionStr = NULL;
			try
			{
				exceptionStr = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, ex.ex);
			}
			catch (const Il2CppExceptionWrapper&)
			{
				exceptionStr = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			}
			il2cpp_codegen_store_exception_info(ex.ex, exceptionStr);
			return ex.ex->hresult;
		}

		*comReturnValue = returnValue;
		return IL2CPP_S_OK;
	}
};

IL2CPP_EXTERN_C Il2CppIUnknown* CreateComCallableWrapperFor_ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4(RuntimeObject* obj)
{
	void* memory = il2cpp::utils::Memory::Malloc(sizeof(ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4_ComCallableWrapper));
	if (memory == NULL)
	{
		il2cpp_codegen_raise_out_of_memory_exception();
	}

	return static_cast<Il2CppIManagedObjectHolder*>(new(memory) ModuleMetadata_tD636CEE709A579BDA3FA23820A65C781DFE201B4_ComCallableWrapper(obj));
}
