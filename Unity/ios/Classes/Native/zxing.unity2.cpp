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
template <typename R, typename T1, typename T2>
struct VirtFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};

// System.Collections.Generic.IList`1<ZXing.BarcodeFormat>
struct IList_1_tC2E36BFD1BAF38073A34E48BC0B155AFA411E535;
// System.Int32[][]
struct Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF;
// System.Int64[][]
struct Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC;
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.Int64[]
struct Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// ZXing.Datamatrix.Encoder.SymbolInfo[]
struct SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD;
// ZXing.QrCode.Internal.Version/ECB[]
struct ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC;
// ZXing.Aztec.AztecWriter
struct AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005;
// ZXing.Datamatrix.Encoder.C40Encoder
struct C40Encoder_t0116F1C0E550E07A64EA97EDE0C17680F74AF079;
// ZXing.OneD.CodaBarWriter
struct CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128;
// ZXing.OneD.Code128Writer
struct Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE;
// ZXing.OneD.Code39Writer
struct Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010;
// ZXing.OneD.Code93Writer
struct Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00;
// ZXing.Datamatrix.DataMatrixWriter
struct DataMatrixWriter_t50600BCE56F15967C245EAB5606415EC95514594;
// ZXing.Dimension
struct Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB;
// ZXing.OneD.EAN13Writer
struct EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA;
// ZXing.OneD.EAN8Writer
struct EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB;
// ZXing.Datamatrix.Encoder.EncoderContext
struct EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA;
// System.Text.Encoding
struct Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827;
// System.Exception
struct Exception_t;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// ZXing.OneD.ITFWriter
struct ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4;
// ZXing.OneD.MSIWriter
struct MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9;
// ZXing.PDF417.PDF417Writer
struct PDF417Writer_t2D7A2CB7551E59A96AA739F49AFCFD2B8FCCC3F9;
// ZXing.OneD.PlesseyWriter
struct PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144;
// ZXing.QrCode.QRCodeWriter
struct QRCodeWriter_t5AC22EE8E5200CD934B1C52F7BFA3B8E2F74CF65;
// System.Text.RegularExpressions.Regex
struct Regex_t90F443D398F44965EA241A652ED75DF5BA072A1F;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// ZXing.Datamatrix.Encoder.SymbolInfo
struct SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926;
// ZXing.OneD.UPCAWriter
struct UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D;
// ZXing.OneD.UPCEWriter
struct UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// ZXing.Writer
struct Writer_t558D37450BABA0E46004E33F3BD6CA4705C778F8;
// ZXing.WriterException
struct WriterException_t6223BBE3D60BC6E579D95555C6ADDD6C6EE5C6C4;
// ZXing.Datamatrix.Encoder.X12Encoder
struct X12Encoder_t098F8ED199393060384BAB57E63D1E9AC4360AC0;
// BigIntegerLibrary.Base10BigInteger/DigitContainer
struct DigitContainer_t67BCA9FC3E44AC0D7DC486704701B2171F8546E8;
// BigIntegerLibrary.BigInteger/DigitContainer
struct DigitContainer_tE6C3DF6764570ADB5B141B781C8E6B082937C72B;
// ZXing.MultiFormatWriter/<>c
struct U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD;
// ZXing.QrCode.Internal.Version/ECB
struct ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2;
// ZXing.QrCode.Internal.Version/ECBlocks
struct ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804;

IL2CPP_EXTERN_C RuntimeClass* AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DataMatrixWriter_t50600BCE56F15967C245EAB5606415EC95514594_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PDF417Writer_t2D7A2CB7551E59A96AA739F49AFCFD2B8FCCC3F9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* QRCodeWriter_t5AC22EE8E5200CD934B1C52F7BFA3B8E2F74CF65_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019_il2cpp_TypeInfo_var;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC;
struct Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6;
struct ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

struct Il2CppArrayBounds;

// System.Array


// ZXing.Aztec.AztecWriter
struct AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005  : public RuntimeObject
{
public:

public:
};

struct AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005_StaticFields
{
public:
	// System.Text.Encoding ZXing.Aztec.AztecWriter::DEFAULT_CHARSET
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___DEFAULT_CHARSET_0;

public:
	inline static int32_t get_offset_of_DEFAULT_CHARSET_0() { return static_cast<int32_t>(offsetof(AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005_StaticFields, ___DEFAULT_CHARSET_0)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_DEFAULT_CHARSET_0() const { return ___DEFAULT_CHARSET_0; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_DEFAULT_CHARSET_0() { return &___DEFAULT_CHARSET_0; }
	inline void set_DEFAULT_CHARSET_0(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___DEFAULT_CHARSET_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___DEFAULT_CHARSET_0), (void*)value);
	}
};


// ZXing.Datamatrix.Encoder.C40Encoder
struct C40Encoder_t0116F1C0E550E07A64EA97EDE0C17680F74AF079  : public RuntimeObject
{
public:

public:
};


// ZXing.Datamatrix.DataMatrixWriter
struct DataMatrixWriter_t50600BCE56F15967C245EAB5606415EC95514594  : public RuntimeObject
{
public:

public:
};


// ZXing.OneD.OneDimensionalCodeWriter
struct OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC  : public RuntimeObject
{
public:

public:
};

struct OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC_StaticFields
{
public:
	// System.Text.RegularExpressions.Regex ZXing.OneD.OneDimensionalCodeWriter::NUMERIC
	Regex_t90F443D398F44965EA241A652ED75DF5BA072A1F * ___NUMERIC_0;

public:
	inline static int32_t get_offset_of_NUMERIC_0() { return static_cast<int32_t>(offsetof(OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC_StaticFields, ___NUMERIC_0)); }
	inline Regex_t90F443D398F44965EA241A652ED75DF5BA072A1F * get_NUMERIC_0() const { return ___NUMERIC_0; }
	inline Regex_t90F443D398F44965EA241A652ED75DF5BA072A1F ** get_address_of_NUMERIC_0() { return &___NUMERIC_0; }
	inline void set_NUMERIC_0(Regex_t90F443D398F44965EA241A652ED75DF5BA072A1F * value)
	{
		___NUMERIC_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___NUMERIC_0), (void*)value);
	}
};


// ZXing.PDF417.PDF417Writer
struct PDF417Writer_t2D7A2CB7551E59A96AA739F49AFCFD2B8FCCC3F9  : public RuntimeObject
{
public:

public:
};


// ZXing.QrCode.QRCodeWriter
struct QRCodeWriter_t5AC22EE8E5200CD934B1C52F7BFA3B8E2F74CF65  : public RuntimeObject
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


// ZXing.Datamatrix.Encoder.SymbolInfo
struct SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926  : public RuntimeObject
{
public:
	// System.Boolean ZXing.Datamatrix.Encoder.SymbolInfo::rectangular
	bool ___rectangular_2;
	// System.Int32 ZXing.Datamatrix.Encoder.SymbolInfo::dataCapacity
	int32_t ___dataCapacity_3;
	// System.Int32 ZXing.Datamatrix.Encoder.SymbolInfo::errorCodewords
	int32_t ___errorCodewords_4;
	// System.Int32 ZXing.Datamatrix.Encoder.SymbolInfo::matrixWidth
	int32_t ___matrixWidth_5;
	// System.Int32 ZXing.Datamatrix.Encoder.SymbolInfo::matrixHeight
	int32_t ___matrixHeight_6;
	// System.Int32 ZXing.Datamatrix.Encoder.SymbolInfo::dataRegions
	int32_t ___dataRegions_7;
	// System.Int32 ZXing.Datamatrix.Encoder.SymbolInfo::rsBlockData
	int32_t ___rsBlockData_8;
	// System.Int32 ZXing.Datamatrix.Encoder.SymbolInfo::rsBlockError
	int32_t ___rsBlockError_9;

public:
	inline static int32_t get_offset_of_rectangular_2() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926, ___rectangular_2)); }
	inline bool get_rectangular_2() const { return ___rectangular_2; }
	inline bool* get_address_of_rectangular_2() { return &___rectangular_2; }
	inline void set_rectangular_2(bool value)
	{
		___rectangular_2 = value;
	}

	inline static int32_t get_offset_of_dataCapacity_3() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926, ___dataCapacity_3)); }
	inline int32_t get_dataCapacity_3() const { return ___dataCapacity_3; }
	inline int32_t* get_address_of_dataCapacity_3() { return &___dataCapacity_3; }
	inline void set_dataCapacity_3(int32_t value)
	{
		___dataCapacity_3 = value;
	}

	inline static int32_t get_offset_of_errorCodewords_4() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926, ___errorCodewords_4)); }
	inline int32_t get_errorCodewords_4() const { return ___errorCodewords_4; }
	inline int32_t* get_address_of_errorCodewords_4() { return &___errorCodewords_4; }
	inline void set_errorCodewords_4(int32_t value)
	{
		___errorCodewords_4 = value;
	}

	inline static int32_t get_offset_of_matrixWidth_5() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926, ___matrixWidth_5)); }
	inline int32_t get_matrixWidth_5() const { return ___matrixWidth_5; }
	inline int32_t* get_address_of_matrixWidth_5() { return &___matrixWidth_5; }
	inline void set_matrixWidth_5(int32_t value)
	{
		___matrixWidth_5 = value;
	}

	inline static int32_t get_offset_of_matrixHeight_6() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926, ___matrixHeight_6)); }
	inline int32_t get_matrixHeight_6() const { return ___matrixHeight_6; }
	inline int32_t* get_address_of_matrixHeight_6() { return &___matrixHeight_6; }
	inline void set_matrixHeight_6(int32_t value)
	{
		___matrixHeight_6 = value;
	}

	inline static int32_t get_offset_of_dataRegions_7() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926, ___dataRegions_7)); }
	inline int32_t get_dataRegions_7() const { return ___dataRegions_7; }
	inline int32_t* get_address_of_dataRegions_7() { return &___dataRegions_7; }
	inline void set_dataRegions_7(int32_t value)
	{
		___dataRegions_7 = value;
	}

	inline static int32_t get_offset_of_rsBlockData_8() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926, ___rsBlockData_8)); }
	inline int32_t get_rsBlockData_8() const { return ___rsBlockData_8; }
	inline int32_t* get_address_of_rsBlockData_8() { return &___rsBlockData_8; }
	inline void set_rsBlockData_8(int32_t value)
	{
		___rsBlockData_8 = value;
	}

	inline static int32_t get_offset_of_rsBlockError_9() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926, ___rsBlockError_9)); }
	inline int32_t get_rsBlockError_9() const { return ___rsBlockError_9; }
	inline int32_t* get_address_of_rsBlockError_9() { return &___rsBlockError_9; }
	inline void set_rsBlockError_9(int32_t value)
	{
		___rsBlockError_9 = value;
	}
};

struct SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926_StaticFields
{
public:
	// ZXing.Datamatrix.Encoder.SymbolInfo[] ZXing.Datamatrix.Encoder.SymbolInfo::PROD_SYMBOLS
	SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD* ___PROD_SYMBOLS_0;
	// ZXing.Datamatrix.Encoder.SymbolInfo[] ZXing.Datamatrix.Encoder.SymbolInfo::symbols
	SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD* ___symbols_1;

public:
	inline static int32_t get_offset_of_PROD_SYMBOLS_0() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926_StaticFields, ___PROD_SYMBOLS_0)); }
	inline SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD* get_PROD_SYMBOLS_0() const { return ___PROD_SYMBOLS_0; }
	inline SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD** get_address_of_PROD_SYMBOLS_0() { return &___PROD_SYMBOLS_0; }
	inline void set_PROD_SYMBOLS_0(SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD* value)
	{
		___PROD_SYMBOLS_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___PROD_SYMBOLS_0), (void*)value);
	}

	inline static int32_t get_offset_of_symbols_1() { return static_cast<int32_t>(offsetof(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926_StaticFields, ___symbols_1)); }
	inline SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD* get_symbols_1() const { return ___symbols_1; }
	inline SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD** get_address_of_symbols_1() { return &___symbols_1; }
	inline void set_symbols_1(SymbolInfoU5BU5D_tCA3E47FE4C63968D7EC185CB3FE2450205CA89DD* value)
	{
		___symbols_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___symbols_1), (void*)value);
	}
};


// ZXing.OneD.UPCAWriter
struct UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D  : public RuntimeObject
{
public:
	// ZXing.OneD.EAN13Writer ZXing.OneD.UPCAWriter::subWriter
	EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA * ___subWriter_0;

public:
	inline static int32_t get_offset_of_subWriter_0() { return static_cast<int32_t>(offsetof(UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D, ___subWriter_0)); }
	inline EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA * get_subWriter_0() const { return ___subWriter_0; }
	inline EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA ** get_address_of_subWriter_0() { return &___subWriter_0; }
	inline void set_subWriter_0(EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA * value)
	{
		___subWriter_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___subWriter_0), (void*)value);
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

