//
//  UOPAuthResponse.h
//  UnionOpenPlatform
//
//  Created by ByteDance on 2021/6/18.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface UOPAuthResponse : NSObject
/// OAuth授权所需要的code
@property (nonatomic, copy) NSString *code;

@property (nonatomic, strong) NSError *error;

- (BOOL)isSuccess;

@end

NS_ASSUME_NONNULL_END
