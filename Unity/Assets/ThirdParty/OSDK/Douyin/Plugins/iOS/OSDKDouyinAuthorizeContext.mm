#import "OSDKDouyinAuthorizeContext.h"

typedef void(^DouyinAuthInfoCallback)(NSError * _Nonnull error, UOPDouyinAuthInfo * _Nonnull authInfo);

@interface OSDKDouyinAuthorizeContext ()

@property (nonatomic, copy) DouyinAuthInfoCallback getCompletion;
@property (nonatomic, copy) DouyinAuthInfoCallback updateCompletion;

@end

@implementation OSDKDouyinAuthorizeContext

+ (instancetype)shared {
    static OSDKDouyinAuthorizeContext *context = nil;
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        context = [[OSDKDouyinAuthorizeContext alloc] init];
    });
    return context;
}

- (void)onGetAuthInfoToken:(NSString *)token openid:(NSString *)openid errorCode:(NSInteger)code errorMsg:(NSString *)msg {
    if (_getCompletion == nil) {
        return;
    }
    NSError *error = nil;
    UOPDouyinAuthInfo *info = nil;
    if (token.length == 0 || openid.length == 0) {// 错误
        error = [NSError errorWithDomain:msg code:code userInfo:nil];
    } else {
        info = [[UOPDouyinAuthInfo alloc] init];
        info.douyinAccessToken = token;
        info.douyinOpenId = openid;
    }
    _getCompletion(error, info);
    _getCompletion = nil;
    
}

- (void)onUpdateAuthInfoToken:(NSString *)token openid:(NSString *)openid errorCode:(NSInteger)code errorMsg:(NSString *)msg {
    if (_updateCompletion == nil) {
        return;
    }
    NSError *error = nil;
    UOPDouyinAuthInfo *info = nil;
    if (token.length == 0 || openid.length == 0) {// 错误
        error = [NSError errorWithDomain:msg code:code userInfo:nil];
    } else {
        info = [[UOPDouyinAuthInfo alloc] init];
        info.douyinAccessToken = token;
        info.douyinOpenId = openid;
    }
    _updateCompletion(error, info);
    _updateCompletion = nil;
}

#pragma mark - UOPDouyinAuthInfoDelegate
- (void)getDouyinAuthInfo:(void (^ _Nullable)(NSError * _Nonnull error, UOPDouyinAuthInfo * _Nonnull authInfo))completion {
    _getCompletion = completion;
    if (_getAuthInfoAction) {
        _getAuthInfoAction();
    }
}

- (void)updateDouyinAuthInfo:(void (^ _Nullable)(NSError * _Nonnull error, UOPDouyinAuthInfo * _Nonnull authInfo))completion {
    _updateCompletion = completion;
    if (_updateAuthInfoAction) {
        _updateAuthInfoAction();
    }
}

@end
