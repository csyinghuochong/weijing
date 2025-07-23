
//
//  BDTGErrorCode.h
//  Pods
//
//  Created by chenzhendong.ok@bytedance.com on 2022/7/23.
//

#ifndef BDTGErrorCode_h
#define BDTGErrorCode_h

FOUNDATION_EXPORT NSString *const BDTGErrorDomain;

typedef NS_ENUM(NSInteger, BDTGErrorCode) {
    BDTGErrorCodeSuccess = 0,
    BDTGErrorCodeUnknown = -1,

    BDTGErrorCodeInvalidParameter = 900,
    BDTGErrorCodeInvalidGetTicketRequest = 901,
    BDTGErrorCodeInvalidUseTicketRequest = 902,

    BDTGErrorCodeUnsupported = 1000,

    BDTGErrorCodeLoadCertFail = 2000,
    BDTGErrorCodeLoadCertNoCSR = 2001,

    BDTGErrorCodeInvalidPublicKeyInfo = 3000,
    BDTGErrorCodeFailToSignCSR = 3001,
    BDTGErrorCodeFailToCreateSignature = 3002,

    BDTGErrorCodeNoClientCert = 4000,
    BDTGErrorCodeNoServerData = 4001,
    BDTGErrorCodeNoPrivateKey = 4002,
    BDTGErrorCodeSignClientData = 4003,

    // 无法生成对称加密密钥
    BDTGErrorCodeECDHKeyNoServerCert = 5000,               // 客户端本地没有服务端证书
    BDTGErrorCodeECDHKeyInvalidServerCert = 5001,          // 服务端证书解析失败
    BDTGErrorCodeECDHKeyFailToParseServerPublicKey = 5002, // 无法从服务端证书中解析出公钥
    BDTGErrorCodeECDHKeyFailToCopyServerPublicKey = 5003,  // 获取公钥二进制失败
    BDTGErrorCodeECDHKeyFailToLoadPrivateKey = 5004,       // 客户端本地私钥加载失败
    BDTGErrorCodeECDHKeyFailToExchangeKey = 5005,          // 密钥协商出错
    BDTGErrorCodeECDHKeyHKDFError = 5006,                  // HKDF算法出错

    // 解密失败
    BDTGErrorCodeDecryptInvalidMessageLength = 6000,   // 密文长度非法
    BDTGErrorCodeDecryptInvalidMessageMagic = 6001,    // 密文格式不正确
    BDTGErrorCodeDecryptInvalidDecryptedLength = 6002, // 解密后的明文长度不正确
    BDTGErrorCodeDecryptTimeout = 6003,                // 解密超时
    BDTGErrorCodeDecryptFailToParseString = 6004,      // 字符串转Data失败
};

#endif /* BDTGErrorCode_h */