// BigIntegerLibrary.Base10BigInteger/DigitContainer
struct DigitContainer_t67BCA9FC3E44AC0D7DC486704701B2171F8546E8  : public RuntimeObject
{
public:
	// System.Int64[][] BigIntegerLibrary.Base10BigInteger/DigitContainer::digits
	Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* ___digits_0;

public:
	inline static int32_t get_offset_of_digits_0() { return static_cast<int32_t>(offsetof(DigitContainer_t67BCA9FC3E44AC0D7DC486704701B2171F8546E8, ___digits_0)); }
	inline Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* get_digits_0() const { return ___digits_0; }
	inline Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC** get_address_of_digits_0() { return &___digits_0; }
	inline void set_digits_0(Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* value)
	{
		___digits_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___digits_0), (void*)value);
	}
};


// BigIntegerLibrary.BigInteger/DigitContainer
struct DigitContainer_tE6C3DF6764570ADB5B141B781C8E6B082937C72B  : public RuntimeObject
{
public:
	// System.Int64[][] BigIntegerLibrary.BigInteger/DigitContainer::digits
	Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* ___digits_0;

public:
	inline static int32_t get_offset_of_digits_0() { return static_cast<int32_t>(offsetof(DigitContainer_tE6C3DF6764570ADB5B141B781C8E6B082937C72B, ___digits_0)); }
	inline Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* get_digits_0() const { return ___digits_0; }
	inline Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC** get_address_of_digits_0() { return &___digits_0; }
	inline void set_digits_0(Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* value)
	{
		___digits_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___digits_0), (void*)value);
	}
};


// ZXing.MultiFormatWriter/<>c
struct U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD  : public RuntimeObject
{
public:

public:
};

struct U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_StaticFields
{
public:
	// ZXing.MultiFormatWriter/<>c ZXing.MultiFormatWriter/<>c::<>9
	U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * ___U3CU3E9_0;

public:
	inline static int32_t get_offset_of_U3CU3E9_0() { return static_cast<int32_t>(offsetof(U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_StaticFields, ___U3CU3E9_0)); }
	inline U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * get_U3CU3E9_0() const { return ___U3CU3E9_0; }
	inline U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD ** get_address_of_U3CU3E9_0() { return &___U3CU3E9_0; }
	inline void set_U3CU3E9_0(U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * value)
	{
		___U3CU3E9_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9_0), (void*)value);
	}
};


// ZXing.QrCode.Internal.Version/ECB
struct ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2  : public RuntimeObject
{
public:
	// System.Int32 ZXing.QrCode.Internal.Version/ECB::count
	int32_t ___count_0;
	// System.Int32 ZXing.QrCode.Internal.Version/ECB::dataCodewords
	int32_t ___dataCodewords_1;

public:
	inline static int32_t get_offset_of_count_0() { return static_cast<int32_t>(offsetof(ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2, ___count_0)); }
	inline int32_t get_count_0() const { return ___count_0; }
	inline int32_t* get_address_of_count_0() { return &___count_0; }
	inline void set_count_0(int32_t value)
	{
		___count_0 = value;
	}

	inline static int32_t get_offset_of_dataCodewords_1() { return static_cast<int32_t>(offsetof(ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2, ___dataCodewords_1)); }
	inline int32_t get_dataCodewords_1() const { return ___dataCodewords_1; }
	inline int32_t* get_address_of_dataCodewords_1() { return &___dataCodewords_1; }
	inline void set_dataCodewords_1(int32_t value)
	{
		___dataCodewords_1 = value;
	}
};


// ZXing.QrCode.Internal.Version/ECBlocks
struct ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804  : public RuntimeObject
{
public:
	// System.Int32 ZXing.QrCode.Internal.Version/ECBlocks::ecCodewordsPerBlock
	int32_t ___ecCodewordsPerBlock_0;
	// ZXing.QrCode.Internal.Version/ECB[] ZXing.QrCode.Internal.Version/ECBlocks::ecBlocks
	ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* ___ecBlocks_1;

public:
	inline static int32_t get_offset_of_ecCodewordsPerBlock_0() { return static_cast<int32_t>(offsetof(ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804, ___ecCodewordsPerBlock_0)); }
	inline int32_t get_ecCodewordsPerBlock_0() const { return ___ecCodewordsPerBlock_0; }
	inline int32_t* get_address_of_ecCodewordsPerBlock_0() { return &___ecCodewordsPerBlock_0; }
	inline void set_ecCodewordsPerBlock_0(int32_t value)
	{
		___ecCodewordsPerBlock_0 = value;
	}

	inline static int32_t get_offset_of_ecBlocks_1() { return static_cast<int32_t>(offsetof(ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804, ___ecBlocks_1)); }
	inline ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* get_ecBlocks_1() const { return ___ecBlocks_1; }
	inline ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC** get_address_of_ecBlocks_1() { return &___ecBlocks_1; }
	inline void set_ecBlocks_1(ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* value)
	{
		___ecBlocks_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ecBlocks_1), (void*)value);
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


// System.Char
struct Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14 
{
public:
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14, ___m_value_0)); }
	inline Il2CppChar get_m_value_0() const { return ___m_value_0; }
	inline Il2CppChar* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(Il2CppChar value)
	{
		___m_value_0 = value;
	}
};

struct Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_StaticFields
{
public:
	// System.Byte[] System.Char::categoryForLatin1
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___categoryForLatin1_3;

public:
	inline static int32_t get_offset_of_categoryForLatin1_3() { return static_cast<int32_t>(offsetof(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_StaticFields, ___categoryForLatin1_3)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_categoryForLatin1_3() const { return ___categoryForLatin1_3; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_categoryForLatin1_3() { return &___categoryForLatin1_3; }
	inline void set_categoryForLatin1_3(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___categoryForLatin1_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___categoryForLatin1_3), (void*)value);
	}
};


// ZXing.OneD.CodaBarWriter
struct CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128  : public OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC
{
public:

public:
};

struct CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_StaticFields
{
public:
	// System.Char[] ZXing.OneD.CodaBarWriter::START_END_CHARS
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___START_END_CHARS_1;
	// System.Char[] ZXing.OneD.CodaBarWriter::ALT_START_END_CHARS
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___ALT_START_END_CHARS_2;
	// System.Char[] ZXing.OneD.CodaBarWriter::CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3;
	// System.Char ZXing.OneD.CodaBarWriter::DEFAULT_GUARD
	Il2CppChar ___DEFAULT_GUARD_4;
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.CodaBarWriter::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_5;

public:
	inline static int32_t get_offset_of_START_END_CHARS_1() { return static_cast<int32_t>(offsetof(CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_StaticFields, ___START_END_CHARS_1)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_START_END_CHARS_1() const { return ___START_END_CHARS_1; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_START_END_CHARS_1() { return &___START_END_CHARS_1; }
	inline void set_START_END_CHARS_1(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___START_END_CHARS_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___START_END_CHARS_1), (void*)value);
	}

	inline static int32_t get_offset_of_ALT_START_END_CHARS_2() { return static_cast<int32_t>(offsetof(CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_StaticFields, ___ALT_START_END_CHARS_2)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_ALT_START_END_CHARS_2() const { return ___ALT_START_END_CHARS_2; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_ALT_START_END_CHARS_2() { return &___ALT_START_END_CHARS_2; }
	inline void set_ALT_START_END_CHARS_2(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___ALT_START_END_CHARS_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ALT_START_END_CHARS_2), (void*)value);
	}

	inline static int32_t get_offset_of_CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3() { return static_cast<int32_t>(offsetof(CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_StaticFields, ___CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3() const { return ___CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3() { return &___CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3; }
	inline void set_CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED_3), (void*)value);
	}

	inline static int32_t get_offset_of_DEFAULT_GUARD_4() { return static_cast<int32_t>(offsetof(CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_StaticFields, ___DEFAULT_GUARD_4)); }
	inline Il2CppChar get_DEFAULT_GUARD_4() const { return ___DEFAULT_GUARD_4; }
	inline Il2CppChar* get_address_of_DEFAULT_GUARD_4() { return &___DEFAULT_GUARD_4; }
	inline void set_DEFAULT_GUARD_4(Il2CppChar value)
	{
		___DEFAULT_GUARD_4 = value;
	}

	inline static int32_t get_offset_of_supportedWriteFormats_5() { return static_cast<int32_t>(offsetof(CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_StaticFields, ___supportedWriteFormats_5)); }
	inline RuntimeObject* get_supportedWriteFormats_5() const { return ___supportedWriteFormats_5; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_5() { return &___supportedWriteFormats_5; }
	inline void set_supportedWriteFormats_5(RuntimeObject* value)
	{
		___supportedWriteFormats_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_5), (void*)value);
	}
};


// ZXing.OneD.Code128Writer
struct Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE  : public OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC
{
public:
	// System.Boolean ZXing.OneD.Code128Writer::forceCodesetB
	bool ___forceCodesetB_1;

public:
	inline static int32_t get_offset_of_forceCodesetB_1() { return static_cast<int32_t>(offsetof(Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE, ___forceCodesetB_1)); }
	inline bool get_forceCodesetB_1() const { return ___forceCodesetB_1; }
	inline bool* get_address_of_forceCodesetB_1() { return &___forceCodesetB_1; }
	inline void set_forceCodesetB_1(bool value)
	{
		___forceCodesetB_1 = value;
	}
};

struct Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE_StaticFields
{
public:
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.Code128Writer::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_2;

public:
	inline static int32_t get_offset_of_supportedWriteFormats_2() { return static_cast<int32_t>(offsetof(Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE_StaticFields, ___supportedWriteFormats_2)); }
	inline RuntimeObject* get_supportedWriteFormats_2() const { return ___supportedWriteFormats_2; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_2() { return &___supportedWriteFormats_2; }
	inline void set_supportedWriteFormats_2(RuntimeObject* value)
	{
		___supportedWriteFormats_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_2), (void*)value);
	}
};


// ZXing.OneD.Code39Writer
struct Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010  : public OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC
{
public:

public:
};

struct Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010_StaticFields
{
public:
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.Code39Writer::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_1;

public:
	inline static int32_t get_offset_of_supportedWriteFormats_1() { return static_cast<int32_t>(offsetof(Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010_StaticFields, ___supportedWriteFormats_1)); }
	inline RuntimeObject* get_supportedWriteFormats_1() const { return ___supportedWriteFormats_1; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_1() { return &___supportedWriteFormats_1; }
	inline void set_supportedWriteFormats_1(RuntimeObject* value)
	{
		___supportedWriteFormats_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_1), (void*)value);
	}
};


// ZXing.OneD.Code93Writer
struct Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00  : public OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC
{
public:

public:
};

struct Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00_StaticFields
{
public:
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.Code93Writer::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_1;

public:
	inline static int32_t get_offset_of_supportedWriteFormats_1() { return static_cast<int32_t>(offsetof(Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00_StaticFields, ___supportedWriteFormats_1)); }
	inline RuntimeObject* get_supportedWriteFormats_1() const { return ___supportedWriteFormats_1; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_1() { return &___supportedWriteFormats_1; }
	inline void set_supportedWriteFormats_1(RuntimeObject* value)
	{
		___supportedWriteFormats_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_1), (void*)value);
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

// ZXing.OneD.ITFWriter
struct ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4  : public OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC
{
public:

public:
};

struct ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4_StaticFields
{
public:
	// System.Int32[] ZXing.OneD.ITFWriter::START_PATTERN
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___START_PATTERN_1;
	// System.Int32[] ZXing.OneD.ITFWriter::END_PATTERN
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___END_PATTERN_2;
	// System.Int32[][] ZXing.OneD.ITFWriter::PATTERNS
	Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* ___PATTERNS_3;
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.ITFWriter::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_4;

public:
	inline static int32_t get_offset_of_START_PATTERN_1() { return static_cast<int32_t>(offsetof(ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4_StaticFields, ___START_PATTERN_1)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_START_PATTERN_1() const { return ___START_PATTERN_1; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_START_PATTERN_1() { return &___START_PATTERN_1; }
	inline void set_START_PATTERN_1(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___START_PATTERN_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___START_PATTERN_1), (void*)value);
	}

	inline static int32_t get_offset_of_END_PATTERN_2() { return static_cast<int32_t>(offsetof(ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4_StaticFields, ___END_PATTERN_2)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_END_PATTERN_2() const { return ___END_PATTERN_2; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_END_PATTERN_2() { return &___END_PATTERN_2; }
	inline void set_END_PATTERN_2(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___END_PATTERN_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___END_PATTERN_2), (void*)value);
	}

	inline static int32_t get_offset_of_PATTERNS_3() { return static_cast<int32_t>(offsetof(ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4_StaticFields, ___PATTERNS_3)); }
	inline Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* get_PATTERNS_3() const { return ___PATTERNS_3; }
	inline Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF** get_address_of_PATTERNS_3() { return &___PATTERNS_3; }
	inline void set_PATTERNS_3(Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* value)
	{
		___PATTERNS_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___PATTERNS_3), (void*)value);
	}

