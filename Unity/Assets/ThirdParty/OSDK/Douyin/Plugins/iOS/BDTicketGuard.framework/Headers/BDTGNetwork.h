//
//  BDTGNetwork.h
//  BDTicketGuard
//
//  Created by ByteDance on 2022/12/19.
//

#ifndef BDTGNetwork_h
#define BDTGNetwork_h

@protocol BDTGHttpRequest <NSObject>

@property (nonatomic, strong, readonly, nullable) NSURL *URL;

@property (nonatomic, copy, readonly, nullable) NSDictionary<NSString *, NSString *> *allHTTPHeaderFields;

- (void)setValue:(nullable NSString *)value forHTTPHeaderField:(nonnull NSString *)field;

@end

@protocol BDTGHttpResponse <NSObject>

@property (nonatomic, copy, readonly, nullable) NSString *logId;

@property (nonatomic, copy, readonly, nullable) NSDictionary<NSString *, NSString *> *allHeaderFields;

@end

#endif /* BDTGNetwork_h */
