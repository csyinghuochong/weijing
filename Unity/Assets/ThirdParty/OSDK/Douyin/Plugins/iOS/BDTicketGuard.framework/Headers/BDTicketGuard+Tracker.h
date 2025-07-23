//
//  BDTicketGuard+Tracker.h
//  BDTicketGuard
//
//  Created by chenzhendong.ok@bytedance.com on 2022/7/13.
//

#import <BDTicketGuard/BDTGDanceKit.h>
#import <BDTicketGuard/BDTicketGuard.h>
#import <BDTicketGuard/BDTGKeyPair.h>

@class BDTGCSRResult;

#define BDTGTrackSDKLaunch [BDTicketGuard trackSDKLaunch]
#define BDTGTrackGetPrivateKey(error, boolIsFromCache, intAttemptCount) [BDTicketGuard trackGetPrivateKeyWithError:error startTimestamp:startTimestamp isFromCache:boolIsFromCache attemptCount:intAttemptCount]
#define BDTGTrackGetPublicKey(error) [BDTicketGuard trackGetPublicKeyWithError:error startTimestamp:startTimestamp]
#define BDTGTrackGetCSRResult(csrResult) [BDTicketGuard trackGetClientCSRWithResult:csrResult]
#define BDTGTrackGetTicket(request, response, intHasLocalClientCert, intHasRemoteClientCert, intHasServerData) [BDTicketGuard trackGetTicketWithRequest:request response:response startTimestamp:startTimestamp hasLocalClientCert:intHasLocalClientCert hasRemoteClientCert:intHasRemoteClientCert hasServerData:intHasServerData]
#define BDTGTrackSignClientData(path, error, intAttemptCount) [BDTicketGuard trackSignClientDataForRequestPath:path error:error startTimestamp:startTimestamp attemptCount:intAttemptCount]
#define BDTGTrackGetCert(params, aError) [BDTicketGuard trackGetCertWithParams:params error:aError startTimestamp:startTimestamp]
#define BDTGTrackDecrypt(aError) [BDTicketGuard trackDecryptWithError:aError startTimestamp:startTimestamp]
#define BDTGTrackKeyCertNotMatch [BDTicketGuard trackKeyCertNotMatch]
#define BDTGTrackAddGetTicketHeaders(aRequest, aError) [BDTicketGuard trackAddGetTicketHeaders:aRequest error:aError startTimestamp:startTimestamp]
#define BDTGTrackAddUseTicketHeaders(aRequest, aError) [BDTicketGuard trackAddUseTicketHeaders:aRequest error:aError startTimestamp:startTimestamp]
#define BDTGTrackCreateSignature(result) [BDTicketGuard trackCreateSignatureResult:result startTimestamp:startTimestamp]

NS_ASSUME_NONNULL_BEGIN


@interface BDTicketGuard (Tracker)

+ (void)trackSDKLaunch;

+ (void)trackGetPrivateKeyWithError:(NSError *_Nullable)error startTimestamp:(NSTimeInterval)startTimestamp isFromCache:(int)isFromCache attemptCount:(int)attemptCount;

+ (void)trackGetPublicKeyWithError:(NSError *_Nullable)error startTimestamp:(NSTimeInterval)startTimestamp;

+ (void)trackGetClientCSRWithResult:(BDTGCSRResult *)result;

+ (void)trackGetTicketWithRequest:(id<BDTGHttpRequest>)request response:(id<BDTGHttpResponse>)response startTimestamp:(NSTimeInterval)startTimestamp hasLocalClientCert:(int)hasLocalClientCert hasRemoteClientCert:(int)hasRemoteClientCert hasServerData:(int)hasServerData;

+ (void)trackSignClientDataForRequestPath:(NSString *_Nullable)path error:(NSError *_Nullable)error startTimestamp:(NSTimeInterval)startTimestamp attemptCount:(int)attemptCount;

+ (void)trackGetCertWithParams:(NSDictionary *)params error:(NSError *)error startTimestamp:(NSTimeInterval)startTimestamp;

+ (void)trackDecryptWithError:(NSError *)error startTimestamp:(NSTimeInterval)startTimestamp;

+ (void)trackKeyCertNotMatch;

+ (void)trackAddGetTicketHeaders:(id<BDTGHttpRequest>)request error:(NSError *_Nullable)error startTimestamp:(NSTimeInterval)startTimestamp;

+ (void)trackAddUseTicketHeaders:(id<BDTGHttpRequest>)request error:(NSError *_Nullable)error startTimestamp:(NSTimeInterval)startTimestamp;

+ (void)trackCreateSignatureResult:(BDTGSignatureResult *)result startTimestamp:(NSTimeInterval)startTimestamp;

@end


@interface BDTicketGuard (TrackerAdapter)


@end

NS_ASSUME_NONNULL_END