	inline static int32_t get_offset_of_supportedWriteFormats_4() { return static_cast<int32_t>(offsetof(ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4_StaticFields, ___supportedWriteFormats_4)); }
	inline RuntimeObject* get_supportedWriteFormats_4() const { return ___supportedWriteFormats_4; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_4() { return &___supportedWriteFormats_4; }
	inline void set_supportedWriteFormats_4(RuntimeObject* value)
	{
		___supportedWriteFormats_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_4), (void*)value);
	}
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


// System.Int64
struct Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3 
{
public:
	// System.Int64 System.Int64::m_value
	int64_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3, ___m_value_0)); }
	inline int64_t get_m_value_0() const { return ___m_value_0; }
	inline int64_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int64_t value)
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


// ZXing.OneD.MSIWriter
struct MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9  : public OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC
{
public:

public:
};

struct MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9_StaticFields
{
public:
	// System.Int32[] ZXing.OneD.MSIWriter::startWidths
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___startWidths_1;
	// System.Int32[] ZXing.OneD.MSIWriter::endWidths
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___endWidths_2;
	// System.Int32[][] ZXing.OneD.MSIWriter::numberWidths
	Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* ___numberWidths_3;
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.MSIWriter::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_4;

public:
	inline static int32_t get_offset_of_startWidths_1() { return static_cast<int32_t>(offsetof(MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9_StaticFields, ___startWidths_1)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_startWidths_1() const { return ___startWidths_1; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_startWidths_1() { return &___startWidths_1; }
	inline void set_startWidths_1(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___startWidths_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___startWidths_1), (void*)value);
	}

	inline static int32_t get_offset_of_endWidths_2() { return static_cast<int32_t>(offsetof(MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9_StaticFields, ___endWidths_2)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_endWidths_2() const { return ___endWidths_2; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_endWidths_2() { return &___endWidths_2; }
	inline void set_endWidths_2(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___endWidths_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___endWidths_2), (void*)value);
	}

	inline static int32_t get_offset_of_numberWidths_3() { return static_cast<int32_t>(offsetof(MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9_StaticFields, ___numberWidths_3)); }
	inline Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* get_numberWidths_3() const { return ___numberWidths_3; }
	inline Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF** get_address_of_numberWidths_3() { return &___numberWidths_3; }
	inline void set_numberWidths_3(Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* value)
	{
		___numberWidths_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___numberWidths_3), (void*)value);
	}

	inline static int32_t get_offset_of_supportedWriteFormats_4() { return static_cast<int32_t>(offsetof(MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9_StaticFields, ___supportedWriteFormats_4)); }
	inline RuntimeObject* get_supportedWriteFormats_4() const { return ___supportedWriteFormats_4; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_4() { return &___supportedWriteFormats_4; }
	inline void set_supportedWriteFormats_4(RuntimeObject* value)
	{
		___supportedWriteFormats_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_4), (void*)value);
	}
};


// ZXing.OneD.PlesseyWriter
struct PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144  : public OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC
{
public:

public:
};

struct PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields
{
public:
	// System.Int32[] ZXing.OneD.PlesseyWriter::startWidths
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___startWidths_1;
	// System.Int32[] ZXing.OneD.PlesseyWriter::terminationWidths
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___terminationWidths_2;
	// System.Int32[] ZXing.OneD.PlesseyWriter::endWidths
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___endWidths_3;
	// System.Int32[][] ZXing.OneD.PlesseyWriter::numberWidths
	Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* ___numberWidths_4;
	// System.Byte[] ZXing.OneD.PlesseyWriter::crcGrid
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___crcGrid_5;
	// System.Int32[] ZXing.OneD.PlesseyWriter::crc0Widths
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___crc0Widths_6;
	// System.Int32[] ZXing.OneD.PlesseyWriter::crc1Widths
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___crc1Widths_7;
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.PlesseyWriter::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_8;

public:
	inline static int32_t get_offset_of_startWidths_1() { return static_cast<int32_t>(offsetof(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields, ___startWidths_1)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_startWidths_1() const { return ___startWidths_1; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_startWidths_1() { return &___startWidths_1; }
	inline void set_startWidths_1(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___startWidths_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___startWidths_1), (void*)value);
	}

	inline static int32_t get_offset_of_terminationWidths_2() { return static_cast<int32_t>(offsetof(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields, ___terminationWidths_2)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_terminationWidths_2() const { return ___terminationWidths_2; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_terminationWidths_2() { return &___terminationWidths_2; }
	inline void set_terminationWidths_2(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___terminationWidths_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___terminationWidths_2), (void*)value);
	}

	inline static int32_t get_offset_of_endWidths_3() { return static_cast<int32_t>(offsetof(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields, ___endWidths_3)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_endWidths_3() const { return ___endWidths_3; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_endWidths_3() { return &___endWidths_3; }
	inline void set_endWidths_3(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___endWidths_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___endWidths_3), (void*)value);
	}

	inline static int32_t get_offset_of_numberWidths_4() { return static_cast<int32_t>(offsetof(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields, ___numberWidths_4)); }
	inline Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* get_numberWidths_4() const { return ___numberWidths_4; }
	inline Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF** get_address_of_numberWidths_4() { return &___numberWidths_4; }
	inline void set_numberWidths_4(Int32U5BU5DU5BU5D_t104DBF1B996084AA19567FD32B02EDF88D044FAF* value)
	{
		___numberWidths_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___numberWidths_4), (void*)value);
	}

	inline static int32_t get_offset_of_crcGrid_5() { return static_cast<int32_t>(offsetof(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields, ___crcGrid_5)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_crcGrid_5() const { return ___crcGrid_5; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_crcGrid_5() { return &___crcGrid_5; }
	inline void set_crcGrid_5(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___crcGrid_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___crcGrid_5), (void*)value);
	}

	inline static int32_t get_offset_of_crc0Widths_6() { return static_cast<int32_t>(offsetof(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields, ___crc0Widths_6)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_crc0Widths_6() const { return ___crc0Widths_6; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_crc0Widths_6() { return &___crc0Widths_6; }
	inline void set_crc0Widths_6(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___crc0Widths_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___crc0Widths_6), (void*)value);
	}

	inline static int32_t get_offset_of_crc1Widths_7() { return static_cast<int32_t>(offsetof(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields, ___crc1Widths_7)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_crc1Widths_7() const { return ___crc1Widths_7; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_crc1Widths_7() { return &___crc1Widths_7; }
	inline void set_crc1Widths_7(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___crc1Widths_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___crc1Widths_7), (void*)value);
	}

	inline static int32_t get_offset_of_supportedWriteFormats_8() { return static_cast<int32_t>(offsetof(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_StaticFields, ___supportedWriteFormats_8)); }
	inline RuntimeObject* get_supportedWriteFormats_8() const { return ___supportedWriteFormats_8; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_8() { return &___supportedWriteFormats_8; }
	inline void set_supportedWriteFormats_8(RuntimeObject* value)
	{
		___supportedWriteFormats_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_8), (void*)value);
	}
};


// ZXing.OneD.UPCEANWriter
struct UPCEANWriter_t23ED2678E9246D148A33E64E40C57596186A28BA  : public OneDimensionalCodeWriter_t2C07397BD9DF24DDA829E3F01B8971E7B2D1F1CC
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


// ZXing.Datamatrix.Encoder.X12Encoder
struct X12Encoder_t098F8ED199393060384BAB57E63D1E9AC4360AC0  : public C40Encoder_t0116F1C0E550E07A64EA97EDE0C17680F74AF079
{
public:

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1024
struct __StaticArrayInitTypeSizeU3D1024_t5278D08EEE44CE0D3B7BE38306380C0F87A3E44D 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D1024_t5278D08EEE44CE0D3B7BE38306380C0F87A3E44D__padding[1024];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=112
struct __StaticArrayInitTypeSizeU3D112_t290F90F1526E68AE8668FC82B33011167F425C02 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D112_t290F90F1526E68AE8668FC82B33011167F425C02__padding[112];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12
struct __StaticArrayInitTypeSizeU3D12_t412128B90A0EF5624EA9EB7E4B150B9A4FFC6512 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D12_t412128B90A0EF5624EA9EB7E4B150B9A4FFC6512__padding[12];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=124
struct __StaticArrayInitTypeSizeU3D124_t4FF4503262AF64104B9C722D2772A96E2168CFC0 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D124_t4FF4503262AF64104B9C722D2772A96E2168CFC0__padding[124];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128
struct __StaticArrayInitTypeSizeU3D128_t758D117DA8033F095948EA9951217DD7A6C4C1FA 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D128_t758D117DA8033F095948EA9951217DD7A6C4C1FA__padding[128];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=132
struct __StaticArrayInitTypeSizeU3D132_t987D44E7E90C74FA4A18126050D7F77CE57F630F 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D132_t987D44E7E90C74FA4A18126050D7F77CE57F630F__padding[132];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=136
struct __StaticArrayInitTypeSizeU3D136_t4F125442BC7A9430A22DC5F84D54D69E88B7E11D 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D136_t4F125442BC7A9430A22DC5F84D54D69E88B7E11D__padding[136];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=144
struct __StaticArrayInitTypeSizeU3D144_t775E0B2C629E4D8C7888F4D682D8D63B7D600BB4 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D144_t775E0B2C629E4D8C7888F4D682D8D63B7D600BB4__padding[144];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=148
struct __StaticArrayInitTypeSizeU3D148_t4A488F3C28ADDA24CBE7CF7CC365917DEDB40BAC 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D148_t4A488F3C28ADDA24CBE7CF7CC365917DEDB40BAC__padding[148];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=16
struct __StaticArrayInitTypeSizeU3D16_t036B1DC59FF4C102BD0D25D26C593A3F605EDB24 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D16_t036B1DC59FF4C102BD0D25D26C593A3F605EDB24__padding[16];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=168
struct __StaticArrayInitTypeSizeU3D168_tB06170CAF02C1C521C4B90C8683DA7D23FC0D6EE 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D168_tB06170CAF02C1C521C4B90C8683DA7D23FC0D6EE__padding[168];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=172
struct __StaticArrayInitTypeSizeU3D172_t4AB32C52F16C06FFAF31B02142FDDA7368EB5E4F 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D172_t4AB32C52F16C06FFAF31B02142FDDA7368EB5E4F__padding[172];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=192
struct __StaticArrayInitTypeSizeU3D192_t36654CAE25C613538C13D0B0C5DD817626BEB4C8 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D192_t36654CAE25C613538C13D0B0C5DD817626BEB4C8__padding[192];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=20
struct __StaticArrayInitTypeSizeU3D20_t810FEE47F0D9BF808548A5C6AD08543E21E80476 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D20_t810FEE47F0D9BF808548A5C6AD08543E21E80476__padding[20];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=2048
struct __StaticArrayInitTypeSizeU3D2048_t8E2204241324AB9285C33C52AD6321A98ECBE681 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D2048_t8E2204241324AB9285C33C52AD6321A98ECBE681__padding[2048];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=224
struct __StaticArrayInitTypeSizeU3D224_tF90D143454B3B8135B6D21201FCC918773749FF4 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D224_tF90D143454B3B8135B6D21201FCC918773749FF4__padding[224];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24
struct __StaticArrayInitTypeSizeU3D24_tC71D672FE83B60F32BACCB699F53B6454942307A 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D24_tC71D672FE83B60F32BACCB699F53B6454942307A__padding[24];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=248
struct __StaticArrayInitTypeSizeU3D248_tAD87A0C7EFD37BAB918EEBA0457C33B84F908905 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D248_tAD87A0C7EFD37BAB918EEBA0457C33B84F908905__padding[248];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256
struct __StaticArrayInitTypeSizeU3D256_t996A1FA6D437F3454DF87510EBF235384F3D70D8 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D256_t996A1FA6D437F3454DF87510EBF235384F3D70D8__padding[256];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=272
struct __StaticArrayInitTypeSizeU3D272_t902E47E647F7954A7841DC1D5FBD1252F226E215 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D272_t902E47E647F7954A7841DC1D5FBD1252F226E215__padding[272];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=28
struct __StaticArrayInitTypeSizeU3D28_t19E364D9C2EB77039D943C90FC660A8E3D5FB699 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D28_t19E364D9C2EB77039D943C90FC660A8E3D5FB699__padding[28];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=30
struct __StaticArrayInitTypeSizeU3D30_t1765907077CB6B608AC727B8DC18F7F5BB7AF180 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D30_t1765907077CB6B608AC727B8DC18F7F5BB7AF180__padding[30];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32
struct __StaticArrayInitTypeSizeU3D32_tB5A6F1B18D4CB4E4BB88FB70A5B8CD2FCDFF5584 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D32_tB5A6F1B18D4CB4E4BB88FB70A5B8CD2FCDFF5584__padding[32];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=3716
struct __StaticArrayInitTypeSizeU3D3716_t5BAF54F5ADBBBD4D21632A5F3D76C456AF15AF65 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D3716_t5BAF54F5ADBBBD4D21632A5F3D76C456AF15AF65__padding[3716];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384
struct __StaticArrayInitTypeSizeU3D384_tDE1B9B23F8F398511164886C0A025F3018BEFB77 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D384_tDE1B9B23F8F398511164886C0A025F3018BEFB77__padding[384];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40
struct __StaticArrayInitTypeSizeU3D40_t8F16A77FD457EC6493A968AC459EA119CBB08CB6 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D40_t8F16A77FD457EC6493A968AC459EA119CBB08CB6__padding[40];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=44
struct __StaticArrayInitTypeSizeU3D44_tAC16288BF3BCAFD1F1D22272DEE46F499F5559FA 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D44_tAC16288BF3BCAFD1F1D22272DEE46F499F5559FA__padding[44];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48
struct __StaticArrayInitTypeSizeU3D48_tFF71C9BF618D2F8CBC9963E25394FA6EB2882A14 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D48_tFF71C9BF618D2F8CBC9963E25394FA6EB2882A14__padding[48];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=512
struct __StaticArrayInitTypeSizeU3D512_t99A22D5A4A6CB05CBFD79C93FAE7A97A4236D351 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D512_t99A22D5A4A6CB05CBFD79C93FAE7A97A4236D351__padding[512];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56
struct __StaticArrayInitTypeSizeU3D56_t78FC779D843212CAC6308C54C51C8183AF801AD2 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D56_t78FC779D843212CAC6308C54C51C8183AF801AD2__padding[56];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64
struct __StaticArrayInitTypeSizeU3D64_tA21174035ECC99D37B2623C9A81510C376964ED6 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D64_tA21174035ECC99D37B2623C9A81510C376964ED6__padding[64];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72
struct __StaticArrayInitTypeSizeU3D72_tA19747DCAE72086182674E0D7BFDF88DE760C0AC 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D72_tA19747DCAE72086182674E0D7BFDF88DE760C0AC__padding[72];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80
struct __StaticArrayInitTypeSizeU3D80_t2CBE762349F3DF2EE051BFA49B0CEEC4FC99A238 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D80_t2CBE762349F3DF2EE051BFA49B0CEEC4FC99A238__padding[80];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=9
struct __StaticArrayInitTypeSizeU3D9_t50D8E57598788729D459F5718BDED983259C9F84 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D9_t50D8E57598788729D459F5718BDED983259C9F84__padding[9];
	};

public:
};


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=96
struct __StaticArrayInitTypeSizeU3D96_tCCDC1300A7B4C125406EC7C5439A563FA9C051CD 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D96_tCCDC1300A7B4C125406EC7C5439A563FA9C051CD__padding[96];
	};

public:
};


