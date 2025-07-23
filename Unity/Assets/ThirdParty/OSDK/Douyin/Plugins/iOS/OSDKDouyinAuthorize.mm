#import <Foundation/Foundation.h>
#import <UnionOpenPlatformDouyin/UOPAuthManager.h>
#import "OSDKiOSUtils.h"
#import "OSDKDouyinAuthorizeContext.h"

typedef void(*OSDKAuthorizeCallback)(NSInteger errorCode, const char* errorMsg, const char* authCode, const char* grantedPermissions);
typedef void(*OSDKAuthorizeEmptyCallback)();

#if defined (__cplusplus)
extern "C" {
#endif

void OSDKAuthorize(const char* scope, OSDKAuthorizeCallback failCallback) {
    if (failCallback == nil) {
        return;
    }
    NSString *scopeOC = [OSDKiOSUtils stringWithUTF8String:scope];
    UOPAuthRequest *req = [[UOPAuthRequest alloc] init];
    NSArray *scopes = [scopeOC componentsSeparatedByString:@","];
    req.permissions = [NSOrderedSet orderedSetWithArray:scopes];
    [[UOPAuthManager sharedInstance] authPlatform:UOPThirdAuthTypeDouyin request:req result:^(UOPAuthResponse * _Nonnull response) {
        const char* grantedPermissions = AutonomousStringCopy_initBridge(scope);
        if (response.isSuccess) {
            const char* authCode = AutonomousStringCopy_initBridge(response.code.UTF8String);
            failCallback(0, NULL, authCode, grantedPermissions);
        } else {
            const char* errorMsg = AutonomousStringCopy_initBridge(response.error.domain.UTF8String);
            failCallback(response.error.code,
                         errorMsg,
                         NULL,
                         grantedPermissions);
        }
    }];
}

void OSDKSetAuthInfoGetCallback(OSDKAuthorizeEmptyCallback callback) {
    OSDKDouyinAuthorizeContext.shared.getAuthInfoAction = ^{
        if (callback) {
            callback();
        }
    };
}

void OSDKSetAuthInfoUpdateCallback(OSDKAuthorizeEmptyCallback callback) {
    OSDKDouyinAuthorizeContext.shared.updateAuthInfoAction = ^{
        if (callback) {
            callback();
        }
    };
}

void OSDKOnGetAuthInfo(const char* token, const char* openid, int code, const char* message) {
    NSString *tokenOC = [OSDKiOSUtils stringWithUTF8String:token];
    NSString *openidOC = [OSDKiOSUtils stringWithUTF8String:openid];
    NSString *messageOC = [OSDKiOSUtils stringWithUTF8String:message];
    [OSDKDouyinAuthorizeContext.shared onGetAuthInfoToken:tokenOC
                                                  openid:openidOC
                                               errorCode:code
                                                errorMsg:messageOC];
}

void OSDKOnUpdateAuthInfo(const char* token, const char* openid, int code, const char* message) {
    NSString *tokenOC = [OSDKiOSUtils stringWithUTF8String:token];
    NSString *openidOC = [OSDKiOSUtils stringWithUTF8String:openid];
    NSString *messageOC = [OSDKiOSUtils stringWithUTF8String:message];
    [OSDKDouyinAuthorizeContext.shared onUpdateAuthInfoToken:tokenOC
                                                     openid:openidOC
                                                  errorCode:code
                                                   errorMsg:messageOC];
}

void OSDKClearAuthInfo() {
    [[UOPAuthManager sharedInstance] clearDouyinAuthInfo];
}
    
#if defined (__cplusplus)
}
#endif

