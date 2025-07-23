//
//  BDTrustEnclave+Private.h
//  BDTrustEnclave
//
//  Created by ….ok@bytedance.com on 2022/6/4.
//

#import <Foundation/Foundation.h>
#import <BDTicketGuard/BDTGKeyPair.h>


@interface BDTGPrivateKeyManager : NSObject

@property (nonatomic, copy, readonly, nonnull) NSString *keyType;

@property (nonatomic, assign, readonly) NSInteger isFromCache;
@property (nonatomic, assign, readonly) BOOL hasGenerated;

+ (instancetype _Nonnull)sharedInstance;

- (SecKeyRef _Nullable)privateKeySync;
- (SecKeyRef _Nullable)privateKeyWithTimeout:(NSTimeInterval)timeout;

- (BDTGCSRResult *_Nonnull)csrWithTimeout:(NSTimeInterval)timeout;
- (NSData *_Nullable)publicKeyBitsWithTimeout:(NSTimeInterval)timeout;
- (NSString *_Nullable)publicKeyBase64WithTimeout:(NSTimeInterval)timeout;

- (void)preloadECDHKey;

- (NSData *_Nullable)ecdhKey NS_AVAILABLE_IOS(11.0);
- (NSData *_Nullable)ecdhKey:(NSError *_Nullable *_Nullable)error NS_AVAILABLE_IOS(11.0);

@end