// ZXing.OneD.EAN13Writer
struct EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA  : public UPCEANWriter_t23ED2678E9246D148A33E64E40C57596186A28BA
{
public:

public:
};

struct EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA_StaticFields
{
public:
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.EAN13Writer::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_1;

public:
	inline static int32_t get_offset_of_supportedWriteFormats_1() { return static_cast<int32_t>(offsetof(EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA_StaticFields, ___supportedWriteFormats_1)); }
	inline RuntimeObject* get_supportedWriteFormats_1() const { return ___supportedWriteFormats_1; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_1() { return &___supportedWriteFormats_1; }
	inline void set_supportedWriteFormats_1(RuntimeObject* value)
	{
		___supportedWriteFormats_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_1), (void*)value);
	}
};


// ZXing.OneD.EAN8Writer
struct EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB  : public UPCEANWriter_t23ED2678E9246D148A33E64E40C57596186A28BA
{
public:

public:
};

struct EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB_StaticFields
{
public:
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.EAN8Writer::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_1;

public:
	inline static int32_t get_offset_of_supportedWriteFormats_1() { return static_cast<int32_t>(offsetof(EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB_StaticFields, ___supportedWriteFormats_1)); }
	inline RuntimeObject* get_supportedWriteFormats_1() const { return ___supportedWriteFormats_1; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_1() { return &___supportedWriteFormats_1; }
	inline void set_supportedWriteFormats_1(RuntimeObject* value)
	{
		___supportedWriteFormats_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_1), (void*)value);
	}
};


// System.Exception
struct Exception_t  : public RuntimeObject
{
public:
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t * ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject * ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject * ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* ___native_trace_ips_15;

public:
	inline static int32_t get_offset_of__className_1() { return static_cast<int32_t>(offsetof(Exception_t, ____className_1)); }
	inline String_t* get__className_1() const { return ____className_1; }
	inline String_t** get_address_of__className_1() { return &____className_1; }
	inline void set__className_1(String_t* value)
	{
		____className_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____className_1), (void*)value);
	}

	inline static int32_t get_offset_of__message_2() { return static_cast<int32_t>(offsetof(Exception_t, ____message_2)); }
	inline String_t* get__message_2() const { return ____message_2; }
	inline String_t** get_address_of__message_2() { return &____message_2; }
	inline void set__message_2(String_t* value)
	{
		____message_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____message_2), (void*)value);
	}

	inline static int32_t get_offset_of__data_3() { return static_cast<int32_t>(offsetof(Exception_t, ____data_3)); }
	inline RuntimeObject* get__data_3() const { return ____data_3; }
	inline RuntimeObject** get_address_of__data_3() { return &____data_3; }
	inline void set__data_3(RuntimeObject* value)
	{
		____data_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____data_3), (void*)value);
	}

	inline static int32_t get_offset_of__innerException_4() { return static_cast<int32_t>(offsetof(Exception_t, ____innerException_4)); }
	inline Exception_t * get__innerException_4() const { return ____innerException_4; }
	inline Exception_t ** get_address_of__innerException_4() { return &____innerException_4; }
	inline void set__innerException_4(Exception_t * value)
	{
		____innerException_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____innerException_4), (void*)value);
	}

	inline static int32_t get_offset_of__helpURL_5() { return static_cast<int32_t>(offsetof(Exception_t, ____helpURL_5)); }
	inline String_t* get__helpURL_5() const { return ____helpURL_5; }
	inline String_t** get_address_of__helpURL_5() { return &____helpURL_5; }
	inline void set__helpURL_5(String_t* value)
	{
		____helpURL_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____helpURL_5), (void*)value);
	}

	inline static int32_t get_offset_of__stackTrace_6() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTrace_6)); }
	inline RuntimeObject * get__stackTrace_6() const { return ____stackTrace_6; }
	inline RuntimeObject ** get_address_of__stackTrace_6() { return &____stackTrace_6; }
	inline void set__stackTrace_6(RuntimeObject * value)
	{
		____stackTrace_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTrace_6), (void*)value);
	}

	inline static int32_t get_offset_of__stackTraceString_7() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTraceString_7)); }
	inline String_t* get__stackTraceString_7() const { return ____stackTraceString_7; }
	inline String_t** get_address_of__stackTraceString_7() { return &____stackTraceString_7; }
	inline void set__stackTraceString_7(String_t* value)
	{
		____stackTraceString_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTraceString_7), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackTraceString_8() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackTraceString_8)); }
	inline String_t* get__remoteStackTraceString_8() const { return ____remoteStackTraceString_8; }
	inline String_t** get_address_of__remoteStackTraceString_8() { return &____remoteStackTraceString_8; }
	inline void set__remoteStackTraceString_8(String_t* value)
	{
		____remoteStackTraceString_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____remoteStackTraceString_8), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackIndex_9() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackIndex_9)); }
	inline int32_t get__remoteStackIndex_9() const { return ____remoteStackIndex_9; }
	inline int32_t* get_address_of__remoteStackIndex_9() { return &____remoteStackIndex_9; }
	inline void set__remoteStackIndex_9(int32_t value)
	{
		____remoteStackIndex_9 = value;
	}

	inline static int32_t get_offset_of__dynamicMethods_10() { return static_cast<int32_t>(offsetof(Exception_t, ____dynamicMethods_10)); }
	inline RuntimeObject * get__dynamicMethods_10() const { return ____dynamicMethods_10; }
	inline RuntimeObject ** get_address_of__dynamicMethods_10() { return &____dynamicMethods_10; }
	inline void set__dynamicMethods_10(RuntimeObject * value)
	{
		____dynamicMethods_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dynamicMethods_10), (void*)value);
	}

	inline static int32_t get_offset_of__HResult_11() { return static_cast<int32_t>(offsetof(Exception_t, ____HResult_11)); }
	inline int32_t get__HResult_11() const { return ____HResult_11; }
	inline int32_t* get_address_of__HResult_11() { return &____HResult_11; }
	inline void set__HResult_11(int32_t value)
	{
		____HResult_11 = value;
	}

	inline static int32_t get_offset_of__source_12() { return static_cast<int32_t>(offsetof(Exception_t, ____source_12)); }
	inline String_t* get__source_12() const { return ____source_12; }
	inline String_t** get_address_of__source_12() { return &____source_12; }
	inline void set__source_12(String_t* value)
	{
		____source_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____source_12), (void*)value);
	}

	inline static int32_t get_offset_of__safeSerializationManager_13() { return static_cast<int32_t>(offsetof(Exception_t, ____safeSerializationManager_13)); }
	inline SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * get__safeSerializationManager_13() const { return ____safeSerializationManager_13; }
	inline SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F ** get_address_of__safeSerializationManager_13() { return &____safeSerializationManager_13; }
	inline void set__safeSerializationManager_13(SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * value)
	{
		____safeSerializationManager_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____safeSerializationManager_13), (void*)value);
	}

	inline static int32_t get_offset_of_captured_traces_14() { return static_cast<int32_t>(offsetof(Exception_t, ___captured_traces_14)); }
	inline StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* get_captured_traces_14() const { return ___captured_traces_14; }
	inline StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971** get_address_of_captured_traces_14() { return &___captured_traces_14; }
	inline void set_captured_traces_14(StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* value)
	{
		___captured_traces_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___captured_traces_14), (void*)value);
	}

	inline static int32_t get_offset_of_native_trace_ips_15() { return static_cast<int32_t>(offsetof(Exception_t, ___native_trace_ips_15)); }
	inline IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* get_native_trace_ips_15() const { return ___native_trace_ips_15; }
	inline IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6** get_address_of_native_trace_ips_15() { return &___native_trace_ips_15; }
	inline void set_native_trace_ips_15(IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* value)
	{
		___native_trace_ips_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___native_trace_ips_15), (void*)value);
	}
};

struct Exception_t_StaticFields
{
public:
	// System.Object System.Exception::s_EDILock
	RuntimeObject * ___s_EDILock_0;

public:
	inline static int32_t get_offset_of_s_EDILock_0() { return static_cast<int32_t>(offsetof(Exception_t_StaticFields, ___s_EDILock_0)); }
	inline RuntimeObject * get_s_EDILock_0() const { return ___s_EDILock_0; }
	inline RuntimeObject ** get_address_of_s_EDILock_0() { return &___s_EDILock_0; }
	inline void set_s_EDILock_0(RuntimeObject * value)
	{
		___s_EDILock_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_EDILock_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};

// ZXing.Datamatrix.Encoder.SymbolShapeHint
struct SymbolShapeHint_t3F148EF5E6CEFBD88FC2A115D07F08729850FB36 
{
public:
	// System.Int32 ZXing.Datamatrix.Encoder.SymbolShapeHint::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(SymbolShapeHint_t3F148EF5E6CEFBD88FC2A115D07F08729850FB36, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// ZXing.OneD.UPCEWriter
struct UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019  : public UPCEANWriter_t23ED2678E9246D148A33E64E40C57596186A28BA
{
public:

public:
};

struct UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019_StaticFields
{
public:
	// System.Collections.Generic.IList`1<ZXing.BarcodeFormat> ZXing.OneD.UPCEWriter::supportedWriteFormats
	RuntimeObject* ___supportedWriteFormats_1;

public:
	inline static int32_t get_offset_of_supportedWriteFormats_1() { return static_cast<int32_t>(offsetof(UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019_StaticFields, ___supportedWriteFormats_1)); }
	inline RuntimeObject* get_supportedWriteFormats_1() const { return ___supportedWriteFormats_1; }
	inline RuntimeObject** get_address_of_supportedWriteFormats_1() { return &___supportedWriteFormats_1; }
	inline void set_supportedWriteFormats_1(RuntimeObject* value)
	{
		___supportedWriteFormats_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___supportedWriteFormats_1), (void*)value);
	}
};


