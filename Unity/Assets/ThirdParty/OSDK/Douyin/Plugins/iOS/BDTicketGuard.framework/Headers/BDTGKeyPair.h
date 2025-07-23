//
//  BDTGKeyPair.h
//  BDTicketGuard
//
//  Created by chenzhendong.ok@bytedance.com on 2022/7/23.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

FOUNDATION_EXPORT NSString *const BDTGKeyTypeTee;
FOUNDATION_EXPORT NSString *const BDTGKeyTypeRee;


@interface BDTGSignatureResult : NSObject

@property (nonatomic, copy, nullable) NSData *signature;
@property (nonatomic, strong, nullable) NSError *error;
@property (nonatomic, assign) int attemptCount;

@end


@interface BDTGCSRResult : NSObject

@property (nonatomic, copy, nullable) NSString *csr;
@property (nonatomic, strong, nullable) NSError *error;
@property (nonatomic, assign) int attemptCount;

@end


@interface BDTGKeyPair : NSObject

+ (SecKeyRef _Nullable)cachedPrivateKeyWithType:(NSString *)type error:(NSError **)error;
+ (SecKeyRef)privateKeyWithType:(NSString *)type error:(NSError **)error;
+ (NSData *_Nullable)publicKeyWithPrivateKey:(SecKeyRef)privateKey error:(NSError **)error;

+ (BDTGSignatureResult *)createSignatureForString:(NSString *)string privateKey:(SecKeyRef)privateKey;
+ (BDTGSignatureResult *)createSignatureForData:(NSData *)fromData privateKey:(SecKeyRef)privateKey;

+ (BDTGCSRResult *)createCSRWithPublicKeyBits:(NSData *)publicKeyBits privateKey:(SecKeyRef)privateKey;

+ (NSData *)ecdhKeyWithServerCert:(NSString *)serverCert clientPrivateKey:(SecKeyRef)privateKey error:(NSError **_Nullable)error NS_AVAILABLE_IOS(11.0);

+ (SecKeyRef)publicKeyWithCert:(NSString *)cert error:(NSError **)error;
+ (NSData *)publicKeyBitsWithPublicKey:(SecKeyRef)publicKey error:(NSError **)error;

@end

NS_ASSUME_NONNULL_END
