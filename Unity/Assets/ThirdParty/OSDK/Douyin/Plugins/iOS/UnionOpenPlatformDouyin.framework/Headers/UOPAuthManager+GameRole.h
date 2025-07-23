//
//  UOPAuthManager+GameRole.h
//  UnionOpenPlatformDouyin
//
//  Created by ByteDance on 2023/12/4.
//

#import <UnionOpenPlatformDouyin/UOPAuthManager.h>
#import <UnionOpenPlatformDouyin/UOPGameRole.h>

NS_ASSUME_NONNULL_BEGIN

typedef NS_ENUM(NSInteger, UOPGameRoleCode) {
    /// 成功
    UOPGameRoleCodeSuccess            = 0,
    
    /// Token或者userID为空
    UOPGameRoleCodeTokenOrUIDIsNull   = -10002,
    /// Token失效
    UOPGameRoleCodeTokenInvalid       = -10003,
    /// 服务器错误
    UOPGameRoleCodeServerError        = -10004,
    /// GameUserID为空
    UOPGameRoleCodeGameUserIDIsNull   = -10005,
    /// GameRoleID为空
    UOPGameRoleCodeGameRoleIDIsNull   = -10006
};

/// 角色绑定授权信息
@interface UOPGameRoleBindAuthInfo : NSObject

/// 用户是否同意角色绑定授权
@property (nonatomic, assign) BOOL isBindAuth;

@end


/// 游戏账号和抖音账号绑定能力
@interface UOPAuthManager (GameRole)

/// 上报当前用户角色信息
/// @attention 需要设置 UOPDouyinAuthInfoDelegate 授权代理
/// @param gameRole 当前角色信息
/// @param gameUserID 当前账号ID
/// @param completion 上报结果回调，error为nil即为成功
/// @discussion 上报流程依赖抖音授权信息，未抖音授权的情况会进入抖音授权流程
- (void)reportGameRole:(UOPGameRole *)gameRole
            gameUserID:(NSString *)gameUserID
            completion:(void(^ _Nullable)(NSError * _Nullable error))completion;

@end

NS_ASSUME_NONNULL_END