// ZXing.OneD.Code128Writer/CType
struct CType_t918DF5FC18A10274725D200EA939706221056D48 
{
public:
	// System.Int32 ZXing.OneD.Code128Writer/CType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(CType_t918DF5FC18A10274725D200EA939706221056D48, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// ZXing.QrCode.Internal.Mode/Names
struct Names_tB20A1DEFF870AF4E79ADCC7184DE36B7B42E3A3B 
{
public:
	// System.Int32 ZXing.QrCode.Internal.Mode/Names::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Names_tB20A1DEFF870AF4E79ADCC7184DE36B7B42E3A3B, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// ZXing.Datamatrix.Encoder.EncoderContext
struct EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA  : public RuntimeObject
{
public:
	// System.String ZXing.Datamatrix.Encoder.EncoderContext::msg
	String_t* ___msg_0;
	// ZXing.Datamatrix.Encoder.SymbolShapeHint ZXing.Datamatrix.Encoder.EncoderContext::shape
	int32_t ___shape_1;
	// ZXing.Dimension ZXing.Datamatrix.Encoder.EncoderContext::minSize
	Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB * ___minSize_2;
	// ZXing.Dimension ZXing.Datamatrix.Encoder.EncoderContext::maxSize
	Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB * ___maxSize_3;
	// System.Text.StringBuilder ZXing.Datamatrix.Encoder.EncoderContext::codewords
	StringBuilder_t * ___codewords_4;
	// System.Int32 ZXing.Datamatrix.Encoder.EncoderContext::pos
	int32_t ___pos_5;
	// System.Int32 ZXing.Datamatrix.Encoder.EncoderContext::newEncoding
	int32_t ___newEncoding_6;
	// ZXing.Datamatrix.Encoder.SymbolInfo ZXing.Datamatrix.Encoder.EncoderContext::symbolInfo
	SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926 * ___symbolInfo_7;
	// System.Int32 ZXing.Datamatrix.Encoder.EncoderContext::skipAtEnd
	int32_t ___skipAtEnd_8;
	// System.Boolean ZXing.Datamatrix.Encoder.EncoderContext::<Fnc1CodewordIsWritten>k__BackingField
	bool ___U3CFnc1CodewordIsWrittenU3Ek__BackingField_10;

public:
	inline static int32_t get_offset_of_msg_0() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___msg_0)); }
	inline String_t* get_msg_0() const { return ___msg_0; }
	inline String_t** get_address_of_msg_0() { return &___msg_0; }
	inline void set_msg_0(String_t* value)
	{
		___msg_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___msg_0), (void*)value);
	}

	inline static int32_t get_offset_of_shape_1() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___shape_1)); }
	inline int32_t get_shape_1() const { return ___shape_1; }
	inline int32_t* get_address_of_shape_1() { return &___shape_1; }
	inline void set_shape_1(int32_t value)
	{
		___shape_1 = value;
	}

	inline static int32_t get_offset_of_minSize_2() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___minSize_2)); }
	inline Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB * get_minSize_2() const { return ___minSize_2; }
	inline Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB ** get_address_of_minSize_2() { return &___minSize_2; }
	inline void set_minSize_2(Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB * value)
	{
		___minSize_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___minSize_2), (void*)value);
	}

	inline static int32_t get_offset_of_maxSize_3() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___maxSize_3)); }
	inline Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB * get_maxSize_3() const { return ___maxSize_3; }
	inline Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB ** get_address_of_maxSize_3() { return &___maxSize_3; }
	inline void set_maxSize_3(Dimension_tB7BE8609BC35CC2A7E1333426019290CE5A0A2BB * value)
	{
		___maxSize_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___maxSize_3), (void*)value);
	}

	inline static int32_t get_offset_of_codewords_4() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___codewords_4)); }
	inline StringBuilder_t * get_codewords_4() const { return ___codewords_4; }
	inline StringBuilder_t ** get_address_of_codewords_4() { return &___codewords_4; }
	inline void set_codewords_4(StringBuilder_t * value)
	{
		___codewords_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___codewords_4), (void*)value);
	}

	inline static int32_t get_offset_of_pos_5() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___pos_5)); }
	inline int32_t get_pos_5() const { return ___pos_5; }
	inline int32_t* get_address_of_pos_5() { return &___pos_5; }
	inline void set_pos_5(int32_t value)
	{
		___pos_5 = value;
	}

	inline static int32_t get_offset_of_newEncoding_6() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___newEncoding_6)); }
	inline int32_t get_newEncoding_6() const { return ___newEncoding_6; }
	inline int32_t* get_address_of_newEncoding_6() { return &___newEncoding_6; }
	inline void set_newEncoding_6(int32_t value)
	{
		___newEncoding_6 = value;
	}

	inline static int32_t get_offset_of_symbolInfo_7() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___symbolInfo_7)); }
	inline SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926 * get_symbolInfo_7() const { return ___symbolInfo_7; }
	inline SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926 ** get_address_of_symbolInfo_7() { return &___symbolInfo_7; }
	inline void set_symbolInfo_7(SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926 * value)
	{
		___symbolInfo_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___symbolInfo_7), (void*)value);
	}

	inline static int32_t get_offset_of_skipAtEnd_8() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___skipAtEnd_8)); }
	inline int32_t get_skipAtEnd_8() const { return ___skipAtEnd_8; }
	inline int32_t* get_address_of_skipAtEnd_8() { return &___skipAtEnd_8; }
	inline void set_skipAtEnd_8(int32_t value)
	{
		___skipAtEnd_8 = value;
	}

	inline static int32_t get_offset_of_U3CFnc1CodewordIsWrittenU3Ek__BackingField_10() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA, ___U3CFnc1CodewordIsWrittenU3Ek__BackingField_10)); }
	inline bool get_U3CFnc1CodewordIsWrittenU3Ek__BackingField_10() const { return ___U3CFnc1CodewordIsWrittenU3Ek__BackingField_10; }
	inline bool* get_address_of_U3CFnc1CodewordIsWrittenU3Ek__BackingField_10() { return &___U3CFnc1CodewordIsWrittenU3Ek__BackingField_10; }
	inline void set_U3CFnc1CodewordIsWrittenU3Ek__BackingField_10(bool value)
	{
		___U3CFnc1CodewordIsWrittenU3Ek__BackingField_10 = value;
	}
};

struct EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA_StaticFields
{
public:
	// System.Text.Encoding ZXing.Datamatrix.Encoder.EncoderContext::encoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___encoding_9;

public:
	inline static int32_t get_offset_of_encoding_9() { return static_cast<int32_t>(offsetof(EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA_StaticFields, ___encoding_9)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_encoding_9() const { return ___encoding_9; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_encoding_9() { return &___encoding_9; }
	inline void set_encoding_9(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___encoding_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___encoding_9), (void*)value);
	}
};


// ZXing.WriterException
struct WriterException_t6223BBE3D60BC6E579D95555C6ADDD6C6EE5C6C4  : public Exception_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Int64[]
struct Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) int64_t m_Items[1];

public:
	inline int64_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int64_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int64_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int64_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int64_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int64_t value)
	{
		m_Items[index] = value;
	}
};
// System.Int64[][]
struct Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* m_Items[1];

public:
	inline Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// ZXing.QrCode.Internal.Version/ECB[]
struct ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * m_Items[1];

public:
	inline ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};



