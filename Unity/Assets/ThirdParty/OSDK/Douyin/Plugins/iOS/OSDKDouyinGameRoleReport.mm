#import <Foundation/Foundation.h>
#import <UnionOpenPlatformDouyin/UOPAuthManager+GameRole.h>
#import "OSDKiOSUtils.h"

typedef void (*OSDKGameRoleReportCallback)();
typedef void (*OSDKGameRoleReportFailCallback)(NSInteger errorCode, const char* errorMsg);

#if defined (__cplusplus)
extern "C" {
#endif

/// 账号绑定
void OSDKGameRoleReport(const char* gameUserID,
                        const char* roleID,
                        const char* roleName,
                        const char* roleLevel,
                        const char* serverID,
                        const char* serverName,
                        const char* avatarUrl,
                        const char* extraJsonString,
                        OSDKGameRoleReportCallback successCallback,
                        OSDKGameRoleReportFailCallback failCallback) {
    NSString *gameUserIDOC = [OSDKiOSUtils stringWithUTF8String:gameUserID];
    UOPGameRole *role = [[UOPGameRole alloc] init];
    role.roleID = [OSDKiOSUtils stringWithUTF8String:roleID];
    role.roleName = [OSDKiOSUtils stringWithUTF8String:roleName];
    role.roleLevel = [OSDKiOSUtils stringWithUTF8String:roleLevel];
    role.serverID = [OSDKiOSUtils stringWithUTF8String:serverID];
    role.serverName = [OSDKiOSUtils stringWithUTF8String:serverName];
    NSString *extraJsonStringOC = [OSDKiOSUtils stringWithUTF8String:extraJsonString];
    role.extra = [OSDKiOSUtils dictionaryWithJSONString:extraJsonStringOC];
    // 原生bug，需要先设置extra再设置avatarUrl
    role.avatarUrl = [OSDKiOSUtils stringWithUTF8String:avatarUrl];

    [[UOPAuthManager sharedInstance] reportGameRole:role gameUserID:gameUserIDOC completion:^(NSError * _Nullable error) {
        if (error) {
            const char* errorMsg = AutonomousStringCopy_initBridge(error.domain.UTF8String);
            NSInteger errorCode = error.code;
            if (failCallback) {
                failCallback(errorCode, errorMsg);
            }
        } else {
            if (successCallback) {
                successCallback();
            }
        }
    }];
}

#if defined (__cplusplus)
}
#endif