#import <Foundation/Foundation.h>
#import <UnionOpenPlatformDouyin/UOPAuthManager.h>

NS_ASSUME_NONNULL_BEGIN

@interface OSDKDouyinAuthorizeContext : NSObject
<UOPDouyinAuthInfoDelegate>

@property (nonatomic, copy, nullable) dispatch_block_t getAuthInfoAction;
@property (nonatomic, copy, nullable) dispatch_block_t updateAuthInfoAction;

+ (instancetype)shared;

- (void)onGetAuthInfoToken:(NSString *)token openid:(NSString *)openid errorCode:(NSInteger)code errorMsg:(NSString *)msg;
- (void)onUpdateAuthInfoToken:(NSString *)token openid:(NSString *)openid errorCode:(NSInteger)code errorMsg:(NSString *)msg;

@end

NS_ASSUME_NONNULL_END