// System.Void System.Exception::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m0E9BEC861F6DBED197960E5BA23149543B1D7F5B (Exception_t * __this, const RuntimeMethod* method);
// System.Void System.Exception::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11 (Exception_t * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Void System.Exception::.ctor(System.String,System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_mB842BA6E644CDB9DB058F5628BB90DF5EF22C080 (Exception_t * __this, String_t* ___message0, Exception_t * ___innerException1, const RuntimeMethod* method);
// System.Void System.Text.StringBuilder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9 (StringBuilder_t * __this, const RuntimeMethod* method);
// System.Char ZXing.Datamatrix.Encoder.EncoderContext::get_CurrentChar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar EncoderContext_get_CurrentChar_m4B8AD1AA3EAED34669FDC6E2C0A4BB68831DCCE7 (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// System.Int32 ZXing.Datamatrix.Encoder.EncoderContext::get_Pos()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t EncoderContext_get_Pos_m51B5DAD7A5658F98F536FBCCD0D80301F54EAEF9_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// System.Void ZXing.Datamatrix.Encoder.EncoderContext::set_Pos(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EncoderContext_set_Pos_m99803C78205441684577036F6F80E309DD4DC105_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Int32 System.Text.StringBuilder::get_Length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t StringBuilder_get_Length_m680500263C59ACFD9582BF2AEEED8E92C87FF5C0 (StringBuilder_t * __this, const RuntimeMethod* method);
// System.Void ZXing.Datamatrix.Encoder.C40Encoder::writeNextTriplet(ZXing.Datamatrix.Encoder.EncoderContext,System.Text.StringBuilder)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void C40Encoder_writeNextTriplet_m647BE110B2BA25459DBE7CF4F63F65B33992BDB2 (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * ___context0, StringBuilder_t * ___buffer1, const RuntimeMethod* method);
// System.String ZXing.Datamatrix.Encoder.EncoderContext::get_Message()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* EncoderContext_get_Message_mC8E3254E4F7CB5C93FCC08725EDF0C74BB4B891C_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// System.Int32 ZXing.Datamatrix.Encoder.HighLevelEncoder::lookAheadTest(System.String,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t HighLevelEncoder_lookAheadTest_mC1EB6906CF3F11BFC49E02320AD14F486B994346 (String_t* ___msg0, int32_t ___startpos1, int32_t ___currentMode2, const RuntimeMethod* method);
// System.Void ZXing.Datamatrix.Encoder.EncoderContext::signalEncoderChange(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EncoderContext_signalEncoderChange_m2FBBC08ABE4274F8FB617FCF6DB2B6EB6CDAD9C1_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, int32_t ___encoding0, const RuntimeMethod* method);
// System.Boolean ZXing.Datamatrix.Encoder.EncoderContext::get_HasMoreCharacters()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EncoderContext_get_HasMoreCharacters_m5CEF0036CD47829C07BD96D1591CABA61374244A (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E (StringBuilder_t * __this, Il2CppChar ___value0, const RuntimeMethod* method);
// System.Void ZXing.Datamatrix.Encoder.HighLevelEncoder::illegalCharacter(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HighLevelEncoder_illegalCharacter_m00FFC66A21096E34209EF27BB5B93BFBD43DF957 (Il2CppChar ___c0, const RuntimeMethod* method);
// System.Void ZXing.Datamatrix.Encoder.EncoderContext::updateSymbolInfo()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EncoderContext_updateSymbolInfo_m76CC0E5B0C5A5663F7A24365507680E5EE36C0E6 (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// ZXing.Datamatrix.Encoder.SymbolInfo ZXing.Datamatrix.Encoder.EncoderContext::get_SymbolInfo()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926 * EncoderContext_get_SymbolInfo_mA08D46314B7D76A799A8226868B1745D1C0C6B6C_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// System.Int32 ZXing.Datamatrix.Encoder.EncoderContext::get_CodewordCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t EncoderContext_get_CodewordCount_mE23F6D0B8A7F6FC7E9B0686865586441B555FB42 (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// System.Int32 ZXing.Datamatrix.Encoder.EncoderContext::get_RemainingCharacters()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t EncoderContext_get_RemainingCharacters_mB52D7BF6916CE3931AE3026F2ACC6DA4EDA78B23 (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// System.Void ZXing.Datamatrix.Encoder.EncoderContext::writeCodeword(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EncoderContext_writeCodeword_m87EAC6B89199EC0B976FCE3CAC2E0B1C7F08098C (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, Il2CppChar ___codeword0, const RuntimeMethod* method);
// System.Int32 ZXing.Datamatrix.Encoder.EncoderContext::get_NewEncoding()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t EncoderContext_get_NewEncoding_m600E35A7D522DE3D5AFFBAD96117EB9F4B8CA785_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method);
// System.Void ZXing.Datamatrix.Encoder.C40Encoder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void C40Encoder__ctor_m3675A6EF71C7A3DFF5EB44C57BF0623616382456 (C40Encoder_t0116F1C0E550E07A64EA97EDE0C17680F74AF079 * __this, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void ZXing.MultiFormatWriter/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m433822110DB851C4804FF36F8A90C0CCA7B18D56 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.EAN8Writer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EAN8Writer__ctor_mB88A99787B9F4DC60FA44854519F6CE75A3656FC (EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.UPCEWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UPCEWriter__ctor_mDEC209C3FB10904D198C2A3EF887777F0250E198 (UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019 * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.EAN13Writer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EAN13Writer__ctor_mBD9D54E31D5067F8D6954AB25DD07EEF18E48052 (EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.UPCAWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UPCAWriter__ctor_m6756A0CF3B1CFDC346AE711796431808A878D108 (UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D * __this, const RuntimeMethod* method);
// System.Void ZXing.QrCode.QRCodeWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void QRCodeWriter__ctor_m93576470D4964EFC1D8882F0909A756B894FE555 (QRCodeWriter_t5AC22EE8E5200CD934B1C52F7BFA3B8E2F74CF65 * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.Code39Writer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Code39Writer__ctor_mA6321AAB54088EAB2430C018FE69EE92218D97E1 (Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010 * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.Code93Writer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Code93Writer__ctor_m57FC1E8C3F676EF0283EEC5FCF9DA9E4893CFF6E (Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00 * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.Code128Writer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Code128Writer__ctor_m0947F6699705E501AD70C4593F8CBD63A10A9B21 (Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.ITFWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ITFWriter__ctor_m62376AD90E55C4507873A759618CDA1994F98B33 (ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4 * __this, const RuntimeMethod* method);
// System.Void ZXing.PDF417.PDF417Writer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PDF417Writer__ctor_mF3433F18E908E98270A6926A1F9B48E5C71C0BB5 (PDF417Writer_t2D7A2CB7551E59A96AA739F49AFCFD2B8FCCC3F9 * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.CodaBarWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CodaBarWriter__ctor_mDC0D991FB5DA7FE07F4CB27A8B4D666C8EFC7EB9 (CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128 * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.MSIWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MSIWriter__ctor_m2FDA8C18BD8E79EAD79D861A45ABDD17187771BE (MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9 * __this, const RuntimeMethod* method);
// System.Void ZXing.OneD.PlesseyWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlesseyWriter__ctor_m04F90920251EB6E6E0BEBC55FBEB5A3C93E5990F (PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144 * __this, const RuntimeMethod* method);
// System.Void ZXing.Datamatrix.DataMatrixWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DataMatrixWriter__ctor_mAC8EF7464F389853A66890872C598C55FD64A10F (DataMatrixWriter_t50600BCE56F15967C245EAB5606415EC95514594 * __this, const RuntimeMethod* method);
// System.Void ZXing.Aztec.AztecWriter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AztecWriter__ctor_mEE6F71943F165B9B6600E7F6CC9559F7E993A949 (AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005 * __this, const RuntimeMethod* method);
// System.Int32 ZXing.QrCode.Internal.Version/ECB::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ECB_get_Count_m8E818F5E92B3FC1D3368555ED28ED7D8685BFDB8_inline (ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * __this, const RuntimeMethod* method);
// System.Int32 ZXing.QrCode.Internal.Version/ECBlocks::get_NumBlocks()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ECBlocks_get_NumBlocks_mF28B932E2998207B91123DDF75F342F3C35A33C7 (ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804 * __this, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void ZXing.WriterException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriterException__ctor_m9BDCB4C5FAFB0B3CD9EA609ECBB6DB74F30FEF58 (WriterException_t6223BBE3D60BC6E579D95555C6ADDD6C6EE5C6C4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Exception_t_il2cpp_TypeInfo_var);
		Exception__ctor_m0E9BEC861F6DBED197960E5BA23149543B1D7F5B(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void ZXing.WriterException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriterException__ctor_m722A01C4FBF44641A4382EB8826499803CA5D72F (WriterException_t6223BBE3D60BC6E579D95555C6ADDD6C6EE5C6C4 * __this, String_t* ___message0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___message0;
		IL2CPP_RUNTIME_CLASS_INIT(Exception_t_il2cpp_TypeInfo_var);
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void ZXing.WriterException::.ctor(System.String,System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriterException__ctor_m1E352B2FB4FDA720A7B2C61A04F02F94CA8A93C8 (WriterException_t6223BBE3D60BC6E579D95555C6ADDD6C6EE5C6C4 * __this, String_t* ___message0, Exception_t * ___innerExc1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___message0;
		Exception_t * L_1 = ___innerExc1;
		IL2CPP_RUNTIME_CLASS_INIT(Exception_t_il2cpp_TypeInfo_var);
		Exception__ctor_mB842BA6E644CDB9DB058F5628BB90DF5EF22C080(__this, L_0, L_1, /*hidden argument*/NULL);
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
// System.Int32 ZXing.Datamatrix.Encoder.X12Encoder::get_EncodingMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t X12Encoder_get_EncodingMode_mDE7F94F0A62A5485EB605842FA03146F8DD56781 (X12Encoder_t098F8ED199393060384BAB57E63D1E9AC4360AC0 * __this, const RuntimeMethod* method)
{
	{
		return 3;
	}
}
// System.Void ZXing.Datamatrix.Encoder.X12Encoder::encode(ZXing.Datamatrix.Encoder.EncoderContext)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X12Encoder_encode_mD4FBE8D2F4D62732F54CE5E8F6014FD9D3EBC49A (X12Encoder_t098F8ED199393060384BAB57E63D1E9AC4360AC0 * __this, EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * ___context0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	int32_t V_1 = 0;
	Il2CppChar V_2 = 0x0;
	int32_t V_3 = 0;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 ZXing.Datamatrix.Encoder.C40Encoder::get_EncodingMode() */, __this);
		V_1 = L_1;
		goto IL_005e;
	}

IL_000f:
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_2 = ___context0;
		NullCheck(L_2);
		Il2CppChar L_3;
		L_3 = EncoderContext_get_CurrentChar_m4B8AD1AA3EAED34669FDC6E2C0A4BB68831DCCE7(L_2, /*hidden argument*/NULL);
		V_2 = L_3;
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_4 = ___context0;
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_5 = L_4;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = EncoderContext_get_Pos_m51B5DAD7A5658F98F536FBCCD0D80301F54EAEF9_inline(L_5, /*hidden argument*/NULL);
		V_3 = L_6;
		int32_t L_7 = V_3;
		NullCheck(L_5);
		EncoderContext_set_Pos_m99803C78205441684577036F6F80E309DD4DC105_inline(L_5, ((int32_t)il2cpp_codegen_add((int32_t)L_7, (int32_t)1)), /*hidden argument*/NULL);
		Il2CppChar L_8 = V_2;
		StringBuilder_t * L_9 = V_0;
		int32_t L_10;
		L_10 = VirtFuncInvoker2< int32_t, Il2CppChar, StringBuilder_t * >::Invoke(8 /* System.Int32 ZXing.Datamatrix.Encoder.C40Encoder::encodeChar(System.Char,System.Text.StringBuilder) */, __this, L_8, L_9);
		StringBuilder_t * L_11 = V_0;
		NullCheck(L_11);
		int32_t L_12;
		L_12 = StringBuilder_get_Length_m680500263C59ACFD9582BF2AEEED8E92C87FF5C0(L_11, /*hidden argument*/NULL);
		if (((int32_t)((int32_t)L_12%(int32_t)3)))
		{
			goto IL_005e;
		}
	}
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_13 = ___context0;
		StringBuilder_t * L_14 = V_0;
		C40Encoder_writeNextTriplet_m647BE110B2BA25459DBE7CF4F63F65B33992BDB2(L_13, L_14, /*hidden argument*/NULL);
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_15 = ___context0;
		NullCheck(L_15);
		String_t* L_16;
		L_16 = EncoderContext_get_Message_mC8E3254E4F7CB5C93FCC08725EDF0C74BB4B891C_inline(L_15, /*hidden argument*/NULL);
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_17 = ___context0;
		NullCheck(L_17);
		int32_t L_18;
		L_18 = EncoderContext_get_Pos_m51B5DAD7A5658F98F536FBCCD0D80301F54EAEF9_inline(L_17, /*hidden argument*/NULL);
		int32_t L_19 = V_1;
		int32_t L_20;
		L_20 = HighLevelEncoder_lookAheadTest_mC1EB6906CF3F11BFC49E02320AD14F486B994346(L_16, L_18, L_19, /*hidden argument*/NULL);
		int32_t L_21 = V_1;
		if ((((int32_t)L_20) == ((int32_t)L_21)))
		{
			goto IL_005e;
		}
	}
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_22 = ___context0;
		NullCheck(L_22);
		EncoderContext_signalEncoderChange_m2FBBC08ABE4274F8FB617FCF6DB2B6EB6CDAD9C1_inline(L_22, 0, /*hidden argument*/NULL);
		goto IL_0066;
	}

IL_005e:
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_23 = ___context0;
		NullCheck(L_23);
		bool L_24;
		L_24 = EncoderContext_get_HasMoreCharacters_m5CEF0036CD47829C07BD96D1591CABA61374244A(L_23, /*hidden argument*/NULL);
		if (L_24)
		{
			goto IL_000f;
		}
	}

IL_0066:
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_25 = ___context0;
		StringBuilder_t * L_26 = V_0;
		VirtActionInvoker2< EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA *, StringBuilder_t * >::Invoke(7 /* System.Void ZXing.Datamatrix.Encoder.C40Encoder::handleEOD(ZXing.Datamatrix.Encoder.EncoderContext,System.Text.StringBuilder) */, __this, L_25, L_26);
		return;
	}
}
// System.Int32 ZXing.Datamatrix.Encoder.X12Encoder::encodeChar(System.Char,System.Text.StringBuilder)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t X12Encoder_encodeChar_m6C3DBAC8D576591DA69E25A0D99A6DBA1F0E4D61 (X12Encoder_t098F8ED199393060384BAB57E63D1E9AC4360AC0 * __this, Il2CppChar ___c0, StringBuilder_t * ___sb1, const RuntimeMethod* method)
{
	{
		Il2CppChar L_0 = ___c0;
		if ((!(((uint32_t)L_0) <= ((uint32_t)((int32_t)32)))))
		{
			goto IL_0011;
		}
	}
	{
		Il2CppChar L_1 = ___c0;
		if ((((int32_t)L_1) == ((int32_t)((int32_t)13))))
		{
			goto IL_001d;
		}
	}
	{
		Il2CppChar L_2 = ___c0;
		if ((((int32_t)L_2) == ((int32_t)((int32_t)32))))
		{
			goto IL_003b;
		}
	}
	{
		goto IL_0045;
	}

IL_0011:
	{
		Il2CppChar L_3 = ___c0;
		if ((((int32_t)L_3) == ((int32_t)((int32_t)42))))
		{
			goto IL_0027;
		}
	}
	{
		Il2CppChar L_4 = ___c0;
		if ((((int32_t)L_4) == ((int32_t)((int32_t)62))))
		{
			goto IL_0031;
		}
	}
	{
		goto IL_0045;
	}

IL_001d:
	{
		StringBuilder_t * L_5 = ___sb1;
		NullCheck(L_5);
		StringBuilder_t * L_6;
		L_6 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_5, 0, /*hidden argument*/NULL);
		goto IL_0080;
	}

IL_0027:
	{
		StringBuilder_t * L_7 = ___sb1;
		NullCheck(L_7);
		StringBuilder_t * L_8;
		L_8 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_7, 1, /*hidden argument*/NULL);
		goto IL_0080;
	}

IL_0031:
	{
		StringBuilder_t * L_9 = ___sb1;
		NullCheck(L_9);
		StringBuilder_t * L_10;
		L_10 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_9, 2, /*hidden argument*/NULL);
		goto IL_0080;
	}

IL_003b:
	{
		StringBuilder_t * L_11 = ___sb1;
		NullCheck(L_11);
		StringBuilder_t * L_12;
		L_12 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_11, 3, /*hidden argument*/NULL);
		goto IL_0080;
	}

IL_0045:
	{
		Il2CppChar L_13 = ___c0;
		if ((((int32_t)L_13) < ((int32_t)((int32_t)48))))
		{
			goto IL_005f;
		}
	}
	{
		Il2CppChar L_14 = ___c0;
		if ((((int32_t)L_14) > ((int32_t)((int32_t)57))))
		{
			goto IL_005f;
		}
	}
	{
		StringBuilder_t * L_15 = ___sb1;
		Il2CppChar L_16 = ___c0;
		NullCheck(L_15);
		StringBuilder_t * L_17;
		L_17 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_15, ((int32_t)((uint16_t)((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_16, (int32_t)((int32_t)48))), (int32_t)4)))), /*hidden argument*/NULL);
		goto IL_0080;
	}

