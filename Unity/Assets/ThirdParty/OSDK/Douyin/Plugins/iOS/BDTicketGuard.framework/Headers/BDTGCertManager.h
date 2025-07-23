//
//  BDTGCertManager.h
//  BDTicketGuard
//
//  Created by ByteDance on 2022/12/19.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN


@interface BDTGCertManager : NSObject

@property (class, nonatomic, copy, readonly, nullable) NSString *clientCert;
@property (class, nonatomic, copy, readonly, nullable) NSString *serverCert;
@property (class, nonatomic, copy, readonly, nullable) NSString *serverCertSN;

+ (void)loadCert;

+ (void)updateClientCert:(NSString *_Nonnull)clientCert;

+ (void)updateClientCert:(NSString *_Nullable)clientCert serverCert:(NSString *_Nullable)serverCert serverCertSN:(NSString *_Nullable)serverCertSN;

+ (void)checkLocalCert;

@end

NS_ASSUME_NONNULL_END