IL_005f:
	{
		Il2CppChar L_18 = ___c0;
		if ((((int32_t)L_18) < ((int32_t)((int32_t)65))))
		{
			goto IL_007a;
		}
	}
	{
		Il2CppChar L_19 = ___c0;
		if ((((int32_t)L_19) > ((int32_t)((int32_t)90))))
		{
			goto IL_007a;
		}
	}
	{
		StringBuilder_t * L_20 = ___sb1;
		Il2CppChar L_21 = ___c0;
		NullCheck(L_20);
		StringBuilder_t * L_22;
		L_22 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_20, ((int32_t)((uint16_t)((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_21, (int32_t)((int32_t)65))), (int32_t)((int32_t)14))))), /*hidden argument*/NULL);
		goto IL_0080;
	}

IL_007a:
	{
		Il2CppChar L_23 = ___c0;
		HighLevelEncoder_illegalCharacter_m00FFC66A21096E34209EF27BB5B93BFBD43DF957(L_23, /*hidden argument*/NULL);
	}

IL_0080:
	{
		return 1;
	}
}
// System.Void ZXing.Datamatrix.Encoder.X12Encoder::handleEOD(ZXing.Datamatrix.Encoder.EncoderContext,System.Text.StringBuilder)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X12Encoder_handleEOD_m431712179599A1123D9F50281717319EDC715D8F (X12Encoder_t098F8ED199393060384BAB57E63D1E9AC4360AC0 * __this, EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * ___context0, StringBuilder_t * ___buffer1, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_0 = ___context0;
		NullCheck(L_0);
		EncoderContext_updateSymbolInfo_m76CC0E5B0C5A5663F7A24365507680E5EE36C0E6(L_0, /*hidden argument*/NULL);
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_1 = ___context0;
		NullCheck(L_1);
		SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926 * L_2;
		L_2 = EncoderContext_get_SymbolInfo_mA08D46314B7D76A799A8226868B1745D1C0C6B6C_inline(L_1, /*hidden argument*/NULL);
		NullCheck(L_2);
		int32_t L_3 = L_2->get_dataCapacity_3();
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_4 = ___context0;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = EncoderContext_get_CodewordCount_mE23F6D0B8A7F6FC7E9B0686865586441B555FB42(L_4, /*hidden argument*/NULL);
		V_0 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_3, (int32_t)L_5));
		StringBuilder_t * L_6 = ___buffer1;
		NullCheck(L_6);
		int32_t L_7;
		L_7 = StringBuilder_get_Length_m680500263C59ACFD9582BF2AEEED8E92C87FF5C0(L_6, /*hidden argument*/NULL);
		V_1 = L_7;
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_8 = ___context0;
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_9 = L_8;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = EncoderContext_get_Pos_m51B5DAD7A5658F98F536FBCCD0D80301F54EAEF9_inline(L_9, /*hidden argument*/NULL);
		int32_t L_11 = V_1;
		NullCheck(L_9);
		EncoderContext_set_Pos_m99803C78205441684577036F6F80E309DD4DC105_inline(L_9, ((int32_t)il2cpp_codegen_subtract((int32_t)L_10, (int32_t)L_11)), /*hidden argument*/NULL);
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_12 = ___context0;
		NullCheck(L_12);
		int32_t L_13;
		L_13 = EncoderContext_get_RemainingCharacters_mB52D7BF6916CE3931AE3026F2ACC6DA4EDA78B23(L_12, /*hidden argument*/NULL);
		if ((((int32_t)L_13) > ((int32_t)1)))
		{
			goto IL_0044;
		}
	}
	{
		int32_t L_14 = V_0;
		if ((((int32_t)L_14) > ((int32_t)1)))
		{
			goto IL_0044;
		}
	}
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_15 = ___context0;
		NullCheck(L_15);
		int32_t L_16;
		L_16 = EncoderContext_get_RemainingCharacters_mB52D7BF6916CE3931AE3026F2ACC6DA4EDA78B23(L_15, /*hidden argument*/NULL);
		int32_t L_17 = V_0;
		if ((((int32_t)L_16) == ((int32_t)L_17)))
		{
			goto IL_004f;
		}
	}

IL_0044:
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_18 = ___context0;
		NullCheck(L_18);
		EncoderContext_writeCodeword_m87EAC6B89199EC0B976FCE3CAC2E0B1C7F08098C(L_18, ((int32_t)254), /*hidden argument*/NULL);
	}

IL_004f:
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_19 = ___context0;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = EncoderContext_get_NewEncoding_m600E35A7D522DE3D5AFFBAD96117EB9F4B8CA785_inline(L_19, /*hidden argument*/NULL);
		if ((((int32_t)L_20) >= ((int32_t)0)))
		{
			goto IL_005f;
		}
	}
	{
		EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * L_21 = ___context0;
		NullCheck(L_21);
		EncoderContext_signalEncoderChange_m2FBBC08ABE4274F8FB617FCF6DB2B6EB6CDAD9C1_inline(L_21, 0, /*hidden argument*/NULL);
	}

IL_005f:
	{
		return;
	}
}
// System.Void ZXing.Datamatrix.Encoder.X12Encoder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X12Encoder__ctor_mAB28D87FE782434C06D58091B149DE7F43B4E132 (X12Encoder_t098F8ED199393060384BAB57E63D1E9AC4360AC0 * __this, const RuntimeMethod* method)
{
	{
		C40Encoder__ctor_m3675A6EF71C7A3DFF5EB44C57BF0623616382456(__this, /*hidden argument*/NULL);
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
// System.Void BigIntegerLibrary.Base10BigInteger/DigitContainer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DigitContainer__ctor_m07BC0633E68E311EA3AF80586BF001C513EE7F40 (DigitContainer_t67BCA9FC3E44AC0D7DC486704701B2171F8546E8 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* L_0 = (Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC*)(Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC*)SZArrayNew(Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC_il2cpp_TypeInfo_var, (uint32_t)((int32_t)200));
		__this->set_digits_0(L_0);
		return;
	}
}
// System.Int64 BigIntegerLibrary.Base10BigInteger/DigitContainer::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t DigitContainer_get_Item_m5D1C5EA46080987A0389D7D6B9C6E1838EA6E020 (DigitContainer_t67BCA9FC3E44AC0D7DC486704701B2171F8546E8 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* V_1 = NULL;
	{
		int32_t L_0 = ___index0;
		V_0 = ((int32_t)((int32_t)L_0>>(int32_t)5));
		Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* L_1 = __this->get_digits_0();
		int32_t L_2 = V_0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_4 = (Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)(L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_1 = L_4;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_5 = V_1;
		if (!L_5)
		{
			goto IL_0017;
		}
	}
	{
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_6 = V_1;
		int32_t L_7 = ___index0;
		NullCheck(L_6);
		int32_t L_8 = ((int32_t)((int32_t)L_7%(int32_t)((int32_t)32)));
		int64_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		return L_9;
	}

IL_0017:
	{
		return ((int64_t)((int64_t)0));
	}
}
// System.Void BigIntegerLibrary.Base10BigInteger/DigitContainer::set_Item(System.Int32,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DigitContainer_set_Item_mC1327B884BE750E4BC3C4D45076FDF65A62D6D9E (DigitContainer_t67BCA9FC3E44AC0D7DC486704701B2171F8546E8 * __this, int32_t ___index0, int64_t ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* V_1 = NULL;
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* G_B2_0 = NULL;
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* G_B1_0 = NULL;
	{
		int32_t L_0 = ___index0;
		V_0 = ((int32_t)((int32_t)L_0>>(int32_t)5));
		Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* L_1 = __this->get_digits_0();
		int32_t L_2 = V_0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_4 = (Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)(L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_5 = L_4;
		G_B1_0 = L_5;
		if (L_5)
		{
			G_B2_0 = L_5;
			goto IL_0022;
		}
	}
	{
		Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* L_6 = __this->get_digits_0();
		int32_t L_7 = V_0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_8 = (Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)(Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)SZArrayNew(Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6_il2cpp_TypeInfo_var, (uint32_t)((int32_t)32));
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_9 = L_8;
		V_1 = L_9;
		NullCheck(L_6);
		ArrayElementTypeCheck (L_6, L_9);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)L_9);
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_10 = V_1;
		G_B2_0 = L_10;
	}

IL_0022:
	{
		int32_t L_11 = ___index0;
		int64_t L_12 = ___value1;
		NullCheck(G_B2_0);
		(G_B2_0)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)((int32_t)L_11%(int32_t)((int32_t)32)))), (int64_t)L_12);
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
// System.Void BigIntegerLibrary.BigInteger/DigitContainer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DigitContainer__ctor_m81B19086062AEB9CD30E8DC12A2D5AC07EE6FABA (DigitContainer_tE6C3DF6764570ADB5B141B781C8E6B082937C72B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* L_0 = (Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC*)(Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC*)SZArrayNew(Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC_il2cpp_TypeInfo_var, (uint32_t)((int32_t)80));
		__this->set_digits_0(L_0);
		return;
	}
}
// System.Int64 BigIntegerLibrary.BigInteger/DigitContainer::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t DigitContainer_get_Item_m9CB68E35A0A57B583A9180F3D10ACA13522C02E2 (DigitContainer_tE6C3DF6764570ADB5B141B781C8E6B082937C72B * __this, int32_t ___index0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* V_1 = NULL;
	{
		int32_t L_0 = ___index0;
		V_0 = ((int32_t)((int32_t)L_0>>(int32_t)4));
		Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* L_1 = __this->get_digits_0();
		int32_t L_2 = V_0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_4 = (Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)(L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_1 = L_4;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_5 = V_1;
		if (!L_5)
		{
			goto IL_0017;
		}
	}
	{
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_6 = V_1;
		int32_t L_7 = ___index0;
		NullCheck(L_6);
		int32_t L_8 = ((int32_t)((int32_t)L_7%(int32_t)((int32_t)16)));
		int64_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		return L_9;
	}

IL_0017:
	{
		return ((int64_t)((int64_t)0));
	}
}
// System.Void BigIntegerLibrary.BigInteger/DigitContainer::set_Item(System.Int32,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DigitContainer_set_Item_m24B4322A402FCFFE26E4F08A9A945AF35F21EB1F (DigitContainer_tE6C3DF6764570ADB5B141B781C8E6B082937C72B * __this, int32_t ___index0, int64_t ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* V_1 = NULL;
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* G_B2_0 = NULL;
	Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* G_B1_0 = NULL;
	{
		int32_t L_0 = ___index0;
		V_0 = ((int32_t)((int32_t)L_0>>(int32_t)4));
		Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* L_1 = __this->get_digits_0();
		int32_t L_2 = V_0;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_4 = (Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)(L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_5 = L_4;
		G_B1_0 = L_5;
		if (L_5)
		{
			G_B2_0 = L_5;
			goto IL_0022;
		}
	}
	{
		Int64U5BU5DU5BU5D_t5237BA0F53E06948ADC63C3B2D68D7EEC8CBD2AC* L_6 = __this->get_digits_0();
		int32_t L_7 = V_0;
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_8 = (Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)(Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)SZArrayNew(Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6_il2cpp_TypeInfo_var, (uint32_t)((int32_t)16));
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_9 = L_8;
		V_1 = L_9;
		NullCheck(L_6);
		ArrayElementTypeCheck (L_6, L_9);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6*)L_9);
		Int64U5BU5D_tCA61E42872C63A4286B24EEE6E0650143B43DCE6* L_10 = V_1;
		G_B2_0 = L_10;
	}

IL_0022:
	{
		int32_t L_11 = ___index0;
		int64_t L_12 = ___value1;
		NullCheck(G_B2_0);
		(G_B2_0)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)((int32_t)L_11%(int32_t)((int32_t)16)))), (int64_t)L_12);
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
// System.Void ZXing.MultiFormatWriter/<>c::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_m78B0F1048B8A4C96461C2EA024799A34A3B6F599 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * L_0 = (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD *)il2cpp_codegen_object_new(U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_il2cpp_TypeInfo_var);
		U3CU3Ec__ctor_m433822110DB851C4804FF36F8A90C0CCA7B18D56(L_0, /*hidden argument*/NULL);
		((U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD_il2cpp_TypeInfo_var))->set_U3CU3E9_0(L_0);
		return;
	}
}
// System.Void ZXing.MultiFormatWriter/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m433822110DB851C4804FF36F8A90C0CCA7B18D56 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_0_m14B462E710CAB3F97D539AFBA01B6B6C8CBE6538 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB * L_0 = (EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB *)il2cpp_codegen_object_new(EAN8Writer_tA0D9E45101E894B7A0794DFAD9C976CED9607BDB_il2cpp_TypeInfo_var);
		EAN8Writer__ctor_mB88A99787B9F4DC60FA44854519F6CE75A3656FC(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_1()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_1_m7F27C29D2EF366740CB8E6414728BB712199D2C3 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019 * L_0 = (UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019 *)il2cpp_codegen_object_new(UPCEWriter_t944DF4C563803B4E14228ED46F95B5D3E6961019_il2cpp_TypeInfo_var);
		UPCEWriter__ctor_mDEC209C3FB10904D198C2A3EF887777F0250E198(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_2()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_2_mD9EF492BDF4658862D24129FF7CE02D8BB0E9EA6 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA * L_0 = (EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA *)il2cpp_codegen_object_new(EAN13Writer_t0B737FEA6465D06ED27DD001A0A78E7310C781BA_il2cpp_TypeInfo_var);
		EAN13Writer__ctor_mBD9D54E31D5067F8D6954AB25DD07EEF18E48052(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_3()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_3_m64D04C8F8EF0A497A2D1D61A2820F1974B1F140B (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D * L_0 = (UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D *)il2cpp_codegen_object_new(UPCAWriter_t8C38015D4DAC68BA398027630E2D95C7160ADC4D_il2cpp_TypeInfo_var);
		UPCAWriter__ctor_m6756A0CF3B1CFDC346AE711796431808A878D108(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_4()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_4_m07342B75BE18F95189FC646A9AD39AF55FCC2ACF (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&QRCodeWriter_t5AC22EE8E5200CD934B1C52F7BFA3B8E2F74CF65_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		QRCodeWriter_t5AC22EE8E5200CD934B1C52F7BFA3B8E2F74CF65 * L_0 = (QRCodeWriter_t5AC22EE8E5200CD934B1C52F7BFA3B8E2F74CF65 *)il2cpp_codegen_object_new(QRCodeWriter_t5AC22EE8E5200CD934B1C52F7BFA3B8E2F74CF65_il2cpp_TypeInfo_var);
		QRCodeWriter__ctor_m93576470D4964EFC1D8882F0909A756B894FE555(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_5()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_5_m402D0C0A0FC19246091836D17A6119ADF38EB98B (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010 * L_0 = (Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010 *)il2cpp_codegen_object_new(Code39Writer_t06F9753FE350B40DD21D79FF71B3A34EA83B5010_il2cpp_TypeInfo_var);
		Code39Writer__ctor_mA6321AAB54088EAB2430C018FE69EE92218D97E1(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_6()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_6_m505F86A00B4D331D803B4D52FC433E1DE42CCDD6 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00 * L_0 = (Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00 *)il2cpp_codegen_object_new(Code93Writer_t947F1275B947AFA6D20F2E2BA9788AAEA3E7FB00_il2cpp_TypeInfo_var);
		Code93Writer__ctor_m57FC1E8C3F676EF0283EEC5FCF9DA9E4893CFF6E(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_7()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_7_m51D4A24EC898BB8F967D30FC0EF1F1384314874D (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE * L_0 = (Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE *)il2cpp_codegen_object_new(Code128Writer_tD2648838968C091719618F3FB2CB91FC2BB137CE_il2cpp_TypeInfo_var);
		Code128Writer__ctor_m0947F6699705E501AD70C4593F8CBD63A10A9B21(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_8_mFE7B11B376E52ABF2B6C19E53D052E84FE3ED376 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4 * L_0 = (ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4 *)il2cpp_codegen_object_new(ITFWriter_tC78506F1799F54103BED659FCC896B97AE793AA4_il2cpp_TypeInfo_var);
		ITFWriter__ctor_m62376AD90E55C4507873A759618CDA1994F98B33(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_9()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_9_mB46BE8A1D2AC280DC8E9D198AF81D8415A136912 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PDF417Writer_t2D7A2CB7551E59A96AA739F49AFCFD2B8FCCC3F9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PDF417Writer_t2D7A2CB7551E59A96AA739F49AFCFD2B8FCCC3F9 * L_0 = (PDF417Writer_t2D7A2CB7551E59A96AA739F49AFCFD2B8FCCC3F9 *)il2cpp_codegen_object_new(PDF417Writer_t2D7A2CB7551E59A96AA739F49AFCFD2B8FCCC3F9_il2cpp_TypeInfo_var);
		PDF417Writer__ctor_mF3433F18E908E98270A6926A1F9B48E5C71C0BB5(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_10()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_10_mD1BA1DC5157DD7198E8D8305A8CFB02CCA17D901 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128 * L_0 = (CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128 *)il2cpp_codegen_object_new(CodaBarWriter_tE5E2FB3F3A4F6B8967DE74084C1EBA0316342128_il2cpp_TypeInfo_var);
		CodaBarWriter__ctor_mDC0D991FB5DA7FE07F4CB27A8B4D666C8EFC7EB9(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_11()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_11_m0E7D09FA7BDDE59594377C99C29C3CA2817873CC (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9 * L_0 = (MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9 *)il2cpp_codegen_object_new(MSIWriter_t62EFB67D1F817F4EA2ECC6ABB9635DC2319BE3A9_il2cpp_TypeInfo_var);
		MSIWriter__ctor_m2FDA8C18BD8E79EAD79D861A45ABDD17187771BE(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_12()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_12_m25FE9299A14575BD82804FEBD6611753A6298FD1 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144 * L_0 = (PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144 *)il2cpp_codegen_object_new(PlesseyWriter_t8CAB1803787457E1318EF5A4791AED13BCC58144_il2cpp_TypeInfo_var);
		PlesseyWriter__ctor_m04F90920251EB6E6E0BEBC55FBEB5A3C93E5990F(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_13()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_13_mBF7528CFF05EEAE995881604ADC1EBC144DE79F2 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DataMatrixWriter_t50600BCE56F15967C245EAB5606415EC95514594_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		DataMatrixWriter_t50600BCE56F15967C245EAB5606415EC95514594 * L_0 = (DataMatrixWriter_t50600BCE56F15967C245EAB5606415EC95514594 *)il2cpp_codegen_object_new(DataMatrixWriter_t50600BCE56F15967C245EAB5606415EC95514594_il2cpp_TypeInfo_var);
		DataMatrixWriter__ctor_mAC8EF7464F389853A66890872C598C55FD64A10F(L_0, /*hidden argument*/NULL);
		return L_0;
	}
}
// ZXing.Writer ZXing.MultiFormatWriter/<>c::<.cctor>b__1_14()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CU3Ec_U3C_cctorU3Eb__1_14_m88DE919C83A8595E4D80D7333090BBB6F5D56912 (U3CU3Ec_t0466484006627AED4AB3804109FFB65C747034DD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005 * L_0 = (AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005 *)il2cpp_codegen_object_new(AztecWriter_tA2CD6731FBF7DBAAD7F0D1BACEEB926CE8D15005_il2cpp_TypeInfo_var);
		AztecWriter__ctor_mEE6F71943F165B9B6600E7F6CC9559F7E993A949(L_0, /*hidden argument*/NULL);
		return L_0;
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
// System.Void ZXing.QrCode.Internal.Version/ECB::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ECB__ctor_m69C4AE1D65380C1AE4A19A7EB507CE094134BC8B (ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * __this, int32_t ___count0, int32_t ___dataCodewords1, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___count0;
		__this->set_count_0(L_0);
		int32_t L_1 = ___dataCodewords1;
		__this->set_dataCodewords_1(L_1);
		return;
	}
}
// System.Int32 ZXing.QrCode.Internal.Version/ECB::get_Count()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ECB_get_Count_m8E818F5E92B3FC1D3368555ED28ED7D8685BFDB8 (ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_count_0();
		return L_0;
	}
}
// System.Int32 ZXing.QrCode.Internal.Version/ECB::get_DataCodewords()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ECB_get_DataCodewords_m7BE1BCE90AB2CF24A383CB98C7ABC754A367B56E (ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_dataCodewords_1();
		return L_0;
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
// System.Void ZXing.QrCode.Internal.Version/ECBlocks::.ctor(System.Int32,ZXing.QrCode.Internal.Version/ECB[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ECBlocks__ctor_m78E82884D5FFE2503D5F061A28170FD1E64F2616 (ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804 * __this, int32_t ___ecCodewordsPerBlock0, ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* ___ecBlocks1, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___ecCodewordsPerBlock0;
		__this->set_ecCodewordsPerBlock_0(L_0);
		ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* L_1 = ___ecBlocks1;
		__this->set_ecBlocks_1(L_1);
		return;
	}
}
// System.Int32 ZXing.QrCode.Internal.Version/ECBlocks::get_ECCodewordsPerBlock()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ECBlocks_get_ECCodewordsPerBlock_m35077BDC1B56FBA334FB5083C4A4E6BDBDE037EA (ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_ecCodewordsPerBlock_0();
		return L_0;
	}
}
// System.Int32 ZXing.QrCode.Internal.Version/ECBlocks::get_NumBlocks()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ECBlocks_get_NumBlocks_mF28B932E2998207B91123DDF75F342F3C35A33C7 (ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* V_1 = NULL;
	int32_t V_2 = 0;
	ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * V_3 = NULL;
	{
		V_0 = 0;
		ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* L_0 = __this->get_ecBlocks_1();
		V_1 = L_0;
		V_2 = 0;
		goto IL_001e;
	}

IL_000d:
	{
		ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* L_1 = V_1;
		int32_t L_2 = V_2;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_3 = L_4;
		int32_t L_5 = V_0;
		ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * L_6 = V_3;
		NullCheck(L_6);
		int32_t L_7;
		L_7 = ECB_get_Count_m8E818F5E92B3FC1D3368555ED28ED7D8685BFDB8_inline(L_6, /*hidden argument*/NULL);
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_5, (int32_t)L_7));
		int32_t L_8 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1));
	}

IL_001e:
	{
		int32_t L_9 = V_2;
		ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* L_10 = V_1;
		NullCheck(L_10);
		if ((((int32_t)L_9) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_10)->max_length))))))
		{
			goto IL_000d;
		}
	}
	{
		int32_t L_11 = V_0;
		return L_11;
	}
}
// System.Int32 ZXing.QrCode.Internal.Version/ECBlocks::get_TotalECCodewords()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ECBlocks_get_TotalECCodewords_m3A22DB2AB527CA2B72F6ED237F57FB010C5C2054 (ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_ecCodewordsPerBlock_0();
		int32_t L_1;
		L_1 = ECBlocks_get_NumBlocks_mF28B932E2998207B91123DDF75F342F3C35A33C7(__this, /*hidden argument*/NULL);
		return ((int32_t)il2cpp_codegen_multiply((int32_t)L_0, (int32_t)L_1));
	}
}
// ZXing.QrCode.Internal.Version/ECB[] ZXing.QrCode.Internal.Version/ECBlocks::getECBlocks()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* ECBlocks_getECBlocks_mD2A781FBB00CA13C5B796EC4DE3BA9736BADD134 (ECBlocks_t5AD99641FC9C4D0CAA6D65D57AE987C096826804 * __this, const RuntimeMethod* method)
{
	{
		ECBU5BU5D_tC3D3ECEADF4776832CAE0EEB69402D08112F43DC* L_0 = __this->get_ecBlocks_1();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t EncoderContext_get_Pos_m51B5DAD7A5658F98F536FBCCD0D80301F54EAEF9_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_pos_5();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EncoderContext_set_Pos_m99803C78205441684577036F6F80E309DD4DC105_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_pos_5(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* EncoderContext_get_Message_mC8E3254E4F7CB5C93FCC08725EDF0C74BB4B891C_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method)
{
	{
		String_t* L_0 = __this->get_msg_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void EncoderContext_signalEncoderChange_m2FBBC08ABE4274F8FB617FCF6DB2B6EB6CDAD9C1_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, int32_t ___encoding0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___encoding0;
		__this->set_newEncoding_6(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926 * EncoderContext_get_SymbolInfo_mA08D46314B7D76A799A8226868B1745D1C0C6B6C_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method)
{
	{
		SymbolInfo_t3056602EB0C2BFCB1083AF3BE9E3E955D0988926 * L_0 = __this->get_symbolInfo_7();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t EncoderContext_get_NewEncoding_m600E35A7D522DE3D5AFFBAD96117EB9F4B8CA785_inline (EncoderContext_tA3E091D056497F3B61DB8E263FEA06D64A57D1AA * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_newEncoding_6();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t ECB_get_Count_m8E818F5E92B3FC1D3368555ED28ED7D8685BFDB8_inline (ECB_t6FA3814A500B6A83826000A8D6EE464F3E9DA7E2 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_count_0();
		return L_0;
	}
}
